using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung eines Frontends.
	/// </summary>
	public class FrontendView : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxCommon;
		private System.Windows.Forms.Label labelAgentCodeCap;
		private System.Windows.Forms.TextBox textBoxAgentCode;
		private System.Windows.Forms.Label labelDeviceCodeCap;
		private System.Windows.Forms.TextBox textBoxDeviceCode;
		private System.Windows.Forms.Label labelCampaignNameCap;
		private System.Windows.Forms.TextBox textBoxCampaignName;
		private System.Windows.Forms.Label labelAgentModeCap;
		private System.Windows.Forms.Label labelAgentMode;
		private System.Windows.Forms.Label labelStateCap;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.Label labelStateTimeCap;
		private System.Windows.Forms.Label labelStateTime;
		private System.Windows.Forms.GroupBox groupBoxCoaching;
		private System.Windows.Forms.Label labelMonitorCodeCap;
		private System.Windows.Forms.TextBox textBoxMonitorCode;
		private System.Windows.Forms.Label labelCoachingModeCap;
		private System.Windows.Forms.TextBox textBoxCoachingMode;
		private System.Windows.Forms.Label labelCoachingPermissionCap;
		private System.Windows.Forms.Label labelCoachingPermission;
		private System.Windows.Forms.GroupBox groupBoxStateTimes;
		private System.Windows.Forms.Label labelStateTimeAvgTtlTalkingCap;
		private System.Windows.Forms.Label labelStateTimeAvgTtlTalking;
		private System.Windows.Forms.Label labelStateTimeAvgTtlWrapupCap;
		private System.Windows.Forms.Label labelStateTimeAvgTtlWrapup;
		private System.Windows.Forms.Label labelStateTimeAvgTtlReadyCap;
		private System.Windows.Forms.Label labelStateTimeAvgTtlReady;
		private System.Windows.Forms.GroupBox groupBoxStateDistribution;
		private itCampus.bb.Graph.Pie.Pie pieStateTimeTtl;
		private System.Windows.Forms.Timer timerRefresh;
		private System.ComponentModel.IContainer components;

		// Parameter
		private DateTime _lastStateChange; // Zeitpunkt für letzten Statuswechsel

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Frontendansicht
		/// </summary>
		public FrontendView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Parameter initialisieren
			_lastStateChange = DateTime.Now;

			// Timer für Aktualisierung starten
			timerRefresh.Start();
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

		#region----------------------------- Component Designer generated code --------------------

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrontendView));
			itCampus.bb.Graph.Pie.Slice slice1 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice2 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice3 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice4 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice5 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice6 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice7 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice8 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice9 = new itCampus.bb.Graph.Pie.Slice();
			this.groupBoxCommon = new System.Windows.Forms.GroupBox();
			this.labelAgentCodeCap = new System.Windows.Forms.Label();
			this.textBoxAgentCode = new System.Windows.Forms.TextBox();
			this.labelDeviceCodeCap = new System.Windows.Forms.Label();
			this.textBoxDeviceCode = new System.Windows.Forms.TextBox();
			this.labelCampaignNameCap = new System.Windows.Forms.Label();
			this.textBoxCampaignName = new System.Windows.Forms.TextBox();
			this.labelAgentModeCap = new System.Windows.Forms.Label();
			this.labelAgentMode = new System.Windows.Forms.Label();
			this.labelStateCap = new System.Windows.Forms.Label();
			this.labelState = new System.Windows.Forms.Label();
			this.labelStateTimeCap = new System.Windows.Forms.Label();
			this.labelStateTime = new System.Windows.Forms.Label();
			this.groupBoxCoaching = new System.Windows.Forms.GroupBox();
			this.labelMonitorCodeCap = new System.Windows.Forms.Label();
			this.textBoxMonitorCode = new System.Windows.Forms.TextBox();
			this.labelCoachingModeCap = new System.Windows.Forms.Label();
			this.textBoxCoachingMode = new System.Windows.Forms.TextBox();
			this.labelCoachingPermissionCap = new System.Windows.Forms.Label();
			this.labelCoachingPermission = new System.Windows.Forms.Label();
			this.groupBoxStateTimes = new System.Windows.Forms.GroupBox();
			this.labelStateTimeAvgTtlTalkingCap = new System.Windows.Forms.Label();
			this.labelStateTimeAvgTtlTalking = new System.Windows.Forms.Label();
			this.labelStateTimeAvgTtlWrapupCap = new System.Windows.Forms.Label();
			this.labelStateTimeAvgTtlWrapup = new System.Windows.Forms.Label();
			this.labelStateTimeAvgTtlReadyCap = new System.Windows.Forms.Label();
			this.labelStateTimeAvgTtlReady = new System.Windows.Forms.Label();
			this.groupBoxStateDistribution = new System.Windows.Forms.GroupBox();
			this.pieStateTimeTtl = new itCampus.bb.Graph.Pie.Pie();
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.groupBoxCommon.SuspendLayout();
			this.groupBoxCoaching.SuspendLayout();
			this.groupBoxStateTimes.SuspendLayout();
			this.groupBoxStateDistribution.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pieStateTimeTtl)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxCommon
			// 
			this.groupBoxCommon.AccessibleDescription = resources.GetString("groupBoxCommon.AccessibleDescription");
			this.groupBoxCommon.AccessibleName = resources.GetString("groupBoxCommon.AccessibleName");
			this.groupBoxCommon.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxCommon.Anchor")));
			this.groupBoxCommon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxCommon.BackgroundImage")));
			this.groupBoxCommon.Controls.Add(this.labelAgentCodeCap);
			this.groupBoxCommon.Controls.Add(this.textBoxAgentCode);
			this.groupBoxCommon.Controls.Add(this.labelDeviceCodeCap);
			this.groupBoxCommon.Controls.Add(this.textBoxDeviceCode);
			this.groupBoxCommon.Controls.Add(this.labelCampaignNameCap);
			this.groupBoxCommon.Controls.Add(this.textBoxCampaignName);
			this.groupBoxCommon.Controls.Add(this.labelAgentModeCap);
			this.groupBoxCommon.Controls.Add(this.labelAgentMode);
			this.groupBoxCommon.Controls.Add(this.labelStateCap);
			this.groupBoxCommon.Controls.Add(this.labelState);
			this.groupBoxCommon.Controls.Add(this.labelStateTimeCap);
			this.groupBoxCommon.Controls.Add(this.labelStateTime);
			this.groupBoxCommon.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxCommon.Dock")));
			this.groupBoxCommon.Enabled = ((bool)(resources.GetObject("groupBoxCommon.Enabled")));
			this.groupBoxCommon.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxCommon.Font")));
			this.groupBoxCommon.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxCommon.ImeMode")));
			this.groupBoxCommon.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxCommon.Location")));
			this.groupBoxCommon.Name = "groupBoxCommon";
			this.groupBoxCommon.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxCommon.RightToLeft")));
			this.groupBoxCommon.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxCommon.Size")));
			this.groupBoxCommon.TabIndex = ((int)(resources.GetObject("groupBoxCommon.TabIndex")));
			this.groupBoxCommon.TabStop = false;
			this.groupBoxCommon.Text = resources.GetString("groupBoxCommon.Text");
			this.groupBoxCommon.Visible = ((bool)(resources.GetObject("groupBoxCommon.Visible")));
			// 
			// labelAgentCodeCap
			// 
			this.labelAgentCodeCap.AccessibleDescription = resources.GetString("labelAgentCodeCap.AccessibleDescription");
			this.labelAgentCodeCap.AccessibleName = resources.GetString("labelAgentCodeCap.AccessibleName");
			this.labelAgentCodeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentCodeCap.Anchor")));
			this.labelAgentCodeCap.AutoSize = ((bool)(resources.GetObject("labelAgentCodeCap.AutoSize")));
			this.labelAgentCodeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentCodeCap.Dock")));
			this.labelAgentCodeCap.Enabled = ((bool)(resources.GetObject("labelAgentCodeCap.Enabled")));
			this.labelAgentCodeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentCodeCap.Font")));
			this.labelAgentCodeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentCodeCap.Image")));
			this.labelAgentCodeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentCodeCap.ImageAlign")));
			this.labelAgentCodeCap.ImageIndex = ((int)(resources.GetObject("labelAgentCodeCap.ImageIndex")));
			this.labelAgentCodeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentCodeCap.ImeMode")));
			this.labelAgentCodeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentCodeCap.Location")));
			this.labelAgentCodeCap.Name = "labelAgentCodeCap";
			this.labelAgentCodeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentCodeCap.RightToLeft")));
			this.labelAgentCodeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentCodeCap.Size")));
			this.labelAgentCodeCap.TabIndex = ((int)(resources.GetObject("labelAgentCodeCap.TabIndex")));
			this.labelAgentCodeCap.Text = resources.GetString("labelAgentCodeCap.Text");
			this.labelAgentCodeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentCodeCap.TextAlign")));
			this.labelAgentCodeCap.Visible = ((bool)(resources.GetObject("labelAgentCodeCap.Visible")));
			// 
			// textBoxAgentCode
			// 
			this.textBoxAgentCode.AccessibleDescription = resources.GetString("textBoxAgentCode.AccessibleDescription");
			this.textBoxAgentCode.AccessibleName = resources.GetString("textBoxAgentCode.AccessibleName");
			this.textBoxAgentCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxAgentCode.Anchor")));
			this.textBoxAgentCode.AutoSize = ((bool)(resources.GetObject("textBoxAgentCode.AutoSize")));
			this.textBoxAgentCode.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxAgentCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxAgentCode.BackgroundImage")));
			this.textBoxAgentCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAgentCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxAgentCode.Dock")));
			this.textBoxAgentCode.Enabled = ((bool)(resources.GetObject("textBoxAgentCode.Enabled")));
			this.textBoxAgentCode.Font = ((System.Drawing.Font)(resources.GetObject("textBoxAgentCode.Font")));
			this.textBoxAgentCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxAgentCode.ImeMode")));
			this.textBoxAgentCode.Location = ((System.Drawing.Point)(resources.GetObject("textBoxAgentCode.Location")));
			this.textBoxAgentCode.MaxLength = ((int)(resources.GetObject("textBoxAgentCode.MaxLength")));
			this.textBoxAgentCode.Multiline = ((bool)(resources.GetObject("textBoxAgentCode.Multiline")));
			this.textBoxAgentCode.Name = "textBoxAgentCode";
			this.textBoxAgentCode.PasswordChar = ((char)(resources.GetObject("textBoxAgentCode.PasswordChar")));
			this.textBoxAgentCode.ReadOnly = true;
			this.textBoxAgentCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxAgentCode.RightToLeft")));
			this.textBoxAgentCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxAgentCode.ScrollBars")));
			this.textBoxAgentCode.Size = ((System.Drawing.Size)(resources.GetObject("textBoxAgentCode.Size")));
			this.textBoxAgentCode.TabIndex = ((int)(resources.GetObject("textBoxAgentCode.TabIndex")));
			this.textBoxAgentCode.TabStop = false;
			this.textBoxAgentCode.Text = resources.GetString("textBoxAgentCode.Text");
			this.textBoxAgentCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxAgentCode.TextAlign")));
			this.textBoxAgentCode.Visible = ((bool)(resources.GetObject("textBoxAgentCode.Visible")));
			this.textBoxAgentCode.WordWrap = ((bool)(resources.GetObject("textBoxAgentCode.WordWrap")));
			// 
			// labelDeviceCodeCap
			// 
			this.labelDeviceCodeCap.AccessibleDescription = resources.GetString("labelDeviceCodeCap.AccessibleDescription");
			this.labelDeviceCodeCap.AccessibleName = resources.GetString("labelDeviceCodeCap.AccessibleName");
			this.labelDeviceCodeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDeviceCodeCap.Anchor")));
			this.labelDeviceCodeCap.AutoSize = ((bool)(resources.GetObject("labelDeviceCodeCap.AutoSize")));
			this.labelDeviceCodeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDeviceCodeCap.Dock")));
			this.labelDeviceCodeCap.Enabled = ((bool)(resources.GetObject("labelDeviceCodeCap.Enabled")));
			this.labelDeviceCodeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDeviceCodeCap.Font")));
			this.labelDeviceCodeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDeviceCodeCap.Image")));
			this.labelDeviceCodeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDeviceCodeCap.ImageAlign")));
			this.labelDeviceCodeCap.ImageIndex = ((int)(resources.GetObject("labelDeviceCodeCap.ImageIndex")));
			this.labelDeviceCodeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDeviceCodeCap.ImeMode")));
			this.labelDeviceCodeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDeviceCodeCap.Location")));
			this.labelDeviceCodeCap.Name = "labelDeviceCodeCap";
			this.labelDeviceCodeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDeviceCodeCap.RightToLeft")));
			this.labelDeviceCodeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDeviceCodeCap.Size")));
			this.labelDeviceCodeCap.TabIndex = ((int)(resources.GetObject("labelDeviceCodeCap.TabIndex")));
			this.labelDeviceCodeCap.Text = resources.GetString("labelDeviceCodeCap.Text");
			this.labelDeviceCodeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDeviceCodeCap.TextAlign")));
			this.labelDeviceCodeCap.Visible = ((bool)(resources.GetObject("labelDeviceCodeCap.Visible")));
			// 
			// textBoxDeviceCode
			// 
			this.textBoxDeviceCode.AccessibleDescription = resources.GetString("textBoxDeviceCode.AccessibleDescription");
			this.textBoxDeviceCode.AccessibleName = resources.GetString("textBoxDeviceCode.AccessibleName");
			this.textBoxDeviceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxDeviceCode.Anchor")));
			this.textBoxDeviceCode.AutoSize = ((bool)(resources.GetObject("textBoxDeviceCode.AutoSize")));
			this.textBoxDeviceCode.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxDeviceCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxDeviceCode.BackgroundImage")));
			this.textBoxDeviceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDeviceCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxDeviceCode.Dock")));
			this.textBoxDeviceCode.Enabled = ((bool)(resources.GetObject("textBoxDeviceCode.Enabled")));
			this.textBoxDeviceCode.Font = ((System.Drawing.Font)(resources.GetObject("textBoxDeviceCode.Font")));
			this.textBoxDeviceCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxDeviceCode.ImeMode")));
			this.textBoxDeviceCode.Location = ((System.Drawing.Point)(resources.GetObject("textBoxDeviceCode.Location")));
			this.textBoxDeviceCode.MaxLength = ((int)(resources.GetObject("textBoxDeviceCode.MaxLength")));
			this.textBoxDeviceCode.Multiline = ((bool)(resources.GetObject("textBoxDeviceCode.Multiline")));
			this.textBoxDeviceCode.Name = "textBoxDeviceCode";
			this.textBoxDeviceCode.PasswordChar = ((char)(resources.GetObject("textBoxDeviceCode.PasswordChar")));
			this.textBoxDeviceCode.ReadOnly = true;
			this.textBoxDeviceCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxDeviceCode.RightToLeft")));
			this.textBoxDeviceCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxDeviceCode.ScrollBars")));
			this.textBoxDeviceCode.Size = ((System.Drawing.Size)(resources.GetObject("textBoxDeviceCode.Size")));
			this.textBoxDeviceCode.TabIndex = ((int)(resources.GetObject("textBoxDeviceCode.TabIndex")));
			this.textBoxDeviceCode.TabStop = false;
			this.textBoxDeviceCode.Text = resources.GetString("textBoxDeviceCode.Text");
			this.textBoxDeviceCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxDeviceCode.TextAlign")));
			this.textBoxDeviceCode.Visible = ((bool)(resources.GetObject("textBoxDeviceCode.Visible")));
			this.textBoxDeviceCode.WordWrap = ((bool)(resources.GetObject("textBoxDeviceCode.WordWrap")));
			// 
			// labelCampaignNameCap
			// 
			this.labelCampaignNameCap.AccessibleDescription = resources.GetString("labelCampaignNameCap.AccessibleDescription");
			this.labelCampaignNameCap.AccessibleName = resources.GetString("labelCampaignNameCap.AccessibleName");
			this.labelCampaignNameCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCampaignNameCap.Anchor")));
			this.labelCampaignNameCap.AutoSize = ((bool)(resources.GetObject("labelCampaignNameCap.AutoSize")));
			this.labelCampaignNameCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCampaignNameCap.Dock")));
			this.labelCampaignNameCap.Enabled = ((bool)(resources.GetObject("labelCampaignNameCap.Enabled")));
			this.labelCampaignNameCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCampaignNameCap.Font")));
			this.labelCampaignNameCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCampaignNameCap.Image")));
			this.labelCampaignNameCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCampaignNameCap.ImageAlign")));
			this.labelCampaignNameCap.ImageIndex = ((int)(resources.GetObject("labelCampaignNameCap.ImageIndex")));
			this.labelCampaignNameCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCampaignNameCap.ImeMode")));
			this.labelCampaignNameCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCampaignNameCap.Location")));
			this.labelCampaignNameCap.Name = "labelCampaignNameCap";
			this.labelCampaignNameCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCampaignNameCap.RightToLeft")));
			this.labelCampaignNameCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCampaignNameCap.Size")));
			this.labelCampaignNameCap.TabIndex = ((int)(resources.GetObject("labelCampaignNameCap.TabIndex")));
			this.labelCampaignNameCap.Text = resources.GetString("labelCampaignNameCap.Text");
			this.labelCampaignNameCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCampaignNameCap.TextAlign")));
			this.labelCampaignNameCap.Visible = ((bool)(resources.GetObject("labelCampaignNameCap.Visible")));
			// 
			// textBoxCampaignName
			// 
			this.textBoxCampaignName.AccessibleDescription = resources.GetString("textBoxCampaignName.AccessibleDescription");
			this.textBoxCampaignName.AccessibleName = resources.GetString("textBoxCampaignName.AccessibleName");
			this.textBoxCampaignName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxCampaignName.Anchor")));
			this.textBoxCampaignName.AutoSize = ((bool)(resources.GetObject("textBoxCampaignName.AutoSize")));
			this.textBoxCampaignName.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxCampaignName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCampaignName.BackgroundImage")));
			this.textBoxCampaignName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCampaignName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxCampaignName.Dock")));
			this.textBoxCampaignName.Enabled = ((bool)(resources.GetObject("textBoxCampaignName.Enabled")));
			this.textBoxCampaignName.Font = ((System.Drawing.Font)(resources.GetObject("textBoxCampaignName.Font")));
			this.textBoxCampaignName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxCampaignName.ImeMode")));
			this.textBoxCampaignName.Location = ((System.Drawing.Point)(resources.GetObject("textBoxCampaignName.Location")));
			this.textBoxCampaignName.MaxLength = ((int)(resources.GetObject("textBoxCampaignName.MaxLength")));
			this.textBoxCampaignName.Multiline = ((bool)(resources.GetObject("textBoxCampaignName.Multiline")));
			this.textBoxCampaignName.Name = "textBoxCampaignName";
			this.textBoxCampaignName.PasswordChar = ((char)(resources.GetObject("textBoxCampaignName.PasswordChar")));
			this.textBoxCampaignName.ReadOnly = true;
			this.textBoxCampaignName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxCampaignName.RightToLeft")));
			this.textBoxCampaignName.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxCampaignName.ScrollBars")));
			this.textBoxCampaignName.Size = ((System.Drawing.Size)(resources.GetObject("textBoxCampaignName.Size")));
			this.textBoxCampaignName.TabIndex = ((int)(resources.GetObject("textBoxCampaignName.TabIndex")));
			this.textBoxCampaignName.TabStop = false;
			this.textBoxCampaignName.Text = resources.GetString("textBoxCampaignName.Text");
			this.textBoxCampaignName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxCampaignName.TextAlign")));
			this.textBoxCampaignName.Visible = ((bool)(resources.GetObject("textBoxCampaignName.Visible")));
			this.textBoxCampaignName.WordWrap = ((bool)(resources.GetObject("textBoxCampaignName.WordWrap")));
			// 
			// labelAgentModeCap
			// 
			this.labelAgentModeCap.AccessibleDescription = resources.GetString("labelAgentModeCap.AccessibleDescription");
			this.labelAgentModeCap.AccessibleName = resources.GetString("labelAgentModeCap.AccessibleName");
			this.labelAgentModeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCap.Anchor")));
			this.labelAgentModeCap.AutoSize = ((bool)(resources.GetObject("labelAgentModeCap.AutoSize")));
			this.labelAgentModeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCap.Dock")));
			this.labelAgentModeCap.Enabled = ((bool)(resources.GetObject("labelAgentModeCap.Enabled")));
			this.labelAgentModeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCap.Font")));
			this.labelAgentModeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCap.Image")));
			this.labelAgentModeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCap.ImageAlign")));
			this.labelAgentModeCap.ImageIndex = ((int)(resources.GetObject("labelAgentModeCap.ImageIndex")));
			this.labelAgentModeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCap.ImeMode")));
			this.labelAgentModeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCap.Location")));
			this.labelAgentModeCap.Name = "labelAgentModeCap";
			this.labelAgentModeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCap.RightToLeft")));
			this.labelAgentModeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCap.Size")));
			this.labelAgentModeCap.TabIndex = ((int)(resources.GetObject("labelAgentModeCap.TabIndex")));
			this.labelAgentModeCap.Text = resources.GetString("labelAgentModeCap.Text");
			this.labelAgentModeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCap.TextAlign")));
			this.labelAgentModeCap.Visible = ((bool)(resources.GetObject("labelAgentModeCap.Visible")));
			// 
			// labelAgentMode
			// 
			this.labelAgentMode.AccessibleDescription = resources.GetString("labelAgentMode.AccessibleDescription");
			this.labelAgentMode.AccessibleName = resources.GetString("labelAgentMode.AccessibleName");
			this.labelAgentMode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentMode.Anchor")));
			this.labelAgentMode.AutoSize = ((bool)(resources.GetObject("labelAgentMode.AutoSize")));
			this.labelAgentMode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentMode.Dock")));
			this.labelAgentMode.Enabled = ((bool)(resources.GetObject("labelAgentMode.Enabled")));
			this.labelAgentMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelAgentMode.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentMode.Font")));
			this.labelAgentMode.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentMode.Image")));
			this.labelAgentMode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentMode.ImageAlign")));
			this.labelAgentMode.ImageIndex = ((int)(resources.GetObject("labelAgentMode.ImageIndex")));
			this.labelAgentMode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentMode.ImeMode")));
			this.labelAgentMode.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentMode.Location")));
			this.labelAgentMode.Name = "labelAgentMode";
			this.labelAgentMode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentMode.RightToLeft")));
			this.labelAgentMode.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentMode.Size")));
			this.labelAgentMode.TabIndex = ((int)(resources.GetObject("labelAgentMode.TabIndex")));
			this.labelAgentMode.Text = resources.GetString("labelAgentMode.Text");
			this.labelAgentMode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentMode.TextAlign")));
			this.labelAgentMode.Visible = ((bool)(resources.GetObject("labelAgentMode.Visible")));
			// 
			// labelStateCap
			// 
			this.labelStateCap.AccessibleDescription = resources.GetString("labelStateCap.AccessibleDescription");
			this.labelStateCap.AccessibleName = resources.GetString("labelStateCap.AccessibleName");
			this.labelStateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateCap.Anchor")));
			this.labelStateCap.AutoSize = ((bool)(resources.GetObject("labelStateCap.AutoSize")));
			this.labelStateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateCap.Dock")));
			this.labelStateCap.Enabled = ((bool)(resources.GetObject("labelStateCap.Enabled")));
			this.labelStateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelStateCap.Font")));
			this.labelStateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelStateCap.Image")));
			this.labelStateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateCap.ImageAlign")));
			this.labelStateCap.ImageIndex = ((int)(resources.GetObject("labelStateCap.ImageIndex")));
			this.labelStateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateCap.ImeMode")));
			this.labelStateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelStateCap.Location")));
			this.labelStateCap.Name = "labelStateCap";
			this.labelStateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateCap.RightToLeft")));
			this.labelStateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelStateCap.Size")));
			this.labelStateCap.TabIndex = ((int)(resources.GetObject("labelStateCap.TabIndex")));
			this.labelStateCap.Text = resources.GetString("labelStateCap.Text");
			this.labelStateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateCap.TextAlign")));
			this.labelStateCap.Visible = ((bool)(resources.GetObject("labelStateCap.Visible")));
			// 
			// labelState
			// 
			this.labelState.AccessibleDescription = resources.GetString("labelState.AccessibleDescription");
			this.labelState.AccessibleName = resources.GetString("labelState.AccessibleName");
			this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelState.Anchor")));
			this.labelState.AutoSize = ((bool)(resources.GetObject("labelState.AutoSize")));
			this.labelState.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelState.Dock")));
			this.labelState.Enabled = ((bool)(resources.GetObject("labelState.Enabled")));
			this.labelState.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelState.Font = ((System.Drawing.Font)(resources.GetObject("labelState.Font")));
			this.labelState.Image = ((System.Drawing.Image)(resources.GetObject("labelState.Image")));
			this.labelState.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelState.ImageAlign")));
			this.labelState.ImageIndex = ((int)(resources.GetObject("labelState.ImageIndex")));
			this.labelState.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelState.ImeMode")));
			this.labelState.Location = ((System.Drawing.Point)(resources.GetObject("labelState.Location")));
			this.labelState.Name = "labelState";
			this.labelState.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelState.RightToLeft")));
			this.labelState.Size = ((System.Drawing.Size)(resources.GetObject("labelState.Size")));
			this.labelState.TabIndex = ((int)(resources.GetObject("labelState.TabIndex")));
			this.labelState.Text = resources.GetString("labelState.Text");
			this.labelState.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelState.TextAlign")));
			this.labelState.Visible = ((bool)(resources.GetObject("labelState.Visible")));
			// 
			// labelStateTimeCap
			// 
			this.labelStateTimeCap.AccessibleDescription = resources.GetString("labelStateTimeCap.AccessibleDescription");
			this.labelStateTimeCap.AccessibleName = resources.GetString("labelStateTimeCap.AccessibleName");
			this.labelStateTimeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeCap.Anchor")));
			this.labelStateTimeCap.AutoSize = ((bool)(resources.GetObject("labelStateTimeCap.AutoSize")));
			this.labelStateTimeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeCap.Dock")));
			this.labelStateTimeCap.Enabled = ((bool)(resources.GetObject("labelStateTimeCap.Enabled")));
			this.labelStateTimeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeCap.Font")));
			this.labelStateTimeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeCap.Image")));
			this.labelStateTimeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeCap.ImageAlign")));
			this.labelStateTimeCap.ImageIndex = ((int)(resources.GetObject("labelStateTimeCap.ImageIndex")));
			this.labelStateTimeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeCap.ImeMode")));
			this.labelStateTimeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeCap.Location")));
			this.labelStateTimeCap.Name = "labelStateTimeCap";
			this.labelStateTimeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeCap.RightToLeft")));
			this.labelStateTimeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeCap.Size")));
			this.labelStateTimeCap.TabIndex = ((int)(resources.GetObject("labelStateTimeCap.TabIndex")));
			this.labelStateTimeCap.Text = resources.GetString("labelStateTimeCap.Text");
			this.labelStateTimeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeCap.TextAlign")));
			this.labelStateTimeCap.Visible = ((bool)(resources.GetObject("labelStateTimeCap.Visible")));
			// 
			// labelStateTime
			// 
			this.labelStateTime.AccessibleDescription = resources.GetString("labelStateTime.AccessibleDescription");
			this.labelStateTime.AccessibleName = resources.GetString("labelStateTime.AccessibleName");
			this.labelStateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTime.Anchor")));
			this.labelStateTime.AutoSize = ((bool)(resources.GetObject("labelStateTime.AutoSize")));
			this.labelStateTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTime.Dock")));
			this.labelStateTime.Enabled = ((bool)(resources.GetObject("labelStateTime.Enabled")));
			this.labelStateTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelStateTime.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTime.Font")));
			this.labelStateTime.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTime.Image")));
			this.labelStateTime.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTime.ImageAlign")));
			this.labelStateTime.ImageIndex = ((int)(resources.GetObject("labelStateTime.ImageIndex")));
			this.labelStateTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTime.ImeMode")));
			this.labelStateTime.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTime.Location")));
			this.labelStateTime.Name = "labelStateTime";
			this.labelStateTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTime.RightToLeft")));
			this.labelStateTime.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTime.Size")));
			this.labelStateTime.TabIndex = ((int)(resources.GetObject("labelStateTime.TabIndex")));
			this.labelStateTime.Text = resources.GetString("labelStateTime.Text");
			this.labelStateTime.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTime.TextAlign")));
			this.labelStateTime.Visible = ((bool)(resources.GetObject("labelStateTime.Visible")));
			// 
			// groupBoxCoaching
			// 
			this.groupBoxCoaching.AccessibleDescription = resources.GetString("groupBoxCoaching.AccessibleDescription");
			this.groupBoxCoaching.AccessibleName = resources.GetString("groupBoxCoaching.AccessibleName");
			this.groupBoxCoaching.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxCoaching.Anchor")));
			this.groupBoxCoaching.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxCoaching.BackgroundImage")));
			this.groupBoxCoaching.Controls.Add(this.labelMonitorCodeCap);
			this.groupBoxCoaching.Controls.Add(this.textBoxMonitorCode);
			this.groupBoxCoaching.Controls.Add(this.labelCoachingModeCap);
			this.groupBoxCoaching.Controls.Add(this.textBoxCoachingMode);
			this.groupBoxCoaching.Controls.Add(this.labelCoachingPermissionCap);
			this.groupBoxCoaching.Controls.Add(this.labelCoachingPermission);
			this.groupBoxCoaching.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxCoaching.Dock")));
			this.groupBoxCoaching.Enabled = ((bool)(resources.GetObject("groupBoxCoaching.Enabled")));
			this.groupBoxCoaching.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxCoaching.Font")));
			this.groupBoxCoaching.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxCoaching.ImeMode")));
			this.groupBoxCoaching.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxCoaching.Location")));
			this.groupBoxCoaching.Name = "groupBoxCoaching";
			this.groupBoxCoaching.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxCoaching.RightToLeft")));
			this.groupBoxCoaching.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxCoaching.Size")));
			this.groupBoxCoaching.TabIndex = ((int)(resources.GetObject("groupBoxCoaching.TabIndex")));
			this.groupBoxCoaching.TabStop = false;
			this.groupBoxCoaching.Text = resources.GetString("groupBoxCoaching.Text");
			this.groupBoxCoaching.Visible = ((bool)(resources.GetObject("groupBoxCoaching.Visible")));
			// 
			// labelMonitorCodeCap
			// 
			this.labelMonitorCodeCap.AccessibleDescription = resources.GetString("labelMonitorCodeCap.AccessibleDescription");
			this.labelMonitorCodeCap.AccessibleName = resources.GetString("labelMonitorCodeCap.AccessibleName");
			this.labelMonitorCodeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMonitorCodeCap.Anchor")));
			this.labelMonitorCodeCap.AutoSize = ((bool)(resources.GetObject("labelMonitorCodeCap.AutoSize")));
			this.labelMonitorCodeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMonitorCodeCap.Dock")));
			this.labelMonitorCodeCap.Enabled = ((bool)(resources.GetObject("labelMonitorCodeCap.Enabled")));
			this.labelMonitorCodeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMonitorCodeCap.Font")));
			this.labelMonitorCodeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMonitorCodeCap.Image")));
			this.labelMonitorCodeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMonitorCodeCap.ImageAlign")));
			this.labelMonitorCodeCap.ImageIndex = ((int)(resources.GetObject("labelMonitorCodeCap.ImageIndex")));
			this.labelMonitorCodeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMonitorCodeCap.ImeMode")));
			this.labelMonitorCodeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMonitorCodeCap.Location")));
			this.labelMonitorCodeCap.Name = "labelMonitorCodeCap";
			this.labelMonitorCodeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMonitorCodeCap.RightToLeft")));
			this.labelMonitorCodeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMonitorCodeCap.Size")));
			this.labelMonitorCodeCap.TabIndex = ((int)(resources.GetObject("labelMonitorCodeCap.TabIndex")));
			this.labelMonitorCodeCap.Text = resources.GetString("labelMonitorCodeCap.Text");
			this.labelMonitorCodeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMonitorCodeCap.TextAlign")));
			this.labelMonitorCodeCap.Visible = ((bool)(resources.GetObject("labelMonitorCodeCap.Visible")));
			// 
			// textBoxMonitorCode
			// 
			this.textBoxMonitorCode.AccessibleDescription = resources.GetString("textBoxMonitorCode.AccessibleDescription");
			this.textBoxMonitorCode.AccessibleName = resources.GetString("textBoxMonitorCode.AccessibleName");
			this.textBoxMonitorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxMonitorCode.Anchor")));
			this.textBoxMonitorCode.AutoSize = ((bool)(resources.GetObject("textBoxMonitorCode.AutoSize")));
			this.textBoxMonitorCode.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxMonitorCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxMonitorCode.BackgroundImage")));
			this.textBoxMonitorCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxMonitorCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxMonitorCode.Dock")));
			this.textBoxMonitorCode.Enabled = ((bool)(resources.GetObject("textBoxMonitorCode.Enabled")));
			this.textBoxMonitorCode.Font = ((System.Drawing.Font)(resources.GetObject("textBoxMonitorCode.Font")));
			this.textBoxMonitorCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxMonitorCode.ImeMode")));
			this.textBoxMonitorCode.Location = ((System.Drawing.Point)(resources.GetObject("textBoxMonitorCode.Location")));
			this.textBoxMonitorCode.MaxLength = ((int)(resources.GetObject("textBoxMonitorCode.MaxLength")));
			this.textBoxMonitorCode.Multiline = ((bool)(resources.GetObject("textBoxMonitorCode.Multiline")));
			this.textBoxMonitorCode.Name = "textBoxMonitorCode";
			this.textBoxMonitorCode.PasswordChar = ((char)(resources.GetObject("textBoxMonitorCode.PasswordChar")));
			this.textBoxMonitorCode.ReadOnly = true;
			this.textBoxMonitorCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxMonitorCode.RightToLeft")));
			this.textBoxMonitorCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxMonitorCode.ScrollBars")));
			this.textBoxMonitorCode.Size = ((System.Drawing.Size)(resources.GetObject("textBoxMonitorCode.Size")));
			this.textBoxMonitorCode.TabIndex = ((int)(resources.GetObject("textBoxMonitorCode.TabIndex")));
			this.textBoxMonitorCode.TabStop = false;
			this.textBoxMonitorCode.Text = resources.GetString("textBoxMonitorCode.Text");
			this.textBoxMonitorCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxMonitorCode.TextAlign")));
			this.textBoxMonitorCode.Visible = ((bool)(resources.GetObject("textBoxMonitorCode.Visible")));
			this.textBoxMonitorCode.WordWrap = ((bool)(resources.GetObject("textBoxMonitorCode.WordWrap")));
			// 
			// labelCoachingModeCap
			// 
			this.labelCoachingModeCap.AccessibleDescription = resources.GetString("labelCoachingModeCap.AccessibleDescription");
			this.labelCoachingModeCap.AccessibleName = resources.GetString("labelCoachingModeCap.AccessibleName");
			this.labelCoachingModeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCoachingModeCap.Anchor")));
			this.labelCoachingModeCap.AutoSize = ((bool)(resources.GetObject("labelCoachingModeCap.AutoSize")));
			this.labelCoachingModeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCoachingModeCap.Dock")));
			this.labelCoachingModeCap.Enabled = ((bool)(resources.GetObject("labelCoachingModeCap.Enabled")));
			this.labelCoachingModeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCoachingModeCap.Font")));
			this.labelCoachingModeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCoachingModeCap.Image")));
			this.labelCoachingModeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingModeCap.ImageAlign")));
			this.labelCoachingModeCap.ImageIndex = ((int)(resources.GetObject("labelCoachingModeCap.ImageIndex")));
			this.labelCoachingModeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCoachingModeCap.ImeMode")));
			this.labelCoachingModeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCoachingModeCap.Location")));
			this.labelCoachingModeCap.Name = "labelCoachingModeCap";
			this.labelCoachingModeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCoachingModeCap.RightToLeft")));
			this.labelCoachingModeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCoachingModeCap.Size")));
			this.labelCoachingModeCap.TabIndex = ((int)(resources.GetObject("labelCoachingModeCap.TabIndex")));
			this.labelCoachingModeCap.Text = resources.GetString("labelCoachingModeCap.Text");
			this.labelCoachingModeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingModeCap.TextAlign")));
			this.labelCoachingModeCap.Visible = ((bool)(resources.GetObject("labelCoachingModeCap.Visible")));
			// 
			// textBoxCoachingMode
			// 
			this.textBoxCoachingMode.AccessibleDescription = resources.GetString("textBoxCoachingMode.AccessibleDescription");
			this.textBoxCoachingMode.AccessibleName = resources.GetString("textBoxCoachingMode.AccessibleName");
			this.textBoxCoachingMode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxCoachingMode.Anchor")));
			this.textBoxCoachingMode.AutoSize = ((bool)(resources.GetObject("textBoxCoachingMode.AutoSize")));
			this.textBoxCoachingMode.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxCoachingMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCoachingMode.BackgroundImage")));
			this.textBoxCoachingMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCoachingMode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxCoachingMode.Dock")));
			this.textBoxCoachingMode.Enabled = ((bool)(resources.GetObject("textBoxCoachingMode.Enabled")));
			this.textBoxCoachingMode.Font = ((System.Drawing.Font)(resources.GetObject("textBoxCoachingMode.Font")));
			this.textBoxCoachingMode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxCoachingMode.ImeMode")));
			this.textBoxCoachingMode.Location = ((System.Drawing.Point)(resources.GetObject("textBoxCoachingMode.Location")));
			this.textBoxCoachingMode.MaxLength = ((int)(resources.GetObject("textBoxCoachingMode.MaxLength")));
			this.textBoxCoachingMode.Multiline = ((bool)(resources.GetObject("textBoxCoachingMode.Multiline")));
			this.textBoxCoachingMode.Name = "textBoxCoachingMode";
			this.textBoxCoachingMode.PasswordChar = ((char)(resources.GetObject("textBoxCoachingMode.PasswordChar")));
			this.textBoxCoachingMode.ReadOnly = true;
			this.textBoxCoachingMode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxCoachingMode.RightToLeft")));
			this.textBoxCoachingMode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxCoachingMode.ScrollBars")));
			this.textBoxCoachingMode.Size = ((System.Drawing.Size)(resources.GetObject("textBoxCoachingMode.Size")));
			this.textBoxCoachingMode.TabIndex = ((int)(resources.GetObject("textBoxCoachingMode.TabIndex")));
			this.textBoxCoachingMode.TabStop = false;
			this.textBoxCoachingMode.Text = resources.GetString("textBoxCoachingMode.Text");
			this.textBoxCoachingMode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxCoachingMode.TextAlign")));
			this.textBoxCoachingMode.Visible = ((bool)(resources.GetObject("textBoxCoachingMode.Visible")));
			this.textBoxCoachingMode.WordWrap = ((bool)(resources.GetObject("textBoxCoachingMode.WordWrap")));
			// 
			// labelCoachingPermissionCap
			// 
			this.labelCoachingPermissionCap.AccessibleDescription = resources.GetString("labelCoachingPermissionCap.AccessibleDescription");
			this.labelCoachingPermissionCap.AccessibleName = resources.GetString("labelCoachingPermissionCap.AccessibleName");
			this.labelCoachingPermissionCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCoachingPermissionCap.Anchor")));
			this.labelCoachingPermissionCap.AutoSize = ((bool)(resources.GetObject("labelCoachingPermissionCap.AutoSize")));
			this.labelCoachingPermissionCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCoachingPermissionCap.Dock")));
			this.labelCoachingPermissionCap.Enabled = ((bool)(resources.GetObject("labelCoachingPermissionCap.Enabled")));
			this.labelCoachingPermissionCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCoachingPermissionCap.Font")));
			this.labelCoachingPermissionCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCoachingPermissionCap.Image")));
			this.labelCoachingPermissionCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingPermissionCap.ImageAlign")));
			this.labelCoachingPermissionCap.ImageIndex = ((int)(resources.GetObject("labelCoachingPermissionCap.ImageIndex")));
			this.labelCoachingPermissionCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCoachingPermissionCap.ImeMode")));
			this.labelCoachingPermissionCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCoachingPermissionCap.Location")));
			this.labelCoachingPermissionCap.Name = "labelCoachingPermissionCap";
			this.labelCoachingPermissionCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCoachingPermissionCap.RightToLeft")));
			this.labelCoachingPermissionCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCoachingPermissionCap.Size")));
			this.labelCoachingPermissionCap.TabIndex = ((int)(resources.GetObject("labelCoachingPermissionCap.TabIndex")));
			this.labelCoachingPermissionCap.Text = resources.GetString("labelCoachingPermissionCap.Text");
			this.labelCoachingPermissionCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingPermissionCap.TextAlign")));
			this.labelCoachingPermissionCap.Visible = ((bool)(resources.GetObject("labelCoachingPermissionCap.Visible")));
			// 
			// labelCoachingPermission
			// 
			this.labelCoachingPermission.AccessibleDescription = resources.GetString("labelCoachingPermission.AccessibleDescription");
			this.labelCoachingPermission.AccessibleName = resources.GetString("labelCoachingPermission.AccessibleName");
			this.labelCoachingPermission.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCoachingPermission.Anchor")));
			this.labelCoachingPermission.AutoSize = ((bool)(resources.GetObject("labelCoachingPermission.AutoSize")));
			this.labelCoachingPermission.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCoachingPermission.Dock")));
			this.labelCoachingPermission.Enabled = ((bool)(resources.GetObject("labelCoachingPermission.Enabled")));
			this.labelCoachingPermission.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelCoachingPermission.Font = ((System.Drawing.Font)(resources.GetObject("labelCoachingPermission.Font")));
			this.labelCoachingPermission.Image = ((System.Drawing.Image)(resources.GetObject("labelCoachingPermission.Image")));
			this.labelCoachingPermission.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingPermission.ImageAlign")));
			this.labelCoachingPermission.ImageIndex = ((int)(resources.GetObject("labelCoachingPermission.ImageIndex")));
			this.labelCoachingPermission.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCoachingPermission.ImeMode")));
			this.labelCoachingPermission.Location = ((System.Drawing.Point)(resources.GetObject("labelCoachingPermission.Location")));
			this.labelCoachingPermission.Name = "labelCoachingPermission";
			this.labelCoachingPermission.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCoachingPermission.RightToLeft")));
			this.labelCoachingPermission.Size = ((System.Drawing.Size)(resources.GetObject("labelCoachingPermission.Size")));
			this.labelCoachingPermission.TabIndex = ((int)(resources.GetObject("labelCoachingPermission.TabIndex")));
			this.labelCoachingPermission.Text = resources.GetString("labelCoachingPermission.Text");
			this.labelCoachingPermission.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCoachingPermission.TextAlign")));
			this.labelCoachingPermission.Visible = ((bool)(resources.GetObject("labelCoachingPermission.Visible")));
			// 
			// groupBoxStateTimes
			// 
			this.groupBoxStateTimes.AccessibleDescription = resources.GetString("groupBoxStateTimes.AccessibleDescription");
			this.groupBoxStateTimes.AccessibleName = resources.GetString("groupBoxStateTimes.AccessibleName");
			this.groupBoxStateTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxStateTimes.Anchor")));
			this.groupBoxStateTimes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxStateTimes.BackgroundImage")));
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlTalkingCap);
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlTalking);
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlWrapupCap);
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlWrapup);
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlReadyCap);
			this.groupBoxStateTimes.Controls.Add(this.labelStateTimeAvgTtlReady);
			this.groupBoxStateTimes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxStateTimes.Dock")));
			this.groupBoxStateTimes.Enabled = ((bool)(resources.GetObject("groupBoxStateTimes.Enabled")));
			this.groupBoxStateTimes.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxStateTimes.Font")));
			this.groupBoxStateTimes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxStateTimes.ImeMode")));
			this.groupBoxStateTimes.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxStateTimes.Location")));
			this.groupBoxStateTimes.Name = "groupBoxStateTimes";
			this.groupBoxStateTimes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxStateTimes.RightToLeft")));
			this.groupBoxStateTimes.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxStateTimes.Size")));
			this.groupBoxStateTimes.TabIndex = ((int)(resources.GetObject("groupBoxStateTimes.TabIndex")));
			this.groupBoxStateTimes.TabStop = false;
			this.groupBoxStateTimes.Text = resources.GetString("groupBoxStateTimes.Text");
			this.groupBoxStateTimes.Visible = ((bool)(resources.GetObject("groupBoxStateTimes.Visible")));
			// 
			// labelStateTimeAvgTtlTalkingCap
			// 
			this.labelStateTimeAvgTtlTalkingCap.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlTalkingCap.AccessibleDescription");
			this.labelStateTimeAvgTtlTalkingCap.AccessibleName = resources.GetString("labelStateTimeAvgTtlTalkingCap.AccessibleName");
			this.labelStateTimeAvgTtlTalkingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Anchor")));
			this.labelStateTimeAvgTtlTalkingCap.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.AutoSize")));
			this.labelStateTimeAvgTtlTalkingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Dock")));
			this.labelStateTimeAvgTtlTalkingCap.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Enabled")));
			this.labelStateTimeAvgTtlTalkingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Font")));
			this.labelStateTimeAvgTtlTalkingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Image")));
			this.labelStateTimeAvgTtlTalkingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.ImageAlign")));
			this.labelStateTimeAvgTtlTalkingCap.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.ImageIndex")));
			this.labelStateTimeAvgTtlTalkingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.ImeMode")));
			this.labelStateTimeAvgTtlTalkingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Location")));
			this.labelStateTimeAvgTtlTalkingCap.Name = "labelStateTimeAvgTtlTalkingCap";
			this.labelStateTimeAvgTtlTalkingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.RightToLeft")));
			this.labelStateTimeAvgTtlTalkingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Size")));
			this.labelStateTimeAvgTtlTalkingCap.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.TabIndex")));
			this.labelStateTimeAvgTtlTalkingCap.Text = resources.GetString("labelStateTimeAvgTtlTalkingCap.Text");
			this.labelStateTimeAvgTtlTalkingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.TextAlign")));
			this.labelStateTimeAvgTtlTalkingCap.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalkingCap.Visible")));
			// 
			// labelStateTimeAvgTtlTalking
			// 
			this.labelStateTimeAvgTtlTalking.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlTalking.AccessibleDescription");
			this.labelStateTimeAvgTtlTalking.AccessibleName = resources.GetString("labelStateTimeAvgTtlTalking.AccessibleName");
			this.labelStateTimeAvgTtlTalking.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlTalking.Anchor")));
			this.labelStateTimeAvgTtlTalking.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalking.AutoSize")));
			this.labelStateTimeAvgTtlTalking.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlTalking.Dock")));
			this.labelStateTimeAvgTtlTalking.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalking.Enabled")));
			this.labelStateTimeAvgTtlTalking.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlTalking.Font")));
			this.labelStateTimeAvgTtlTalking.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlTalking.Image")));
			this.labelStateTimeAvgTtlTalking.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlTalking.ImageAlign")));
			this.labelStateTimeAvgTtlTalking.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlTalking.ImageIndex")));
			this.labelStateTimeAvgTtlTalking.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlTalking.ImeMode")));
			this.labelStateTimeAvgTtlTalking.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlTalking.Location")));
			this.labelStateTimeAvgTtlTalking.Name = "labelStateTimeAvgTtlTalking";
			this.labelStateTimeAvgTtlTalking.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlTalking.RightToLeft")));
			this.labelStateTimeAvgTtlTalking.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlTalking.Size")));
			this.labelStateTimeAvgTtlTalking.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlTalking.TabIndex")));
			this.labelStateTimeAvgTtlTalking.Text = resources.GetString("labelStateTimeAvgTtlTalking.Text");
			this.labelStateTimeAvgTtlTalking.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlTalking.TextAlign")));
			this.labelStateTimeAvgTtlTalking.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlTalking.Visible")));
			// 
			// labelStateTimeAvgTtlWrapupCap
			// 
			this.labelStateTimeAvgTtlWrapupCap.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlWrapupCap.AccessibleDescription");
			this.labelStateTimeAvgTtlWrapupCap.AccessibleName = resources.GetString("labelStateTimeAvgTtlWrapupCap.AccessibleName");
			this.labelStateTimeAvgTtlWrapupCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Anchor")));
			this.labelStateTimeAvgTtlWrapupCap.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.AutoSize")));
			this.labelStateTimeAvgTtlWrapupCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Dock")));
			this.labelStateTimeAvgTtlWrapupCap.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Enabled")));
			this.labelStateTimeAvgTtlWrapupCap.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Font")));
			this.labelStateTimeAvgTtlWrapupCap.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Image")));
			this.labelStateTimeAvgTtlWrapupCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.ImageAlign")));
			this.labelStateTimeAvgTtlWrapupCap.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.ImageIndex")));
			this.labelStateTimeAvgTtlWrapupCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.ImeMode")));
			this.labelStateTimeAvgTtlWrapupCap.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Location")));
			this.labelStateTimeAvgTtlWrapupCap.Name = "labelStateTimeAvgTtlWrapupCap";
			this.labelStateTimeAvgTtlWrapupCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.RightToLeft")));
			this.labelStateTimeAvgTtlWrapupCap.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Size")));
			this.labelStateTimeAvgTtlWrapupCap.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.TabIndex")));
			this.labelStateTimeAvgTtlWrapupCap.Text = resources.GetString("labelStateTimeAvgTtlWrapupCap.Text");
			this.labelStateTimeAvgTtlWrapupCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.TextAlign")));
			this.labelStateTimeAvgTtlWrapupCap.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapupCap.Visible")));
			// 
			// labelStateTimeAvgTtlWrapup
			// 
			this.labelStateTimeAvgTtlWrapup.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlWrapup.AccessibleDescription");
			this.labelStateTimeAvgTtlWrapup.AccessibleName = resources.GetString("labelStateTimeAvgTtlWrapup.AccessibleName");
			this.labelStateTimeAvgTtlWrapup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlWrapup.Anchor")));
			this.labelStateTimeAvgTtlWrapup.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapup.AutoSize")));
			this.labelStateTimeAvgTtlWrapup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlWrapup.Dock")));
			this.labelStateTimeAvgTtlWrapup.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapup.Enabled")));
			this.labelStateTimeAvgTtlWrapup.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlWrapup.Font")));
			this.labelStateTimeAvgTtlWrapup.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlWrapup.Image")));
			this.labelStateTimeAvgTtlWrapup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlWrapup.ImageAlign")));
			this.labelStateTimeAvgTtlWrapup.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlWrapup.ImageIndex")));
			this.labelStateTimeAvgTtlWrapup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlWrapup.ImeMode")));
			this.labelStateTimeAvgTtlWrapup.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlWrapup.Location")));
			this.labelStateTimeAvgTtlWrapup.Name = "labelStateTimeAvgTtlWrapup";
			this.labelStateTimeAvgTtlWrapup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlWrapup.RightToLeft")));
			this.labelStateTimeAvgTtlWrapup.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlWrapup.Size")));
			this.labelStateTimeAvgTtlWrapup.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlWrapup.TabIndex")));
			this.labelStateTimeAvgTtlWrapup.Text = resources.GetString("labelStateTimeAvgTtlWrapup.Text");
			this.labelStateTimeAvgTtlWrapup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlWrapup.TextAlign")));
			this.labelStateTimeAvgTtlWrapup.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlWrapup.Visible")));
			// 
			// labelStateTimeAvgTtlReadyCap
			// 
			this.labelStateTimeAvgTtlReadyCap.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlReadyCap.AccessibleDescription");
			this.labelStateTimeAvgTtlReadyCap.AccessibleName = resources.GetString("labelStateTimeAvgTtlReadyCap.AccessibleName");
			this.labelStateTimeAvgTtlReadyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Anchor")));
			this.labelStateTimeAvgTtlReadyCap.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlReadyCap.AutoSize")));
			this.labelStateTimeAvgTtlReadyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Dock")));
			this.labelStateTimeAvgTtlReadyCap.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Enabled")));
			this.labelStateTimeAvgTtlReadyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Font")));
			this.labelStateTimeAvgTtlReadyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Image")));
			this.labelStateTimeAvgTtlReadyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlReadyCap.ImageAlign")));
			this.labelStateTimeAvgTtlReadyCap.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlReadyCap.ImageIndex")));
			this.labelStateTimeAvgTtlReadyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlReadyCap.ImeMode")));
			this.labelStateTimeAvgTtlReadyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Location")));
			this.labelStateTimeAvgTtlReadyCap.Name = "labelStateTimeAvgTtlReadyCap";
			this.labelStateTimeAvgTtlReadyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlReadyCap.RightToLeft")));
			this.labelStateTimeAvgTtlReadyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Size")));
			this.labelStateTimeAvgTtlReadyCap.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlReadyCap.TabIndex")));
			this.labelStateTimeAvgTtlReadyCap.Text = resources.GetString("labelStateTimeAvgTtlReadyCap.Text");
			this.labelStateTimeAvgTtlReadyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlReadyCap.TextAlign")));
			this.labelStateTimeAvgTtlReadyCap.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlReadyCap.Visible")));
			// 
			// labelStateTimeAvgTtlReady
			// 
			this.labelStateTimeAvgTtlReady.AccessibleDescription = resources.GetString("labelStateTimeAvgTtlReady.AccessibleDescription");
			this.labelStateTimeAvgTtlReady.AccessibleName = resources.GetString("labelStateTimeAvgTtlReady.AccessibleName");
			this.labelStateTimeAvgTtlReady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTimeAvgTtlReady.Anchor")));
			this.labelStateTimeAvgTtlReady.AutoSize = ((bool)(resources.GetObject("labelStateTimeAvgTtlReady.AutoSize")));
			this.labelStateTimeAvgTtlReady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTimeAvgTtlReady.Dock")));
			this.labelStateTimeAvgTtlReady.Enabled = ((bool)(resources.GetObject("labelStateTimeAvgTtlReady.Enabled")));
			this.labelStateTimeAvgTtlReady.Font = ((System.Drawing.Font)(resources.GetObject("labelStateTimeAvgTtlReady.Font")));
			this.labelStateTimeAvgTtlReady.Image = ((System.Drawing.Image)(resources.GetObject("labelStateTimeAvgTtlReady.Image")));
			this.labelStateTimeAvgTtlReady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlReady.ImageAlign")));
			this.labelStateTimeAvgTtlReady.ImageIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlReady.ImageIndex")));
			this.labelStateTimeAvgTtlReady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelStateTimeAvgTtlReady.ImeMode")));
			this.labelStateTimeAvgTtlReady.Location = ((System.Drawing.Point)(resources.GetObject("labelStateTimeAvgTtlReady.Location")));
			this.labelStateTimeAvgTtlReady.Name = "labelStateTimeAvgTtlReady";
			this.labelStateTimeAvgTtlReady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelStateTimeAvgTtlReady.RightToLeft")));
			this.labelStateTimeAvgTtlReady.Size = ((System.Drawing.Size)(resources.GetObject("labelStateTimeAvgTtlReady.Size")));
			this.labelStateTimeAvgTtlReady.TabIndex = ((int)(resources.GetObject("labelStateTimeAvgTtlReady.TabIndex")));
			this.labelStateTimeAvgTtlReady.Text = resources.GetString("labelStateTimeAvgTtlReady.Text");
			this.labelStateTimeAvgTtlReady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelStateTimeAvgTtlReady.TextAlign")));
			this.labelStateTimeAvgTtlReady.Visible = ((bool)(resources.GetObject("labelStateTimeAvgTtlReady.Visible")));
			// 
			// groupBoxStateDistribution
			// 
			this.groupBoxStateDistribution.AccessibleDescription = resources.GetString("groupBoxStateDistribution.AccessibleDescription");
			this.groupBoxStateDistribution.AccessibleName = resources.GetString("groupBoxStateDistribution.AccessibleName");
			this.groupBoxStateDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxStateDistribution.Anchor")));
			this.groupBoxStateDistribution.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxStateDistribution.BackgroundImage")));
			this.groupBoxStateDistribution.Controls.Add(this.pieStateTimeTtl);
			this.groupBoxStateDistribution.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxStateDistribution.Dock")));
			this.groupBoxStateDistribution.Enabled = ((bool)(resources.GetObject("groupBoxStateDistribution.Enabled")));
			this.groupBoxStateDistribution.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxStateDistribution.Font")));
			this.groupBoxStateDistribution.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxStateDistribution.ImeMode")));
			this.groupBoxStateDistribution.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxStateDistribution.Location")));
			this.groupBoxStateDistribution.Name = "groupBoxStateDistribution";
			this.groupBoxStateDistribution.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxStateDistribution.RightToLeft")));
			this.groupBoxStateDistribution.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxStateDistribution.Size")));
			this.groupBoxStateDistribution.TabIndex = ((int)(resources.GetObject("groupBoxStateDistribution.TabIndex")));
			this.groupBoxStateDistribution.TabStop = false;
			this.groupBoxStateDistribution.Text = resources.GetString("groupBoxStateDistribution.Text");
			this.groupBoxStateDistribution.Visible = ((bool)(resources.GetObject("groupBoxStateDistribution.Visible")));
			// 
			// pieStateTimeTtl
			// 
			this.pieStateTimeTtl.AccessibleDescription = resources.GetString("pieStateTimeTtl.AccessibleDescription");
			this.pieStateTimeTtl.AccessibleName = resources.GetString("pieStateTimeTtl.AccessibleName");
			this.pieStateTimeTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pieStateTimeTtl.Anchor")));
			this.pieStateTimeTtl.AutoScroll = ((bool)(resources.GetObject("pieStateTimeTtl.AutoScroll")));
			this.pieStateTimeTtl.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pieStateTimeTtl.AutoScrollMargin")));
			this.pieStateTimeTtl.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pieStateTimeTtl.AutoScrollMinSize")));
			this.pieStateTimeTtl.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("pieStateTimeTtl.BackgroundColor")));
			this.pieStateTimeTtl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieStateTimeTtl.BackgroundImage")));
			this.pieStateTimeTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pieStateTimeTtl.Dock")));
			this.pieStateTimeTtl.Enabled = ((bool)(resources.GetObject("pieStateTimeTtl.Enabled")));
			this.pieStateTimeTtl.Font = ((System.Drawing.Font)(resources.GetObject("pieStateTimeTtl.Font")));
			this.pieStateTimeTtl.HorizontalSpace = ((int)(resources.GetObject("pieStateTimeTtl.HorizontalSpace")));
			this.pieStateTimeTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pieStateTimeTtl.ImeMode")));
			this.pieStateTimeTtl.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("pieStateTimeTtl.LegendAlignment")));
			this.pieStateTimeTtl.LegendColor = ((System.Drawing.Color)(resources.GetObject("pieStateTimeTtl.LegendColor")));
			this.pieStateTimeTtl.Location = ((System.Drawing.Point)(resources.GetObject("pieStateTimeTtl.Location")));
			this.pieStateTimeTtl.Name = "pieStateTimeTtl";
			this.pieStateTimeTtl.Painting = ((bool)(resources.GetObject("pieStateTimeTtl.Painting")));
			this.pieStateTimeTtl.RefreshInterval = ((int)(resources.GetObject("pieStateTimeTtl.RefreshInterval")));
			this.pieStateTimeTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pieStateTimeTtl.RightToLeft")));
			this.pieStateTimeTtl.Size = ((System.Drawing.Size)(resources.GetObject("pieStateTimeTtl.Size")));
			slice1.Caption = resources.GetString("slice1.Caption");
			slice1.Color = ((System.Drawing.Color)(resources.GetObject("slice1.Color")));
			slice1.Value = ((System.Double)(resources.GetObject("slice1.Value")));
			slice1.Visible = ((bool)(resources.GetObject("slice1.Visible")));
			slice2.Caption = resources.GetString("slice2.Caption");
			slice2.Color = ((System.Drawing.Color)(resources.GetObject("slice2.Color")));
			slice2.Value = ((System.Double)(resources.GetObject("slice2.Value")));
			slice2.Visible = ((bool)(resources.GetObject("slice2.Visible")));
			slice3.Caption = resources.GetString("slice3.Caption");
			slice3.Color = ((System.Drawing.Color)(resources.GetObject("slice3.Color")));
			slice3.Value = ((System.Double)(resources.GetObject("slice3.Value")));
			slice3.Visible = ((bool)(resources.GetObject("slice3.Visible")));
			slice4.Caption = resources.GetString("slice4.Caption");
			slice4.Color = ((System.Drawing.Color)(resources.GetObject("slice4.Color")));
			slice4.Value = ((System.Double)(resources.GetObject("slice4.Value")));
			slice4.Visible = ((bool)(resources.GetObject("slice4.Visible")));
			slice5.Caption = resources.GetString("slice5.Caption");
			slice5.Color = ((System.Drawing.Color)(resources.GetObject("slice5.Color")));
			slice5.Value = ((System.Double)(resources.GetObject("slice5.Value")));
			slice5.Visible = ((bool)(resources.GetObject("slice5.Visible")));
			slice6.Caption = resources.GetString("slice6.Caption");
			slice6.Color = ((System.Drawing.Color)(resources.GetObject("slice6.Color")));
			slice6.Value = ((System.Double)(resources.GetObject("slice6.Value")));
			slice6.Visible = ((bool)(resources.GetObject("slice6.Visible")));
			slice7.Caption = resources.GetString("slice7.Caption");
			slice7.Color = ((System.Drawing.Color)(resources.GetObject("slice7.Color")));
			slice7.Value = ((System.Double)(resources.GetObject("slice7.Value")));
			slice7.Visible = ((bool)(resources.GetObject("slice7.Visible")));
			slice8.Caption = resources.GetString("slice8.Caption");
			slice8.Color = ((System.Drawing.Color)(resources.GetObject("slice8.Color")));
			slice8.Value = ((System.Double)(resources.GetObject("slice8.Value")));
			slice8.Visible = ((bool)(resources.GetObject("slice8.Visible")));
			slice9.Caption = resources.GetString("slice9.Caption");
			slice9.Color = ((System.Drawing.Color)(resources.GetObject("slice9.Color")));
			slice9.Value = ((System.Double)(resources.GetObject("slice9.Value")));
			slice9.Visible = ((bool)(resources.GetObject("slice9.Visible")));
			this.pieStateTimeTtl.Slices.AddRange(new itCampus.bb.Graph.Pie.Slice[] {
																					   slice1,
																					   slice2,
																					   slice3,
																					   slice4,
																					   slice5,
																					   slice6,
																					   slice7,
																					   slice8,
																					   slice9});
			this.pieStateTimeTtl.TabIndex = ((int)(resources.GetObject("pieStateTimeTtl.TabIndex")));
			this.pieStateTimeTtl.ValueColor = ((System.Drawing.Color)(resources.GetObject("pieStateTimeTtl.ValueColor")));
			this.pieStateTimeTtl.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("pieStateTimeTtl.ValueType")));
			this.pieStateTimeTtl.VerticalSpace = ((int)(resources.GetObject("pieStateTimeTtl.VerticalSpace")));
			this.pieStateTimeTtl.Visible = ((bool)(resources.GetObject("pieStateTimeTtl.Visible")));
			// 
			// timerRefresh
			// 
			this.timerRefresh.Interval = 1000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// FrontendView
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxStateDistribution);
			this.Controls.Add(this.groupBoxStateTimes);
			this.Controls.Add(this.groupBoxCoaching);
			this.Controls.Add(this.groupBoxCommon);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "FrontendView";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxCommon.ResumeLayout(false);
			this.groupBoxCoaching.ResumeLayout(false);
			this.groupBoxStateTimes.ResumeLayout(false);
			this.groupBoxStateDistribution.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pieStateTimeTtl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Frontend frontend)
		{
			// Parameter aktualisieren
			textBoxAgentCode.Text = frontend.AgentCode;
			textBoxDeviceCode.Text = frontend.DeviceCode;
			textBoxCampaignName.Text = frontend.CampaignName;
			labelAgentMode.Text = frontend.AgentMode.ToString();
			labelState.Text = frontend.State.ToString();
			textBoxMonitorCode.Text = frontend.MonitorCode;
			textBoxCoachingMode.Text =
				frontend.MonitorCode != "" ? frontend.CoachingMode.ToString() : "";
			labelCoachingPermission.Text = frontend.CoachingPermission ?
				Resources.GetString("FrontendView.CoachingPermission.Text.Granted") :
				Resources.GetString("FrontendView.CoachingPermission.Text.NotGranted");
			labelStateTimeAvgTtlTalking.Text =
				FormatTimeSpan(frontend.GetAgentStateTimeAvgTtl(AgentState.Talking));
			labelStateTimeAvgTtlWrapup.Text =
				FormatTimeSpan(frontend.GetAgentStateTimeAvgTtl(AgentState.Wrapup));
			labelStateTimeAvgTtlReady.Text =
				FormatTimeSpan(frontend.GetAgentStateTimeAvgTtl(AgentState.Ready));

			// ggf. Statusdauer aktualisieren
			if (_lastStateChange != frontend.LastStateChange)
			{
				_lastStateChange = frontend.LastStateChange;
				labelStateTime.Text = GetStateTime(_lastStateChange);
			}

			// Kuchendiagramm aktualisieren
			pieStateTimeTtl.Slices[0].Value = frontend.GetAgentStateTimeTtl(AgentState.Talking);
			pieStateTimeTtl.Slices[1].Value = frontend.GetAgentStateTimeTtl(AgentState.Wrapup);
			pieStateTimeTtl.Slices[2].Value = frontend.GetAgentStateTimeTtl(AgentState.Ready);
			pieStateTimeTtl.Slices[3].Value = frontend.GetAgentStateTimeTtl(AgentState.Pending);
			pieStateTimeTtl.Slices[4].Value = frontend.GetAgentStateTimeTtl(AgentState.Signaling);
			pieStateTimeTtl.Slices[5].Value = frontend.GetAgentStateTimeTtl(AgentState.Preparing);
			pieStateTimeTtl.Slices[6].Value = frontend.GetAgentStateTimeTtl(AgentState.Calling);
			pieStateTimeTtl.Slices[7].Value = frontend.GetAgentStateTimeTtl(AgentState.Conferencing);
			pieStateTimeTtl.Slices[8].Value = frontend.GetAgentStateTimeTtl(AgentState.NotReady);
		}

		/// <summary>
		/// aktualisiert Steuerelement
		/// </summary>
		private void timerRefresh_Tick(object sender, System.EventArgs e)
		{
			try
			{
				// Statusdauer aktualisieren
				labelStateTime.Text = GetStateTime(_lastStateChange);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing frontend view.", ex);
			}
		}

		/// <summary>
		/// gibt Zeitspanne vom übergebenen bis zum aktuellen Zeitpunkt im Format mm:ss zurück
		/// </summary>
		private string GetStateTime(DateTime lastStateChanged)
		{
			TimeSpan timeSpan = DateTime.Now.AddSeconds(0.5) - lastStateChanged;
			return timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
		}

		/// <summary>
		/// gibt in Sekunden übergebene Zeitspanne im Format mm:ss zurück
		/// </summary>
		private string FormatTimeSpan(int seconds)
		{
			TimeSpan timeSpan = new TimeSpan(0, 0, seconds);
			return timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
		}

		#endregion

		#endregion
	}
}
