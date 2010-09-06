using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet Kampagnenanmeldungen.
	/// </summary>
	public class CampaignSessionList
	{
		#region----------------------------- Member Variables -------------------------------------

		// Liste aller Kampagnenanmeldungen und Index
		private ArrayList _campaignSessions = new ArrayList();
		private Hashtable _campaignSessionsHash = new Hashtable();

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Liste von Kampagnenanmeldungen
		/// </summary>
		public CampaignSessionList()
		{
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Anzahl Kampagnenanmeldungen
		/// </summary>
		public int Count
		{
			get
			{
				return _campaignSessions.Count;
			}
		}

		/// <summary>
		/// Standard-Eigenschaft
		/// </summary>
		public CampaignSession this[int index]
		{
			get
			{
				return (CampaignSession)_campaignSessions[index];
			}
		}

		/// <summary>
		/// Standard-Eigenschaft
		/// </summary>
		public CampaignSession this[string campaignCode]
		{
			get
			{
				return (CampaignSession)_campaignSessionsHash[campaignCode];
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Verwaltung Kampagnenanmeldungen ----------------------

		/// <summary>
		/// fügt Kampagnenanmeldung zu Liste hinzu
		/// </summary>
		public void AddCampaignSession(CampaignSession campaignSession)
		{
			// Kampagnenanmeldung zu Liste und Index hinzufügen
			_campaignSessions.Add(campaignSession);
			_campaignSessionsHash.Add(campaignSession.CampaignCode, campaignSession);
		}

		/// <summary>
		/// entfernt Kampagnenanmeldung aus Liste
		/// </summary>
		public void RemoveCampaignSession(CampaignSession campaignSession)
		{
			// Kampagne aus Liste und Index entfernen
			_campaignSessions.Remove(campaignSession);
			_campaignSessionsHash.Remove(campaignSession.CampaignCode);
		}

		#endregion

		#endregion
	}
}
