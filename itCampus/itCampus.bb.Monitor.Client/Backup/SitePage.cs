using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf alle Räume.
	/// </summary>
	public class SitePage : itCampus.bb.Monitor.Client.Page
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.ColumnHeader columnHeaderCode;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderDeviceCount;
		private System.ComponentModel.IContainer components = null;

		// Raumverwaltung
		private SiteControl _siteControl;

		// Index Raumansichten
		private Hashtable _siteViews = new Hashtable();

		// aktuelle Raumansicht
		private SiteView _currentSiteView;

		// Kontextmenü Raumansichten
		private ContextMenu _siteViewContextMenu;

		#endregion

		#region----------------------------- Delegates --------------------------------------------

		public delegate void OnSelectedDeviceChangedEventHandler();

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// ausgewähltes Device geändert
		public event OnSelectedDeviceChangedEventHandler OnSelectedDeviceChanged;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Raumseite
		/// </summary>
		public SitePage(SiteControl siteControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Raumverwaltung referenzieren
			_siteControl = siteControl;
			_siteControl.OnAddSite += new SiteControl.SiteEventHandler(
				_siteControl_OnAddSite);
			_siteControl.OnRefreshSite += new SiteControl.SiteEventHandler(
				_siteControl_OnRefreshSite);
			_siteControl.OnRemoveSite += new SiteControl.SiteEventHandler(
				_siteControl_OnRemoveSite);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Raumverwaltung freigeben
			_siteControl.OnAddSite -= new SiteControl.SiteEventHandler(
				_siteControl_OnAddSite);
			_siteControl.OnRefreshSite -= new SiteControl.SiteEventHandler(
				_siteControl_OnRefreshSite);
			_siteControl.OnRemoveSite -= new SiteControl.SiteEventHandler(
				_siteControl_OnRemoveSite);
			_siteControl = null;

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

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Code des ausgewählten Devices
		/// </summary>
		public string SelectedDeviceCode
		{
			get
			{
				return _currentSiteView != null ? _currentSiteView.SelectedItemTag : "";
			}
		}

		/// <summary>
		/// Kontextmenü Raumansichten
		/// </summary>
		public ContextMenu SiteViewContextMenu
		{
			get
			{
				return _siteViewContextMenu;
			}
			set
			{
				_siteViewContextMenu = value;
				foreach (SiteView siteView in _siteViews.Values)
				{
					siteView.ContextMenu = _siteViewContextMenu;
				}
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SitePage));
			this.columnHeaderCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDeviceCount = new System.Windows.Forms.ColumnHeader();
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
																					   this.columnHeaderDeviceCount});
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
			// columnHeaderDeviceCount
			// 
			this.columnHeaderDeviceCount.Text = resources.GetString("columnHeaderDeviceCount.Text");
			this.columnHeaderDeviceCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderDeviceCount.TextAlign")));
			this.columnHeaderDeviceCount.Width = ((int)(resources.GetObject("columnHeaderDeviceCount.Width")));
			// 
			// SitePage
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
			this.Name = "SitePage";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Initialisierung EventHandler -------------------------

		/// <summary>
		/// referenziert aktuelle Raumansicht
		/// </summary>
		private void SetCurrentSiteView(SiteView siteView)
		{
			if (_currentSiteView != null)
			{
				_currentSiteView.OnSelectedItemChanged -=
					new SiteView.OnSelectedItemChangedEventHandler(
					_currentSiteView_OnSelectedItemChanged);
				_currentSiteView = null;
			}
			if (siteView != null)
			{
				_currentSiteView = siteView;
				_currentSiteView.OnSelectedItemChanged +=
					new SiteView.OnSelectedItemChangedEventHandler(
					_currentSiteView_OnSelectedItemChanged);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Raumverwaltung --------------------

		/// <summary>
		/// fügt Raum zu Seite hinzu
		/// </summary>
		private void _siteControl_OnAddSite(Site site)
		{
			try
			{
				// neuen Listeneintrag erzeugen
				ListViewItem item = new ListViewItem(site.Code);
				item.SubItems.Add(site.Name);
				item.SubItems.Add(site.DeviceCount.ToString());
				item.Tag = site.Code;

				// Listeneintrag zu Ansicht und Index hinzufügen
				listView.Items.Add(item);
				_listViewHash.Add(site.Code, item);

				// neue Raumansicht erzeugen und konfigurieren
				SiteView siteView = new SiteView(site);
				siteView.Visible = false;
				siteView.Dock = DockStyle.Fill;
				siteView.ContextMenu = _siteViewContextMenu;

				// Raumansicht zu Seite und Index hinzufügen
				panelBottom.Controls.Add(siteView);
				_siteViews.Add(site.Code, siteView);

				// initialen Listeneintrag selektieren
				if (listView.Items.Count == 1)
				{
					item.Selected = true;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding site.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Raum
		/// </summary>
		private void _siteControl_OnRefreshSite(Site site)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[site.Code];

				// wenn Listeneintrag gefunden, aktualisieren
				if (item != null)
				{
					item.Text = site.Code;
					item.SubItems[1].Text = site.Name;
					item.SubItems[2].Text = site.DeviceCount.ToString();
				}

				// Raumansicht in Index suchen
				SiteView siteView = (SiteView)_siteViews[site.Code];

				// wenn Raumansicht gefunden, aktualisieren
				if (siteView != null)
				{
					siteView.RefreshParameters();
				}

				// wenn Listeneintrag ausgewählt, Änderung signalisieren
				if ((listView.SelectedItems.Count > 0) &&
					(listView.SelectedItems[0].Tag.ToString() == site.Code))
				{
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing site.", ex);
			}
		}

		/// <summary>
		/// entfernt Raum von Seite
		/// </summary>
		private void _siteControl_OnRemoveSite(Site site)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[site.Code];

				// wenn Listeneintrag gefunden, aus Ansicht und Index entfernen
				if (item != null)
				{
					listView.Items.Remove(item);
					_listViewHash.Remove(site.Code);
				}

				// Raumansicht in Index suchen
				SiteView siteView = (SiteView)_siteViews[site.Code];

				// wenn Raumansicht gefunden, von Seite und Index entfernen
				if (siteView != null)
				{
					panelBottom.Controls.Remove(siteView);
					siteView.Dispose();
					_siteViews.Remove(site.Code);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing site.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Listenansicht ---------------------

		/// <summary>
		/// zeigt Ansicht des ausgewählten Raumes an
		/// </summary>
		private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				// alle Raumansichten verbergen
				foreach (SiteView siteView in _siteViews.Values)
				{
					siteView.Visible = false;
				}

				// wenn Raum ausgewählt
				if (listView.SelectedItems.Count > 0)
				{
					// Raumansicht suchen
					ListViewItem item = listView.SelectedItems[0];
					SiteView siteView = (SiteView)_siteViews[item.Tag];

					// wenn Raumansicht gefunden, anzeigen
					if (siteView != null)
					{
						siteView.Visible = true;
					}

					// aktuelle Raumansicht referenzieren
					SetCurrentSiteView(siteView);
				}
				else
				{
					// sonst aktuelle Raumansicht freigeben
					SetCurrentSiteView(null);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on showing site view.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Raumansicht -----------------------

		/// <summary>
		/// signalisiert Änderung des aktuellen Devices
		/// </summary>
		private void _currentSiteView_OnSelectedItemChanged()
		{
			RaiseOnSelectedDeviceChanged();
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnSelectedDeviceChanged aus
		/// </summary>
		private void RaiseOnSelectedDeviceChanged()
		{
			try
			{
				if (OnSelectedDeviceChanged != null)
				{
					OnSelectedDeviceChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		#endregion

		#endregion
	}
}
