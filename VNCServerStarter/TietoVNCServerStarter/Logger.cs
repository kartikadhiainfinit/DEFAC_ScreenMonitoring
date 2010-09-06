using System;
using log4net;
using log4net.Config;

namespace TietoVNCServerStarter
{
    public class Logger
    {
        #region----------------------------- Member Variables -------------------------------------

        // Protokoll
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Logger));

  


        #endregion

        #region----------------------------- Properties -------------------------------------------

        /// <summary>
        /// Protokoll
        /// </summary>
        public static ILog Log
        {
            get
            {
                if (_logger != null)
                {
                    return _logger;
                }
                else
                {
                    throw new Exception("Log not initialized.");
                }
            }
        }

        #endregion

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

    }
}
