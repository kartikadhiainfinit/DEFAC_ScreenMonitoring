using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Formular zum Bearbeiten eines Raumes.
	/// </summary>
	public class SiteForm : System.Windows.Forms.Form
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.Label labelCodeCap;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Label labelNameCap;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelPictureFileCap;
		private System.Windows.Forms.TextBox textBoxPictureFile;
		private System.Windows.Forms.Button buttonPictureFile;
		private System.Windows.Forms.GroupBox groupBoxDevices;
		private System.Windows.Forms.Button buttonDevicesRemove;
		private System.Windows.Forms.Button buttonDevicesRemoveAll;
		private System.Windows.Forms.Button buttonDevicesAddAll;
		private System.Windows.Forms.Button buttonDevicesAdd;
		private System.Windows.Forms.ListBox listBoxDevicesAssigned;
		private System.Windows.Forms.Label labelDevicesAssignedCap;
		private System.Windows.Forms.ListBox listBoxDevicesUnassigned;
		private System.Windows.Forms.Label labelDevicesUnassignedCap;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		// Objektverwaltung
		private MainControl _mainControl;

		// zu bearbeitender Raum
		private Site _site;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Raumformular
		/// </summary>
		public SiteForm(MainControl mainControl, Site site)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Objekte referenzieren
			_mainControl = mainControl;
			_site = site;

			// Formular konfigurieren
			if (_site == null)
			{
				this.Text = Resources.GetString("SiteForm.Text.AddSite");
				textBoxCode.Enabled = true;
				textBoxCode.BackColor = SystemColors.Window;
				textBoxCode.Text = "";
				textBoxName.Text = "";
				textBoxPictureFile.Text = "";
			}
			else
			{
				this.Text = Resources.GetString("SiteForm.Text.EditSite");
				textBoxCode.Enabled = false;
				textBoxCode.BackColor = SystemColors.Control;
				textBoxCode.Text = _site.Code;
				textBoxName.Text = _site.Name;
				textBoxPictureFile.Text = _site.PictureFile;
			}

			// Devicelisten initialisieren
			InitDevices();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Windows Form Designer generated code -----------------

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SiteForm));
			this.labelCodeCap = new System.Windows.Forms.Label();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.labelNameCap = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelPictureFileCap = new System.Windows.Forms.Label();
			this.textBoxPictureFile = new System.Windows.Forms.TextBox();
			this.buttonPictureFile = new System.Windows.Forms.Button();
			this.groupBoxDevices = new System.Windows.Forms.GroupBox();
			this.buttonDevicesRemove = new System.Windows.Forms.Button();
			this.buttonDevicesRemoveAll = new System.Windows.Forms.Button();
			this.buttonDevicesAddAll = new System.Windows.Forms.Button();
			this.buttonDevicesAdd = new System.Windows.Forms.Button();
			this.listBoxDevicesAssigned = new System.Windows.Forms.ListBox();
			this.labelDevicesAssignedCap = new System.Windows.Forms.Label();
			this.listBoxDevicesUnassigned = new System.Windows.Forms.ListBox();
			this.labelDevicesUnassignedCap = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBoxDevices.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCodeCap
			// 
			this.labelCodeCap.AccessibleDescription = resources.GetString("labelCodeCap.AccessibleDescription");
			this.labelCodeCap.AccessibleName = resources.GetString("labelCodeCap.AccessibleName");
			this.labelCodeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCodeCap.Anchor")));
			this.labelCodeCap.AutoSize = ((bool)(resources.GetObject("labelCodeCap.AutoSize")));
			this.labelCodeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCodeCap.Dock")));
			this.labelCodeCap.Enabled = ((bool)(resources.GetObject("labelCodeCap.Enabled")));
			this.labelCodeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCodeCap.Font")));
			this.labelCodeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCodeCap.Image")));
			this.labelCodeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCodeCap.ImageAlign")));
			this.labelCodeCap.ImageIndex = ((int)(resources.GetObject("labelCodeCap.ImageIndex")));
			this.labelCodeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCodeCap.ImeMode")));
			this.labelCodeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCodeCap.Location")));
			this.labelCodeCap.Name = "labelCodeCap";
			this.labelCodeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCodeCap.RightToLeft")));
			this.labelCodeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCodeCap.Size")));
			this.labelCodeCap.TabIndex = ((int)(resources.GetObject("labelCodeCap.TabIndex")));
			this.labelCodeCap.Text = resources.GetString("labelCodeCap.Text");
			this.labelCodeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCodeCap.TextAlign")));
			this.labelCodeCap.Visible = ((bool)(resources.GetObject("labelCodeCap.Visible")));
			// 
			// textBoxCode
			// 
			this.textBoxCode.AccessibleDescription = resources.GetString("textBoxCode.AccessibleDescription");
			this.textBoxCode.AccessibleName = resources.GetString("textBoxCode.AccessibleName");
			this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxCode.Anchor")));
			this.textBoxCode.AutoSize = ((bool)(resources.GetObject("textBoxCode.AutoSize")));
			this.textBoxCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCode.BackgroundImage")));
			this.textBoxCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxCode.Dock")));
			this.textBoxCode.Enabled = ((bool)(resources.GetObject("textBoxCode.Enabled")));
			this.textBoxCode.Font = ((System.Drawing.Font)(resources.GetObject("textBoxCode.Font")));
			this.textBoxCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxCode.ImeMode")));
			this.textBoxCode.Location = ((System.Drawing.Point)(resources.GetObject("textBoxCode.Location")));
			this.textBoxCode.MaxLength = ((int)(resources.GetObject("textBoxCode.MaxLength")));
			this.textBoxCode.Multiline = ((bool)(resources.GetObject("textBoxCode.Multiline")));
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.PasswordChar = ((char)(resources.GetObject("textBoxCode.PasswordChar")));
			this.textBoxCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxCode.RightToLeft")));
			this.textBoxCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxCode.ScrollBars")));
			this.textBoxCode.Size = ((System.Drawing.Size)(resources.GetObject("textBoxCode.Size")));
			this.textBoxCode.TabIndex = ((int)(resources.GetObject("textBoxCode.TabIndex")));
			this.textBoxCode.Text = resources.GetString("textBoxCode.Text");
			this.textBoxCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxCode.TextAlign")));
			this.textBoxCode.Visible = ((bool)(resources.GetObject("textBoxCode.Visible")));
			this.textBoxCode.WordWrap = ((bool)(resources.GetObject("textBoxCode.WordWrap")));
			this.textBoxCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCode_Validating);
			// 
			// labelNameCap
			// 
			this.labelNameCap.AccessibleDescription = resources.GetString("labelNameCap.AccessibleDescription");
			this.labelNameCap.AccessibleName = resources.GetString("labelNameCap.AccessibleName");
			this.labelNameCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelNameCap.Anchor")));
			this.labelNameCap.AutoSize = ((bool)(resources.GetObject("labelNameCap.AutoSize")));
			this.labelNameCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelNameCap.Dock")));
			this.labelNameCap.Enabled = ((bool)(resources.GetObject("labelNameCap.Enabled")));
			this.labelNameCap.Font = ((System.Drawing.Font)(resources.GetObject("labelNameCap.Font")));
			this.labelNameCap.Image = ((System.Drawing.Image)(resources.GetObject("labelNameCap.Image")));
			this.labelNameCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelNameCap.ImageAlign")));
			this.labelNameCap.ImageIndex = ((int)(resources.GetObject("labelNameCap.ImageIndex")));
			this.labelNameCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelNameCap.ImeMode")));
			this.labelNameCap.Location = ((System.Drawing.Point)(resources.GetObject("labelNameCap.Location")));
			this.labelNameCap.Name = "labelNameCap";
			this.labelNameCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelNameCap.RightToLeft")));
			this.labelNameCap.Size = ((System.Drawing.Size)(resources.GetObject("labelNameCap.Size")));
			this.labelNameCap.TabIndex = ((int)(resources.GetObject("labelNameCap.TabIndex")));
			this.labelNameCap.Text = resources.GetString("labelNameCap.Text");
			this.labelNameCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelNameCap.TextAlign")));
			this.labelNameCap.Visible = ((bool)(resources.GetObject("labelNameCap.Visible")));
			// 
			// textBoxName
			// 
			this.textBoxName.AccessibleDescription = resources.GetString("textBoxName.AccessibleDescription");
			this.textBoxName.AccessibleName = resources.GetString("textBoxName.AccessibleName");
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxName.Anchor")));
			this.textBoxName.AutoSize = ((bool)(resources.GetObject("textBoxName.AutoSize")));
			this.textBoxName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxName.BackgroundImage")));
			this.textBoxName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxName.Dock")));
			this.textBoxName.Enabled = ((bool)(resources.GetObject("textBoxName.Enabled")));
			this.textBoxName.Font = ((System.Drawing.Font)(resources.GetObject("textBoxName.Font")));
			this.textBoxName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxName.ImeMode")));
			this.textBoxName.Location = ((System.Drawing.Point)(resources.GetObject("textBoxName.Location")));
			this.textBoxName.MaxLength = ((int)(resources.GetObject("textBoxName.MaxLength")));
			this.textBoxName.Multiline = ((bool)(resources.GetObject("textBoxName.Multiline")));
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.PasswordChar = ((char)(resources.GetObject("textBoxName.PasswordChar")));
			this.textBoxName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxName.RightToLeft")));
			this.textBoxName.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxName.ScrollBars")));
			this.textBoxName.Size = ((System.Drawing.Size)(resources.GetObject("textBoxName.Size")));
			this.textBoxName.TabIndex = ((int)(resources.GetObject("textBoxName.TabIndex")));
			this.textBoxName.Text = resources.GetString("textBoxName.Text");
			this.textBoxName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxName.TextAlign")));
			this.textBoxName.Visible = ((bool)(resources.GetObject("textBoxName.Visible")));
			this.textBoxName.WordWrap = ((bool)(resources.GetObject("textBoxName.WordWrap")));
			// 
			// labelPictureFileCap
			// 
			this.labelPictureFileCap.AccessibleDescription = resources.GetString("labelPictureFileCap.AccessibleDescription");
			this.labelPictureFileCap.AccessibleName = resources.GetString("labelPictureFileCap.AccessibleName");
			this.labelPictureFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPictureFileCap.Anchor")));
			this.labelPictureFileCap.AutoSize = ((bool)(resources.GetObject("labelPictureFileCap.AutoSize")));
			this.labelPictureFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPictureFileCap.Dock")));
			this.labelPictureFileCap.Enabled = ((bool)(resources.GetObject("labelPictureFileCap.Enabled")));
			this.labelPictureFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelPictureFileCap.Font")));
			this.labelPictureFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelPictureFileCap.Image")));
			this.labelPictureFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPictureFileCap.ImageAlign")));
			this.labelPictureFileCap.ImageIndex = ((int)(resources.GetObject("labelPictureFileCap.ImageIndex")));
			this.labelPictureFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPictureFileCap.ImeMode")));
			this.labelPictureFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelPictureFileCap.Location")));
			this.labelPictureFileCap.Name = "labelPictureFileCap";
			this.labelPictureFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPictureFileCap.RightToLeft")));
			this.labelPictureFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelPictureFileCap.Size")));
			this.labelPictureFileCap.TabIndex = ((int)(resources.GetObject("labelPictureFileCap.TabIndex")));
			this.labelPictureFileCap.Text = resources.GetString("labelPictureFileCap.Text");
			this.labelPictureFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPictureFileCap.TextAlign")));
			this.labelPictureFileCap.Visible = ((bool)(resources.GetObject("labelPictureFileCap.Visible")));
			// 
			// textBoxPictureFile
			// 
			this.textBoxPictureFile.AccessibleDescription = resources.GetString("textBoxPictureFile.AccessibleDescription");
			this.textBoxPictureFile.AccessibleName = resources.GetString("textBoxPictureFile.AccessibleName");
			this.textBoxPictureFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxPictureFile.Anchor")));
			this.textBoxPictureFile.AutoSize = ((bool)(resources.GetObject("textBoxPictureFile.AutoSize")));
			this.textBoxPictureFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxPictureFile.BackgroundImage")));
			this.textBoxPictureFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxPictureFile.Dock")));
			this.textBoxPictureFile.Enabled = ((bool)(resources.GetObject("textBoxPictureFile.Enabled")));
			this.textBoxPictureFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxPictureFile.Font")));
			this.textBoxPictureFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxPictureFile.ImeMode")));
			this.textBoxPictureFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxPictureFile.Location")));
			this.textBoxPictureFile.MaxLength = ((int)(resources.GetObject("textBoxPictureFile.MaxLength")));
			this.textBoxPictureFile.Multiline = ((bool)(resources.GetObject("textBoxPictureFile.Multiline")));
			this.textBoxPictureFile.Name = "textBoxPictureFile";
			this.textBoxPictureFile.PasswordChar = ((char)(resources.GetObject("textBoxPictureFile.PasswordChar")));
			this.textBoxPictureFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxPictureFile.RightToLeft")));
			this.textBoxPictureFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxPictureFile.ScrollBars")));
			this.textBoxPictureFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxPictureFile.Size")));
			this.textBoxPictureFile.TabIndex = ((int)(resources.GetObject("textBoxPictureFile.TabIndex")));
			this.textBoxPictureFile.Text = resources.GetString("textBoxPictureFile.Text");
			this.textBoxPictureFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxPictureFile.TextAlign")));
			this.textBoxPictureFile.Visible = ((bool)(resources.GetObject("textBoxPictureFile.Visible")));
			this.textBoxPictureFile.WordWrap = ((bool)(resources.GetObject("textBoxPictureFile.WordWrap")));
			// 
			// buttonPictureFile
			// 
			this.buttonPictureFile.AccessibleDescription = resources.GetString("buttonPictureFile.AccessibleDescription");
			this.buttonPictureFile.AccessibleName = resources.GetString("buttonPictureFile.AccessibleName");
			this.buttonPictureFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonPictureFile.Anchor")));
			this.buttonPictureFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPictureFile.BackgroundImage")));
			this.buttonPictureFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonPictureFile.Dock")));
			this.buttonPictureFile.Enabled = ((bool)(resources.GetObject("buttonPictureFile.Enabled")));
			this.buttonPictureFile.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonPictureFile.FlatStyle")));
			this.buttonPictureFile.Font = ((System.Drawing.Font)(resources.GetObject("buttonPictureFile.Font")));
			this.buttonPictureFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonPictureFile.Image")));
			this.buttonPictureFile.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonPictureFile.ImageAlign")));
			this.buttonPictureFile.ImageIndex = ((int)(resources.GetObject("buttonPictureFile.ImageIndex")));
			this.buttonPictureFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonPictureFile.ImeMode")));
			this.buttonPictureFile.Location = ((System.Drawing.Point)(resources.GetObject("buttonPictureFile.Location")));
			this.buttonPictureFile.Name = "buttonPictureFile";
			this.buttonPictureFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonPictureFile.RightToLeft")));
			this.buttonPictureFile.Size = ((System.Drawing.Size)(resources.GetObject("buttonPictureFile.Size")));
			this.buttonPictureFile.TabIndex = ((int)(resources.GetObject("buttonPictureFile.TabIndex")));
			this.buttonPictureFile.Text = resources.GetString("buttonPictureFile.Text");
			this.buttonPictureFile.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonPictureFile.TextAlign")));
			this.buttonPictureFile.Visible = ((bool)(resources.GetObject("buttonPictureFile.Visible")));
			this.buttonPictureFile.Click += new System.EventHandler(this.buttonPictureFile_Click);
			// 
			// groupBoxDevices
			// 
			this.groupBoxDevices.AccessibleDescription = resources.GetString("groupBoxDevices.AccessibleDescription");
			this.groupBoxDevices.AccessibleName = resources.GetString("groupBoxDevices.AccessibleName");
			this.groupBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxDevices.Anchor")));
			this.groupBoxDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxDevices.BackgroundImage")));
			this.groupBoxDevices.Controls.Add(this.buttonDevicesRemove);
			this.groupBoxDevices.Controls.Add(this.buttonDevicesRemoveAll);
			this.groupBoxDevices.Controls.Add(this.buttonDevicesAddAll);
			this.groupBoxDevices.Controls.Add(this.buttonDevicesAdd);
			this.groupBoxDevices.Controls.Add(this.listBoxDevicesAssigned);
			this.groupBoxDevices.Controls.Add(this.labelDevicesAssignedCap);
			this.groupBoxDevices.Controls.Add(this.listBoxDevicesUnassigned);
			this.groupBoxDevices.Controls.Add(this.labelDevicesUnassignedCap);
			this.groupBoxDevices.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxDevices.Dock")));
			this.groupBoxDevices.Enabled = ((bool)(resources.GetObject("groupBoxDevices.Enabled")));
			this.groupBoxDevices.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxDevices.Font")));
			this.groupBoxDevices.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxDevices.ImeMode")));
			this.groupBoxDevices.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxDevices.Location")));
			this.groupBoxDevices.Name = "groupBoxDevices";
			this.groupBoxDevices.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxDevices.RightToLeft")));
			this.groupBoxDevices.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxDevices.Size")));
			this.groupBoxDevices.TabIndex = ((int)(resources.GetObject("groupBoxDevices.TabIndex")));
			this.groupBoxDevices.TabStop = false;
			this.groupBoxDevices.Text = resources.GetString("groupBoxDevices.Text");
			this.groupBoxDevices.Visible = ((bool)(resources.GetObject("groupBoxDevices.Visible")));
			// 
			// buttonDevicesRemove
			// 
			this.buttonDevicesRemove.AccessibleDescription = resources.GetString("buttonDevicesRemove.AccessibleDescription");
			this.buttonDevicesRemove.AccessibleName = resources.GetString("buttonDevicesRemove.AccessibleName");
			this.buttonDevicesRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonDevicesRemove.Anchor")));
			this.buttonDevicesRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevicesRemove.BackgroundImage")));
			this.buttonDevicesRemove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonDevicesRemove.Dock")));
			this.buttonDevicesRemove.Enabled = ((bool)(resources.GetObject("buttonDevicesRemove.Enabled")));
			this.buttonDevicesRemove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonDevicesRemove.FlatStyle")));
			this.buttonDevicesRemove.Font = ((System.Drawing.Font)(resources.GetObject("buttonDevicesRemove.Font")));
			this.buttonDevicesRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevicesRemove.Image")));
			this.buttonDevicesRemove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesRemove.ImageAlign")));
			this.buttonDevicesRemove.ImageIndex = ((int)(resources.GetObject("buttonDevicesRemove.ImageIndex")));
			this.buttonDevicesRemove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonDevicesRemove.ImeMode")));
			this.buttonDevicesRemove.Location = ((System.Drawing.Point)(resources.GetObject("buttonDevicesRemove.Location")));
			this.buttonDevicesRemove.Name = "buttonDevicesRemove";
			this.buttonDevicesRemove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonDevicesRemove.RightToLeft")));
			this.buttonDevicesRemove.Size = ((System.Drawing.Size)(resources.GetObject("buttonDevicesRemove.Size")));
			this.buttonDevicesRemove.TabIndex = ((int)(resources.GetObject("buttonDevicesRemove.TabIndex")));
			this.buttonDevicesRemove.Text = resources.GetString("buttonDevicesRemove.Text");
			this.buttonDevicesRemove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesRemove.TextAlign")));
			this.buttonDevicesRemove.Visible = ((bool)(resources.GetObject("buttonDevicesRemove.Visible")));
			this.buttonDevicesRemove.Click += new System.EventHandler(this.buttonDevicesRemove_Click);
			// 
			// buttonDevicesRemoveAll
			// 
			this.buttonDevicesRemoveAll.AccessibleDescription = resources.GetString("buttonDevicesRemoveAll.AccessibleDescription");
			this.buttonDevicesRemoveAll.AccessibleName = resources.GetString("buttonDevicesRemoveAll.AccessibleName");
			this.buttonDevicesRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonDevicesRemoveAll.Anchor")));
			this.buttonDevicesRemoveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevicesRemoveAll.BackgroundImage")));
			this.buttonDevicesRemoveAll.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonDevicesRemoveAll.Dock")));
			this.buttonDevicesRemoveAll.Enabled = ((bool)(resources.GetObject("buttonDevicesRemoveAll.Enabled")));
			this.buttonDevicesRemoveAll.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonDevicesRemoveAll.FlatStyle")));
			this.buttonDevicesRemoveAll.Font = ((System.Drawing.Font)(resources.GetObject("buttonDevicesRemoveAll.Font")));
			this.buttonDevicesRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevicesRemoveAll.Image")));
			this.buttonDevicesRemoveAll.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesRemoveAll.ImageAlign")));
			this.buttonDevicesRemoveAll.ImageIndex = ((int)(resources.GetObject("buttonDevicesRemoveAll.ImageIndex")));
			this.buttonDevicesRemoveAll.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonDevicesRemoveAll.ImeMode")));
			this.buttonDevicesRemoveAll.Location = ((System.Drawing.Point)(resources.GetObject("buttonDevicesRemoveAll.Location")));
			this.buttonDevicesRemoveAll.Name = "buttonDevicesRemoveAll";
			this.buttonDevicesRemoveAll.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonDevicesRemoveAll.RightToLeft")));
			this.buttonDevicesRemoveAll.Size = ((System.Drawing.Size)(resources.GetObject("buttonDevicesRemoveAll.Size")));
			this.buttonDevicesRemoveAll.TabIndex = ((int)(resources.GetObject("buttonDevicesRemoveAll.TabIndex")));
			this.buttonDevicesRemoveAll.Text = resources.GetString("buttonDevicesRemoveAll.Text");
			this.buttonDevicesRemoveAll.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesRemoveAll.TextAlign")));
			this.buttonDevicesRemoveAll.Visible = ((bool)(resources.GetObject("buttonDevicesRemoveAll.Visible")));
			this.buttonDevicesRemoveAll.Click += new System.EventHandler(this.buttonDevicesRemoveAll_Click);
			// 
			// buttonDevicesAddAll
			// 
			this.buttonDevicesAddAll.AccessibleDescription = resources.GetString("buttonDevicesAddAll.AccessibleDescription");
			this.buttonDevicesAddAll.AccessibleName = resources.GetString("buttonDevicesAddAll.AccessibleName");
			this.buttonDevicesAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonDevicesAddAll.Anchor")));
			this.buttonDevicesAddAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevicesAddAll.BackgroundImage")));
			this.buttonDevicesAddAll.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonDevicesAddAll.Dock")));
			this.buttonDevicesAddAll.Enabled = ((bool)(resources.GetObject("buttonDevicesAddAll.Enabled")));
			this.buttonDevicesAddAll.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonDevicesAddAll.FlatStyle")));
			this.buttonDevicesAddAll.Font = ((System.Drawing.Font)(resources.GetObject("buttonDevicesAddAll.Font")));
			this.buttonDevicesAddAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevicesAddAll.Image")));
			this.buttonDevicesAddAll.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesAddAll.ImageAlign")));
			this.buttonDevicesAddAll.ImageIndex = ((int)(resources.GetObject("buttonDevicesAddAll.ImageIndex")));
			this.buttonDevicesAddAll.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonDevicesAddAll.ImeMode")));
			this.buttonDevicesAddAll.Location = ((System.Drawing.Point)(resources.GetObject("buttonDevicesAddAll.Location")));
			this.buttonDevicesAddAll.Name = "buttonDevicesAddAll";
			this.buttonDevicesAddAll.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonDevicesAddAll.RightToLeft")));
			this.buttonDevicesAddAll.Size = ((System.Drawing.Size)(resources.GetObject("buttonDevicesAddAll.Size")));
			this.buttonDevicesAddAll.TabIndex = ((int)(resources.GetObject("buttonDevicesAddAll.TabIndex")));
			this.buttonDevicesAddAll.Text = resources.GetString("buttonDevicesAddAll.Text");
			this.buttonDevicesAddAll.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesAddAll.TextAlign")));
			this.buttonDevicesAddAll.Visible = ((bool)(resources.GetObject("buttonDevicesAddAll.Visible")));
			this.buttonDevicesAddAll.Click += new System.EventHandler(this.buttonDevicesAddAll_Click);
			// 
			// buttonDevicesAdd
			// 
			this.buttonDevicesAdd.AccessibleDescription = resources.GetString("buttonDevicesAdd.AccessibleDescription");
			this.buttonDevicesAdd.AccessibleName = resources.GetString("buttonDevicesAdd.AccessibleName");
			this.buttonDevicesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonDevicesAdd.Anchor")));
			this.buttonDevicesAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevicesAdd.BackgroundImage")));
			this.buttonDevicesAdd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonDevicesAdd.Dock")));
			this.buttonDevicesAdd.Enabled = ((bool)(resources.GetObject("buttonDevicesAdd.Enabled")));
			this.buttonDevicesAdd.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonDevicesAdd.FlatStyle")));
			this.buttonDevicesAdd.Font = ((System.Drawing.Font)(resources.GetObject("buttonDevicesAdd.Font")));
			this.buttonDevicesAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevicesAdd.Image")));
			this.buttonDevicesAdd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesAdd.ImageAlign")));
			this.buttonDevicesAdd.ImageIndex = ((int)(resources.GetObject("buttonDevicesAdd.ImageIndex")));
			this.buttonDevicesAdd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonDevicesAdd.ImeMode")));
			this.buttonDevicesAdd.Location = ((System.Drawing.Point)(resources.GetObject("buttonDevicesAdd.Location")));
			this.buttonDevicesAdd.Name = "buttonDevicesAdd";
			this.buttonDevicesAdd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonDevicesAdd.RightToLeft")));
			this.buttonDevicesAdd.Size = ((System.Drawing.Size)(resources.GetObject("buttonDevicesAdd.Size")));
			this.buttonDevicesAdd.TabIndex = ((int)(resources.GetObject("buttonDevicesAdd.TabIndex")));
			this.buttonDevicesAdd.Text = resources.GetString("buttonDevicesAdd.Text");
			this.buttonDevicesAdd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonDevicesAdd.TextAlign")));
			this.buttonDevicesAdd.Visible = ((bool)(resources.GetObject("buttonDevicesAdd.Visible")));
			this.buttonDevicesAdd.Click += new System.EventHandler(this.buttonDevicesAdd_Click);
			// 
			// listBoxDevicesAssigned
			// 
			this.listBoxDevicesAssigned.AccessibleDescription = resources.GetString("listBoxDevicesAssigned.AccessibleDescription");
			this.listBoxDevicesAssigned.AccessibleName = resources.GetString("listBoxDevicesAssigned.AccessibleName");
			this.listBoxDevicesAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listBoxDevicesAssigned.Anchor")));
			this.listBoxDevicesAssigned.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listBoxDevicesAssigned.BackgroundImage")));
			this.listBoxDevicesAssigned.ColumnWidth = ((int)(resources.GetObject("listBoxDevicesAssigned.ColumnWidth")));
			this.listBoxDevicesAssigned.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listBoxDevicesAssigned.Dock")));
			this.listBoxDevicesAssigned.Enabled = ((bool)(resources.GetObject("listBoxDevicesAssigned.Enabled")));
			this.listBoxDevicesAssigned.Font = ((System.Drawing.Font)(resources.GetObject("listBoxDevicesAssigned.Font")));
			this.listBoxDevicesAssigned.HorizontalExtent = ((int)(resources.GetObject("listBoxDevicesAssigned.HorizontalExtent")));
			this.listBoxDevicesAssigned.HorizontalScrollbar = ((bool)(resources.GetObject("listBoxDevicesAssigned.HorizontalScrollbar")));
			this.listBoxDevicesAssigned.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listBoxDevicesAssigned.ImeMode")));
			this.listBoxDevicesAssigned.IntegralHeight = ((bool)(resources.GetObject("listBoxDevicesAssigned.IntegralHeight")));
			this.listBoxDevicesAssigned.ItemHeight = ((int)(resources.GetObject("listBoxDevicesAssigned.ItemHeight")));
			this.listBoxDevicesAssigned.Location = ((System.Drawing.Point)(resources.GetObject("listBoxDevicesAssigned.Location")));
			this.listBoxDevicesAssigned.Name = "listBoxDevicesAssigned";
			this.listBoxDevicesAssigned.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listBoxDevicesAssigned.RightToLeft")));
			this.listBoxDevicesAssigned.ScrollAlwaysVisible = ((bool)(resources.GetObject("listBoxDevicesAssigned.ScrollAlwaysVisible")));
			this.listBoxDevicesAssigned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxDevicesAssigned.Size = ((System.Drawing.Size)(resources.GetObject("listBoxDevicesAssigned.Size")));
			this.listBoxDevicesAssigned.Sorted = true;
			this.listBoxDevicesAssigned.TabIndex = ((int)(resources.GetObject("listBoxDevicesAssigned.TabIndex")));
			this.listBoxDevicesAssigned.Visible = ((bool)(resources.GetObject("listBoxDevicesAssigned.Visible")));
			// 
			// labelDevicesAssignedCap
			// 
			this.labelDevicesAssignedCap.AccessibleDescription = resources.GetString("labelDevicesAssignedCap.AccessibleDescription");
			this.labelDevicesAssignedCap.AccessibleName = resources.GetString("labelDevicesAssignedCap.AccessibleName");
			this.labelDevicesAssignedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDevicesAssignedCap.Anchor")));
			this.labelDevicesAssignedCap.AutoSize = ((bool)(resources.GetObject("labelDevicesAssignedCap.AutoSize")));
			this.labelDevicesAssignedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDevicesAssignedCap.Dock")));
			this.labelDevicesAssignedCap.Enabled = ((bool)(resources.GetObject("labelDevicesAssignedCap.Enabled")));
			this.labelDevicesAssignedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDevicesAssignedCap.Font")));
			this.labelDevicesAssignedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDevicesAssignedCap.Image")));
			this.labelDevicesAssignedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDevicesAssignedCap.ImageAlign")));
			this.labelDevicesAssignedCap.ImageIndex = ((int)(resources.GetObject("labelDevicesAssignedCap.ImageIndex")));
			this.labelDevicesAssignedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDevicesAssignedCap.ImeMode")));
			this.labelDevicesAssignedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDevicesAssignedCap.Location")));
			this.labelDevicesAssignedCap.Name = "labelDevicesAssignedCap";
			this.labelDevicesAssignedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDevicesAssignedCap.RightToLeft")));
			this.labelDevicesAssignedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDevicesAssignedCap.Size")));
			this.labelDevicesAssignedCap.TabIndex = ((int)(resources.GetObject("labelDevicesAssignedCap.TabIndex")));
			this.labelDevicesAssignedCap.Text = resources.GetString("labelDevicesAssignedCap.Text");
			this.labelDevicesAssignedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDevicesAssignedCap.TextAlign")));
			this.labelDevicesAssignedCap.Visible = ((bool)(resources.GetObject("labelDevicesAssignedCap.Visible")));
			// 
			// listBoxDevicesUnassigned
			// 
			this.listBoxDevicesUnassigned.AccessibleDescription = resources.GetString("listBoxDevicesUnassigned.AccessibleDescription");
			this.listBoxDevicesUnassigned.AccessibleName = resources.GetString("listBoxDevicesUnassigned.AccessibleName");
			this.listBoxDevicesUnassigned.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listBoxDevicesUnassigned.Anchor")));
			this.listBoxDevicesUnassigned.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listBoxDevicesUnassigned.BackgroundImage")));
			this.listBoxDevicesUnassigned.ColumnWidth = ((int)(resources.GetObject("listBoxDevicesUnassigned.ColumnWidth")));
			this.listBoxDevicesUnassigned.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listBoxDevicesUnassigned.Dock")));
			this.listBoxDevicesUnassigned.Enabled = ((bool)(resources.GetObject("listBoxDevicesUnassigned.Enabled")));
			this.listBoxDevicesUnassigned.Font = ((System.Drawing.Font)(resources.GetObject("listBoxDevicesUnassigned.Font")));
			this.listBoxDevicesUnassigned.HorizontalExtent = ((int)(resources.GetObject("listBoxDevicesUnassigned.HorizontalExtent")));
			this.listBoxDevicesUnassigned.HorizontalScrollbar = ((bool)(resources.GetObject("listBoxDevicesUnassigned.HorizontalScrollbar")));
			this.listBoxDevicesUnassigned.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listBoxDevicesUnassigned.ImeMode")));
			this.listBoxDevicesUnassigned.IntegralHeight = ((bool)(resources.GetObject("listBoxDevicesUnassigned.IntegralHeight")));
			this.listBoxDevicesUnassigned.ItemHeight = ((int)(resources.GetObject("listBoxDevicesUnassigned.ItemHeight")));
			this.listBoxDevicesUnassigned.Location = ((System.Drawing.Point)(resources.GetObject("listBoxDevicesUnassigned.Location")));
			this.listBoxDevicesUnassigned.Name = "listBoxDevicesUnassigned";
			this.listBoxDevicesUnassigned.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listBoxDevicesUnassigned.RightToLeft")));
			this.listBoxDevicesUnassigned.ScrollAlwaysVisible = ((bool)(resources.GetObject("listBoxDevicesUnassigned.ScrollAlwaysVisible")));
			this.listBoxDevicesUnassigned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxDevicesUnassigned.Size = ((System.Drawing.Size)(resources.GetObject("listBoxDevicesUnassigned.Size")));
			this.listBoxDevicesUnassigned.Sorted = true;
			this.listBoxDevicesUnassigned.TabIndex = ((int)(resources.GetObject("listBoxDevicesUnassigned.TabIndex")));
			this.listBoxDevicesUnassigned.Visible = ((bool)(resources.GetObject("listBoxDevicesUnassigned.Visible")));
			// 
			// labelDevicesUnassignedCap
			// 
			this.labelDevicesUnassignedCap.AccessibleDescription = resources.GetString("labelDevicesUnassignedCap.AccessibleDescription");
			this.labelDevicesUnassignedCap.AccessibleName = resources.GetString("labelDevicesUnassignedCap.AccessibleName");
			this.labelDevicesUnassignedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDevicesUnassignedCap.Anchor")));
			this.labelDevicesUnassignedCap.AutoSize = ((bool)(resources.GetObject("labelDevicesUnassignedCap.AutoSize")));
			this.labelDevicesUnassignedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDevicesUnassignedCap.Dock")));
			this.labelDevicesUnassignedCap.Enabled = ((bool)(resources.GetObject("labelDevicesUnassignedCap.Enabled")));
			this.labelDevicesUnassignedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDevicesUnassignedCap.Font")));
			this.labelDevicesUnassignedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDevicesUnassignedCap.Image")));
			this.labelDevicesUnassignedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDevicesUnassignedCap.ImageAlign")));
			this.labelDevicesUnassignedCap.ImageIndex = ((int)(resources.GetObject("labelDevicesUnassignedCap.ImageIndex")));
			this.labelDevicesUnassignedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDevicesUnassignedCap.ImeMode")));
			this.labelDevicesUnassignedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDevicesUnassignedCap.Location")));
			this.labelDevicesUnassignedCap.Name = "labelDevicesUnassignedCap";
			this.labelDevicesUnassignedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDevicesUnassignedCap.RightToLeft")));
			this.labelDevicesUnassignedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDevicesUnassignedCap.Size")));
			this.labelDevicesUnassignedCap.TabIndex = ((int)(resources.GetObject("labelDevicesUnassignedCap.TabIndex")));
			this.labelDevicesUnassignedCap.Text = resources.GetString("labelDevicesUnassignedCap.Text");
			this.labelDevicesUnassignedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDevicesUnassignedCap.TextAlign")));
			this.labelDevicesUnassignedCap.Visible = ((bool)(resources.GetObject("labelDevicesUnassignedCap.Visible")));
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = resources.GetString("buttonOK.AccessibleDescription");
			this.buttonOK.AccessibleName = resources.GetString("buttonOK.AccessibleName");
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonOK.Anchor")));
			this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
			this.buttonOK.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonOK.Dock")));
			this.buttonOK.Enabled = ((bool)(resources.GetObject("buttonOK.Enabled")));
			this.buttonOK.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonOK.FlatStyle")));
			this.buttonOK.Font = ((System.Drawing.Font)(resources.GetObject("buttonOK.Font")));
			this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
			this.buttonOK.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonOK.ImageAlign")));
			this.buttonOK.ImageIndex = ((int)(resources.GetObject("buttonOK.ImageIndex")));
			this.buttonOK.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonOK.ImeMode")));
			this.buttonOK.Location = ((System.Drawing.Point)(resources.GetObject("buttonOK.Location")));
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonOK.RightToLeft")));
			this.buttonOK.Size = ((System.Drawing.Size)(resources.GetObject("buttonOK.Size")));
			this.buttonOK.TabIndex = ((int)(resources.GetObject("buttonOK.TabIndex")));
			this.buttonOK.Text = resources.GetString("buttonOK.Text");
			this.buttonOK.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonOK.TextAlign")));
			this.buttonOK.Visible = ((bool)(resources.GetObject("buttonOK.Visible")));
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = resources.GetString("buttonCancel.AccessibleDescription");
			this.buttonCancel.AccessibleName = resources.GetString("buttonCancel.AccessibleName");
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("buttonCancel.Anchor")));
			this.buttonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancel.BackgroundImage")));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("buttonCancel.Dock")));
			this.buttonCancel.Enabled = ((bool)(resources.GetObject("buttonCancel.Enabled")));
			this.buttonCancel.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("buttonCancel.FlatStyle")));
			this.buttonCancel.Font = ((System.Drawing.Font)(resources.GetObject("buttonCancel.Font")));
			this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
			this.buttonCancel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonCancel.ImageAlign")));
			this.buttonCancel.ImageIndex = ((int)(resources.GetObject("buttonCancel.ImageIndex")));
			this.buttonCancel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("buttonCancel.ImeMode")));
			this.buttonCancel.Location = ((System.Drawing.Point)(resources.GetObject("buttonCancel.Location")));
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("buttonCancel.RightToLeft")));
			this.buttonCancel.Size = ((System.Drawing.Size)(resources.GetObject("buttonCancel.Size")));
			this.buttonCancel.TabIndex = ((int)(resources.GetObject("buttonCancel.TabIndex")));
			this.buttonCancel.Text = resources.GetString("buttonCancel.Text");
			this.buttonCancel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("buttonCancel.TextAlign")));
			this.buttonCancel.Visible = ((bool)(resources.GetObject("buttonCancel.Visible")));
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
			this.openFileDialog.Title = resources.GetString("openFileDialog.Title");
			// 
			// SiteForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CancelButton = this.buttonCancel;
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBoxDevices);
			this.Controls.Add(this.buttonPictureFile);
			this.Controls.Add(this.textBoxPictureFile);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.labelPictureFileCap);
			this.Controls.Add(this.labelNameCap);
			this.Controls.Add(this.labelCodeCap);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "SiteForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.groupBoxDevices.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Steuerelemente --------------------

		/// <summary>
		/// entfernt führende und abschließende Leerzeichen
		/// </summary>
		private void textBoxCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBoxCode.Text = textBoxCode.Text.Trim();
		}

		/// <summary>
		/// zeigt Auswahldialog für Hintergrundbild an
		/// </summary>
		private void buttonPictureFile_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Dialog initialisieren
				openFileDialog.FileName = "";

				// Dialog anzeigen
				openFileDialog.ShowDialog(this);

				// wenn Dialog bestätigt, Dateiname übernehmen
				if (openFileDialog.FileName != "")
				{
					textBoxPictureFile.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on selecting picture file.", ex);
			}
		}

		/// <summary>
		/// fügt markierte Devices zu Auswahl hinzu
		/// </summary>
		private void buttonDevicesAdd_Click(object sender, System.EventArgs e)
		{
			try
			{
				// alle markierten freien Devices zu Auswahl hinzufügen
				while (listBoxDevicesUnassigned.SelectedItem != null)
				{
					listBoxDevicesAssigned.Items.Add(listBoxDevicesUnassigned.SelectedItem);
					listBoxDevicesUnassigned.Items.Remove(listBoxDevicesUnassigned.SelectedItem);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on assigning devices.", ex);
			}
		}

		/// <summary>
		/// entfernt markierte Devices von Auswahl
		/// </summary>
		private void buttonDevicesRemove_Click(object sender, System.EventArgs e)
		{
			try
			{
				// alle markierten Devices von Auswahl entfernen
				while (listBoxDevicesAssigned.SelectedItem != null)
				{
					listBoxDevicesUnassigned.Items.Add(listBoxDevicesAssigned.SelectedItem);
					listBoxDevicesAssigned.Items.Remove(listBoxDevicesAssigned.SelectedItem);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on assigning devices.", ex);
			}
		}

		/// <summary>
		/// fügt alle Devices zu Auswahl hinzu
		/// </summary>
		private void buttonDevicesAddAll_Click(object sender, System.EventArgs e)
		{
			try
			{
				// alle freien Devices zu Auswahl hinzufügen
				while (listBoxDevicesUnassigned.Items.Count > 0)
				{
					listBoxDevicesAssigned.Items.Add(listBoxDevicesUnassigned.Items[0]);
					listBoxDevicesUnassigned.Items.Remove(listBoxDevicesUnassigned.Items[0]);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on assigning devices.", ex);
			}
		}

		/// <summary>
		/// entfernt alle Devices von Auswahl
		/// </summary>
		private void buttonDevicesRemoveAll_Click(object sender, System.EventArgs e)
		{
			try
			{
				// alle Devices von Auswahl entfernen
				while (listBoxDevicesAssigned.Items.Count > 0)
				{
					listBoxDevicesUnassigned.Items.Add(listBoxDevicesAssigned.Items[0]);
					listBoxDevicesAssigned.Items.Remove(listBoxDevicesAssigned.Items[0]);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on assigning devices.", ex);
			}
		}

		/// <summary>
		/// speichert Raum und entlädt Formular
		/// </summary>
		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Sanduhr anzeigen
				this.Cursor = Cursors.WaitCursor;

				// wenn Parameter gültig
				if (CheckParameters())
				{
					// wenn Raum noch nicht existiert, neu anlegen
					if (_site == null)
					{
						_site = new Site(textBoxCode.Text, _mainControl.SiteControl);
					}

					// Raum aktualisieren
					_site.RefreshParameters(textBoxName.Text, textBoxPictureFile.Text);

					// Devicezuordnung aktualisieren
					AssignDevices();

					// Formular schließen
					this.Close();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on saving site.", ex);
			}
			finally
			{
				// Sanduhr verbergen
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// schließt Formular
		/// </summary>
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region----------------------------- sonstige Methoden ------------------------------------

		/// <summary>
		/// initialisiert Devicelisten
		/// </summary>
		private void InitDevices()
		{
			// Devicelisten initialisieren
			foreach (Device device in _mainControl.DeviceControl)
			{
				if (device.Site == null)
				{
					listBoxDevicesUnassigned.Items.Add(device.Code);
				}
				else
				{
					if (device.Site == _site)
					{
						listBoxDevicesAssigned.Items.Add(device.Code);
					}
				}
			}
		}

		/// <summary>
		/// aktualisiert Devicezuordnung
		/// </summary>
		private void AssignDevices()
		{
			// Raumzuordnung freier Devices entfernen
			foreach (string item in listBoxDevicesUnassigned.Items)
			{
				Device device = _mainControl.DeviceControl[item];
				if (device.Site != null)
				{
					device.UnassignSite();
				}
			}

			// ausgewählte Devices Raum zuordnen
			foreach (string item in listBoxDevicesAssigned.Items)
			{
				Device device = _mainControl.DeviceControl[item];
				if (device.Site == null)
				{
					device.AssignSite(_site);
				}
			}
		}

		/// <summary>
		/// prüft Parameter
		/// </summary>
		private bool CheckParameters()
		{
			// Code formal prüfen
			if (textBoxCode.Text == "")
			{
				MessageBox.Show(this, Resources.GetString("SiteForm.MessageBox.Text.CodeEmpty"),
					Resources.GetString("SiteForm.MessageBox.Caption.CodeEmpty"),
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			// prüfen, ob Code schon vergeben
			if ((_site == null) && (_mainControl.SiteControl[textBoxCode.Text] != null))
			{
				MessageBox.Show(this, Resources.GetString("SiteForm.MessageBox.Text.CodeExists"),
					Resources.GetString("SiteForm.MessageBox.Caption.CodeExists"),
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			// prüfen, ob Hintergrundbild existiert
			if ((textBoxPictureFile.Text != "") && (!File.Exists(textBoxPictureFile.Text)))
			{
				MessageBox.Show(this, Resources.GetString("SiteForm.MessageBox.Text.FileNotFound"),
					Resources.GetString("SiteForm.MessageBox.Caption.FileNotFound"),
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			return true;
		}

		#endregion

		#endregion
	}
}
