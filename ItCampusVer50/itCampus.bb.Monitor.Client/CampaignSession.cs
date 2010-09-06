using System;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten einer Kampagnenanmeldung.
	/// </summary>
	public class CampaignSession
	{
		#region----------------------------- Member Variables -------------------------------------

		// Parameter
		private string _campaignCode; // Kampagnencode
		private AgentMode _agentMode; // Agentenmodus
		private int _agentPriority;   // Agentenpriorität

		// Kampagne
		private Campaign _campaign;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenanmeldung
		/// </summary>
		public CampaignSession(string campaignCode, AgentMode agentMode, int agentPriority)
		{
			// Parameter initialisieren
			_campaignCode = campaignCode;
			_agentMode = agentMode;
			_agentPriority = agentPriority;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Kampagnencode
		/// </summary>
		public string CampaignCode
		{
			get
			{
				return _campaignCode;
			}
		}

		/// <summary>
		/// Anzeigename der Kampagne
		/// </summary>
		public string CampaignDisplayName
		{
			get
			{
				return _campaign != null ? _campaign.DisplayName : _campaignCode;
			}
		}

		/// <summary>
		/// Agentenmodus
		/// </summary>
		public AgentMode AgentMode
		{
			get
			{
				return _agentMode;
			}
		}

		/// <summary>
		/// Agentenpriorität
		/// </summary>
		public int AgentPriority
		{
			get
			{
				return _agentPriority;
			}
		}

		/// <summary>
		/// Kampagne
		/// </summary>
		public Campaign Campaign
		{
			get
			{
				return _campaign;
			}
			set
			{
				_campaign = value;
			}
		}

		#endregion
	}
}
