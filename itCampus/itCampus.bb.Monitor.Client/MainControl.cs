using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using itCampus.bb.Common;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Hauptklasse zum Steuern des Monitors.
	/// </summary>
	public class MainControl : IDisposable
	{
		#region----------------------------- Member Variables -------------------------------------

		// Objektverwaltung
		private FrontendControl _frontendControl;     // Frontendverwaltung
		private CampaignControl _campaignControl;     // Kampagnenverwaltung
		private ConferenceControl _conferenceControl; // Konferenzverwaltung
		private SiteControl _siteControl;             // Raumverwaltung
		private DeviceControl _deviceControl;         // Deviceverwaltung

		// Schnittstelle zum Dialer
		private Monitor _monitor;

		// aktuelle Coachingparameter
		private string _currentAgentCode;          // Agentencode
		private CoachingMode _currentCoachingMode; // Coachingmodus

		#endregion

		#region----------------------------- Delegates --------------------------------------------

		public delegate void OnAgentLostEventHandler();
		public delegate void OnDeviceTerminatedEventHandler();
		public delegate void OnConnectionLostEventHandler();
		
		#endregion

		#region----------------------------- Events -----------------------------------------------

		// gecoachter Agent verloren
		public event OnAgentLostEventHandler OnAgentLost;

		// Device getrennt
		public event OnDeviceTerminatedEventHandler OnDeviceTerminated;

		// Verbindung zum Dialer verloren
		public event OnConnectionLostEventHandler OnConnectionLost;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Hauptobjekt
		/// </summary>
		public MainControl()
		{
			// Einstellungen initialisieren
			Settings.Initialize();

			// Assembly ermitteln
			Assembly assembly = Assembly.GetAssembly(this.GetType());

			// Protokoll initialisieren
			Logger.Initialize(Tools.GetFileName(assembly), Settings.Instance.LogEnabled,
				Settings.Instance.LogLevel);

			// Programmversion protokollieren
			Logger.Log.Info("[Info] -> " + Tools.GetFileName(assembly) + " " +
				Tools.GetFileVersion(assembly));

			// Einstellungen protokollieren
			Logger.Log.Info("[Info] -> MonitorCode: " + Settings.Instance.MonitorCode +
				", RefreshInterval: " + Settings.Instance.RefreshInterval +
				", ChartHistoryLength: " + Settings.Instance.ChartHistoryLength +
				", DeviceCode: " + Settings.Instance.DeviceCode +
				", CoachingPermissionRequired: " + Settings.Instance.CoachingPermissionRequired +
                ", ScreenMonitoringAllowed: " + Settings.Instance.ScreenMonitoringAllowed +
				", AutoStopCoaching: " + Settings.Instance.AutoStopCoaching +
				", LogEnabled: " + Settings.Instance.LogEnabled +
				", LogLevel: " + Settings.Instance.LogLevel);

			// Objektverwaltung initialisieren
			_frontendControl = new FrontendControl(this);
			_campaignControl = new CampaignControl(this);
			_conferenceControl = new ConferenceControl(this);
			_siteControl = new SiteControl(this);
			_deviceControl = new DeviceControl(this);

			// Schnittstelle zum Dialer initialisieren
			_monitor = new Monitor();
			_monitor.OnAddFrontend += new Monitor.OnAddFrontendEventHandler(
				_monitor_OnAddFrontend);
			_monitor.OnRefreshFrontend += new Monitor.OnRefreshFrontendEventHandler(
				_monitor_OnRefreshFrontend);
			_monitor.OnRemoveFrontend += new Monitor.OnRemoveFrontendEventHandler(
				_monitor_OnRemoveFrontend);
			_monitor.OnAddCampaign += new Monitor.OnAddCampaignEventHandler(
				_monitor_OnAddCampaign);
			_monitor.OnRefreshCampaign += new Monitor.OnRefreshCampaignEventHandler(
				_monitor_OnRefreshCampaign);
			_monitor.OnRemoveCampaign += new Monitor.OnRemoveCampaignEventHandler(
				_monitor_OnRemoveCampaign);
			_monitor.OnAddConference += new Monitor.OnAddConferenceEventHandler(
				_monitor_OnAddConference);
			_monitor.OnRefreshConference += new Monitor.OnRefreshConferenceEventHandler(
				_monitor_OnRefreshConference);
			_monitor.OnRemoveConference += new Monitor.OnRemoveConferenceEventHandler(
				_monitor_OnRemoveConference);
			_monitor.OnAgentLost += new Monitor.OnAgentLostEventHandler(
				_monitor_OnAgentLost);
			_monitor.OnDeviceTerminated += new Monitor.OnDeviceTerminatedEventHandler(
				_monitor_OnDeviceTerminated);
			_monitor.OnConnectionLost += new Monitor.OnConnectionLostEventHandler(
				_monitor_OnConnectionLost);

			// Verbindung zum Dialer herstellen
			MonitorConnect();
			MonitorLogonDialer(Settings.Instance.MonitorCode, Settings.Instance.RefreshInterval);
		}

		/// <summary>
		/// schließt Hauptobjekt ab
		/// </summary>
		public void Dispose()
		{
			// je nach aktuellem Status, Monitor von Dialer abmelden
			switch (_monitor.State)
			{
				case MonitorState.Coaching:
					MonitorStopCoaching();
					goto case MonitorState.Assigned;
				case MonitorState.Assigned:
					MonitorUnassignDevice();
					goto case MonitorState.Started;
				case MonitorState.Started:
					MonitorStopMonitoring();
					goto case MonitorState.Stopped;
				case MonitorState.Stopped:
					MonitorLogoffDialer();
					goto case MonitorState.LoggedOff;
				case MonitorState.LoggedOff:
					MonitorDisconnect();
					break;
			}

			// Schnittstelle zum Dialer freigeben
			_monitor.Dispose();

			// alle Objekte abschließen
			_frontendControl.TerminateAllFrontends();
			_campaignControl.TerminateAllCampaigns();
			_conferenceControl.TerminateAllConferences();
			_siteControl.TerminateAllSites();
			_deviceControl.TerminateAllDevices();

			// Protokoll freigeben
			Logger.Terminate();
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Frontendverwaltung
		/// </summary>
		public FrontendControl FrontendControl
		{
			get
			{
				return _frontendControl;
			}
		}

		/// <summary>
		/// Kampagnenverwaltung
		/// </summary>
		public CampaignControl CampaignControl
		{
			get
			{
				return _campaignControl;
			}
		}

		/// <summary>
		/// Konferenzverwaltung
		/// </summary>
		public ConferenceControl ConferenceControl
		{
			get
			{
				return _conferenceControl;
			}
		}

		/// <summary>
		/// Raumverwaltung
		/// </summary>
		public SiteControl SiteControl
		{
			get
			{
				return _siteControl;
			}
		}

		/// <summary>
		/// Deviceverwaltung
		/// </summary>
		public DeviceControl DeviceControl
		{
			get
			{
				return _deviceControl;
			}
		}

		/// <summary>
		/// aktueller Monitorstatus
		/// </summary>
		public MonitorState MonitorState
		{
			get
			{
				return _monitor.State;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Laden und Speichern Konfiguration --------------------

		/// <summary>
		/// lädt Konfiguration
		/// </summary>
		public void LoadConfig()
		{
			try
			{
				// Pfad für Konfigurationsdatei ermitteln
				string fileName = GetConfigFile();

				// wenn Konfigurationsdatei existiert, Konfiguration laden
				if (File.Exists(fileName))
				{
					LoadConfigFromCSVFile(fileName);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on loading configuration.", ex);
			}
		}

		/// <summary>
		/// speichert Konfiguration
		/// </summary>
		public void SaveConfig()
		{
			try
			{
				// wenn Räume oder Devices vorhanden
				if ((_siteControl.SiteCount > 0) || (_deviceControl.DeviceCount > 0))
				{
					// Pfad für Konfigurationsdatei ermitteln
					string fileName = GetConfigFile();

					// Konfiguration speichern
					SaveConfigToCSVFile(fileName);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on saving configuration.", ex);
			}
		}

		/// <summary>
		/// lädt Konfiguration aus CSV-Datei
		/// </summary>
		private void LoadConfigFromCSVFile(string fileName)
		{
			// Konfigurationsdatei öffnen
			StreamReader reader = new StreamReader(fileName, System.Text.Encoding.Default);

			try
			{
				// Zeilenpuffer initialisieren
				string line = null;

				// Räume einlesen
				while ((line = reader.ReadLine()) != null)
				{
					// Datensatz konvertieren
					string[] dataArray = CSV.GetArrayFromCSV(line);

					// wenn Raumangaben eingelesen, Raum initialisieren
					if (dataArray[0] == "S")
					{
						Site site = new Site(dataArray[1], _siteControl);
						site.RefreshParameters(dataArray[2], dataArray[3]);
					}
				}

				// Datensatzzeiger auf Anfang der Konfigurationsdatei setzen
				reader.BaseStream.Seek(0, SeekOrigin.Begin);

				// Devices einlesen
				while ((line = reader.ReadLine()) != null)
				{
					// Datensatz konvertieren
					string[] dataArray = CSV.GetArrayFromCSV(line);

					// wenn Deviceangaben eingelesen
					if (dataArray[0] == "D")
					{
						// Device initialisieren
						Device device = new Device(dataArray[1], _deviceControl);

						// Raum suchen
						Site site = _siteControl[dataArray[2]];

						// wenn Raum gefunden
						if (site != null)
						{
							// Device zu Raum zuordnen und positionieren
							device.AssignSite(site);
							int x = int.Parse(dataArray[3]);
							int y = int.Parse(dataArray[4]);
							device.Location = new Point(x, y);
						}
					}
				}
			}
			finally
			{
				// Konfigurationsdatei schließen
				reader.Close();
			}
		}

		/// <summary>
		/// speichert Kofiguration in CSV-Datei
		/// </summary>
		private void SaveConfigToCSVFile(string fileName)
		{
			// Konfigurationsdatei öffnen
			StreamWriter writer = new StreamWriter(fileName, false, System.Text.Encoding.Default);

			try
			{
				// alle Räume speichern
				foreach (Site site in _siteControl)
				{
					// Datensatz initialisieren
					string[] dataArray = new string[4];
					dataArray[0] = "S";
					dataArray[1] = site.Code;
					dataArray[2] = site.Name;
					dataArray[3] = site.PictureFile;

					// Datensatz konvertieren und in Datei schreiben
					string line = CSV.GetCSVFromArray(dataArray);
					writer.WriteLine(line);
				}

				// alle Devices speichern
				foreach (Device device in _deviceControl)
				{
					// Datensatz initialisieren
					string[] dataArray = new string[5];
					dataArray[0] = "D";
					dataArray[1] = device.Code;
					dataArray[2] = device.Site != null ? device.Site.Code : "";
					dataArray[3] = device.Site != null ? device.Location.X.ToString() : "";
					dataArray[4] = device.Site != null ? device.Location.Y.ToString() : "";

					// Datensatz konvertieren und in Datei schreiben
					string line = CSV.GetCSVFromArray(dataArray);
					writer.WriteLine(line);
				}
			}
			finally
			{
				// Konfigurationsdatei schließen
				writer.Close();
			}
		}

		/// <summary>
		/// gibt Pfad der Konfigurationsdatei zurück
		/// </summary>
		private string GetConfigFile()
		{
			// Pfad für Konfigurationsdatei ermitteln
			Assembly assembly = Assembly.GetAssembly(this.GetType());
			return Tools.GetConfigPath(assembly) + "\\" + Tools.GetFileName(assembly) + ".dat";
		}

		#endregion

		#region----------------------------- Monitoring -------------------------------------------

		/// <summary>
		/// startet Monitoring in Abhängigkeit von aktuellem Status
		/// </summary>
		public void StartMonitoring()
		{
			// Status prüfen
			if (_monitor.State != MonitorState.Stopped)
			{
				return;
			}

			// Monitoring starten
			MonitorStartMonitoring();
		}

		/// <summary>
		/// stoppt Monitoring in Abhängigkeit von aktuellem Status
		/// </summary>
		public void StopMonitoring()
		{
			// Status prüfen
			if ((_monitor.State != MonitorState.Assigned) &&
				(_monitor.State != MonitorState.Coaching) &&
				(_monitor.State != MonitorState.Started))
			{
				return;
			}

			// je nach aktuellem Status, Monitoring stoppen
			switch (_monitor.State)
			{
				case MonitorState.Coaching:
					MonitorStopCoaching();
					goto case MonitorState.Assigned;
				case MonitorState.Assigned:
					MonitorUnassignDevice();
					goto case MonitorState.Started;
				case MonitorState.Started:
					MonitorStopMonitoring();
					break;
			}
		}

		#endregion

		#region----------------------------- Coaching ---------------------------------------------

		/// <summary>
		/// weist Device zu in Abhängigkeit von aktuellem Status
		/// </summary>
		public void AssignDevice(string deviceCode)
		{
			// Status prüfen
			if (_monitor.State != MonitorState.Started)
			{
				return;
			}

			// Device zuweisen
			MonitorAssignDevice(deviceCode);
		}

		/// <summary>
		/// gibt Device frei in Abhängigkeit von aktuellem Status
		/// </summary>
		public void UnassignDevice()
		{
			// Status prüfen
			if ((_monitor.State != MonitorState.Assigned) &&
				(_monitor.State != MonitorState.Coaching))
			{
				return;
			}

			// je nach aktuellem Status, Coaching beenden und Device freigeben
			switch (_monitor.State)
			{
				case MonitorState.Coaching:
					MonitorStopCoaching();
					goto case MonitorState.Assigned;
				case MonitorState.Assigned:
					MonitorUnassignDevice();
					break;
			}
		}

		/// <summary>
		/// startet Coaching in Abhängigkeit von aktuellem Status
		/// </summary>
		public void StartCoaching(string agentCode, CoachingMode coachingMode)
		{
			// Status prüfen
			if ((_monitor.State != MonitorState.Assigned) &&
				(_monitor.State != MonitorState.Coaching))
			{
				return;
			}

			// je nach aktuellem Status
			switch (_monitor.State)
			{
				case MonitorState.Assigned:
					// Coaching starten
					MonitorStartCoaching(agentCode, coachingMode);
					break;
				case MonitorState.Coaching:
					// Coaching anpassen
					if (agentCode != _currentAgentCode)
					{
						MonitorStopCoaching();
						MonitorStartCoaching(agentCode, coachingMode);
					}
					else if (coachingMode != _currentCoachingMode)
					{
						MonitorChangeCoaching(coachingMode);
					}
					break;
			}

			// Coachingparameter aktualisieren
			_currentAgentCode = agentCode;
			_currentCoachingMode = coachingMode;
		}

		/// <summary>
		/// beendet Coaching in Abhängigkeit von aktuellem Status
		/// </summary>
		public void StopCoaching()
		{
			// Status prüfen
			if (_monitor.State != MonitorState.Coaching)
			{
				return;
			}

			// Coaching beenden
			MonitorStopCoaching();
		}

		#endregion

		#region----------------------------- Steuerung Monitor ------------------------------------

		/// <summary>
		/// stellt Verbindung zum Dialer her
		/// </summary>
		private void MonitorConnect()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [Connect]");

			// Verbindung zum Dialer herstellen
			_monitor.Connect();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [Connect]");
		}

		/// <summary>
		/// trennt Verbindung zum Dialer
		/// </summary>
		private void MonitorDisconnect()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [Disconnect]");

			// Verbindung zum Dialer trennen
			_monitor.Disconnect();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [Disconnect]");
		}

		/// <summary>
		/// meldet Monitor an Dialer an
		/// </summary>
		private void MonitorLogonDialer(string monitorCode, int refreshInterval)
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [LogonDialer] MonitorCode: " + monitorCode +
				", RefreshInterval: " + refreshInterval);

			// Monitor an Dialer anmelden
			_monitor.LogonDialer(monitorCode, refreshInterval);

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [LogonDialer]");
		}

		/// <summary>
		/// meldet Monitor von Dialer ab
		/// </summary>
		private void MonitorLogoffDialer()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [LogoffDialer]");

			// Monitor von Dialer abmelden
			_monitor.LogoffDialer();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [LogoffDialer]");
		}

		/// <summary>
		/// startet Monitoring
		/// </summary>
		private void MonitorStartMonitoring()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [StartMonitoring]");

			// Monitoring starten
			_monitor.StartMonitoring();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [StartMonitoring]");
		}

		/// <summary>
		/// stoppt Monitoring
		/// </summary>
		private void MonitorStopMonitoring()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [StopMonitoring]");

			// Monitoring stoppen
			_monitor.StopMonitoring();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [StopMonitoring]");
		}

		/// <summary>
		/// weist Device zu
		/// </summary>
		private void MonitorAssignDevice(string deviceCode)
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [AssignDevice] DeviceCode: " + deviceCode);

			// Device zuweisen
			_monitor.AssignDevice(deviceCode);

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [AssignDevice]");
		}

		/// <summary>
		/// gibt Device frei
		/// </summary>
		private void MonitorUnassignDevice()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [UnassignDevice]");

			// Device freigeben
			_monitor.UnassignDevice();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [UnassignDevice]");
		}

		/// <summary>
		/// startet Coaching
		/// </summary>
		private void MonitorStartCoaching(string agentCode, CoachingMode coachingMode)
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [StartCoaching] AgentCode: " + agentCode +
				", CoachingMode: " + coachingMode);

			// Coaching starten
			_monitor.StartCoaching(agentCode, coachingMode);

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [StartCoaching]");
		}

		/// <summary>
		/// ändert Coachingmodus
		/// </summary>
		private void MonitorChangeCoaching(CoachingMode coachingMode)
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [ChangeCoaching] CoachingMode: " + coachingMode);

			// Coachingmodus ändern
			_monitor.ChangeCoaching(coachingMode);

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [ChangeCoaching]");
		}

		/// <summary>
		/// beendet Coaching
		/// </summary>
		private void MonitorStopCoaching()
		{
			// Methodenaufruf protokollieren
			Logger.Log.Info("[Monitor] <- [StopCoaching]");

			// Coaching beenden
			_monitor.StopCoaching();

			// Methodenabschluss protokollieren
			Logger.Log.Info("[Monitor] -> [StopCoaching]");
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Monitor ---------------------------

		/// <summary>
		/// initialisiert Frontend
		/// </summary>
		private void _monitor_OnAddFrontend(itCampus.bb.Monitor.Frontend frontend)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnAddFrontend]" +
					" Frontend: Frontend#" + frontend.Key);

				// Frontend initialisieren
				new Frontend(frontend, _frontendControl);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Frontend
		/// </summary>
		private void _monitor_OnRefreshFrontend(itCampus.bb.Monitor.Frontend frontend)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRefreshFrontend]" +
					" Frontend: Frontend#" + frontend.Key);

				// Frontend aktualisieren
				_frontendControl[frontend.Key].RefreshParameters(frontend);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// schließt Frontend ab
		/// </summary>
		private void _monitor_OnRemoveFrontend(itCampus.bb.Monitor.Frontend frontend)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRemoveFrontend]" +
					" Frontend: Frontend#" + frontend.Key);

				// Frontend abschließen
				_frontendControl[frontend.Key].Terminate();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// initialisiert Kampagne
		/// </summary>
		private void _monitor_OnAddCampaign(itCampus.bb.Monitor.Campaign campaign)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnAddCampaign]" +
					" Campaign: Campaign#" + campaign.Key);

				// Kampagne initialisieren
				new Campaign(campaign, _campaignControl);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Kampagne
		/// </summary>
		private void _monitor_OnRefreshCampaign(itCampus.bb.Monitor.Campaign campaign)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRefreshCampaign]" +
					" Campaign: Campaign#" + campaign.Key);

				// Kampagne aktualisieren
				_campaignControl[campaign.Key].RefreshParameters(campaign);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// schließt Kampagne ab
		/// </summary>
		private void _monitor_OnRemoveCampaign(itCampus.bb.Monitor.Campaign campaign)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRemoveCampaign]" +
					" Campaign: Campaign#" + campaign.Key);

				// Kampagne abschließen
				_campaignControl[campaign.Key].Terminate();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// initialisiert Konferenz
		/// </summary>
		private void _monitor_OnAddConference(itCampus.bb.Monitor.Conference conference)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnAddConference]" +
					" Conference: Conference#" + conference.Key);

				// Konferenz initialisieren
				new Conference(conference, _conferenceControl);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Konferenz
		/// </summary>
		private void _monitor_OnRefreshConference(itCampus.bb.Monitor.Conference conference)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRefreshConference]" +
					" Conference: Conference#" + conference.Key);

				// Konferenz aktualisieren
				_conferenceControl[conference.Key].RefreshParameters(conference);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// schließt Konferenz ab
		/// </summary>
		private void _monitor_OnRemoveConference(itCampus.bb.Monitor.Conference conference)
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnRemoveConference]" +
					" Conference: Conference#" + conference.Key);

				// Konferenz abschließen
				_conferenceControl[conference.Key].Terminate();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// behandelt Verlieren des gecoachten Agenten
		/// </summary>
		private void _monitor_OnAgentLost()
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnAgentLost]");

				// Ereignis auslösen
				RaiseOnAgentLost();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// behandelt Trennen des Devices
		/// </summary>
		private void _monitor_OnDeviceTerminated()
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnDeviceTerminated]");

				// Ereignis auslösen
				RaiseOnDeviceTerminated();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		/// <summary>
		/// behandelt Trennen der Verbindung zum Dialer
		/// </summary>
		private void _monitor_OnConnectionLost()
		{
			try
			{
				// Ereignis protokollieren
				Logger.Log.Info("[Monitor] -> [OnConnectionLost]");

				// alle Frontends, Kampagnen und Konferenzen entfernen
				_frontendControl.TerminateAllFrontends();
				_campaignControl.TerminateAllCampaigns();
				_conferenceControl.TerminateAllConferences();

				// Ereignis auslösen
				RaiseOnConnectionLost();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on processing event.", ex);
			}
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnAgentLost aus
		/// </summary>
		private void RaiseOnAgentLost()
		{
			try
			{
				if (OnAgentLost != null)
				{
					OnAgentLost();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnDeviceTerminated aus
		/// </summary>
		private void RaiseOnDeviceTerminated()
		{
			try
			{
				if (OnDeviceTerminated != null)
				{
					OnDeviceTerminated();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnConnectionLost aus
		/// </summary>
		private void RaiseOnConnectionLost()
		{
			try
			{
				if (OnConnectionLost != null)
				{
					OnConnectionLost();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		#endregion

		#endregion
	}
}
