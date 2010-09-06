using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf alle Kampagnen.
	/// </summary>
	public class CampaignPage : itCampus.bb.Monitor.Client.Page
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.ColumnHeader columnHeaderCode;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderState;
		private System.Windows.Forms.ColumnHeader columnHeaderAgentCount;
		private System.Windows.Forms.ColumnHeader columnHeaderCallJobCount;
		private System.Windows.Forms.ColumnHeader columnHeaderIncomingCallCount;
		private System.ComponentModel.IContainer components = null;

		// Kampagnenansicht
		private CampaignView _campaignView;

		// Kampagnenverwaltung
		private CampaignControl _campaignControl;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenseite
		/// </summary>
		public CampaignPage(CampaignControl campaignControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Kampagnenansicht initialisieren
			_campaignView = new CampaignView();
			_campaignView.Visible = false;
			_campaignView.Dock = DockStyle.Fill;

			// Kampagnenansicht zu Seite hinzufügen
			panelBottom.Controls.Add(_campaignView);

			// Kampagnenverwaltung referenzieren
			_campaignControl = campaignControl;
			_campaignControl.OnAddCampaign += new CampaignControl.CampaignEventHandler(
				_campaignControl_OnAddCampaign);
			_campaignControl.OnRefreshCampaign += new CampaignControl.CampaignEventHandler(
				_campaignControl_OnRefreshCampaign);
			_campaignControl.OnRemoveCampaign += new CampaignControl.CampaignEventHandler(
				_campaignControl_OnRemoveCampaign);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Kampagnenverwaltung freigeben
			_campaignControl.OnAddCampaign -= new CampaignControl.CampaignEventHandler(
				_campaignControl_OnAddCampaign);
			_campaignControl.OnRefreshCampaign -= new CampaignControl.CampaignEventHandler(
				_campaignControl_OnRefreshCampaign);
			_campaignControl.OnRemoveCampaign -= new CampaignControl.CampaignEventHandler(
				_campaignControl_OnRemoveCampaign);
			_campaignControl = null;

			if( disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Component Designer generated code --------------------

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignPage));
			this.columnHeaderCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderState = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderAgentCount = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderCallJobCount = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderIncomingCallCount = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Text = resources.GetString("labelTitle.Text");
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeaderCode,
																					   this.columnHeaderName,
																					   this.columnHeaderState,
																					   this.columnHeaderAgentCount,
																					   this.columnHeaderCallJobCount,
																					   this.columnHeaderIncomingCallCount});
			this.listView.Name = "listView";
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// panelBottom
			// 
			this.panelBottom.Name = "panelBottom";
			// 
			// columnHeaderCode
			// 
			this.columnHeaderCode.Text = resources.GetString("columnHeaderCode.Text");
			this.columnHeaderCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderCode.TextAlign")));
			this.columnHeaderCode.Width = ((int)(resources.GetObject("columnHeaderCode.Width")));
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = resources.GetString("columnHeaderName.Text");
			this.columnHeaderName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderName.TextAlign")));
			this.columnHeaderName.Width = ((int)(resources.GetObject("columnHeaderName.Width")));
			// 
			// columnHeaderState
			// 
			this.columnHeaderState.Text = resources.GetString("columnHeaderState.Text");
			this.columnHeaderState.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderState.TextAlign")));
			this.columnHeaderState.Width = ((int)(resources.GetObject("columnHeaderState.Width")));
			// 
			// columnHeaderAgentCount
			// 
			this.columnHeaderAgentCount.Text = resources.GetString("columnHeaderAgentCount.Text");
			this.columnHeaderAgentCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderAgentCount.TextAlign")));
			this.columnHeaderAgentCount.Width = ((int)(resources.GetObject("columnHeaderAgentCount.Width")));
			// 
			// columnHeaderCallJobCount
			// 
			this.columnHeaderCallJobCount.Text = resources.GetString("columnHeaderCallJobCount.Text");
			this.columnHeaderCallJobCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderCallJobCount.TextAlign")));
			this.columnHeaderCallJobCount.Width = ((int)(resources.GetObject("columnHeaderCallJobCount.Width")));
			// 
			// columnHeaderIncomingCallCount
			// 
			this.columnHeaderIncomingCallCount.Text = resources.GetString("columnHeaderIncomingCallCount.Text");
			this.columnHeaderIncomingCallCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderIncomingCallCount.TextAlign")));
			this.columnHeaderIncomingCallCount.Width = ((int)(resources.GetObject("columnHeaderIncomingCallCount.Width")));
			// 
			// CampaignPage
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignPage";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Kampagnenverwaltung ---------------

		/// <summary>
		/// fügt Kampagne zu Seite hinzu
		/// </summary>
		private void _campaignControl_OnAddCampaign(Campaign campaign)
		{
			try
			{
				// neuen Listeneintrag erzeugen
				ListViewItem item = new ListViewItem(campaign.Code);
				item.SubItems.Add(campaign.Name);
				item.SubItems.Add(campaign.State.ToString());
				item.SubItems.Add(campaign.AgentCount.ToString());
				item.SubItems.Add(campaign.CallJobCount.ToString());
				item.SubItems.Add(campaign.IncomingCallCount.ToString());
				item.Tag = campaign.Key;

				// Listeneintrag zu Ansicht und Index hinzufügen
				listView.Items.Add(item);
				_listViewHash.Add(campaign.Key, item);

				// initialen Listeneintrag selektieren
				if (listView.Items.Count == 1)
				{
					item.Selected = true;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding campaign.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Kampagne
		/// </summary>
		private void _campaignControl_OnRefreshCampaign(Campaign campaign)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[campaign.Key];

				// wenn Listeneintrag gefunden, aktualisieren
				if (item != null)
				{
					item.Text = campaign.Code;
					item.SubItems[1].Text = campaign.Name;
					item.SubItems[2].Text = campaign.State.ToString();
					item.SubItems[3].Text = campaign.AgentCount.ToString();
					item.SubItems[4].Text = campaign.CallJobCount.ToString();
					item.SubItems[5].Text = campaign.IncomingCallCount.ToString();
				}

				// wenn Listeneintrag ausgewählt
				if ((listView.SelectedItems.Count > 0) &&
					(listView.SelectedItems[0].Tag.ToString() == campaign.Key))
				{
					// Kampagnenansicht aktualisieren
					RefreshCampaignView();

					// Änderung signalisieren
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing campaign.", ex);
			}
		}

		/// <summary>
		/// entfernt Kampagne von Seite
		/// </summary>
		private void _campaignControl_OnRemoveCampaign(Campaign campaign)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[campaign.Key];

				// wenn Listeneintrag gefunden, aus Ansicht und Index entfernen
				if (item != null)
				{
					listView.Items.Remove(item);
					_listViewHash.Remove(campaign.Key);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing campaign.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Listenansicht ---------------------

		/// <summary>
		/// zeigt Ansicht der ausgewählten Kampagne an
		/// </summary>
		private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				// Kampagnenansicht aktualisieren
				RefreshCampaignView();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing campaign view.", ex);
			}
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Kampagnenansicht
		/// </summary>
		private void RefreshCampaignView()
		{
			// wenn Kampagne ausgewählt
			if (listView.SelectedItems.Count > 0)
			{
				// Kampagne suchen
				ListViewItem item = listView.SelectedItems[0];
				Campaign campaign = _campaignControl[item.Tag.ToString()];

				// wenn Kampagne gefunden
				if (campaign != null)
				{
					// Kampagnenansicht aktualisieren und anzeigen
					_campaignView.RefreshParameters(campaign);
					_campaignView.Visible = true;
				}
				else
				{
					// sonst Kampagnenansicht verbergen
					_campaignView.Visible = false;
				}
			}
			else
			{
				// sonst Kampagnenansicht verbergen
				_campaignView.Visible = false;
			}
		}

		#endregion

		#endregion
	}
}
