using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Calljobs einer Kampagne.
	/// </summary>
	public class CampaignViewCallJobs : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxCallJobStates;
		private System.Windows.Forms.Label labelCallJobStatesRowState;
		private System.Windows.Forms.Label labelCallJobStatesRowCount;
		private System.Windows.Forms.Label labelCallJobStatesTopLineWhite;
		private System.Windows.Forms.Label labelCallJobStatesTopLineGray;
		private System.Windows.Forms.Label labelCallJobStateCountReadyCap;
		private System.Windows.Forms.Label labelCallJobStateCountReady;
		private System.Windows.Forms.Label labelCallJobStateCountPreparingCap;
		private System.Windows.Forms.Label labelCallJobStateCountPreparing;
		private System.Windows.Forms.Label labelCallJobStateCountDialingCap;
		private System.Windows.Forms.Label labelCallJobStateCountDialing;
		private System.Windows.Forms.Label labelCallJobStateCountAlertingCap;
		private System.Windows.Forms.Label labelCallJobStateCountAlerting;
		private System.Windows.Forms.Label labelCallJobStateCountCPACap;
		private System.Windows.Forms.Label labelCallJobStateCountCPA;
		private System.Windows.Forms.Label labelCallJobStateCountGreetingCap;
		private System.Windows.Forms.Label labelCallJobStateCountGreeting;
		private System.Windows.Forms.Label labelCallJobStateCountWaitingCap;
		private System.Windows.Forms.Label labelCallJobStateCountWaiting;
		private System.Windows.Forms.Label labelCallJobStateCountSignalingCap;
		private System.Windows.Forms.Label labelCallJobStateCountSignaling;
		private System.Windows.Forms.Label labelCallJobStatesBottomLineWhite;
		private System.Windows.Forms.Label labelCallJobStatesBottomLineGray;
		private System.Windows.Forms.Label labelCallJobStateCountCap;
		private System.Windows.Forms.Label labelCallJobStateCount;
		private System.Windows.Forms.GroupBox groupBoxChartCallJobStateCount;
		private System.Windows.Forms.Panel panelChartCallJobStateCount;
		private itCampus.bb.Graph.Chart.Chart chartCallJobStateCount;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewCallJobs()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewCallJobs));
			itCampus.bb.Graph.Chart.Curve curve1 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve2 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve3 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve4 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve5 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve6 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve7 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve8 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve9 = new itCampus.bb.Graph.Chart.Curve();
			this.groupBoxChartCallJobStateCount = new System.Windows.Forms.GroupBox();
			this.panelChartCallJobStateCount = new System.Windows.Forms.Panel();
			this.chartCallJobStateCount = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxCallJobStates = new System.Windows.Forms.GroupBox();
			this.labelCallJobStateCount = new System.Windows.Forms.Label();
			this.labelCallJobStateCountCap = new System.Windows.Forms.Label();
			this.labelCallJobStatesBottomLineGray = new System.Windows.Forms.Label();
			this.labelCallJobStatesBottomLineWhite = new System.Windows.Forms.Label();
			this.labelCallJobStateCountSignaling = new System.Windows.Forms.Label();
			this.labelCallJobStateCountSignalingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountWaiting = new System.Windows.Forms.Label();
			this.labelCallJobStateCountWaitingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountGreeting = new System.Windows.Forms.Label();
			this.labelCallJobStateCountGreetingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountCPA = new System.Windows.Forms.Label();
			this.labelCallJobStateCountCPACap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountAlerting = new System.Windows.Forms.Label();
			this.labelCallJobStateCountAlertingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountDialing = new System.Windows.Forms.Label();
			this.labelCallJobStateCountDialingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountPreparing = new System.Windows.Forms.Label();
			this.labelCallJobStateCountPreparingCap = new System.Windows.Forms.Label();
			this.labelCallJobStateCountReady = new System.Windows.Forms.Label();
			this.labelCallJobStateCountReadyCap = new System.Windows.Forms.Label();
			this.labelCallJobStatesTopLineGray = new System.Windows.Forms.Label();
			this.labelCallJobStatesTopLineWhite = new System.Windows.Forms.Label();
			this.labelCallJobStatesRowCount = new System.Windows.Forms.Label();
			this.labelCallJobStatesRowState = new System.Windows.Forms.Label();
			this.groupBoxChartCallJobStateCount.SuspendLayout();
			this.panelChartCallJobStateCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartCallJobStateCount)).BeginInit();
			this.groupBoxCallJobStates.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartCallJobStateCount
			// 
			this.groupBoxChartCallJobStateCount.AccessibleDescription = resources.GetString("groupBoxChartCallJobStateCount.AccessibleDescription");
			this.groupBoxChartCallJobStateCount.AccessibleName = resources.GetString("groupBoxChartCallJobStateCount.AccessibleName");
			this.groupBoxChartCallJobStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartCallJobStateCount.Anchor")));
			this.groupBoxChartCallJobStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartCallJobStateCount.BackgroundImage")));
			this.groupBoxChartCallJobStateCount.Controls.Add(this.panelChartCallJobStateCount);
			this.groupBoxChartCallJobStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartCallJobStateCount.Dock")));
			this.groupBoxChartCallJobStateCount.Enabled = ((bool)(resources.GetObject("groupBoxChartCallJobStateCount.Enabled")));
			this.groupBoxChartCallJobStateCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartCallJobStateCount.Font")));
			this.groupBoxChartCallJobStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartCallJobStateCount.ImeMode")));
			this.groupBoxChartCallJobStateCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartCallJobStateCount.Location")));
			this.groupBoxChartCallJobStateCount.Name = "groupBoxChartCallJobStateCount";
			this.groupBoxChartCallJobStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartCallJobStateCount.RightToLeft")));
			this.groupBoxChartCallJobStateCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartCallJobStateCount.Size")));
			this.groupBoxChartCallJobStateCount.TabIndex = ((int)(resources.GetObject("groupBoxChartCallJobStateCount.TabIndex")));
			this.groupBoxChartCallJobStateCount.TabStop = false;
			this.groupBoxChartCallJobStateCount.Text = resources.GetString("groupBoxChartCallJobStateCount.Text");
			this.groupBoxChartCallJobStateCount.Visible = ((bool)(resources.GetObject("groupBoxChartCallJobStateCount.Visible")));
			// 
			// panelChartCallJobStateCount
			// 
			this.panelChartCallJobStateCount.AccessibleDescription = resources.GetString("panelChartCallJobStateCount.AccessibleDescription");
			this.panelChartCallJobStateCount.AccessibleName = resources.GetString("panelChartCallJobStateCount.AccessibleName");
			this.panelChartCallJobStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartCallJobStateCount.Anchor")));
			this.panelChartCallJobStateCount.AutoScroll = ((bool)(resources.GetObject("panelChartCallJobStateCount.AutoScroll")));
			this.panelChartCallJobStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartCallJobStateCount.AutoScrollMargin")));
			this.panelChartCallJobStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartCallJobStateCount.AutoScrollMinSize")));
			this.panelChartCallJobStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartCallJobStateCount.BackgroundImage")));
			this.panelChartCallJobStateCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartCallJobStateCount.Controls.Add(this.chartCallJobStateCount);
			this.panelChartCallJobStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartCallJobStateCount.Dock")));
			this.panelChartCallJobStateCount.Enabled = ((bool)(resources.GetObject("panelChartCallJobStateCount.Enabled")));
			this.panelChartCallJobStateCount.Font = ((System.Drawing.Font)(resources.GetObject("panelChartCallJobStateCount.Font")));
			this.panelChartCallJobStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartCallJobStateCount.ImeMode")));
			this.panelChartCallJobStateCount.Location = ((System.Drawing.Point)(resources.GetObject("panelChartCallJobStateCount.Location")));
			this.panelChartCallJobStateCount.Name = "panelChartCallJobStateCount";
			this.panelChartCallJobStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartCallJobStateCount.RightToLeft")));
			this.panelChartCallJobStateCount.Size = ((System.Drawing.Size)(resources.GetObject("panelChartCallJobStateCount.Size")));
			this.panelChartCallJobStateCount.TabIndex = ((int)(resources.GetObject("panelChartCallJobStateCount.TabIndex")));
			this.panelChartCallJobStateCount.Text = resources.GetString("panelChartCallJobStateCount.Text");
			this.panelChartCallJobStateCount.Visible = ((bool)(resources.GetObject("panelChartCallJobStateCount.Visible")));
			// 
			// chartCallJobStateCount
			// 
			this.chartCallJobStateCount.AccessibleDescription = resources.GetString("chartCallJobStateCount.AccessibleDescription");
			this.chartCallJobStateCount.AccessibleName = resources.GetString("chartCallJobStateCount.AccessibleName");
			this.chartCallJobStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartCallJobStateCount.Anchor")));
			this.chartCallJobStateCount.AutoScroll = ((bool)(resources.GetObject("chartCallJobStateCount.AutoScroll")));
			this.chartCallJobStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartCallJobStateCount.AutoScrollMargin")));
			this.chartCallJobStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartCallJobStateCount.AutoScrollMinSize")));
			this.chartCallJobStateCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.BackgroundColor")));
			this.chartCallJobStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartCallJobStateCount.BackgroundImage")));
			curve1.Caption = resources.GetString("curve1.Caption");
			curve1.Color = ((System.Drawing.Color)(resources.GetObject("curve1.Color")));
			curve1.ContinuesLine = ((bool)(resources.GetObject("curve1.ContinuesLine")));
			curve1.MappingName = resources.GetString("curve1.MappingName");
			curve1.Visible = ((bool)(resources.GetObject("curve1.Visible")));
			curve2.Caption = resources.GetString("curve2.Caption");
			curve2.Color = ((System.Drawing.Color)(resources.GetObject("curve2.Color")));
			curve2.ContinuesLine = ((bool)(resources.GetObject("curve2.ContinuesLine")));
			curve2.MappingName = resources.GetString("curve2.MappingName");
			curve2.Visible = ((bool)(resources.GetObject("curve2.Visible")));
			curve3.Caption = resources.GetString("curve3.Caption");
			curve3.Color = ((System.Drawing.Color)(resources.GetObject("curve3.Color")));
			curve3.ContinuesLine = ((bool)(resources.GetObject("curve3.ContinuesLine")));
			curve3.MappingName = resources.GetString("curve3.MappingName");
			curve3.Visible = ((bool)(resources.GetObject("curve3.Visible")));
			curve4.Caption = resources.GetString("curve4.Caption");
			curve4.Color = ((System.Drawing.Color)(resources.GetObject("curve4.Color")));
			curve4.ContinuesLine = ((bool)(resources.GetObject("curve4.ContinuesLine")));
			curve4.MappingName = resources.GetString("curve4.MappingName");
			curve4.Visible = ((bool)(resources.GetObject("curve4.Visible")));
			curve5.Caption = resources.GetString("curve5.Caption");
			curve5.Color = ((System.Drawing.Color)(resources.GetObject("curve5.Color")));
			curve5.ContinuesLine = ((bool)(resources.GetObject("curve5.ContinuesLine")));
			curve5.MappingName = resources.GetString("curve5.MappingName");
			curve5.Visible = ((bool)(resources.GetObject("curve5.Visible")));
			curve6.Caption = resources.GetString("curve6.Caption");
			curve6.Color = ((System.Drawing.Color)(resources.GetObject("curve6.Color")));
			curve6.ContinuesLine = ((bool)(resources.GetObject("curve6.ContinuesLine")));
			curve6.MappingName = resources.GetString("curve6.MappingName");
			curve6.Visible = ((bool)(resources.GetObject("curve6.Visible")));
			curve7.Caption = resources.GetString("curve7.Caption");
			curve7.Color = ((System.Drawing.Color)(resources.GetObject("curve7.Color")));
			curve7.ContinuesLine = ((bool)(resources.GetObject("curve7.ContinuesLine")));
			curve7.MappingName = resources.GetString("curve7.MappingName");
			curve7.Visible = ((bool)(resources.GetObject("curve7.Visible")));
			curve8.Caption = resources.GetString("curve8.Caption");
			curve8.Color = ((System.Drawing.Color)(resources.GetObject("curve8.Color")));
			curve8.ContinuesLine = ((bool)(resources.GetObject("curve8.ContinuesLine")));
			curve8.MappingName = resources.GetString("curve8.MappingName");
			curve8.Visible = ((bool)(resources.GetObject("curve8.Visible")));
			curve9.Caption = resources.GetString("curve9.Caption");
			curve9.Color = ((System.Drawing.Color)(resources.GetObject("curve9.Color")));
			curve9.ContinuesLine = ((bool)(resources.GetObject("curve9.ContinuesLine")));
			curve9.MappingName = resources.GetString("curve9.MappingName");
			curve9.Visible = ((bool)(resources.GetObject("curve9.Visible")));
			this.chartCallJobStateCount.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																								curve1,
																								curve2,
																								curve3,
																								curve4,
																								curve5,
																								curve6,
																								curve7,
																								curve8,
																								curve9});
			this.chartCallJobStateCount.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartCallJobStateCount.DisplayedInterval")));
			this.chartCallJobStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartCallJobStateCount.Dock")));
			this.chartCallJobStateCount.Enabled = ((bool)(resources.GetObject("chartCallJobStateCount.Enabled")));
			this.chartCallJobStateCount.Font = ((System.Drawing.Font)(resources.GetObject("chartCallJobStateCount.Font")));
			this.chartCallJobStateCount.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.FrameColor")));
			this.chartCallJobStateCount.GridColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.GridColor")));
			this.chartCallJobStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartCallJobStateCount.ImeMode")));
			this.chartCallJobStateCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartCallJobStateCount.LegendAlignment")));
			this.chartCallJobStateCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.LegendColor")));
			this.chartCallJobStateCount.Location = ((System.Drawing.Point)(resources.GetObject("chartCallJobStateCount.Location")));
			this.chartCallJobStateCount.Name = "chartCallJobStateCount";
			this.chartCallJobStateCount.Painting = ((bool)(resources.GetObject("chartCallJobStateCount.Painting")));
			this.chartCallJobStateCount.RescaleRatio = ((System.Double)(resources.GetObject("chartCallJobStateCount.RescaleRatio")));
			this.chartCallJobStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartCallJobStateCount.RightToLeft")));
			this.chartCallJobStateCount.Size = ((System.Drawing.Size)(resources.GetObject("chartCallJobStateCount.Size")));
			this.chartCallJobStateCount.TabIndex = ((int)(resources.GetObject("chartCallJobStateCount.TabIndex")));
			this.chartCallJobStateCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.ValueColor")));
			this.chartCallJobStateCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartCallJobStateCount.ValueType")));
			this.chartCallJobStateCount.Visible = ((bool)(resources.GetObject("chartCallJobStateCount.Visible")));
			this.chartCallJobStateCount.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.XLabelColor")));
			this.chartCallJobStateCount.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartCallJobStateCount.YLabelColor")));
			this.chartCallJobStateCount.YMax = ((System.Double)(resources.GetObject("chartCallJobStateCount.YMax")));
			this.chartCallJobStateCount.YMaxScaling = ((bool)(resources.GetObject("chartCallJobStateCount.YMaxScaling")));
			this.chartCallJobStateCount.YMin = ((System.Double)(resources.GetObject("chartCallJobStateCount.YMin")));
			this.chartCallJobStateCount.YMinScaling = ((bool)(resources.GetObject("chartCallJobStateCount.YMinScaling")));
			// 
			// groupBoxCallJobStates
			// 
			this.groupBoxCallJobStates.AccessibleDescription = resources.GetString("groupBoxCallJobStates.AccessibleDescription");
			this.groupBoxCallJobStates.AccessibleName = resources.GetString("groupBoxCallJobStates.AccessibleName");
			this.groupBoxCallJobStates.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxCallJobStates.Anchor")));
			this.groupBoxCallJobStates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxCallJobStates.BackgroundImage")));
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCount);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesBottomLineGray);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesBottomLineWhite);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountSignaling);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountSignalingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountWaiting);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountWaitingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountGreeting);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountGreetingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountCPA);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountCPACap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountAlerting);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountAlertingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountDialing);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountDialingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountPreparing);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountPreparingCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountReady);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStateCountReadyCap);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesTopLineGray);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesTopLineWhite);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesRowCount);
			this.groupBoxCallJobStates.Controls.Add(this.labelCallJobStatesRowState);
			this.groupBoxCallJobStates.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxCallJobStates.Dock")));
			this.groupBoxCallJobStates.Enabled = ((bool)(resources.GetObject("groupBoxCallJobStates.Enabled")));
			this.groupBoxCallJobStates.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxCallJobStates.Font")));
			this.groupBoxCallJobStates.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxCallJobStates.ImeMode")));
			this.groupBoxCallJobStates.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxCallJobStates.Location")));
			this.groupBoxCallJobStates.Name = "groupBoxCallJobStates";
			this.groupBoxCallJobStates.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxCallJobStates.RightToLeft")));
			this.groupBoxCallJobStates.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxCallJobStates.Size")));
			this.groupBoxCallJobStates.TabIndex = ((int)(resources.GetObject("groupBoxCallJobStates.TabIndex")));
			this.groupBoxCallJobStates.TabStop = false;
			this.groupBoxCallJobStates.Text = resources.GetString("groupBoxCallJobStates.Text");
			this.groupBoxCallJobStates.Visible = ((bool)(resources.GetObject("groupBoxCallJobStates.Visible")));
			// 
			// labelCallJobStateCount
			// 
			this.labelCallJobStateCount.AccessibleDescription = resources.GetString("labelCallJobStateCount.AccessibleDescription");
			this.labelCallJobStateCount.AccessibleName = resources.GetString("labelCallJobStateCount.AccessibleName");
			this.labelCallJobStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCount.Anchor")));
			this.labelCallJobStateCount.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCount.AutoSize")));
			this.labelCallJobStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCount.Dock")));
			this.labelCallJobStateCount.Enabled = ((bool)(resources.GetObject("labelCallJobStateCount.Enabled")));
			this.labelCallJobStateCount.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCount.Font")));
			this.labelCallJobStateCount.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCount.Image")));
			this.labelCallJobStateCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCount.ImageAlign")));
			this.labelCallJobStateCount.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCount.ImageIndex")));
			this.labelCallJobStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCount.ImeMode")));
			this.labelCallJobStateCount.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCount.Location")));
			this.labelCallJobStateCount.Name = "labelCallJobStateCount";
			this.labelCallJobStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCount.RightToLeft")));
			this.labelCallJobStateCount.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCount.Size")));
			this.labelCallJobStateCount.TabIndex = ((int)(resources.GetObject("labelCallJobStateCount.TabIndex")));
			this.labelCallJobStateCount.Text = resources.GetString("labelCallJobStateCount.Text");
			this.labelCallJobStateCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCount.TextAlign")));
			this.labelCallJobStateCount.Visible = ((bool)(resources.GetObject("labelCallJobStateCount.Visible")));
			// 
			// labelCallJobStateCountCap
			// 
			this.labelCallJobStateCountCap.AccessibleDescription = resources.GetString("labelCallJobStateCountCap.AccessibleDescription");
			this.labelCallJobStateCountCap.AccessibleName = resources.GetString("labelCallJobStateCountCap.AccessibleName");
			this.labelCallJobStateCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountCap.Anchor")));
			this.labelCallJobStateCountCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountCap.AutoSize")));
			this.labelCallJobStateCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountCap.Dock")));
			this.labelCallJobStateCountCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountCap.Enabled")));
			this.labelCallJobStateCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountCap.Font")));
			this.labelCallJobStateCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountCap.Image")));
			this.labelCallJobStateCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCap.ImageAlign")));
			this.labelCallJobStateCountCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountCap.ImageIndex")));
			this.labelCallJobStateCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountCap.ImeMode")));
			this.labelCallJobStateCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountCap.Location")));
			this.labelCallJobStateCountCap.Name = "labelCallJobStateCountCap";
			this.labelCallJobStateCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountCap.RightToLeft")));
			this.labelCallJobStateCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountCap.Size")));
			this.labelCallJobStateCountCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountCap.TabIndex")));
			this.labelCallJobStateCountCap.Text = resources.GetString("labelCallJobStateCountCap.Text");
			this.labelCallJobStateCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCap.TextAlign")));
			this.labelCallJobStateCountCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountCap.Visible")));
			// 
			// labelCallJobStatesBottomLineGray
			// 
			this.labelCallJobStatesBottomLineGray.AccessibleDescription = resources.GetString("labelCallJobStatesBottomLineGray.AccessibleDescription");
			this.labelCallJobStatesBottomLineGray.AccessibleName = resources.GetString("labelCallJobStatesBottomLineGray.AccessibleName");
			this.labelCallJobStatesBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesBottomLineGray.Anchor")));
			this.labelCallJobStatesBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesBottomLineGray.AutoSize")));
			this.labelCallJobStatesBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelCallJobStatesBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesBottomLineGray.Dock")));
			this.labelCallJobStatesBottomLineGray.Enabled = ((bool)(resources.GetObject("labelCallJobStatesBottomLineGray.Enabled")));
			this.labelCallJobStatesBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesBottomLineGray.Font")));
			this.labelCallJobStatesBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCallJobStatesBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesBottomLineGray.Image")));
			this.labelCallJobStatesBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesBottomLineGray.ImageAlign")));
			this.labelCallJobStatesBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesBottomLineGray.ImageIndex")));
			this.labelCallJobStatesBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesBottomLineGray.ImeMode")));
			this.labelCallJobStatesBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesBottomLineGray.Location")));
			this.labelCallJobStatesBottomLineGray.Name = "labelCallJobStatesBottomLineGray";
			this.labelCallJobStatesBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesBottomLineGray.RightToLeft")));
			this.labelCallJobStatesBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesBottomLineGray.Size")));
			this.labelCallJobStatesBottomLineGray.TabIndex = ((int)(resources.GetObject("labelCallJobStatesBottomLineGray.TabIndex")));
			this.labelCallJobStatesBottomLineGray.Text = resources.GetString("labelCallJobStatesBottomLineGray.Text");
			this.labelCallJobStatesBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesBottomLineGray.TextAlign")));
			this.labelCallJobStatesBottomLineGray.Visible = ((bool)(resources.GetObject("labelCallJobStatesBottomLineGray.Visible")));
			// 
			// labelCallJobStatesBottomLineWhite
			// 
			this.labelCallJobStatesBottomLineWhite.AccessibleDescription = resources.GetString("labelCallJobStatesBottomLineWhite.AccessibleDescription");
			this.labelCallJobStatesBottomLineWhite.AccessibleName = resources.GetString("labelCallJobStatesBottomLineWhite.AccessibleName");
			this.labelCallJobStatesBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesBottomLineWhite.Anchor")));
			this.labelCallJobStatesBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesBottomLineWhite.AutoSize")));
			this.labelCallJobStatesBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelCallJobStatesBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesBottomLineWhite.Dock")));
			this.labelCallJobStatesBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelCallJobStatesBottomLineWhite.Enabled")));
			this.labelCallJobStatesBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesBottomLineWhite.Font")));
			this.labelCallJobStatesBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCallJobStatesBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesBottomLineWhite.Image")));
			this.labelCallJobStatesBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesBottomLineWhite.ImageAlign")));
			this.labelCallJobStatesBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesBottomLineWhite.ImageIndex")));
			this.labelCallJobStatesBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesBottomLineWhite.ImeMode")));
			this.labelCallJobStatesBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesBottomLineWhite.Location")));
			this.labelCallJobStatesBottomLineWhite.Name = "labelCallJobStatesBottomLineWhite";
			this.labelCallJobStatesBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesBottomLineWhite.RightToLeft")));
			this.labelCallJobStatesBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesBottomLineWhite.Size")));
			this.labelCallJobStatesBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelCallJobStatesBottomLineWhite.TabIndex")));
			this.labelCallJobStatesBottomLineWhite.Text = resources.GetString("labelCallJobStatesBottomLineWhite.Text");
			this.labelCallJobStatesBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesBottomLineWhite.TextAlign")));
			this.labelCallJobStatesBottomLineWhite.Visible = ((bool)(resources.GetObject("labelCallJobStatesBottomLineWhite.Visible")));
			// 
			// labelCallJobStateCountSignaling
			// 
			this.labelCallJobStateCountSignaling.AccessibleDescription = resources.GetString("labelCallJobStateCountSignaling.AccessibleDescription");
			this.labelCallJobStateCountSignaling.AccessibleName = resources.GetString("labelCallJobStateCountSignaling.AccessibleName");
			this.labelCallJobStateCountSignaling.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountSignaling.Anchor")));
			this.labelCallJobStateCountSignaling.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountSignaling.AutoSize")));
			this.labelCallJobStateCountSignaling.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountSignaling.Dock")));
			this.labelCallJobStateCountSignaling.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountSignaling.Enabled")));
			this.labelCallJobStateCountSignaling.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountSignaling.Font")));
			this.labelCallJobStateCountSignaling.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountSignaling.Image")));
			this.labelCallJobStateCountSignaling.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountSignaling.ImageAlign")));
			this.labelCallJobStateCountSignaling.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountSignaling.ImageIndex")));
			this.labelCallJobStateCountSignaling.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountSignaling.ImeMode")));
			this.labelCallJobStateCountSignaling.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountSignaling.Location")));
			this.labelCallJobStateCountSignaling.Name = "labelCallJobStateCountSignaling";
			this.labelCallJobStateCountSignaling.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountSignaling.RightToLeft")));
			this.labelCallJobStateCountSignaling.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountSignaling.Size")));
			this.labelCallJobStateCountSignaling.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountSignaling.TabIndex")));
			this.labelCallJobStateCountSignaling.Text = resources.GetString("labelCallJobStateCountSignaling.Text");
			this.labelCallJobStateCountSignaling.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountSignaling.TextAlign")));
			this.labelCallJobStateCountSignaling.Visible = ((bool)(resources.GetObject("labelCallJobStateCountSignaling.Visible")));
			// 
			// labelCallJobStateCountSignalingCap
			// 
			this.labelCallJobStateCountSignalingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountSignalingCap.AccessibleDescription");
			this.labelCallJobStateCountSignalingCap.AccessibleName = resources.GetString("labelCallJobStateCountSignalingCap.AccessibleName");
			this.labelCallJobStateCountSignalingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountSignalingCap.Anchor")));
			this.labelCallJobStateCountSignalingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountSignalingCap.AutoSize")));
			this.labelCallJobStateCountSignalingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountSignalingCap.Dock")));
			this.labelCallJobStateCountSignalingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountSignalingCap.Enabled")));
			this.labelCallJobStateCountSignalingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountSignalingCap.Font")));
			this.labelCallJobStateCountSignalingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountSignalingCap.Image")));
			this.labelCallJobStateCountSignalingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountSignalingCap.ImageAlign")));
			this.labelCallJobStateCountSignalingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountSignalingCap.ImageIndex")));
			this.labelCallJobStateCountSignalingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountSignalingCap.ImeMode")));
			this.labelCallJobStateCountSignalingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountSignalingCap.Location")));
			this.labelCallJobStateCountSignalingCap.Name = "labelCallJobStateCountSignalingCap";
			this.labelCallJobStateCountSignalingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountSignalingCap.RightToLeft")));
			this.labelCallJobStateCountSignalingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountSignalingCap.Size")));
			this.labelCallJobStateCountSignalingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountSignalingCap.TabIndex")));
			this.labelCallJobStateCountSignalingCap.Text = resources.GetString("labelCallJobStateCountSignalingCap.Text");
			this.labelCallJobStateCountSignalingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountSignalingCap.TextAlign")));
			this.labelCallJobStateCountSignalingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountSignalingCap.Visible")));
			// 
			// labelCallJobStateCountWaiting
			// 
			this.labelCallJobStateCountWaiting.AccessibleDescription = resources.GetString("labelCallJobStateCountWaiting.AccessibleDescription");
			this.labelCallJobStateCountWaiting.AccessibleName = resources.GetString("labelCallJobStateCountWaiting.AccessibleName");
			this.labelCallJobStateCountWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountWaiting.Anchor")));
			this.labelCallJobStateCountWaiting.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountWaiting.AutoSize")));
			this.labelCallJobStateCountWaiting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountWaiting.Dock")));
			this.labelCallJobStateCountWaiting.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountWaiting.Enabled")));
			this.labelCallJobStateCountWaiting.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountWaiting.Font")));
			this.labelCallJobStateCountWaiting.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountWaiting.Image")));
			this.labelCallJobStateCountWaiting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountWaiting.ImageAlign")));
			this.labelCallJobStateCountWaiting.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountWaiting.ImageIndex")));
			this.labelCallJobStateCountWaiting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountWaiting.ImeMode")));
			this.labelCallJobStateCountWaiting.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountWaiting.Location")));
			this.labelCallJobStateCountWaiting.Name = "labelCallJobStateCountWaiting";
			this.labelCallJobStateCountWaiting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountWaiting.RightToLeft")));
			this.labelCallJobStateCountWaiting.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountWaiting.Size")));
			this.labelCallJobStateCountWaiting.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountWaiting.TabIndex")));
			this.labelCallJobStateCountWaiting.Text = resources.GetString("labelCallJobStateCountWaiting.Text");
			this.labelCallJobStateCountWaiting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountWaiting.TextAlign")));
			this.labelCallJobStateCountWaiting.Visible = ((bool)(resources.GetObject("labelCallJobStateCountWaiting.Visible")));
			// 
			// labelCallJobStateCountWaitingCap
			// 
			this.labelCallJobStateCountWaitingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountWaitingCap.AccessibleDescription");
			this.labelCallJobStateCountWaitingCap.AccessibleName = resources.GetString("labelCallJobStateCountWaitingCap.AccessibleName");
			this.labelCallJobStateCountWaitingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountWaitingCap.Anchor")));
			this.labelCallJobStateCountWaitingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountWaitingCap.AutoSize")));
			this.labelCallJobStateCountWaitingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountWaitingCap.Dock")));
			this.labelCallJobStateCountWaitingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountWaitingCap.Enabled")));
			this.labelCallJobStateCountWaitingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountWaitingCap.Font")));
			this.labelCallJobStateCountWaitingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountWaitingCap.Image")));
			this.labelCallJobStateCountWaitingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountWaitingCap.ImageAlign")));
			this.labelCallJobStateCountWaitingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountWaitingCap.ImageIndex")));
			this.labelCallJobStateCountWaitingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountWaitingCap.ImeMode")));
			this.labelCallJobStateCountWaitingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountWaitingCap.Location")));
			this.labelCallJobStateCountWaitingCap.Name = "labelCallJobStateCountWaitingCap";
			this.labelCallJobStateCountWaitingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountWaitingCap.RightToLeft")));
			this.labelCallJobStateCountWaitingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountWaitingCap.Size")));
			this.labelCallJobStateCountWaitingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountWaitingCap.TabIndex")));
			this.labelCallJobStateCountWaitingCap.Text = resources.GetString("labelCallJobStateCountWaitingCap.Text");
			this.labelCallJobStateCountWaitingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountWaitingCap.TextAlign")));
			this.labelCallJobStateCountWaitingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountWaitingCap.Visible")));
			// 
			// labelCallJobStateCountGreeting
			// 
			this.labelCallJobStateCountGreeting.AccessibleDescription = resources.GetString("labelCallJobStateCountGreeting.AccessibleDescription");
			this.labelCallJobStateCountGreeting.AccessibleName = resources.GetString("labelCallJobStateCountGreeting.AccessibleName");
			this.labelCallJobStateCountGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountGreeting.Anchor")));
			this.labelCallJobStateCountGreeting.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountGreeting.AutoSize")));
			this.labelCallJobStateCountGreeting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountGreeting.Dock")));
			this.labelCallJobStateCountGreeting.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountGreeting.Enabled")));
			this.labelCallJobStateCountGreeting.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountGreeting.Font")));
			this.labelCallJobStateCountGreeting.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountGreeting.Image")));
			this.labelCallJobStateCountGreeting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountGreeting.ImageAlign")));
			this.labelCallJobStateCountGreeting.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountGreeting.ImageIndex")));
			this.labelCallJobStateCountGreeting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountGreeting.ImeMode")));
			this.labelCallJobStateCountGreeting.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountGreeting.Location")));
			this.labelCallJobStateCountGreeting.Name = "labelCallJobStateCountGreeting";
			this.labelCallJobStateCountGreeting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountGreeting.RightToLeft")));
			this.labelCallJobStateCountGreeting.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountGreeting.Size")));
			this.labelCallJobStateCountGreeting.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountGreeting.TabIndex")));
			this.labelCallJobStateCountGreeting.Text = resources.GetString("labelCallJobStateCountGreeting.Text");
			this.labelCallJobStateCountGreeting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountGreeting.TextAlign")));
			this.labelCallJobStateCountGreeting.Visible = ((bool)(resources.GetObject("labelCallJobStateCountGreeting.Visible")));
			// 
			// labelCallJobStateCountGreetingCap
			// 
			this.labelCallJobStateCountGreetingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountGreetingCap.AccessibleDescription");
			this.labelCallJobStateCountGreetingCap.AccessibleName = resources.GetString("labelCallJobStateCountGreetingCap.AccessibleName");
			this.labelCallJobStateCountGreetingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountGreetingCap.Anchor")));
			this.labelCallJobStateCountGreetingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountGreetingCap.AutoSize")));
			this.labelCallJobStateCountGreetingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountGreetingCap.Dock")));
			this.labelCallJobStateCountGreetingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountGreetingCap.Enabled")));
			this.labelCallJobStateCountGreetingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountGreetingCap.Font")));
			this.labelCallJobStateCountGreetingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountGreetingCap.Image")));
			this.labelCallJobStateCountGreetingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountGreetingCap.ImageAlign")));
			this.labelCallJobStateCountGreetingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountGreetingCap.ImageIndex")));
			this.labelCallJobStateCountGreetingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountGreetingCap.ImeMode")));
			this.labelCallJobStateCountGreetingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountGreetingCap.Location")));
			this.labelCallJobStateCountGreetingCap.Name = "labelCallJobStateCountGreetingCap";
			this.labelCallJobStateCountGreetingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountGreetingCap.RightToLeft")));
			this.labelCallJobStateCountGreetingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountGreetingCap.Size")));
			this.labelCallJobStateCountGreetingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountGreetingCap.TabIndex")));
			this.labelCallJobStateCountGreetingCap.Text = resources.GetString("labelCallJobStateCountGreetingCap.Text");
			this.labelCallJobStateCountGreetingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountGreetingCap.TextAlign")));
			this.labelCallJobStateCountGreetingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountGreetingCap.Visible")));
			// 
			// labelCallJobStateCountCPA
			// 
			this.labelCallJobStateCountCPA.AccessibleDescription = resources.GetString("labelCallJobStateCountCPA.AccessibleDescription");
			this.labelCallJobStateCountCPA.AccessibleName = resources.GetString("labelCallJobStateCountCPA.AccessibleName");
			this.labelCallJobStateCountCPA.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountCPA.Anchor")));
			this.labelCallJobStateCountCPA.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountCPA.AutoSize")));
			this.labelCallJobStateCountCPA.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountCPA.Dock")));
			this.labelCallJobStateCountCPA.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountCPA.Enabled")));
			this.labelCallJobStateCountCPA.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountCPA.Font")));
			this.labelCallJobStateCountCPA.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountCPA.Image")));
			this.labelCallJobStateCountCPA.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCPA.ImageAlign")));
			this.labelCallJobStateCountCPA.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountCPA.ImageIndex")));
			this.labelCallJobStateCountCPA.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountCPA.ImeMode")));
			this.labelCallJobStateCountCPA.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountCPA.Location")));
			this.labelCallJobStateCountCPA.Name = "labelCallJobStateCountCPA";
			this.labelCallJobStateCountCPA.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountCPA.RightToLeft")));
			this.labelCallJobStateCountCPA.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountCPA.Size")));
			this.labelCallJobStateCountCPA.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountCPA.TabIndex")));
			this.labelCallJobStateCountCPA.Text = resources.GetString("labelCallJobStateCountCPA.Text");
			this.labelCallJobStateCountCPA.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCPA.TextAlign")));
			this.labelCallJobStateCountCPA.Visible = ((bool)(resources.GetObject("labelCallJobStateCountCPA.Visible")));
			// 
			// labelCallJobStateCountCPACap
			// 
			this.labelCallJobStateCountCPACap.AccessibleDescription = resources.GetString("labelCallJobStateCountCPACap.AccessibleDescription");
			this.labelCallJobStateCountCPACap.AccessibleName = resources.GetString("labelCallJobStateCountCPACap.AccessibleName");
			this.labelCallJobStateCountCPACap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountCPACap.Anchor")));
			this.labelCallJobStateCountCPACap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountCPACap.AutoSize")));
			this.labelCallJobStateCountCPACap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountCPACap.Dock")));
			this.labelCallJobStateCountCPACap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountCPACap.Enabled")));
			this.labelCallJobStateCountCPACap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountCPACap.Font")));
			this.labelCallJobStateCountCPACap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountCPACap.Image")));
			this.labelCallJobStateCountCPACap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCPACap.ImageAlign")));
			this.labelCallJobStateCountCPACap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountCPACap.ImageIndex")));
			this.labelCallJobStateCountCPACap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountCPACap.ImeMode")));
			this.labelCallJobStateCountCPACap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountCPACap.Location")));
			this.labelCallJobStateCountCPACap.Name = "labelCallJobStateCountCPACap";
			this.labelCallJobStateCountCPACap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountCPACap.RightToLeft")));
			this.labelCallJobStateCountCPACap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountCPACap.Size")));
			this.labelCallJobStateCountCPACap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountCPACap.TabIndex")));
			this.labelCallJobStateCountCPACap.Text = resources.GetString("labelCallJobStateCountCPACap.Text");
			this.labelCallJobStateCountCPACap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountCPACap.TextAlign")));
			this.labelCallJobStateCountCPACap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountCPACap.Visible")));
			// 
			// labelCallJobStateCountAlerting
			// 
			this.labelCallJobStateCountAlerting.AccessibleDescription = resources.GetString("labelCallJobStateCountAlerting.AccessibleDescription");
			this.labelCallJobStateCountAlerting.AccessibleName = resources.GetString("labelCallJobStateCountAlerting.AccessibleName");
			this.labelCallJobStateCountAlerting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountAlerting.Anchor")));
			this.labelCallJobStateCountAlerting.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountAlerting.AutoSize")));
			this.labelCallJobStateCountAlerting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountAlerting.Dock")));
			this.labelCallJobStateCountAlerting.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountAlerting.Enabled")));
			this.labelCallJobStateCountAlerting.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountAlerting.Font")));
			this.labelCallJobStateCountAlerting.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountAlerting.Image")));
			this.labelCallJobStateCountAlerting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountAlerting.ImageAlign")));
			this.labelCallJobStateCountAlerting.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountAlerting.ImageIndex")));
			this.labelCallJobStateCountAlerting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountAlerting.ImeMode")));
			this.labelCallJobStateCountAlerting.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountAlerting.Location")));
			this.labelCallJobStateCountAlerting.Name = "labelCallJobStateCountAlerting";
			this.labelCallJobStateCountAlerting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountAlerting.RightToLeft")));
			this.labelCallJobStateCountAlerting.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountAlerting.Size")));
			this.labelCallJobStateCountAlerting.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountAlerting.TabIndex")));
			this.labelCallJobStateCountAlerting.Text = resources.GetString("labelCallJobStateCountAlerting.Text");
			this.labelCallJobStateCountAlerting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountAlerting.TextAlign")));
			this.labelCallJobStateCountAlerting.Visible = ((bool)(resources.GetObject("labelCallJobStateCountAlerting.Visible")));
			// 
			// labelCallJobStateCountAlertingCap
			// 
			this.labelCallJobStateCountAlertingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountAlertingCap.AccessibleDescription");
			this.labelCallJobStateCountAlertingCap.AccessibleName = resources.GetString("labelCallJobStateCountAlertingCap.AccessibleName");
			this.labelCallJobStateCountAlertingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountAlertingCap.Anchor")));
			this.labelCallJobStateCountAlertingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountAlertingCap.AutoSize")));
			this.labelCallJobStateCountAlertingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountAlertingCap.Dock")));
			this.labelCallJobStateCountAlertingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountAlertingCap.Enabled")));
			this.labelCallJobStateCountAlertingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountAlertingCap.Font")));
			this.labelCallJobStateCountAlertingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountAlertingCap.Image")));
			this.labelCallJobStateCountAlertingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountAlertingCap.ImageAlign")));
			this.labelCallJobStateCountAlertingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountAlertingCap.ImageIndex")));
			this.labelCallJobStateCountAlertingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountAlertingCap.ImeMode")));
			this.labelCallJobStateCountAlertingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountAlertingCap.Location")));
			this.labelCallJobStateCountAlertingCap.Name = "labelCallJobStateCountAlertingCap";
			this.labelCallJobStateCountAlertingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountAlertingCap.RightToLeft")));
			this.labelCallJobStateCountAlertingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountAlertingCap.Size")));
			this.labelCallJobStateCountAlertingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountAlertingCap.TabIndex")));
			this.labelCallJobStateCountAlertingCap.Text = resources.GetString("labelCallJobStateCountAlertingCap.Text");
			this.labelCallJobStateCountAlertingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountAlertingCap.TextAlign")));
			this.labelCallJobStateCountAlertingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountAlertingCap.Visible")));
			// 
			// labelCallJobStateCountDialing
			// 
			this.labelCallJobStateCountDialing.AccessibleDescription = resources.GetString("labelCallJobStateCountDialing.AccessibleDescription");
			this.labelCallJobStateCountDialing.AccessibleName = resources.GetString("labelCallJobStateCountDialing.AccessibleName");
			this.labelCallJobStateCountDialing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountDialing.Anchor")));
			this.labelCallJobStateCountDialing.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountDialing.AutoSize")));
			this.labelCallJobStateCountDialing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountDialing.Dock")));
			this.labelCallJobStateCountDialing.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountDialing.Enabled")));
			this.labelCallJobStateCountDialing.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountDialing.Font")));
			this.labelCallJobStateCountDialing.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountDialing.Image")));
			this.labelCallJobStateCountDialing.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountDialing.ImageAlign")));
			this.labelCallJobStateCountDialing.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountDialing.ImageIndex")));
			this.labelCallJobStateCountDialing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountDialing.ImeMode")));
			this.labelCallJobStateCountDialing.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountDialing.Location")));
			this.labelCallJobStateCountDialing.Name = "labelCallJobStateCountDialing";
			this.labelCallJobStateCountDialing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountDialing.RightToLeft")));
			this.labelCallJobStateCountDialing.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountDialing.Size")));
			this.labelCallJobStateCountDialing.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountDialing.TabIndex")));
			this.labelCallJobStateCountDialing.Text = resources.GetString("labelCallJobStateCountDialing.Text");
			this.labelCallJobStateCountDialing.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountDialing.TextAlign")));
			this.labelCallJobStateCountDialing.Visible = ((bool)(resources.GetObject("labelCallJobStateCountDialing.Visible")));
			// 
			// labelCallJobStateCountDialingCap
			// 
			this.labelCallJobStateCountDialingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountDialingCap.AccessibleDescription");
			this.labelCallJobStateCountDialingCap.AccessibleName = resources.GetString("labelCallJobStateCountDialingCap.AccessibleName");
			this.labelCallJobStateCountDialingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountDialingCap.Anchor")));
			this.labelCallJobStateCountDialingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountDialingCap.AutoSize")));
			this.labelCallJobStateCountDialingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountDialingCap.Dock")));
			this.labelCallJobStateCountDialingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountDialingCap.Enabled")));
			this.labelCallJobStateCountDialingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountDialingCap.Font")));
			this.labelCallJobStateCountDialingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountDialingCap.Image")));
			this.labelCallJobStateCountDialingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountDialingCap.ImageAlign")));
			this.labelCallJobStateCountDialingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountDialingCap.ImageIndex")));
			this.labelCallJobStateCountDialingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountDialingCap.ImeMode")));
			this.labelCallJobStateCountDialingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountDialingCap.Location")));
			this.labelCallJobStateCountDialingCap.Name = "labelCallJobStateCountDialingCap";
			this.labelCallJobStateCountDialingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountDialingCap.RightToLeft")));
			this.labelCallJobStateCountDialingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountDialingCap.Size")));
			this.labelCallJobStateCountDialingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountDialingCap.TabIndex")));
			this.labelCallJobStateCountDialingCap.Text = resources.GetString("labelCallJobStateCountDialingCap.Text");
			this.labelCallJobStateCountDialingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountDialingCap.TextAlign")));
			this.labelCallJobStateCountDialingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountDialingCap.Visible")));
			// 
			// labelCallJobStateCountPreparing
			// 
			this.labelCallJobStateCountPreparing.AccessibleDescription = resources.GetString("labelCallJobStateCountPreparing.AccessibleDescription");
			this.labelCallJobStateCountPreparing.AccessibleName = resources.GetString("labelCallJobStateCountPreparing.AccessibleName");
			this.labelCallJobStateCountPreparing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountPreparing.Anchor")));
			this.labelCallJobStateCountPreparing.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountPreparing.AutoSize")));
			this.labelCallJobStateCountPreparing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountPreparing.Dock")));
			this.labelCallJobStateCountPreparing.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountPreparing.Enabled")));
			this.labelCallJobStateCountPreparing.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountPreparing.Font")));
			this.labelCallJobStateCountPreparing.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountPreparing.Image")));
			this.labelCallJobStateCountPreparing.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountPreparing.ImageAlign")));
			this.labelCallJobStateCountPreparing.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountPreparing.ImageIndex")));
			this.labelCallJobStateCountPreparing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountPreparing.ImeMode")));
			this.labelCallJobStateCountPreparing.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountPreparing.Location")));
			this.labelCallJobStateCountPreparing.Name = "labelCallJobStateCountPreparing";
			this.labelCallJobStateCountPreparing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountPreparing.RightToLeft")));
			this.labelCallJobStateCountPreparing.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountPreparing.Size")));
			this.labelCallJobStateCountPreparing.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountPreparing.TabIndex")));
			this.labelCallJobStateCountPreparing.Text = resources.GetString("labelCallJobStateCountPreparing.Text");
			this.labelCallJobStateCountPreparing.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountPreparing.TextAlign")));
			this.labelCallJobStateCountPreparing.Visible = ((bool)(resources.GetObject("labelCallJobStateCountPreparing.Visible")));
			// 
			// labelCallJobStateCountPreparingCap
			// 
			this.labelCallJobStateCountPreparingCap.AccessibleDescription = resources.GetString("labelCallJobStateCountPreparingCap.AccessibleDescription");
			this.labelCallJobStateCountPreparingCap.AccessibleName = resources.GetString("labelCallJobStateCountPreparingCap.AccessibleName");
			this.labelCallJobStateCountPreparingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountPreparingCap.Anchor")));
			this.labelCallJobStateCountPreparingCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountPreparingCap.AutoSize")));
			this.labelCallJobStateCountPreparingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountPreparingCap.Dock")));
			this.labelCallJobStateCountPreparingCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountPreparingCap.Enabled")));
			this.labelCallJobStateCountPreparingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountPreparingCap.Font")));
			this.labelCallJobStateCountPreparingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountPreparingCap.Image")));
			this.labelCallJobStateCountPreparingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountPreparingCap.ImageAlign")));
			this.labelCallJobStateCountPreparingCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountPreparingCap.ImageIndex")));
			this.labelCallJobStateCountPreparingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountPreparingCap.ImeMode")));
			this.labelCallJobStateCountPreparingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountPreparingCap.Location")));
			this.labelCallJobStateCountPreparingCap.Name = "labelCallJobStateCountPreparingCap";
			this.labelCallJobStateCountPreparingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountPreparingCap.RightToLeft")));
			this.labelCallJobStateCountPreparingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountPreparingCap.Size")));
			this.labelCallJobStateCountPreparingCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountPreparingCap.TabIndex")));
			this.labelCallJobStateCountPreparingCap.Text = resources.GetString("labelCallJobStateCountPreparingCap.Text");
			this.labelCallJobStateCountPreparingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountPreparingCap.TextAlign")));
			this.labelCallJobStateCountPreparingCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountPreparingCap.Visible")));
			// 
			// labelCallJobStateCountReady
			// 
			this.labelCallJobStateCountReady.AccessibleDescription = resources.GetString("labelCallJobStateCountReady.AccessibleDescription");
			this.labelCallJobStateCountReady.AccessibleName = resources.GetString("labelCallJobStateCountReady.AccessibleName");
			this.labelCallJobStateCountReady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountReady.Anchor")));
			this.labelCallJobStateCountReady.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountReady.AutoSize")));
			this.labelCallJobStateCountReady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountReady.Dock")));
			this.labelCallJobStateCountReady.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountReady.Enabled")));
			this.labelCallJobStateCountReady.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountReady.Font")));
			this.labelCallJobStateCountReady.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountReady.Image")));
			this.labelCallJobStateCountReady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountReady.ImageAlign")));
			this.labelCallJobStateCountReady.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountReady.ImageIndex")));
			this.labelCallJobStateCountReady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountReady.ImeMode")));
			this.labelCallJobStateCountReady.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountReady.Location")));
			this.labelCallJobStateCountReady.Name = "labelCallJobStateCountReady";
			this.labelCallJobStateCountReady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountReady.RightToLeft")));
			this.labelCallJobStateCountReady.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountReady.Size")));
			this.labelCallJobStateCountReady.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountReady.TabIndex")));
			this.labelCallJobStateCountReady.Text = resources.GetString("labelCallJobStateCountReady.Text");
			this.labelCallJobStateCountReady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountReady.TextAlign")));
			this.labelCallJobStateCountReady.Visible = ((bool)(resources.GetObject("labelCallJobStateCountReady.Visible")));
			// 
			// labelCallJobStateCountReadyCap
			// 
			this.labelCallJobStateCountReadyCap.AccessibleDescription = resources.GetString("labelCallJobStateCountReadyCap.AccessibleDescription");
			this.labelCallJobStateCountReadyCap.AccessibleName = resources.GetString("labelCallJobStateCountReadyCap.AccessibleName");
			this.labelCallJobStateCountReadyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStateCountReadyCap.Anchor")));
			this.labelCallJobStateCountReadyCap.AutoSize = ((bool)(resources.GetObject("labelCallJobStateCountReadyCap.AutoSize")));
			this.labelCallJobStateCountReadyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStateCountReadyCap.Dock")));
			this.labelCallJobStateCountReadyCap.Enabled = ((bool)(resources.GetObject("labelCallJobStateCountReadyCap.Enabled")));
			this.labelCallJobStateCountReadyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStateCountReadyCap.Font")));
			this.labelCallJobStateCountReadyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStateCountReadyCap.Image")));
			this.labelCallJobStateCountReadyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountReadyCap.ImageAlign")));
			this.labelCallJobStateCountReadyCap.ImageIndex = ((int)(resources.GetObject("labelCallJobStateCountReadyCap.ImageIndex")));
			this.labelCallJobStateCountReadyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStateCountReadyCap.ImeMode")));
			this.labelCallJobStateCountReadyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStateCountReadyCap.Location")));
			this.labelCallJobStateCountReadyCap.Name = "labelCallJobStateCountReadyCap";
			this.labelCallJobStateCountReadyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStateCountReadyCap.RightToLeft")));
			this.labelCallJobStateCountReadyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStateCountReadyCap.Size")));
			this.labelCallJobStateCountReadyCap.TabIndex = ((int)(resources.GetObject("labelCallJobStateCountReadyCap.TabIndex")));
			this.labelCallJobStateCountReadyCap.Text = resources.GetString("labelCallJobStateCountReadyCap.Text");
			this.labelCallJobStateCountReadyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStateCountReadyCap.TextAlign")));
			this.labelCallJobStateCountReadyCap.Visible = ((bool)(resources.GetObject("labelCallJobStateCountReadyCap.Visible")));
			// 
			// labelCallJobStatesTopLineGray
			// 
			this.labelCallJobStatesTopLineGray.AccessibleDescription = resources.GetString("labelCallJobStatesTopLineGray.AccessibleDescription");
			this.labelCallJobStatesTopLineGray.AccessibleName = resources.GetString("labelCallJobStatesTopLineGray.AccessibleName");
			this.labelCallJobStatesTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesTopLineGray.Anchor")));
			this.labelCallJobStatesTopLineGray.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesTopLineGray.AutoSize")));
			this.labelCallJobStatesTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelCallJobStatesTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesTopLineGray.Dock")));
			this.labelCallJobStatesTopLineGray.Enabled = ((bool)(resources.GetObject("labelCallJobStatesTopLineGray.Enabled")));
			this.labelCallJobStatesTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesTopLineGray.Font")));
			this.labelCallJobStatesTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCallJobStatesTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesTopLineGray.Image")));
			this.labelCallJobStatesTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesTopLineGray.ImageAlign")));
			this.labelCallJobStatesTopLineGray.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesTopLineGray.ImageIndex")));
			this.labelCallJobStatesTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesTopLineGray.ImeMode")));
			this.labelCallJobStatesTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesTopLineGray.Location")));
			this.labelCallJobStatesTopLineGray.Name = "labelCallJobStatesTopLineGray";
			this.labelCallJobStatesTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesTopLineGray.RightToLeft")));
			this.labelCallJobStatesTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesTopLineGray.Size")));
			this.labelCallJobStatesTopLineGray.TabIndex = ((int)(resources.GetObject("labelCallJobStatesTopLineGray.TabIndex")));
			this.labelCallJobStatesTopLineGray.Text = resources.GetString("labelCallJobStatesTopLineGray.Text");
			this.labelCallJobStatesTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesTopLineGray.TextAlign")));
			this.labelCallJobStatesTopLineGray.Visible = ((bool)(resources.GetObject("labelCallJobStatesTopLineGray.Visible")));
			// 
			// labelCallJobStatesTopLineWhite
			// 
			this.labelCallJobStatesTopLineWhite.AccessibleDescription = resources.GetString("labelCallJobStatesTopLineWhite.AccessibleDescription");
			this.labelCallJobStatesTopLineWhite.AccessibleName = resources.GetString("labelCallJobStatesTopLineWhite.AccessibleName");
			this.labelCallJobStatesTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesTopLineWhite.Anchor")));
			this.labelCallJobStatesTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesTopLineWhite.AutoSize")));
			this.labelCallJobStatesTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelCallJobStatesTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesTopLineWhite.Dock")));
			this.labelCallJobStatesTopLineWhite.Enabled = ((bool)(resources.GetObject("labelCallJobStatesTopLineWhite.Enabled")));
			this.labelCallJobStatesTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesTopLineWhite.Font")));
			this.labelCallJobStatesTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCallJobStatesTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesTopLineWhite.Image")));
			this.labelCallJobStatesTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesTopLineWhite.ImageAlign")));
			this.labelCallJobStatesTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesTopLineWhite.ImageIndex")));
			this.labelCallJobStatesTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesTopLineWhite.ImeMode")));
			this.labelCallJobStatesTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesTopLineWhite.Location")));
			this.labelCallJobStatesTopLineWhite.Name = "labelCallJobStatesTopLineWhite";
			this.labelCallJobStatesTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesTopLineWhite.RightToLeft")));
			this.labelCallJobStatesTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesTopLineWhite.Size")));
			this.labelCallJobStatesTopLineWhite.TabIndex = ((int)(resources.GetObject("labelCallJobStatesTopLineWhite.TabIndex")));
			this.labelCallJobStatesTopLineWhite.Text = resources.GetString("labelCallJobStatesTopLineWhite.Text");
			this.labelCallJobStatesTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesTopLineWhite.TextAlign")));
			this.labelCallJobStatesTopLineWhite.Visible = ((bool)(resources.GetObject("labelCallJobStatesTopLineWhite.Visible")));
			// 
			// labelCallJobStatesRowCount
			// 
			this.labelCallJobStatesRowCount.AccessibleDescription = resources.GetString("labelCallJobStatesRowCount.AccessibleDescription");
			this.labelCallJobStatesRowCount.AccessibleName = resources.GetString("labelCallJobStatesRowCount.AccessibleName");
			this.labelCallJobStatesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesRowCount.Anchor")));
			this.labelCallJobStatesRowCount.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesRowCount.AutoSize")));
			this.labelCallJobStatesRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesRowCount.Dock")));
			this.labelCallJobStatesRowCount.Enabled = ((bool)(resources.GetObject("labelCallJobStatesRowCount.Enabled")));
			this.labelCallJobStatesRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesRowCount.Font")));
			this.labelCallJobStatesRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesRowCount.Image")));
			this.labelCallJobStatesRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesRowCount.ImageAlign")));
			this.labelCallJobStatesRowCount.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesRowCount.ImageIndex")));
			this.labelCallJobStatesRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesRowCount.ImeMode")));
			this.labelCallJobStatesRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesRowCount.Location")));
			this.labelCallJobStatesRowCount.Name = "labelCallJobStatesRowCount";
			this.labelCallJobStatesRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesRowCount.RightToLeft")));
			this.labelCallJobStatesRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesRowCount.Size")));
			this.labelCallJobStatesRowCount.TabIndex = ((int)(resources.GetObject("labelCallJobStatesRowCount.TabIndex")));
			this.labelCallJobStatesRowCount.Text = resources.GetString("labelCallJobStatesRowCount.Text");
			this.labelCallJobStatesRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesRowCount.TextAlign")));
			this.labelCallJobStatesRowCount.Visible = ((bool)(resources.GetObject("labelCallJobStatesRowCount.Visible")));
			// 
			// labelCallJobStatesRowState
			// 
			this.labelCallJobStatesRowState.AccessibleDescription = resources.GetString("labelCallJobStatesRowState.AccessibleDescription");
			this.labelCallJobStatesRowState.AccessibleName = resources.GetString("labelCallJobStatesRowState.AccessibleName");
			this.labelCallJobStatesRowState.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallJobStatesRowState.Anchor")));
			this.labelCallJobStatesRowState.AutoSize = ((bool)(resources.GetObject("labelCallJobStatesRowState.AutoSize")));
			this.labelCallJobStatesRowState.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallJobStatesRowState.Dock")));
			this.labelCallJobStatesRowState.Enabled = ((bool)(resources.GetObject("labelCallJobStatesRowState.Enabled")));
			this.labelCallJobStatesRowState.Font = ((System.Drawing.Font)(resources.GetObject("labelCallJobStatesRowState.Font")));
			this.labelCallJobStatesRowState.Image = ((System.Drawing.Image)(resources.GetObject("labelCallJobStatesRowState.Image")));
			this.labelCallJobStatesRowState.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesRowState.ImageAlign")));
			this.labelCallJobStatesRowState.ImageIndex = ((int)(resources.GetObject("labelCallJobStatesRowState.ImageIndex")));
			this.labelCallJobStatesRowState.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallJobStatesRowState.ImeMode")));
			this.labelCallJobStatesRowState.Location = ((System.Drawing.Point)(resources.GetObject("labelCallJobStatesRowState.Location")));
			this.labelCallJobStatesRowState.Name = "labelCallJobStatesRowState";
			this.labelCallJobStatesRowState.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallJobStatesRowState.RightToLeft")));
			this.labelCallJobStatesRowState.Size = ((System.Drawing.Size)(resources.GetObject("labelCallJobStatesRowState.Size")));
			this.labelCallJobStatesRowState.TabIndex = ((int)(resources.GetObject("labelCallJobStatesRowState.TabIndex")));
			this.labelCallJobStatesRowState.Text = resources.GetString("labelCallJobStatesRowState.Text");
			this.labelCallJobStatesRowState.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallJobStatesRowState.TextAlign")));
			this.labelCallJobStatesRowState.Visible = ((bool)(resources.GetObject("labelCallJobStatesRowState.Visible")));
			// 
			// CampaignViewCallJobs
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartCallJobStateCount);
			this.Controls.Add(this.groupBoxCallJobStates);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewCallJobs";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartCallJobStateCount.ResumeLayout(false);
			this.panelChartCallJobStateCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartCallJobStateCount)).EndInit();
			this.groupBoxCallJobStates.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// Statusverteilung aktualisieren
			labelCallJobStateCountReady.Text =
				campaign.GetCallJobStateCount(CallJobState.Ready).ToString();
			labelCallJobStateCountPreparing.Text =
				campaign.GetCallJobStateCount(CallJobState.Preparing).ToString();
			labelCallJobStateCountDialing.Text =
				campaign.GetCallJobStateCount(CallJobState.Dialing).ToString();
			labelCallJobStateCountAlerting.Text =
				(campaign.GetCallJobStateCount(CallJobState.ForcedAlerting) +
				campaign.GetCallJobStateCount(CallJobState.FreeAlerting)).ToString();
			labelCallJobStateCountCPA.Text =
				campaign.GetCallJobStateCount(CallJobState.CPA).ToString();
			labelCallJobStateCountGreeting.Text =
				campaign.GetCallJobStateCount(CallJobState.Greeting).ToString();
			labelCallJobStateCountWaiting.Text =
				campaign.GetCallJobStateCount(CallJobState.Waiting).ToString();
			labelCallJobStateCountSignaling.Text =
				campaign.GetCallJobStateCount(CallJobState.Signaling).ToString();
			labelCallJobStateCount.Text = campaign.CallJobCount.ToString();

			// Verlaufsgrafik aktualisieren
			chartCallJobStateCount.DataCollection = campaign.CallJobStateCountData;
		}

		#endregion

		#endregion
	}
}
