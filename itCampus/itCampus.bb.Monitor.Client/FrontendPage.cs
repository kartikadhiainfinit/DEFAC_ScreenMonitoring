using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf alle Frontends.
	/// </summary>
	public class FrontendPage : itCampus.bb.Monitor.Client.Page
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.ColumnHeader columnHeaderRemoteAddress;
		private System.Windows.Forms.ColumnHeader columnHeaderAgentCode;
		private System.Windows.Forms.ColumnHeader columnHeaderState;
		private System.Windows.Forms.ColumnHeader columnHeaderDeviceCode;
		private System.Windows.Forms.ColumnHeader columnHeaderCampaignName;
		private System.Windows.Forms.ColumnHeader columnHeaderMonitorCode;
		private System.ComponentModel.IContainer components = null;

		// Frontendansicht
		private FrontendView _frontendView;

		// Frontendverwaltung
		private FrontendControl _frontendControl;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontendseite
		/// </summary>
		public FrontendPage(FrontendControl frontendControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Frontendansicht initialisieren
			_frontendView = new FrontendView();
			_frontendView.Visible = false;
			_frontendView.Dock = DockStyle.Fill;

			// Frontendansicht zu Seite hinzufügen
			panelBottom.Controls.Add(_frontendView);

			// Frontendverwaltung referenzieren
			_frontendControl = frontendControl;
			_frontendControl.OnAddFrontend += new FrontendControl.FrontendEventHandler(
				_frontendControl_OnAddFrontend);
			_frontendControl.OnRefreshFrontend += new FrontendControl.FrontendEventHandler(
				_frontendControl_OnRefreshFrontend);
			_frontendControl.OnRemoveFrontend += new FrontendControl.FrontendEventHandler(
				_frontendControl_OnRemoveFrontend);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Frontendverwaltung freigeben
			_frontendControl.OnAddFrontend -= new FrontendControl.FrontendEventHandler(
				_frontendControl_OnAddFrontend);
			_frontendControl.OnRefreshFrontend -= new FrontendControl.FrontendEventHandler(
				_frontendControl_OnRefreshFrontend);
			_frontendControl.OnRemoveFrontend -= new FrontendControl.FrontendEventHandler(
				_frontendControl_OnRemoveFrontend);
			_frontendControl = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrontendPage));
			this.columnHeaderRemoteAddress = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderAgentCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderState = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDeviceCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderCampaignName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderMonitorCode = new System.Windows.Forms.ColumnHeader();
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
																					   this.columnHeaderRemoteAddress,
																					   this.columnHeaderAgentCode,
																					   this.columnHeaderState,
																					   this.columnHeaderDeviceCode,
																					   this.columnHeaderCampaignName,
																					   this.columnHeaderMonitorCode});
			this.listView.Name = "listView";
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// panelBottom
			// 
			this.panelBottom.Name = "panelBottom";
			// 
			// columnHeaderRemoteAddress
			// 
			this.columnHeaderRemoteAddress.Text = resources.GetString("columnHeaderRemoteAddress.Text");
			this.columnHeaderRemoteAddress.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderRemoteAddress.TextAlign")));
			this.columnHeaderRemoteAddress.Width = ((int)(resources.GetObject("columnHeaderRemoteAddress.Width")));
			// 
			// columnHeaderAgentCode
			// 
			this.columnHeaderAgentCode.Text = resources.GetString("columnHeaderAgentCode.Text");
			this.columnHeaderAgentCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderAgentCode.TextAlign")));
			this.columnHeaderAgentCode.Width = ((int)(resources.GetObject("columnHeaderAgentCode.Width")));
			// 
			// columnHeaderState
			// 
			this.columnHeaderState.Text = resources.GetString("columnHeaderState.Text");
			this.columnHeaderState.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderState.TextAlign")));
			this.columnHeaderState.Width = ((int)(resources.GetObject("columnHeaderState.Width")));
			// 
			// columnHeaderDeviceCode
			// 
			this.columnHeaderDeviceCode.Text = resources.GetString("columnHeaderDeviceCode.Text");
			this.columnHeaderDeviceCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderDeviceCode.TextAlign")));
			this.columnHeaderDeviceCode.Width = ((int)(resources.GetObject("columnHeaderDeviceCode.Width")));
			// 
			// columnHeaderCampaignName
			// 
			this.columnHeaderCampaignName.Text = resources.GetString("columnHeaderCampaignName.Text");
			this.columnHeaderCampaignName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderCampaignName.TextAlign")));
			this.columnHeaderCampaignName.Width = ((int)(resources.GetObject("columnHeaderCampaignName.Width")));
			// 
			// columnHeaderMonitorCode
			// 
			this.columnHeaderMonitorCode.Text = resources.GetString("columnHeaderMonitorCode.Text");
			this.columnHeaderMonitorCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderMonitorCode.TextAlign")));
			this.columnHeaderMonitorCode.Width = ((int)(resources.GetObject("columnHeaderMonitorCode.Width")));
			// 
			// FrontendPage
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
			this.Name = "FrontendPage";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Frontendverwaltung ----------------

		/// <summary>
		/// fügt Frontend zu Seite hinzu
		/// </summary>
		private void _frontendControl_OnAddFrontend(Frontend frontend)
		{
			try
			{
				// neuen Listeneintrag erzeugen
				ListViewItem item = new ListViewItem(frontend.RemoteAddress);
				item.SubItems.Add(frontend.AgentCode);
				item.SubItems.Add(frontend.State.ToString());
				item.SubItems.Add(frontend.DeviceCode);
				item.SubItems.Add(frontend.CampaignName);
				item.SubItems.Add(frontend.MonitorCode);
				item.Tag = frontend.Key;

				// Listeneintrag zu Ansicht und Index hinzufügen
				listView.Items.Add(item);
				_listViewHash.Add(frontend.Key, item);

				// initialen Listeneintrag selektieren
				if (listView.Items.Count == 1)
				{
					item.Selected = true;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding frontend.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Frontend
		/// </summary>
		private void _frontendControl_OnRefreshFrontend(Frontend frontend)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[frontend.Key];

				// wenn Listeneintrag gefunden, aktualisieren
				if (item != null)
				{
					item.Text = frontend.RemoteAddress;
					item.SubItems[1].Text = frontend.AgentCode;
					item.SubItems[2].Text = frontend.State.ToString();
					item.SubItems[3].Text = frontend.DeviceCode;
					item.SubItems[4].Text = frontend.CampaignName;
					item.SubItems[5].Text = frontend.MonitorCode;
				}

				// wenn Listeneintrag ausgewählt
				if ((listView.SelectedItems.Count > 0) &&
					(listView.SelectedItems[0].Tag.ToString() == frontend.Key))
				{
					// Frontendansicht aktualisieren
					RefreshFrontendView();

					// Änderung signalisieren
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing frontend.", ex);
			}
		}

		/// <summary>
		/// entfernt Frontend von Seite
		/// </summary>
		private void _frontendControl_OnRemoveFrontend(Frontend frontend)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[frontend.Key];

				// wenn Listeneintrag gefunden, aus Ansicht und Index entfernen
				if (item != null)
				{
					listView.Items.Remove(item);
					_listViewHash.Remove(frontend.Key);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing frontend.", ex);
			}
		}
		
		#endregion

		#region----------------------------- Ereignisbehandlung Listenansicht ---------------------

		/// <summary>
		/// zeigt Ansicht des ausgewählten Frontends an
		/// </summary>
		private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				// Frontendansicht aktualisieren
				RefreshFrontendView();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing frontend view.", ex);
			}
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Frontendansicht
		/// </summary>
		private void RefreshFrontendView()
		{
			// wenn Frontend ausgewählt
			if (listView.SelectedItems.Count > 0)
			{
				// Frontend suchen
				ListViewItem item = listView.SelectedItems[0];
				Frontend frontend = _frontendControl[item.Tag.ToString()];

				// wenn Frontend gefunden
				if (frontend != null)
				{
					// Frontendansicht aktualisieren und anzeigen
					_frontendView.RefreshParameters(frontend);
					_frontendView.Visible = true;
				}
				else
				{
					// sonst Frontendansicht verbergen
					_frontendView.Visible = false;
				}
			}
			else
			{
				// sonst Frontendansicht verbergen
				_frontendView.Visible = false;
			}
		}

		#endregion

		#endregion
	}
}
