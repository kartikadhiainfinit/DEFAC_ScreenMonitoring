using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle Räume.
	/// </summary>
	public class SiteControl : IEnumerable
	{
		#region----------------------------- Member Variables -------------------------------------

		// Hauptobjekt
		private MainControl _mainControl;

		// Raumliste und Index
		private ArrayList _sites = new ArrayList(); 
		private Hashtable _sitesHash = new Hashtable();

		#endregion

		#region----------------------------- Delegates --------------------------------------------
		
		public delegate void SiteEventHandler(Site site);

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// Raum hinzugefügt
		public event SiteEventHandler OnAddSite;

		// Raum aktualisiert
		public event SiteEventHandler OnRefreshSite;

		// Raum entfernt
		public event SiteEventHandler OnRemoveSite;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Raumverwaltung
		/// </summary>
		public SiteControl(MainControl mainControl)
		{
			// Hauptobjekt referenzieren
			_mainControl = mainControl;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Hauptobjekt
		/// </summary>
		public MainControl MainControl
		{
			get
			{
				return _mainControl;
			}
		}

		/// <summary>
		/// Standard-Eigenschaft
		/// </summary>
		public Site this[string code]
		{
			get
			{
				return (Site)_sitesHash[code];
			}
		}

		/// <summary>
		/// Anzahl Räume
		/// </summary>
		public int SiteCount
		{
			get
			{
				return _sites.Count;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Raumverwaltung ---------------------------------------

		/// <summary>
		/// fügt Raum zu Raumliste hinzu
		/// </summary>
		public void AddSite(Site site)
		{
			// Raum zu Liste und Index hinzufügen
			_sites.Add(site);
			_sitesHash.Add(site.Code, site);

			// Ereignis auslösen
			RaiseOnAddSite(site);
		}

		/// <summary>
		/// aktualisiert Raum
		/// </summary>
		public void RefreshSite(Site site)
		{
			// Ereignis auslösen
			RaiseOnRefreshSite(site);
		}

		/// <summary>
		/// entfernt Raum aus Raumliste
		/// </summary>
		public void RemoveSite(Site site)
		{
			// Raum aus Liste und Index entfernen
			_sites.Remove(site);
			_sitesHash.Remove(site.Code);

			// Ereignis auslösen
			RaiseOnRemoveSite(site);
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnAddSite aus
		/// </summary>
		private void RaiseOnAddSite(Site site)
		{
			try
			{
				if (OnAddSite != null)
				{
					OnAddSite(site);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRefreshSite aus
		/// </summary>
		private void RaiseOnRefreshSite(Site site)
		{
			try
			{
				if (OnRefreshSite != null)
				{
					OnRefreshSite(site);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRemoveSite aus
		/// </summary>
		private void RaiseOnRemoveSite(Site site)
		{
			try
			{
				if (OnRemoveSite != null)
				{
					OnRemoveSite(site);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		#endregion

		#region----------------------------- sonstige Methoden ------------------------------------

		/// <summary>
		/// gibt Enumerator der Raumliste zurück
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			return _sites.GetEnumerator();
		}

		/// <summary>
		/// schließt alle Räume ab
		/// </summary>
		public void TerminateAllSites()
		{
			// alle Räume abschließen
			foreach (Site site in (ArrayList)_sites.Clone())
			{
				site.Terminate();
			}
		}

		#endregion

		#endregion

	}
}
