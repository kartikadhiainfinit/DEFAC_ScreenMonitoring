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

		// Konferenz hinzugef�gt
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
		/// f�gt Konferenz zu Konferenzliste hinzu
		/// </summary>
		public void AddConference(Conference conference)
		{
			// Konferenz zu Liste und Index hinzuf�gen
			_conferences.Add(conference);
			_conferencesHash.Add(conference.Key, conference);

			// Ereignis ausl�sen
			RaiseOnAddConference(conference);
		}

		/// <summary>
		/// aktualisiert Konferenz
		/// </summary>
		public void RefreshConference(Conference conference)
		{
			// Ereignis ausl�sen
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

			// Ereignis ausl�sen
			RaiseOnRemoveConference(conference);
		}

		#endregion

		#region----------------------------- Ausl�sen von Ereignissen -----------------------------

		/// <summary>
		/// l�st Ereignis OnAddConference aus
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
		/// l�st Ereignis OnRefreshConference aus
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
		/// l�st Ereignis OnRemoveConference aus
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
		/// schlie�t alle Konferenzen ab
		/// </summary>
		public void TerminateAllConferences()
		{
			// alle Konferenzen abschlie�en
			foreach (Conference conference in (ArrayList)_conferences.Clone())
			{
				conference.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
