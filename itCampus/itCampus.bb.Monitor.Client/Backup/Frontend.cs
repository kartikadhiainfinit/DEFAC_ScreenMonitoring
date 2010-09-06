using System;
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
		private string _key;                 // GUID
		private string _remoteAddress;       // IP-Adresse
		private FrontendState _state;        // aktueller Status
		private FrontendState _lastState;    // letzter Status
		private DateTime _lastStateChange;   // Zeitpunkt letzter Statuswechsel
		private string _agentCode;           // Agentencode
		private string _deviceCode;          // Devicecode
		private string _campaignCode;        // Kampagnencode
		private AgentMode _agentMode;        // Agentenmodus
		private bool _coachingPermission;    // Kennzeichen für Coachingerlaubnis
		private string _monitorCode;         // Monitorcode bei laufendem Coaching
		private CoachingMode _coachingMode;  // aktueller Coachingmodus
		private int[] _agentStateTimeAvgTtl; // Durchschnittszeit je Status
		private int[] _agentStateTimeTtl;    // Gesamtzeit je Status

		// Device
		private Device _device;

		// Kampagne
		private Campaign _campaign;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontend
		/// </summary>
		public Frontend(itCampus.bb.Monitor.Frontend frontend, FrontendControl frontendControl)
		{
			// Parameter initialisieren
			_key = frontend.Key;
			_agentStateTimeAvgTtl = new int[9];
			_agentStateTimeTtl = new int[9];

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
			// wenn Kampagne zugeordnet, freigeben
			if (_campaign != null)
			{
				_campaign.RemoveFrontend(this);
				_campaign = null;
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
		/// Kampagnencode
		/// </summary>
		public string CampaignCode
		{
			get
			{
				return _campaignCode;
			}
		}

		/// <summary>
		/// Kampagnenname
		/// </summary>
		public string CampaignName
		{
			get
			{
				return (_campaign != null) && (_campaign.Name != "") ?
					_campaign.Name : _campaignCode;
			}
		}

		/// <summary>
		/// Agentenmodus
		/// </summary>
		public AgentMode AgentMode
		{
			get
			{
				return _agentMode;
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
			_campaignCode = frontend.CampaignCode;
			_agentMode = frontend.AgentMode;
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

			// wenn Kampagne zugeordnet
			if (_campaign != null)
			{
				// wenn Kampagnencode nicht übereinstimmt, Kampagne freigeben
				if (_campaign.Code != _campaignCode)
				{
					UnassignCampaign();
				}
			}

			// wenn keine Kampagne zugeordnet
			if (_campaign == null)
			{
				// wenn Kampagnencode angegeben
				if (_campaignCode != "")
				{
					// Kampagnenverwaltung referenzieren
					CampaignControl campaignControl = _frontendControl.MainControl.CampaignControl;

					// Kampagne suchen
					Campaign campaign = campaignControl.GetCampaign(_campaignCode);

					// wenn Kampagne gefunden, zuordnen
					if (campaign != null)
					{
						AssignCampaign(campaign);
					}
				}
			}

			// Frontendverwaltung aktualisieren
			_frontendControl.RefreshFrontend(this);
		}

		#endregion

		#region----------------------------- Frontendsteuerung ------------------------------------

		/// <summary>
		/// weist Kampagne zu
		/// </summary>
		public void AssignCampaign(Campaign campaign)
		{
			// Kampagne zuweisen
			_campaign = campaign;
			_campaign.AddFrontend(this);

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
		public void RefreshCampaign()
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
		public void UnassignCampaign()
		{
			// Kampagne freigeben
			_campaign.RemoveFrontend(this);
			_campaign = null;

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
