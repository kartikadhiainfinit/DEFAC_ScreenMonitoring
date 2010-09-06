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
		private System.Windows.Forms.ColumnHeader columnHeaderDeviceState;
		private System.Windows.Forms.ColumnHeader columnHeaderCampaignCount;
		private System.Windows.Forms.ColumnHeader columnHeaderMonitorCode;
		private System.ComponentModel.IContainer components = null;

		// Frontendansicht
		private FrontendView _frontendView;

		// Frontendverwaltung
		private FrontendControl _frontendControl;

		// Parameter
		private string _titleBase;          // Basisbezeichnung der Seite
		private string _filterCampaignCode; // Frontendfilter

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontendseite
		/// </summary>
		public FrontendPage(FrontendControl frontendControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Parameter initialisieren
			_titleBase = labelTitle.Text;
			_filterCampaignCode = "";

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
			this.columnHeaderDeviceState = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderCampaignCount = new System.Windows.Forms.ColumnHeader();
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
																					   this.columnHeaderDeviceState,
																					   this.columnHeaderCampaignCount,
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
			// columnHeaderDeviceState
			// 
			this.columnHeaderDeviceState.Text = resources.GetString("columnHeaderDeviceState.Text");
			this.columnHeaderDeviceState.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderDeviceState.TextAlign")));
			this.columnHeaderDeviceState.Width = ((int)(resources.GetObject("columnHeaderDeviceState.Width")));
			// 
			// columnHeaderCampaignCount
			// 
			this.columnHeaderCampaignCount.Text = resources.GetString("columnHeaderCampaignCount.Text");
			this.columnHeaderCampaignCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderCampaignCount.TextAlign")));
			this.columnHeaderCampaignCount.Width = ((int)(resources.GetObject("columnHeaderCampaignCount.Width")));
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
				item.SubItems.Add(frontend.DeviceState.ToString());
				item.SubItems.Add(frontend.CampaignSessions.Count.ToString());
				item.SubItems.Add(frontend.MonitorCode);
				item.Tag = frontend.Key;

				// Listeneintrag zu Index hinzufügen
				_listViewHash.Add(frontend.Key, item);

				// Frontendfilter auf Frontend anwenden
				ApplyFrontendFilter(frontend);

				// initialen Listeneintrag selektieren
				if ((listView.Items.Count == 1) && (listView.Items[0] == item))
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

				// wenn Listeneintrag gefunden
				if (item != null)
				{
					// Listeneintrag aktualisieren
					item.Text = frontend.RemoteAddress;
					item.SubItems[1].Text = frontend.AgentCode;
					item.SubItems[2].Text = frontend.State.ToString();
					item.SubItems[3].Text = frontend.DeviceState.ToString();
					item.SubItems[4].Text = frontend.CampaignSessions.Count.ToString();
					item.SubItems[5].Text = frontend.MonitorCode;

					// Frontendfilter auf Frontend anwenden
					ApplyFrontendFilter(frontend);
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

				// wenn Listeneintrag gefunden
				if (item != null)
				{
					// wenn Listeneintrag in Ansicht enthalten, aus Ansicht entfernen
					if (listView.Items.Contains(item))
					{
						listView.Items.Remove(item);
					}

					// Listeneintrag aus Index entfernen
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

				// wenn Listeneintrag selektiert wurde
				if (listView.SelectedItems.Count > 0)
				{
					// alle Listeneinträge durchgehen
					foreach (ListViewItem item in _listViewHash.Values)
					{
						// wenn Listeneintrag nicht in Ansicht enthalten, deselektieren
						if (!listView.Items.Contains(item))
						{
							item.Selected = false;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing frontend view.", ex);
			}
		}

		#endregion

		#region----------------------------- Frontendfilter ---------------------------------------

		/// <summary>
		/// stellt Frontendfilter ein
		/// </summary>
		public void SetFrontendFilter(string campaignCode, string campaignDisplayName)
		{
			// wenn Frontendfilter geändert
			if (campaignCode != _filterCampaignCode)
			{
				// Frontendfilter aktualisieren
				_filterCampaignCode = campaignCode;

				// Frontendfilter auf alle Frontends anwenden
				ApplyFrontendFilter();

				// Listenansicht aktualisieren
				RefreshView();
			}

			// Seitentitel aktualisieren
			if (campaignCode != "")
			{
				labelTitle.Text = _titleBase + " - " + campaignDisplayName;
			}
			else
			{
				labelTitle.Text = _titleBase;
			}
		}

		/// <summary>
		/// wendet Frontendfilter auf alle Frontends an
		/// </summary>
		private void ApplyFrontendFilter()
		{
			// Zeichnen der Listenansicht unterdrücken
			listView.BeginUpdate();

			try
			{
				// Frontendfilter auf alle Frontends anwenden
				foreach (Frontend frontend in _frontendControl)
				{
					ApplyFrontendFilter(frontend);
				}
			}
			finally
			{
				// Zeichnen der Listenansicht ermöglichen
				listView.EndUpdate();
			}
		}

		/// <summary>
		/// wendet Frontendfilter auf Frontend an
		/// </summary>
		private void ApplyFrontendFilter(Frontend frontend)
		{
			// Listeneintrag in Index suchen
			ListViewItem item = (ListViewItem)_listViewHash[frontend.Key];

			// wenn Listeneintrag gefunden
			if (item != null)
			{
				// wenn Frontendfilter deaktiviert oder Filterbedingung erfüllt
				if ((_filterCampaignCode == "") ||
					(frontend.CampaignSessions[_filterCampaignCode] != null))
				{
					// wenn Listeneintrag nicht in Ansicht enthalten, zu Ansicht hinzufügen
					if (!listView.Items.Contains(item))
					{
						listView.Items.Add(item);
					}
				}
				else
				{
					// sonst, wenn Listeneintrag in Ansicht enthalten, aus Ansicht entfernen
					if (listView.Items.Contains(item))
					{
						listView.Items.Remove(item);
					}
				}
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
