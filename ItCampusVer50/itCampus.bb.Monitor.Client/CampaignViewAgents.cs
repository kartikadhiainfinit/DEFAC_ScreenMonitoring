using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Agenten einer Kampagne.
	/// </summary>
	public class CampaignViewAgents : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxAgentModes;
		private System.Windows.Forms.Label labelAgentModesRowMode;
		private System.Windows.Forms.Label labelAgentModesRowCount;
		private System.Windows.Forms.Label labelAgentModesRowCountActive;
		private System.Windows.Forms.Label labelAgentModesRowCountInactive;
		private System.Windows.Forms.Label labelAgentModesTopLineWhite;
		private System.Windows.Forms.Label labelAgentModesTopLineGray;
		private System.Windows.Forms.Label labelAgentModeCountInboundCap;
		private System.Windows.Forms.Label labelAgentModeCountInbound;
		private System.Windows.Forms.Label labelAgentModeCountInboundActive;
		private System.Windows.Forms.Label labelAgentModeCountInboundInactive;
		private System.Windows.Forms.Label labelAgentModeCountOutboundCap;
		private System.Windows.Forms.Label labelAgentModeCountOutbound;
		private System.Windows.Forms.Label labelAgentModeCountOutboundActive;
		private System.Windows.Forms.Label labelAgentModeCountOutboundInactive;
		private System.Windows.Forms.Label labelAgentModeCountBlendedCap;
		private System.Windows.Forms.Label labelAgentModeCountBlended;
		private System.Windows.Forms.Label labelAgentModeCountBlendedActive;
		private System.Windows.Forms.Label labelAgentModeCountBlendedInactive;
		private System.Windows.Forms.Label labelAgentModesBottomLineWhite;
		private System.Windows.Forms.Label labelAgentModesBottomLineGray;
		private System.Windows.Forms.Label labelAgentModeCountCap;
		private System.Windows.Forms.Label labelAgentModeCount;
		private System.Windows.Forms.Label labelAgentModeCountActive;
		private System.Windows.Forms.Label labelAgentModeCountInactive;
		private System.Windows.Forms.GroupBox groupBoxAgentStates;
		private System.Windows.Forms.Label labelAgentStatesRowState;
		private System.Windows.Forms.Label labelAgentStatesRowCount;
		private System.Windows.Forms.Label labelAgentStatesRowTimeCur;
		private System.Windows.Forms.Label labelAgentStatesRowTimeTtl;
		private System.Windows.Forms.Label labelAgentStatesTopLineWhite;
		private System.Windows.Forms.Label labelAgentStatesTopLineGray;
		private System.Windows.Forms.Label labelAgentStateCountUnassignedCap;
		private System.Windows.Forms.Label labelAgentStateCountUnassigned;
		private System.Windows.Forms.Label labelAgentStateTimeUnassignedCur;
		private System.Windows.Forms.Label labelAgentStateTimeUnassignedTtl;
		private System.Windows.Forms.Label labelAgentStateCountNotReadyCap;
		private System.Windows.Forms.Label labelAgentStateCountNotReady;
		private System.Windows.Forms.Label labelAgentStateTimeNotReadyCur;
		private System.Windows.Forms.Label labelAgentStateTimeNotReadyTtl;
		private System.Windows.Forms.Label labelAgentStateCountReadyCap;
		private System.Windows.Forms.Label labelAgentStateCountReady;
		private System.Windows.Forms.Label labelAgentStateTimeReadyCur;
		private System.Windows.Forms.Label labelAgentStateTimeReadyTtl;
		private System.Windows.Forms.Label labelAgentStateCountPendingCap;
		private System.Windows.Forms.Label labelAgentStateCountPending;
		private System.Windows.Forms.Label labelAgentStateTimePendingCur;
		private System.Windows.Forms.Label labelAgentStateTimePendingTtl;
		private System.Windows.Forms.Label labelAgentStateCountSignalingCap;
		private System.Windows.Forms.Label labelAgentStateCountSignaling;
		private System.Windows.Forms.Label labelAgentStateTimeSignalingCur;
		private System.Windows.Forms.Label labelAgentStateTimeSignalingTtl;
		private System.Windows.Forms.Label labelAgentStateCountPreparingCap;
		private System.Windows.Forms.Label labelAgentStateCountPreparing;
		private System.Windows.Forms.Label labelAgentStateTimePreparingCur;
		private System.Windows.Forms.Label labelAgentStateTimePreparingTtl;
		private System.Windows.Forms.Label labelAgentStateCountCallingCap;
		private System.Windows.Forms.Label labelAgentStateCountCalling;
		private System.Windows.Forms.Label labelAgentStateTimeCallingCur;
		private System.Windows.Forms.Label labelAgentStateTimeCallingTtl;
		private System.Windows.Forms.Label labelAgentStateCountTalkingCap;
		private System.Windows.Forms.Label labelAgentStateCountTalking;
		private System.Windows.Forms.Label labelAgentStateTimeTalkingCur;
		private System.Windows.Forms.Label labelAgentStateTimeTalkingTtl;
		private System.Windows.Forms.Label labelAgentStateCountConferencingCap;
		private System.Windows.Forms.Label labelAgentStateCountConferencing;
		private System.Windows.Forms.Label labelAgentStateTimeConferencingCur;
		private System.Windows.Forms.Label labelAgentStateTimeConferencingTtl;
		private System.Windows.Forms.Label labelAgentStateCountWrapupCap;
		private System.Windows.Forms.Label labelAgentStateCountWrapup;
		private System.Windows.Forms.Label labelAgentStateTimeWrapupCur;
		private System.Windows.Forms.Label labelAgentStateTimeWrapupTtl;
		private System.Windows.Forms.Label labelAgentStatesBottomLineWhite;
		private System.Windows.Forms.Label labelAgentStatesBottomLineGray;
		private System.Windows.Forms.Label labelAgentStateCountCap;
		private System.Windows.Forms.Label labelAgentStateCount;
		private System.Windows.Forms.GroupBox groupBoxChartAgentStateCount;
		private System.Windows.Forms.Panel panelChartAgentStateCount;
		private itCampus.bb.Graph.Chart.Chart chartAgentStateCount;
		private System.Windows.Forms.GroupBox groupBoxChartAgentStateTime;
		private System.Windows.Forms.Panel panelChartAgentStateTime;
		private itCampus.bb.Graph.Chart.Chart chartAgentStateTime;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewAgents()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewAgents));
			itCampus.bb.Graph.Chart.Curve curve1 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve2 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve3 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve4 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve5 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve6 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve7 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve8 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve9 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve10 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve11 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve12 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve13 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve14 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve15 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve16 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve17 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve18 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve19 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve20 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve21 = new itCampus.bb.Graph.Chart.Curve();
			this.groupBoxChartAgentStateTime = new System.Windows.Forms.GroupBox();
			this.panelChartAgentStateTime = new System.Windows.Forms.Panel();
			this.chartAgentStateTime = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxChartAgentStateCount = new System.Windows.Forms.GroupBox();
			this.panelChartAgentStateCount = new System.Windows.Forms.Panel();
			this.chartAgentStateCount = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxAgentStates = new System.Windows.Forms.GroupBox();
			this.labelAgentStateCount = new System.Windows.Forms.Label();
			this.labelAgentStateCountCap = new System.Windows.Forms.Label();
			this.labelAgentStatesBottomLineGray = new System.Windows.Forms.Label();
			this.labelAgentStatesBottomLineWhite = new System.Windows.Forms.Label();
			this.labelAgentStateTimeWrapupTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeWrapupCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountWrapup = new System.Windows.Forms.Label();
			this.labelAgentStateCountWrapupCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeConferencingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeConferencingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountConferencing = new System.Windows.Forms.Label();
			this.labelAgentStateCountConferencingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeTalkingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeTalkingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountTalking = new System.Windows.Forms.Label();
			this.labelAgentStateCountTalkingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeCallingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeCallingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountCalling = new System.Windows.Forms.Label();
			this.labelAgentStateCountCallingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimePreparingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimePreparingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountPreparing = new System.Windows.Forms.Label();
			this.labelAgentStateCountPreparingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeSignalingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeSignalingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountSignaling = new System.Windows.Forms.Label();
			this.labelAgentStateCountSignalingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimePendingTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimePendingCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountPending = new System.Windows.Forms.Label();
			this.labelAgentStateCountPendingCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeReadyTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeReadyCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountReady = new System.Windows.Forms.Label();
			this.labelAgentStateCountReadyCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeNotReadyTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeNotReadyCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountNotReady = new System.Windows.Forms.Label();
			this.labelAgentStateCountNotReadyCap = new System.Windows.Forms.Label();
			this.labelAgentStateTimeUnassignedTtl = new System.Windows.Forms.Label();
			this.labelAgentStateTimeUnassignedCur = new System.Windows.Forms.Label();
			this.labelAgentStateCountUnassigned = new System.Windows.Forms.Label();
			this.labelAgentStateCountUnassignedCap = new System.Windows.Forms.Label();
			this.labelAgentStatesTopLineGray = new System.Windows.Forms.Label();
			this.labelAgentStatesTopLineWhite = new System.Windows.Forms.Label();
			this.labelAgentStatesRowTimeTtl = new System.Windows.Forms.Label();
			this.labelAgentStatesRowTimeCur = new System.Windows.Forms.Label();
			this.labelAgentStatesRowCount = new System.Windows.Forms.Label();
			this.labelAgentStatesRowState = new System.Windows.Forms.Label();
			this.groupBoxAgentModes = new System.Windows.Forms.GroupBox();
			this.labelAgentModeCountInactive = new System.Windows.Forms.Label();
			this.labelAgentModeCountActive = new System.Windows.Forms.Label();
			this.labelAgentModeCount = new System.Windows.Forms.Label();
			this.labelAgentModeCountCap = new System.Windows.Forms.Label();
			this.labelAgentModesBottomLineGray = new System.Windows.Forms.Label();
			this.labelAgentModesBottomLineWhite = new System.Windows.Forms.Label();
			this.labelAgentModeCountBlendedInactive = new System.Windows.Forms.Label();
			this.labelAgentModeCountBlendedActive = new System.Windows.Forms.Label();
			this.labelAgentModeCountBlended = new System.Windows.Forms.Label();
			this.labelAgentModeCountBlendedCap = new System.Windows.Forms.Label();
			this.labelAgentModeCountOutboundInactive = new System.Windows.Forms.Label();
			this.labelAgentModeCountOutboundActive = new System.Windows.Forms.Label();
			this.labelAgentModeCountOutbound = new System.Windows.Forms.Label();
			this.labelAgentModeCountOutboundCap = new System.Windows.Forms.Label();
			this.labelAgentModeCountInboundInactive = new System.Windows.Forms.Label();
			this.labelAgentModeCountInboundActive = new System.Windows.Forms.Label();
			this.labelAgentModeCountInbound = new System.Windows.Forms.Label();
			this.labelAgentModeCountInboundCap = new System.Windows.Forms.Label();
			this.labelAgentModesTopLineGray = new System.Windows.Forms.Label();
			this.labelAgentModesTopLineWhite = new System.Windows.Forms.Label();
			this.labelAgentModesRowCountInactive = new System.Windows.Forms.Label();
			this.labelAgentModesRowCountActive = new System.Windows.Forms.Label();
			this.labelAgentModesRowCount = new System.Windows.Forms.Label();
			this.labelAgentModesRowMode = new System.Windows.Forms.Label();
			this.groupBoxChartAgentStateTime.SuspendLayout();
			this.panelChartAgentStateTime.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartAgentStateTime)).BeginInit();
			this.groupBoxChartAgentStateCount.SuspendLayout();
			this.panelChartAgentStateCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartAgentStateCount)).BeginInit();
			this.groupBoxAgentStates.SuspendLayout();
			this.groupBoxAgentModes.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartAgentStateTime
			// 
			this.groupBoxChartAgentStateTime.AccessibleDescription = resources.GetString("groupBoxChartAgentStateTime.AccessibleDescription");
			this.groupBoxChartAgentStateTime.AccessibleName = resources.GetString("groupBoxChartAgentStateTime.AccessibleName");
			this.groupBoxChartAgentStateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartAgentStateTime.Anchor")));
			this.groupBoxChartAgentStateTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartAgentStateTime.BackgroundImage")));
			this.groupBoxChartAgentStateTime.Controls.Add(this.panelChartAgentStateTime);
			this.groupBoxChartAgentStateTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartAgentStateTime.Dock")));
			this.groupBoxChartAgentStateTime.Enabled = ((bool)(resources.GetObject("groupBoxChartAgentStateTime.Enabled")));
			this.groupBoxChartAgentStateTime.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartAgentStateTime.Font")));
			this.groupBoxChartAgentStateTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartAgentStateTime.ImeMode")));
			this.groupBoxChartAgentStateTime.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartAgentStateTime.Location")));
			this.groupBoxChartAgentStateTime.Name = "groupBoxChartAgentStateTime";
			this.groupBoxChartAgentStateTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartAgentStateTime.RightToLeft")));
			this.groupBoxChartAgentStateTime.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartAgentStateTime.Size")));
			this.groupBoxChartAgentStateTime.TabIndex = ((int)(resources.GetObject("groupBoxChartAgentStateTime.TabIndex")));
			this.groupBoxChartAgentStateTime.TabStop = false;
			this.groupBoxChartAgentStateTime.Text = resources.GetString("groupBoxChartAgentStateTime.Text");
			this.groupBoxChartAgentStateTime.Visible = ((bool)(resources.GetObject("groupBoxChartAgentStateTime.Visible")));
			// 
			// panelChartAgentStateTime
			// 
			this.panelChartAgentStateTime.AccessibleDescription = resources.GetString("panelChartAgentStateTime.AccessibleDescription");
			this.panelChartAgentStateTime.AccessibleName = resources.GetString("panelChartAgentStateTime.AccessibleName");
			this.panelChartAgentStateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartAgentStateTime.Anchor")));
			this.panelChartAgentStateTime.AutoScroll = ((bool)(resources.GetObject("panelChartAgentStateTime.AutoScroll")));
			this.panelChartAgentStateTime.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateTime.AutoScrollMargin")));
			this.panelChartAgentStateTime.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateTime.AutoScrollMinSize")));
			this.panelChartAgentStateTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartAgentStateTime.BackgroundImage")));
			this.panelChartAgentStateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartAgentStateTime.Controls.Add(this.chartAgentStateTime);
			this.panelChartAgentStateTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartAgentStateTime.Dock")));
			this.panelChartAgentStateTime.Enabled = ((bool)(resources.GetObject("panelChartAgentStateTime.Enabled")));
			this.panelChartAgentStateTime.Font = ((System.Drawing.Font)(resources.GetObject("panelChartAgentStateTime.Font")));
			this.panelChartAgentStateTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartAgentStateTime.ImeMode")));
			this.panelChartAgentStateTime.Location = ((System.Drawing.Point)(resources.GetObject("panelChartAgentStateTime.Location")));
			this.panelChartAgentStateTime.Name = "panelChartAgentStateTime";
			this.panelChartAgentStateTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartAgentStateTime.RightToLeft")));
			this.panelChartAgentStateTime.Size = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateTime.Size")));
			this.panelChartAgentStateTime.TabIndex = ((int)(resources.GetObject("panelChartAgentStateTime.TabIndex")));
			this.panelChartAgentStateTime.Text = resources.GetString("panelChartAgentStateTime.Text");
			this.panelChartAgentStateTime.Visible = ((bool)(resources.GetObject("panelChartAgentStateTime.Visible")));
			// 
			// chartAgentStateTime
			// 
			this.chartAgentStateTime.AccessibleDescription = resources.GetString("chartAgentStateTime.AccessibleDescription");
			this.chartAgentStateTime.AccessibleName = resources.GetString("chartAgentStateTime.AccessibleName");
			this.chartAgentStateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartAgentStateTime.Anchor")));
			this.chartAgentStateTime.AutoScroll = ((bool)(resources.GetObject("chartAgentStateTime.AutoScroll")));
			this.chartAgentStateTime.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartAgentStateTime.AutoScrollMargin")));
			this.chartAgentStateTime.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartAgentStateTime.AutoScrollMinSize")));
			this.chartAgentStateTime.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.BackgroundColor")));
			this.chartAgentStateTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartAgentStateTime.BackgroundImage")));
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
			curve10.Caption = resources.GetString("curve10.Caption");
			curve10.Color = ((System.Drawing.Color)(resources.GetObject("curve10.Color")));
			curve10.ContinuesLine = ((bool)(resources.GetObject("curve10.ContinuesLine")));
			curve10.MappingName = resources.GetString("curve10.MappingName");
			curve10.Visible = ((bool)(resources.GetObject("curve10.Visible")));
			this.chartAgentStateTime.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																							 curve1,
																							 curve2,
																							 curve3,
																							 curve4,
																							 curve5,
																							 curve6,
																							 curve7,
																							 curve8,
																							 curve9,
																							 curve10});
			this.chartAgentStateTime.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartAgentStateTime.DisplayedInterval")));
			this.chartAgentStateTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartAgentStateTime.Dock")));
			this.chartAgentStateTime.Enabled = ((bool)(resources.GetObject("chartAgentStateTime.Enabled")));
			this.chartAgentStateTime.Font = ((System.Drawing.Font)(resources.GetObject("chartAgentStateTime.Font")));
			this.chartAgentStateTime.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.FrameColor")));
			this.chartAgentStateTime.GridColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.GridColor")));
			this.chartAgentStateTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartAgentStateTime.ImeMode")));
			this.chartAgentStateTime.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartAgentStateTime.LegendAlignment")));
			this.chartAgentStateTime.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.LegendColor")));
			this.chartAgentStateTime.Location = ((System.Drawing.Point)(resources.GetObject("chartAgentStateTime.Location")));
			this.chartAgentStateTime.Name = "chartAgentStateTime";
			this.chartAgentStateTime.Painting = ((bool)(resources.GetObject("chartAgentStateTime.Painting")));
			this.chartAgentStateTime.RescaleRatio = ((System.Double)(resources.GetObject("chartAgentStateTime.RescaleRatio")));
			this.chartAgentStateTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartAgentStateTime.RightToLeft")));
			this.chartAgentStateTime.Size = ((System.Drawing.Size)(resources.GetObject("chartAgentStateTime.Size")));
			this.chartAgentStateTime.TabIndex = ((int)(resources.GetObject("chartAgentStateTime.TabIndex")));
			this.chartAgentStateTime.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.ValueColor")));
			this.chartAgentStateTime.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartAgentStateTime.ValueType")));
			this.chartAgentStateTime.Visible = ((bool)(resources.GetObject("chartAgentStateTime.Visible")));
			this.chartAgentStateTime.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.XLabelColor")));
			this.chartAgentStateTime.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateTime.YLabelColor")));
			this.chartAgentStateTime.YMax = ((System.Double)(resources.GetObject("chartAgentStateTime.YMax")));
			this.chartAgentStateTime.YMaxScaling = ((bool)(resources.GetObject("chartAgentStateTime.YMaxScaling")));
			this.chartAgentStateTime.YMin = ((System.Double)(resources.GetObject("chartAgentStateTime.YMin")));
			this.chartAgentStateTime.YMinScaling = ((bool)(resources.GetObject("chartAgentStateTime.YMinScaling")));
			// 
			// groupBoxChartAgentStateCount
			// 
			this.groupBoxChartAgentStateCount.AccessibleDescription = resources.GetString("groupBoxChartAgentStateCount.AccessibleDescription");
			this.groupBoxChartAgentStateCount.AccessibleName = resources.GetString("groupBoxChartAgentStateCount.AccessibleName");
			this.groupBoxChartAgentStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartAgentStateCount.Anchor")));
			this.groupBoxChartAgentStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartAgentStateCount.BackgroundImage")));
			this.groupBoxChartAgentStateCount.Controls.Add(this.panelChartAgentStateCount);
			this.groupBoxChartAgentStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartAgentStateCount.Dock")));
			this.groupBoxChartAgentStateCount.Enabled = ((bool)(resources.GetObject("groupBoxChartAgentStateCount.Enabled")));
			this.groupBoxChartAgentStateCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartAgentStateCount.Font")));
			this.groupBoxChartAgentStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartAgentStateCount.ImeMode")));
			this.groupBoxChartAgentStateCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartAgentStateCount.Location")));
			this.groupBoxChartAgentStateCount.Name = "groupBoxChartAgentStateCount";
			this.groupBoxChartAgentStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartAgentStateCount.RightToLeft")));
			this.groupBoxChartAgentStateCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartAgentStateCount.Size")));
			this.groupBoxChartAgentStateCount.TabIndex = ((int)(resources.GetObject("groupBoxChartAgentStateCount.TabIndex")));
			this.groupBoxChartAgentStateCount.TabStop = false;
			this.groupBoxChartAgentStateCount.Text = resources.GetString("groupBoxChartAgentStateCount.Text");
			this.groupBoxChartAgentStateCount.Visible = ((bool)(resources.GetObject("groupBoxChartAgentStateCount.Visible")));
			// 
			// panelChartAgentStateCount
			// 
			this.panelChartAgentStateCount.AccessibleDescription = resources.GetString("panelChartAgentStateCount.AccessibleDescription");
			this.panelChartAgentStateCount.AccessibleName = resources.GetString("panelChartAgentStateCount.AccessibleName");
			this.panelChartAgentStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartAgentStateCount.Anchor")));
			this.panelChartAgentStateCount.AutoScroll = ((bool)(resources.GetObject("panelChartAgentStateCount.AutoScroll")));
			this.panelChartAgentStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateCount.AutoScrollMargin")));
			this.panelChartAgentStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateCount.AutoScrollMinSize")));
			this.panelChartAgentStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartAgentStateCount.BackgroundImage")));
			this.panelChartAgentStateCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartAgentStateCount.Controls.Add(this.chartAgentStateCount);
			this.panelChartAgentStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartAgentStateCount.Dock")));
			this.panelChartAgentStateCount.Enabled = ((bool)(resources.GetObject("panelChartAgentStateCount.Enabled")));
			this.panelChartAgentStateCount.Font = ((System.Drawing.Font)(resources.GetObject("panelChartAgentStateCount.Font")));
			this.panelChartAgentStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartAgentStateCount.ImeMode")));
			this.panelChartAgentStateCount.Location = ((System.Drawing.Point)(resources.GetObject("panelChartAgentStateCount.Location")));
			this.panelChartAgentStateCount.Name = "panelChartAgentStateCount";
			this.panelChartAgentStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartAgentStateCount.RightToLeft")));
			this.panelChartAgentStateCount.Size = ((System.Drawing.Size)(resources.GetObject("panelChartAgentStateCount.Size")));
			this.panelChartAgentStateCount.TabIndex = ((int)(resources.GetObject("panelChartAgentStateCount.TabIndex")));
			this.panelChartAgentStateCount.Text = resources.GetString("panelChartAgentStateCount.Text");
			this.panelChartAgentStateCount.Visible = ((bool)(resources.GetObject("panelChartAgentStateCount.Visible")));
			// 
			// chartAgentStateCount
			// 
			this.chartAgentStateCount.AccessibleDescription = resources.GetString("chartAgentStateCount.AccessibleDescription");
			this.chartAgentStateCount.AccessibleName = resources.GetString("chartAgentStateCount.AccessibleName");
			this.chartAgentStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartAgentStateCount.Anchor")));
			this.chartAgentStateCount.AutoScroll = ((bool)(resources.GetObject("chartAgentStateCount.AutoScroll")));
			this.chartAgentStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartAgentStateCount.AutoScrollMargin")));
			this.chartAgentStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartAgentStateCount.AutoScrollMinSize")));
			this.chartAgentStateCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.BackgroundColor")));
			this.chartAgentStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartAgentStateCount.BackgroundImage")));
			curve11.Caption = resources.GetString("curve11.Caption");
			curve11.Color = ((System.Drawing.Color)(resources.GetObject("curve11.Color")));
			curve11.ContinuesLine = ((bool)(resources.GetObject("curve11.ContinuesLine")));
			curve11.MappingName = resources.GetString("curve11.MappingName");
			curve11.Visible = ((bool)(resources.GetObject("curve11.Visible")));
			curve12.Caption = resources.GetString("curve12.Caption");
			curve12.Color = ((System.Drawing.Color)(resources.GetObject("curve12.Color")));
			curve12.ContinuesLine = ((bool)(resources.GetObject("curve12.ContinuesLine")));
			curve12.MappingName = resources.GetString("curve12.MappingName");
			curve12.Visible = ((bool)(resources.GetObject("curve12.Visible")));
			curve13.Caption = resources.GetString("curve13.Caption");
			curve13.Color = ((System.Drawing.Color)(resources.GetObject("curve13.Color")));
			curve13.ContinuesLine = ((bool)(resources.GetObject("curve13.ContinuesLine")));
			curve13.MappingName = resources.GetString("curve13.MappingName");
			curve13.Visible = ((bool)(resources.GetObject("curve13.Visible")));
			curve14.Caption = resources.GetString("curve14.Caption");
			curve14.Color = ((System.Drawing.Color)(resources.GetObject("curve14.Color")));
			curve14.ContinuesLine = ((bool)(resources.GetObject("curve14.ContinuesLine")));
			curve14.MappingName = resources.GetString("curve14.MappingName");
			curve14.Visible = ((bool)(resources.GetObject("curve14.Visible")));
			curve15.Caption = resources.GetString("curve15.Caption");
			curve15.Color = ((System.Drawing.Color)(resources.GetObject("curve15.Color")));
			curve15.ContinuesLine = ((bool)(resources.GetObject("curve15.ContinuesLine")));
			curve15.MappingName = resources.GetString("curve15.MappingName");
			curve15.Visible = ((bool)(resources.GetObject("curve15.Visible")));
			curve16.Caption = resources.GetString("curve16.Caption");
			curve16.Color = ((System.Drawing.Color)(resources.GetObject("curve16.Color")));
			curve16.ContinuesLine = ((bool)(resources.GetObject("curve16.ContinuesLine")));
			curve16.MappingName = resources.GetString("curve16.MappingName");
			curve16.Visible = ((bool)(resources.GetObject("curve16.Visible")));
			curve17.Caption = resources.GetString("curve17.Caption");
			curve17.Color = ((System.Drawing.Color)(resources.GetObject("curve17.Color")));
			curve17.ContinuesLine = ((bool)(resources.GetObject("curve17.ContinuesLine")));
			curve17.MappingName = resources.GetString("curve17.MappingName");
			curve17.Visible = ((bool)(resources.GetObject("curve17.Visible")));
			curve18.Caption = resources.GetString("curve18.Caption");
			curve18.Color = ((System.Drawing.Color)(resources.GetObject("curve18.Color")));
			curve18.ContinuesLine = ((bool)(resources.GetObject("curve18.ContinuesLine")));
			curve18.MappingName = resources.GetString("curve18.MappingName");
			curve18.Visible = ((bool)(resources.GetObject("curve18.Visible")));
			curve19.Caption = resources.GetString("curve19.Caption");
			curve19.Color = ((System.Drawing.Color)(resources.GetObject("curve19.Color")));
			curve19.ContinuesLine = ((bool)(resources.GetObject("curve19.ContinuesLine")));
			curve19.MappingName = resources.GetString("curve19.MappingName");
			curve19.Visible = ((bool)(resources.GetObject("curve19.Visible")));
			curve20.Caption = resources.GetString("curve20.Caption");
			curve20.Color = ((System.Drawing.Color)(resources.GetObject("curve20.Color")));
			curve20.ContinuesLine = ((bool)(resources.GetObject("curve20.ContinuesLine")));
			curve20.MappingName = resources.GetString("curve20.MappingName");
			curve20.Visible = ((bool)(resources.GetObject("curve20.Visible")));
			curve21.Caption = resources.GetString("curve21.Caption");
			curve21.Color = ((System.Drawing.Color)(resources.GetObject("curve21.Color")));
			curve21.ContinuesLine = ((bool)(resources.GetObject("curve21.ContinuesLine")));
			curve21.MappingName = resources.GetString("curve21.MappingName");
			curve21.Visible = ((bool)(resources.GetObject("curve21.Visible")));
			this.chartAgentStateCount.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																							  curve11,
																							  curve12,
																							  curve13,
																							  curve14,
																							  curve15,
																							  curve16,
																							  curve17,
																							  curve18,
																							  curve19,
																							  curve20,
																							  curve21});
			this.chartAgentStateCount.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartAgentStateCount.DisplayedInterval")));
			this.chartAgentStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartAgentStateCount.Dock")));
			this.chartAgentStateCount.Enabled = ((bool)(resources.GetObject("chartAgentStateCount.Enabled")));
			this.chartAgentStateCount.Font = ((System.Drawing.Font)(resources.GetObject("chartAgentStateCount.Font")));
			this.chartAgentStateCount.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.FrameColor")));
			this.chartAgentStateCount.GridColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.GridColor")));
			this.chartAgentStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartAgentStateCount.ImeMode")));
			this.chartAgentStateCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartAgentStateCount.LegendAlignment")));
			this.chartAgentStateCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.LegendColor")));
			this.chartAgentStateCount.Location = ((System.Drawing.Point)(resources.GetObject("chartAgentStateCount.Location")));
			this.chartAgentStateCount.Name = "chartAgentStateCount";
			this.chartAgentStateCount.Painting = ((bool)(resources.GetObject("chartAgentStateCount.Painting")));
			this.chartAgentStateCount.RescaleRatio = ((System.Double)(resources.GetObject("chartAgentStateCount.RescaleRatio")));
			this.chartAgentStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartAgentStateCount.RightToLeft")));
			this.chartAgentStateCount.Size = ((System.Drawing.Size)(resources.GetObject("chartAgentStateCount.Size")));
			this.chartAgentStateCount.TabIndex = ((int)(resources.GetObject("chartAgentStateCount.TabIndex")));
			this.chartAgentStateCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.ValueColor")));
			this.chartAgentStateCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartAgentStateCount.ValueType")));
			this.chartAgentStateCount.Visible = ((bool)(resources.GetObject("chartAgentStateCount.Visible")));
			this.chartAgentStateCount.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.XLabelColor")));
			this.chartAgentStateCount.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartAgentStateCount.YLabelColor")));
			this.chartAgentStateCount.YMax = ((System.Double)(resources.GetObject("chartAgentStateCount.YMax")));
			this.chartAgentStateCount.YMaxScaling = ((bool)(resources.GetObject("chartAgentStateCount.YMaxScaling")));
			this.chartAgentStateCount.YMin = ((System.Double)(resources.GetObject("chartAgentStateCount.YMin")));
			this.chartAgentStateCount.YMinScaling = ((bool)(resources.GetObject("chartAgentStateCount.YMinScaling")));
			// 
			// groupBoxAgentStates
			// 
			this.groupBoxAgentStates.AccessibleDescription = resources.GetString("groupBoxAgentStates.AccessibleDescription");
			this.groupBoxAgentStates.AccessibleName = resources.GetString("groupBoxAgentStates.AccessibleName");
			this.groupBoxAgentStates.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxAgentStates.Anchor")));
			this.groupBoxAgentStates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxAgentStates.BackgroundImage")));
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCount);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesBottomLineGray);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesBottomLineWhite);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeWrapupTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeWrapupCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountWrapup);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountWrapupCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeConferencingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeConferencingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountConferencing);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountConferencingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeTalkingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeTalkingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountTalking);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountTalkingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeCallingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeCallingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountCalling);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountCallingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimePreparingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimePreparingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountPreparing);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountPreparingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeSignalingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeSignalingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountSignaling);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountSignalingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimePendingTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimePendingCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountPending);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountPendingCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeReadyTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeReadyCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountReady);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountReadyCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeNotReadyTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeNotReadyCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountNotReady);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountNotReadyCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeUnassignedTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateTimeUnassignedCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountUnassigned);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStateCountUnassignedCap);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesTopLineGray);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesTopLineWhite);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesRowTimeTtl);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesRowTimeCur);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesRowCount);
			this.groupBoxAgentStates.Controls.Add(this.labelAgentStatesRowState);
			this.groupBoxAgentStates.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxAgentStates.Dock")));
			this.groupBoxAgentStates.Enabled = ((bool)(resources.GetObject("groupBoxAgentStates.Enabled")));
			this.groupBoxAgentStates.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxAgentStates.Font")));
			this.groupBoxAgentStates.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxAgentStates.ImeMode")));
			this.groupBoxAgentStates.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxAgentStates.Location")));
			this.groupBoxAgentStates.Name = "groupBoxAgentStates";
			this.groupBoxAgentStates.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxAgentStates.RightToLeft")));
			this.groupBoxAgentStates.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxAgentStates.Size")));
			this.groupBoxAgentStates.TabIndex = ((int)(resources.GetObject("groupBoxAgentStates.TabIndex")));
			this.groupBoxAgentStates.TabStop = false;
			this.groupBoxAgentStates.Text = resources.GetString("groupBoxAgentStates.Text");
			this.groupBoxAgentStates.Visible = ((bool)(resources.GetObject("groupBoxAgentStates.Visible")));
			// 
			// labelAgentStateCount
			// 
			this.labelAgentStateCount.AccessibleDescription = resources.GetString("labelAgentStateCount.AccessibleDescription");
			this.labelAgentStateCount.AccessibleName = resources.GetString("labelAgentStateCount.AccessibleName");
			this.labelAgentStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCount.Anchor")));
			this.labelAgentStateCount.AutoSize = ((bool)(resources.GetObject("labelAgentStateCount.AutoSize")));
			this.labelAgentStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCount.Dock")));
			this.labelAgentStateCount.Enabled = ((bool)(resources.GetObject("labelAgentStateCount.Enabled")));
			this.labelAgentStateCount.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCount.Font")));
			this.labelAgentStateCount.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCount.Image")));
			this.labelAgentStateCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCount.ImageAlign")));
			this.labelAgentStateCount.ImageIndex = ((int)(resources.GetObject("labelAgentStateCount.ImageIndex")));
			this.labelAgentStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCount.ImeMode")));
			this.labelAgentStateCount.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCount.Location")));
			this.labelAgentStateCount.Name = "labelAgentStateCount";
			this.labelAgentStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCount.RightToLeft")));
			this.labelAgentStateCount.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCount.Size")));
			this.labelAgentStateCount.TabIndex = ((int)(resources.GetObject("labelAgentStateCount.TabIndex")));
			this.labelAgentStateCount.Text = resources.GetString("labelAgentStateCount.Text");
			this.labelAgentStateCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCount.TextAlign")));
			this.labelAgentStateCount.Visible = ((bool)(resources.GetObject("labelAgentStateCount.Visible")));
			// 
			// labelAgentStateCountCap
			// 
			this.labelAgentStateCountCap.AccessibleDescription = resources.GetString("labelAgentStateCountCap.AccessibleDescription");
			this.labelAgentStateCountCap.AccessibleName = resources.GetString("labelAgentStateCountCap.AccessibleName");
			this.labelAgentStateCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountCap.Anchor")));
			this.labelAgentStateCountCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountCap.AutoSize")));
			this.labelAgentStateCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountCap.Dock")));
			this.labelAgentStateCountCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountCap.Enabled")));
			this.labelAgentStateCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountCap.Font")));
			this.labelAgentStateCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountCap.Image")));
			this.labelAgentStateCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCap.ImageAlign")));
			this.labelAgentStateCountCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountCap.ImageIndex")));
			this.labelAgentStateCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountCap.ImeMode")));
			this.labelAgentStateCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountCap.Location")));
			this.labelAgentStateCountCap.Name = "labelAgentStateCountCap";
			this.labelAgentStateCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountCap.RightToLeft")));
			this.labelAgentStateCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountCap.Size")));
			this.labelAgentStateCountCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountCap.TabIndex")));
			this.labelAgentStateCountCap.Text = resources.GetString("labelAgentStateCountCap.Text");
			this.labelAgentStateCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCap.TextAlign")));
			this.labelAgentStateCountCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountCap.Visible")));
			// 
			// labelAgentStatesBottomLineGray
			// 
			this.labelAgentStatesBottomLineGray.AccessibleDescription = resources.GetString("labelAgentStatesBottomLineGray.AccessibleDescription");
			this.labelAgentStatesBottomLineGray.AccessibleName = resources.GetString("labelAgentStatesBottomLineGray.AccessibleName");
			this.labelAgentStatesBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesBottomLineGray.Anchor")));
			this.labelAgentStatesBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelAgentStatesBottomLineGray.AutoSize")));
			this.labelAgentStatesBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelAgentStatesBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesBottomLineGray.Dock")));
			this.labelAgentStatesBottomLineGray.Enabled = ((bool)(resources.GetObject("labelAgentStatesBottomLineGray.Enabled")));
			this.labelAgentStatesBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesBottomLineGray.Font")));
			this.labelAgentStatesBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentStatesBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesBottomLineGray.Image")));
			this.labelAgentStatesBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesBottomLineGray.ImageAlign")));
			this.labelAgentStatesBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelAgentStatesBottomLineGray.ImageIndex")));
			this.labelAgentStatesBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesBottomLineGray.ImeMode")));
			this.labelAgentStatesBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesBottomLineGray.Location")));
			this.labelAgentStatesBottomLineGray.Name = "labelAgentStatesBottomLineGray";
			this.labelAgentStatesBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesBottomLineGray.RightToLeft")));
			this.labelAgentStatesBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesBottomLineGray.Size")));
			this.labelAgentStatesBottomLineGray.TabIndex = ((int)(resources.GetObject("labelAgentStatesBottomLineGray.TabIndex")));
			this.labelAgentStatesBottomLineGray.Text = resources.GetString("labelAgentStatesBottomLineGray.Text");
			this.labelAgentStatesBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesBottomLineGray.TextAlign")));
			this.labelAgentStatesBottomLineGray.Visible = ((bool)(resources.GetObject("labelAgentStatesBottomLineGray.Visible")));
			// 
			// labelAgentStatesBottomLineWhite
			// 
			this.labelAgentStatesBottomLineWhite.AccessibleDescription = resources.GetString("labelAgentStatesBottomLineWhite.AccessibleDescription");
			this.labelAgentStatesBottomLineWhite.AccessibleName = resources.GetString("labelAgentStatesBottomLineWhite.AccessibleName");
			this.labelAgentStatesBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesBottomLineWhite.Anchor")));
			this.labelAgentStatesBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelAgentStatesBottomLineWhite.AutoSize")));
			this.labelAgentStatesBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelAgentStatesBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesBottomLineWhite.Dock")));
			this.labelAgentStatesBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelAgentStatesBottomLineWhite.Enabled")));
			this.labelAgentStatesBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesBottomLineWhite.Font")));
			this.labelAgentStatesBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentStatesBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesBottomLineWhite.Image")));
			this.labelAgentStatesBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesBottomLineWhite.ImageAlign")));
			this.labelAgentStatesBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelAgentStatesBottomLineWhite.ImageIndex")));
			this.labelAgentStatesBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesBottomLineWhite.ImeMode")));
			this.labelAgentStatesBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesBottomLineWhite.Location")));
			this.labelAgentStatesBottomLineWhite.Name = "labelAgentStatesBottomLineWhite";
			this.labelAgentStatesBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesBottomLineWhite.RightToLeft")));
			this.labelAgentStatesBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesBottomLineWhite.Size")));
			this.labelAgentStatesBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelAgentStatesBottomLineWhite.TabIndex")));
			this.labelAgentStatesBottomLineWhite.Text = resources.GetString("labelAgentStatesBottomLineWhite.Text");
			this.labelAgentStatesBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesBottomLineWhite.TextAlign")));
			this.labelAgentStatesBottomLineWhite.Visible = ((bool)(resources.GetObject("labelAgentStatesBottomLineWhite.Visible")));
			// 
			// labelAgentStateTimeWrapupTtl
			// 
			this.labelAgentStateTimeWrapupTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeWrapupTtl.AccessibleDescription");
			this.labelAgentStateTimeWrapupTtl.AccessibleName = resources.GetString("labelAgentStateTimeWrapupTtl.AccessibleName");
			this.labelAgentStateTimeWrapupTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeWrapupTtl.Anchor")));
			this.labelAgentStateTimeWrapupTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeWrapupTtl.AutoSize")));
			this.labelAgentStateTimeWrapupTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeWrapupTtl.Dock")));
			this.labelAgentStateTimeWrapupTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeWrapupTtl.Enabled")));
			this.labelAgentStateTimeWrapupTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeWrapupTtl.Font")));
			this.labelAgentStateTimeWrapupTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeWrapupTtl.Image")));
			this.labelAgentStateTimeWrapupTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeWrapupTtl.ImageAlign")));
			this.labelAgentStateTimeWrapupTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeWrapupTtl.ImageIndex")));
			this.labelAgentStateTimeWrapupTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeWrapupTtl.ImeMode")));
			this.labelAgentStateTimeWrapupTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeWrapupTtl.Location")));
			this.labelAgentStateTimeWrapupTtl.Name = "labelAgentStateTimeWrapupTtl";
			this.labelAgentStateTimeWrapupTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeWrapupTtl.RightToLeft")));
			this.labelAgentStateTimeWrapupTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeWrapupTtl.Size")));
			this.labelAgentStateTimeWrapupTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeWrapupTtl.TabIndex")));
			this.labelAgentStateTimeWrapupTtl.Text = resources.GetString("labelAgentStateTimeWrapupTtl.Text");
			this.labelAgentStateTimeWrapupTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeWrapupTtl.TextAlign")));
			this.labelAgentStateTimeWrapupTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeWrapupTtl.Visible")));
			// 
			// labelAgentStateTimeWrapupCur
			// 
			this.labelAgentStateTimeWrapupCur.AccessibleDescription = resources.GetString("labelAgentStateTimeWrapupCur.AccessibleDescription");
			this.labelAgentStateTimeWrapupCur.AccessibleName = resources.GetString("labelAgentStateTimeWrapupCur.AccessibleName");
			this.labelAgentStateTimeWrapupCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeWrapupCur.Anchor")));
			this.labelAgentStateTimeWrapupCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeWrapupCur.AutoSize")));
			this.labelAgentStateTimeWrapupCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeWrapupCur.Dock")));
			this.labelAgentStateTimeWrapupCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeWrapupCur.Enabled")));
			this.labelAgentStateTimeWrapupCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeWrapupCur.Font")));
			this.labelAgentStateTimeWrapupCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeWrapupCur.Image")));
			this.labelAgentStateTimeWrapupCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeWrapupCur.ImageAlign")));
			this.labelAgentStateTimeWrapupCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeWrapupCur.ImageIndex")));
			this.labelAgentStateTimeWrapupCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeWrapupCur.ImeMode")));
			this.labelAgentStateTimeWrapupCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeWrapupCur.Location")));
			this.labelAgentStateTimeWrapupCur.Name = "labelAgentStateTimeWrapupCur";
			this.labelAgentStateTimeWrapupCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeWrapupCur.RightToLeft")));
			this.labelAgentStateTimeWrapupCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeWrapupCur.Size")));
			this.labelAgentStateTimeWrapupCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeWrapupCur.TabIndex")));
			this.labelAgentStateTimeWrapupCur.Text = resources.GetString("labelAgentStateTimeWrapupCur.Text");
			this.labelAgentStateTimeWrapupCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeWrapupCur.TextAlign")));
			this.labelAgentStateTimeWrapupCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeWrapupCur.Visible")));
			// 
			// labelAgentStateCountWrapup
			// 
			this.labelAgentStateCountWrapup.AccessibleDescription = resources.GetString("labelAgentStateCountWrapup.AccessibleDescription");
			this.labelAgentStateCountWrapup.AccessibleName = resources.GetString("labelAgentStateCountWrapup.AccessibleName");
			this.labelAgentStateCountWrapup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountWrapup.Anchor")));
			this.labelAgentStateCountWrapup.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountWrapup.AutoSize")));
			this.labelAgentStateCountWrapup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountWrapup.Dock")));
			this.labelAgentStateCountWrapup.Enabled = ((bool)(resources.GetObject("labelAgentStateCountWrapup.Enabled")));
			this.labelAgentStateCountWrapup.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountWrapup.Font")));
			this.labelAgentStateCountWrapup.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountWrapup.Image")));
			this.labelAgentStateCountWrapup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountWrapup.ImageAlign")));
			this.labelAgentStateCountWrapup.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountWrapup.ImageIndex")));
			this.labelAgentStateCountWrapup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountWrapup.ImeMode")));
			this.labelAgentStateCountWrapup.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountWrapup.Location")));
			this.labelAgentStateCountWrapup.Name = "labelAgentStateCountWrapup";
			this.labelAgentStateCountWrapup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountWrapup.RightToLeft")));
			this.labelAgentStateCountWrapup.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountWrapup.Size")));
			this.labelAgentStateCountWrapup.TabIndex = ((int)(resources.GetObject("labelAgentStateCountWrapup.TabIndex")));
			this.labelAgentStateCountWrapup.Text = resources.GetString("labelAgentStateCountWrapup.Text");
			this.labelAgentStateCountWrapup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountWrapup.TextAlign")));
			this.labelAgentStateCountWrapup.Visible = ((bool)(resources.GetObject("labelAgentStateCountWrapup.Visible")));
			// 
			// labelAgentStateCountWrapupCap
			// 
			this.labelAgentStateCountWrapupCap.AccessibleDescription = resources.GetString("labelAgentStateCountWrapupCap.AccessibleDescription");
			this.labelAgentStateCountWrapupCap.AccessibleName = resources.GetString("labelAgentStateCountWrapupCap.AccessibleName");
			this.labelAgentStateCountWrapupCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountWrapupCap.Anchor")));
			this.labelAgentStateCountWrapupCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountWrapupCap.AutoSize")));
			this.labelAgentStateCountWrapupCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountWrapupCap.Dock")));
			this.labelAgentStateCountWrapupCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountWrapupCap.Enabled")));
			this.labelAgentStateCountWrapupCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountWrapupCap.Font")));
			this.labelAgentStateCountWrapupCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountWrapupCap.Image")));
			this.labelAgentStateCountWrapupCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountWrapupCap.ImageAlign")));
			this.labelAgentStateCountWrapupCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountWrapupCap.ImageIndex")));
			this.labelAgentStateCountWrapupCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountWrapupCap.ImeMode")));
			this.labelAgentStateCountWrapupCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountWrapupCap.Location")));
			this.labelAgentStateCountWrapupCap.Name = "labelAgentStateCountWrapupCap";
			this.labelAgentStateCountWrapupCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountWrapupCap.RightToLeft")));
			this.labelAgentStateCountWrapupCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountWrapupCap.Size")));
			this.labelAgentStateCountWrapupCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountWrapupCap.TabIndex")));
			this.labelAgentStateCountWrapupCap.Text = resources.GetString("labelAgentStateCountWrapupCap.Text");
			this.labelAgentStateCountWrapupCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountWrapupCap.TextAlign")));
			this.labelAgentStateCountWrapupCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountWrapupCap.Visible")));
			// 
			// labelAgentStateTimeConferencingTtl
			// 
			this.labelAgentStateTimeConferencingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeConferencingTtl.AccessibleDescription");
			this.labelAgentStateTimeConferencingTtl.AccessibleName = resources.GetString("labelAgentStateTimeConferencingTtl.AccessibleName");
			this.labelAgentStateTimeConferencingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeConferencingTtl.Anchor")));
			this.labelAgentStateTimeConferencingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeConferencingTtl.AutoSize")));
			this.labelAgentStateTimeConferencingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeConferencingTtl.Dock")));
			this.labelAgentStateTimeConferencingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeConferencingTtl.Enabled")));
			this.labelAgentStateTimeConferencingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeConferencingTtl.Font")));
			this.labelAgentStateTimeConferencingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeConferencingTtl.Image")));
			this.labelAgentStateTimeConferencingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeConferencingTtl.ImageAlign")));
			this.labelAgentStateTimeConferencingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeConferencingTtl.ImageIndex")));
			this.labelAgentStateTimeConferencingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeConferencingTtl.ImeMode")));
			this.labelAgentStateTimeConferencingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeConferencingTtl.Location")));
			this.labelAgentStateTimeConferencingTtl.Name = "labelAgentStateTimeConferencingTtl";
			this.labelAgentStateTimeConferencingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeConferencingTtl.RightToLeft")));
			this.labelAgentStateTimeConferencingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeConferencingTtl.Size")));
			this.labelAgentStateTimeConferencingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeConferencingTtl.TabIndex")));
			this.labelAgentStateTimeConferencingTtl.Text = resources.GetString("labelAgentStateTimeConferencingTtl.Text");
			this.labelAgentStateTimeConferencingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeConferencingTtl.TextAlign")));
			this.labelAgentStateTimeConferencingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeConferencingTtl.Visible")));
			// 
			// labelAgentStateTimeConferencingCur
			// 
			this.labelAgentStateTimeConferencingCur.AccessibleDescription = resources.GetString("labelAgentStateTimeConferencingCur.AccessibleDescription");
			this.labelAgentStateTimeConferencingCur.AccessibleName = resources.GetString("labelAgentStateTimeConferencingCur.AccessibleName");
			this.labelAgentStateTimeConferencingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeConferencingCur.Anchor")));
			this.labelAgentStateTimeConferencingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeConferencingCur.AutoSize")));
			this.labelAgentStateTimeConferencingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeConferencingCur.Dock")));
			this.labelAgentStateTimeConferencingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeConferencingCur.Enabled")));
			this.labelAgentStateTimeConferencingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeConferencingCur.Font")));
			this.labelAgentStateTimeConferencingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeConferencingCur.Image")));
			this.labelAgentStateTimeConferencingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeConferencingCur.ImageAlign")));
			this.labelAgentStateTimeConferencingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeConferencingCur.ImageIndex")));
			this.labelAgentStateTimeConferencingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeConferencingCur.ImeMode")));
			this.labelAgentStateTimeConferencingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeConferencingCur.Location")));
			this.labelAgentStateTimeConferencingCur.Name = "labelAgentStateTimeConferencingCur";
			this.labelAgentStateTimeConferencingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeConferencingCur.RightToLeft")));
			this.labelAgentStateTimeConferencingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeConferencingCur.Size")));
			this.labelAgentStateTimeConferencingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeConferencingCur.TabIndex")));
			this.labelAgentStateTimeConferencingCur.Text = resources.GetString("labelAgentStateTimeConferencingCur.Text");
			this.labelAgentStateTimeConferencingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeConferencingCur.TextAlign")));
			this.labelAgentStateTimeConferencingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeConferencingCur.Visible")));
			// 
			// labelAgentStateCountConferencing
			// 
			this.labelAgentStateCountConferencing.AccessibleDescription = resources.GetString("labelAgentStateCountConferencing.AccessibleDescription");
			this.labelAgentStateCountConferencing.AccessibleName = resources.GetString("labelAgentStateCountConferencing.AccessibleName");
			this.labelAgentStateCountConferencing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountConferencing.Anchor")));
			this.labelAgentStateCountConferencing.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountConferencing.AutoSize")));
			this.labelAgentStateCountConferencing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountConferencing.Dock")));
			this.labelAgentStateCountConferencing.Enabled = ((bool)(resources.GetObject("labelAgentStateCountConferencing.Enabled")));
			this.labelAgentStateCountConferencing.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountConferencing.Font")));
			this.labelAgentStateCountConferencing.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountConferencing.Image")));
			this.labelAgentStateCountConferencing.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountConferencing.ImageAlign")));
			this.labelAgentStateCountConferencing.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountConferencing.ImageIndex")));
			this.labelAgentStateCountConferencing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountConferencing.ImeMode")));
			this.labelAgentStateCountConferencing.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountConferencing.Location")));
			this.labelAgentStateCountConferencing.Name = "labelAgentStateCountConferencing";
			this.labelAgentStateCountConferencing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountConferencing.RightToLeft")));
			this.labelAgentStateCountConferencing.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountConferencing.Size")));
			this.labelAgentStateCountConferencing.TabIndex = ((int)(resources.GetObject("labelAgentStateCountConferencing.TabIndex")));
			this.labelAgentStateCountConferencing.Text = resources.GetString("labelAgentStateCountConferencing.Text");
			this.labelAgentStateCountConferencing.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountConferencing.TextAlign")));
			this.labelAgentStateCountConferencing.Visible = ((bool)(resources.GetObject("labelAgentStateCountConferencing.Visible")));
			// 
			// labelAgentStateCountConferencingCap
			// 
			this.labelAgentStateCountConferencingCap.AccessibleDescription = resources.GetString("labelAgentStateCountConferencingCap.AccessibleDescription");
			this.labelAgentStateCountConferencingCap.AccessibleName = resources.GetString("labelAgentStateCountConferencingCap.AccessibleName");
			this.labelAgentStateCountConferencingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountConferencingCap.Anchor")));
			this.labelAgentStateCountConferencingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountConferencingCap.AutoSize")));
			this.labelAgentStateCountConferencingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountConferencingCap.Dock")));
			this.labelAgentStateCountConferencingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountConferencingCap.Enabled")));
			this.labelAgentStateCountConferencingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountConferencingCap.Font")));
			this.labelAgentStateCountConferencingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountConferencingCap.Image")));
			this.labelAgentStateCountConferencingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountConferencingCap.ImageAlign")));
			this.labelAgentStateCountConferencingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountConferencingCap.ImageIndex")));
			this.labelAgentStateCountConferencingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountConferencingCap.ImeMode")));
			this.labelAgentStateCountConferencingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountConferencingCap.Location")));
			this.labelAgentStateCountConferencingCap.Name = "labelAgentStateCountConferencingCap";
			this.labelAgentStateCountConferencingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountConferencingCap.RightToLeft")));
			this.labelAgentStateCountConferencingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountConferencingCap.Size")));
			this.labelAgentStateCountConferencingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountConferencingCap.TabIndex")));
			this.labelAgentStateCountConferencingCap.Text = resources.GetString("labelAgentStateCountConferencingCap.Text");
			this.labelAgentStateCountConferencingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountConferencingCap.TextAlign")));
			this.labelAgentStateCountConferencingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountConferencingCap.Visible")));
			// 
			// labelAgentStateTimeTalkingTtl
			// 
			this.labelAgentStateTimeTalkingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeTalkingTtl.AccessibleDescription");
			this.labelAgentStateTimeTalkingTtl.AccessibleName = resources.GetString("labelAgentStateTimeTalkingTtl.AccessibleName");
			this.labelAgentStateTimeTalkingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeTalkingTtl.Anchor")));
			this.labelAgentStateTimeTalkingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeTalkingTtl.AutoSize")));
			this.labelAgentStateTimeTalkingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeTalkingTtl.Dock")));
			this.labelAgentStateTimeTalkingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeTalkingTtl.Enabled")));
			this.labelAgentStateTimeTalkingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeTalkingTtl.Font")));
			this.labelAgentStateTimeTalkingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeTalkingTtl.Image")));
			this.labelAgentStateTimeTalkingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeTalkingTtl.ImageAlign")));
			this.labelAgentStateTimeTalkingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeTalkingTtl.ImageIndex")));
			this.labelAgentStateTimeTalkingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeTalkingTtl.ImeMode")));
			this.labelAgentStateTimeTalkingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeTalkingTtl.Location")));
			this.labelAgentStateTimeTalkingTtl.Name = "labelAgentStateTimeTalkingTtl";
			this.labelAgentStateTimeTalkingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeTalkingTtl.RightToLeft")));
			this.labelAgentStateTimeTalkingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeTalkingTtl.Size")));
			this.labelAgentStateTimeTalkingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeTalkingTtl.TabIndex")));
			this.labelAgentStateTimeTalkingTtl.Text = resources.GetString("labelAgentStateTimeTalkingTtl.Text");
			this.labelAgentStateTimeTalkingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeTalkingTtl.TextAlign")));
			this.labelAgentStateTimeTalkingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeTalkingTtl.Visible")));
			// 
			// labelAgentStateTimeTalkingCur
			// 
			this.labelAgentStateTimeTalkingCur.AccessibleDescription = resources.GetString("labelAgentStateTimeTalkingCur.AccessibleDescription");
			this.labelAgentStateTimeTalkingCur.AccessibleName = resources.GetString("labelAgentStateTimeTalkingCur.AccessibleName");
			this.labelAgentStateTimeTalkingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeTalkingCur.Anchor")));
			this.labelAgentStateTimeTalkingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeTalkingCur.AutoSize")));
			this.labelAgentStateTimeTalkingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeTalkingCur.Dock")));
			this.labelAgentStateTimeTalkingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeTalkingCur.Enabled")));
			this.labelAgentStateTimeTalkingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeTalkingCur.Font")));
			this.labelAgentStateTimeTalkingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeTalkingCur.Image")));
			this.labelAgentStateTimeTalkingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeTalkingCur.ImageAlign")));
			this.labelAgentStateTimeTalkingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeTalkingCur.ImageIndex")));
			this.labelAgentStateTimeTalkingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeTalkingCur.ImeMode")));
			this.labelAgentStateTimeTalkingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeTalkingCur.Location")));
			this.labelAgentStateTimeTalkingCur.Name = "labelAgentStateTimeTalkingCur";
			this.labelAgentStateTimeTalkingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeTalkingCur.RightToLeft")));
			this.labelAgentStateTimeTalkingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeTalkingCur.Size")));
			this.labelAgentStateTimeTalkingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeTalkingCur.TabIndex")));
			this.labelAgentStateTimeTalkingCur.Text = resources.GetString("labelAgentStateTimeTalkingCur.Text");
			this.labelAgentStateTimeTalkingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeTalkingCur.TextAlign")));
			this.labelAgentStateTimeTalkingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeTalkingCur.Visible")));
			// 
			// labelAgentStateCountTalking
			// 
			this.labelAgentStateCountTalking.AccessibleDescription = resources.GetString("labelAgentStateCountTalking.AccessibleDescription");
			this.labelAgentStateCountTalking.AccessibleName = resources.GetString("labelAgentStateCountTalking.AccessibleName");
			this.labelAgentStateCountTalking.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountTalking.Anchor")));
			this.labelAgentStateCountTalking.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountTalking.AutoSize")));
			this.labelAgentStateCountTalking.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountTalking.Dock")));
			this.labelAgentStateCountTalking.Enabled = ((bool)(resources.GetObject("labelAgentStateCountTalking.Enabled")));
			this.labelAgentStateCountTalking.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountTalking.Font")));
			this.labelAgentStateCountTalking.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountTalking.Image")));
			this.labelAgentStateCountTalking.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountTalking.ImageAlign")));
			this.labelAgentStateCountTalking.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountTalking.ImageIndex")));
			this.labelAgentStateCountTalking.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountTalking.ImeMode")));
			this.labelAgentStateCountTalking.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountTalking.Location")));
			this.labelAgentStateCountTalking.Name = "labelAgentStateCountTalking";
			this.labelAgentStateCountTalking.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountTalking.RightToLeft")));
			this.labelAgentStateCountTalking.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountTalking.Size")));
			this.labelAgentStateCountTalking.TabIndex = ((int)(resources.GetObject("labelAgentStateCountTalking.TabIndex")));
			this.labelAgentStateCountTalking.Text = resources.GetString("labelAgentStateCountTalking.Text");
			this.labelAgentStateCountTalking.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountTalking.TextAlign")));
			this.labelAgentStateCountTalking.Visible = ((bool)(resources.GetObject("labelAgentStateCountTalking.Visible")));
			// 
			// labelAgentStateCountTalkingCap
			// 
			this.labelAgentStateCountTalkingCap.AccessibleDescription = resources.GetString("labelAgentStateCountTalkingCap.AccessibleDescription");
			this.labelAgentStateCountTalkingCap.AccessibleName = resources.GetString("labelAgentStateCountTalkingCap.AccessibleName");
			this.labelAgentStateCountTalkingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountTalkingCap.Anchor")));
			this.labelAgentStateCountTalkingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountTalkingCap.AutoSize")));
			this.labelAgentStateCountTalkingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountTalkingCap.Dock")));
			this.labelAgentStateCountTalkingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountTalkingCap.Enabled")));
			this.labelAgentStateCountTalkingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountTalkingCap.Font")));
			this.labelAgentStateCountTalkingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountTalkingCap.Image")));
			this.labelAgentStateCountTalkingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountTalkingCap.ImageAlign")));
			this.labelAgentStateCountTalkingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountTalkingCap.ImageIndex")));
			this.labelAgentStateCountTalkingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountTalkingCap.ImeMode")));
			this.labelAgentStateCountTalkingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountTalkingCap.Location")));
			this.labelAgentStateCountTalkingCap.Name = "labelAgentStateCountTalkingCap";
			this.labelAgentStateCountTalkingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountTalkingCap.RightToLeft")));
			this.labelAgentStateCountTalkingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountTalkingCap.Size")));
			this.labelAgentStateCountTalkingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountTalkingCap.TabIndex")));
			this.labelAgentStateCountTalkingCap.Text = resources.GetString("labelAgentStateCountTalkingCap.Text");
			this.labelAgentStateCountTalkingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountTalkingCap.TextAlign")));
			this.labelAgentStateCountTalkingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountTalkingCap.Visible")));
			// 
			// labelAgentStateTimeCallingTtl
			// 
			this.labelAgentStateTimeCallingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeCallingTtl.AccessibleDescription");
			this.labelAgentStateTimeCallingTtl.AccessibleName = resources.GetString("labelAgentStateTimeCallingTtl.AccessibleName");
			this.labelAgentStateTimeCallingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeCallingTtl.Anchor")));
			this.labelAgentStateTimeCallingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeCallingTtl.AutoSize")));
			this.labelAgentStateTimeCallingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeCallingTtl.Dock")));
			this.labelAgentStateTimeCallingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeCallingTtl.Enabled")));
			this.labelAgentStateTimeCallingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeCallingTtl.Font")));
			this.labelAgentStateTimeCallingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeCallingTtl.Image")));
			this.labelAgentStateTimeCallingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeCallingTtl.ImageAlign")));
			this.labelAgentStateTimeCallingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeCallingTtl.ImageIndex")));
			this.labelAgentStateTimeCallingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeCallingTtl.ImeMode")));
			this.labelAgentStateTimeCallingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeCallingTtl.Location")));
			this.labelAgentStateTimeCallingTtl.Name = "labelAgentStateTimeCallingTtl";
			this.labelAgentStateTimeCallingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeCallingTtl.RightToLeft")));
			this.labelAgentStateTimeCallingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeCallingTtl.Size")));
			this.labelAgentStateTimeCallingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeCallingTtl.TabIndex")));
			this.labelAgentStateTimeCallingTtl.Text = resources.GetString("labelAgentStateTimeCallingTtl.Text");
			this.labelAgentStateTimeCallingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeCallingTtl.TextAlign")));
			this.labelAgentStateTimeCallingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeCallingTtl.Visible")));
			// 
			// labelAgentStateTimeCallingCur
			// 
			this.labelAgentStateTimeCallingCur.AccessibleDescription = resources.GetString("labelAgentStateTimeCallingCur.AccessibleDescription");
			this.labelAgentStateTimeCallingCur.AccessibleName = resources.GetString("labelAgentStateTimeCallingCur.AccessibleName");
			this.labelAgentStateTimeCallingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeCallingCur.Anchor")));
			this.labelAgentStateTimeCallingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeCallingCur.AutoSize")));
			this.labelAgentStateTimeCallingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeCallingCur.Dock")));
			this.labelAgentStateTimeCallingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeCallingCur.Enabled")));
			this.labelAgentStateTimeCallingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeCallingCur.Font")));
			this.labelAgentStateTimeCallingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeCallingCur.Image")));
			this.labelAgentStateTimeCallingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeCallingCur.ImageAlign")));
			this.labelAgentStateTimeCallingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeCallingCur.ImageIndex")));
			this.labelAgentStateTimeCallingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeCallingCur.ImeMode")));
			this.labelAgentStateTimeCallingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeCallingCur.Location")));
			this.labelAgentStateTimeCallingCur.Name = "labelAgentStateTimeCallingCur";
			this.labelAgentStateTimeCallingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeCallingCur.RightToLeft")));
			this.labelAgentStateTimeCallingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeCallingCur.Size")));
			this.labelAgentStateTimeCallingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeCallingCur.TabIndex")));
			this.labelAgentStateTimeCallingCur.Text = resources.GetString("labelAgentStateTimeCallingCur.Text");
			this.labelAgentStateTimeCallingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeCallingCur.TextAlign")));
			this.labelAgentStateTimeCallingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeCallingCur.Visible")));
			// 
			// labelAgentStateCountCalling
			// 
			this.labelAgentStateCountCalling.AccessibleDescription = resources.GetString("labelAgentStateCountCalling.AccessibleDescription");
			this.labelAgentStateCountCalling.AccessibleName = resources.GetString("labelAgentStateCountCalling.AccessibleName");
			this.labelAgentStateCountCalling.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountCalling.Anchor")));
			this.labelAgentStateCountCalling.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountCalling.AutoSize")));
			this.labelAgentStateCountCalling.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountCalling.Dock")));
			this.labelAgentStateCountCalling.Enabled = ((bool)(resources.GetObject("labelAgentStateCountCalling.Enabled")));
			this.labelAgentStateCountCalling.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountCalling.Font")));
			this.labelAgentStateCountCalling.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountCalling.Image")));
			this.labelAgentStateCountCalling.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCalling.ImageAlign")));
			this.labelAgentStateCountCalling.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountCalling.ImageIndex")));
			this.labelAgentStateCountCalling.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountCalling.ImeMode")));
			this.labelAgentStateCountCalling.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountCalling.Location")));
			this.labelAgentStateCountCalling.Name = "labelAgentStateCountCalling";
			this.labelAgentStateCountCalling.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountCalling.RightToLeft")));
			this.labelAgentStateCountCalling.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountCalling.Size")));
			this.labelAgentStateCountCalling.TabIndex = ((int)(resources.GetObject("labelAgentStateCountCalling.TabIndex")));
			this.labelAgentStateCountCalling.Text = resources.GetString("labelAgentStateCountCalling.Text");
			this.labelAgentStateCountCalling.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCalling.TextAlign")));
			this.labelAgentStateCountCalling.Visible = ((bool)(resources.GetObject("labelAgentStateCountCalling.Visible")));
			// 
			// labelAgentStateCountCallingCap
			// 
			this.labelAgentStateCountCallingCap.AccessibleDescription = resources.GetString("labelAgentStateCountCallingCap.AccessibleDescription");
			this.labelAgentStateCountCallingCap.AccessibleName = resources.GetString("labelAgentStateCountCallingCap.AccessibleName");
			this.labelAgentStateCountCallingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountCallingCap.Anchor")));
			this.labelAgentStateCountCallingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountCallingCap.AutoSize")));
			this.labelAgentStateCountCallingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountCallingCap.Dock")));
			this.labelAgentStateCountCallingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountCallingCap.Enabled")));
			this.labelAgentStateCountCallingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountCallingCap.Font")));
			this.labelAgentStateCountCallingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountCallingCap.Image")));
			this.labelAgentStateCountCallingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCallingCap.ImageAlign")));
			this.labelAgentStateCountCallingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountCallingCap.ImageIndex")));
			this.labelAgentStateCountCallingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountCallingCap.ImeMode")));
			this.labelAgentStateCountCallingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountCallingCap.Location")));
			this.labelAgentStateCountCallingCap.Name = "labelAgentStateCountCallingCap";
			this.labelAgentStateCountCallingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountCallingCap.RightToLeft")));
			this.labelAgentStateCountCallingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountCallingCap.Size")));
			this.labelAgentStateCountCallingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountCallingCap.TabIndex")));
			this.labelAgentStateCountCallingCap.Text = resources.GetString("labelAgentStateCountCallingCap.Text");
			this.labelAgentStateCountCallingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountCallingCap.TextAlign")));
			this.labelAgentStateCountCallingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountCallingCap.Visible")));
			// 
			// labelAgentStateTimePreparingTtl
			// 
			this.labelAgentStateTimePreparingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimePreparingTtl.AccessibleDescription");
			this.labelAgentStateTimePreparingTtl.AccessibleName = resources.GetString("labelAgentStateTimePreparingTtl.AccessibleName");
			this.labelAgentStateTimePreparingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimePreparingTtl.Anchor")));
			this.labelAgentStateTimePreparingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimePreparingTtl.AutoSize")));
			this.labelAgentStateTimePreparingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimePreparingTtl.Dock")));
			this.labelAgentStateTimePreparingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimePreparingTtl.Enabled")));
			this.labelAgentStateTimePreparingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimePreparingTtl.Font")));
			this.labelAgentStateTimePreparingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimePreparingTtl.Image")));
			this.labelAgentStateTimePreparingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePreparingTtl.ImageAlign")));
			this.labelAgentStateTimePreparingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimePreparingTtl.ImageIndex")));
			this.labelAgentStateTimePreparingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimePreparingTtl.ImeMode")));
			this.labelAgentStateTimePreparingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimePreparingTtl.Location")));
			this.labelAgentStateTimePreparingTtl.Name = "labelAgentStateTimePreparingTtl";
			this.labelAgentStateTimePreparingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimePreparingTtl.RightToLeft")));
			this.labelAgentStateTimePreparingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimePreparingTtl.Size")));
			this.labelAgentStateTimePreparingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimePreparingTtl.TabIndex")));
			this.labelAgentStateTimePreparingTtl.Text = resources.GetString("labelAgentStateTimePreparingTtl.Text");
			this.labelAgentStateTimePreparingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePreparingTtl.TextAlign")));
			this.labelAgentStateTimePreparingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimePreparingTtl.Visible")));
			// 
			// labelAgentStateTimePreparingCur
			// 
			this.labelAgentStateTimePreparingCur.AccessibleDescription = resources.GetString("labelAgentStateTimePreparingCur.AccessibleDescription");
			this.labelAgentStateTimePreparingCur.AccessibleName = resources.GetString("labelAgentStateTimePreparingCur.AccessibleName");
			this.labelAgentStateTimePreparingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimePreparingCur.Anchor")));
			this.labelAgentStateTimePreparingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimePreparingCur.AutoSize")));
			this.labelAgentStateTimePreparingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimePreparingCur.Dock")));
			this.labelAgentStateTimePreparingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimePreparingCur.Enabled")));
			this.labelAgentStateTimePreparingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimePreparingCur.Font")));
			this.labelAgentStateTimePreparingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimePreparingCur.Image")));
			this.labelAgentStateTimePreparingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePreparingCur.ImageAlign")));
			this.labelAgentStateTimePreparingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimePreparingCur.ImageIndex")));
			this.labelAgentStateTimePreparingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimePreparingCur.ImeMode")));
			this.labelAgentStateTimePreparingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimePreparingCur.Location")));
			this.labelAgentStateTimePreparingCur.Name = "labelAgentStateTimePreparingCur";
			this.labelAgentStateTimePreparingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimePreparingCur.RightToLeft")));
			this.labelAgentStateTimePreparingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimePreparingCur.Size")));
			this.labelAgentStateTimePreparingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimePreparingCur.TabIndex")));
			this.labelAgentStateTimePreparingCur.Text = resources.GetString("labelAgentStateTimePreparingCur.Text");
			this.labelAgentStateTimePreparingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePreparingCur.TextAlign")));
			this.labelAgentStateTimePreparingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimePreparingCur.Visible")));
			// 
			// labelAgentStateCountPreparing
			// 
			this.labelAgentStateCountPreparing.AccessibleDescription = resources.GetString("labelAgentStateCountPreparing.AccessibleDescription");
			this.labelAgentStateCountPreparing.AccessibleName = resources.GetString("labelAgentStateCountPreparing.AccessibleName");
			this.labelAgentStateCountPreparing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountPreparing.Anchor")));
			this.labelAgentStateCountPreparing.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountPreparing.AutoSize")));
			this.labelAgentStateCountPreparing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountPreparing.Dock")));
			this.labelAgentStateCountPreparing.Enabled = ((bool)(resources.GetObject("labelAgentStateCountPreparing.Enabled")));
			this.labelAgentStateCountPreparing.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountPreparing.Font")));
			this.labelAgentStateCountPreparing.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountPreparing.Image")));
			this.labelAgentStateCountPreparing.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPreparing.ImageAlign")));
			this.labelAgentStateCountPreparing.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountPreparing.ImageIndex")));
			this.labelAgentStateCountPreparing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountPreparing.ImeMode")));
			this.labelAgentStateCountPreparing.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountPreparing.Location")));
			this.labelAgentStateCountPreparing.Name = "labelAgentStateCountPreparing";
			this.labelAgentStateCountPreparing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountPreparing.RightToLeft")));
			this.labelAgentStateCountPreparing.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountPreparing.Size")));
			this.labelAgentStateCountPreparing.TabIndex = ((int)(resources.GetObject("labelAgentStateCountPreparing.TabIndex")));
			this.labelAgentStateCountPreparing.Text = resources.GetString("labelAgentStateCountPreparing.Text");
			this.labelAgentStateCountPreparing.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPreparing.TextAlign")));
			this.labelAgentStateCountPreparing.Visible = ((bool)(resources.GetObject("labelAgentStateCountPreparing.Visible")));
			// 
			// labelAgentStateCountPreparingCap
			// 
			this.labelAgentStateCountPreparingCap.AccessibleDescription = resources.GetString("labelAgentStateCountPreparingCap.AccessibleDescription");
			this.labelAgentStateCountPreparingCap.AccessibleName = resources.GetString("labelAgentStateCountPreparingCap.AccessibleName");
			this.labelAgentStateCountPreparingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountPreparingCap.Anchor")));
			this.labelAgentStateCountPreparingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountPreparingCap.AutoSize")));
			this.labelAgentStateCountPreparingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountPreparingCap.Dock")));
			this.labelAgentStateCountPreparingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountPreparingCap.Enabled")));
			this.labelAgentStateCountPreparingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountPreparingCap.Font")));
			this.labelAgentStateCountPreparingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountPreparingCap.Image")));
			this.labelAgentStateCountPreparingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPreparingCap.ImageAlign")));
			this.labelAgentStateCountPreparingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountPreparingCap.ImageIndex")));
			this.labelAgentStateCountPreparingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountPreparingCap.ImeMode")));
			this.labelAgentStateCountPreparingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountPreparingCap.Location")));
			this.labelAgentStateCountPreparingCap.Name = "labelAgentStateCountPreparingCap";
			this.labelAgentStateCountPreparingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountPreparingCap.RightToLeft")));
			this.labelAgentStateCountPreparingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountPreparingCap.Size")));
			this.labelAgentStateCountPreparingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountPreparingCap.TabIndex")));
			this.labelAgentStateCountPreparingCap.Text = resources.GetString("labelAgentStateCountPreparingCap.Text");
			this.labelAgentStateCountPreparingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPreparingCap.TextAlign")));
			this.labelAgentStateCountPreparingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountPreparingCap.Visible")));
			// 
			// labelAgentStateTimeSignalingTtl
			// 
			this.labelAgentStateTimeSignalingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeSignalingTtl.AccessibleDescription");
			this.labelAgentStateTimeSignalingTtl.AccessibleName = resources.GetString("labelAgentStateTimeSignalingTtl.AccessibleName");
			this.labelAgentStateTimeSignalingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeSignalingTtl.Anchor")));
			this.labelAgentStateTimeSignalingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeSignalingTtl.AutoSize")));
			this.labelAgentStateTimeSignalingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeSignalingTtl.Dock")));
			this.labelAgentStateTimeSignalingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeSignalingTtl.Enabled")));
			this.labelAgentStateTimeSignalingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeSignalingTtl.Font")));
			this.labelAgentStateTimeSignalingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeSignalingTtl.Image")));
			this.labelAgentStateTimeSignalingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeSignalingTtl.ImageAlign")));
			this.labelAgentStateTimeSignalingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeSignalingTtl.ImageIndex")));
			this.labelAgentStateTimeSignalingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeSignalingTtl.ImeMode")));
			this.labelAgentStateTimeSignalingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeSignalingTtl.Location")));
			this.labelAgentStateTimeSignalingTtl.Name = "labelAgentStateTimeSignalingTtl";
			this.labelAgentStateTimeSignalingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeSignalingTtl.RightToLeft")));
			this.labelAgentStateTimeSignalingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeSignalingTtl.Size")));
			this.labelAgentStateTimeSignalingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeSignalingTtl.TabIndex")));
			this.labelAgentStateTimeSignalingTtl.Text = resources.GetString("labelAgentStateTimeSignalingTtl.Text");
			this.labelAgentStateTimeSignalingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeSignalingTtl.TextAlign")));
			this.labelAgentStateTimeSignalingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeSignalingTtl.Visible")));
			// 
			// labelAgentStateTimeSignalingCur
			// 
			this.labelAgentStateTimeSignalingCur.AccessibleDescription = resources.GetString("labelAgentStateTimeSignalingCur.AccessibleDescription");
			this.labelAgentStateTimeSignalingCur.AccessibleName = resources.GetString("labelAgentStateTimeSignalingCur.AccessibleName");
			this.labelAgentStateTimeSignalingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeSignalingCur.Anchor")));
			this.labelAgentStateTimeSignalingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeSignalingCur.AutoSize")));
			this.labelAgentStateTimeSignalingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeSignalingCur.Dock")));
			this.labelAgentStateTimeSignalingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeSignalingCur.Enabled")));
			this.labelAgentStateTimeSignalingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeSignalingCur.Font")));
			this.labelAgentStateTimeSignalingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeSignalingCur.Image")));
			this.labelAgentStateTimeSignalingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeSignalingCur.ImageAlign")));
			this.labelAgentStateTimeSignalingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeSignalingCur.ImageIndex")));
			this.labelAgentStateTimeSignalingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeSignalingCur.ImeMode")));
			this.labelAgentStateTimeSignalingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeSignalingCur.Location")));
			this.labelAgentStateTimeSignalingCur.Name = "labelAgentStateTimeSignalingCur";
			this.labelAgentStateTimeSignalingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeSignalingCur.RightToLeft")));
			this.labelAgentStateTimeSignalingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeSignalingCur.Size")));
			this.labelAgentStateTimeSignalingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeSignalingCur.TabIndex")));
			this.labelAgentStateTimeSignalingCur.Text = resources.GetString("labelAgentStateTimeSignalingCur.Text");
			this.labelAgentStateTimeSignalingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeSignalingCur.TextAlign")));
			this.labelAgentStateTimeSignalingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeSignalingCur.Visible")));
			// 
			// labelAgentStateCountSignaling
			// 
			this.labelAgentStateCountSignaling.AccessibleDescription = resources.GetString("labelAgentStateCountSignaling.AccessibleDescription");
			this.labelAgentStateCountSignaling.AccessibleName = resources.GetString("labelAgentStateCountSignaling.AccessibleName");
			this.labelAgentStateCountSignaling.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountSignaling.Anchor")));
			this.labelAgentStateCountSignaling.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountSignaling.AutoSize")));
			this.labelAgentStateCountSignaling.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountSignaling.Dock")));
			this.labelAgentStateCountSignaling.Enabled = ((bool)(resources.GetObject("labelAgentStateCountSignaling.Enabled")));
			this.labelAgentStateCountSignaling.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountSignaling.Font")));
			this.labelAgentStateCountSignaling.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountSignaling.Image")));
			this.labelAgentStateCountSignaling.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountSignaling.ImageAlign")));
			this.labelAgentStateCountSignaling.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountSignaling.ImageIndex")));
			this.labelAgentStateCountSignaling.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountSignaling.ImeMode")));
			this.labelAgentStateCountSignaling.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountSignaling.Location")));
			this.labelAgentStateCountSignaling.Name = "labelAgentStateCountSignaling";
			this.labelAgentStateCountSignaling.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountSignaling.RightToLeft")));
			this.labelAgentStateCountSignaling.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountSignaling.Size")));
			this.labelAgentStateCountSignaling.TabIndex = ((int)(resources.GetObject("labelAgentStateCountSignaling.TabIndex")));
			this.labelAgentStateCountSignaling.Text = resources.GetString("labelAgentStateCountSignaling.Text");
			this.labelAgentStateCountSignaling.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountSignaling.TextAlign")));
			this.labelAgentStateCountSignaling.Visible = ((bool)(resources.GetObject("labelAgentStateCountSignaling.Visible")));
			// 
			// labelAgentStateCountSignalingCap
			// 
			this.labelAgentStateCountSignalingCap.AccessibleDescription = resources.GetString("labelAgentStateCountSignalingCap.AccessibleDescription");
			this.labelAgentStateCountSignalingCap.AccessibleName = resources.GetString("labelAgentStateCountSignalingCap.AccessibleName");
			this.labelAgentStateCountSignalingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountSignalingCap.Anchor")));
			this.labelAgentStateCountSignalingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountSignalingCap.AutoSize")));
			this.labelAgentStateCountSignalingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountSignalingCap.Dock")));
			this.labelAgentStateCountSignalingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountSignalingCap.Enabled")));
			this.labelAgentStateCountSignalingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountSignalingCap.Font")));
			this.labelAgentStateCountSignalingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountSignalingCap.Image")));
			this.labelAgentStateCountSignalingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountSignalingCap.ImageAlign")));
			this.labelAgentStateCountSignalingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountSignalingCap.ImageIndex")));
			this.labelAgentStateCountSignalingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountSignalingCap.ImeMode")));
			this.labelAgentStateCountSignalingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountSignalingCap.Location")));
			this.labelAgentStateCountSignalingCap.Name = "labelAgentStateCountSignalingCap";
			this.labelAgentStateCountSignalingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountSignalingCap.RightToLeft")));
			this.labelAgentStateCountSignalingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountSignalingCap.Size")));
			this.labelAgentStateCountSignalingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountSignalingCap.TabIndex")));
			this.labelAgentStateCountSignalingCap.Text = resources.GetString("labelAgentStateCountSignalingCap.Text");
			this.labelAgentStateCountSignalingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountSignalingCap.TextAlign")));
			this.labelAgentStateCountSignalingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountSignalingCap.Visible")));
			// 
			// labelAgentStateTimePendingTtl
			// 
			this.labelAgentStateTimePendingTtl.AccessibleDescription = resources.GetString("labelAgentStateTimePendingTtl.AccessibleDescription");
			this.labelAgentStateTimePendingTtl.AccessibleName = resources.GetString("labelAgentStateTimePendingTtl.AccessibleName");
			this.labelAgentStateTimePendingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimePendingTtl.Anchor")));
			this.labelAgentStateTimePendingTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimePendingTtl.AutoSize")));
			this.labelAgentStateTimePendingTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimePendingTtl.Dock")));
			this.labelAgentStateTimePendingTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimePendingTtl.Enabled")));
			this.labelAgentStateTimePendingTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimePendingTtl.Font")));
			this.labelAgentStateTimePendingTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimePendingTtl.Image")));
			this.labelAgentStateTimePendingTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePendingTtl.ImageAlign")));
			this.labelAgentStateTimePendingTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimePendingTtl.ImageIndex")));
			this.labelAgentStateTimePendingTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimePendingTtl.ImeMode")));
			this.labelAgentStateTimePendingTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimePendingTtl.Location")));
			this.labelAgentStateTimePendingTtl.Name = "labelAgentStateTimePendingTtl";
			this.labelAgentStateTimePendingTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimePendingTtl.RightToLeft")));
			this.labelAgentStateTimePendingTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimePendingTtl.Size")));
			this.labelAgentStateTimePendingTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimePendingTtl.TabIndex")));
			this.labelAgentStateTimePendingTtl.Text = resources.GetString("labelAgentStateTimePendingTtl.Text");
			this.labelAgentStateTimePendingTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePendingTtl.TextAlign")));
			this.labelAgentStateTimePendingTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimePendingTtl.Visible")));
			// 
			// labelAgentStateTimePendingCur
			// 
			this.labelAgentStateTimePendingCur.AccessibleDescription = resources.GetString("labelAgentStateTimePendingCur.AccessibleDescription");
			this.labelAgentStateTimePendingCur.AccessibleName = resources.GetString("labelAgentStateTimePendingCur.AccessibleName");
			this.labelAgentStateTimePendingCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimePendingCur.Anchor")));
			this.labelAgentStateTimePendingCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimePendingCur.AutoSize")));
			this.labelAgentStateTimePendingCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimePendingCur.Dock")));
			this.labelAgentStateTimePendingCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimePendingCur.Enabled")));
			this.labelAgentStateTimePendingCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimePendingCur.Font")));
			this.labelAgentStateTimePendingCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimePendingCur.Image")));
			this.labelAgentStateTimePendingCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePendingCur.ImageAlign")));
			this.labelAgentStateTimePendingCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimePendingCur.ImageIndex")));
			this.labelAgentStateTimePendingCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimePendingCur.ImeMode")));
			this.labelAgentStateTimePendingCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimePendingCur.Location")));
			this.labelAgentStateTimePendingCur.Name = "labelAgentStateTimePendingCur";
			this.labelAgentStateTimePendingCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimePendingCur.RightToLeft")));
			this.labelAgentStateTimePendingCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimePendingCur.Size")));
			this.labelAgentStateTimePendingCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimePendingCur.TabIndex")));
			this.labelAgentStateTimePendingCur.Text = resources.GetString("labelAgentStateTimePendingCur.Text");
			this.labelAgentStateTimePendingCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimePendingCur.TextAlign")));
			this.labelAgentStateTimePendingCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimePendingCur.Visible")));
			// 
			// labelAgentStateCountPending
			// 
			this.labelAgentStateCountPending.AccessibleDescription = resources.GetString("labelAgentStateCountPending.AccessibleDescription");
			this.labelAgentStateCountPending.AccessibleName = resources.GetString("labelAgentStateCountPending.AccessibleName");
			this.labelAgentStateCountPending.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountPending.Anchor")));
			this.labelAgentStateCountPending.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountPending.AutoSize")));
			this.labelAgentStateCountPending.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountPending.Dock")));
			this.labelAgentStateCountPending.Enabled = ((bool)(resources.GetObject("labelAgentStateCountPending.Enabled")));
			this.labelAgentStateCountPending.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountPending.Font")));
			this.labelAgentStateCountPending.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountPending.Image")));
			this.labelAgentStateCountPending.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPending.ImageAlign")));
			this.labelAgentStateCountPending.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountPending.ImageIndex")));
			this.labelAgentStateCountPending.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountPending.ImeMode")));
			this.labelAgentStateCountPending.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountPending.Location")));
			this.labelAgentStateCountPending.Name = "labelAgentStateCountPending";
			this.labelAgentStateCountPending.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountPending.RightToLeft")));
			this.labelAgentStateCountPending.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountPending.Size")));
			this.labelAgentStateCountPending.TabIndex = ((int)(resources.GetObject("labelAgentStateCountPending.TabIndex")));
			this.labelAgentStateCountPending.Text = resources.GetString("labelAgentStateCountPending.Text");
			this.labelAgentStateCountPending.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPending.TextAlign")));
			this.labelAgentStateCountPending.Visible = ((bool)(resources.GetObject("labelAgentStateCountPending.Visible")));
			// 
			// labelAgentStateCountPendingCap
			// 
			this.labelAgentStateCountPendingCap.AccessibleDescription = resources.GetString("labelAgentStateCountPendingCap.AccessibleDescription");
			this.labelAgentStateCountPendingCap.AccessibleName = resources.GetString("labelAgentStateCountPendingCap.AccessibleName");
			this.labelAgentStateCountPendingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountPendingCap.Anchor")));
			this.labelAgentStateCountPendingCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountPendingCap.AutoSize")));
			this.labelAgentStateCountPendingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountPendingCap.Dock")));
			this.labelAgentStateCountPendingCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountPendingCap.Enabled")));
			this.labelAgentStateCountPendingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountPendingCap.Font")));
			this.labelAgentStateCountPendingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountPendingCap.Image")));
			this.labelAgentStateCountPendingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPendingCap.ImageAlign")));
			this.labelAgentStateCountPendingCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountPendingCap.ImageIndex")));
			this.labelAgentStateCountPendingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountPendingCap.ImeMode")));
			this.labelAgentStateCountPendingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountPendingCap.Location")));
			this.labelAgentStateCountPendingCap.Name = "labelAgentStateCountPendingCap";
			this.labelAgentStateCountPendingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountPendingCap.RightToLeft")));
			this.labelAgentStateCountPendingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountPendingCap.Size")));
			this.labelAgentStateCountPendingCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountPendingCap.TabIndex")));
			this.labelAgentStateCountPendingCap.Text = resources.GetString("labelAgentStateCountPendingCap.Text");
			this.labelAgentStateCountPendingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountPendingCap.TextAlign")));
			this.labelAgentStateCountPendingCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountPendingCap.Visible")));
			// 
			// labelAgentStateTimeReadyTtl
			// 
			this.labelAgentStateTimeReadyTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeReadyTtl.AccessibleDescription");
			this.labelAgentStateTimeReadyTtl.AccessibleName = resources.GetString("labelAgentStateTimeReadyTtl.AccessibleName");
			this.labelAgentStateTimeReadyTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeReadyTtl.Anchor")));
			this.labelAgentStateTimeReadyTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeReadyTtl.AutoSize")));
			this.labelAgentStateTimeReadyTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeReadyTtl.Dock")));
			this.labelAgentStateTimeReadyTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeReadyTtl.Enabled")));
			this.labelAgentStateTimeReadyTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeReadyTtl.Font")));
			this.labelAgentStateTimeReadyTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeReadyTtl.Image")));
			this.labelAgentStateTimeReadyTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeReadyTtl.ImageAlign")));
			this.labelAgentStateTimeReadyTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeReadyTtl.ImageIndex")));
			this.labelAgentStateTimeReadyTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeReadyTtl.ImeMode")));
			this.labelAgentStateTimeReadyTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeReadyTtl.Location")));
			this.labelAgentStateTimeReadyTtl.Name = "labelAgentStateTimeReadyTtl";
			this.labelAgentStateTimeReadyTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeReadyTtl.RightToLeft")));
			this.labelAgentStateTimeReadyTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeReadyTtl.Size")));
			this.labelAgentStateTimeReadyTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeReadyTtl.TabIndex")));
			this.labelAgentStateTimeReadyTtl.Text = resources.GetString("labelAgentStateTimeReadyTtl.Text");
			this.labelAgentStateTimeReadyTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeReadyTtl.TextAlign")));
			this.labelAgentStateTimeReadyTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeReadyTtl.Visible")));
			// 
			// labelAgentStateTimeReadyCur
			// 
			this.labelAgentStateTimeReadyCur.AccessibleDescription = resources.GetString("labelAgentStateTimeReadyCur.AccessibleDescription");
			this.labelAgentStateTimeReadyCur.AccessibleName = resources.GetString("labelAgentStateTimeReadyCur.AccessibleName");
			this.labelAgentStateTimeReadyCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeReadyCur.Anchor")));
			this.labelAgentStateTimeReadyCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeReadyCur.AutoSize")));
			this.labelAgentStateTimeReadyCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeReadyCur.Dock")));
			this.labelAgentStateTimeReadyCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeReadyCur.Enabled")));
			this.labelAgentStateTimeReadyCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeReadyCur.Font")));
			this.labelAgentStateTimeReadyCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeReadyCur.Image")));
			this.labelAgentStateTimeReadyCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeReadyCur.ImageAlign")));
			this.labelAgentStateTimeReadyCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeReadyCur.ImageIndex")));
			this.labelAgentStateTimeReadyCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeReadyCur.ImeMode")));
			this.labelAgentStateTimeReadyCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeReadyCur.Location")));
			this.labelAgentStateTimeReadyCur.Name = "labelAgentStateTimeReadyCur";
			this.labelAgentStateTimeReadyCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeReadyCur.RightToLeft")));
			this.labelAgentStateTimeReadyCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeReadyCur.Size")));
			this.labelAgentStateTimeReadyCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeReadyCur.TabIndex")));
			this.labelAgentStateTimeReadyCur.Text = resources.GetString("labelAgentStateTimeReadyCur.Text");
			this.labelAgentStateTimeReadyCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeReadyCur.TextAlign")));
			this.labelAgentStateTimeReadyCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeReadyCur.Visible")));
			// 
			// labelAgentStateCountReady
			// 
			this.labelAgentStateCountReady.AccessibleDescription = resources.GetString("labelAgentStateCountReady.AccessibleDescription");
			this.labelAgentStateCountReady.AccessibleName = resources.GetString("labelAgentStateCountReady.AccessibleName");
			this.labelAgentStateCountReady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountReady.Anchor")));
			this.labelAgentStateCountReady.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountReady.AutoSize")));
			this.labelAgentStateCountReady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountReady.Dock")));
			this.labelAgentStateCountReady.Enabled = ((bool)(resources.GetObject("labelAgentStateCountReady.Enabled")));
			this.labelAgentStateCountReady.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountReady.Font")));
			this.labelAgentStateCountReady.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountReady.Image")));
			this.labelAgentStateCountReady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountReady.ImageAlign")));
			this.labelAgentStateCountReady.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountReady.ImageIndex")));
			this.labelAgentStateCountReady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountReady.ImeMode")));
			this.labelAgentStateCountReady.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountReady.Location")));
			this.labelAgentStateCountReady.Name = "labelAgentStateCountReady";
			this.labelAgentStateCountReady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountReady.RightToLeft")));
			this.labelAgentStateCountReady.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountReady.Size")));
			this.labelAgentStateCountReady.TabIndex = ((int)(resources.GetObject("labelAgentStateCountReady.TabIndex")));
			this.labelAgentStateCountReady.Text = resources.GetString("labelAgentStateCountReady.Text");
			this.labelAgentStateCountReady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountReady.TextAlign")));
			this.labelAgentStateCountReady.Visible = ((bool)(resources.GetObject("labelAgentStateCountReady.Visible")));
			// 
			// labelAgentStateCountReadyCap
			// 
			this.labelAgentStateCountReadyCap.AccessibleDescription = resources.GetString("labelAgentStateCountReadyCap.AccessibleDescription");
			this.labelAgentStateCountReadyCap.AccessibleName = resources.GetString("labelAgentStateCountReadyCap.AccessibleName");
			this.labelAgentStateCountReadyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountReadyCap.Anchor")));
			this.labelAgentStateCountReadyCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountReadyCap.AutoSize")));
			this.labelAgentStateCountReadyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountReadyCap.Dock")));
			this.labelAgentStateCountReadyCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountReadyCap.Enabled")));
			this.labelAgentStateCountReadyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountReadyCap.Font")));
			this.labelAgentStateCountReadyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountReadyCap.Image")));
			this.labelAgentStateCountReadyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountReadyCap.ImageAlign")));
			this.labelAgentStateCountReadyCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountReadyCap.ImageIndex")));
			this.labelAgentStateCountReadyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountReadyCap.ImeMode")));
			this.labelAgentStateCountReadyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountReadyCap.Location")));
			this.labelAgentStateCountReadyCap.Name = "labelAgentStateCountReadyCap";
			this.labelAgentStateCountReadyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountReadyCap.RightToLeft")));
			this.labelAgentStateCountReadyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountReadyCap.Size")));
			this.labelAgentStateCountReadyCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountReadyCap.TabIndex")));
			this.labelAgentStateCountReadyCap.Text = resources.GetString("labelAgentStateCountReadyCap.Text");
			this.labelAgentStateCountReadyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountReadyCap.TextAlign")));
			this.labelAgentStateCountReadyCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountReadyCap.Visible")));
			// 
			// labelAgentStateTimeNotReadyTtl
			// 
			this.labelAgentStateTimeNotReadyTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeNotReadyTtl.AccessibleDescription");
			this.labelAgentStateTimeNotReadyTtl.AccessibleName = resources.GetString("labelAgentStateTimeNotReadyTtl.AccessibleName");
			this.labelAgentStateTimeNotReadyTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Anchor")));
			this.labelAgentStateTimeNotReadyTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyTtl.AutoSize")));
			this.labelAgentStateTimeNotReadyTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Dock")));
			this.labelAgentStateTimeNotReadyTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Enabled")));
			this.labelAgentStateTimeNotReadyTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Font")));
			this.labelAgentStateTimeNotReadyTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Image")));
			this.labelAgentStateTimeNotReadyTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeNotReadyTtl.ImageAlign")));
			this.labelAgentStateTimeNotReadyTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeNotReadyTtl.ImageIndex")));
			this.labelAgentStateTimeNotReadyTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeNotReadyTtl.ImeMode")));
			this.labelAgentStateTimeNotReadyTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Location")));
			this.labelAgentStateTimeNotReadyTtl.Name = "labelAgentStateTimeNotReadyTtl";
			this.labelAgentStateTimeNotReadyTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeNotReadyTtl.RightToLeft")));
			this.labelAgentStateTimeNotReadyTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Size")));
			this.labelAgentStateTimeNotReadyTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeNotReadyTtl.TabIndex")));
			this.labelAgentStateTimeNotReadyTtl.Text = resources.GetString("labelAgentStateTimeNotReadyTtl.Text");
			this.labelAgentStateTimeNotReadyTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeNotReadyTtl.TextAlign")));
			this.labelAgentStateTimeNotReadyTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyTtl.Visible")));
			// 
			// labelAgentStateTimeNotReadyCur
			// 
			this.labelAgentStateTimeNotReadyCur.AccessibleDescription = resources.GetString("labelAgentStateTimeNotReadyCur.AccessibleDescription");
			this.labelAgentStateTimeNotReadyCur.AccessibleName = resources.GetString("labelAgentStateTimeNotReadyCur.AccessibleName");
			this.labelAgentStateTimeNotReadyCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeNotReadyCur.Anchor")));
			this.labelAgentStateTimeNotReadyCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyCur.AutoSize")));
			this.labelAgentStateTimeNotReadyCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeNotReadyCur.Dock")));
			this.labelAgentStateTimeNotReadyCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyCur.Enabled")));
			this.labelAgentStateTimeNotReadyCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeNotReadyCur.Font")));
			this.labelAgentStateTimeNotReadyCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeNotReadyCur.Image")));
			this.labelAgentStateTimeNotReadyCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeNotReadyCur.ImageAlign")));
			this.labelAgentStateTimeNotReadyCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeNotReadyCur.ImageIndex")));
			this.labelAgentStateTimeNotReadyCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeNotReadyCur.ImeMode")));
			this.labelAgentStateTimeNotReadyCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeNotReadyCur.Location")));
			this.labelAgentStateTimeNotReadyCur.Name = "labelAgentStateTimeNotReadyCur";
			this.labelAgentStateTimeNotReadyCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeNotReadyCur.RightToLeft")));
			this.labelAgentStateTimeNotReadyCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeNotReadyCur.Size")));
			this.labelAgentStateTimeNotReadyCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeNotReadyCur.TabIndex")));
			this.labelAgentStateTimeNotReadyCur.Text = resources.GetString("labelAgentStateTimeNotReadyCur.Text");
			this.labelAgentStateTimeNotReadyCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeNotReadyCur.TextAlign")));
			this.labelAgentStateTimeNotReadyCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeNotReadyCur.Visible")));
			// 
			// labelAgentStateCountNotReady
			// 
			this.labelAgentStateCountNotReady.AccessibleDescription = resources.GetString("labelAgentStateCountNotReady.AccessibleDescription");
			this.labelAgentStateCountNotReady.AccessibleName = resources.GetString("labelAgentStateCountNotReady.AccessibleName");
			this.labelAgentStateCountNotReady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountNotReady.Anchor")));
			this.labelAgentStateCountNotReady.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountNotReady.AutoSize")));
			this.labelAgentStateCountNotReady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountNotReady.Dock")));
			this.labelAgentStateCountNotReady.Enabled = ((bool)(resources.GetObject("labelAgentStateCountNotReady.Enabled")));
			this.labelAgentStateCountNotReady.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountNotReady.Font")));
			this.labelAgentStateCountNotReady.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountNotReady.Image")));
			this.labelAgentStateCountNotReady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountNotReady.ImageAlign")));
			this.labelAgentStateCountNotReady.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountNotReady.ImageIndex")));
			this.labelAgentStateCountNotReady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountNotReady.ImeMode")));
			this.labelAgentStateCountNotReady.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountNotReady.Location")));
			this.labelAgentStateCountNotReady.Name = "labelAgentStateCountNotReady";
			this.labelAgentStateCountNotReady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountNotReady.RightToLeft")));
			this.labelAgentStateCountNotReady.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountNotReady.Size")));
			this.labelAgentStateCountNotReady.TabIndex = ((int)(resources.GetObject("labelAgentStateCountNotReady.TabIndex")));
			this.labelAgentStateCountNotReady.Text = resources.GetString("labelAgentStateCountNotReady.Text");
			this.labelAgentStateCountNotReady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountNotReady.TextAlign")));
			this.labelAgentStateCountNotReady.Visible = ((bool)(resources.GetObject("labelAgentStateCountNotReady.Visible")));
			// 
			// labelAgentStateCountNotReadyCap
			// 
			this.labelAgentStateCountNotReadyCap.AccessibleDescription = resources.GetString("labelAgentStateCountNotReadyCap.AccessibleDescription");
			this.labelAgentStateCountNotReadyCap.AccessibleName = resources.GetString("labelAgentStateCountNotReadyCap.AccessibleName");
			this.labelAgentStateCountNotReadyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountNotReadyCap.Anchor")));
			this.labelAgentStateCountNotReadyCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountNotReadyCap.AutoSize")));
			this.labelAgentStateCountNotReadyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountNotReadyCap.Dock")));
			this.labelAgentStateCountNotReadyCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountNotReadyCap.Enabled")));
			this.labelAgentStateCountNotReadyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountNotReadyCap.Font")));
			this.labelAgentStateCountNotReadyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountNotReadyCap.Image")));
			this.labelAgentStateCountNotReadyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountNotReadyCap.ImageAlign")));
			this.labelAgentStateCountNotReadyCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountNotReadyCap.ImageIndex")));
			this.labelAgentStateCountNotReadyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountNotReadyCap.ImeMode")));
			this.labelAgentStateCountNotReadyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountNotReadyCap.Location")));
			this.labelAgentStateCountNotReadyCap.Name = "labelAgentStateCountNotReadyCap";
			this.labelAgentStateCountNotReadyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountNotReadyCap.RightToLeft")));
			this.labelAgentStateCountNotReadyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountNotReadyCap.Size")));
			this.labelAgentStateCountNotReadyCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountNotReadyCap.TabIndex")));
			this.labelAgentStateCountNotReadyCap.Text = resources.GetString("labelAgentStateCountNotReadyCap.Text");
			this.labelAgentStateCountNotReadyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountNotReadyCap.TextAlign")));
			this.labelAgentStateCountNotReadyCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountNotReadyCap.Visible")));
			// 
			// labelAgentStateTimeUnassignedTtl
			// 
			this.labelAgentStateTimeUnassignedTtl.AccessibleDescription = resources.GetString("labelAgentStateTimeUnassignedTtl.AccessibleDescription");
			this.labelAgentStateTimeUnassignedTtl.AccessibleName = resources.GetString("labelAgentStateTimeUnassignedTtl.AccessibleName");
			this.labelAgentStateTimeUnassignedTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Anchor")));
			this.labelAgentStateTimeUnassignedTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedTtl.AutoSize")));
			this.labelAgentStateTimeUnassignedTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Dock")));
			this.labelAgentStateTimeUnassignedTtl.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Enabled")));
			this.labelAgentStateTimeUnassignedTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Font")));
			this.labelAgentStateTimeUnassignedTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Image")));
			this.labelAgentStateTimeUnassignedTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeUnassignedTtl.ImageAlign")));
			this.labelAgentStateTimeUnassignedTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeUnassignedTtl.ImageIndex")));
			this.labelAgentStateTimeUnassignedTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeUnassignedTtl.ImeMode")));
			this.labelAgentStateTimeUnassignedTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Location")));
			this.labelAgentStateTimeUnassignedTtl.Name = "labelAgentStateTimeUnassignedTtl";
			this.labelAgentStateTimeUnassignedTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeUnassignedTtl.RightToLeft")));
			this.labelAgentStateTimeUnassignedTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Size")));
			this.labelAgentStateTimeUnassignedTtl.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeUnassignedTtl.TabIndex")));
			this.labelAgentStateTimeUnassignedTtl.Text = resources.GetString("labelAgentStateTimeUnassignedTtl.Text");
			this.labelAgentStateTimeUnassignedTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeUnassignedTtl.TextAlign")));
			this.labelAgentStateTimeUnassignedTtl.Visible = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedTtl.Visible")));
			// 
			// labelAgentStateTimeUnassignedCur
			// 
			this.labelAgentStateTimeUnassignedCur.AccessibleDescription = resources.GetString("labelAgentStateTimeUnassignedCur.AccessibleDescription");
			this.labelAgentStateTimeUnassignedCur.AccessibleName = resources.GetString("labelAgentStateTimeUnassignedCur.AccessibleName");
			this.labelAgentStateTimeUnassignedCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateTimeUnassignedCur.Anchor")));
			this.labelAgentStateTimeUnassignedCur.AutoSize = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedCur.AutoSize")));
			this.labelAgentStateTimeUnassignedCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateTimeUnassignedCur.Dock")));
			this.labelAgentStateTimeUnassignedCur.Enabled = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedCur.Enabled")));
			this.labelAgentStateTimeUnassignedCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateTimeUnassignedCur.Font")));
			this.labelAgentStateTimeUnassignedCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateTimeUnassignedCur.Image")));
			this.labelAgentStateTimeUnassignedCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeUnassignedCur.ImageAlign")));
			this.labelAgentStateTimeUnassignedCur.ImageIndex = ((int)(resources.GetObject("labelAgentStateTimeUnassignedCur.ImageIndex")));
			this.labelAgentStateTimeUnassignedCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateTimeUnassignedCur.ImeMode")));
			this.labelAgentStateTimeUnassignedCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateTimeUnassignedCur.Location")));
			this.labelAgentStateTimeUnassignedCur.Name = "labelAgentStateTimeUnassignedCur";
			this.labelAgentStateTimeUnassignedCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateTimeUnassignedCur.RightToLeft")));
			this.labelAgentStateTimeUnassignedCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateTimeUnassignedCur.Size")));
			this.labelAgentStateTimeUnassignedCur.TabIndex = ((int)(resources.GetObject("labelAgentStateTimeUnassignedCur.TabIndex")));
			this.labelAgentStateTimeUnassignedCur.Text = resources.GetString("labelAgentStateTimeUnassignedCur.Text");
			this.labelAgentStateTimeUnassignedCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateTimeUnassignedCur.TextAlign")));
			this.labelAgentStateTimeUnassignedCur.Visible = ((bool)(resources.GetObject("labelAgentStateTimeUnassignedCur.Visible")));
			// 
			// labelAgentStateCountUnassigned
			// 
			this.labelAgentStateCountUnassigned.AccessibleDescription = resources.GetString("labelAgentStateCountUnassigned.AccessibleDescription");
			this.labelAgentStateCountUnassigned.AccessibleName = resources.GetString("labelAgentStateCountUnassigned.AccessibleName");
			this.labelAgentStateCountUnassigned.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountUnassigned.Anchor")));
			this.labelAgentStateCountUnassigned.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountUnassigned.AutoSize")));
			this.labelAgentStateCountUnassigned.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountUnassigned.Dock")));
			this.labelAgentStateCountUnassigned.Enabled = ((bool)(resources.GetObject("labelAgentStateCountUnassigned.Enabled")));
			this.labelAgentStateCountUnassigned.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountUnassigned.Font")));
			this.labelAgentStateCountUnassigned.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountUnassigned.Image")));
			this.labelAgentStateCountUnassigned.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountUnassigned.ImageAlign")));
			this.labelAgentStateCountUnassigned.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountUnassigned.ImageIndex")));
			this.labelAgentStateCountUnassigned.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountUnassigned.ImeMode")));
			this.labelAgentStateCountUnassigned.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountUnassigned.Location")));
			this.labelAgentStateCountUnassigned.Name = "labelAgentStateCountUnassigned";
			this.labelAgentStateCountUnassigned.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountUnassigned.RightToLeft")));
			this.labelAgentStateCountUnassigned.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountUnassigned.Size")));
			this.labelAgentStateCountUnassigned.TabIndex = ((int)(resources.GetObject("labelAgentStateCountUnassigned.TabIndex")));
			this.labelAgentStateCountUnassigned.Text = resources.GetString("labelAgentStateCountUnassigned.Text");
			this.labelAgentStateCountUnassigned.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountUnassigned.TextAlign")));
			this.labelAgentStateCountUnassigned.Visible = ((bool)(resources.GetObject("labelAgentStateCountUnassigned.Visible")));
			// 
			// labelAgentStateCountUnassignedCap
			// 
			this.labelAgentStateCountUnassignedCap.AccessibleDescription = resources.GetString("labelAgentStateCountUnassignedCap.AccessibleDescription");
			this.labelAgentStateCountUnassignedCap.AccessibleName = resources.GetString("labelAgentStateCountUnassignedCap.AccessibleName");
			this.labelAgentStateCountUnassignedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStateCountUnassignedCap.Anchor")));
			this.labelAgentStateCountUnassignedCap.AutoSize = ((bool)(resources.GetObject("labelAgentStateCountUnassignedCap.AutoSize")));
			this.labelAgentStateCountUnassignedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStateCountUnassignedCap.Dock")));
			this.labelAgentStateCountUnassignedCap.Enabled = ((bool)(resources.GetObject("labelAgentStateCountUnassignedCap.Enabled")));
			this.labelAgentStateCountUnassignedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStateCountUnassignedCap.Font")));
			this.labelAgentStateCountUnassignedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStateCountUnassignedCap.Image")));
			this.labelAgentStateCountUnassignedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountUnassignedCap.ImageAlign")));
			this.labelAgentStateCountUnassignedCap.ImageIndex = ((int)(resources.GetObject("labelAgentStateCountUnassignedCap.ImageIndex")));
			this.labelAgentStateCountUnassignedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStateCountUnassignedCap.ImeMode")));
			this.labelAgentStateCountUnassignedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStateCountUnassignedCap.Location")));
			this.labelAgentStateCountUnassignedCap.Name = "labelAgentStateCountUnassignedCap";
			this.labelAgentStateCountUnassignedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStateCountUnassignedCap.RightToLeft")));
			this.labelAgentStateCountUnassignedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStateCountUnassignedCap.Size")));
			this.labelAgentStateCountUnassignedCap.TabIndex = ((int)(resources.GetObject("labelAgentStateCountUnassignedCap.TabIndex")));
			this.labelAgentStateCountUnassignedCap.Text = resources.GetString("labelAgentStateCountUnassignedCap.Text");
			this.labelAgentStateCountUnassignedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStateCountUnassignedCap.TextAlign")));
			this.labelAgentStateCountUnassignedCap.Visible = ((bool)(resources.GetObject("labelAgentStateCountUnassignedCap.Visible")));
			// 
			// labelAgentStatesTopLineGray
			// 
			this.labelAgentStatesTopLineGray.AccessibleDescription = resources.GetString("labelAgentStatesTopLineGray.AccessibleDescription");
			this.labelAgentStatesTopLineGray.AccessibleName = resources.GetString("labelAgentStatesTopLineGray.AccessibleName");
			this.labelAgentStatesTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesTopLineGray.Anchor")));
			this.labelAgentStatesTopLineGray.AutoSize = ((bool)(resources.GetObject("labelAgentStatesTopLineGray.AutoSize")));
			this.labelAgentStatesTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelAgentStatesTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesTopLineGray.Dock")));
			this.labelAgentStatesTopLineGray.Enabled = ((bool)(resources.GetObject("labelAgentStatesTopLineGray.Enabled")));
			this.labelAgentStatesTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesTopLineGray.Font")));
			this.labelAgentStatesTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentStatesTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesTopLineGray.Image")));
			this.labelAgentStatesTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesTopLineGray.ImageAlign")));
			this.labelAgentStatesTopLineGray.ImageIndex = ((int)(resources.GetObject("labelAgentStatesTopLineGray.ImageIndex")));
			this.labelAgentStatesTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesTopLineGray.ImeMode")));
			this.labelAgentStatesTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesTopLineGray.Location")));
			this.labelAgentStatesTopLineGray.Name = "labelAgentStatesTopLineGray";
			this.labelAgentStatesTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesTopLineGray.RightToLeft")));
			this.labelAgentStatesTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesTopLineGray.Size")));
			this.labelAgentStatesTopLineGray.TabIndex = ((int)(resources.GetObject("labelAgentStatesTopLineGray.TabIndex")));
			this.labelAgentStatesTopLineGray.Text = resources.GetString("labelAgentStatesTopLineGray.Text");
			this.labelAgentStatesTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesTopLineGray.TextAlign")));
			this.labelAgentStatesTopLineGray.Visible = ((bool)(resources.GetObject("labelAgentStatesTopLineGray.Visible")));
			// 
			// labelAgentStatesTopLineWhite
			// 
			this.labelAgentStatesTopLineWhite.AccessibleDescription = resources.GetString("labelAgentStatesTopLineWhite.AccessibleDescription");
			this.labelAgentStatesTopLineWhite.AccessibleName = resources.GetString("labelAgentStatesTopLineWhite.AccessibleName");
			this.labelAgentStatesTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesTopLineWhite.Anchor")));
			this.labelAgentStatesTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelAgentStatesTopLineWhite.AutoSize")));
			this.labelAgentStatesTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelAgentStatesTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesTopLineWhite.Dock")));
			this.labelAgentStatesTopLineWhite.Enabled = ((bool)(resources.GetObject("labelAgentStatesTopLineWhite.Enabled")));
			this.labelAgentStatesTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesTopLineWhite.Font")));
			this.labelAgentStatesTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentStatesTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesTopLineWhite.Image")));
			this.labelAgentStatesTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesTopLineWhite.ImageAlign")));
			this.labelAgentStatesTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelAgentStatesTopLineWhite.ImageIndex")));
			this.labelAgentStatesTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesTopLineWhite.ImeMode")));
			this.labelAgentStatesTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesTopLineWhite.Location")));
			this.labelAgentStatesTopLineWhite.Name = "labelAgentStatesTopLineWhite";
			this.labelAgentStatesTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesTopLineWhite.RightToLeft")));
			this.labelAgentStatesTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesTopLineWhite.Size")));
			this.labelAgentStatesTopLineWhite.TabIndex = ((int)(resources.GetObject("labelAgentStatesTopLineWhite.TabIndex")));
			this.labelAgentStatesTopLineWhite.Text = resources.GetString("labelAgentStatesTopLineWhite.Text");
			this.labelAgentStatesTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesTopLineWhite.TextAlign")));
			this.labelAgentStatesTopLineWhite.Visible = ((bool)(resources.GetObject("labelAgentStatesTopLineWhite.Visible")));
			// 
			// labelAgentStatesRowTimeTtl
			// 
			this.labelAgentStatesRowTimeTtl.AccessibleDescription = resources.GetString("labelAgentStatesRowTimeTtl.AccessibleDescription");
			this.labelAgentStatesRowTimeTtl.AccessibleName = resources.GetString("labelAgentStatesRowTimeTtl.AccessibleName");
			this.labelAgentStatesRowTimeTtl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesRowTimeTtl.Anchor")));
			this.labelAgentStatesRowTimeTtl.AutoSize = ((bool)(resources.GetObject("labelAgentStatesRowTimeTtl.AutoSize")));
			this.labelAgentStatesRowTimeTtl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesRowTimeTtl.Dock")));
			this.labelAgentStatesRowTimeTtl.Enabled = ((bool)(resources.GetObject("labelAgentStatesRowTimeTtl.Enabled")));
			this.labelAgentStatesRowTimeTtl.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesRowTimeTtl.Font")));
			this.labelAgentStatesRowTimeTtl.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesRowTimeTtl.Image")));
			this.labelAgentStatesRowTimeTtl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowTimeTtl.ImageAlign")));
			this.labelAgentStatesRowTimeTtl.ImageIndex = ((int)(resources.GetObject("labelAgentStatesRowTimeTtl.ImageIndex")));
			this.labelAgentStatesRowTimeTtl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesRowTimeTtl.ImeMode")));
			this.labelAgentStatesRowTimeTtl.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesRowTimeTtl.Location")));
			this.labelAgentStatesRowTimeTtl.Name = "labelAgentStatesRowTimeTtl";
			this.labelAgentStatesRowTimeTtl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesRowTimeTtl.RightToLeft")));
			this.labelAgentStatesRowTimeTtl.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesRowTimeTtl.Size")));
			this.labelAgentStatesRowTimeTtl.TabIndex = ((int)(resources.GetObject("labelAgentStatesRowTimeTtl.TabIndex")));
			this.labelAgentStatesRowTimeTtl.Text = resources.GetString("labelAgentStatesRowTimeTtl.Text");
			this.labelAgentStatesRowTimeTtl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowTimeTtl.TextAlign")));
			this.labelAgentStatesRowTimeTtl.Visible = ((bool)(resources.GetObject("labelAgentStatesRowTimeTtl.Visible")));
			// 
			// labelAgentStatesRowTimeCur
			// 
			this.labelAgentStatesRowTimeCur.AccessibleDescription = resources.GetString("labelAgentStatesRowTimeCur.AccessibleDescription");
			this.labelAgentStatesRowTimeCur.AccessibleName = resources.GetString("labelAgentStatesRowTimeCur.AccessibleName");
			this.labelAgentStatesRowTimeCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesRowTimeCur.Anchor")));
			this.labelAgentStatesRowTimeCur.AutoSize = ((bool)(resources.GetObject("labelAgentStatesRowTimeCur.AutoSize")));
			this.labelAgentStatesRowTimeCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesRowTimeCur.Dock")));
			this.labelAgentStatesRowTimeCur.Enabled = ((bool)(resources.GetObject("labelAgentStatesRowTimeCur.Enabled")));
			this.labelAgentStatesRowTimeCur.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesRowTimeCur.Font")));
			this.labelAgentStatesRowTimeCur.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesRowTimeCur.Image")));
			this.labelAgentStatesRowTimeCur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowTimeCur.ImageAlign")));
			this.labelAgentStatesRowTimeCur.ImageIndex = ((int)(resources.GetObject("labelAgentStatesRowTimeCur.ImageIndex")));
			this.labelAgentStatesRowTimeCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesRowTimeCur.ImeMode")));
			this.labelAgentStatesRowTimeCur.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesRowTimeCur.Location")));
			this.labelAgentStatesRowTimeCur.Name = "labelAgentStatesRowTimeCur";
			this.labelAgentStatesRowTimeCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesRowTimeCur.RightToLeft")));
			this.labelAgentStatesRowTimeCur.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesRowTimeCur.Size")));
			this.labelAgentStatesRowTimeCur.TabIndex = ((int)(resources.GetObject("labelAgentStatesRowTimeCur.TabIndex")));
			this.labelAgentStatesRowTimeCur.Text = resources.GetString("labelAgentStatesRowTimeCur.Text");
			this.labelAgentStatesRowTimeCur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowTimeCur.TextAlign")));
			this.labelAgentStatesRowTimeCur.Visible = ((bool)(resources.GetObject("labelAgentStatesRowTimeCur.Visible")));
			// 
			// labelAgentStatesRowCount
			// 
			this.labelAgentStatesRowCount.AccessibleDescription = resources.GetString("labelAgentStatesRowCount.AccessibleDescription");
			this.labelAgentStatesRowCount.AccessibleName = resources.GetString("labelAgentStatesRowCount.AccessibleName");
			this.labelAgentStatesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesRowCount.Anchor")));
			this.labelAgentStatesRowCount.AutoSize = ((bool)(resources.GetObject("labelAgentStatesRowCount.AutoSize")));
			this.labelAgentStatesRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesRowCount.Dock")));
			this.labelAgentStatesRowCount.Enabled = ((bool)(resources.GetObject("labelAgentStatesRowCount.Enabled")));
			this.labelAgentStatesRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesRowCount.Font")));
			this.labelAgentStatesRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesRowCount.Image")));
			this.labelAgentStatesRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowCount.ImageAlign")));
			this.labelAgentStatesRowCount.ImageIndex = ((int)(resources.GetObject("labelAgentStatesRowCount.ImageIndex")));
			this.labelAgentStatesRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesRowCount.ImeMode")));
			this.labelAgentStatesRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesRowCount.Location")));
			this.labelAgentStatesRowCount.Name = "labelAgentStatesRowCount";
			this.labelAgentStatesRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesRowCount.RightToLeft")));
			this.labelAgentStatesRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesRowCount.Size")));
			this.labelAgentStatesRowCount.TabIndex = ((int)(resources.GetObject("labelAgentStatesRowCount.TabIndex")));
			this.labelAgentStatesRowCount.Text = resources.GetString("labelAgentStatesRowCount.Text");
			this.labelAgentStatesRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowCount.TextAlign")));
			this.labelAgentStatesRowCount.Visible = ((bool)(resources.GetObject("labelAgentStatesRowCount.Visible")));
			// 
			// labelAgentStatesRowState
			// 
			this.labelAgentStatesRowState.AccessibleDescription = resources.GetString("labelAgentStatesRowState.AccessibleDescription");
			this.labelAgentStatesRowState.AccessibleName = resources.GetString("labelAgentStatesRowState.AccessibleName");
			this.labelAgentStatesRowState.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentStatesRowState.Anchor")));
			this.labelAgentStatesRowState.AutoSize = ((bool)(resources.GetObject("labelAgentStatesRowState.AutoSize")));
			this.labelAgentStatesRowState.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentStatesRowState.Dock")));
			this.labelAgentStatesRowState.Enabled = ((bool)(resources.GetObject("labelAgentStatesRowState.Enabled")));
			this.labelAgentStatesRowState.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentStatesRowState.Font")));
			this.labelAgentStatesRowState.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentStatesRowState.Image")));
			this.labelAgentStatesRowState.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowState.ImageAlign")));
			this.labelAgentStatesRowState.ImageIndex = ((int)(resources.GetObject("labelAgentStatesRowState.ImageIndex")));
			this.labelAgentStatesRowState.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentStatesRowState.ImeMode")));
			this.labelAgentStatesRowState.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentStatesRowState.Location")));
			this.labelAgentStatesRowState.Name = "labelAgentStatesRowState";
			this.labelAgentStatesRowState.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentStatesRowState.RightToLeft")));
			this.labelAgentStatesRowState.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentStatesRowState.Size")));
			this.labelAgentStatesRowState.TabIndex = ((int)(resources.GetObject("labelAgentStatesRowState.TabIndex")));
			this.labelAgentStatesRowState.Text = resources.GetString("labelAgentStatesRowState.Text");
			this.labelAgentStatesRowState.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentStatesRowState.TextAlign")));
			this.labelAgentStatesRowState.Visible = ((bool)(resources.GetObject("labelAgentStatesRowState.Visible")));
			// 
			// groupBoxAgentModes
			// 
			this.groupBoxAgentModes.AccessibleDescription = resources.GetString("groupBoxAgentModes.AccessibleDescription");
			this.groupBoxAgentModes.AccessibleName = resources.GetString("groupBoxAgentModes.AccessibleName");
			this.groupBoxAgentModes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxAgentModes.Anchor")));
			this.groupBoxAgentModes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxAgentModes.BackgroundImage")));
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountInactive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountActive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCount);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountCap);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesBottomLineGray);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesBottomLineWhite);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountBlendedInactive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountBlendedActive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountBlended);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountBlendedCap);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountOutboundInactive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountOutboundActive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountOutbound);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountOutboundCap);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountInboundInactive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountInboundActive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountInbound);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModeCountInboundCap);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesTopLineGray);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesTopLineWhite);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesRowCountInactive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesRowCountActive);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesRowCount);
			this.groupBoxAgentModes.Controls.Add(this.labelAgentModesRowMode);
			this.groupBoxAgentModes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxAgentModes.Dock")));
			this.groupBoxAgentModes.Enabled = ((bool)(resources.GetObject("groupBoxAgentModes.Enabled")));
			this.groupBoxAgentModes.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxAgentModes.Font")));
			this.groupBoxAgentModes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxAgentModes.ImeMode")));
			this.groupBoxAgentModes.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxAgentModes.Location")));
			this.groupBoxAgentModes.Name = "groupBoxAgentModes";
			this.groupBoxAgentModes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxAgentModes.RightToLeft")));
			this.groupBoxAgentModes.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxAgentModes.Size")));
			this.groupBoxAgentModes.TabIndex = ((int)(resources.GetObject("groupBoxAgentModes.TabIndex")));
			this.groupBoxAgentModes.TabStop = false;
			this.groupBoxAgentModes.Text = resources.GetString("groupBoxAgentModes.Text");
			this.groupBoxAgentModes.Visible = ((bool)(resources.GetObject("groupBoxAgentModes.Visible")));
			// 
			// labelAgentModeCountInactive
			// 
			this.labelAgentModeCountInactive.AccessibleDescription = resources.GetString("labelAgentModeCountInactive.AccessibleDescription");
			this.labelAgentModeCountInactive.AccessibleName = resources.GetString("labelAgentModeCountInactive.AccessibleName");
			this.labelAgentModeCountInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountInactive.Anchor")));
			this.labelAgentModeCountInactive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountInactive.AutoSize")));
			this.labelAgentModeCountInactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountInactive.Dock")));
			this.labelAgentModeCountInactive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountInactive.Enabled")));
			this.labelAgentModeCountInactive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountInactive.Font")));
			this.labelAgentModeCountInactive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountInactive.Image")));
			this.labelAgentModeCountInactive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInactive.ImageAlign")));
			this.labelAgentModeCountInactive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountInactive.ImageIndex")));
			this.labelAgentModeCountInactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountInactive.ImeMode")));
			this.labelAgentModeCountInactive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountInactive.Location")));
			this.labelAgentModeCountInactive.Name = "labelAgentModeCountInactive";
			this.labelAgentModeCountInactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountInactive.RightToLeft")));
			this.labelAgentModeCountInactive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountInactive.Size")));
			this.labelAgentModeCountInactive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountInactive.TabIndex")));
			this.labelAgentModeCountInactive.Text = resources.GetString("labelAgentModeCountInactive.Text");
			this.labelAgentModeCountInactive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInactive.TextAlign")));
			this.labelAgentModeCountInactive.Visible = ((bool)(resources.GetObject("labelAgentModeCountInactive.Visible")));
			// 
			// labelAgentModeCountActive
			// 
			this.labelAgentModeCountActive.AccessibleDescription = resources.GetString("labelAgentModeCountActive.AccessibleDescription");
			this.labelAgentModeCountActive.AccessibleName = resources.GetString("labelAgentModeCountActive.AccessibleName");
			this.labelAgentModeCountActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountActive.Anchor")));
			this.labelAgentModeCountActive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountActive.AutoSize")));
			this.labelAgentModeCountActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountActive.Dock")));
			this.labelAgentModeCountActive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountActive.Enabled")));
			this.labelAgentModeCountActive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountActive.Font")));
			this.labelAgentModeCountActive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountActive.Image")));
			this.labelAgentModeCountActive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountActive.ImageAlign")));
			this.labelAgentModeCountActive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountActive.ImageIndex")));
			this.labelAgentModeCountActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountActive.ImeMode")));
			this.labelAgentModeCountActive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountActive.Location")));
			this.labelAgentModeCountActive.Name = "labelAgentModeCountActive";
			this.labelAgentModeCountActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountActive.RightToLeft")));
			this.labelAgentModeCountActive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountActive.Size")));
			this.labelAgentModeCountActive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountActive.TabIndex")));
			this.labelAgentModeCountActive.Text = resources.GetString("labelAgentModeCountActive.Text");
			this.labelAgentModeCountActive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountActive.TextAlign")));
			this.labelAgentModeCountActive.Visible = ((bool)(resources.GetObject("labelAgentModeCountActive.Visible")));
			// 
			// labelAgentModeCount
			// 
			this.labelAgentModeCount.AccessibleDescription = resources.GetString("labelAgentModeCount.AccessibleDescription");
			this.labelAgentModeCount.AccessibleName = resources.GetString("labelAgentModeCount.AccessibleName");
			this.labelAgentModeCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCount.Anchor")));
			this.labelAgentModeCount.AutoSize = ((bool)(resources.GetObject("labelAgentModeCount.AutoSize")));
			this.labelAgentModeCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCount.Dock")));
			this.labelAgentModeCount.Enabled = ((bool)(resources.GetObject("labelAgentModeCount.Enabled")));
			this.labelAgentModeCount.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCount.Font")));
			this.labelAgentModeCount.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCount.Image")));
			this.labelAgentModeCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCount.ImageAlign")));
			this.labelAgentModeCount.ImageIndex = ((int)(resources.GetObject("labelAgentModeCount.ImageIndex")));
			this.labelAgentModeCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCount.ImeMode")));
			this.labelAgentModeCount.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCount.Location")));
			this.labelAgentModeCount.Name = "labelAgentModeCount";
			this.labelAgentModeCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCount.RightToLeft")));
			this.labelAgentModeCount.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCount.Size")));
			this.labelAgentModeCount.TabIndex = ((int)(resources.GetObject("labelAgentModeCount.TabIndex")));
			this.labelAgentModeCount.Text = resources.GetString("labelAgentModeCount.Text");
			this.labelAgentModeCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCount.TextAlign")));
			this.labelAgentModeCount.Visible = ((bool)(resources.GetObject("labelAgentModeCount.Visible")));
			// 
			// labelAgentModeCountCap
			// 
			this.labelAgentModeCountCap.AccessibleDescription = resources.GetString("labelAgentModeCountCap.AccessibleDescription");
			this.labelAgentModeCountCap.AccessibleName = resources.GetString("labelAgentModeCountCap.AccessibleName");
			this.labelAgentModeCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountCap.Anchor")));
			this.labelAgentModeCountCap.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountCap.AutoSize")));
			this.labelAgentModeCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountCap.Dock")));
			this.labelAgentModeCountCap.Enabled = ((bool)(resources.GetObject("labelAgentModeCountCap.Enabled")));
			this.labelAgentModeCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountCap.Font")));
			this.labelAgentModeCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountCap.Image")));
			this.labelAgentModeCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountCap.ImageAlign")));
			this.labelAgentModeCountCap.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountCap.ImageIndex")));
			this.labelAgentModeCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountCap.ImeMode")));
			this.labelAgentModeCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountCap.Location")));
			this.labelAgentModeCountCap.Name = "labelAgentModeCountCap";
			this.labelAgentModeCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountCap.RightToLeft")));
			this.labelAgentModeCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountCap.Size")));
			this.labelAgentModeCountCap.TabIndex = ((int)(resources.GetObject("labelAgentModeCountCap.TabIndex")));
			this.labelAgentModeCountCap.Text = resources.GetString("labelAgentModeCountCap.Text");
			this.labelAgentModeCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountCap.TextAlign")));
			this.labelAgentModeCountCap.Visible = ((bool)(resources.GetObject("labelAgentModeCountCap.Visible")));
			// 
			// labelAgentModesBottomLineGray
			// 
			this.labelAgentModesBottomLineGray.AccessibleDescription = resources.GetString("labelAgentModesBottomLineGray.AccessibleDescription");
			this.labelAgentModesBottomLineGray.AccessibleName = resources.GetString("labelAgentModesBottomLineGray.AccessibleName");
			this.labelAgentModesBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesBottomLineGray.Anchor")));
			this.labelAgentModesBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelAgentModesBottomLineGray.AutoSize")));
			this.labelAgentModesBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelAgentModesBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesBottomLineGray.Dock")));
			this.labelAgentModesBottomLineGray.Enabled = ((bool)(resources.GetObject("labelAgentModesBottomLineGray.Enabled")));
			this.labelAgentModesBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesBottomLineGray.Font")));
			this.labelAgentModesBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentModesBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesBottomLineGray.Image")));
			this.labelAgentModesBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesBottomLineGray.ImageAlign")));
			this.labelAgentModesBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelAgentModesBottomLineGray.ImageIndex")));
			this.labelAgentModesBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesBottomLineGray.ImeMode")));
			this.labelAgentModesBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesBottomLineGray.Location")));
			this.labelAgentModesBottomLineGray.Name = "labelAgentModesBottomLineGray";
			this.labelAgentModesBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesBottomLineGray.RightToLeft")));
			this.labelAgentModesBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesBottomLineGray.Size")));
			this.labelAgentModesBottomLineGray.TabIndex = ((int)(resources.GetObject("labelAgentModesBottomLineGray.TabIndex")));
			this.labelAgentModesBottomLineGray.Text = resources.GetString("labelAgentModesBottomLineGray.Text");
			this.labelAgentModesBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesBottomLineGray.TextAlign")));
			this.labelAgentModesBottomLineGray.Visible = ((bool)(resources.GetObject("labelAgentModesBottomLineGray.Visible")));
			// 
			// labelAgentModesBottomLineWhite
			// 
			this.labelAgentModesBottomLineWhite.AccessibleDescription = resources.GetString("labelAgentModesBottomLineWhite.AccessibleDescription");
			this.labelAgentModesBottomLineWhite.AccessibleName = resources.GetString("labelAgentModesBottomLineWhite.AccessibleName");
			this.labelAgentModesBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesBottomLineWhite.Anchor")));
			this.labelAgentModesBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelAgentModesBottomLineWhite.AutoSize")));
			this.labelAgentModesBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelAgentModesBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesBottomLineWhite.Dock")));
			this.labelAgentModesBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelAgentModesBottomLineWhite.Enabled")));
			this.labelAgentModesBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesBottomLineWhite.Font")));
			this.labelAgentModesBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentModesBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesBottomLineWhite.Image")));
			this.labelAgentModesBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesBottomLineWhite.ImageAlign")));
			this.labelAgentModesBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelAgentModesBottomLineWhite.ImageIndex")));
			this.labelAgentModesBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesBottomLineWhite.ImeMode")));
			this.labelAgentModesBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesBottomLineWhite.Location")));
			this.labelAgentModesBottomLineWhite.Name = "labelAgentModesBottomLineWhite";
			this.labelAgentModesBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesBottomLineWhite.RightToLeft")));
			this.labelAgentModesBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesBottomLineWhite.Size")));
			this.labelAgentModesBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelAgentModesBottomLineWhite.TabIndex")));
			this.labelAgentModesBottomLineWhite.Text = resources.GetString("labelAgentModesBottomLineWhite.Text");
			this.labelAgentModesBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesBottomLineWhite.TextAlign")));
			this.labelAgentModesBottomLineWhite.Visible = ((bool)(resources.GetObject("labelAgentModesBottomLineWhite.Visible")));
			// 
			// labelAgentModeCountBlendedInactive
			// 
			this.labelAgentModeCountBlendedInactive.AccessibleDescription = resources.GetString("labelAgentModeCountBlendedInactive.AccessibleDescription");
			this.labelAgentModeCountBlendedInactive.AccessibleName = resources.GetString("labelAgentModeCountBlendedInactive.AccessibleName");
			this.labelAgentModeCountBlendedInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountBlendedInactive.Anchor")));
			this.labelAgentModeCountBlendedInactive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountBlendedInactive.AutoSize")));
			this.labelAgentModeCountBlendedInactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountBlendedInactive.Dock")));
			this.labelAgentModeCountBlendedInactive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountBlendedInactive.Enabled")));
			this.labelAgentModeCountBlendedInactive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountBlendedInactive.Font")));
			this.labelAgentModeCountBlendedInactive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountBlendedInactive.Image")));
			this.labelAgentModeCountBlendedInactive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedInactive.ImageAlign")));
			this.labelAgentModeCountBlendedInactive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedInactive.ImageIndex")));
			this.labelAgentModeCountBlendedInactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountBlendedInactive.ImeMode")));
			this.labelAgentModeCountBlendedInactive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountBlendedInactive.Location")));
			this.labelAgentModeCountBlendedInactive.Name = "labelAgentModeCountBlendedInactive";
			this.labelAgentModeCountBlendedInactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountBlendedInactive.RightToLeft")));
			this.labelAgentModeCountBlendedInactive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountBlendedInactive.Size")));
			this.labelAgentModeCountBlendedInactive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedInactive.TabIndex")));
			this.labelAgentModeCountBlendedInactive.Text = resources.GetString("labelAgentModeCountBlendedInactive.Text");
			this.labelAgentModeCountBlendedInactive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedInactive.TextAlign")));
			this.labelAgentModeCountBlendedInactive.Visible = ((bool)(resources.GetObject("labelAgentModeCountBlendedInactive.Visible")));
			// 
			// labelAgentModeCountBlendedActive
			// 
			this.labelAgentModeCountBlendedActive.AccessibleDescription = resources.GetString("labelAgentModeCountBlendedActive.AccessibleDescription");
			this.labelAgentModeCountBlendedActive.AccessibleName = resources.GetString("labelAgentModeCountBlendedActive.AccessibleName");
			this.labelAgentModeCountBlendedActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountBlendedActive.Anchor")));
			this.labelAgentModeCountBlendedActive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountBlendedActive.AutoSize")));
			this.labelAgentModeCountBlendedActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountBlendedActive.Dock")));
			this.labelAgentModeCountBlendedActive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountBlendedActive.Enabled")));
			this.labelAgentModeCountBlendedActive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountBlendedActive.Font")));
			this.labelAgentModeCountBlendedActive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountBlendedActive.Image")));
			this.labelAgentModeCountBlendedActive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedActive.ImageAlign")));
			this.labelAgentModeCountBlendedActive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedActive.ImageIndex")));
			this.labelAgentModeCountBlendedActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountBlendedActive.ImeMode")));
			this.labelAgentModeCountBlendedActive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountBlendedActive.Location")));
			this.labelAgentModeCountBlendedActive.Name = "labelAgentModeCountBlendedActive";
			this.labelAgentModeCountBlendedActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountBlendedActive.RightToLeft")));
			this.labelAgentModeCountBlendedActive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountBlendedActive.Size")));
			this.labelAgentModeCountBlendedActive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedActive.TabIndex")));
			this.labelAgentModeCountBlendedActive.Text = resources.GetString("labelAgentModeCountBlendedActive.Text");
			this.labelAgentModeCountBlendedActive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedActive.TextAlign")));
			this.labelAgentModeCountBlendedActive.Visible = ((bool)(resources.GetObject("labelAgentModeCountBlendedActive.Visible")));
			// 
			// labelAgentModeCountBlended
			// 
			this.labelAgentModeCountBlended.AccessibleDescription = resources.GetString("labelAgentModeCountBlended.AccessibleDescription");
			this.labelAgentModeCountBlended.AccessibleName = resources.GetString("labelAgentModeCountBlended.AccessibleName");
			this.labelAgentModeCountBlended.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountBlended.Anchor")));
			this.labelAgentModeCountBlended.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountBlended.AutoSize")));
			this.labelAgentModeCountBlended.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountBlended.Dock")));
			this.labelAgentModeCountBlended.Enabled = ((bool)(resources.GetObject("labelAgentModeCountBlended.Enabled")));
			this.labelAgentModeCountBlended.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountBlended.Font")));
			this.labelAgentModeCountBlended.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountBlended.Image")));
			this.labelAgentModeCountBlended.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlended.ImageAlign")));
			this.labelAgentModeCountBlended.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountBlended.ImageIndex")));
			this.labelAgentModeCountBlended.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountBlended.ImeMode")));
			this.labelAgentModeCountBlended.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountBlended.Location")));
			this.labelAgentModeCountBlended.Name = "labelAgentModeCountBlended";
			this.labelAgentModeCountBlended.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountBlended.RightToLeft")));
			this.labelAgentModeCountBlended.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountBlended.Size")));
			this.labelAgentModeCountBlended.TabIndex = ((int)(resources.GetObject("labelAgentModeCountBlended.TabIndex")));
			this.labelAgentModeCountBlended.Text = resources.GetString("labelAgentModeCountBlended.Text");
			this.labelAgentModeCountBlended.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlended.TextAlign")));
			this.labelAgentModeCountBlended.Visible = ((bool)(resources.GetObject("labelAgentModeCountBlended.Visible")));
			// 
			// labelAgentModeCountBlendedCap
			// 
			this.labelAgentModeCountBlendedCap.AccessibleDescription = resources.GetString("labelAgentModeCountBlendedCap.AccessibleDescription");
			this.labelAgentModeCountBlendedCap.AccessibleName = resources.GetString("labelAgentModeCountBlendedCap.AccessibleName");
			this.labelAgentModeCountBlendedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountBlendedCap.Anchor")));
			this.labelAgentModeCountBlendedCap.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountBlendedCap.AutoSize")));
			this.labelAgentModeCountBlendedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountBlendedCap.Dock")));
			this.labelAgentModeCountBlendedCap.Enabled = ((bool)(resources.GetObject("labelAgentModeCountBlendedCap.Enabled")));
			this.labelAgentModeCountBlendedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountBlendedCap.Font")));
			this.labelAgentModeCountBlendedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountBlendedCap.Image")));
			this.labelAgentModeCountBlendedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedCap.ImageAlign")));
			this.labelAgentModeCountBlendedCap.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedCap.ImageIndex")));
			this.labelAgentModeCountBlendedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountBlendedCap.ImeMode")));
			this.labelAgentModeCountBlendedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountBlendedCap.Location")));
			this.labelAgentModeCountBlendedCap.Name = "labelAgentModeCountBlendedCap";
			this.labelAgentModeCountBlendedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountBlendedCap.RightToLeft")));
			this.labelAgentModeCountBlendedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountBlendedCap.Size")));
			this.labelAgentModeCountBlendedCap.TabIndex = ((int)(resources.GetObject("labelAgentModeCountBlendedCap.TabIndex")));
			this.labelAgentModeCountBlendedCap.Text = resources.GetString("labelAgentModeCountBlendedCap.Text");
			this.labelAgentModeCountBlendedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountBlendedCap.TextAlign")));
			this.labelAgentModeCountBlendedCap.Visible = ((bool)(resources.GetObject("labelAgentModeCountBlendedCap.Visible")));
			// 
			// labelAgentModeCountOutboundInactive
			// 
			this.labelAgentModeCountOutboundInactive.AccessibleDescription = resources.GetString("labelAgentModeCountOutboundInactive.AccessibleDescription");
			this.labelAgentModeCountOutboundInactive.AccessibleName = resources.GetString("labelAgentModeCountOutboundInactive.AccessibleName");
			this.labelAgentModeCountOutboundInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountOutboundInactive.Anchor")));
			this.labelAgentModeCountOutboundInactive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountOutboundInactive.AutoSize")));
			this.labelAgentModeCountOutboundInactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountOutboundInactive.Dock")));
			this.labelAgentModeCountOutboundInactive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountOutboundInactive.Enabled")));
			this.labelAgentModeCountOutboundInactive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountOutboundInactive.Font")));
			this.labelAgentModeCountOutboundInactive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountOutboundInactive.Image")));
			this.labelAgentModeCountOutboundInactive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundInactive.ImageAlign")));
			this.labelAgentModeCountOutboundInactive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundInactive.ImageIndex")));
			this.labelAgentModeCountOutboundInactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountOutboundInactive.ImeMode")));
			this.labelAgentModeCountOutboundInactive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountOutboundInactive.Location")));
			this.labelAgentModeCountOutboundInactive.Name = "labelAgentModeCountOutboundInactive";
			this.labelAgentModeCountOutboundInactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountOutboundInactive.RightToLeft")));
			this.labelAgentModeCountOutboundInactive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountOutboundInactive.Size")));
			this.labelAgentModeCountOutboundInactive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundInactive.TabIndex")));
			this.labelAgentModeCountOutboundInactive.Text = resources.GetString("labelAgentModeCountOutboundInactive.Text");
			this.labelAgentModeCountOutboundInactive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundInactive.TextAlign")));
			this.labelAgentModeCountOutboundInactive.Visible = ((bool)(resources.GetObject("labelAgentModeCountOutboundInactive.Visible")));
			// 
			// labelAgentModeCountOutboundActive
			// 
			this.labelAgentModeCountOutboundActive.AccessibleDescription = resources.GetString("labelAgentModeCountOutboundActive.AccessibleDescription");
			this.labelAgentModeCountOutboundActive.AccessibleName = resources.GetString("labelAgentModeCountOutboundActive.AccessibleName");
			this.labelAgentModeCountOutboundActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountOutboundActive.Anchor")));
			this.labelAgentModeCountOutboundActive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountOutboundActive.AutoSize")));
			this.labelAgentModeCountOutboundActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountOutboundActive.Dock")));
			this.labelAgentModeCountOutboundActive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountOutboundActive.Enabled")));
			this.labelAgentModeCountOutboundActive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountOutboundActive.Font")));
			this.labelAgentModeCountOutboundActive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountOutboundActive.Image")));
			this.labelAgentModeCountOutboundActive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundActive.ImageAlign")));
			this.labelAgentModeCountOutboundActive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundActive.ImageIndex")));
			this.labelAgentModeCountOutboundActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountOutboundActive.ImeMode")));
			this.labelAgentModeCountOutboundActive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountOutboundActive.Location")));
			this.labelAgentModeCountOutboundActive.Name = "labelAgentModeCountOutboundActive";
			this.labelAgentModeCountOutboundActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountOutboundActive.RightToLeft")));
			this.labelAgentModeCountOutboundActive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountOutboundActive.Size")));
			this.labelAgentModeCountOutboundActive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundActive.TabIndex")));
			this.labelAgentModeCountOutboundActive.Text = resources.GetString("labelAgentModeCountOutboundActive.Text");
			this.labelAgentModeCountOutboundActive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundActive.TextAlign")));
			this.labelAgentModeCountOutboundActive.Visible = ((bool)(resources.GetObject("labelAgentModeCountOutboundActive.Visible")));
			// 
			// labelAgentModeCountOutbound
			// 
			this.labelAgentModeCountOutbound.AccessibleDescription = resources.GetString("labelAgentModeCountOutbound.AccessibleDescription");
			this.labelAgentModeCountOutbound.AccessibleName = resources.GetString("labelAgentModeCountOutbound.AccessibleName");
			this.labelAgentModeCountOutbound.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountOutbound.Anchor")));
			this.labelAgentModeCountOutbound.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountOutbound.AutoSize")));
			this.labelAgentModeCountOutbound.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountOutbound.Dock")));
			this.labelAgentModeCountOutbound.Enabled = ((bool)(resources.GetObject("labelAgentModeCountOutbound.Enabled")));
			this.labelAgentModeCountOutbound.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountOutbound.Font")));
			this.labelAgentModeCountOutbound.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountOutbound.Image")));
			this.labelAgentModeCountOutbound.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutbound.ImageAlign")));
			this.labelAgentModeCountOutbound.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountOutbound.ImageIndex")));
			this.labelAgentModeCountOutbound.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountOutbound.ImeMode")));
			this.labelAgentModeCountOutbound.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountOutbound.Location")));
			this.labelAgentModeCountOutbound.Name = "labelAgentModeCountOutbound";
			this.labelAgentModeCountOutbound.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountOutbound.RightToLeft")));
			this.labelAgentModeCountOutbound.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountOutbound.Size")));
			this.labelAgentModeCountOutbound.TabIndex = ((int)(resources.GetObject("labelAgentModeCountOutbound.TabIndex")));
			this.labelAgentModeCountOutbound.Text = resources.GetString("labelAgentModeCountOutbound.Text");
			this.labelAgentModeCountOutbound.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutbound.TextAlign")));
			this.labelAgentModeCountOutbound.Visible = ((bool)(resources.GetObject("labelAgentModeCountOutbound.Visible")));
			// 
			// labelAgentModeCountOutboundCap
			// 
			this.labelAgentModeCountOutboundCap.AccessibleDescription = resources.GetString("labelAgentModeCountOutboundCap.AccessibleDescription");
			this.labelAgentModeCountOutboundCap.AccessibleName = resources.GetString("labelAgentModeCountOutboundCap.AccessibleName");
			this.labelAgentModeCountOutboundCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountOutboundCap.Anchor")));
			this.labelAgentModeCountOutboundCap.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountOutboundCap.AutoSize")));
			this.labelAgentModeCountOutboundCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountOutboundCap.Dock")));
			this.labelAgentModeCountOutboundCap.Enabled = ((bool)(resources.GetObject("labelAgentModeCountOutboundCap.Enabled")));
			this.labelAgentModeCountOutboundCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountOutboundCap.Font")));
			this.labelAgentModeCountOutboundCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountOutboundCap.Image")));
			this.labelAgentModeCountOutboundCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundCap.ImageAlign")));
			this.labelAgentModeCountOutboundCap.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundCap.ImageIndex")));
			this.labelAgentModeCountOutboundCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountOutboundCap.ImeMode")));
			this.labelAgentModeCountOutboundCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountOutboundCap.Location")));
			this.labelAgentModeCountOutboundCap.Name = "labelAgentModeCountOutboundCap";
			this.labelAgentModeCountOutboundCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountOutboundCap.RightToLeft")));
			this.labelAgentModeCountOutboundCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountOutboundCap.Size")));
			this.labelAgentModeCountOutboundCap.TabIndex = ((int)(resources.GetObject("labelAgentModeCountOutboundCap.TabIndex")));
			this.labelAgentModeCountOutboundCap.Text = resources.GetString("labelAgentModeCountOutboundCap.Text");
			this.labelAgentModeCountOutboundCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountOutboundCap.TextAlign")));
			this.labelAgentModeCountOutboundCap.Visible = ((bool)(resources.GetObject("labelAgentModeCountOutboundCap.Visible")));
			// 
			// labelAgentModeCountInboundInactive
			// 
			this.labelAgentModeCountInboundInactive.AccessibleDescription = resources.GetString("labelAgentModeCountInboundInactive.AccessibleDescription");
			this.labelAgentModeCountInboundInactive.AccessibleName = resources.GetString("labelAgentModeCountInboundInactive.AccessibleName");
			this.labelAgentModeCountInboundInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountInboundInactive.Anchor")));
			this.labelAgentModeCountInboundInactive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountInboundInactive.AutoSize")));
			this.labelAgentModeCountInboundInactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountInboundInactive.Dock")));
			this.labelAgentModeCountInboundInactive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountInboundInactive.Enabled")));
			this.labelAgentModeCountInboundInactive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountInboundInactive.Font")));
			this.labelAgentModeCountInboundInactive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountInboundInactive.Image")));
			this.labelAgentModeCountInboundInactive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundInactive.ImageAlign")));
			this.labelAgentModeCountInboundInactive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountInboundInactive.ImageIndex")));
			this.labelAgentModeCountInboundInactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountInboundInactive.ImeMode")));
			this.labelAgentModeCountInboundInactive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountInboundInactive.Location")));
			this.labelAgentModeCountInboundInactive.Name = "labelAgentModeCountInboundInactive";
			this.labelAgentModeCountInboundInactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountInboundInactive.RightToLeft")));
			this.labelAgentModeCountInboundInactive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountInboundInactive.Size")));
			this.labelAgentModeCountInboundInactive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountInboundInactive.TabIndex")));
			this.labelAgentModeCountInboundInactive.Text = resources.GetString("labelAgentModeCountInboundInactive.Text");
			this.labelAgentModeCountInboundInactive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundInactive.TextAlign")));
			this.labelAgentModeCountInboundInactive.Visible = ((bool)(resources.GetObject("labelAgentModeCountInboundInactive.Visible")));
			// 
			// labelAgentModeCountInboundActive
			// 
			this.labelAgentModeCountInboundActive.AccessibleDescription = resources.GetString("labelAgentModeCountInboundActive.AccessibleDescription");
			this.labelAgentModeCountInboundActive.AccessibleName = resources.GetString("labelAgentModeCountInboundActive.AccessibleName");
			this.labelAgentModeCountInboundActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountInboundActive.Anchor")));
			this.labelAgentModeCountInboundActive.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountInboundActive.AutoSize")));
			this.labelAgentModeCountInboundActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountInboundActive.Dock")));
			this.labelAgentModeCountInboundActive.Enabled = ((bool)(resources.GetObject("labelAgentModeCountInboundActive.Enabled")));
			this.labelAgentModeCountInboundActive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountInboundActive.Font")));
			this.labelAgentModeCountInboundActive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountInboundActive.Image")));
			this.labelAgentModeCountInboundActive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundActive.ImageAlign")));
			this.labelAgentModeCountInboundActive.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountInboundActive.ImageIndex")));
			this.labelAgentModeCountInboundActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountInboundActive.ImeMode")));
			this.labelAgentModeCountInboundActive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountInboundActive.Location")));
			this.labelAgentModeCountInboundActive.Name = "labelAgentModeCountInboundActive";
			this.labelAgentModeCountInboundActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountInboundActive.RightToLeft")));
			this.labelAgentModeCountInboundActive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountInboundActive.Size")));
			this.labelAgentModeCountInboundActive.TabIndex = ((int)(resources.GetObject("labelAgentModeCountInboundActive.TabIndex")));
			this.labelAgentModeCountInboundActive.Text = resources.GetString("labelAgentModeCountInboundActive.Text");
			this.labelAgentModeCountInboundActive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundActive.TextAlign")));
			this.labelAgentModeCountInboundActive.Visible = ((bool)(resources.GetObject("labelAgentModeCountInboundActive.Visible")));
			// 
			// labelAgentModeCountInbound
			// 
			this.labelAgentModeCountInbound.AccessibleDescription = resources.GetString("labelAgentModeCountInbound.AccessibleDescription");
			this.labelAgentModeCountInbound.AccessibleName = resources.GetString("labelAgentModeCountInbound.AccessibleName");
			this.labelAgentModeCountInbound.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountInbound.Anchor")));
			this.labelAgentModeCountInbound.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountInbound.AutoSize")));
			this.labelAgentModeCountInbound.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountInbound.Dock")));
			this.labelAgentModeCountInbound.Enabled = ((bool)(resources.GetObject("labelAgentModeCountInbound.Enabled")));
			this.labelAgentModeCountInbound.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountInbound.Font")));
			this.labelAgentModeCountInbound.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountInbound.Image")));
			this.labelAgentModeCountInbound.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInbound.ImageAlign")));
			this.labelAgentModeCountInbound.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountInbound.ImageIndex")));
			this.labelAgentModeCountInbound.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountInbound.ImeMode")));
			this.labelAgentModeCountInbound.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountInbound.Location")));
			this.labelAgentModeCountInbound.Name = "labelAgentModeCountInbound";
			this.labelAgentModeCountInbound.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountInbound.RightToLeft")));
			this.labelAgentModeCountInbound.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountInbound.Size")));
			this.labelAgentModeCountInbound.TabIndex = ((int)(resources.GetObject("labelAgentModeCountInbound.TabIndex")));
			this.labelAgentModeCountInbound.Text = resources.GetString("labelAgentModeCountInbound.Text");
			this.labelAgentModeCountInbound.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInbound.TextAlign")));
			this.labelAgentModeCountInbound.Visible = ((bool)(resources.GetObject("labelAgentModeCountInbound.Visible")));
			// 
			// labelAgentModeCountInboundCap
			// 
			this.labelAgentModeCountInboundCap.AccessibleDescription = resources.GetString("labelAgentModeCountInboundCap.AccessibleDescription");
			this.labelAgentModeCountInboundCap.AccessibleName = resources.GetString("labelAgentModeCountInboundCap.AccessibleName");
			this.labelAgentModeCountInboundCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModeCountInboundCap.Anchor")));
			this.labelAgentModeCountInboundCap.AutoSize = ((bool)(resources.GetObject("labelAgentModeCountInboundCap.AutoSize")));
			this.labelAgentModeCountInboundCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModeCountInboundCap.Dock")));
			this.labelAgentModeCountInboundCap.Enabled = ((bool)(resources.GetObject("labelAgentModeCountInboundCap.Enabled")));
			this.labelAgentModeCountInboundCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModeCountInboundCap.Font")));
			this.labelAgentModeCountInboundCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModeCountInboundCap.Image")));
			this.labelAgentModeCountInboundCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundCap.ImageAlign")));
			this.labelAgentModeCountInboundCap.ImageIndex = ((int)(resources.GetObject("labelAgentModeCountInboundCap.ImageIndex")));
			this.labelAgentModeCountInboundCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModeCountInboundCap.ImeMode")));
			this.labelAgentModeCountInboundCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModeCountInboundCap.Location")));
			this.labelAgentModeCountInboundCap.Name = "labelAgentModeCountInboundCap";
			this.labelAgentModeCountInboundCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModeCountInboundCap.RightToLeft")));
			this.labelAgentModeCountInboundCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModeCountInboundCap.Size")));
			this.labelAgentModeCountInboundCap.TabIndex = ((int)(resources.GetObject("labelAgentModeCountInboundCap.TabIndex")));
			this.labelAgentModeCountInboundCap.Text = resources.GetString("labelAgentModeCountInboundCap.Text");
			this.labelAgentModeCountInboundCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModeCountInboundCap.TextAlign")));
			this.labelAgentModeCountInboundCap.Visible = ((bool)(resources.GetObject("labelAgentModeCountInboundCap.Visible")));
			// 
			// labelAgentModesTopLineGray
			// 
			this.labelAgentModesTopLineGray.AccessibleDescription = resources.GetString("labelAgentModesTopLineGray.AccessibleDescription");
			this.labelAgentModesTopLineGray.AccessibleName = resources.GetString("labelAgentModesTopLineGray.AccessibleName");
			this.labelAgentModesTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesTopLineGray.Anchor")));
			this.labelAgentModesTopLineGray.AutoSize = ((bool)(resources.GetObject("labelAgentModesTopLineGray.AutoSize")));
			this.labelAgentModesTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelAgentModesTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesTopLineGray.Dock")));
			this.labelAgentModesTopLineGray.Enabled = ((bool)(resources.GetObject("labelAgentModesTopLineGray.Enabled")));
			this.labelAgentModesTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesTopLineGray.Font")));
			this.labelAgentModesTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentModesTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesTopLineGray.Image")));
			this.labelAgentModesTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesTopLineGray.ImageAlign")));
			this.labelAgentModesTopLineGray.ImageIndex = ((int)(resources.GetObject("labelAgentModesTopLineGray.ImageIndex")));
			this.labelAgentModesTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesTopLineGray.ImeMode")));
			this.labelAgentModesTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesTopLineGray.Location")));
			this.labelAgentModesTopLineGray.Name = "labelAgentModesTopLineGray";
			this.labelAgentModesTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesTopLineGray.RightToLeft")));
			this.labelAgentModesTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesTopLineGray.Size")));
			this.labelAgentModesTopLineGray.TabIndex = ((int)(resources.GetObject("labelAgentModesTopLineGray.TabIndex")));
			this.labelAgentModesTopLineGray.Text = resources.GetString("labelAgentModesTopLineGray.Text");
			this.labelAgentModesTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesTopLineGray.TextAlign")));
			this.labelAgentModesTopLineGray.Visible = ((bool)(resources.GetObject("labelAgentModesTopLineGray.Visible")));
			// 
			// labelAgentModesTopLineWhite
			// 
			this.labelAgentModesTopLineWhite.AccessibleDescription = resources.GetString("labelAgentModesTopLineWhite.AccessibleDescription");
			this.labelAgentModesTopLineWhite.AccessibleName = resources.GetString("labelAgentModesTopLineWhite.AccessibleName");
			this.labelAgentModesTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesTopLineWhite.Anchor")));
			this.labelAgentModesTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelAgentModesTopLineWhite.AutoSize")));
			this.labelAgentModesTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelAgentModesTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesTopLineWhite.Dock")));
			this.labelAgentModesTopLineWhite.Enabled = ((bool)(resources.GetObject("labelAgentModesTopLineWhite.Enabled")));
			this.labelAgentModesTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesTopLineWhite.Font")));
			this.labelAgentModesTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelAgentModesTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesTopLineWhite.Image")));
			this.labelAgentModesTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesTopLineWhite.ImageAlign")));
			this.labelAgentModesTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelAgentModesTopLineWhite.ImageIndex")));
			this.labelAgentModesTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesTopLineWhite.ImeMode")));
			this.labelAgentModesTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesTopLineWhite.Location")));
			this.labelAgentModesTopLineWhite.Name = "labelAgentModesTopLineWhite";
			this.labelAgentModesTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesTopLineWhite.RightToLeft")));
			this.labelAgentModesTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesTopLineWhite.Size")));
			this.labelAgentModesTopLineWhite.TabIndex = ((int)(resources.GetObject("labelAgentModesTopLineWhite.TabIndex")));
			this.labelAgentModesTopLineWhite.Text = resources.GetString("labelAgentModesTopLineWhite.Text");
			this.labelAgentModesTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesTopLineWhite.TextAlign")));
			this.labelAgentModesTopLineWhite.Visible = ((bool)(resources.GetObject("labelAgentModesTopLineWhite.Visible")));
			// 
			// labelAgentModesRowCountInactive
			// 
			this.labelAgentModesRowCountInactive.AccessibleDescription = resources.GetString("labelAgentModesRowCountInactive.AccessibleDescription");
			this.labelAgentModesRowCountInactive.AccessibleName = resources.GetString("labelAgentModesRowCountInactive.AccessibleName");
			this.labelAgentModesRowCountInactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesRowCountInactive.Anchor")));
			this.labelAgentModesRowCountInactive.AutoSize = ((bool)(resources.GetObject("labelAgentModesRowCountInactive.AutoSize")));
			this.labelAgentModesRowCountInactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesRowCountInactive.Dock")));
			this.labelAgentModesRowCountInactive.Enabled = ((bool)(resources.GetObject("labelAgentModesRowCountInactive.Enabled")));
			this.labelAgentModesRowCountInactive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesRowCountInactive.Font")));
			this.labelAgentModesRowCountInactive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesRowCountInactive.Image")));
			this.labelAgentModesRowCountInactive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCountInactive.ImageAlign")));
			this.labelAgentModesRowCountInactive.ImageIndex = ((int)(resources.GetObject("labelAgentModesRowCountInactive.ImageIndex")));
			this.labelAgentModesRowCountInactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesRowCountInactive.ImeMode")));
			this.labelAgentModesRowCountInactive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesRowCountInactive.Location")));
			this.labelAgentModesRowCountInactive.Name = "labelAgentModesRowCountInactive";
			this.labelAgentModesRowCountInactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesRowCountInactive.RightToLeft")));
			this.labelAgentModesRowCountInactive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesRowCountInactive.Size")));
			this.labelAgentModesRowCountInactive.TabIndex = ((int)(resources.GetObject("labelAgentModesRowCountInactive.TabIndex")));
			this.labelAgentModesRowCountInactive.Text = resources.GetString("labelAgentModesRowCountInactive.Text");
			this.labelAgentModesRowCountInactive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCountInactive.TextAlign")));
			this.labelAgentModesRowCountInactive.Visible = ((bool)(resources.GetObject("labelAgentModesRowCountInactive.Visible")));
			// 
			// labelAgentModesRowCountActive
			// 
			this.labelAgentModesRowCountActive.AccessibleDescription = resources.GetString("labelAgentModesRowCountActive.AccessibleDescription");
			this.labelAgentModesRowCountActive.AccessibleName = resources.GetString("labelAgentModesRowCountActive.AccessibleName");
			this.labelAgentModesRowCountActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesRowCountActive.Anchor")));
			this.labelAgentModesRowCountActive.AutoSize = ((bool)(resources.GetObject("labelAgentModesRowCountActive.AutoSize")));
			this.labelAgentModesRowCountActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesRowCountActive.Dock")));
			this.labelAgentModesRowCountActive.Enabled = ((bool)(resources.GetObject("labelAgentModesRowCountActive.Enabled")));
			this.labelAgentModesRowCountActive.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesRowCountActive.Font")));
			this.labelAgentModesRowCountActive.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesRowCountActive.Image")));
			this.labelAgentModesRowCountActive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCountActive.ImageAlign")));
			this.labelAgentModesRowCountActive.ImageIndex = ((int)(resources.GetObject("labelAgentModesRowCountActive.ImageIndex")));
			this.labelAgentModesRowCountActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesRowCountActive.ImeMode")));
			this.labelAgentModesRowCountActive.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesRowCountActive.Location")));
			this.labelAgentModesRowCountActive.Name = "labelAgentModesRowCountActive";
			this.labelAgentModesRowCountActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesRowCountActive.RightToLeft")));
			this.labelAgentModesRowCountActive.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesRowCountActive.Size")));
			this.labelAgentModesRowCountActive.TabIndex = ((int)(resources.GetObject("labelAgentModesRowCountActive.TabIndex")));
			this.labelAgentModesRowCountActive.Text = resources.GetString("labelAgentModesRowCountActive.Text");
			this.labelAgentModesRowCountActive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCountActive.TextAlign")));
			this.labelAgentModesRowCountActive.Visible = ((bool)(resources.GetObject("labelAgentModesRowCountActive.Visible")));
			// 
			// labelAgentModesRowCount
			// 
			this.labelAgentModesRowCount.AccessibleDescription = resources.GetString("labelAgentModesRowCount.AccessibleDescription");
			this.labelAgentModesRowCount.AccessibleName = resources.GetString("labelAgentModesRowCount.AccessibleName");
			this.labelAgentModesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesRowCount.Anchor")));
			this.labelAgentModesRowCount.AutoSize = ((bool)(resources.GetObject("labelAgentModesRowCount.AutoSize")));
			this.labelAgentModesRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesRowCount.Dock")));
			this.labelAgentModesRowCount.Enabled = ((bool)(resources.GetObject("labelAgentModesRowCount.Enabled")));
			this.labelAgentModesRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesRowCount.Font")));
			this.labelAgentModesRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesRowCount.Image")));
			this.labelAgentModesRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCount.ImageAlign")));
			this.labelAgentModesRowCount.ImageIndex = ((int)(resources.GetObject("labelAgentModesRowCount.ImageIndex")));
			this.labelAgentModesRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesRowCount.ImeMode")));
			this.labelAgentModesRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesRowCount.Location")));
			this.labelAgentModesRowCount.Name = "labelAgentModesRowCount";
			this.labelAgentModesRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesRowCount.RightToLeft")));
			this.labelAgentModesRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesRowCount.Size")));
			this.labelAgentModesRowCount.TabIndex = ((int)(resources.GetObject("labelAgentModesRowCount.TabIndex")));
			this.labelAgentModesRowCount.Text = resources.GetString("labelAgentModesRowCount.Text");
			this.labelAgentModesRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowCount.TextAlign")));
			this.labelAgentModesRowCount.Visible = ((bool)(resources.GetObject("labelAgentModesRowCount.Visible")));
			// 
			// labelAgentModesRowMode
			// 
			this.labelAgentModesRowMode.AccessibleDescription = resources.GetString("labelAgentModesRowMode.AccessibleDescription");
			this.labelAgentModesRowMode.AccessibleName = resources.GetString("labelAgentModesRowMode.AccessibleName");
			this.labelAgentModesRowMode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentModesRowMode.Anchor")));
			this.labelAgentModesRowMode.AutoSize = ((bool)(resources.GetObject("labelAgentModesRowMode.AutoSize")));
			this.labelAgentModesRowMode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentModesRowMode.Dock")));
			this.labelAgentModesRowMode.Enabled = ((bool)(resources.GetObject("labelAgentModesRowMode.Enabled")));
			this.labelAgentModesRowMode.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentModesRowMode.Font")));
			this.labelAgentModesRowMode.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentModesRowMode.Image")));
			this.labelAgentModesRowMode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowMode.ImageAlign")));
			this.labelAgentModesRowMode.ImageIndex = ((int)(resources.GetObject("labelAgentModesRowMode.ImageIndex")));
			this.labelAgentModesRowMode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentModesRowMode.ImeMode")));
			this.labelAgentModesRowMode.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentModesRowMode.Location")));
			this.labelAgentModesRowMode.Name = "labelAgentModesRowMode";
			this.labelAgentModesRowMode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentModesRowMode.RightToLeft")));
			this.labelAgentModesRowMode.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentModesRowMode.Size")));
			this.labelAgentModesRowMode.TabIndex = ((int)(resources.GetObject("labelAgentModesRowMode.TabIndex")));
			this.labelAgentModesRowMode.Text = resources.GetString("labelAgentModesRowMode.Text");
			this.labelAgentModesRowMode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentModesRowMode.TextAlign")));
			this.labelAgentModesRowMode.Visible = ((bool)(resources.GetObject("labelAgentModesRowMode.Visible")));
			// 
			// CampaignViewAgents
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartAgentStateTime);
			this.Controls.Add(this.groupBoxChartAgentStateCount);
			this.Controls.Add(this.groupBoxAgentStates);
			this.Controls.Add(this.groupBoxAgentModes);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewAgents";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartAgentStateTime.ResumeLayout(false);
			this.panelChartAgentStateTime.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartAgentStateTime)).EndInit();
			this.groupBoxChartAgentStateCount.ResumeLayout(false);
			this.panelChartAgentStateCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartAgentStateCount)).EndInit();
			this.groupBoxAgentStates.ResumeLayout(false);
			this.groupBoxAgentModes.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// Modusverteilung aktualisieren
			labelAgentModeCountInbound.Text =
				campaign.GetAgentModeCount(AgentMode.Inbound).ToString();
			labelAgentModeCountOutbound.Text =
				campaign.GetAgentModeCount(AgentMode.Outbound).ToString();
			labelAgentModeCountBlended.Text =
				campaign.GetAgentModeCount(AgentMode.Blended).ToString();
			labelAgentModeCount.Text = campaign.AgentCount.ToString();
			labelAgentModeCountInboundActive.Text =
				campaign.GetAgentModeCountActive(AgentMode.Inbound).ToString();
			labelAgentModeCountOutboundActive.Text =
				campaign.GetAgentModeCountActive(AgentMode.Outbound).ToString();
			labelAgentModeCountBlendedActive.Text =
				campaign.GetAgentModeCountActive(AgentMode.Blended).ToString();
			labelAgentModeCountActive.Text =
				(campaign.GetAgentModeCountActive(AgentMode.Inbound) +
				campaign.GetAgentModeCountActive(AgentMode.Outbound) +
				campaign.GetAgentModeCountActive(AgentMode.Blended)).ToString();
			labelAgentModeCountInboundInactive.Text =
				campaign.GetAgentModeCountInactive(AgentMode.Inbound).ToString();
			labelAgentModeCountOutboundInactive.Text =
				campaign.GetAgentModeCountInactive(AgentMode.Outbound).ToString();
			labelAgentModeCountBlendedInactive.Text =
				campaign.GetAgentModeCountInactive(AgentMode.Blended).ToString();
			labelAgentModeCountInactive.Text =
				(campaign.GetAgentModeCountInactive(AgentMode.Inbound) +
				campaign.GetAgentModeCountInactive(AgentMode.Outbound) +
				campaign.GetAgentModeCountInactive(AgentMode.Blended)).ToString();

			// Statusverteilung aktualisieren
			labelAgentStateCountUnassigned.Text =
				campaign.GetAgentStateCount(AgentState.Unassigned).ToString();
			labelAgentStateCountNotReady.Text =
				campaign.GetAgentStateCount(AgentState.NotReady).ToString();
			labelAgentStateCountReady.Text =
				campaign.GetAgentStateCount(AgentState.Ready).ToString();
			labelAgentStateCountPending.Text =
				campaign.GetAgentStateCount(AgentState.Pending).ToString();
			labelAgentStateCountSignaling.Text =
				campaign.GetAgentStateCount(AgentState.Signaling).ToString();
			labelAgentStateCountPreparing.Text =
				campaign.GetAgentStateCount(AgentState.Preparing).ToString();
			labelAgentStateCountCalling.Text =
				campaign.GetAgentStateCount(AgentState.Calling).ToString();
			labelAgentStateCountTalking.Text =
				campaign.GetAgentStateCount(AgentState.Talking).ToString();
			labelAgentStateCountConferencing.Text =
				campaign.GetAgentStateCount(AgentState.Conferencing).ToString();
			labelAgentStateCountWrapup.Text =
				campaign.GetAgentStateCount(AgentState.Wrapup).ToString();
			labelAgentStateCount.Text = campaign.AgentCount.ToString();
			labelAgentStateTimeUnassignedCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Unassigned));
			labelAgentStateTimeNotReadyCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.NotReady));
			labelAgentStateTimeReadyCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Ready));
			labelAgentStateTimePendingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Pending));
			labelAgentStateTimeSignalingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Signaling));
			labelAgentStateTimePreparingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Preparing));
			labelAgentStateTimeCallingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Calling));
			labelAgentStateTimeTalkingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Talking));
			labelAgentStateTimeConferencingCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Conferencing));
			labelAgentStateTimeWrapupCur.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgCur(AgentState.Wrapup));
			labelAgentStateTimeUnassignedTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Unassigned));
			labelAgentStateTimeNotReadyTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.NotReady));
			labelAgentStateTimeReadyTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Ready));
			labelAgentStateTimePendingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Pending));
			labelAgentStateTimeSignalingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Signaling));
			labelAgentStateTimePreparingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Preparing));
			labelAgentStateTimeCallingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Calling));
			labelAgentStateTimeTalkingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Talking));
			labelAgentStateTimeConferencingTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Conferencing));
			labelAgentStateTimeWrapupTtl.Text =
				FormatTimeSpan(campaign.GetAgentStateTimeAvgTtl(AgentState.Wrapup));

			// Verlaufsgrafiken aktualisieren
			chartAgentStateCount.DataCollection = campaign.AgentStateCountData;
			chartAgentStateTime.DataCollection = campaign.AgentStateTimeData;
		}

		/// <summary>
		/// gibt in Sekunden übergebene Zeitspanne im Format hh:mm:ss zurück
		/// </summary>
		private string FormatTimeSpan(int seconds)
		{
			TimeSpan timeSpan = new TimeSpan(0, 0, seconds);
			return timeSpan.Hours.ToString("00") + ":" + timeSpan.Minutes.ToString("00") + ":" +
				timeSpan.Seconds.ToString("00");
		}

		#endregion

		#endregion
	}
}
