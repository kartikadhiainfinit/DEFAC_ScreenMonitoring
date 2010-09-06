using System;
using System.Collections;
using itCampus.bb.Common;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten eines Frontends.
	/// </summary>
	public class Frontend
	{
		#region----------------------------- Member Variables -------------------------------------

		// Frontendverwaltung
		private FrontendControl _frontendControl;

		// Parameter
		private string _key;                           // GUID
		private string _remoteAddress;                 // IP-Adresse
		private FrontendState _state;                  // aktueller Status
		private FrontendState _lastState;              // letzter Status
		private DateTime _lastStateChange;             // Zeitpunkt letzter Statuswechsel
		private string _agentCode;                     // Agentencode
		private string _deviceCode;                    // Devicecode
		private DeviceMode _deviceMode;                // Devicemodus
		private DeviceState _deviceState;              // Devicestatus
		private DateTime _lastDeviceStateChange;       // Zeitpunkt letzter Devicestatuswechsel
		private string _extension;                     // Durchwahl
		private int _extensionQueueSize;               // Anzahl wartender Anrufe auf Nebenstelle
		private AutoRecording _autoRecording;          // automatische Aufnahme
		private CampaignSessionList _campaignSessions; // Liste bestehender Kampagnenanmeldungen
		private bool _coachingPermission;              // Kennzeichen für Coachingerlaubnis
		private string _monitorCode;                   // Monitorcode bei laufendem Coaching
		private CoachingMode _coachingMode;            // aktueller Coachingmodus
		private int[] _agentStateTimeAvgTtl;           // Durchschnittszeit je Status
		private int[] _agentStateTimeTtl;              // Gesamtzeit je Status

		// Device
		private Device _device;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontend
		/// </summary>
		public Frontend(itCampus.bb.Monitor.Frontend frontend, FrontendControl frontendControl)
		{
			// Parameter initialisieren
			_key = frontend.Key;
			_campaignSessions = new CampaignSessionList();
			_agentStateTimeAvgTtl = new int[10];
			_agentStateTimeTtl = new int[10];

			// Frontend zu Frontendverwaltung hinzufügen
			_frontendControl = frontendControl;
			_frontendControl.AddFrontend(this);

			// Parameter aktualisieren
			RefreshParameters(frontend);
		}

		/// <summary>
		/// schließt Frontend ab
		/// </summary>
		public void Terminate()
		{
			// alle zugeordneten Kampagnen freigeben
			for (int i = 0; i < _campaignSessions.Count; i++)
			{
				// Kampagnenanmeldung referenzieren
				CampaignSession campaignSession = _campaignSessions[i];

				// wenn Kampagne zugeordnet, freigeben
				if (campaignSession.Campaign != null)
				{
					campaignSession.Campaign.RemoveFrontend(this);
					campaignSession.Campaign = null;
				}
			}

			// wenn Device zugeordnet, freigeben
			if (_device != null)
			{
				_device.UnassignFrontend();
				_device = null;
			}

			// Frontend aus Frontendverwaltung entfernen
			_frontendControl.RemoveFrontend(this);
			_frontendControl = null;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// GUID
		/// </summary>
		public string Key
		{
			get
			{
				return _key;
			}
		}

		/// <summary>
		/// IP-Adresse
		/// </summary>
		public string RemoteAddress
		{
			get
			{
				return _remoteAddress;
			}
		}

		/// <summary>
		/// aktueller Status
		/// </summary>
		public FrontendState State
		{
			get
			{
				return _state;
			}
		}

		/// <summary>
		/// letzter Status
		/// </summary>
		public FrontendState LastState
		{
			get
			{
				return _lastState;
			}
		}

		/// <summary>
		/// Zeitpunkt letzter Statuswechsel
		/// </summary>
		public DateTime LastStateChange
		{
			get
			{
				return _lastStateChange;
			}
		}

		/// <summary>
		/// Agentencode
		/// </summary>
		public string AgentCode
		{
			get
			{
				return _agentCode;
			}
		}

		/// <summary>
		/// Devicecode
		/// </summary>
		public string DeviceCode
		{
			get
			{
				return _deviceCode;
			}
		}

		/// <summary>
		/// Devicemodus
		/// </summary>
		public DeviceMode DeviceMode
		{
			get
			{
				return _deviceMode;
			}
		}

		/// <summary>
		/// Devicestatus
		/// </summary>
		public DeviceState DeviceState
		{
			get
			{
				return _deviceState;
			}
		}

		/// <summary>
		/// Zeitpunkt letzter Devicestatuswechsel
		/// </summary>
		public DateTime LastDeviceStateChange
		{
			get
			{
				return _lastDeviceStateChange;
			}
		}

		/// <summary>
		/// Durchwahl
		/// </summary>
		public string Extension
		{
			get
			{
				return _extension;
			}
		}

		/// <summary>
		/// Anzahl wartender Anrufe auf Nebenstelle
		/// </summary>
		public int ExtensionQueueSize
		{
			get
			{
				return _extensionQueueSize;
			}
		}

		/// <summary>
		/// automatische Aufnahme
		/// </summary>
		public AutoRecording AutoRecording
		{
			get
			{
				return _autoRecording;
			}
		}

		/// <summary>
		/// Liste bestehender Kampagnenanmeldungen
		/// </summary>
		public CampaignSessionList CampaignSessions
		{
			get
			{
				return _campaignSessions;
			}
		}

		/// <summary>
		/// Kennzeichen für Coachingerlaubnis
		/// </summary>
		public bool CoachingPermission
		{
			get
			{
				return _coachingPermission;
			}
		}

		/// <summary>
		/// Monitorcode bei laufendem Coaching
		/// </summary>
		public string MonitorCode
		{
			get
			{
				return _monitorCode;
			}
		}

		/// <summary>
		/// aktueller Coachingmodus
		/// </summary>
		public CoachingMode CoachingMode
		{
			get
			{
				return _coachingMode;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Statistik --------------------------------------------

		/// <summary>
		/// gibt Durchschnittszeit für angegebenen Status zurück
		/// </summary>
		public int GetAgentStateTimeAvgTtl(AgentState agentState)
		{
			return _agentStateTimeAvgTtl[(int)agentState];
		}

		/// <summary>
		/// gibt Gesamtzeit für angegebenen Status zurück
		/// </summary>
		public int GetAgentStateTimeTtl(AgentState agentState)
		{
			return _agentStateTimeTtl[(int)agentState];
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(itCampus.bb.Monitor.Frontend frontend)
		{
			// Parameter aktualisieren
			_remoteAddress = frontend.RemoteAddress;
			_lastState = _state;
			_state = frontend.State;
			_lastStateChange = frontend.LastStateChange;
			_agentCode = frontend.AgentCode;
			_deviceCode = frontend.DeviceCode;
			_deviceMode = frontend.DeviceMode;
			_deviceState = frontend.DeviceState;
			_lastDeviceStateChange = frontend.LastDeviceStateChange;
			_extension = frontend.Extension;
			_extensionQueueSize = frontend.ExtensionQueueSize;
			_autoRecording = frontend.AutoRecording;
			_coachingPermission = frontend.CoachingPermission;
			_monitorCode = frontend.MonitorCode;
			_coachingMode = frontend.CoachingMode;
			foreach (AgentState agentState in Enum.GetValues(typeof(AgentState)))
			{
				_agentStateTimeAvgTtl[(int)agentState] =
					frontend.GetAgentStateTimeAvgTtl(agentState);
			}
			foreach (AgentState agentState in Enum.GetValues(typeof(AgentState)))
			{
				_agentStateTimeTtl[(int)agentState] =
					frontend.GetAgentStateTimeTtl(agentState);
			}

			// Kampagnenanmeldungen aktualisieren
			RefreshCampaignSessions(frontend.CampaignSessions);

			// wenn Device zugeordnet
			if (_device != null)
			{
				// wenn Devicecode übereinstimmt
				if (_device.Code == _deviceCode)
				{
					// Device aktualisieren
					_device.RefreshFrontend();
				}
				else
				{
					// sonst Device freigeben
					_device.UnassignFrontend();
					_device = null;
				}
			}

			// wenn kein Device zugeordnet
			if (_device == null)
			{
				// wenn Devicecode angegeben
				if (_deviceCode != "")
				{
					// Deviceverwaltung referenzieren
					DeviceControl deviceControl = _frontendControl.MainControl.DeviceControl;

					// Device suchen
					_device = deviceControl[_deviceCode];

					// wenn Device nicht gefunden, erzeugen
					if (_device == null)
					{
						_device = new Device(_deviceCode, deviceControl);
					}

					// Device zuordnen
					_device.AssignFrontend(this);
				}
			}

			// Frontendverwaltung aktualisieren
			_frontendControl.RefreshFrontend(this);
		}

		/// <summary>
		/// aktualisiert Kampagnenanmeldungen
		/// </summary>
		private void RefreshCampaignSessions(
			itCampus.bb.Monitor.CampaignSessionList campaignSessions)
		{
			// Kampagnenanmeldungen abgleichen
			for (int i = 0; i < campaignSessions.Count; i++)
			{
				// Parameter für aktuelle Kampagnenanmeldung ermitteln
				string campaignCode = campaignSessions[i].CampaignCode;
				AgentMode agentMode = campaignSessions[i].AgentMode;
				int agentPriority = campaignSessions[i].AgentPriority;

				// Kampagnenanmeldung an aktueller Position ermitteln
				CampaignSession campaignSession = GetCampaignSession(i);

				// solange Kampagnenanmeldung an aktueller Position vorhanden und veraltet
				while ((campaignSession != null) &&
					((campaignSession.CampaignCode != campaignCode) ||
					(campaignSession.AgentMode != agentMode) ||
					(campaignSession.AgentPriority != agentPriority)))
				{
					// wenn Kampagne zugeordnet, freigeben
					if (campaignSession.Campaign != null)
					{
						UnassignCampaign(campaignSession.Campaign);
					}

					// Kampagnenanmeldung entfernen
					_campaignSessions.RemoveCampaignSession(campaignSession);

					// nächste Kampagnenanmeldung ermitteln
					campaignSession = GetCampaignSession(i);
				}

				// wenn keine Kampagnenanmeldung mit übereinstimmenden Parametern gefunden
				if (campaignSession == null)
				{
					// neue Kampagnenanmeldung initialisieren
					campaignSession = new CampaignSession(campaignCode, agentMode, agentPriority);

					// Kampagnenanmeldung zu Liste hinzufügen
					_campaignSessions.AddCampaignSession(campaignSession);

					// Kampagne suchen
					Campaign campaign = _frontendControl.MainControl.CampaignControl.GetCampaign(
						campaignCode);

					// wenn Kampagne gefunden, zuordnen
					if (campaign != null)
					{
						AssignCampaign(campaign);
					}
				}
			}

			// alle übrigen Kampagnenanmeldungen entfernen
			while (_campaignSessions.Count > campaignSessions.Count)
			{
				// nächste Kampagnenanmeldung ermitteln
				CampaignSession campaignSession = GetCampaignSession(campaignSessions.Count);

				// wenn Kampagne zugeordnet, freigeben
				if (campaignSession.Campaign != null)
				{
					UnassignCampaign(campaignSession.Campaign);
				}

				// Kampagnenanmeldung entfernen
				_campaignSessions.RemoveCampaignSession(campaignSession);
			}
		}

		/// <summary>
		/// gibt Referenz auf Kampagnenanmeldung zurück, sofern vorhanden
		/// </summary>
		private CampaignSession GetCampaignSession(int index)
		{
			// Kampagnenanmeldung an angegebener Position ermitteln und zurückgeben
			return index < _campaignSessions.Count ? _campaignSessions[index] : null;
		}

		#endregion

		#region----------------------------- Frontendsteuerung ------------------------------------

		/// <summary>
		/// weist Kampagne zu
		/// </summary>
		public void AssignCampaign(Campaign campaign)
		{
			// Kampagnenanmeldung ermitteln
			CampaignSession campaignSession = _campaignSessions[campaign.Code];

			// Kampagne zuweisen
			campaignSession.Campaign = campaign;
			campaignSession.Campaign.AddFrontend(this);

			// Frontendverwaltung aktualisieren
			_frontendControl.RefreshFrontend(this);

			// wenn Device zugeordnet, aktualisieren
			if (_device != null)
			{
				_device.RefreshFrontend();
			}
		}

		/// <summary>
		/// aktualisiert Kampagne
		/// </summary>
		public void RefreshCampaign(Campaign campaign)
		{
			// Frontendverwaltung aktualisieren
			_frontendControl.RefreshFrontend(this);

			// wenn Device zugeordnet, aktualisieren
			if (_device != null)
			{
				_device.RefreshFrontend();
			}
		}

		/// <summary>
		/// hebt Kampagnenzuweisung auf
		/// </summary>
		public void UnassignCampaign(Campaign campaign)
		{
			// Kampagnenanmeldung ermitteln
			CampaignSession campaignSession = _campaignSessions[campaign.Code];

			// Kampagne freigeben
			campaignSession.Campaign.RemoveFrontend(this);
			campaignSession.Campaign = null;

			// Frontendverwaltung aktualisieren
			_frontendControl.RefreshFrontend(this);

			// wenn Device zugeordnet, aktualisieren
			if (_device != null)
			{
				_device.RefreshFrontend();
			}
		}

		#endregion

		#endregion
	}
}
