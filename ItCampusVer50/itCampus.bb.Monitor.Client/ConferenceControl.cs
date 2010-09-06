using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle Konferenzen.
	/// </summary>
	public class ConferenceControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Hauptobjekt
		private MainControl _mainControl;

		// Konferenzliste und Index
		private ArrayList _conferences = new ArrayList(); 
		private Hashtable _conferencesHash = new Hashtable();

		#endregion

		#region----------------------------- Delegates --------------------------------------------
		
		public delegate void ConferenceEventHandler(Conference conference);

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// Konferenz hinzugefügt
		public event ConferenceEventHandler OnAddConference;

		// Konferenz aktualisiert
		public event ConferenceEventHandler OnRefreshConference;

		// Konferenz entfernt
		public event ConferenceEventHandler OnRemoveConference;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Konferenzverwaltung
		/// </summary>
		public ConferenceControl(MainControl mainControl)
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
		public Conference this[string key]
		{
			get
			{
				return (Conference)_conferencesHash[key];
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Konferenzverwaltung ----------------------------------

		/// <summary>
		/// fügt Konferenz zu Konferenzliste hinzu
		/// </summary>
		public void AddConference(Conference conference)
		{
			// Konferenz zu Liste und Index hinzufügen
			_conferences.Add(conference);
			_conferencesHash.Add(conference.Key, conference);

			// Ereignis auslösen
			RaiseOnAddConference(conference);
		}

		/// <summary>
		/// aktualisiert Konferenz
		/// </summary>
		public void RefreshConference(Conference conference)
		{
			// Ereignis auslösen
			RaiseOnRefreshConference(conference);
		}

		/// <summary>
		/// entfernt Konferenz aus Konferenzliste
		/// </summary>
		public void RemoveConference(Conference conference)
		{
			// Konferenz aus Liste und Index entfernen
			_conferences.Remove(conference);
			_conferencesHash.Remove(conference.Key);

			// Ereignis auslösen
			RaiseOnRemoveConference(conference);
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnAddConference aus
		/// </summary>
		private void RaiseOnAddConference(Conference conference)
		{
			try
			{
				if (OnAddConference != null)
				{
					OnAddConference(conference);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRefreshConference aus
		/// </summary>
		private void RaiseOnRefreshConference(Conference conference)
		{
			try
			{
				if (OnRefreshConference != null)
				{
					OnRefreshConference(conference);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRemoveConference aus
		/// </summary>
		private void RaiseOnRemoveConference(Conference conference)
		{
			try
			{
				if (OnRemoveConference != null)
				{
					OnRemoveConference(conference);
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
		/// schließt alle Konferenzen ab
		/// </summary>
		public void TerminateAllConferences()
		{
			// alle Konferenzen abschließen
			foreach (Conference conference in (ArrayList)_conferences.Clone())
			{
				conference.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
