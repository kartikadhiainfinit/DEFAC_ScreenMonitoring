using System;
using System.Resources;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet sprachabhängige Ressourcen des Assemblies.
	/// </summary>
	public class Resources
	{
		#region----------------------------- Member Variables -------------------------------------

		// Ressourcenverwaltung
		private static readonly ResourceManager _resources =
			new ResourceManager(typeof(Resources));

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		/// <summary>
		/// gibt String in der aktuellen Sprache zurück
		/// </summary>
		public static string GetString(string name)
		{
			return _resources.GetString(name);
		}

		#endregion
	}
}
