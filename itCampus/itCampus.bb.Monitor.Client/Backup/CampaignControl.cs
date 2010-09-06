using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle Kampagnen.
	/// </summary>
	public class CampaignControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Hauptobjekt
		private MainControl _mainControl;

		// Kampagnenliste und Index
		private ArrayList _campaigns = new ArrayList(); 
		private Hashtable _campaignsHash = new Hashtable();

		#endregion

		#region----------------------------- Delegates --------------------------------------------
		
		public delegate void CampaignEventHandler(Campaign campaign);

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// Kampagne hinzugef�gt
		public event CampaignEventHandler OnAddCampaign;

		// Kampagne aktualisiert
		public event CampaignEventHandler OnRefreshCampaign;

		// Kampagne entfernt
		public event CampaignEventHandler OnRemoveCampaign;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenverwaltung
		/// </summary>
		public CampaignControl(MainControl mainControl)
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
		public Campaign this[string key]
		{
			get
			{
				return (Campaign)_campaignsHash[key];
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Kampagnenverwaltung ----------------------------------

		/// <summary>
		/// f�gt Kampagne zu Kampagnenliste hinzu
		/// </summary>
		public void AddCampaign(Campaign campaign)
		{
			// Kampagne zu Liste und Index hinzuf�gen
			_campaigns.Add(campaign);
			_campaignsHash.Add(campaign.Key, campaign);

			// Ereignis ausl�sen
			RaiseOnAddCampaign(campaign);
		}

		/// <summary>
		/// aktualisiert Kampagne
		/// </summary>
		public void RefreshCampaign(Campaign campaign)
		{
			// Ereignis ausl�sen
			RaiseOnRefreshCampaign(campaign);
		}

		/// <summary>
		/// entfernt Kampagne aus Kampagnenliste
		/// </summary>
		public void RemoveCampaign(Campaign campaign)
		{
			// Kampagne aus Liste und Index entfernen
			_campaigns.Remove(campaign);
			_campaignsHash.Remove(campaign.Key);

			// Ereignis ausl�sen
			RaiseOnRemoveCampaign(campaign);
		}

		#endregion

		#region----------------------------- Ausl�sen von Ereignissen -----------------------------

		/// <summary>
		/// l�st Ereignis OnAddCampaign aus
		/// </summary>
		private void RaiseOnAddCampaign(Campaign campaign)
		{
			try
			{
				if (OnAddCampaign != null)
				{
					OnAddCampaign(campaign);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// l�st Ereignis OnRefreshCampaign aus
		/// </summary>
		private void RaiseOnRefreshCampaign(Campaign campaign)
		{
			try
			{
				if (OnRefreshCampaign != null)
				{
					OnRefreshCampaign(campaign);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// l�st Ereignis OnRemoveCampaign aus
		/// </summary>
		private void RaiseOnRemoveCampaign(Campaign campaign)
		{
			try
			{
				if (OnRemoveCampaign != null)
				{
					OnRemoveCampaign(campaign);
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
		/// gibt Kampagne zur�ck, sofern vorhanden
		/// </summary>
		public Campaign GetCampaign(string campaignCode)
		{
			// Kampagne suchen und zur�ckgeben
			foreach (Campaign campaign in _campaigns)
			{
				if (campaign.Code == campaignCode)
				{
					return campaign;
				}
			}
			return null;
		}

		/// <summary>
		/// schlie�t alle Kampagnen ab
		/// </summary>
		public void TerminateAllCampaigns()
		{
			// alle Kampagnen abschlie�en
			foreach (Campaign campaign in (ArrayList)_campaigns.Clone())
			{
				campaign.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
