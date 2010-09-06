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
        private string _monitorCode;              // Monitorcode
        private int _refreshInterval;             // Aktualisierungsintervall
        private int _chartHistoryLength;          // max. Chartlänge in Std.
        private string _deviceCode;               // Device-Code
        private bool _coachingPermissionRequired; // Erfordernis Coachingerlaubnis
        private bool _screenMonitoringAllowed;    // Erfordernis Screen Monitoring
        private bool _autoStopCoaching;           // automatisches Coachingende bei Gesprächsende
        private bool _logEnabled;                 // Kennzeichen für Protokollierung
        private string _logLevel;                 // Protokollebene

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
        /// Device-Code
        /// </summary>
        public string DeviceCode
        {
            get
            {
                return _deviceCode;
            }
        }

        /// <summary>
        /// Erfordernis Coachingerlaubnis
        /// </summary>
        public bool CoachingPermissionRequired
        {
            get
            {
                return _coachingPermissionRequired;
            }
        }

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
                _refreshInterval = INI.GetINIParamAsInt(fileName, "Common", "RefreshInterval");
                _chartHistoryLength = INI.GetINIParamAsInt(fileName, "Common", "ChartHistoryLength");
                _deviceCode = INI.GetINIParamAsString(fileName, "Coaching", "DeviceCode");
                _coachingPermissionRequired = INI.GetINIParamAsBoolean(fileName, "Coaching", "CoachingPermissionRequired");
                _screenMonitoringAllowed = INI.GetINIParamAsBoolean(fileName, "Coaching", "ScreenMonitoringAllowed");
                _autoStopCoaching = INI.GetINIParamAsBoolean(fileName, "Coaching", "AutoStopCoaching");
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
