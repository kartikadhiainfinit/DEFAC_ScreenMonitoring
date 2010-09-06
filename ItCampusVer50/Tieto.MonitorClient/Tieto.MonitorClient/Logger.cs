using System;
using itCampus.bb.Log;

namespace Tieto.MonitorClient
{
    class Logger
    {
        #region----------------------------- Member Variables -------------------------------------

        // Protokoll
        private static itCampus.bb.Log.Log _log;

        #endregion

        #region----------------------------- Properties -------------------------------------------

        /// <summary>
        /// Protokoll
        /// </summary>
        public static itCampus.bb.Log.Log Log
        {
            get
            {
                if (_log != null)
                {
                    return _log;
                }
                else
                {
                    throw new Exception("Log not initialized.");
                }
            }
        }

        #endregion

        #region----------------------------- Methods ----------------------------------------------

        /// <summary>
        /// initialisiert Protokoll
        /// </summary>		
        public static void Initialize(string moduleName, bool logEnabled, string logLevel)
        {
            _log = new itCampus.bb.Log.Log(moduleName, logEnabled, logLevel);
        }

        /// <summary>
        /// gibt Protokoll frei
        /// </summary>
        public static void Terminate()
        {
            if (_log != null)
            {
                _log.Dispose();
            }
        }

        #endregion
    }
}
