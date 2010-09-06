using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der eingehenden Anrufe einer Kampagne.
	/// </summary>
	public class CampaignViewIncomingCalls : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxIncomingCallStates;
		private System.Windows.Forms.Label labelIncomingCallStatesRowState;
		private System.Windows.Forms.Label labelIncomingCallStatesRowCount;
		private System.Windows.Forms.Label labelIncomingCallStatesTopLineWhite;
		private System.Windows.Forms.Label labelIncomingCallStatesTopLineGray;
		private System.Windows.Forms.Label labelIncomingCallStateCountAlertingCap;
		private System.Windows.Forms.Label labelIncomingCallStateCountAlerting;
		private System.Windows.Forms.Label labelIncomingCallStateCountGreetingCap;
		private System.Windows.Forms.Label labelIncomingCallStateCountGreeting;
		private System.Windows.Forms.Label labelIncomingCallStateCountWaitingCap;
		private System.Windows.Forms.Label labelIncomingCallStateCountWaiting;
		private System.Windows.Forms.Label labelIncomingCallStateCountSignalingCap;
		private System.Windows.Forms.Label labelIncomingCallStateCountSignaling;
		private System.Windows.Forms.Label labelIncomingCallStatesBottomLineWhite;
		private System.Windows.Forms.Label labelIncomingCallStatesBottomLineGray;
		private System.Windows.Forms.Label labelIncomingCallStateCountCap;
		private System.Windows.Forms.Label labelIncomingCallStateCount;
		private System.Windows.Forms.GroupBox groupBoxChartIncomingCallStateCount;
		private System.Windows.Forms.Panel panelChartIncomingCallStateCount;
		private itCampus.bb.Graph.Chart.Chart chartIncomingCallStateCount;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewIncomingCalls()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewIncomingCalls));
			itCampus.bb.Graph.Chart.Curve curve1 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve2 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve3 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve4 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve5 = new itCampus.bb.Graph.Chart.Curve();
			this.groupBoxChartIncomingCallStateCount = new System.Windows.Forms.GroupBox();
			this.panelChartIncomingCallStateCount = new System.Windows.Forms.Panel();
			this.chartIncomingCallStateCount = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxIncomingCallStates = new System.Windows.Forms.GroupBox();
			this.labelIncomingCallStateCount = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountCap = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesBottomLineGray = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesBottomLineWhite = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountSignaling = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountSignalingCap = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountWaiting = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountWaitingCap = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountGreeting = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountGreetingCap = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountAlerting = new System.Windows.Forms.Label();
			this.labelIncomingCallStateCountAlertingCap = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesTopLineGray = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesTopLineWhite = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesRowCount = new System.Windows.Forms.Label();
			this.labelIncomingCallStatesRowState = new System.Windows.Forms.Label();
			this.groupBoxChartIncomingCallStateCount.SuspendLayout();
			this.panelChartIncomingCallStateCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartIncomingCallStateCount)).BeginInit();
			this.groupBoxIncomingCallStates.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartIncomingCallStateCount
			// 
			this.groupBoxChartIncomingCallStateCount.AccessibleDescription = resources.GetString("groupBoxChartIncomingCallStateCount.AccessibleDescription");
			this.groupBoxChartIncomingCallStateCount.AccessibleName = resources.GetString("groupBoxChartIncomingCallStateCount.AccessibleName");
			this.groupBoxChartIncomingCallStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartIncomingCallStateCount.Anchor")));
			this.groupBoxChartIncomingCallStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartIncomingCallStateCount.BackgroundImage")));
			this.groupBoxChartIncomingCallStateCount.Controls.Add(this.panelChartIncomingCallStateCount);
			this.groupBoxChartIncomingCallStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartIncomingCallStateCount.Dock")));
			this.groupBoxChartIncomingCallStateCount.Enabled = ((bool)(resources.GetObject("groupBoxChartIncomingCallStateCount.Enabled")));
			this.groupBoxChartIncomingCallStateCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartIncomingCallStateCount.Font")));
			this.groupBoxChartIncomingCallStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartIncomingCallStateCount.ImeMode")));
			this.groupBoxChartIncomingCallStateCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartIncomingCallStateCount.Location")));
			this.groupBoxChartIncomingCallStateCount.Name = "groupBoxChartIncomingCallStateCount";
			this.groupBoxChartIncomingCallStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartIncomingCallStateCount.RightToLeft")));
			this.groupBoxChartIncomingCallStateCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartIncomingCallStateCount.Size")));
			this.groupBoxChartIncomingCallStateCount.TabIndex = ((int)(resources.GetObject("groupBoxChartIncomingCallStateCount.TabIndex")));
			this.groupBoxChartIncomingCallStateCount.TabStop = false;
			this.groupBoxChartIncomingCallStateCount.Text = resources.GetString("groupBoxChartIncomingCallStateCount.Text");
			this.groupBoxChartIncomingCallStateCount.Visible = ((bool)(resources.GetObject("groupBoxChartIncomingCallStateCount.Visible")));
			// 
			// panelChartIncomingCallStateCount
			// 
			this.panelChartIncomingCallStateCount.AccessibleDescription = resources.GetString("panelChartIncomingCallStateCount.AccessibleDescription");
			this.panelChartIncomingCallStateCount.AccessibleName = resources.GetString("panelChartIncomingCallStateCount.AccessibleName");
			this.panelChartIncomingCallStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartIncomingCallStateCount.Anchor")));
			this.panelChartIncomingCallStateCount.AutoScroll = ((bool)(resources.GetObject("panelChartIncomingCallStateCount.AutoScroll")));
			this.panelChartIncomingCallStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartIncomingCallStateCount.AutoScrollMargin")));
			this.panelChartIncomingCallStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartIncomingCallStateCount.AutoScrollMinSize")));
			this.panelChartIncomingCallStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartIncomingCallStateCount.BackgroundImage")));
			this.panelChartIncomingCallStateCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartIncomingCallStateCount.Controls.Add(this.chartIncomingCallStateCount);
			this.panelChartIncomingCallStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartIncomingCallStateCount.Dock")));
			this.panelChartIncomingCallStateCount.Enabled = ((bool)(resources.GetObject("panelChartIncomingCallStateCount.Enabled")));
			this.panelChartIncomingCallStateCount.Font = ((System.Drawing.Font)(resources.GetObject("panelChartIncomingCallStateCount.Font")));
			this.panelChartIncomingCallStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartIncomingCallStateCount.ImeMode")));
			this.panelChartIncomingCallStateCount.Location = ((System.Drawing.Point)(resources.GetObject("panelChartIncomingCallStateCount.Location")));
			this.panelChartIncomingCallStateCount.Name = "panelChartIncomingCallStateCount";
			this.panelChartIncomingCallStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartIncomingCallStateCount.RightToLeft")));
			this.panelChartIncomingCallStateCount.Size = ((System.Drawing.Size)(resources.GetObject("panelChartIncomingCallStateCount.Size")));
			this.panelChartIncomingCallStateCount.TabIndex = ((int)(resources.GetObject("panelChartIncomingCallStateCount.TabIndex")));
			this.panelChartIncomingCallStateCount.Text = resources.GetString("panelChartIncomingCallStateCount.Text");
			this.panelChartIncomingCallStateCount.Visible = ((bool)(resources.GetObject("panelChartIncomingCallStateCount.Visible")));
			// 
			// chartIncomingCallStateCount
			// 
			this.chartIncomingCallStateCount.AccessibleDescription = resources.GetString("chartIncomingCallStateCount.AccessibleDescription");
			this.chartIncomingCallStateCount.AccessibleName = resources.GetString("chartIncomingCallStateCount.AccessibleName");
			this.chartIncomingCallStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartIncomingCallStateCount.Anchor")));
			this.chartIncomingCallStateCount.AutoScroll = ((bool)(resources.GetObject("chartIncomingCallStateCount.AutoScroll")));
			this.chartIncomingCallStateCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartIncomingCallStateCount.AutoScrollMargin")));
			this.chartIncomingCallStateCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartIncomingCallStateCount.AutoScrollMinSize")));
			this.chartIncomingCallStateCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.BackgroundColor")));
			this.chartIncomingCallStateCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartIncomingCallStateCount.BackgroundImage")));
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
			this.chartIncomingCallStateCount.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																									 curve1,
																									 curve2,
																									 curve3,
																									 curve4,
																									 curve5});
			this.chartIncomingCallStateCount.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartIncomingCallStateCount.DisplayedInterval")));
			this.chartIncomingCallStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartIncomingCallStateCount.Dock")));
			this.chartIncomingCallStateCount.Enabled = ((bool)(resources.GetObject("chartIncomingCallStateCount.Enabled")));
			this.chartIncomingCallStateCount.Font = ((System.Drawing.Font)(resources.GetObject("chartIncomingCallStateCount.Font")));
			this.chartIncomingCallStateCount.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.FrameColor")));
			this.chartIncomingCallStateCount.GridColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.GridColor")));
			this.chartIncomingCallStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartIncomingCallStateCount.ImeMode")));
			this.chartIncomingCallStateCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartIncomingCallStateCount.LegendAlignment")));
			this.chartIncomingCallStateCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.LegendColor")));
			this.chartIncomingCallStateCount.Location = ((System.Drawing.Point)(resources.GetObject("chartIncomingCallStateCount.Location")));
			this.chartIncomingCallStateCount.Name = "chartIncomingCallStateCount";
			this.chartIncomingCallStateCount.Painting = ((bool)(resources.GetObject("chartIncomingCallStateCount.Painting")));
			this.chartIncomingCallStateCount.RescaleRatio = ((System.Double)(resources.GetObject("chartIncomingCallStateCount.RescaleRatio")));
			this.chartIncomingCallStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartIncomingCallStateCount.RightToLeft")));
			this.chartIncomingCallStateCount.Size = ((System.Drawing.Size)(resources.GetObject("chartIncomingCallStateCount.Size")));
			this.chartIncomingCallStateCount.TabIndex = ((int)(resources.GetObject("chartIncomingCallStateCount.TabIndex")));
			this.chartIncomingCallStateCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.ValueColor")));
			this.chartIncomingCallStateCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartIncomingCallStateCount.ValueType")));
			this.chartIncomingCallStateCount.Visible = ((bool)(resources.GetObject("chartIncomingCallStateCount.Visible")));
			this.chartIncomingCallStateCount.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.XLabelColor")));
			this.chartIncomingCallStateCount.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartIncomingCallStateCount.YLabelColor")));
			this.chartIncomingCallStateCount.YMax = ((System.Double)(resources.GetObject("chartIncomingCallStateCount.YMax")));
			this.chartIncomingCallStateCount.YMaxScaling = ((bool)(resources.GetObject("chartIncomingCallStateCount.YMaxScaling")));
			this.chartIncomingCallStateCount.YMin = ((System.Double)(resources.GetObject("chartIncomingCallStateCount.YMin")));
			this.chartIncomingCallStateCount.YMinScaling = ((bool)(resources.GetObject("chartIncomingCallStateCount.YMinScaling")));
			// 
			// groupBoxIncomingCallStates
			// 
			this.groupBoxIncomingCallStates.AccessibleDescription = resources.GetString("groupBoxIncomingCallStates.AccessibleDescription");
			this.groupBoxIncomingCallStates.AccessibleName = resources.GetString("groupBoxIncomingCallStates.AccessibleName");
			this.groupBoxIncomingCallStates.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxIncomingCallStates.Anchor")));
			this.groupBoxIncomingCallStates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxIncomingCallStates.BackgroundImage")));
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCount);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountCap);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesBottomLineGray);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesBottomLineWhite);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountSignaling);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountSignalingCap);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountWaiting);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountWaitingCap);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountGreeting);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountGreetingCap);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountAlerting);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStateCountAlertingCap);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesTopLineGray);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesTopLineWhite);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesRowCount);
			this.groupBoxIncomingCallStates.Controls.Add(this.labelIncomingCallStatesRowState);
			this.groupBoxIncomingCallStates.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxIncomingCallStates.Dock")));
			this.groupBoxIncomingCallStates.Enabled = ((bool)(resources.GetObject("groupBoxIncomingCallStates.Enabled")));
			this.groupBoxIncomingCallStates.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxIncomingCallStates.Font")));
			this.groupBoxIncomingCallStates.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxIncomingCallStates.ImeMode")));
			this.groupBoxIncomingCallStates.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxIncomingCallStates.Location")));
			this.groupBoxIncomingCallStates.Name = "groupBoxIncomingCallStates";
			this.groupBoxIncomingCallStates.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxIncomingCallStates.RightToLeft")));
			this.groupBoxIncomingCallStates.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxIncomingCallStates.Size")));
			this.groupBoxIncomingCallStates.TabIndex = ((int)(resources.GetObject("groupBoxIncomingCallStates.TabIndex")));
			this.groupBoxIncomingCallStates.TabStop = false;
			this.groupBoxIncomingCallStates.Text = resources.GetString("groupBoxIncomingCallStates.Text");
			this.groupBoxIncomingCallStates.Visible = ((bool)(resources.GetObject("groupBoxIncomingCallStates.Visible")));
			// 
			// labelIncomingCallStateCount
			// 
			this.labelIncomingCallStateCount.AccessibleDescription = resources.GetString("labelIncomingCallStateCount.AccessibleDescription");
			this.labelIncomingCallStateCount.AccessibleName = resources.GetString("labelIncomingCallStateCount.AccessibleName");
			this.labelIncomingCallStateCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCount.Anchor")));
			this.labelIncomingCallStateCount.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCount.AutoSize")));
			this.labelIncomingCallStateCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCount.Dock")));
			this.labelIncomingCallStateCount.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCount.Enabled")));
			this.labelIncomingCallStateCount.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCount.Font")));
			this.labelIncomingCallStateCount.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCount.Image")));
			this.labelIncomingCallStateCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCount.ImageAlign")));
			this.labelIncomingCallStateCount.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCount.ImageIndex")));
			this.labelIncomingCallStateCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCount.ImeMode")));
			this.labelIncomingCallStateCount.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCount.Location")));
			this.labelIncomingCallStateCount.Name = "labelIncomingCallStateCount";
			this.labelIncomingCallStateCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCount.RightToLeft")));
			this.labelIncomingCallStateCount.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCount.Size")));
			this.labelIncomingCallStateCount.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCount.TabIndex")));
			this.labelIncomingCallStateCount.Text = resources.GetString("labelIncomingCallStateCount.Text");
			this.labelIncomingCallStateCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCount.TextAlign")));
			this.labelIncomingCallStateCount.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCount.Visible")));
			// 
			// labelIncomingCallStateCountCap
			// 
			this.labelIncomingCallStateCountCap.AccessibleDescription = resources.GetString("labelIncomingCallStateCountCap.AccessibleDescription");
			this.labelIncomingCallStateCountCap.AccessibleName = resources.GetString("labelIncomingCallStateCountCap.AccessibleName");
			this.labelIncomingCallStateCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountCap.Anchor")));
			this.labelIncomingCallStateCountCap.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountCap.AutoSize")));
			this.labelIncomingCallStateCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountCap.Dock")));
			this.labelIncomingCallStateCountCap.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountCap.Enabled")));
			this.labelIncomingCallStateCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountCap.Font")));
			this.labelIncomingCallStateCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountCap.Image")));
			this.labelIncomingCallStateCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountCap.ImageAlign")));
			this.labelIncomingCallStateCountCap.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountCap.ImageIndex")));
			this.labelIncomingCallStateCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountCap.ImeMode")));
			this.labelIncomingCallStateCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountCap.Location")));
			this.labelIncomingCallStateCountCap.Name = "labelIncomingCallStateCountCap";
			this.labelIncomingCallStateCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountCap.RightToLeft")));
			this.labelIncomingCallStateCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountCap.Size")));
			this.labelIncomingCallStateCountCap.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountCap.TabIndex")));
			this.labelIncomingCallStateCountCap.Text = resources.GetString("labelIncomingCallStateCountCap.Text");
			this.labelIncomingCallStateCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountCap.TextAlign")));
			this.labelIncomingCallStateCountCap.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountCap.Visible")));
			// 
			// labelIncomingCallStatesBottomLineGray
			// 
			this.labelIncomingCallStatesBottomLineGray.AccessibleDescription = resources.GetString("labelIncomingCallStatesBottomLineGray.AccessibleDescription");
			this.labelIncomingCallStatesBottomLineGray.AccessibleName = resources.GetString("labelIncomingCallStatesBottomLineGray.AccessibleName");
			this.labelIncomingCallStatesBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Anchor")));
			this.labelIncomingCallStatesBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineGray.AutoSize")));
			this.labelIncomingCallStatesBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelIncomingCallStatesBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Dock")));
			this.labelIncomingCallStatesBottomLineGray.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Enabled")));
			this.labelIncomingCallStatesBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Font")));
			this.labelIncomingCallStatesBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelIncomingCallStatesBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Image")));
			this.labelIncomingCallStatesBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesBottomLineGray.ImageAlign")));
			this.labelIncomingCallStatesBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesBottomLineGray.ImageIndex")));
			this.labelIncomingCallStatesBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesBottomLineGray.ImeMode")));
			this.labelIncomingCallStatesBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Location")));
			this.labelIncomingCallStatesBottomLineGray.Name = "labelIncomingCallStatesBottomLineGray";
			this.labelIncomingCallStatesBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesBottomLineGray.RightToLeft")));
			this.labelIncomingCallStatesBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Size")));
			this.labelIncomingCallStatesBottomLineGray.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesBottomLineGray.TabIndex")));
			this.labelIncomingCallStatesBottomLineGray.Text = resources.GetString("labelIncomingCallStatesBottomLineGray.Text");
			this.labelIncomingCallStatesBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesBottomLineGray.TextAlign")));
			this.labelIncomingCallStatesBottomLineGray.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineGray.Visible")));
			// 
			// labelIncomingCallStatesBottomLineWhite
			// 
			this.labelIncomingCallStatesBottomLineWhite.AccessibleDescription = resources.GetString("labelIncomingCallStatesBottomLineWhite.AccessibleDescription");
			this.labelIncomingCallStatesBottomLineWhite.AccessibleName = resources.GetString("labelIncomingCallStatesBottomLineWhite.AccessibleName");
			this.labelIncomingCallStatesBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Anchor")));
			this.labelIncomingCallStatesBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.AutoSize")));
			this.labelIncomingCallStatesBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelIncomingCallStatesBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Dock")));
			this.labelIncomingCallStatesBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Enabled")));
			this.labelIncomingCallStatesBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Font")));
			this.labelIncomingCallStatesBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelIncomingCallStatesBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Image")));
			this.labelIncomingCallStatesBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.ImageAlign")));
			this.labelIncomingCallStatesBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.ImageIndex")));
			this.labelIncomingCallStatesBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.ImeMode")));
			this.labelIncomingCallStatesBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Location")));
			this.labelIncomingCallStatesBottomLineWhite.Name = "labelIncomingCallStatesBottomLineWhite";
			this.labelIncomingCallStatesBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.RightToLeft")));
			this.labelIncomingCallStatesBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Size")));
			this.labelIncomingCallStatesBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.TabIndex")));
			this.labelIncomingCallStatesBottomLineWhite.Text = resources.GetString("labelIncomingCallStatesBottomLineWhite.Text");
			this.labelIncomingCallStatesBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.TextAlign")));
			this.labelIncomingCallStatesBottomLineWhite.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesBottomLineWhite.Visible")));
			// 
			// labelIncomingCallStateCountSignaling
			// 
			this.labelIncomingCallStateCountSignaling.AccessibleDescription = resources.GetString("labelIncomingCallStateCountSignaling.AccessibleDescription");
			this.labelIncomingCallStateCountSignaling.AccessibleName = resources.GetString("labelIncomingCallStateCountSignaling.AccessibleName");
			this.labelIncomingCallStateCountSignaling.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountSignaling.Anchor")));
			this.labelIncomingCallStateCountSignaling.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountSignaling.AutoSize")));
			this.labelIncomingCallStateCountSignaling.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountSignaling.Dock")));
			this.labelIncomingCallStateCountSignaling.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountSignaling.Enabled")));
			this.labelIncomingCallStateCountSignaling.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountSignaling.Font")));
			this.labelIncomingCallStateCountSignaling.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountSignaling.Image")));
			this.labelIncomingCallStateCountSignaling.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountSignaling.ImageAlign")));
			this.labelIncomingCallStateCountSignaling.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountSignaling.ImageIndex")));
			this.labelIncomingCallStateCountSignaling.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountSignaling.ImeMode")));
			this.labelIncomingCallStateCountSignaling.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountSignaling.Location")));
			this.labelIncomingCallStateCountSignaling.Name = "labelIncomingCallStateCountSignaling";
			this.labelIncomingCallStateCountSignaling.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountSignaling.RightToLeft")));
			this.labelIncomingCallStateCountSignaling.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountSignaling.Size")));
			this.labelIncomingCallStateCountSignaling.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountSignaling.TabIndex")));
			this.labelIncomingCallStateCountSignaling.Text = resources.GetString("labelIncomingCallStateCountSignaling.Text");
			this.labelIncomingCallStateCountSignaling.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountSignaling.TextAlign")));
			this.labelIncomingCallStateCountSignaling.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountSignaling.Visible")));
			// 
			// labelIncomingCallStateCountSignalingCap
			// 
			this.labelIncomingCallStateCountSignalingCap.AccessibleDescription = resources.GetString("labelIncomingCallStateCountSignalingCap.AccessibleDescription");
			this.labelIncomingCallStateCountSignalingCap.AccessibleName = resources.GetString("labelIncomingCallStateCountSignalingCap.AccessibleName");
			this.labelIncomingCallStateCountSignalingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Anchor")));
			this.labelIncomingCallStateCountSignalingCap.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountSignalingCap.AutoSize")));
			this.labelIncomingCallStateCountSignalingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Dock")));
			this.labelIncomingCallStateCountSignalingCap.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Enabled")));
			this.labelIncomingCallStateCountSignalingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Font")));
			this.labelIncomingCallStateCountSignalingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Image")));
			this.labelIncomingCallStateCountSignalingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountSignalingCap.ImageAlign")));
			this.labelIncomingCallStateCountSignalingCap.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountSignalingCap.ImageIndex")));
			this.labelIncomingCallStateCountSignalingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountSignalingCap.ImeMode")));
			this.labelIncomingCallStateCountSignalingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Location")));
			this.labelIncomingCallStateCountSignalingCap.Name = "labelIncomingCallStateCountSignalingCap";
			this.labelIncomingCallStateCountSignalingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountSignalingCap.RightToLeft")));
			this.labelIncomingCallStateCountSignalingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Size")));
			this.labelIncomingCallStateCountSignalingCap.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountSignalingCap.TabIndex")));
			this.labelIncomingCallStateCountSignalingCap.Text = resources.GetString("labelIncomingCallStateCountSignalingCap.Text");
			this.labelIncomingCallStateCountSignalingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountSignalingCap.TextAlign")));
			this.labelIncomingCallStateCountSignalingCap.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountSignalingCap.Visible")));
			// 
			// labelIncomingCallStateCountWaiting
			// 
			this.labelIncomingCallStateCountWaiting.AccessibleDescription = resources.GetString("labelIncomingCallStateCountWaiting.AccessibleDescription");
			this.labelIncomingCallStateCountWaiting.AccessibleName = resources.GetString("labelIncomingCallStateCountWaiting.AccessibleName");
			this.labelIncomingCallStateCountWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountWaiting.Anchor")));
			this.labelIncomingCallStateCountWaiting.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountWaiting.AutoSize")));
			this.labelIncomingCallStateCountWaiting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountWaiting.Dock")));
			this.labelIncomingCallStateCountWaiting.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountWaiting.Enabled")));
			this.labelIncomingCallStateCountWaiting.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountWaiting.Font")));
			this.labelIncomingCallStateCountWaiting.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountWaiting.Image")));
			this.labelIncomingCallStateCountWaiting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountWaiting.ImageAlign")));
			this.labelIncomingCallStateCountWaiting.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountWaiting.ImageIndex")));
			this.labelIncomingCallStateCountWaiting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountWaiting.ImeMode")));
			this.labelIncomingCallStateCountWaiting.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountWaiting.Location")));
			this.labelIncomingCallStateCountWaiting.Name = "labelIncomingCallStateCountWaiting";
			this.labelIncomingCallStateCountWaiting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountWaiting.RightToLeft")));
			this.labelIncomingCallStateCountWaiting.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountWaiting.Size")));
			this.labelIncomingCallStateCountWaiting.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountWaiting.TabIndex")));
			this.labelIncomingCallStateCountWaiting.Text = resources.GetString("labelIncomingCallStateCountWaiting.Text");
			this.labelIncomingCallStateCountWaiting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountWaiting.TextAlign")));
			this.labelIncomingCallStateCountWaiting.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountWaiting.Visible")));
			// 
			// labelIncomingCallStateCountWaitingCap
			// 
			this.labelIncomingCallStateCountWaitingCap.AccessibleDescription = resources.GetString("labelIncomingCallStateCountWaitingCap.AccessibleDescription");
			this.labelIncomingCallStateCountWaitingCap.AccessibleName = resources.GetString("labelIncomingCallStateCountWaitingCap.AccessibleName");
			this.labelIncomingCallStateCountWaitingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Anchor")));
			this.labelIncomingCallStateCountWaitingCap.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountWaitingCap.AutoSize")));
			this.labelIncomingCallStateCountWaitingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Dock")));
			this.labelIncomingCallStateCountWaitingCap.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Enabled")));
			this.labelIncomingCallStateCountWaitingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Font")));
			this.labelIncomingCallStateCountWaitingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Image")));
			this.labelIncomingCallStateCountWaitingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountWaitingCap.ImageAlign")));
			this.labelIncomingCallStateCountWaitingCap.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountWaitingCap.ImageIndex")));
			this.labelIncomingCallStateCountWaitingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountWaitingCap.ImeMode")));
			this.labelIncomingCallStateCountWaitingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Location")));
			this.labelIncomingCallStateCountWaitingCap.Name = "labelIncomingCallStateCountWaitingCap";
			this.labelIncomingCallStateCountWaitingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountWaitingCap.RightToLeft")));
			this.labelIncomingCallStateCountWaitingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Size")));
			this.labelIncomingCallStateCountWaitingCap.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountWaitingCap.TabIndex")));
			this.labelIncomingCallStateCountWaitingCap.Text = resources.GetString("labelIncomingCallStateCountWaitingCap.Text");
			this.labelIncomingCallStateCountWaitingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountWaitingCap.TextAlign")));
			this.labelIncomingCallStateCountWaitingCap.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountWaitingCap.Visible")));
			// 
			// labelIncomingCallStateCountGreeting
			// 
			this.labelIncomingCallStateCountGreeting.AccessibleDescription = resources.GetString("labelIncomingCallStateCountGreeting.AccessibleDescription");
			this.labelIncomingCallStateCountGreeting.AccessibleName = resources.GetString("labelIncomingCallStateCountGreeting.AccessibleName");
			this.labelIncomingCallStateCountGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountGreeting.Anchor")));
			this.labelIncomingCallStateCountGreeting.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountGreeting.AutoSize")));
			this.labelIncomingCallStateCountGreeting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountGreeting.Dock")));
			this.labelIncomingCallStateCountGreeting.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountGreeting.Enabled")));
			this.labelIncomingCallStateCountGreeting.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountGreeting.Font")));
			this.labelIncomingCallStateCountGreeting.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountGreeting.Image")));
			this.labelIncomingCallStateCountGreeting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountGreeting.ImageAlign")));
			this.labelIncomingCallStateCountGreeting.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountGreeting.ImageIndex")));
			this.labelIncomingCallStateCountGreeting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountGreeting.ImeMode")));
			this.labelIncomingCallStateCountGreeting.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountGreeting.Location")));
			this.labelIncomingCallStateCountGreeting.Name = "labelIncomingCallStateCountGreeting";
			this.labelIncomingCallStateCountGreeting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountGreeting.RightToLeft")));
			this.labelIncomingCallStateCountGreeting.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountGreeting.Size")));
			this.labelIncomingCallStateCountGreeting.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountGreeting.TabIndex")));
			this.labelIncomingCallStateCountGreeting.Text = resources.GetString("labelIncomingCallStateCountGreeting.Text");
			this.labelIncomingCallStateCountGreeting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountGreeting.TextAlign")));
			this.labelIncomingCallStateCountGreeting.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountGreeting.Visible")));
			// 
			// labelIncomingCallStateCountGreetingCap
			// 
			this.labelIncomingCallStateCountGreetingCap.AccessibleDescription = resources.GetString("labelIncomingCallStateCountGreetingCap.AccessibleDescription");
			this.labelIncomingCallStateCountGreetingCap.AccessibleName = resources.GetString("labelIncomingCallStateCountGreetingCap.AccessibleName");
			this.labelIncomingCallStateCountGreetingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Anchor")));
			this.labelIncomingCallStateCountGreetingCap.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountGreetingCap.AutoSize")));
			this.labelIncomingCallStateCountGreetingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Dock")));
			this.labelIncomingCallStateCountGreetingCap.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Enabled")));
			this.labelIncomingCallStateCountGreetingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Font")));
			this.labelIncomingCallStateCountGreetingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Image")));
			this.labelIncomingCallStateCountGreetingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountGreetingCap.ImageAlign")));
			this.labelIncomingCallStateCountGreetingCap.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountGreetingCap.ImageIndex")));
			this.labelIncomingCallStateCountGreetingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountGreetingCap.ImeMode")));
			this.labelIncomingCallStateCountGreetingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Location")));
			this.labelIncomingCallStateCountGreetingCap.Name = "labelIncomingCallStateCountGreetingCap";
			this.labelIncomingCallStateCountGreetingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountGreetingCap.RightToLeft")));
			this.labelIncomingCallStateCountGreetingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Size")));
			this.labelIncomingCallStateCountGreetingCap.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountGreetingCap.TabIndex")));
			this.labelIncomingCallStateCountGreetingCap.Text = resources.GetString("labelIncomingCallStateCountGreetingCap.Text");
			this.labelIncomingCallStateCountGreetingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountGreetingCap.TextAlign")));
			this.labelIncomingCallStateCountGreetingCap.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountGreetingCap.Visible")));
			// 
			// labelIncomingCallStateCountAlerting
			// 
			this.labelIncomingCallStateCountAlerting.AccessibleDescription = resources.GetString("labelIncomingCallStateCountAlerting.AccessibleDescription");
			this.labelIncomingCallStateCountAlerting.AccessibleName = resources.GetString("labelIncomingCallStateCountAlerting.AccessibleName");
			this.labelIncomingCallStateCountAlerting.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountAlerting.Anchor")));
			this.labelIncomingCallStateCountAlerting.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountAlerting.AutoSize")));
			this.labelIncomingCallStateCountAlerting.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountAlerting.Dock")));
			this.labelIncomingCallStateCountAlerting.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountAlerting.Enabled")));
			this.labelIncomingCallStateCountAlerting.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountAlerting.Font")));
			this.labelIncomingCallStateCountAlerting.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountAlerting.Image")));
			this.labelIncomingCallStateCountAlerting.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountAlerting.ImageAlign")));
			this.labelIncomingCallStateCountAlerting.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountAlerting.ImageIndex")));
			this.labelIncomingCallStateCountAlerting.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountAlerting.ImeMode")));
			this.labelIncomingCallStateCountAlerting.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountAlerting.Location")));
			this.labelIncomingCallStateCountAlerting.Name = "labelIncomingCallStateCountAlerting";
			this.labelIncomingCallStateCountAlerting.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountAlerting.RightToLeft")));
			this.labelIncomingCallStateCountAlerting.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountAlerting.Size")));
			this.labelIncomingCallStateCountAlerting.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountAlerting.TabIndex")));
			this.labelIncomingCallStateCountAlerting.Text = resources.GetString("labelIncomingCallStateCountAlerting.Text");
			this.labelIncomingCallStateCountAlerting.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountAlerting.TextAlign")));
			this.labelIncomingCallStateCountAlerting.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountAlerting.Visible")));
			// 
			// labelIncomingCallStateCountAlertingCap
			// 
			this.labelIncomingCallStateCountAlertingCap.AccessibleDescription = resources.GetString("labelIncomingCallStateCountAlertingCap.AccessibleDescription");
			this.labelIncomingCallStateCountAlertingCap.AccessibleName = resources.GetString("labelIncomingCallStateCountAlertingCap.AccessibleName");
			this.labelIncomingCallStateCountAlertingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Anchor")));
			this.labelIncomingCallStateCountAlertingCap.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStateCountAlertingCap.AutoSize")));
			this.labelIncomingCallStateCountAlertingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Dock")));
			this.labelIncomingCallStateCountAlertingCap.Enabled = ((bool)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Enabled")));
			this.labelIncomingCallStateCountAlertingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Font")));
			this.labelIncomingCallStateCountAlertingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Image")));
			this.labelIncomingCallStateCountAlertingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountAlertingCap.ImageAlign")));
			this.labelIncomingCallStateCountAlertingCap.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStateCountAlertingCap.ImageIndex")));
			this.labelIncomingCallStateCountAlertingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStateCountAlertingCap.ImeMode")));
			this.labelIncomingCallStateCountAlertingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Location")));
			this.labelIncomingCallStateCountAlertingCap.Name = "labelIncomingCallStateCountAlertingCap";
			this.labelIncomingCallStateCountAlertingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStateCountAlertingCap.RightToLeft")));
			this.labelIncomingCallStateCountAlertingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Size")));
			this.labelIncomingCallStateCountAlertingCap.TabIndex = ((int)(resources.GetObject("labelIncomingCallStateCountAlertingCap.TabIndex")));
			this.labelIncomingCallStateCountAlertingCap.Text = resources.GetString("labelIncomingCallStateCountAlertingCap.Text");
			this.labelIncomingCallStateCountAlertingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStateCountAlertingCap.TextAlign")));
			this.labelIncomingCallStateCountAlertingCap.Visible = ((bool)(resources.GetObject("labelIncomingCallStateCountAlertingCap.Visible")));
			// 
			// labelIncomingCallStatesTopLineGray
			// 
			this.labelIncomingCallStatesTopLineGray.AccessibleDescription = resources.GetString("labelIncomingCallStatesTopLineGray.AccessibleDescription");
			this.labelIncomingCallStatesTopLineGray.AccessibleName = resources.GetString("labelIncomingCallStatesTopLineGray.AccessibleName");
			this.labelIncomingCallStatesTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesTopLineGray.Anchor")));
			this.labelIncomingCallStatesTopLineGray.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineGray.AutoSize")));
			this.labelIncomingCallStatesTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelIncomingCallStatesTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesTopLineGray.Dock")));
			this.labelIncomingCallStatesTopLineGray.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineGray.Enabled")));
			this.labelIncomingCallStatesTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesTopLineGray.Font")));
			this.labelIncomingCallStatesTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelIncomingCallStatesTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesTopLineGray.Image")));
			this.labelIncomingCallStatesTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesTopLineGray.ImageAlign")));
			this.labelIncomingCallStatesTopLineGray.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesTopLineGray.ImageIndex")));
			this.labelIncomingCallStatesTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesTopLineGray.ImeMode")));
			this.labelIncomingCallStatesTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesTopLineGray.Location")));
			this.labelIncomingCallStatesTopLineGray.Name = "labelIncomingCallStatesTopLineGray";
			this.labelIncomingCallStatesTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesTopLineGray.RightToLeft")));
			this.labelIncomingCallStatesTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesTopLineGray.Size")));
			this.labelIncomingCallStatesTopLineGray.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesTopLineGray.TabIndex")));
			this.labelIncomingCallStatesTopLineGray.Text = resources.GetString("labelIncomingCallStatesTopLineGray.Text");
			this.labelIncomingCallStatesTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesTopLineGray.TextAlign")));
			this.labelIncomingCallStatesTopLineGray.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineGray.Visible")));
			// 
			// labelIncomingCallStatesTopLineWhite
			// 
			this.labelIncomingCallStatesTopLineWhite.AccessibleDescription = resources.GetString("labelIncomingCallStatesTopLineWhite.AccessibleDescription");
			this.labelIncomingCallStatesTopLineWhite.AccessibleName = resources.GetString("labelIncomingCallStatesTopLineWhite.AccessibleName");
			this.labelIncomingCallStatesTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Anchor")));
			this.labelIncomingCallStatesTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineWhite.AutoSize")));
			this.labelIncomingCallStatesTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelIncomingCallStatesTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Dock")));
			this.labelIncomingCallStatesTopLineWhite.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Enabled")));
			this.labelIncomingCallStatesTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Font")));
			this.labelIncomingCallStatesTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelIncomingCallStatesTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Image")));
			this.labelIncomingCallStatesTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesTopLineWhite.ImageAlign")));
			this.labelIncomingCallStatesTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesTopLineWhite.ImageIndex")));
			this.labelIncomingCallStatesTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesTopLineWhite.ImeMode")));
			this.labelIncomingCallStatesTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Location")));
			this.labelIncomingCallStatesTopLineWhite.Name = "labelIncomingCallStatesTopLineWhite";
			this.labelIncomingCallStatesTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesTopLineWhite.RightToLeft")));
			this.labelIncomingCallStatesTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Size")));
			this.labelIncomingCallStatesTopLineWhite.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesTopLineWhite.TabIndex")));
			this.labelIncomingCallStatesTopLineWhite.Text = resources.GetString("labelIncomingCallStatesTopLineWhite.Text");
			this.labelIncomingCallStatesTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesTopLineWhite.TextAlign")));
			this.labelIncomingCallStatesTopLineWhite.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesTopLineWhite.Visible")));
			// 
			// labelIncomingCallStatesRowCount
			// 
			this.labelIncomingCallStatesRowCount.AccessibleDescription = resources.GetString("labelIncomingCallStatesRowCount.AccessibleDescription");
			this.labelIncomingCallStatesRowCount.AccessibleName = resources.GetString("labelIncomingCallStatesRowCount.AccessibleName");
			this.labelIncomingCallStatesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesRowCount.Anchor")));
			this.labelIncomingCallStatesRowCount.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesRowCount.AutoSize")));
			this.labelIncomingCallStatesRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesRowCount.Dock")));
			this.labelIncomingCallStatesRowCount.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesRowCount.Enabled")));
			this.labelIncomingCallStatesRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesRowCount.Font")));
			this.labelIncomingCallStatesRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesRowCount.Image")));
			this.labelIncomingCallStatesRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesRowCount.ImageAlign")));
			this.labelIncomingCallStatesRowCount.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesRowCount.ImageIndex")));
			this.labelIncomingCallStatesRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesRowCount.ImeMode")));
			this.labelIncomingCallStatesRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesRowCount.Location")));
			this.labelIncomingCallStatesRowCount.Name = "labelIncomingCallStatesRowCount";
			this.labelIncomingCallStatesRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesRowCount.RightToLeft")));
			this.labelIncomingCallStatesRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesRowCount.Size")));
			this.labelIncomingCallStatesRowCount.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesRowCount.TabIndex")));
			this.labelIncomingCallStatesRowCount.Text = resources.GetString("labelIncomingCallStatesRowCount.Text");
			this.labelIncomingCallStatesRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesRowCount.TextAlign")));
			this.labelIncomingCallStatesRowCount.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesRowCount.Visible")));
			// 
			// labelIncomingCallStatesRowState
			// 
			this.labelIncomingCallStatesRowState.AccessibleDescription = resources.GetString("labelIncomingCallStatesRowState.AccessibleDescription");
			this.labelIncomingCallStatesRowState.AccessibleName = resources.GetString("labelIncomingCallStatesRowState.AccessibleName");
			this.labelIncomingCallStatesRowState.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelIncomingCallStatesRowState.Anchor")));
			this.labelIncomingCallStatesRowState.AutoSize = ((bool)(resources.GetObject("labelIncomingCallStatesRowState.AutoSize")));
			this.labelIncomingCallStatesRowState.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelIncomingCallStatesRowState.Dock")));
			this.labelIncomingCallStatesRowState.Enabled = ((bool)(resources.GetObject("labelIncomingCallStatesRowState.Enabled")));
			this.labelIncomingCallStatesRowState.Font = ((System.Drawing.Font)(resources.GetObject("labelIncomingCallStatesRowState.Font")));
			this.labelIncomingCallStatesRowState.Image = ((System.Drawing.Image)(resources.GetObject("labelIncomingCallStatesRowState.Image")));
			this.labelIncomingCallStatesRowState.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesRowState.ImageAlign")));
			this.labelIncomingCallStatesRowState.ImageIndex = ((int)(resources.GetObject("labelIncomingCallStatesRowState.ImageIndex")));
			this.labelIncomingCallStatesRowState.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelIncomingCallStatesRowState.ImeMode")));
			this.labelIncomingCallStatesRowState.Location = ((System.Drawing.Point)(resources.GetObject("labelIncomingCallStatesRowState.Location")));
			this.labelIncomingCallStatesRowState.Name = "labelIncomingCallStatesRowState";
			this.labelIncomingCallStatesRowState.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelIncomingCallStatesRowState.RightToLeft")));
			this.labelIncomingCallStatesRowState.Size = ((System.Drawing.Size)(resources.GetObject("labelIncomingCallStatesRowState.Size")));
			this.labelIncomingCallStatesRowState.TabIndex = ((int)(resources.GetObject("labelIncomingCallStatesRowState.TabIndex")));
			this.labelIncomingCallStatesRowState.Text = resources.GetString("labelIncomingCallStatesRowState.Text");
			this.labelIncomingCallStatesRowState.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelIncomingCallStatesRowState.TextAlign")));
			this.labelIncomingCallStatesRowState.Visible = ((bool)(resources.GetObject("labelIncomingCallStatesRowState.Visible")));
			// 
			// CampaignViewIncomingCalls
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartIncomingCallStateCount);
			this.Controls.Add(this.groupBoxIncomingCallStates);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewIncomingCalls";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartIncomingCallStateCount.ResumeLayout(false);
			this.panelChartIncomingCallStateCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartIncomingCallStateCount)).EndInit();
			this.groupBoxIncomingCallStates.ResumeLayout(false);
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
			labelIncomingCallStateCountAlerting.Text =
				campaign.GetIncomingCallStateCount(IncomingCallState.Alerting).ToString();
			labelIncomingCallStateCountGreeting.Text =
				campaign.GetIncomingCallStateCount(IncomingCallState.Greeting).ToString();
			labelIncomingCallStateCountWaiting.Text =
				campaign.GetIncomingCallStateCount(IncomingCallState.Waiting).ToString();
			labelIncomingCallStateCountSignaling.Text =
				campaign.GetIncomingCallStateCount(IncomingCallState.Signaling).ToString();
			labelIncomingCallStateCount.Text = campaign.IncomingCallCount.ToString();

			// Verlaufsgrafik aktualisieren
			chartIncomingCallStateCount.DataCollection = campaign.IncomingCallStateCountData;
		}

		#endregion

		#endregion
	}
}
