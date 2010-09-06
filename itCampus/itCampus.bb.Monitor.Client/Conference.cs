using System;
using itCampus.bb.Common;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten einer Konferenz.
	/// </summary>
	public class Conference
	{
		#region----------------------------- Member Variables -------------------------------------

		// Konferenzverwaltung
		private ConferenceControl _conferenceControl;

		// Parameter
		private string _key;               // GUID
		private ConferenceState _state;    // aktueller Status
		private DateTime _lastStateChange; // Zeitpunkt letzter Statuswechsel
		private string _initiator;         // Initiator
		private int _confereeCount;        // Anzahl Teilnehmer

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Konferenz
		/// </summary>
		public Conference(itCampus.bb.Monitor.Conference conference,
			ConferenceControl conferenceControl)
		{
			// Parameter initialisieren
			_key = conference.Key;

			// Konferenz zu Konferenzverwaltung hinzufügen
			_conferenceControl = conferenceControl;
			_conferenceControl.AddConference(this);

			// Parameter aktualisiern
			RefreshParameters(conference);
		}

		/// <summary>
		/// schließt Konferenz ab
		/// </summary>
		public void Terminate()
		{
			// Konferenz aus Konferenzverwaltung entfernen
			_conferenceControl.RemoveConference(this);
			_conferenceControl = null;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// GUID
		/// </summary>
		public string Key
		{
			get
			{
				return _key;
			}
		}

		/// <summary>
		/// aktueller Status
		/// </summary>
		public ConferenceState State
		{
			get
			{
				return _state;
			}
		}

		/// <summary>
		/// Zeitpunkt letzter Statuswechsel
		/// </summary>
		public DateTime LastStateChange
		{
			get
			{
				return _lastStateChange;
			}
		}

		/// <summary>
		/// Initiator
		/// </summary>
		public string Initiator
		{
			get
			{
				return _initiator;
			}
		}

		/// <summary>
		/// Anzahl Teilnehmer
		/// </summary>
		public int ConfereeCount
		{
			get
			{
				return _confereeCount;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(itCampus.bb.Monitor.Conference conference)
		{
			// Parameter aktualisieren
			_state = conference.State;
			_lastStateChange = conference.LastStateChange;
			_initiator = conference.Initiator;
			_confereeCount = conference.ConfereeCount;

			// Konferenzverwaltung aktualisieren
			_conferenceControl.RefreshConference(this);
		}

		#endregion

		#endregion
	}
}
