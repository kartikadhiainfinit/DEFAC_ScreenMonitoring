using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle R�ume.
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

		// Raum hinzugef�gt
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
		/// Anzahl R�ume
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
		/// f�gt Raum zu Raumliste hinzu
		/// </summary>
		public void AddSite(Site site)
		{
			// Raum zu Liste und Index hinzuf�gen
			_sites.Add(site);
			_sitesHash.Add(site.Code, site);

			// Ereignis ausl�sen
			RaiseOnAddSite(site);
		}

		/// <summary>
		/// aktualisiert Raum
		/// </summary>
		public void RefreshSite(Site site)
		{
			// Ereignis ausl�sen
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

			// Ereignis ausl�sen
			RaiseOnRemoveSite(site);
		}

		#endregion

		#region----------------------------- Ausl�sen von Ereignissen -----------------------------

		/// <summary>
		/// l�st Ereignis OnAddSite aus
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
		/// l�st Ereignis OnRefreshSite aus
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
		/// l�st Ereignis OnRemoveSite aus
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
		/// gibt Enumerator der Raumliste zur�ck
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			return _sites.GetEnumerator();
		}

		/// <summary>
		/// schlie�t alle R�ume ab
		/// </summary>
		public void TerminateAllSites()
		{
			// alle R�ume abschlie�en
			foreach (Site site in (ArrayList)_sites.Clone())
			{
				site.Terminate();
			}
		}

		#endregion

		#endregion

	}
}
