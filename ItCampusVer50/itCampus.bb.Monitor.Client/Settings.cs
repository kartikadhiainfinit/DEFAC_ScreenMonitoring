using System;
using System.IO;
using System.Reflection;
using itCampus.bb.Common;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet Konfigurationsparameter.
	/// </summary>
	public class Settings
	{
		#region----------------------------- Member Variables -------------------------------------

		// INI Parameter
		private string _monitorCode;          // Monitorcode
		private int _refreshInterval;         // Aktualisierungsintervall
		private int _chartHistoryLength;      // max. Chartlänge in Std.
		private string _deviceCode;           // Devicecode
		private int _deviceType;              // Devicetyp
		private int _coachingLevel;           // Freigabeebene Coaching
		private int _coachingPermissionLevel; // Erfordernis Coachingerlaubnis
        private bool _screenMonitoringAllowed;    // Erfordernis Screen Monitoring
		private bool _autoStopCoaching;       // automatisches Coachingende bei Gesprächsende
		private bool _logEnabled;             // Kennzeichen für Protokollierung
		private string _logLevel;             // Protokollebene

		// Instanz der Klasse
		private static Settings _instanceSettings;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// liest Einstellungen ein
		/// </summary>
		private Settings()
		{
			ReadINI();
		}

		/// <summary>
		/// initialisiert Einstellungen
		/// </summary>
		public static void Initialize()
		{
			try
			{
				_instanceSettings = new Settings();
			}
			catch (Exception ex)
			{
				throw new Exception("Error on reading ini file.", ex);
			}
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------
        /// <summary>
        /// Erfordernis Screen Monitoring
        /// </summary>
        public bool ScreenMonitoringAllowed
        {
            get
            {
                return _screenMonitoringAllowed;
            }
        }

		/// <summary>
		/// Instanz von Settings
		/// </summary>
		public static Settings Instance
		{
			get
			{
				// wenn Einstellungen initialisiert, Instanz zurückgeben, sonst Fehler werfen
				if (_instanceSettings != null)
				{
					return _instanceSettings;
				}
				else
				{
					throw new Exception("Settings not initialized.");
				}
			}
		}

		/// <summary>
		/// Monitorcode
		/// </summary>
		public string MonitorCode
		{
			get
			{
				return _monitorCode;
			}
		}

		/// <summary>
		/// Aktualisierungsintervall
		/// </summary>
		public int RefreshInterval
		{
			get
			{
				return _refreshInterval;
			}
		}

		/// <summary>
		/// max. Chartlänge in Std.
		/// </summary>
		public int ChartHistoryLength
		{
			get
			{
				return _chartHistoryLength;
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
		/// Devicetyp
		/// </summary>
		public int DeviceType
		{
			get
			{
				return _deviceType;
			}
		}

		/// <summary>
		/// Freigabeebene Coaching
		/// </summary>
		public int CoachingLevel
		{
			get
			{
				return _coachingLevel;
			}
		}

		/// <summary>
		/// Erfordernis Coachingerlaubnis
		/// </summary>
		public int CoachingPermissionLevel
		{
			get
			{
				return _coachingPermissionLevel;
			}
		}

		/// <summary>
		/// automatisches Coachingende bei Gesprächsende
		/// </summary>
		public bool AutoStopCoaching
		{
			get
			{
				return _autoStopCoaching;
			}
		}

		/// <summary>
		/// Kennzeichen für Protokollierung
		/// </summary>
		public bool LogEnabled
		{
			get
			{
				return _logEnabled;
			}
		}

		/// <summary>
		/// Protokollebene
		/// </summary>
		public string LogLevel
		{
			get
			{
				return _logLevel;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		/// <summary>
		/// liest Parameter aus INI-Datei
		/// </summary>
		private void ReadINI()
		{
			// Pfad für INI-Datei ermitteln
			Assembly assembly = Assembly.GetAssembly(this.GetType());
			string fileName =
				Tools.GetConfigPath(assembly) + "\\" + Tools.GetFileName(assembly) + ".ini";

			// wenn INI-Datei existiert
			if (new FileInfo(fileName).Exists)
			{
				// Parameter einlesen
				_monitorCode = INI.GetINIParamAsString(fileName, "Common", "MonitorCode");
                _screenMonitoringAllowed = INI.GetINIParamAsBoolean(fileName, "Coaching", "ScreenMonitoringAllowed");
				_refreshInterval = INI.GetINIParamAsInt(fileName, "Common", "RefreshInterval");
				_chartHistoryLength =
					INI.GetINIParamAsInt(fileName, "Common", "ChartHistoryLength");
				_deviceCode = INI.GetINIParamAsString(fileName, "Coaching", "DeviceCode");
				_deviceType = INI.GetINIParamAsInt(fileName, "Coaching", "DeviceType");
				_coachingLevel = INI.GetINIParamAsInt(fileName, "Coaching", "CoachingLevel");
				_coachingPermissionLevel =
					INI.GetINIParamAsInt(fileName, "Coaching", "CoachingPermissionLevel");
				_autoStopCoaching =
					INI.GetINIParamAsBoolean(fileName, "Coaching", "AutoStopCoaching");
				_logEnabled = INI.GetINIParamAsBoolean(fileName, "Logging", "LogEnabled");
				_logLevel = INI.GetINIParamAsString(fileName, "Logging", "LogLevel");
			}
			else
			{
				throw new Exception("Ini file " + fileName + " not found.");
			}
		}

		#endregion
	}
}
