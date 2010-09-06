using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung einer Kampagne.
	/// </summary>
	public class CampaignView : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.TabControl tabControlCampaign;
		private System.Windows.Forms.TabPage tabPageCampaignOverview;
		private System.Windows.Forms.Panel panelOverview;
		private System.Windows.Forms.RadioButton radioButtonOverviewProperties;
		private System.Windows.Forms.RadioButton radioButtonOverviewParameters;
		private System.Windows.Forms.TabControl tabControlOverview;
		private System.Windows.Forms.TabPage tabPageOverviewProperties;
		private System.Windows.Forms.TabPage tabPageOverviewParameters;
		private System.Windows.Forms.TabPage tabPageCampaignStatisticsCallJobs;
		private System.Windows.Forms.Panel panelStatisticsCallJobs;
		private System.Windows.Forms.RadioButton radioButtonStatisticsCallJobsRecentStatistics;
		private System.Windows.Forms.RadioButton radioButtonStatisticsCallJobsTotalStatistics;
		private System.Windows.Forms.TabControl tabControlStatisticsCallJobs;
		private System.Windows.Forms.TabPage tabPageStatisticsCallJobsRecentStatistics;
		private System.Windows.Forms.TabPage tabPageStatisticsCallJobsTotalStatistics;
		private System.Windows.Forms.TabPage tabPageCampaignStatisticsIncomingCalls;
		private System.Windows.Forms.Panel panelStatisticsIncomingCalls;
		private System.Windows.Forms.RadioButton radioButtonStatisticsIncomingCallsTotalStatistics;
		private System.Windows.Forms.RadioButton radioButtonStatisticsIncomingCallsRecentStatistics;
		private System.Windows.Forms.TabControl tabControlStatisticsIncomingCalls;
		private System.Windows.Forms.TabPage tabPageStatisticsIncomingCallsRecentStatistics;
		private System.Windows.Forms.TabPage tabPageStatisticsIncomingCallsTotalStatistics;
		private System.Windows.Forms.TabPage tabPageCampaignResources;
		private System.Windows.Forms.Panel panelResources;
		private System.Windows.Forms.RadioButton radioButtonResourcesAgents;
		private System.Windows.Forms.RadioButton radioButtonResourcesCallJobs;
		private System.Windows.Forms.RadioButton radioButtonResourcesIncomingCalls;
		private System.Windows.Forms.TabControl tabControlResources;
		private System.Windows.Forms.TabPage tabPageResourcesAgents;
		private System.Windows.Forms.TabPage tabPageResourcesCallJobs;
		private System.Windows.Forms.TabPage tabPageResourcesIncomingCalls;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		// Kampagnenteilansichten
		private CampaignViewProperties _campaignViewProperties;
		private CampaignViewParameters _campaignViewParameters;
		private CampaignViewCallJobsRecentStatistics _campaignViewCallJobsRecentStatistics;
		private CampaignViewCallJobsTotalStatistics _campaignViewCallJobsTotalStatistics;
		private CampaignViewIncomingCallsRecentStatistics
			_campaignViewIncomingCallsRecentStatistics;
		private CampaignViewIncomingCallsTotalStatistics _campaignViewIncomingCallsTotalStatistics;
		private CampaignViewAgents _campaignViewAgents;
		private CampaignViewCallJobs _campaignViewCallJobs;
		private CampaignViewIncomingCalls _campaignViewIncomingCalls;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenansicht
		/// </summary>
		public CampaignView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Kampagnenteilansichten initialisieren
			_campaignViewProperties = new CampaignViewProperties();
			_campaignViewParameters = new CampaignViewParameters();
			_campaignViewCallJobsRecentStatistics = new CampaignViewCallJobsRecentStatistics();
			_campaignViewCallJobsTotalStatistics = new CampaignViewCallJobsTotalStatistics();
			_campaignViewIncomingCallsRecentStatistics =
				new CampaignViewIncomingCallsRecentStatistics();
			_campaignViewIncomingCallsTotalStatistics =
				new CampaignViewIncomingCallsTotalStatistics();
			_campaignViewAgents = new CampaignViewAgents();
			_campaignViewCallJobs = new CampaignViewCallJobs();
			_campaignViewIncomingCalls = new CampaignViewIncomingCalls();

			// Kampagnenteilansichten zu Kampagnenansicht hinzufügen
			tabPageOverviewProperties.Controls.Add(_campaignViewProperties);
			tabPageOverviewParameters.Controls.Add(_campaignViewParameters);
			tabPageStatisticsCallJobsRecentStatistics.Controls.Add(
				_campaignViewCallJobsRecentStatistics);
			tabPageStatisticsCallJobsTotalStatistics.Controls.Add(
				_campaignViewCallJobsTotalStatistics);
			tabPageStatisticsIncomingCallsRecentStatistics.Controls.Add(
				_campaignViewIncomingCallsRecentStatistics);
			tabPageStatisticsIncomingCallsTotalStatistics.Controls.Add(
				_campaignViewIncomingCallsTotalStatistics);
			tabPageResourcesAgents.Controls.Add(_campaignViewAgents);
			tabPageResourcesCallJobs.Controls.Add(_campaignViewCallJobs);
			tabPageResourcesIncomingCalls.Controls.Add(_campaignViewIncomingCalls);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignView));
			this.tabControlCampaign = new System.Windows.Forms.TabControl();
			this.tabPageCampaignOverview = new System.Windows.Forms.TabPage();
			this.panelOverview = new System.Windows.Forms.Panel();
			this.radioButtonOverviewParameters = new System.Windows.Forms.RadioButton();
			this.radioButtonOverviewProperties = new System.Windows.Forms.RadioButton();
			this.tabControlOverview = new System.Windows.Forms.TabControl();
			this.tabPageOverviewProperties = new System.Windows.Forms.TabPage();
			this.tabPageOverviewParameters = new System.Windows.Forms.TabPage();
			this.tabPageCampaignStatisticsCallJobs = new System.Windows.Forms.TabPage();
			this.panelStatisticsCallJobs = new System.Windows.Forms.Panel();
			this.radioButtonStatisticsCallJobsTotalStatistics = new System.Windows.Forms.RadioButton();
			this.radioButtonStatisticsCallJobsRecentStatistics = new System.Windows.Forms.RadioButton();
			this.tabControlStatisticsCallJobs = new System.Windows.Forms.TabControl();
			this.tabPageStatisticsCallJobsRecentStatistics = new System.Windows.Forms.TabPage();
			this.tabPageStatisticsCallJobsTotalStatistics = new System.Windows.Forms.TabPage();
			this.tabPageCampaignStatisticsIncomingCalls = new System.Windows.Forms.TabPage();
			this.panelStatisticsIncomingCalls = new System.Windows.Forms.Panel();
			this.radioButtonStatisticsIncomingCallsTotalStatistics = new System.Windows.Forms.RadioButton();
			this.radioButtonStatisticsIncomingCallsRecentStatistics = new System.Windows.Forms.RadioButton();
			this.tabControlStatisticsIncomingCalls = new System.Windows.Forms.TabControl();
			this.tabPageStatisticsIncomingCallsRecentStatistics = new System.Windows.Forms.TabPage();
			this.tabPageStatisticsIncomingCallsTotalStatistics = new System.Windows.Forms.TabPage();
			this.tabPageCampaignResources = new System.Windows.Forms.TabPage();
			this.panelResources = new System.Windows.Forms.Panel();
			this.radioButtonResourcesIncomingCalls = new System.Windows.Forms.RadioButton();
			this.radioButtonResourcesCallJobs = new System.Windows.Forms.RadioButton();
			this.radioButtonResourcesAgents = new System.Windows.Forms.RadioButton();
			this.tabControlResources = new System.Windows.Forms.TabControl();
			this.tabPageResourcesAgents = new System.Windows.Forms.TabPage();
			this.tabPageResourcesCallJobs = new System.Windows.Forms.TabPage();
			this.tabPageResourcesIncomingCalls = new System.Windows.Forms.TabPage();
			this.tabControlCampaign.SuspendLayout();
			this.tabPageCampaignOverview.SuspendLayout();
			this.panelOverview.SuspendLayout();
			this.tabControlOverview.SuspendLayout();
			this.tabPageCampaignStatisticsCallJobs.SuspendLayout();
			this.panelStatisticsCallJobs.SuspendLayout();
			this.tabControlStatisticsCallJobs.SuspendLayout();
			this.tabPageCampaignStatisticsIncomingCalls.SuspendLayout();
			this.panelStatisticsIncomingCalls.SuspendLayout();
			this.tabControlStatisticsIncomingCalls.SuspendLayout();
			this.tabPageCampaignResources.SuspendLayout();
			this.panelResources.SuspendLayout();
			this.tabControlResources.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlCampaign
			// 
			this.tabControlCampaign.AccessibleDescription = resources.GetString("tabControlCampaign.AccessibleDescription");
			this.tabControlCampaign.AccessibleName = resources.GetString("tabControlCampaign.AccessibleName");
			this.tabControlCampaign.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControlCampaign.Alignment")));
			this.tabControlCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControlCampaign.Anchor")));
			this.tabControlCampaign.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControlCampaign.Appearance")));
			this.tabControlCampaign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControlCampaign.BackgroundImage")));
			this.tabControlCampaign.Controls.Add(this.tabPageCampaignOverview);
			this.tabControlCampaign.Controls.Add(this.tabPageCampaignStatisticsCallJobs);
			this.tabControlCampaign.Controls.Add(this.tabPageCampaignStatisticsIncomingCalls);
			this.tabControlCampaign.Controls.Add(this.tabPageCampaignResources);
			this.tabControlCampaign.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControlCampaign.Dock")));
			this.tabControlCampaign.Enabled = ((bool)(resources.GetObject("tabControlCampaign.Enabled")));
			this.tabControlCampaign.Font = ((System.Drawing.Font)(resources.GetObject("tabControlCampaign.Font")));
			this.tabControlCampaign.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControlCampaign.ImeMode")));
			this.tabControlCampaign.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControlCampaign.ItemSize")));
			this.tabControlCampaign.Location = ((System.Drawing.Point)(resources.GetObject("tabControlCampaign.Location")));
			this.tabControlCampaign.Name = "tabControlCampaign";
			this.tabControlCampaign.Padding = ((System.Drawing.Point)(resources.GetObject("tabControlCampaign.Padding")));
			this.tabControlCampaign.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControlCampaign.RightToLeft")));
			this.tabControlCampaign.SelectedIndex = 0;
			this.tabControlCampaign.ShowToolTips = ((bool)(resources.GetObject("tabControlCampaign.ShowToolTips")));
			this.tabControlCampaign.Size = ((System.Drawing.Size)(resources.GetObject("tabControlCampaign.Size")));
			this.tabControlCampaign.TabIndex = ((int)(resources.GetObject("tabControlCampaign.TabIndex")));
			this.tabControlCampaign.Text = resources.GetString("tabControlCampaign.Text");
			this.tabControlCampaign.Visible = ((bool)(resources.GetObject("tabControlCampaign.Visible")));
			// 
			// tabPageCampaignOverview
			// 
			this.tabPageCampaignOverview.AccessibleDescription = resources.GetString("tabPageCampaignOverview.AccessibleDescription");
			this.tabPageCampaignOverview.AccessibleName = resources.GetString("tabPageCampaignOverview.AccessibleName");
			this.tabPageCampaignOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageCampaignOverview.Anchor")));
			this.tabPageCampaignOverview.AutoScroll = ((bool)(resources.GetObject("tabPageCampaignOverview.AutoScroll")));
			this.tabPageCampaignOverview.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignOverview.AutoScrollMargin")));
			this.tabPageCampaignOverview.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignOverview.AutoScrollMinSize")));
			this.tabPageCampaignOverview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCampaignOverview.BackgroundImage")));
			this.tabPageCampaignOverview.Controls.Add(this.panelOverview);
			this.tabPageCampaignOverview.Controls.Add(this.tabControlOverview);
			this.tabPageCampaignOverview.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageCampaignOverview.Dock")));
			this.tabPageCampaignOverview.Enabled = ((bool)(resources.GetObject("tabPageCampaignOverview.Enabled")));
			this.tabPageCampaignOverview.Font = ((System.Drawing.Font)(resources.GetObject("tabPageCampaignOverview.Font")));
			this.tabPageCampaignOverview.ImageIndex = ((int)(resources.GetObject("tabPageCampaignOverview.ImageIndex")));
			this.tabPageCampaignOverview.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageCampaignOverview.ImeMode")));
			this.tabPageCampaignOverview.Location = ((System.Drawing.Point)(resources.GetObject("tabPageCampaignOverview.Location")));
			this.tabPageCampaignOverview.Name = "tabPageCampaignOverview";
			this.tabPageCampaignOverview.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageCampaignOverview.RightToLeft")));
			this.tabPageCampaignOverview.Size = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignOverview.Size")));
			this.tabPageCampaignOverview.TabIndex = ((int)(resources.GetObject("tabPageCampaignOverview.TabIndex")));
			this.tabPageCampaignOverview.Text = resources.GetString("tabPageCampaignOverview.Text");
			this.tabPageCampaignOverview.ToolTipText = resources.GetString("tabPageCampaignOverview.ToolTipText");
			this.tabPageCampaignOverview.Visible = ((bool)(resources.GetObject("tabPageCampaignOverview.Visible")));
			// 
			// panelOverview
			// 
			this.panelOverview.AccessibleDescription = resources.GetString("panelOverview.AccessibleDescription");
			this.panelOverview.AccessibleName = resources.GetString("panelOverview.AccessibleName");
			this.panelOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelOverview.Anchor")));
			this.panelOverview.AutoScroll = ((bool)(resources.GetObject("panelOverview.AutoScroll")));
			this.panelOverview.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelOverview.AutoScrollMargin")));
			this.panelOverview.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelOverview.AutoScrollMinSize")));
			this.panelOverview.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelOverview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOverview.BackgroundImage")));
			this.panelOverview.Controls.Add(this.radioButtonOverviewParameters);
			this.panelOverview.Controls.Add(this.radioButtonOverviewProperties);
			this.panelOverview.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelOverview.Dock")));
			this.panelOverview.Enabled = ((bool)(resources.GetObject("panelOverview.Enabled")));
			this.panelOverview.Font = ((System.Drawing.Font)(resources.GetObject("panelOverview.Font")));
			this.panelOverview.ForeColor = System.Drawing.SystemColors.Window;
			this.panelOverview.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelOverview.ImeMode")));
			this.panelOverview.Location = ((System.Drawing.Point)(resources.GetObject("panelOverview.Location")));
			this.panelOverview.Name = "panelOverview";
			this.panelOverview.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelOverview.RightToLeft")));
			this.panelOverview.Size = ((System.Drawing.Size)(resources.GetObject("panelOverview.Size")));
			this.panelOverview.TabIndex = ((int)(resources.GetObject("panelOverview.TabIndex")));
			this.panelOverview.Text = resources.GetString("panelOverview.Text");
			this.panelOverview.Visible = ((bool)(resources.GetObject("panelOverview.Visible")));
			// 
			// radioButtonOverviewParameters
			// 
			this.radioButtonOverviewParameters.AccessibleDescription = resources.GetString("radioButtonOverviewParameters.AccessibleDescription");
			this.radioButtonOverviewParameters.AccessibleName = resources.GetString("radioButtonOverviewParameters.AccessibleName");
			this.radioButtonOverviewParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonOverviewParameters.Anchor")));
			this.radioButtonOverviewParameters.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonOverviewParameters.Appearance")));
			this.radioButtonOverviewParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonOverviewParameters.BackgroundImage")));
			this.radioButtonOverviewParameters.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewParameters.CheckAlign")));
			this.radioButtonOverviewParameters.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonOverviewParameters.Dock")));
			this.radioButtonOverviewParameters.Enabled = ((bool)(resources.GetObject("radioButtonOverviewParameters.Enabled")));
			this.radioButtonOverviewParameters.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonOverviewParameters.FlatStyle")));
			this.radioButtonOverviewParameters.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonOverviewParameters.Font")));
			this.radioButtonOverviewParameters.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonOverviewParameters.Image")));
			this.radioButtonOverviewParameters.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewParameters.ImageAlign")));
			this.radioButtonOverviewParameters.ImageIndex = ((int)(resources.GetObject("radioButtonOverviewParameters.ImageIndex")));
			this.radioButtonOverviewParameters.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonOverviewParameters.ImeMode")));
			this.radioButtonOverviewParameters.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonOverviewParameters.Location")));
			this.radioButtonOverviewParameters.Name = "radioButtonOverviewParameters";
			this.radioButtonOverviewParameters.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonOverviewParameters.RightToLeft")));
			this.radioButtonOverviewParameters.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonOverviewParameters.Size")));
			this.radioButtonOverviewParameters.TabIndex = ((int)(resources.GetObject("radioButtonOverviewParameters.TabIndex")));
			this.radioButtonOverviewParameters.Text = resources.GetString("radioButtonOverviewParameters.Text");
			this.radioButtonOverviewParameters.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewParameters.TextAlign")));
			this.radioButtonOverviewParameters.Visible = ((bool)(resources.GetObject("radioButtonOverviewParameters.Visible")));
			this.radioButtonOverviewParameters.CheckedChanged += new System.EventHandler(this.radioButtonOverviewParameters_CheckedChanged);
			// 
			// radioButtonOverviewProperties
			// 
			this.radioButtonOverviewProperties.AccessibleDescription = resources.GetString("radioButtonOverviewProperties.AccessibleDescription");
			this.radioButtonOverviewProperties.AccessibleName = resources.GetString("radioButtonOverviewProperties.AccessibleName");
			this.radioButtonOverviewProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonOverviewProperties.Anchor")));
			this.radioButtonOverviewProperties.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonOverviewProperties.Appearance")));
			this.radioButtonOverviewProperties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonOverviewProperties.BackgroundImage")));
			this.radioButtonOverviewProperties.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewProperties.CheckAlign")));
			this.radioButtonOverviewProperties.Checked = true;
			this.radioButtonOverviewProperties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonOverviewProperties.Dock")));
			this.radioButtonOverviewProperties.Enabled = ((bool)(resources.GetObject("radioButtonOverviewProperties.Enabled")));
			this.radioButtonOverviewProperties.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonOverviewProperties.FlatStyle")));
			this.radioButtonOverviewProperties.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonOverviewProperties.Font")));
			this.radioButtonOverviewProperties.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonOverviewProperties.Image")));
			this.radioButtonOverviewProperties.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewProperties.ImageAlign")));
			this.radioButtonOverviewProperties.ImageIndex = ((int)(resources.GetObject("radioButtonOverviewProperties.ImageIndex")));
			this.radioButtonOverviewProperties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonOverviewProperties.ImeMode")));
			this.radioButtonOverviewProperties.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonOverviewProperties.Location")));
			this.radioButtonOverviewProperties.Name = "radioButtonOverviewProperties";
			this.radioButtonOverviewProperties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonOverviewProperties.RightToLeft")));
			this.radioButtonOverviewProperties.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonOverviewProperties.Size")));
			this.radioButtonOverviewProperties.TabIndex = ((int)(resources.GetObject("radioButtonOverviewProperties.TabIndex")));
			this.radioButtonOverviewProperties.TabStop = true;
			this.radioButtonOverviewProperties.Text = resources.GetString("radioButtonOverviewProperties.Text");
			this.radioButtonOverviewProperties.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonOverviewProperties.TextAlign")));
			this.radioButtonOverviewProperties.Visible = ((bool)(resources.GetObject("radioButtonOverviewProperties.Visible")));
			this.radioButtonOverviewProperties.CheckedChanged += new System.EventHandler(this.radioButtonOverviewProperties_CheckedChanged);
			// 
			// tabControlOverview
			// 
			this.tabControlOverview.AccessibleDescription = resources.GetString("tabControlOverview.AccessibleDescription");
			this.tabControlOverview.AccessibleName = resources.GetString("tabControlOverview.AccessibleName");
			this.tabControlOverview.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControlOverview.Alignment")));
			this.tabControlOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControlOverview.Anchor")));
			this.tabControlOverview.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControlOverview.Appearance")));
			this.tabControlOverview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControlOverview.BackgroundImage")));
			this.tabControlOverview.Controls.Add(this.tabPageOverviewProperties);
			this.tabControlOverview.Controls.Add(this.tabPageOverviewParameters);
			this.tabControlOverview.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControlOverview.Dock")));
			this.tabControlOverview.Enabled = ((bool)(resources.GetObject("tabControlOverview.Enabled")));
			this.tabControlOverview.Font = ((System.Drawing.Font)(resources.GetObject("tabControlOverview.Font")));
			this.tabControlOverview.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControlOverview.ImeMode")));
			this.tabControlOverview.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControlOverview.ItemSize")));
			this.tabControlOverview.Location = ((System.Drawing.Point)(resources.GetObject("tabControlOverview.Location")));
			this.tabControlOverview.Name = "tabControlOverview";
			this.tabControlOverview.Padding = ((System.Drawing.Point)(resources.GetObject("tabControlOverview.Padding")));
			this.tabControlOverview.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControlOverview.RightToLeft")));
			this.tabControlOverview.SelectedIndex = 0;
			this.tabControlOverview.ShowToolTips = ((bool)(resources.GetObject("tabControlOverview.ShowToolTips")));
			this.tabControlOverview.Size = ((System.Drawing.Size)(resources.GetObject("tabControlOverview.Size")));
			this.tabControlOverview.TabIndex = ((int)(resources.GetObject("tabControlOverview.TabIndex")));
			this.tabControlOverview.TabStop = false;
			this.tabControlOverview.Text = resources.GetString("tabControlOverview.Text");
			this.tabControlOverview.Visible = ((bool)(resources.GetObject("tabControlOverview.Visible")));
			// 
			// tabPageOverviewProperties
			// 
			this.tabPageOverviewProperties.AccessibleDescription = resources.GetString("tabPageOverviewProperties.AccessibleDescription");
			this.tabPageOverviewProperties.AccessibleName = resources.GetString("tabPageOverviewProperties.AccessibleName");
			this.tabPageOverviewProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageOverviewProperties.Anchor")));
			this.tabPageOverviewProperties.AutoScroll = ((bool)(resources.GetObject("tabPageOverviewProperties.AutoScroll")));
			this.tabPageOverviewProperties.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewProperties.AutoScrollMargin")));
			this.tabPageOverviewProperties.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewProperties.AutoScrollMinSize")));
			this.tabPageOverviewProperties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageOverviewProperties.BackgroundImage")));
			this.tabPageOverviewProperties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageOverviewProperties.Dock")));
			this.tabPageOverviewProperties.Enabled = ((bool)(resources.GetObject("tabPageOverviewProperties.Enabled")));
			this.tabPageOverviewProperties.Font = ((System.Drawing.Font)(resources.GetObject("tabPageOverviewProperties.Font")));
			this.tabPageOverviewProperties.ImageIndex = ((int)(resources.GetObject("tabPageOverviewProperties.ImageIndex")));
			this.tabPageOverviewProperties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageOverviewProperties.ImeMode")));
			this.tabPageOverviewProperties.Location = ((System.Drawing.Point)(resources.GetObject("tabPageOverviewProperties.Location")));
			this.tabPageOverviewProperties.Name = "tabPageOverviewProperties";
			this.tabPageOverviewProperties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageOverviewProperties.RightToLeft")));
			this.tabPageOverviewProperties.Size = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewProperties.Size")));
			this.tabPageOverviewProperties.TabIndex = ((int)(resources.GetObject("tabPageOverviewProperties.TabIndex")));
			this.tabPageOverviewProperties.Text = resources.GetString("tabPageOverviewProperties.Text");
			this.tabPageOverviewProperties.ToolTipText = resources.GetString("tabPageOverviewProperties.ToolTipText");
			this.tabPageOverviewProperties.Visible = ((bool)(resources.GetObject("tabPageOverviewProperties.Visible")));
			// 
			// tabPageOverviewParameters
			// 
			this.tabPageOverviewParameters.AccessibleDescription = resources.GetString("tabPageOverviewParameters.AccessibleDescription");
			this.tabPageOverviewParameters.AccessibleName = resources.GetString("tabPageOverviewParameters.AccessibleName");
			this.tabPageOverviewParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageOverviewParameters.Anchor")));
			this.tabPageOverviewParameters.AutoScroll = ((bool)(resources.GetObject("tabPageOverviewParameters.AutoScroll")));
			this.tabPageOverviewParameters.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewParameters.AutoScrollMargin")));
			this.tabPageOverviewParameters.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewParameters.AutoScrollMinSize")));
			this.tabPageOverviewParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageOverviewParameters.BackgroundImage")));
			this.tabPageOverviewParameters.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageOverviewParameters.Dock")));
			this.tabPageOverviewParameters.Enabled = ((bool)(resources.GetObject("tabPageOverviewParameters.Enabled")));
			this.tabPageOverviewParameters.Font = ((System.Drawing.Font)(resources.GetObject("tabPageOverviewParameters.Font")));
			this.tabPageOverviewParameters.ImageIndex = ((int)(resources.GetObject("tabPageOverviewParameters.ImageIndex")));
			this.tabPageOverviewParameters.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageOverviewParameters.ImeMode")));
			this.tabPageOverviewParameters.Location = ((System.Drawing.Point)(resources.GetObject("tabPageOverviewParameters.Location")));
			this.tabPageOverviewParameters.Name = "tabPageOverviewParameters";
			this.tabPageOverviewParameters.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageOverviewParameters.RightToLeft")));
			this.tabPageOverviewParameters.Size = ((System.Drawing.Size)(resources.GetObject("tabPageOverviewParameters.Size")));
			this.tabPageOverviewParameters.TabIndex = ((int)(resources.GetObject("tabPageOverviewParameters.TabIndex")));
			this.tabPageOverviewParameters.Text = resources.GetString("tabPageOverviewParameters.Text");
			this.tabPageOverviewParameters.ToolTipText = resources.GetString("tabPageOverviewParameters.ToolTipText");
			this.tabPageOverviewParameters.Visible = ((bool)(resources.GetObject("tabPageOverviewParameters.Visible")));
			// 
			// tabPageCampaignStatisticsCallJobs
			// 
			this.tabPageCampaignStatisticsCallJobs.AccessibleDescription = resources.GetString("tabPageCampaignStatisticsCallJobs.AccessibleDescription");
			this.tabPageCampaignStatisticsCallJobs.AccessibleName = resources.GetString("tabPageCampaignStatisticsCallJobs.AccessibleName");
			this.tabPageCampaignStatisticsCallJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Anchor")));
			this.tabPageCampaignStatisticsCallJobs.AutoScroll = ((bool)(resources.GetObject("tabPageCampaignStatisticsCallJobs.AutoScroll")));
			this.tabPageCampaignStatisticsCallJobs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsCallJobs.AutoScrollMargin")));
			this.tabPageCampaignStatisticsCallJobs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsCallJobs.AutoScrollMinSize")));
			this.tabPageCampaignStatisticsCallJobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCampaignStatisticsCallJobs.BackgroundImage")));
			this.tabPageCampaignStatisticsCallJobs.Controls.Add(this.panelStatisticsCallJobs);
			this.tabPageCampaignStatisticsCallJobs.Controls.Add(this.tabControlStatisticsCallJobs);
			this.tabPageCampaignStatisticsCallJobs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Dock")));
			this.tabPageCampaignStatisticsCallJobs.Enabled = ((bool)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Enabled")));
			this.tabPageCampaignStatisticsCallJobs.Font = ((System.Drawing.Font)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Font")));
			this.tabPageCampaignStatisticsCallJobs.ImageIndex = ((int)(resources.GetObject("tabPageCampaignStatisticsCallJobs.ImageIndex")));
			this.tabPageCampaignStatisticsCallJobs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageCampaignStatisticsCallJobs.ImeMode")));
			this.tabPageCampaignStatisticsCallJobs.Location = ((System.Drawing.Point)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Location")));
			this.tabPageCampaignStatisticsCallJobs.Name = "tabPageCampaignStatisticsCallJobs";
			this.tabPageCampaignStatisticsCallJobs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageCampaignStatisticsCallJobs.RightToLeft")));
			this.tabPageCampaignStatisticsCallJobs.Size = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Size")));
			this.tabPageCampaignStatisticsCallJobs.TabIndex = ((int)(resources.GetObject("tabPageCampaignStatisticsCallJobs.TabIndex")));
			this.tabPageCampaignStatisticsCallJobs.Text = resources.GetString("tabPageCampaignStatisticsCallJobs.Text");
			this.tabPageCampaignStatisticsCallJobs.ToolTipText = resources.GetString("tabPageCampaignStatisticsCallJobs.ToolTipText");
			this.tabPageCampaignStatisticsCallJobs.Visible = ((bool)(resources.GetObject("tabPageCampaignStatisticsCallJobs.Visible")));
			// 
			// panelStatisticsCallJobs
			// 
			this.panelStatisticsCallJobs.AccessibleDescription = resources.GetString("panelStatisticsCallJobs.AccessibleDescription");
			this.panelStatisticsCallJobs.AccessibleName = resources.GetString("panelStatisticsCallJobs.AccessibleName");
			this.panelStatisticsCallJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelStatisticsCallJobs.Anchor")));
			this.panelStatisticsCallJobs.AutoScroll = ((bool)(resources.GetObject("panelStatisticsCallJobs.AutoScroll")));
			this.panelStatisticsCallJobs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelStatisticsCallJobs.AutoScrollMargin")));
			this.panelStatisticsCallJobs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelStatisticsCallJobs.AutoScrollMinSize")));
			this.panelStatisticsCallJobs.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelStatisticsCallJobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStatisticsCallJobs.BackgroundImage")));
			this.panelStatisticsCallJobs.Controls.Add(this.radioButtonStatisticsCallJobsTotalStatistics);
			this.panelStatisticsCallJobs.Controls.Add(this.radioButtonStatisticsCallJobsRecentStatistics);
			this.panelStatisticsCallJobs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelStatisticsCallJobs.Dock")));
			this.panelStatisticsCallJobs.Enabled = ((bool)(resources.GetObject("panelStatisticsCallJobs.Enabled")));
			this.panelStatisticsCallJobs.Font = ((System.Drawing.Font)(resources.GetObject("panelStatisticsCallJobs.Font")));
			this.panelStatisticsCallJobs.ForeColor = System.Drawing.SystemColors.Window;
			this.panelStatisticsCallJobs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelStatisticsCallJobs.ImeMode")));
			this.panelStatisticsCallJobs.Location = ((System.Drawing.Point)(resources.GetObject("panelStatisticsCallJobs.Location")));
			this.panelStatisticsCallJobs.Name = "panelStatisticsCallJobs";
			this.panelStatisticsCallJobs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelStatisticsCallJobs.RightToLeft")));
			this.panelStatisticsCallJobs.Size = ((System.Drawing.Size)(resources.GetObject("panelStatisticsCallJobs.Size")));
			this.panelStatisticsCallJobs.TabIndex = ((int)(resources.GetObject("panelStatisticsCallJobs.TabIndex")));
			this.panelStatisticsCallJobs.Text = resources.GetString("panelStatisticsCallJobs.Text");
			this.panelStatisticsCallJobs.Visible = ((bool)(resources.GetObject("panelStatisticsCallJobs.Visible")));
			// 
			// radioButtonStatisticsCallJobsTotalStatistics
			// 
			this.radioButtonStatisticsCallJobsTotalStatistics.AccessibleDescription = resources.GetString("radioButtonStatisticsCallJobsTotalStatistics.AccessibleDescription");
			this.radioButtonStatisticsCallJobsTotalStatistics.AccessibleName = resources.GetString("radioButtonStatisticsCallJobsTotalStatistics.AccessibleName");
			this.radioButtonStatisticsCallJobsTotalStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Anchor")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Appearance")));
			this.radioButtonStatisticsCallJobsTotalStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.BackgroundImage")));
			this.radioButtonStatisticsCallJobsTotalStatistics.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.CheckAlign")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Dock")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Enabled = ((bool)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Enabled")));
			this.radioButtonStatisticsCallJobsTotalStatistics.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.FlatStyle")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Font")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Image")));
			this.radioButtonStatisticsCallJobsTotalStatistics.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.ImageAlign")));
			this.radioButtonStatisticsCallJobsTotalStatistics.ImageIndex = ((int)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.ImageIndex")));
			this.radioButtonStatisticsCallJobsTotalStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.ImeMode")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Location")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Name = "radioButtonStatisticsCallJobsTotalStatistics";
			this.radioButtonStatisticsCallJobsTotalStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.RightToLeft")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Size")));
			this.radioButtonStatisticsCallJobsTotalStatistics.TabIndex = ((int)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.TabIndex")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Text = resources.GetString("radioButtonStatisticsCallJobsTotalStatistics.Text");
			this.radioButtonStatisticsCallJobsTotalStatistics.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.TextAlign")));
			this.radioButtonStatisticsCallJobsTotalStatistics.Visible = ((bool)(resources.GetObject("radioButtonStatisticsCallJobsTotalStatistics.Visible")));
			this.radioButtonStatisticsCallJobsTotalStatistics.CheckedChanged += new System.EventHandler(this.radioButtonStatisticsCallJobsTotalStatistics_CheckedChanged);
			// 
			// radioButtonStatisticsCallJobsRecentStatistics
			// 
			this.radioButtonStatisticsCallJobsRecentStatistics.AccessibleDescription = resources.GetString("radioButtonStatisticsCallJobsRecentStatistics.AccessibleDescription");
			this.radioButtonStatisticsCallJobsRecentStatistics.AccessibleName = resources.GetString("radioButtonStatisticsCallJobsRecentStatistics.AccessibleName");
			this.radioButtonStatisticsCallJobsRecentStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Anchor")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Appearance")));
			this.radioButtonStatisticsCallJobsRecentStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.BackgroundImage")));
			this.radioButtonStatisticsCallJobsRecentStatistics.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.CheckAlign")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Checked = true;
			this.radioButtonStatisticsCallJobsRecentStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Dock")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Enabled = ((bool)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Enabled")));
			this.radioButtonStatisticsCallJobsRecentStatistics.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.FlatStyle")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Font")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Image")));
			this.radioButtonStatisticsCallJobsRecentStatistics.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.ImageAlign")));
			this.radioButtonStatisticsCallJobsRecentStatistics.ImageIndex = ((int)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.ImageIndex")));
			this.radioButtonStatisticsCallJobsRecentStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.ImeMode")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Location")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Name = "radioButtonStatisticsCallJobsRecentStatistics";
			this.radioButtonStatisticsCallJobsRecentStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.RightToLeft")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Size")));
			this.radioButtonStatisticsCallJobsRecentStatistics.TabIndex = ((int)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.TabIndex")));
			this.radioButtonStatisticsCallJobsRecentStatistics.TabStop = true;
			this.radioButtonStatisticsCallJobsRecentStatistics.Text = resources.GetString("radioButtonStatisticsCallJobsRecentStatistics.Text");
			this.radioButtonStatisticsCallJobsRecentStatistics.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.TextAlign")));
			this.radioButtonStatisticsCallJobsRecentStatistics.Visible = ((bool)(resources.GetObject("radioButtonStatisticsCallJobsRecentStatistics.Visible")));
			this.radioButtonStatisticsCallJobsRecentStatistics.CheckedChanged += new System.EventHandler(this.radioButtonStatisticsCallJobsRecentStatistics_CheckedChanged);
			// 
			// tabControlStatisticsCallJobs
			// 
			this.tabControlStatisticsCallJobs.AccessibleDescription = resources.GetString("tabControlStatisticsCallJobs.AccessibleDescription");
			this.tabControlStatisticsCallJobs.AccessibleName = resources.GetString("tabControlStatisticsCallJobs.AccessibleName");
			this.tabControlStatisticsCallJobs.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControlStatisticsCallJobs.Alignment")));
			this.tabControlStatisticsCallJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControlStatisticsCallJobs.Anchor")));
			this.tabControlStatisticsCallJobs.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControlStatisticsCallJobs.Appearance")));
			this.tabControlStatisticsCallJobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControlStatisticsCallJobs.BackgroundImage")));
			this.tabControlStatisticsCallJobs.Controls.Add(this.tabPageStatisticsCallJobsRecentStatistics);
			this.tabControlStatisticsCallJobs.Controls.Add(this.tabPageStatisticsCallJobsTotalStatistics);
			this.tabControlStatisticsCallJobs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControlStatisticsCallJobs.Dock")));
			this.tabControlStatisticsCallJobs.Enabled = ((bool)(resources.GetObject("tabControlStatisticsCallJobs.Enabled")));
			this.tabControlStatisticsCallJobs.Font = ((System.Drawing.Font)(resources.GetObject("tabControlStatisticsCallJobs.Font")));
			this.tabControlStatisticsCallJobs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControlStatisticsCallJobs.ImeMode")));
			this.tabControlStatisticsCallJobs.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControlStatisticsCallJobs.ItemSize")));
			this.tabControlStatisticsCallJobs.Location = ((System.Drawing.Point)(resources.GetObject("tabControlStatisticsCallJobs.Location")));
			this.tabControlStatisticsCallJobs.Name = "tabControlStatisticsCallJobs";
			this.tabControlStatisticsCallJobs.Padding = ((System.Drawing.Point)(resources.GetObject("tabControlStatisticsCallJobs.Padding")));
			this.tabControlStatisticsCallJobs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControlStatisticsCallJobs.RightToLeft")));
			this.tabControlStatisticsCallJobs.SelectedIndex = 0;
			this.tabControlStatisticsCallJobs.ShowToolTips = ((bool)(resources.GetObject("tabControlStatisticsCallJobs.ShowToolTips")));
			this.tabControlStatisticsCallJobs.Size = ((System.Drawing.Size)(resources.GetObject("tabControlStatisticsCallJobs.Size")));
			this.tabControlStatisticsCallJobs.TabIndex = ((int)(resources.GetObject("tabControlStatisticsCallJobs.TabIndex")));
			this.tabControlStatisticsCallJobs.TabStop = false;
			this.tabControlStatisticsCallJobs.Text = resources.GetString("tabControlStatisticsCallJobs.Text");
			this.tabControlStatisticsCallJobs.Visible = ((bool)(resources.GetObject("tabControlStatisticsCallJobs.Visible")));
			// 
			// tabPageStatisticsCallJobsRecentStatistics
			// 
			this.tabPageStatisticsCallJobsRecentStatistics.AccessibleDescription = resources.GetString("tabPageStatisticsCallJobsRecentStatistics.AccessibleDescription");
			this.tabPageStatisticsCallJobsRecentStatistics.AccessibleName = resources.GetString("tabPageStatisticsCallJobsRecentStatistics.AccessibleName");
			this.tabPageStatisticsCallJobsRecentStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Anchor")));
			this.tabPageStatisticsCallJobsRecentStatistics.AutoScroll = ((bool)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.AutoScroll")));
			this.tabPageStatisticsCallJobsRecentStatistics.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.AutoScrollMargin")));
			this.tabPageStatisticsCallJobsRecentStatistics.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.AutoScrollMinSize")));
			this.tabPageStatisticsCallJobsRecentStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.BackgroundImage")));
			this.tabPageStatisticsCallJobsRecentStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Dock")));
			this.tabPageStatisticsCallJobsRecentStatistics.Enabled = ((bool)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Enabled")));
			this.tabPageStatisticsCallJobsRecentStatistics.Font = ((System.Drawing.Font)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Font")));
			this.tabPageStatisticsCallJobsRecentStatistics.ImageIndex = ((int)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.ImageIndex")));
			this.tabPageStatisticsCallJobsRecentStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.ImeMode")));
			this.tabPageStatisticsCallJobsRecentStatistics.Location = ((System.Drawing.Point)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Location")));
			this.tabPageStatisticsCallJobsRecentStatistics.Name = "tabPageStatisticsCallJobsRecentStatistics";
			this.tabPageStatisticsCallJobsRecentStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.RightToLeft")));
			this.tabPageStatisticsCallJobsRecentStatistics.Size = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Size")));
			this.tabPageStatisticsCallJobsRecentStatistics.TabIndex = ((int)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.TabIndex")));
			this.tabPageStatisticsCallJobsRecentStatistics.Text = resources.GetString("tabPageStatisticsCallJobsRecentStatistics.Text");
			this.tabPageStatisticsCallJobsRecentStatistics.ToolTipText = resources.GetString("tabPageStatisticsCallJobsRecentStatistics.ToolTipText");
			this.tabPageStatisticsCallJobsRecentStatistics.Visible = ((bool)(resources.GetObject("tabPageStatisticsCallJobsRecentStatistics.Visible")));
			// 
			// tabPageStatisticsCallJobsTotalStatistics
			// 
			this.tabPageStatisticsCallJobsTotalStatistics.AccessibleDescription = resources.GetString("tabPageStatisticsCallJobsTotalStatistics.AccessibleDescription");
			this.tabPageStatisticsCallJobsTotalStatistics.AccessibleName = resources.GetString("tabPageStatisticsCallJobsTotalStatistics.AccessibleName");
			this.tabPageStatisticsCallJobsTotalStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Anchor")));
			this.tabPageStatisticsCallJobsTotalStatistics.AutoScroll = ((bool)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.AutoScroll")));
			this.tabPageStatisticsCallJobsTotalStatistics.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.AutoScrollMargin")));
			this.tabPageStatisticsCallJobsTotalStatistics.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.AutoScrollMinSize")));
			this.tabPageStatisticsCallJobsTotalStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.BackgroundImage")));
			this.tabPageStatisticsCallJobsTotalStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Dock")));
			this.tabPageStatisticsCallJobsTotalStatistics.Enabled = ((bool)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Enabled")));
			this.tabPageStatisticsCallJobsTotalStatistics.Font = ((System.Drawing.Font)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Font")));
			this.tabPageStatisticsCallJobsTotalStatistics.ImageIndex = ((int)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.ImageIndex")));
			this.tabPageStatisticsCallJobsTotalStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.ImeMode")));
			this.tabPageStatisticsCallJobsTotalStatistics.Location = ((System.Drawing.Point)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Location")));
			this.tabPageStatisticsCallJobsTotalStatistics.Name = "tabPageStatisticsCallJobsTotalStatistics";
			this.tabPageStatisticsCallJobsTotalStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.RightToLeft")));
			this.tabPageStatisticsCallJobsTotalStatistics.Size = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Size")));
			this.tabPageStatisticsCallJobsTotalStatistics.TabIndex = ((int)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.TabIndex")));
			this.tabPageStatisticsCallJobsTotalStatistics.Text = resources.GetString("tabPageStatisticsCallJobsTotalStatistics.Text");
			this.tabPageStatisticsCallJobsTotalStatistics.ToolTipText = resources.GetString("tabPageStatisticsCallJobsTotalStatistics.ToolTipText");
			this.tabPageStatisticsCallJobsTotalStatistics.Visible = ((bool)(resources.GetObject("tabPageStatisticsCallJobsTotalStatistics.Visible")));
			// 
			// tabPageCampaignStatisticsIncomingCalls
			// 
			this.tabPageCampaignStatisticsIncomingCalls.AccessibleDescription = resources.GetString("tabPageCampaignStatisticsIncomingCalls.AccessibleDescription");
			this.tabPageCampaignStatisticsIncomingCalls.AccessibleName = resources.GetString("tabPageCampaignStatisticsIncomingCalls.AccessibleName");
			this.tabPageCampaignStatisticsIncomingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Anchor")));
			this.tabPageCampaignStatisticsIncomingCalls.AutoScroll = ((bool)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.AutoScroll")));
			this.tabPageCampaignStatisticsIncomingCalls.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.AutoScrollMargin")));
			this.tabPageCampaignStatisticsIncomingCalls.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.AutoScrollMinSize")));
			this.tabPageCampaignStatisticsIncomingCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.BackgroundImage")));
			this.tabPageCampaignStatisticsIncomingCalls.Controls.Add(this.panelStatisticsIncomingCalls);
			this.tabPageCampaignStatisticsIncomingCalls.Controls.Add(this.tabControlStatisticsIncomingCalls);
			this.tabPageCampaignStatisticsIncomingCalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Dock")));
			this.tabPageCampaignStatisticsIncomingCalls.Enabled = ((bool)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Enabled")));
			this.tabPageCampaignStatisticsIncomingCalls.Font = ((System.Drawing.Font)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Font")));
			this.tabPageCampaignStatisticsIncomingCalls.ImageIndex = ((int)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.ImageIndex")));
			this.tabPageCampaignStatisticsIncomingCalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.ImeMode")));
			this.tabPageCampaignStatisticsIncomingCalls.Location = ((System.Drawing.Point)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Location")));
			this.tabPageCampaignStatisticsIncomingCalls.Name = "tabPageCampaignStatisticsIncomingCalls";
			this.tabPageCampaignStatisticsIncomingCalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.RightToLeft")));
			this.tabPageCampaignStatisticsIncomingCalls.Size = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Size")));
			this.tabPageCampaignStatisticsIncomingCalls.TabIndex = ((int)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.TabIndex")));
			this.tabPageCampaignStatisticsIncomingCalls.Text = resources.GetString("tabPageCampaignStatisticsIncomingCalls.Text");
			this.tabPageCampaignStatisticsIncomingCalls.ToolTipText = resources.GetString("tabPageCampaignStatisticsIncomingCalls.ToolTipText");
			this.tabPageCampaignStatisticsIncomingCalls.Visible = ((bool)(resources.GetObject("tabPageCampaignStatisticsIncomingCalls.Visible")));
			// 
			// panelStatisticsIncomingCalls
			// 
			this.panelStatisticsIncomingCalls.AccessibleDescription = resources.GetString("panelStatisticsIncomingCalls.AccessibleDescription");
			this.panelStatisticsIncomingCalls.AccessibleName = resources.GetString("panelStatisticsIncomingCalls.AccessibleName");
			this.panelStatisticsIncomingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelStatisticsIncomingCalls.Anchor")));
			this.panelStatisticsIncomingCalls.AutoScroll = ((bool)(resources.GetObject("panelStatisticsIncomingCalls.AutoScroll")));
			this.panelStatisticsIncomingCalls.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelStatisticsIncomingCalls.AutoScrollMargin")));
			this.panelStatisticsIncomingCalls.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelStatisticsIncomingCalls.AutoScrollMinSize")));
			this.panelStatisticsIncomingCalls.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelStatisticsIncomingCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStatisticsIncomingCalls.BackgroundImage")));
			this.panelStatisticsIncomingCalls.Controls.Add(this.radioButtonStatisticsIncomingCallsTotalStatistics);
			this.panelStatisticsIncomingCalls.Controls.Add(this.radioButtonStatisticsIncomingCallsRecentStatistics);
			this.panelStatisticsIncomingCalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelStatisticsIncomingCalls.Dock")));
			this.panelStatisticsIncomingCalls.Enabled = ((bool)(resources.GetObject("panelStatisticsIncomingCalls.Enabled")));
			this.panelStatisticsIncomingCalls.Font = ((System.Drawing.Font)(resources.GetObject("panelStatisticsIncomingCalls.Font")));
			this.panelStatisticsIncomingCalls.ForeColor = System.Drawing.SystemColors.Window;
			this.panelStatisticsIncomingCalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelStatisticsIncomingCalls.ImeMode")));
			this.panelStatisticsIncomingCalls.Location = ((System.Drawing.Point)(resources.GetObject("panelStatisticsIncomingCalls.Location")));
			this.panelStatisticsIncomingCalls.Name = "panelStatisticsIncomingCalls";
			this.panelStatisticsIncomingCalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelStatisticsIncomingCalls.RightToLeft")));
			this.panelStatisticsIncomingCalls.Size = ((System.Drawing.Size)(resources.GetObject("panelStatisticsIncomingCalls.Size")));
			this.panelStatisticsIncomingCalls.TabIndex = ((int)(resources.GetObject("panelStatisticsIncomingCalls.TabIndex")));
			this.panelStatisticsIncomingCalls.Text = resources.GetString("panelStatisticsIncomingCalls.Text");
			this.panelStatisticsIncomingCalls.Visible = ((bool)(resources.GetObject("panelStatisticsIncomingCalls.Visible")));
			// 
			// radioButtonStatisticsIncomingCallsTotalStatistics
			// 
			this.radioButtonStatisticsIncomingCallsTotalStatistics.AccessibleDescription = resources.GetString("radioButtonStatisticsIncomingCallsTotalStatistics.AccessibleDescription");
			this.radioButtonStatisticsIncomingCallsTotalStatistics.AccessibleName = resources.GetString("radioButtonStatisticsIncomingCallsTotalStatistics.AccessibleName");
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Anchor")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Appearance")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.BackgroundImage")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.CheckAlign")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Dock")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Enabled = ((bool)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Enabled")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.FlatStyle")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Font")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Image")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.ImageAlign")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.ImageIndex = ((int)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.ImageIndex")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.ImeMode")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Location")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Name = "radioButtonStatisticsIncomingCallsTotalStatistics";
			this.radioButtonStatisticsIncomingCallsTotalStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.RightToLeft")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Size")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.TabIndex = ((int)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.TabIndex")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Text = resources.GetString("radioButtonStatisticsIncomingCallsTotalStatistics.Text");
			this.radioButtonStatisticsIncomingCallsTotalStatistics.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.TextAlign")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.Visible = ((bool)(resources.GetObject("radioButtonStatisticsIncomingCallsTotalStatistics.Visible")));
			this.radioButtonStatisticsIncomingCallsTotalStatistics.CheckedChanged += new System.EventHandler(this.radioButtonStatisticsIncomingCallsTotalStatistics_CheckedChanged);
			// 
			// radioButtonStatisticsIncomingCallsRecentStatistics
			// 
			this.radioButtonStatisticsIncomingCallsRecentStatistics.AccessibleDescription = resources.GetString("radioButtonStatisticsIncomingCallsRecentStatistics.AccessibleDescription");
			this.radioButtonStatisticsIncomingCallsRecentStatistics.AccessibleName = resources.GetString("radioButtonStatisticsIncomingCallsRecentStatistics.AccessibleName");
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Anchor")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Appearance")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.BackgroundImage")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.CheckAlign")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Checked = true;
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Dock")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Enabled = ((bool)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Enabled")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.FlatStyle")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Font")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Image")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.ImageAlign")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.ImageIndex = ((int)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.ImageIndex")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.ImeMode")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Location")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Name = "radioButtonStatisticsIncomingCallsRecentStatistics";
			this.radioButtonStatisticsIncomingCallsRecentStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.RightToLeft")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Size")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.TabIndex = ((int)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.TabIndex")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.TabStop = true;
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Text = resources.GetString("radioButtonStatisticsIncomingCallsRecentStatistics.Text");
			this.radioButtonStatisticsIncomingCallsRecentStatistics.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.TextAlign")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.Visible = ((bool)(resources.GetObject("radioButtonStatisticsIncomingCallsRecentStatistics.Visible")));
			this.radioButtonStatisticsIncomingCallsRecentStatistics.CheckedChanged += new System.EventHandler(this.radioButtonStatisticsIncomingCallsRecentStatistics_CheckedChanged);
			// 
			// tabControlStatisticsIncomingCalls
			// 
			this.tabControlStatisticsIncomingCalls.AccessibleDescription = resources.GetString("tabControlStatisticsIncomingCalls.AccessibleDescription");
			this.tabControlStatisticsIncomingCalls.AccessibleName = resources.GetString("tabControlStatisticsIncomingCalls.AccessibleName");
			this.tabControlStatisticsIncomingCalls.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControlStatisticsIncomingCalls.Alignment")));
			this.tabControlStatisticsIncomingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControlStatisticsIncomingCalls.Anchor")));
			this.tabControlStatisticsIncomingCalls.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControlStatisticsIncomingCalls.Appearance")));
			this.tabControlStatisticsIncomingCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControlStatisticsIncomingCalls.BackgroundImage")));
			this.tabControlStatisticsIncomingCalls.Controls.Add(this.tabPageStatisticsIncomingCallsRecentStatistics);
			this.tabControlStatisticsIncomingCalls.Controls.Add(this.tabPageStatisticsIncomingCallsTotalStatistics);
			this.tabControlStatisticsIncomingCalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControlStatisticsIncomingCalls.Dock")));
			this.tabControlStatisticsIncomingCalls.Enabled = ((bool)(resources.GetObject("tabControlStatisticsIncomingCalls.Enabled")));
			this.tabControlStatisticsIncomingCalls.Font = ((System.Drawing.Font)(resources.GetObject("tabControlStatisticsIncomingCalls.Font")));
			this.tabControlStatisticsIncomingCalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControlStatisticsIncomingCalls.ImeMode")));
			this.tabControlStatisticsIncomingCalls.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControlStatisticsIncomingCalls.ItemSize")));
			this.tabControlStatisticsIncomingCalls.Location = ((System.Drawing.Point)(resources.GetObject("tabControlStatisticsIncomingCalls.Location")));
			this.tabControlStatisticsIncomingCalls.Name = "tabControlStatisticsIncomingCalls";
			this.tabControlStatisticsIncomingCalls.Padding = ((System.Drawing.Point)(resources.GetObject("tabControlStatisticsIncomingCalls.Padding")));
			this.tabControlStatisticsIncomingCalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControlStatisticsIncomingCalls.RightToLeft")));
			this.tabControlStatisticsIncomingCalls.SelectedIndex = 0;
			this.tabControlStatisticsIncomingCalls.ShowToolTips = ((bool)(resources.GetObject("tabControlStatisticsIncomingCalls.ShowToolTips")));
			this.tabControlStatisticsIncomingCalls.Size = ((System.Drawing.Size)(resources.GetObject("tabControlStatisticsIncomingCalls.Size")));
			this.tabControlStatisticsIncomingCalls.TabIndex = ((int)(resources.GetObject("tabControlStatisticsIncomingCalls.TabIndex")));
			this.tabControlStatisticsIncomingCalls.TabStop = false;
			this.tabControlStatisticsIncomingCalls.Text = resources.GetString("tabControlStatisticsIncomingCalls.Text");
			this.tabControlStatisticsIncomingCalls.Visible = ((bool)(resources.GetObject("tabControlStatisticsIncomingCalls.Visible")));
			// 
			// tabPageStatisticsIncomingCallsRecentStatistics
			// 
			this.tabPageStatisticsIncomingCallsRecentStatistics.AccessibleDescription = resources.GetString("tabPageStatisticsIncomingCallsRecentStatistics.AccessibleDescription");
			this.tabPageStatisticsIncomingCallsRecentStatistics.AccessibleName = resources.GetString("tabPageStatisticsIncomingCallsRecentStatistics.AccessibleName");
			this.tabPageStatisticsIncomingCallsRecentStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Anchor")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.AutoScroll = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.AutoScroll")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.AutoScrollMargin")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.AutoScrollMinSize")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.BackgroundImage")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Dock")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Enabled = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Enabled")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Font = ((System.Drawing.Font)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Font")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.ImageIndex = ((int)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.ImageIndex")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.ImeMode")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Location = ((System.Drawing.Point)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Location")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Name = "tabPageStatisticsIncomingCallsRecentStatistics";
			this.tabPageStatisticsIncomingCallsRecentStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.RightToLeft")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Size = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Size")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.TabIndex = ((int)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.TabIndex")));
			this.tabPageStatisticsIncomingCallsRecentStatistics.Text = resources.GetString("tabPageStatisticsIncomingCallsRecentStatistics.Text");
			this.tabPageStatisticsIncomingCallsRecentStatistics.ToolTipText = resources.GetString("tabPageStatisticsIncomingCallsRecentStatistics.ToolTipText");
			this.tabPageStatisticsIncomingCallsRecentStatistics.Visible = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsRecentStatistics.Visible")));
			// 
			// tabPageStatisticsIncomingCallsTotalStatistics
			// 
			this.tabPageStatisticsIncomingCallsTotalStatistics.AccessibleDescription = resources.GetString("tabPageStatisticsIncomingCallsTotalStatistics.AccessibleDescription");
			this.tabPageStatisticsIncomingCallsTotalStatistics.AccessibleName = resources.GetString("tabPageStatisticsIncomingCallsTotalStatistics.AccessibleName");
			this.tabPageStatisticsIncomingCallsTotalStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Anchor")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.AutoScroll = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.AutoScroll")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.AutoScrollMargin")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.AutoScrollMinSize")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.BackgroundImage")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Dock")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Enabled = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Enabled")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Font = ((System.Drawing.Font)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Font")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.ImageIndex = ((int)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.ImageIndex")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.ImeMode")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Location = ((System.Drawing.Point)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Location")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Name = "tabPageStatisticsIncomingCallsTotalStatistics";
			this.tabPageStatisticsIncomingCallsTotalStatistics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.RightToLeft")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Size = ((System.Drawing.Size)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Size")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.TabIndex = ((int)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.TabIndex")));
			this.tabPageStatisticsIncomingCallsTotalStatistics.Text = resources.GetString("tabPageStatisticsIncomingCallsTotalStatistics.Text");
			this.tabPageStatisticsIncomingCallsTotalStatistics.ToolTipText = resources.GetString("tabPageStatisticsIncomingCallsTotalStatistics.ToolTipText");
			this.tabPageStatisticsIncomingCallsTotalStatistics.Visible = ((bool)(resources.GetObject("tabPageStatisticsIncomingCallsTotalStatistics.Visible")));
			// 
			// tabPageCampaignResources
			// 
			this.tabPageCampaignResources.AccessibleDescription = resources.GetString("tabPageCampaignResources.AccessibleDescription");
			this.tabPageCampaignResources.AccessibleName = resources.GetString("tabPageCampaignResources.AccessibleName");
			this.tabPageCampaignResources.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageCampaignResources.Anchor")));
			this.tabPageCampaignResources.AutoScroll = ((bool)(resources.GetObject("tabPageCampaignResources.AutoScroll")));
			this.tabPageCampaignResources.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignResources.AutoScrollMargin")));
			this.tabPageCampaignResources.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignResources.AutoScrollMinSize")));
			this.tabPageCampaignResources.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCampaignResources.BackgroundImage")));
			this.tabPageCampaignResources.Controls.Add(this.panelResources);
			this.tabPageCampaignResources.Controls.Add(this.tabControlResources);
			this.tabPageCampaignResources.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageCampaignResources.Dock")));
			this.tabPageCampaignResources.Enabled = ((bool)(resources.GetObject("tabPageCampaignResources.Enabled")));
			this.tabPageCampaignResources.Font = ((System.Drawing.Font)(resources.GetObject("tabPageCampaignResources.Font")));
			this.tabPageCampaignResources.ImageIndex = ((int)(resources.GetObject("tabPageCampaignResources.ImageIndex")));
			this.tabPageCampaignResources.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageCampaignResources.ImeMode")));
			this.tabPageCampaignResources.Location = ((System.Drawing.Point)(resources.GetObject("tabPageCampaignResources.Location")));
			this.tabPageCampaignResources.Name = "tabPageCampaignResources";
			this.tabPageCampaignResources.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageCampaignResources.RightToLeft")));
			this.tabPageCampaignResources.Size = ((System.Drawing.Size)(resources.GetObject("tabPageCampaignResources.Size")));
			this.tabPageCampaignResources.TabIndex = ((int)(resources.GetObject("tabPageCampaignResources.TabIndex")));
			this.tabPageCampaignResources.Text = resources.GetString("tabPageCampaignResources.Text");
			this.tabPageCampaignResources.ToolTipText = resources.GetString("tabPageCampaignResources.ToolTipText");
			this.tabPageCampaignResources.Visible = ((bool)(resources.GetObject("tabPageCampaignResources.Visible")));
			// 
			// panelResources
			// 
			this.panelResources.AccessibleDescription = resources.GetString("panelResources.AccessibleDescription");
			this.panelResources.AccessibleName = resources.GetString("panelResources.AccessibleName");
			this.panelResources.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelResources.Anchor")));
			this.panelResources.AutoScroll = ((bool)(resources.GetObject("panelResources.AutoScroll")));
			this.panelResources.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelResources.AutoScrollMargin")));
			this.panelResources.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelResources.AutoScrollMinSize")));
			this.panelResources.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelResources.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelResources.BackgroundImage")));
			this.panelResources.Controls.Add(this.radioButtonResourcesIncomingCalls);
			this.panelResources.Controls.Add(this.radioButtonResourcesCallJobs);
			this.panelResources.Controls.Add(this.radioButtonResourcesAgents);
			this.panelResources.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelResources.Dock")));
			this.panelResources.Enabled = ((bool)(resources.GetObject("panelResources.Enabled")));
			this.panelResources.Font = ((System.Drawing.Font)(resources.GetObject("panelResources.Font")));
			this.panelResources.ForeColor = System.Drawing.SystemColors.Window;
			this.panelResources.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelResources.ImeMode")));
			this.panelResources.Location = ((System.Drawing.Point)(resources.GetObject("panelResources.Location")));
			this.panelResources.Name = "panelResources";
			this.panelResources.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelResources.RightToLeft")));
			this.panelResources.Size = ((System.Drawing.Size)(resources.GetObject("panelResources.Size")));
			this.panelResources.TabIndex = ((int)(resources.GetObject("panelResources.TabIndex")));
			this.panelResources.Text = resources.GetString("panelResources.Text");
			this.panelResources.Visible = ((bool)(resources.GetObject("panelResources.Visible")));
			// 
			// radioButtonResourcesIncomingCalls
			// 
			this.radioButtonResourcesIncomingCalls.AccessibleDescription = resources.GetString("radioButtonResourcesIncomingCalls.AccessibleDescription");
			this.radioButtonResourcesIncomingCalls.AccessibleName = resources.GetString("radioButtonResourcesIncomingCalls.AccessibleName");
			this.radioButtonResourcesIncomingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonResourcesIncomingCalls.Anchor")));
			this.radioButtonResourcesIncomingCalls.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonResourcesIncomingCalls.Appearance")));
			this.radioButtonResourcesIncomingCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesIncomingCalls.BackgroundImage")));
			this.radioButtonResourcesIncomingCalls.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesIncomingCalls.CheckAlign")));
			this.radioButtonResourcesIncomingCalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonResourcesIncomingCalls.Dock")));
			this.radioButtonResourcesIncomingCalls.Enabled = ((bool)(resources.GetObject("radioButtonResourcesIncomingCalls.Enabled")));
			this.radioButtonResourcesIncomingCalls.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonResourcesIncomingCalls.FlatStyle")));
			this.radioButtonResourcesIncomingCalls.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonResourcesIncomingCalls.Font")));
			this.radioButtonResourcesIncomingCalls.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesIncomingCalls.Image")));
			this.radioButtonResourcesIncomingCalls.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesIncomingCalls.ImageAlign")));
			this.radioButtonResourcesIncomingCalls.ImageIndex = ((int)(resources.GetObject("radioButtonResourcesIncomingCalls.ImageIndex")));
			this.radioButtonResourcesIncomingCalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonResourcesIncomingCalls.ImeMode")));
			this.radioButtonResourcesIncomingCalls.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonResourcesIncomingCalls.Location")));
			this.radioButtonResourcesIncomingCalls.Name = "radioButtonResourcesIncomingCalls";
			this.radioButtonResourcesIncomingCalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonResourcesIncomingCalls.RightToLeft")));
			this.radioButtonResourcesIncomingCalls.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonResourcesIncomingCalls.Size")));
			this.radioButtonResourcesIncomingCalls.TabIndex = ((int)(resources.GetObject("radioButtonResourcesIncomingCalls.TabIndex")));
			this.radioButtonResourcesIncomingCalls.Text = resources.GetString("radioButtonResourcesIncomingCalls.Text");
			this.radioButtonResourcesIncomingCalls.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesIncomingCalls.TextAlign")));
			this.radioButtonResourcesIncomingCalls.Visible = ((bool)(resources.GetObject("radioButtonResourcesIncomingCalls.Visible")));
			this.radioButtonResourcesIncomingCalls.CheckedChanged += new System.EventHandler(this.radioButtonResourcesIncomingCalls_CheckedChanged);
			// 
			// radioButtonResourcesCallJobs
			// 
			this.radioButtonResourcesCallJobs.AccessibleDescription = resources.GetString("radioButtonResourcesCallJobs.AccessibleDescription");
			this.radioButtonResourcesCallJobs.AccessibleName = resources.GetString("radioButtonResourcesCallJobs.AccessibleName");
			this.radioButtonResourcesCallJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonResourcesCallJobs.Anchor")));
			this.radioButtonResourcesCallJobs.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonResourcesCallJobs.Appearance")));
			this.radioButtonResourcesCallJobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesCallJobs.BackgroundImage")));
			this.radioButtonResourcesCallJobs.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesCallJobs.CheckAlign")));
			this.radioButtonResourcesCallJobs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonResourcesCallJobs.Dock")));
			this.radioButtonResourcesCallJobs.Enabled = ((bool)(resources.GetObject("radioButtonResourcesCallJobs.Enabled")));
			this.radioButtonResourcesCallJobs.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonResourcesCallJobs.FlatStyle")));
			this.radioButtonResourcesCallJobs.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonResourcesCallJobs.Font")));
			this.radioButtonResourcesCallJobs.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesCallJobs.Image")));
			this.radioButtonResourcesCallJobs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesCallJobs.ImageAlign")));
			this.radioButtonResourcesCallJobs.ImageIndex = ((int)(resources.GetObject("radioButtonResourcesCallJobs.ImageIndex")));
			this.radioButtonResourcesCallJobs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonResourcesCallJobs.ImeMode")));
			this.radioButtonResourcesCallJobs.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonResourcesCallJobs.Location")));
			this.radioButtonResourcesCallJobs.Name = "radioButtonResourcesCallJobs";
			this.radioButtonResourcesCallJobs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonResourcesCallJobs.RightToLeft")));
			this.radioButtonResourcesCallJobs.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonResourcesCallJobs.Size")));
			this.radioButtonResourcesCallJobs.TabIndex = ((int)(resources.GetObject("radioButtonResourcesCallJobs.TabIndex")));
			this.radioButtonResourcesCallJobs.Text = resources.GetString("radioButtonResourcesCallJobs.Text");
			this.radioButtonResourcesCallJobs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesCallJobs.TextAlign")));
			this.radioButtonResourcesCallJobs.Visible = ((bool)(resources.GetObject("radioButtonResourcesCallJobs.Visible")));
			this.radioButtonResourcesCallJobs.CheckedChanged += new System.EventHandler(this.radioButtonResourcesCallJobs_CheckedChanged);
			// 
			// radioButtonResourcesAgents
			// 
			this.radioButtonResourcesAgents.AccessibleDescription = resources.GetString("radioButtonResourcesAgents.AccessibleDescription");
			this.radioButtonResourcesAgents.AccessibleName = resources.GetString("radioButtonResourcesAgents.AccessibleName");
			this.radioButtonResourcesAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("radioButtonResourcesAgents.Anchor")));
			this.radioButtonResourcesAgents.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("radioButtonResourcesAgents.Appearance")));
			this.radioButtonResourcesAgents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesAgents.BackgroundImage")));
			this.radioButtonResourcesAgents.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesAgents.CheckAlign")));
			this.radioButtonResourcesAgents.Checked = true;
			this.radioButtonResourcesAgents.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("radioButtonResourcesAgents.Dock")));
			this.radioButtonResourcesAgents.Enabled = ((bool)(resources.GetObject("radioButtonResourcesAgents.Enabled")));
			this.radioButtonResourcesAgents.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("radioButtonResourcesAgents.FlatStyle")));
			this.radioButtonResourcesAgents.Font = ((System.Drawing.Font)(resources.GetObject("radioButtonResourcesAgents.Font")));
			this.radioButtonResourcesAgents.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonResourcesAgents.Image")));
			this.radioButtonResourcesAgents.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesAgents.ImageAlign")));
			this.radioButtonResourcesAgents.ImageIndex = ((int)(resources.GetObject("radioButtonResourcesAgents.ImageIndex")));
			this.radioButtonResourcesAgents.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radioButtonResourcesAgents.ImeMode")));
			this.radioButtonResourcesAgents.Location = ((System.Drawing.Point)(resources.GetObject("radioButtonResourcesAgents.Location")));
			this.radioButtonResourcesAgents.Name = "radioButtonResourcesAgents";
			this.radioButtonResourcesAgents.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("radioButtonResourcesAgents.RightToLeft")));
			this.radioButtonResourcesAgents.Size = ((System.Drawing.Size)(resources.GetObject("radioButtonResourcesAgents.Size")));
			this.radioButtonResourcesAgents.TabIndex = ((int)(resources.GetObject("radioButtonResourcesAgents.TabIndex")));
			this.radioButtonResourcesAgents.TabStop = true;
			this.radioButtonResourcesAgents.Text = resources.GetString("radioButtonResourcesAgents.Text");
			this.radioButtonResourcesAgents.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("radioButtonResourcesAgents.TextAlign")));
			this.radioButtonResourcesAgents.Visible = ((bool)(resources.GetObject("radioButtonResourcesAgents.Visible")));
			this.radioButtonResourcesAgents.CheckedChanged += new System.EventHandler(this.radioButtonResourcesAgents_CheckedChanged);
			// 
			// tabControlResources
			// 
			this.tabControlResources.AccessibleDescription = resources.GetString("tabControlResources.AccessibleDescription");
			this.tabControlResources.AccessibleName = resources.GetString("tabControlResources.AccessibleName");
			this.tabControlResources.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControlResources.Alignment")));
			this.tabControlResources.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControlResources.Anchor")));
			this.tabControlResources.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControlResources.Appearance")));
			this.tabControlResources.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControlResources.BackgroundImage")));
			this.tabControlResources.Controls.Add(this.tabPageResourcesAgents);
			this.tabControlResources.Controls.Add(this.tabPageResourcesCallJobs);
			this.tabControlResources.Controls.Add(this.tabPageResourcesIncomingCalls);
			this.tabControlResources.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControlResources.Dock")));
			this.tabControlResources.Enabled = ((bool)(resources.GetObject("tabControlResources.Enabled")));
			this.tabControlResources.Font = ((System.Drawing.Font)(resources.GetObject("tabControlResources.Font")));
			this.tabControlResources.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControlResources.ImeMode")));
			this.tabControlResources.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControlResources.ItemSize")));
			this.tabControlResources.Location = ((System.Drawing.Point)(resources.GetObject("tabControlResources.Location")));
			this.tabControlResources.Name = "tabControlResources";
			this.tabControlResources.Padding = ((System.Drawing.Point)(resources.GetObject("tabControlResources.Padding")));
			this.tabControlResources.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControlResources.RightToLeft")));
			this.tabControlResources.SelectedIndex = 0;
			this.tabControlResources.ShowToolTips = ((bool)(resources.GetObject("tabControlResources.ShowToolTips")));
			this.tabControlResources.Size = ((System.Drawing.Size)(resources.GetObject("tabControlResources.Size")));
			this.tabControlResources.TabIndex = ((int)(resources.GetObject("tabControlResources.TabIndex")));
			this.tabControlResources.TabStop = false;
			this.tabControlResources.Text = resources.GetString("tabControlResources.Text");
			this.tabControlResources.Visible = ((bool)(resources.GetObject("tabControlResources.Visible")));
			// 
			// tabPageResourcesAgents
			// 
			this.tabPageResourcesAgents.AccessibleDescription = resources.GetString("tabPageResourcesAgents.AccessibleDescription");
			this.tabPageResourcesAgents.AccessibleName = resources.GetString("tabPageResourcesAgents.AccessibleName");
			this.tabPageResourcesAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageResourcesAgents.Anchor")));
			this.tabPageResourcesAgents.AutoScroll = ((bool)(resources.GetObject("tabPageResourcesAgents.AutoScroll")));
			this.tabPageResourcesAgents.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesAgents.AutoScrollMargin")));
			this.tabPageResourcesAgents.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesAgents.AutoScrollMinSize")));
			this.tabPageResourcesAgents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageResourcesAgents.BackgroundImage")));
			this.tabPageResourcesAgents.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageResourcesAgents.Dock")));
			this.tabPageResourcesAgents.Enabled = ((bool)(resources.GetObject("tabPageResourcesAgents.Enabled")));
			this.tabPageResourcesAgents.Font = ((System.Drawing.Font)(resources.GetObject("tabPageResourcesAgents.Font")));
			this.tabPageResourcesAgents.ImageIndex = ((int)(resources.GetObject("tabPageResourcesAgents.ImageIndex")));
			this.tabPageResourcesAgents.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageResourcesAgents.ImeMode")));
			this.tabPageResourcesAgents.Location = ((System.Drawing.Point)(resources.GetObject("tabPageResourcesAgents.Location")));
			this.tabPageResourcesAgents.Name = "tabPageResourcesAgents";
			this.tabPageResourcesAgents.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageResourcesAgents.RightToLeft")));
			this.tabPageResourcesAgents.Size = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesAgents.Size")));
			this.tabPageResourcesAgents.TabIndex = ((int)(resources.GetObject("tabPageResourcesAgents.TabIndex")));
			this.tabPageResourcesAgents.Text = resources.GetString("tabPageResourcesAgents.Text");
			this.tabPageResourcesAgents.ToolTipText = resources.GetString("tabPageResourcesAgents.ToolTipText");
			this.tabPageResourcesAgents.Visible = ((bool)(resources.GetObject("tabPageResourcesAgents.Visible")));
			// 
			// tabPageResourcesCallJobs
			// 
			this.tabPageResourcesCallJobs.AccessibleDescription = resources.GetString("tabPageResourcesCallJobs.AccessibleDescription");
			this.tabPageResourcesCallJobs.AccessibleName = resources.GetString("tabPageResourcesCallJobs.AccessibleName");
			this.tabPageResourcesCallJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageResourcesCallJobs.Anchor")));
			this.tabPageResourcesCallJobs.AutoScroll = ((bool)(resources.GetObject("tabPageResourcesCallJobs.AutoScroll")));
			this.tabPageResourcesCallJobs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesCallJobs.AutoScrollMargin")));
			this.tabPageResourcesCallJobs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesCallJobs.AutoScrollMinSize")));
			this.tabPageResourcesCallJobs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageResourcesCallJobs.BackgroundImage")));
			this.tabPageResourcesCallJobs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageResourcesCallJobs.Dock")));
			this.tabPageResourcesCallJobs.Enabled = ((bool)(resources.GetObject("tabPageResourcesCallJobs.Enabled")));
			this.tabPageResourcesCallJobs.Font = ((System.Drawing.Font)(resources.GetObject("tabPageResourcesCallJobs.Font")));
			this.tabPageResourcesCallJobs.ImageIndex = ((int)(resources.GetObject("tabPageResourcesCallJobs.ImageIndex")));
			this.tabPageResourcesCallJobs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageResourcesCallJobs.ImeMode")));
			this.tabPageResourcesCallJobs.Location = ((System.Drawing.Point)(resources.GetObject("tabPageResourcesCallJobs.Location")));
			this.tabPageResourcesCallJobs.Name = "tabPageResourcesCallJobs";
			this.tabPageResourcesCallJobs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageResourcesCallJobs.RightToLeft")));
			this.tabPageResourcesCallJobs.Size = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesCallJobs.Size")));
			this.tabPageResourcesCallJobs.TabIndex = ((int)(resources.GetObject("tabPageResourcesCallJobs.TabIndex")));
			this.tabPageResourcesCallJobs.Text = resources.GetString("tabPageResourcesCallJobs.Text");
			this.tabPageResourcesCallJobs.ToolTipText = resources.GetString("tabPageResourcesCallJobs.ToolTipText");
			this.tabPageResourcesCallJobs.Visible = ((bool)(resources.GetObject("tabPageResourcesCallJobs.Visible")));
			// 
			// tabPageResourcesIncomingCalls
			// 
			this.tabPageResourcesIncomingCalls.AccessibleDescription = resources.GetString("tabPageResourcesIncomingCalls.AccessibleDescription");
			this.tabPageResourcesIncomingCalls.AccessibleName = resources.GetString("tabPageResourcesIncomingCalls.AccessibleName");
			this.tabPageResourcesIncomingCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPageResourcesIncomingCalls.Anchor")));
			this.tabPageResourcesIncomingCalls.AutoScroll = ((bool)(resources.GetObject("tabPageResourcesIncomingCalls.AutoScroll")));
			this.tabPageResourcesIncomingCalls.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesIncomingCalls.AutoScrollMargin")));
			this.tabPageResourcesIncomingCalls.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesIncomingCalls.AutoScrollMinSize")));
			this.tabPageResourcesIncomingCalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageResourcesIncomingCalls.BackgroundImage")));
			this.tabPageResourcesIncomingCalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPageResourcesIncomingCalls.Dock")));
			this.tabPageResourcesIncomingCalls.Enabled = ((bool)(resources.GetObject("tabPageResourcesIncomingCalls.Enabled")));
			this.tabPageResourcesIncomingCalls.Font = ((System.Drawing.Font)(resources.GetObject("tabPageResourcesIncomingCalls.Font")));
			this.tabPageResourcesIncomingCalls.ImageIndex = ((int)(resources.GetObject("tabPageResourcesIncomingCalls.ImageIndex")));
			this.tabPageResourcesIncomingCalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPageResourcesIncomingCalls.ImeMode")));
			this.tabPageResourcesIncomingCalls.Location = ((System.Drawing.Point)(resources.GetObject("tabPageResourcesIncomingCalls.Location")));
			this.tabPageResourcesIncomingCalls.Name = "tabPageResourcesIncomingCalls";
			this.tabPageResourcesIncomingCalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPageResourcesIncomingCalls.RightToLeft")));
			this.tabPageResourcesIncomingCalls.Size = ((System.Drawing.Size)(resources.GetObject("tabPageResourcesIncomingCalls.Size")));
			this.tabPageResourcesIncomingCalls.TabIndex = ((int)(resources.GetObject("tabPageResourcesIncomingCalls.TabIndex")));
			this.tabPageResourcesIncomingCalls.Text = resources.GetString("tabPageResourcesIncomingCalls.Text");
			this.tabPageResourcesIncomingCalls.ToolTipText = resources.GetString("tabPageResourcesIncomingCalls.ToolTipText");
			this.tabPageResourcesIncomingCalls.Visible = ((bool)(resources.GetObject("tabPageResourcesIncomingCalls.Visible")));
			// 
			// CampaignView
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.tabControlCampaign);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignView";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.tabControlCampaign.ResumeLayout(false);
			this.tabPageCampaignOverview.ResumeLayout(false);
			this.panelOverview.ResumeLayout(false);
			this.tabControlOverview.ResumeLayout(false);
			this.tabPageCampaignStatisticsCallJobs.ResumeLayout(false);
			this.panelStatisticsCallJobs.ResumeLayout(false);
			this.tabControlStatisticsCallJobs.ResumeLayout(false);
			this.tabPageCampaignStatisticsIncomingCalls.ResumeLayout(false);
			this.panelStatisticsIncomingCalls.ResumeLayout(false);
			this.tabControlStatisticsIncomingCalls.ResumeLayout(false);
			this.tabPageCampaignResources.ResumeLayout(false);
			this.panelResources.ResumeLayout(false);
			this.tabControlResources.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Steuerelemente --------------------

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonOverviewProperties_CheckedChanged(object sender, System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonOverviewProperties.Checked)
			{
				SelectTabPage(tabControlOverview, tabPageOverviewProperties);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonOverviewParameters_CheckedChanged(object sender,
			System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonOverviewParameters.Checked)
			{
				SelectTabPage(tabControlOverview, tabPageOverviewParameters);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonStatisticsCallJobsRecentStatistics_CheckedChanged(object sender,
			System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonStatisticsCallJobsRecentStatistics.Checked)
			{
				SelectTabPage(tabControlStatisticsCallJobs,
					tabPageStatisticsCallJobsRecentStatistics);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonStatisticsCallJobsTotalStatistics_CheckedChanged(object sender,
			System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonStatisticsCallJobsTotalStatistics.Checked)
			{
				SelectTabPage(tabControlStatisticsCallJobs,
					tabPageStatisticsCallJobsTotalStatistics);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonStatisticsIncomingCallsRecentStatistics_CheckedChanged(
			object sender, System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonStatisticsIncomingCallsRecentStatistics.Checked)
			{
				SelectTabPage(tabControlStatisticsIncomingCalls,
					tabPageStatisticsIncomingCallsRecentStatistics);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonStatisticsIncomingCallsTotalStatistics_CheckedChanged(
			object sender, System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonStatisticsIncomingCallsTotalStatistics.Checked)
			{
				SelectTabPage(tabControlStatisticsIncomingCalls,
					tabPageStatisticsIncomingCallsTotalStatistics);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonResourcesAgents_CheckedChanged(object sender, System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonResourcesAgents.Checked)
			{
				SelectTabPage(tabControlResources, tabPageResourcesAgents);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonResourcesCallJobs_CheckedChanged(object sender, System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonResourcesCallJobs.Checked)
			{
				SelectTabPage(tabControlResources, tabPageResourcesCallJobs);
			}
		}

		/// <summary>
		/// zeigt ausgewählte Seite an
		/// </summary>
		private void radioButtonResourcesIncomingCalls_CheckedChanged(object sender,
			System.EventArgs e)
		{
			// wenn Seite ausgewählt, anzeigen
			if (radioButtonResourcesIncomingCalls.Checked)
			{
				SelectTabPage(tabControlResources, tabPageResourcesIncomingCalls);
			}
		}

		/// <summary>
		/// zeigt angegebene Registerkarte eines untergeordneten TabControls an
		/// </summary>
		private void SelectTabPage(TabControl tabControl, TabPage tabPage)
		{
			// angegebene Registerkarte anzeigen
			tabControl.SelectedTab = tabPage;

			// Scrollbar zurücksetzen
			tabControl.Parent.Parent.Focus();
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// Kampagnenteilansichten aktualisieren
			_campaignViewProperties.RefreshParameters(campaign);
			_campaignViewParameters.RefreshParameters(campaign);
			_campaignViewCallJobsRecentStatistics.RefreshParameters(campaign);
			_campaignViewCallJobsTotalStatistics.RefreshParameters(campaign);
			_campaignViewIncomingCallsRecentStatistics.RefreshParameters(campaign);
			_campaignViewIncomingCallsTotalStatistics.RefreshParameters(campaign);
			_campaignViewAgents.RefreshParameters(campaign);
			_campaignViewCallJobs.RefreshParameters(campaign);
			_campaignViewIncomingCalls.RefreshParameters(campaign);
		}

		#endregion

		#endregion
	}
}
