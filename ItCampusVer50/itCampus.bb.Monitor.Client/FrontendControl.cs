using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle Frontends.
	/// </summary>
	public class FrontendControl : IEnumerable
	{
		#region----------------------------- Member Variables -------------------------------------

		// Hauptobjekt
		private MainControl _mainControl;

		// Frontendliste und Index
		private ArrayList _frontends = new ArrayList(); 
		private Hashtable _frontendsHash = new Hashtable();

		#endregion

		#region----------------------------- Delegates --------------------------------------------
		
		public delegate void FrontendEventHandler(Frontend frontend);

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// Frontend hinzugefügt
		public event FrontendEventHandler OnAddFrontend;

		// Frontend aktualisiert
		public event FrontendEventHandler OnRefreshFrontend;

		// Frontend entfernt
		public event FrontendEventHandler OnRemoveFrontend;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontendverwaltung
		/// </summary>
		public FrontendControl(MainControl mainControl)
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
		public Frontend this[string key]
		{
			get
			{
				return (Frontend)_frontendsHash[key];
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Frontendverwaltung -----------------------------------

		/// <summary>
		/// fügt Frontend zu Frontendliste hinzu
		/// </summary>
		public void AddFrontend(Frontend frontend)
		{
			// Frontend zu Liste und Index hinzufügen
			_frontends.Add(frontend);
			_frontendsHash.Add(frontend.Key, frontend);

			// Ereignis auslösen
			RaiseOnAddFrontend(frontend);
		}

		/// <summary>
		/// aktualisiert Frontend
		/// </summary>
		public void RefreshFrontend(Frontend frontend)
		{
			// Ereignis auslösen
			RaiseOnRefreshFrontend(frontend);
		}

		/// <summary>
		/// entfernt Frontend aus Frontendliste
		/// </summary>
		public void RemoveFrontend(Frontend frontend)
		{
			// Frontend aus Liste und Index entfernen
			_frontends.Remove(frontend);
			_frontendsHash.Remove(frontend.Key);

			// Ereignis auslösen
			RaiseOnRemoveFrontend(frontend);
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnAddFrontend aus
		/// </summary>
		private void RaiseOnAddFrontend(Frontend frontend)
		{
			try
			{
				if (OnAddFrontend != null)
				{
					OnAddFrontend(frontend);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRefreshFrontend aus
		/// </summary>
		private void RaiseOnRefreshFrontend(Frontend frontend)
		{
			try
			{
				if (OnRefreshFrontend != null)
				{
					OnRefreshFrontend(frontend);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRemoveFrontend aus
		/// </summary>
		private void RaiseOnRemoveFrontend(Frontend frontend)
		{
			try
			{
				if (OnRemoveFrontend != null)
				{
					OnRemoveFrontend(frontend);
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
		/// gibt Enumerator der Frontendliste zurück
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			return _frontends.GetEnumerator();
		}

		/// <summary>
		/// schließt alle Frontends ab
		/// </summary>
		public void TerminateAllFrontends()
		{
			// alle Frontends abschließen
			foreach (Frontend frontend in (ArrayList)_frontends.Clone())
			{
				frontend.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
