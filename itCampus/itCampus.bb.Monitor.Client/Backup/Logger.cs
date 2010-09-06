using System;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Protokollklasse.
	/// </summary>
	public class Logger
	{
		#region----------------------------- Member Variables -------------------------------------
		
		// Protokoll
		private static Log.Log _log;

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Protokoll
		/// </summary>
		public static Log.Log Log
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
			_log = new Log.Log(moduleName, logEnabled, logLevel);
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
