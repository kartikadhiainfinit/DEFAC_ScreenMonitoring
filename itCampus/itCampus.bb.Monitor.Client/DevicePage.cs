using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf alle Devices.
	/// </summary>
	public class DevicePage : itCampus.bb.Monitor.Client.Page
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.ColumnHeader columnHeaderCode;
		private System.Windows.Forms.ColumnHeader columnHeaderSiteName;
		private System.Windows.Forms.ColumnHeader columnHeaderAgentCode;
		private System.ComponentModel.IContainer components = null;

		// Deviceverwaltung
		private DeviceControl _deviceControl;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Deviceseite
		/// </summary>
		public DevicePage(DeviceControl deviceControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Deviceverwaltung referenzieren
			_deviceControl = deviceControl;
			_deviceControl.OnAddDevice += new DeviceControl.DeviceEventHandler(
				_deviceControl_OnAddDevice);
			_deviceControl.OnRefreshDevice += new DeviceControl.DeviceEventHandler(
				_deviceControl_OnRefreshDevice);
			_deviceControl.OnRemoveDevice += new DeviceControl.DeviceEventHandler(
				_deviceControl_OnRemoveDevice);

			// Seitenmodus initialisieren
			this.Mode = PageMode.List;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Deviceverwaltung freigeben
			_deviceControl.OnAddDevice -= new DeviceControl.DeviceEventHandler(
				_deviceControl_OnAddDevice);
			_deviceControl.OnRefreshDevice -= new DeviceControl.DeviceEventHandler(
				_deviceControl_OnRefreshDevice);
			_deviceControl.OnRemoveDevice -= new DeviceControl.DeviceEventHandler(
				_deviceControl_OnRemoveDevice);
			_deviceControl = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DevicePage));
			this.columnHeaderCode = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderSiteName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderAgentCode = new System.Windows.Forms.ColumnHeader();
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
																					   this.columnHeaderSiteName,
																					   this.columnHeaderAgentCode});
			this.listView.Name = "listView";
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
			// columnHeaderSiteName
			// 
			this.columnHeaderSiteName.Text = resources.GetString("columnHeaderSiteName.Text");
			this.columnHeaderSiteName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderSiteName.TextAlign")));
			this.columnHeaderSiteName.Width = ((int)(resources.GetObject("columnHeaderSiteName.Width")));
			// 
			// columnHeaderAgentCode
			// 
			this.columnHeaderAgentCode.Text = resources.GetString("columnHeaderAgentCode.Text");
			this.columnHeaderAgentCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderAgentCode.TextAlign")));
			this.columnHeaderAgentCode.Width = ((int)(resources.GetObject("columnHeaderAgentCode.Width")));
			// 
			// DevicePage
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
			this.Name = "DevicePage";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Deviceverwaltung ------------------

		/// <summary>
		/// fügt Device zu Seite hinzu
		/// </summary>
		private void _deviceControl_OnAddDevice(Device device)
		{
			try
			{
				// neuen Listeneintrag erzeugen
				ListViewItem item = new ListViewItem(device.Code);
				item.SubItems.Add(device.Site != null ?
					(device.Site.Name != "" ? device.Site.Name : device.Site.Code) : "");
				item.SubItems.Add(device.Frontend != null ? device.Frontend.AgentCode : "");
				item.Tag = device.Code;

				// Listeneintrag zu Ansicht und Index hinzufügen
				listView.Items.Add(item);
				_listViewHash.Add(device.Code, item);

				// initialen Listeneintrag selektieren
				if (listView.Items.Count == 1)
				{
					item.Selected = true;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding device.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Device
		/// </summary>
		private void _deviceControl_OnRefreshDevice(Device device)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[device.Code];

				// wenn Listeneintrag gefunden, aktualisieren
				if (item != null)
				{
					item.Text = device.Code;
					item.SubItems[1].Text = device.Site != null ?
						(device.Site.Name != "" ? device.Site.Name : device.Site.Code) : "";
					item.SubItems[2].Text =
						device.Frontend != null ? device.Frontend.AgentCode : "";
				}

				// wenn Listeneintrag ausgewählt, Änderung signalisieren
				if ((listView.SelectedItems.Count > 0) &&
					(listView.SelectedItems[0].Tag.ToString() == device.Code))
				{
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing device.", ex);
			}
		}

		/// <summary>
		/// entfernt Device von Seite
		/// </summary>
		private void _deviceControl_OnRemoveDevice(Device device)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[device.Code];

				// wenn Listeneintrag gefunden, aus Ansicht und Index entfernen
				if (item != null)
				{
					listView.Items.Remove(item);
					_listViewHash.Remove(device.Code);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing device.", ex);
			}
		}

		#endregion

		#endregion
	}
}
