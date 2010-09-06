using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Inbound Kurzzeitstatistik einer Kampagne.
	/// </summary>
	public class CampaignViewIncomingCallsRecentStatistics : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxRecentIncomingCallResults;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsRowResult;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsRowCount;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsRowRate;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsTopLineWhite;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsTopLineGray;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPSTNFailureCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPSTNFailureAbs;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPSTNFailureRel;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPSTNFailureRelMea;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountTelcoOverloadCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountTelcoOverloadAbs;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountTelcoOverloadRel;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountTelcoOverloadRelMea;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountNoInterestCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountNoInterestAbs;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountNoInterestRel;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountNoInterestRelMea;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountLostCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountLostAbs;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountLostRel;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountLostRelMea;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPutThroughCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPutThroughAbs;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPutThroughRel;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountPutThroughRelMea;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsBottomLineWhite;
		private System.Windows.Forms.Label labelRecentIncomingCallResultsBottomLineGray;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountCap;
		private System.Windows.Forms.Label labelRecentIncomingCallResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxPieRecentIncomingCallResultCount;
		private itCampus.bb.Graph.Pie.Pie pieRecentIncomingCallResultCount;
		private System.Windows.Forms.GroupBox groupBoxChartRecentIncomingCallResultCountAbs;
		private System.Windows.Forms.Panel panelChartRecentIncomngCallResultCountAbs;
		private itCampus.bb.Graph.Chart.Chart chartRecentIncomingCallResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxChartRecentIncomingCallResultCountRel;
		private System.Windows.Forms.Panel panelChartRecentIncomingCallResultCountRel;
		private itCampus.bb.Graph.Chart.Chart chartRecentIncomingCallResultCountRel;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewIncomingCallsRecentStatistics()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Intervall Tortengrafik einstellen
			pieRecentIncomingCallResultCount.RefreshInterval =
				Settings.Instance.RefreshInterval * 1000;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewIncomingCallsRecentStatistics));
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
			itCampus.bb.Graph.Pie.Slice slice1 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice2 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice3 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice4 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice5 = new itCampus.bb.Graph.Pie.Slice();
			this.groupBoxChartRecentIncomingCallResultCountRel = new System.Windows.Forms.GroupBox();
			this.panelChartRecentIncomingCallResultCountRel = new System.Windows.Forms.Panel();
			this.chartRecentIncomingCallResultCountRel = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxChartRecentIncomingCallResultCountAbs = new System.Windows.Forms.GroupBox();
			this.panelChartRecentIncomngCallResultCountAbs = new System.Windows.Forms.Panel();
			this.chartRecentIncomingCallResultCountAbs = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxPieRecentIncomingCallResultCount = new System.Windows.Forms.GroupBox();
			this.pieRecentIncomingCallResultCount = new itCampus.bb.Graph.Pie.Pie();
			this.groupBoxRecentIncomingCallResults = new System.Windows.Forms.GroupBox();
			this.labelRecentIncomingCallResultCountAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsBottomLineGray = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsBottomLineWhite = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPutThroughRelMea = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPutThroughRel = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPutThroughAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPutThroughCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountLostRelMea = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountLostRel = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountLostAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountLostCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountNoInterestRelMea = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountNoInterestRel = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountNoInterestAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountNoInterestCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountTelcoOverloadRel = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountTelcoOverloadCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPSTNFailureRel = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPSTNFailureAbs = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultCountPSTNFailureCap = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsTopLineGray = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsTopLineWhite = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsRowRate = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsRowCount = new System.Windows.Forms.Label();
			this.labelRecentIncomingCallResultsRowResult = new System.Windows.Forms.Label();
			this.groupBoxChartRecentIncomingCallResultCountRel.SuspendLayout();
			this.panelChartRecentIncomingCallResultCountRel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartRecentIncomingCallResultCountRel)).BeginInit();
			this.groupBoxChartRecentIncomingCallResultCountAbs.SuspendLayout();
			this.panelChartRecentIncomngCallResultCountAbs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartRecentIncomingCallResultCountAbs)).BeginInit();
			this.groupBoxPieRecentIncomingCallResultCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pieRecentIncomingCallResultCount)).BeginInit();
			this.groupBoxRecentIncomingCallResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartRecentIncomingCallResultCountRel
			// 
			this.groupBoxChartRecentIncomingCallResultCountRel.AccessibleDescription = resources.GetString("groupBoxChartRecentIncomingCallResultCountRel.AccessibleDescription");
			this.groupBoxChartRecentIncomingCallResultCountRel.AccessibleName = resources.GetString("groupBoxChartRecentIncomingCallResultCountRel.AccessibleName");
			this.groupBoxChartRecentIncomingCallResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Anchor")));
			this.groupBoxChartRecentIncomingCallResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.BackgroundImage")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Controls.Add(this.panelChartRecentIncomingCallResultCountRel);
			this.groupBoxChartRecentIncomingCallResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Dock")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Enabled = ((bool)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Enabled")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Font")));
			this.groupBoxChartRecentIncomingCallResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.ImeMode")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Location")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Name = "groupBoxChartRecentIncomingCallResultCountRel";
			this.groupBoxChartRecentIncomingCallResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.RightToLeft")));
			this.groupBoxChartRecentIncomingCallResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Size")));
			this.groupBoxChartRecentIncomingCallResultCountRel.TabIndex = ((int)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.TabIndex")));
			this.groupBoxChartRecentIncomingCallResultCountRel.TabStop = false;
			this.groupBoxChartRecentIncomingCallResultCountRel.Text = resources.GetString("groupBoxChartRecentIncomingCallResultCountRel.Text");
			this.groupBoxChartRecentIncomingCallResultCountRel.Visible = ((bool)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountRel.Visible")));
			// 
			// panelChartRecentIncomingCallResultCountRel
			// 
			this.panelChartRecentIncomingCallResultCountRel.AccessibleDescription = resources.GetString("panelChartRecentIncomingCallResultCountRel.AccessibleDescription");
			this.panelChartRecentIncomingCallResultCountRel.AccessibleName = resources.GetString("panelChartRecentIncomingCallResultCountRel.AccessibleName");
			this.panelChartRecentIncomingCallResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Anchor")));
			this.panelChartRecentIncomingCallResultCountRel.AutoScroll = ((bool)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.AutoScroll")));
			this.panelChartRecentIncomingCallResultCountRel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.AutoScrollMargin")));
			this.panelChartRecentIncomingCallResultCountRel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.AutoScrollMinSize")));
			this.panelChartRecentIncomingCallResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.BackgroundImage")));
			this.panelChartRecentIncomingCallResultCountRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartRecentIncomingCallResultCountRel.Controls.Add(this.chartRecentIncomingCallResultCountRel);
			this.panelChartRecentIncomingCallResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Dock")));
			this.panelChartRecentIncomingCallResultCountRel.Enabled = ((bool)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Enabled")));
			this.panelChartRecentIncomingCallResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Font")));
			this.panelChartRecentIncomingCallResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.ImeMode")));
			this.panelChartRecentIncomingCallResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Location")));
			this.panelChartRecentIncomingCallResultCountRel.Name = "panelChartRecentIncomingCallResultCountRel";
			this.panelChartRecentIncomingCallResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.RightToLeft")));
			this.panelChartRecentIncomingCallResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Size")));
			this.panelChartRecentIncomingCallResultCountRel.TabIndex = ((int)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.TabIndex")));
			this.panelChartRecentIncomingCallResultCountRel.Text = resources.GetString("panelChartRecentIncomingCallResultCountRel.Text");
			this.panelChartRecentIncomingCallResultCountRel.Visible = ((bool)(resources.GetObject("panelChartRecentIncomingCallResultCountRel.Visible")));
			// 
			// chartRecentIncomingCallResultCountRel
			// 
			this.chartRecentIncomingCallResultCountRel.AccessibleDescription = resources.GetString("chartRecentIncomingCallResultCountRel.AccessibleDescription");
			this.chartRecentIncomingCallResultCountRel.AccessibleName = resources.GetString("chartRecentIncomingCallResultCountRel.AccessibleName");
			this.chartRecentIncomingCallResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartRecentIncomingCallResultCountRel.Anchor")));
			this.chartRecentIncomingCallResultCountRel.AutoScroll = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.AutoScroll")));
			this.chartRecentIncomingCallResultCountRel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountRel.AutoScrollMargin")));
			this.chartRecentIncomingCallResultCountRel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountRel.AutoScrollMinSize")));
			this.chartRecentIncomingCallResultCountRel.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.BackgroundColor")));
			this.chartRecentIncomingCallResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartRecentIncomingCallResultCountRel.BackgroundImage")));
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
			this.chartRecentIncomingCallResultCountRel.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																											   curve1,
																											   curve2,
																											   curve3,
																											   curve4,
																											   curve5});
			this.chartRecentIncomingCallResultCountRel.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartRecentIncomingCallResultCountRel.DisplayedInterval")));
			this.chartRecentIncomingCallResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartRecentIncomingCallResultCountRel.Dock")));
			this.chartRecentIncomingCallResultCountRel.Enabled = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.Enabled")));
			this.chartRecentIncomingCallResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("chartRecentIncomingCallResultCountRel.Font")));
			this.chartRecentIncomingCallResultCountRel.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.FrameColor")));
			this.chartRecentIncomingCallResultCountRel.GridColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.GridColor")));
			this.chartRecentIncomingCallResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartRecentIncomingCallResultCountRel.ImeMode")));
			this.chartRecentIncomingCallResultCountRel.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartRecentIncomingCallResultCountRel.LegendAlignment")));
			this.chartRecentIncomingCallResultCountRel.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.LegendColor")));
			this.chartRecentIncomingCallResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("chartRecentIncomingCallResultCountRel.Location")));
			this.chartRecentIncomingCallResultCountRel.Name = "chartRecentIncomingCallResultCountRel";
			this.chartRecentIncomingCallResultCountRel.Painting = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.Painting")));
			this.chartRecentIncomingCallResultCountRel.RescaleRatio = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountRel.RescaleRatio")));
			this.chartRecentIncomingCallResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartRecentIncomingCallResultCountRel.RightToLeft")));
			this.chartRecentIncomingCallResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountRel.Size")));
			this.chartRecentIncomingCallResultCountRel.TabIndex = ((int)(resources.GetObject("chartRecentIncomingCallResultCountRel.TabIndex")));
			this.chartRecentIncomingCallResultCountRel.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.ValueColor")));
			this.chartRecentIncomingCallResultCountRel.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartRecentIncomingCallResultCountRel.ValueType")));
			this.chartRecentIncomingCallResultCountRel.Visible = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.Visible")));
			this.chartRecentIncomingCallResultCountRel.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.XLabelColor")));
			this.chartRecentIncomingCallResultCountRel.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountRel.YLabelColor")));
			this.chartRecentIncomingCallResultCountRel.YMax = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountRel.YMax")));
			this.chartRecentIncomingCallResultCountRel.YMaxScaling = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.YMaxScaling")));
			this.chartRecentIncomingCallResultCountRel.YMin = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountRel.YMin")));
			this.chartRecentIncomingCallResultCountRel.YMinScaling = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountRel.YMinScaling")));
			// 
			// groupBoxChartRecentIncomingCallResultCountAbs
			// 
			this.groupBoxChartRecentIncomingCallResultCountAbs.AccessibleDescription = resources.GetString("groupBoxChartRecentIncomingCallResultCountAbs.AccessibleDescription");
			this.groupBoxChartRecentIncomingCallResultCountAbs.AccessibleName = resources.GetString("groupBoxChartRecentIncomingCallResultCountAbs.AccessibleName");
			this.groupBoxChartRecentIncomingCallResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Anchor")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.BackgroundImage")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Controls.Add(this.panelChartRecentIncomngCallResultCountAbs);
			this.groupBoxChartRecentIncomingCallResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Dock")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Enabled = ((bool)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Enabled")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Font")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.ImeMode")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Location")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Name = "groupBoxChartRecentIncomingCallResultCountAbs";
			this.groupBoxChartRecentIncomingCallResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.RightToLeft")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Size")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.TabIndex = ((int)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.TabIndex")));
			this.groupBoxChartRecentIncomingCallResultCountAbs.TabStop = false;
			this.groupBoxChartRecentIncomingCallResultCountAbs.Text = resources.GetString("groupBoxChartRecentIncomingCallResultCountAbs.Text");
			this.groupBoxChartRecentIncomingCallResultCountAbs.Visible = ((bool)(resources.GetObject("groupBoxChartRecentIncomingCallResultCountAbs.Visible")));
			// 
			// panelChartRecentIncomngCallResultCountAbs
			// 
			this.panelChartRecentIncomngCallResultCountAbs.AccessibleDescription = resources.GetString("panelChartRecentIncomngCallResultCountAbs.AccessibleDescription");
			this.panelChartRecentIncomngCallResultCountAbs.AccessibleName = resources.GetString("panelChartRecentIncomngCallResultCountAbs.AccessibleName");
			this.panelChartRecentIncomngCallResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Anchor")));
			this.panelChartRecentIncomngCallResultCountAbs.AutoScroll = ((bool)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.AutoScroll")));
			this.panelChartRecentIncomngCallResultCountAbs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.AutoScrollMargin")));
			this.panelChartRecentIncomngCallResultCountAbs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.AutoScrollMinSize")));
			this.panelChartRecentIncomngCallResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.BackgroundImage")));
			this.panelChartRecentIncomngCallResultCountAbs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartRecentIncomngCallResultCountAbs.Controls.Add(this.chartRecentIncomingCallResultCountAbs);
			this.panelChartRecentIncomngCallResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Dock")));
			this.panelChartRecentIncomngCallResultCountAbs.Enabled = ((bool)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Enabled")));
			this.panelChartRecentIncomngCallResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Font")));
			this.panelChartRecentIncomngCallResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.ImeMode")));
			this.panelChartRecentIncomngCallResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Location")));
			this.panelChartRecentIncomngCallResultCountAbs.Name = "panelChartRecentIncomngCallResultCountAbs";
			this.panelChartRecentIncomngCallResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.RightToLeft")));
			this.panelChartRecentIncomngCallResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Size")));
			this.panelChartRecentIncomngCallResultCountAbs.TabIndex = ((int)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.TabIndex")));
			this.panelChartRecentIncomngCallResultCountAbs.Text = resources.GetString("panelChartRecentIncomngCallResultCountAbs.Text");
			this.panelChartRecentIncomngCallResultCountAbs.Visible = ((bool)(resources.GetObject("panelChartRecentIncomngCallResultCountAbs.Visible")));
			// 
			// chartRecentIncomingCallResultCountAbs
			// 
			this.chartRecentIncomingCallResultCountAbs.AccessibleDescription = resources.GetString("chartRecentIncomingCallResultCountAbs.AccessibleDescription");
			this.chartRecentIncomingCallResultCountAbs.AccessibleName = resources.GetString("chartRecentIncomingCallResultCountAbs.AccessibleName");
			this.chartRecentIncomingCallResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Anchor")));
			this.chartRecentIncomingCallResultCountAbs.AutoScroll = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.AutoScroll")));
			this.chartRecentIncomingCallResultCountAbs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountAbs.AutoScrollMargin")));
			this.chartRecentIncomingCallResultCountAbs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountAbs.AutoScrollMinSize")));
			this.chartRecentIncomingCallResultCountAbs.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.BackgroundColor")));
			this.chartRecentIncomingCallResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartRecentIncomingCallResultCountAbs.BackgroundImage")));
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
			curve11.Caption = resources.GetString("curve11.Caption");
			curve11.Color = ((System.Drawing.Color)(resources.GetObject("curve11.Color")));
			curve11.ContinuesLine = ((bool)(resources.GetObject("curve11.ContinuesLine")));
			curve11.MappingName = resources.GetString("curve11.MappingName");
			curve11.Visible = ((bool)(resources.GetObject("curve11.Visible")));
			this.chartRecentIncomingCallResultCountAbs.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																											   curve6,
																											   curve7,
																											   curve8,
																											   curve9,
																											   curve10,
																											   curve11});
			this.chartRecentIncomingCallResultCountAbs.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartRecentIncomingCallResultCountAbs.DisplayedInterval")));
			this.chartRecentIncomingCallResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Dock")));
			this.chartRecentIncomingCallResultCountAbs.Enabled = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Enabled")));
			this.chartRecentIncomingCallResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Font")));
			this.chartRecentIncomingCallResultCountAbs.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.FrameColor")));
			this.chartRecentIncomingCallResultCountAbs.GridColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.GridColor")));
			this.chartRecentIncomingCallResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartRecentIncomingCallResultCountAbs.ImeMode")));
			this.chartRecentIncomingCallResultCountAbs.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartRecentIncomingCallResultCountAbs.LegendAlignment")));
			this.chartRecentIncomingCallResultCountAbs.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.LegendColor")));
			this.chartRecentIncomingCallResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Location")));
			this.chartRecentIncomingCallResultCountAbs.Name = "chartRecentIncomingCallResultCountAbs";
			this.chartRecentIncomingCallResultCountAbs.Painting = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Painting")));
			this.chartRecentIncomingCallResultCountAbs.RescaleRatio = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountAbs.RescaleRatio")));
			this.chartRecentIncomingCallResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartRecentIncomingCallResultCountAbs.RightToLeft")));
			this.chartRecentIncomingCallResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Size")));
			this.chartRecentIncomingCallResultCountAbs.TabIndex = ((int)(resources.GetObject("chartRecentIncomingCallResultCountAbs.TabIndex")));
			this.chartRecentIncomingCallResultCountAbs.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.ValueColor")));
			this.chartRecentIncomingCallResultCountAbs.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartRecentIncomingCallResultCountAbs.ValueType")));
			this.chartRecentIncomingCallResultCountAbs.Visible = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.Visible")));
			this.chartRecentIncomingCallResultCountAbs.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.XLabelColor")));
			this.chartRecentIncomingCallResultCountAbs.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentIncomingCallResultCountAbs.YLabelColor")));
			this.chartRecentIncomingCallResultCountAbs.YMax = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountAbs.YMax")));
			this.chartRecentIncomingCallResultCountAbs.YMaxScaling = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.YMaxScaling")));
			this.chartRecentIncomingCallResultCountAbs.YMin = ((System.Double)(resources.GetObject("chartRecentIncomingCallResultCountAbs.YMin")));
			this.chartRecentIncomingCallResultCountAbs.YMinScaling = ((bool)(resources.GetObject("chartRecentIncomingCallResultCountAbs.YMinScaling")));
			// 
			// groupBoxPieRecentIncomingCallResultCount
			// 
			this.groupBoxPieRecentIncomingCallResultCount.AccessibleDescription = resources.GetString("groupBoxPieRecentIncomingCallResultCount.AccessibleDescription");
			this.groupBoxPieRecentIncomingCallResultCount.AccessibleName = resources.GetString("groupBoxPieRecentIncomingCallResultCount.AccessibleName");
			this.groupBoxPieRecentIncomingCallResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Anchor")));
			this.groupBoxPieRecentIncomingCallResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.BackgroundImage")));
			this.groupBoxPieRecentIncomingCallResultCount.Controls.Add(this.pieRecentIncomingCallResultCount);
			this.groupBoxPieRecentIncomingCallResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Dock")));
			this.groupBoxPieRecentIncomingCallResultCount.Enabled = ((bool)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Enabled")));
			this.groupBoxPieRecentIncomingCallResultCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Font")));
			this.groupBoxPieRecentIncomingCallResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.ImeMode")));
			this.groupBoxPieRecentIncomingCallResultCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Location")));
			this.groupBoxPieRecentIncomingCallResultCount.Name = "groupBoxPieRecentIncomingCallResultCount";
			this.groupBoxPieRecentIncomingCallResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.RightToLeft")));
			this.groupBoxPieRecentIncomingCallResultCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Size")));
			this.groupBoxPieRecentIncomingCallResultCount.TabIndex = ((int)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.TabIndex")));
			this.groupBoxPieRecentIncomingCallResultCount.TabStop = false;
			this.groupBoxPieRecentIncomingCallResultCount.Text = resources.GetString("groupBoxPieRecentIncomingCallResultCount.Text");
			this.groupBoxPieRecentIncomingCallResultCount.Visible = ((bool)(resources.GetObject("groupBoxPieRecentIncomingCallResultCount.Visible")));
			// 
			// pieRecentIncomingCallResultCount
			// 
			this.pieRecentIncomingCallResultCount.AccessibleDescription = resources.GetString("pieRecentIncomingCallResultCount.AccessibleDescription");
			this.pieRecentIncomingCallResultCount.AccessibleName = resources.GetString("pieRecentIncomingCallResultCount.AccessibleName");
			this.pieRecentIncomingCallResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pieRecentIncomingCallResultCount.Anchor")));
			this.pieRecentIncomingCallResultCount.AutoScroll = ((bool)(resources.GetObject("pieRecentIncomingCallResultCount.AutoScroll")));
			this.pieRecentIncomingCallResultCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pieRecentIncomingCallResultCount.AutoScrollMargin")));
			this.pieRecentIncomingCallResultCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pieRecentIncomingCallResultCount.AutoScrollMinSize")));
			this.pieRecentIncomingCallResultCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("pieRecentIncomingCallResultCount.BackgroundColor")));
			this.pieRecentIncomingCallResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieRecentIncomingCallResultCount.BackgroundImage")));
			this.pieRecentIncomingCallResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pieRecentIncomingCallResultCount.Dock")));
			this.pieRecentIncomingCallResultCount.Enabled = ((bool)(resources.GetObject("pieRecentIncomingCallResultCount.Enabled")));
			this.pieRecentIncomingCallResultCount.Font = ((System.Drawing.Font)(resources.GetObject("pieRecentIncomingCallResultCount.Font")));
			this.pieRecentIncomingCallResultCount.HorizontalSpace = ((int)(resources.GetObject("pieRecentIncomingCallResultCount.HorizontalSpace")));
			this.pieRecentIncomingCallResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pieRecentIncomingCallResultCount.ImeMode")));
			this.pieRecentIncomingCallResultCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("pieRecentIncomingCallResultCount.LegendAlignment")));
			this.pieRecentIncomingCallResultCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("pieRecentIncomingCallResultCount.LegendColor")));
			this.pieRecentIncomingCallResultCount.Location = ((System.Drawing.Point)(resources.GetObject("pieRecentIncomingCallResultCount.Location")));
			this.pieRecentIncomingCallResultCount.Name = "pieRecentIncomingCallResultCount";
			this.pieRecentIncomingCallResultCount.Painting = ((bool)(resources.GetObject("pieRecentIncomingCallResultCount.Painting")));
			this.pieRecentIncomingCallResultCount.RefreshInterval = ((int)(resources.GetObject("pieRecentIncomingCallResultCount.RefreshInterval")));
			this.pieRecentIncomingCallResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pieRecentIncomingCallResultCount.RightToLeft")));
			this.pieRecentIncomingCallResultCount.Size = ((System.Drawing.Size)(resources.GetObject("pieRecentIncomingCallResultCount.Size")));
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
			this.pieRecentIncomingCallResultCount.Slices.AddRange(new itCampus.bb.Graph.Pie.Slice[] {
																										slice1,
																										slice2,
																										slice3,
																										slice4,
																										slice5});
			this.pieRecentIncomingCallResultCount.TabIndex = ((int)(resources.GetObject("pieRecentIncomingCallResultCount.TabIndex")));
			this.pieRecentIncomingCallResultCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("pieRecentIncomingCallResultCount.ValueColor")));
			this.pieRecentIncomingCallResultCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("pieRecentIncomingCallResultCount.ValueType")));
			this.pieRecentIncomingCallResultCount.VerticalSpace = ((int)(resources.GetObject("pieRecentIncomingCallResultCount.VerticalSpace")));
			this.pieRecentIncomingCallResultCount.Visible = ((bool)(resources.GetObject("pieRecentIncomingCallResultCount.Visible")));
			// 
			// groupBoxRecentIncomingCallResults
			// 
			this.groupBoxRecentIncomingCallResults.AccessibleDescription = resources.GetString("groupBoxRecentIncomingCallResults.AccessibleDescription");
			this.groupBoxRecentIncomingCallResults.AccessibleName = resources.GetString("groupBoxRecentIncomingCallResults.AccessibleName");
			this.groupBoxRecentIncomingCallResults.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxRecentIncomingCallResults.Anchor")));
			this.groupBoxRecentIncomingCallResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxRecentIncomingCallResults.BackgroundImage")));
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsBottomLineGray);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsBottomLineWhite);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPutThroughRelMea);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPutThroughRel);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPutThroughAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPutThroughCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountLostRelMea);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountLostRel);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountLostAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountLostCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountNoInterestRelMea);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountNoInterestRel);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountNoInterestAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountNoInterestCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountTelcoOverloadRelMea);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountTelcoOverloadRel);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountTelcoOverloadAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountTelcoOverloadCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPSTNFailureRelMea);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPSTNFailureRel);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPSTNFailureAbs);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultCountPSTNFailureCap);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsTopLineGray);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsTopLineWhite);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsRowRate);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsRowCount);
			this.groupBoxRecentIncomingCallResults.Controls.Add(this.labelRecentIncomingCallResultsRowResult);
			this.groupBoxRecentIncomingCallResults.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxRecentIncomingCallResults.Dock")));
			this.groupBoxRecentIncomingCallResults.Enabled = ((bool)(resources.GetObject("groupBoxRecentIncomingCallResults.Enabled")));
			this.groupBoxRecentIncomingCallResults.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxRecentIncomingCallResults.Font")));
			this.groupBoxRecentIncomingCallResults.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxRecentIncomingCallResults.ImeMode")));
			this.groupBoxRecentIncomingCallResults.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxRecentIncomingCallResults.Location")));
			this.groupBoxRecentIncomingCallResults.Name = "groupBoxRecentIncomingCallResults";
			this.groupBoxRecentIncomingCallResults.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxRecentIncomingCallResults.RightToLeft")));
			this.groupBoxRecentIncomingCallResults.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxRecentIncomingCallResults.Size")));
			this.groupBoxRecentIncomingCallResults.TabIndex = ((int)(resources.GetObject("groupBoxRecentIncomingCallResults.TabIndex")));
			this.groupBoxRecentIncomingCallResults.TabStop = false;
			this.groupBoxRecentIncomingCallResults.Text = resources.GetString("groupBoxRecentIncomingCallResults.Text");
			this.groupBoxRecentIncomingCallResults.Visible = ((bool)(resources.GetObject("groupBoxRecentIncomingCallResults.Visible")));
			// 
			// labelRecentIncomingCallResultCountAbs
			// 
			this.labelRecentIncomingCallResultCountAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Anchor")));
			this.labelRecentIncomingCallResultCountAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Dock")));
			this.labelRecentIncomingCallResultCountAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Enabled")));
			this.labelRecentIncomingCallResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Font")));
			this.labelRecentIncomingCallResultCountAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Image")));
			this.labelRecentIncomingCallResultCountAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Location")));
			this.labelRecentIncomingCallResultCountAbs.Name = "labelRecentIncomingCallResultCountAbs";
			this.labelRecentIncomingCallResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Size")));
			this.labelRecentIncomingCallResultCountAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountAbs.Text = resources.GetString("labelRecentIncomingCallResultCountAbs.Text");
			this.labelRecentIncomingCallResultCountAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountCap
			// 
			this.labelRecentIncomingCallResultCountCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountCap.AccessibleName");
			this.labelRecentIncomingCallResultCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountCap.Anchor")));
			this.labelRecentIncomingCallResultCountCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountCap.AutoSize")));
			this.labelRecentIncomingCallResultCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountCap.Dock")));
			this.labelRecentIncomingCallResultCountCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountCap.Enabled")));
			this.labelRecentIncomingCallResultCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountCap.Font")));
			this.labelRecentIncomingCallResultCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountCap.Image")));
			this.labelRecentIncomingCallResultCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountCap.ImeMode")));
			this.labelRecentIncomingCallResultCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountCap.Location")));
			this.labelRecentIncomingCallResultCountCap.Name = "labelRecentIncomingCallResultCountCap";
			this.labelRecentIncomingCallResultCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountCap.Size")));
			this.labelRecentIncomingCallResultCountCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountCap.TabIndex")));
			this.labelRecentIncomingCallResultCountCap.Text = resources.GetString("labelRecentIncomingCallResultCountCap.Text");
			this.labelRecentIncomingCallResultCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountCap.TextAlign")));
			this.labelRecentIncomingCallResultCountCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountCap.Visible")));
			// 
			// labelRecentIncomingCallResultsBottomLineGray
			// 
			this.labelRecentIncomingCallResultsBottomLineGray.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsBottomLineGray.AccessibleDescription");
			this.labelRecentIncomingCallResultsBottomLineGray.AccessibleName = resources.GetString("labelRecentIncomingCallResultsBottomLineGray.AccessibleName");
			this.labelRecentIncomingCallResultsBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Anchor")));
			this.labelRecentIncomingCallResultsBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.AutoSize")));
			this.labelRecentIncomingCallResultsBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelRecentIncomingCallResultsBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Dock")));
			this.labelRecentIncomingCallResultsBottomLineGray.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Enabled")));
			this.labelRecentIncomingCallResultsBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Font")));
			this.labelRecentIncomingCallResultsBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentIncomingCallResultsBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Image")));
			this.labelRecentIncomingCallResultsBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.ImageAlign")));
			this.labelRecentIncomingCallResultsBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.ImageIndex")));
			this.labelRecentIncomingCallResultsBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.ImeMode")));
			this.labelRecentIncomingCallResultsBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Location")));
			this.labelRecentIncomingCallResultsBottomLineGray.Name = "labelRecentIncomingCallResultsBottomLineGray";
			this.labelRecentIncomingCallResultsBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.RightToLeft")));
			this.labelRecentIncomingCallResultsBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Size")));
			this.labelRecentIncomingCallResultsBottomLineGray.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.TabIndex")));
			this.labelRecentIncomingCallResultsBottomLineGray.Text = resources.GetString("labelRecentIncomingCallResultsBottomLineGray.Text");
			this.labelRecentIncomingCallResultsBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.TextAlign")));
			this.labelRecentIncomingCallResultsBottomLineGray.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineGray.Visible")));
			// 
			// labelRecentIncomingCallResultsBottomLineWhite
			// 
			this.labelRecentIncomingCallResultsBottomLineWhite.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsBottomLineWhite.AccessibleDescription");
			this.labelRecentIncomingCallResultsBottomLineWhite.AccessibleName = resources.GetString("labelRecentIncomingCallResultsBottomLineWhite.AccessibleName");
			this.labelRecentIncomingCallResultsBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Anchor")));
			this.labelRecentIncomingCallResultsBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.AutoSize")));
			this.labelRecentIncomingCallResultsBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelRecentIncomingCallResultsBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Dock")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Enabled")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Font")));
			this.labelRecentIncomingCallResultsBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentIncomingCallResultsBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Image")));
			this.labelRecentIncomingCallResultsBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.ImageAlign")));
			this.labelRecentIncomingCallResultsBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.ImageIndex")));
			this.labelRecentIncomingCallResultsBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.ImeMode")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Location")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Name = "labelRecentIncomingCallResultsBottomLineWhite";
			this.labelRecentIncomingCallResultsBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.RightToLeft")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Size")));
			this.labelRecentIncomingCallResultsBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.TabIndex")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Text = resources.GetString("labelRecentIncomingCallResultsBottomLineWhite.Text");
			this.labelRecentIncomingCallResultsBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.TextAlign")));
			this.labelRecentIncomingCallResultsBottomLineWhite.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsBottomLineWhite.Visible")));
			// 
			// labelRecentIncomingCallResultCountPutThroughRelMea
			// 
			this.labelRecentIncomingCallResultCountPutThroughRelMea.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPutThroughRelMea.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPutThroughRelMea.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPutThroughRelMea.AccessibleName");
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Anchor")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.AutoSize")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Dock")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Enabled")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Font")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Image")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.ImageAlign")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.ImageIndex")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.ImeMode")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Location")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Name = "labelRecentIncomingCallResultCountPutThroughRelMea";
			this.labelRecentIncomingCallResultCountPutThroughRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.RightToLeft")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Size")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.TabIndex")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Text = resources.GetString("labelRecentIncomingCallResultCountPutThroughRelMea.Text");
			this.labelRecentIncomingCallResultCountPutThroughRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.TextAlign")));
			this.labelRecentIncomingCallResultCountPutThroughRelMea.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRelMea.Visible")));
			// 
			// labelRecentIncomingCallResultCountPutThroughRel
			// 
			this.labelRecentIncomingCallResultCountPutThroughRel.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPutThroughRel.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPutThroughRel.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPutThroughRel.AccessibleName");
			this.labelRecentIncomingCallResultCountPutThroughRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Anchor")));
			this.labelRecentIncomingCallResultCountPutThroughRel.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.AutoSize")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Dock")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Enabled")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Font")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Image")));
			this.labelRecentIncomingCallResultCountPutThroughRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.ImageAlign")));
			this.labelRecentIncomingCallResultCountPutThroughRel.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.ImageIndex")));
			this.labelRecentIncomingCallResultCountPutThroughRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.ImeMode")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Location")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Name = "labelRecentIncomingCallResultCountPutThroughRel";
			this.labelRecentIncomingCallResultCountPutThroughRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.RightToLeft")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Size")));
			this.labelRecentIncomingCallResultCountPutThroughRel.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.TabIndex")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Text = resources.GetString("labelRecentIncomingCallResultCountPutThroughRel.Text");
			this.labelRecentIncomingCallResultCountPutThroughRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.TextAlign")));
			this.labelRecentIncomingCallResultCountPutThroughRel.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughRel.Visible")));
			// 
			// labelRecentIncomingCallResultCountPutThroughAbs
			// 
			this.labelRecentIncomingCallResultCountPutThroughAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPutThroughAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPutThroughAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPutThroughAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountPutThroughAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Anchor")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Dock")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Enabled")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Font")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Image")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Location")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Name = "labelRecentIncomingCallResultCountPutThroughAbs";
			this.labelRecentIncomingCallResultCountPutThroughAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Size")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Text = resources.GetString("labelRecentIncomingCallResultCountPutThroughAbs.Text");
			this.labelRecentIncomingCallResultCountPutThroughAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountPutThroughAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountPutThroughCap
			// 
			this.labelRecentIncomingCallResultCountPutThroughCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPutThroughCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPutThroughCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPutThroughCap.AccessibleName");
			this.labelRecentIncomingCallResultCountPutThroughCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Anchor")));
			this.labelRecentIncomingCallResultCountPutThroughCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.AutoSize")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Dock")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Enabled")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Font")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Image")));
			this.labelRecentIncomingCallResultCountPutThroughCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountPutThroughCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountPutThroughCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.ImeMode")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Location")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Name = "labelRecentIncomingCallResultCountPutThroughCap";
			this.labelRecentIncomingCallResultCountPutThroughCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Size")));
			this.labelRecentIncomingCallResultCountPutThroughCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.TabIndex")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Text = resources.GetString("labelRecentIncomingCallResultCountPutThroughCap.Text");
			this.labelRecentIncomingCallResultCountPutThroughCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.TextAlign")));
			this.labelRecentIncomingCallResultCountPutThroughCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPutThroughCap.Visible")));
			// 
			// labelRecentIncomingCallResultCountLostRelMea
			// 
			this.labelRecentIncomingCallResultCountLostRelMea.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountLostRelMea.AccessibleDescription");
			this.labelRecentIncomingCallResultCountLostRelMea.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountLostRelMea.AccessibleName");
			this.labelRecentIncomingCallResultCountLostRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Anchor")));
			this.labelRecentIncomingCallResultCountLostRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.AutoSize")));
			this.labelRecentIncomingCallResultCountLostRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Dock")));
			this.labelRecentIncomingCallResultCountLostRelMea.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Enabled")));
			this.labelRecentIncomingCallResultCountLostRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Font")));
			this.labelRecentIncomingCallResultCountLostRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Image")));
			this.labelRecentIncomingCallResultCountLostRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.ImageAlign")));
			this.labelRecentIncomingCallResultCountLostRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.ImageIndex")));
			this.labelRecentIncomingCallResultCountLostRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.ImeMode")));
			this.labelRecentIncomingCallResultCountLostRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Location")));
			this.labelRecentIncomingCallResultCountLostRelMea.Name = "labelRecentIncomingCallResultCountLostRelMea";
			this.labelRecentIncomingCallResultCountLostRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.RightToLeft")));
			this.labelRecentIncomingCallResultCountLostRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Size")));
			this.labelRecentIncomingCallResultCountLostRelMea.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.TabIndex")));
			this.labelRecentIncomingCallResultCountLostRelMea.Text = resources.GetString("labelRecentIncomingCallResultCountLostRelMea.Text");
			this.labelRecentIncomingCallResultCountLostRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.TextAlign")));
			this.labelRecentIncomingCallResultCountLostRelMea.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRelMea.Visible")));
			// 
			// labelRecentIncomingCallResultCountLostRel
			// 
			this.labelRecentIncomingCallResultCountLostRel.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountLostRel.AccessibleDescription");
			this.labelRecentIncomingCallResultCountLostRel.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountLostRel.AccessibleName");
			this.labelRecentIncomingCallResultCountLostRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Anchor")));
			this.labelRecentIncomingCallResultCountLostRel.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.AutoSize")));
			this.labelRecentIncomingCallResultCountLostRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Dock")));
			this.labelRecentIncomingCallResultCountLostRel.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Enabled")));
			this.labelRecentIncomingCallResultCountLostRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Font")));
			this.labelRecentIncomingCallResultCountLostRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Image")));
			this.labelRecentIncomingCallResultCountLostRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.ImageAlign")));
			this.labelRecentIncomingCallResultCountLostRel.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.ImageIndex")));
			this.labelRecentIncomingCallResultCountLostRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.ImeMode")));
			this.labelRecentIncomingCallResultCountLostRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Location")));
			this.labelRecentIncomingCallResultCountLostRel.Name = "labelRecentIncomingCallResultCountLostRel";
			this.labelRecentIncomingCallResultCountLostRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.RightToLeft")));
			this.labelRecentIncomingCallResultCountLostRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Size")));
			this.labelRecentIncomingCallResultCountLostRel.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.TabIndex")));
			this.labelRecentIncomingCallResultCountLostRel.Text = resources.GetString("labelRecentIncomingCallResultCountLostRel.Text");
			this.labelRecentIncomingCallResultCountLostRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.TextAlign")));
			this.labelRecentIncomingCallResultCountLostRel.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostRel.Visible")));
			// 
			// labelRecentIncomingCallResultCountLostAbs
			// 
			this.labelRecentIncomingCallResultCountLostAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountLostAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountLostAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountLostAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountLostAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Anchor")));
			this.labelRecentIncomingCallResultCountLostAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountLostAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Dock")));
			this.labelRecentIncomingCallResultCountLostAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Enabled")));
			this.labelRecentIncomingCallResultCountLostAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Font")));
			this.labelRecentIncomingCallResultCountLostAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Image")));
			this.labelRecentIncomingCallResultCountLostAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountLostAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountLostAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountLostAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Location")));
			this.labelRecentIncomingCallResultCountLostAbs.Name = "labelRecentIncomingCallResultCountLostAbs";
			this.labelRecentIncomingCallResultCountLostAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountLostAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Size")));
			this.labelRecentIncomingCallResultCountLostAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountLostAbs.Text = resources.GetString("labelRecentIncomingCallResultCountLostAbs.Text");
			this.labelRecentIncomingCallResultCountLostAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountLostAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountLostCap
			// 
			this.labelRecentIncomingCallResultCountLostCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountLostCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountLostCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountLostCap.AccessibleName");
			this.labelRecentIncomingCallResultCountLostCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Anchor")));
			this.labelRecentIncomingCallResultCountLostCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.AutoSize")));
			this.labelRecentIncomingCallResultCountLostCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Dock")));
			this.labelRecentIncomingCallResultCountLostCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Enabled")));
			this.labelRecentIncomingCallResultCountLostCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Font")));
			this.labelRecentIncomingCallResultCountLostCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Image")));
			this.labelRecentIncomingCallResultCountLostCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountLostCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountLostCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.ImeMode")));
			this.labelRecentIncomingCallResultCountLostCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Location")));
			this.labelRecentIncomingCallResultCountLostCap.Name = "labelRecentIncomingCallResultCountLostCap";
			this.labelRecentIncomingCallResultCountLostCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountLostCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Size")));
			this.labelRecentIncomingCallResultCountLostCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.TabIndex")));
			this.labelRecentIncomingCallResultCountLostCap.Text = resources.GetString("labelRecentIncomingCallResultCountLostCap.Text");
			this.labelRecentIncomingCallResultCountLostCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.TextAlign")));
			this.labelRecentIncomingCallResultCountLostCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountLostCap.Visible")));
			// 
			// labelRecentIncomingCallResultCountNoInterestRelMea
			// 
			this.labelRecentIncomingCallResultCountNoInterestRelMea.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountNoInterestRelMea.AccessibleDescription");
			this.labelRecentIncomingCallResultCountNoInterestRelMea.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountNoInterestRelMea.AccessibleName");
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Anchor")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.AutoSize")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Dock")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Enabled")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Font")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Image")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.ImageAlign")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.ImageIndex")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.ImeMode")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Location")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Name = "labelRecentIncomingCallResultCountNoInterestRelMea";
			this.labelRecentIncomingCallResultCountNoInterestRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.RightToLeft")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Size")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.TabIndex")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Text = resources.GetString("labelRecentIncomingCallResultCountNoInterestRelMea.Text");
			this.labelRecentIncomingCallResultCountNoInterestRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.TextAlign")));
			this.labelRecentIncomingCallResultCountNoInterestRelMea.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRelMea.Visible")));
			// 
			// labelRecentIncomingCallResultCountNoInterestRel
			// 
			this.labelRecentIncomingCallResultCountNoInterestRel.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountNoInterestRel.AccessibleDescription");
			this.labelRecentIncomingCallResultCountNoInterestRel.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountNoInterestRel.AccessibleName");
			this.labelRecentIncomingCallResultCountNoInterestRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Anchor")));
			this.labelRecentIncomingCallResultCountNoInterestRel.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.AutoSize")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Dock")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Enabled")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Font")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Image")));
			this.labelRecentIncomingCallResultCountNoInterestRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.ImageAlign")));
			this.labelRecentIncomingCallResultCountNoInterestRel.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.ImageIndex")));
			this.labelRecentIncomingCallResultCountNoInterestRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.ImeMode")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Location")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Name = "labelRecentIncomingCallResultCountNoInterestRel";
			this.labelRecentIncomingCallResultCountNoInterestRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.RightToLeft")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Size")));
			this.labelRecentIncomingCallResultCountNoInterestRel.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.TabIndex")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Text = resources.GetString("labelRecentIncomingCallResultCountNoInterestRel.Text");
			this.labelRecentIncomingCallResultCountNoInterestRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.TextAlign")));
			this.labelRecentIncomingCallResultCountNoInterestRel.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestRel.Visible")));
			// 
			// labelRecentIncomingCallResultCountNoInterestAbs
			// 
			this.labelRecentIncomingCallResultCountNoInterestAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountNoInterestAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountNoInterestAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountNoInterestAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountNoInterestAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Anchor")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Dock")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Enabled")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Font")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Image")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Location")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Name = "labelRecentIncomingCallResultCountNoInterestAbs";
			this.labelRecentIncomingCallResultCountNoInterestAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Size")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Text = resources.GetString("labelRecentIncomingCallResultCountNoInterestAbs.Text");
			this.labelRecentIncomingCallResultCountNoInterestAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountNoInterestAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountNoInterestCap
			// 
			this.labelRecentIncomingCallResultCountNoInterestCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountNoInterestCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountNoInterestCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountNoInterestCap.AccessibleName");
			this.labelRecentIncomingCallResultCountNoInterestCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Anchor")));
			this.labelRecentIncomingCallResultCountNoInterestCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.AutoSize")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Dock")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Enabled")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Font")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Image")));
			this.labelRecentIncomingCallResultCountNoInterestCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountNoInterestCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountNoInterestCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.ImeMode")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Location")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Name = "labelRecentIncomingCallResultCountNoInterestCap";
			this.labelRecentIncomingCallResultCountNoInterestCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Size")));
			this.labelRecentIncomingCallResultCountNoInterestCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.TabIndex")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Text = resources.GetString("labelRecentIncomingCallResultCountNoInterestCap.Text");
			this.labelRecentIncomingCallResultCountNoInterestCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.TextAlign")));
			this.labelRecentIncomingCallResultCountNoInterestCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountNoInterestCap.Visible")));
			// 
			// labelRecentIncomingCallResultCountTelcoOverloadRelMea
			// 
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRelMea.AccessibleDescription");
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRelMea.AccessibleName");
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Anchor")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.AutoSize")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Dock")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Enabled")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Font")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Image")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImageAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImageIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.ImeMode")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Location")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Name = "labelRecentIncomingCallResultCountTelcoOverloadRelMea";
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.RightToLeft")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Size")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.TabIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Text = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Text");
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.TextAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRelMea.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRelMea.Visible")));
			// 
			// labelRecentIncomingCallResultCountTelcoOverloadRel
			// 
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRel.AccessibleDescription");
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRel.AccessibleName");
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Anchor")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.AutoSize")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Dock")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Enabled")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Font")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Image")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.ImageAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.ImageIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.ImeMode")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Location")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Name = "labelRecentIncomingCallResultCountTelcoOverloadRel";
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.RightToLeft")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Size")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.TabIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Text = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadRel.Text");
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.TextAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadRel.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadRel.Visible")));
			// 
			// labelRecentIncomingCallResultCountTelcoOverloadAbs
			// 
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Anchor")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Dock")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Enabled")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Font")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Image")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Location")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Name = "labelRecentIncomingCallResultCountTelcoOverloadAbs";
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Size")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Text = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadAbs.Text");
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountTelcoOverloadCap
			// 
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadCap.AccessibleName");
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Anchor")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.AutoSize")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Dock")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Enabled")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Font")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Image")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.ImeMode")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Location")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Name = "labelRecentIncomingCallResultCountTelcoOverloadCap";
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Size")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.TabIndex")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Text = resources.GetString("labelRecentIncomingCallResultCountTelcoOverloadCap.Text");
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.TextAlign")));
			this.labelRecentIncomingCallResultCountTelcoOverloadCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountTelcoOverloadCap.Visible")));
			// 
			// labelRecentIncomingCallResultCountPSTNFailureRelMea
			// 
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRelMea.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRelMea.AccessibleName");
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Anchor")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.AutoSize")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Dock")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Enabled")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Font")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Image")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.ImageAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.ImageIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.ImeMode")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Location")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Name = "labelRecentIncomingCallResultCountPSTNFailureRelMea";
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.RightToLeft")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Size")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.TabIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Text = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRelMea.Text");
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.TextAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureRelMea.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRelMea.Visible")));
			// 
			// labelRecentIncomingCallResultCountPSTNFailureRel
			// 
			this.labelRecentIncomingCallResultCountPSTNFailureRel.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRel.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPSTNFailureRel.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRel.AccessibleName");
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Anchor")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.AutoSize")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Dock")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Enabled")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Font")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Image")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.ImageAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.ImageIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.ImeMode")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Location")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Name = "labelRecentIncomingCallResultCountPSTNFailureRel";
			this.labelRecentIncomingCallResultCountPSTNFailureRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.RightToLeft")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Size")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.TabIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Text = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureRel.Text");
			this.labelRecentIncomingCallResultCountPSTNFailureRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.TextAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureRel.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureRel.Visible")));
			// 
			// labelRecentIncomingCallResultCountPSTNFailureAbs
			// 
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureAbs.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureAbs.AccessibleName");
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Anchor")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.AutoSize")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Dock")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Enabled")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Font")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Image")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.ImageAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.ImageIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.ImeMode")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Location")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Name = "labelRecentIncomingCallResultCountPSTNFailureAbs";
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.RightToLeft")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Size")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.TabIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Text = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureAbs.Text");
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.TextAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureAbs.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureAbs.Visible")));
			// 
			// labelRecentIncomingCallResultCountPSTNFailureCap
			// 
			this.labelRecentIncomingCallResultCountPSTNFailureCap.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureCap.AccessibleDescription");
			this.labelRecentIncomingCallResultCountPSTNFailureCap.AccessibleName = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureCap.AccessibleName");
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Anchor")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.AutoSize")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Dock")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Enabled")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Font")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Image")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.ImageAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.ImageIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.ImeMode")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Location")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Name = "labelRecentIncomingCallResultCountPSTNFailureCap";
			this.labelRecentIncomingCallResultCountPSTNFailureCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.RightToLeft")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Size")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.TabIndex")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Text = resources.GetString("labelRecentIncomingCallResultCountPSTNFailureCap.Text");
			this.labelRecentIncomingCallResultCountPSTNFailureCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.TextAlign")));
			this.labelRecentIncomingCallResultCountPSTNFailureCap.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultCountPSTNFailureCap.Visible")));
			// 
			// labelRecentIncomingCallResultsTopLineGray
			// 
			this.labelRecentIncomingCallResultsTopLineGray.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsTopLineGray.AccessibleDescription");
			this.labelRecentIncomingCallResultsTopLineGray.AccessibleName = resources.GetString("labelRecentIncomingCallResultsTopLineGray.AccessibleName");
			this.labelRecentIncomingCallResultsTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Anchor")));
			this.labelRecentIncomingCallResultsTopLineGray.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.AutoSize")));
			this.labelRecentIncomingCallResultsTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelRecentIncomingCallResultsTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Dock")));
			this.labelRecentIncomingCallResultsTopLineGray.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Enabled")));
			this.labelRecentIncomingCallResultsTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Font")));
			this.labelRecentIncomingCallResultsTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentIncomingCallResultsTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Image")));
			this.labelRecentIncomingCallResultsTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.ImageAlign")));
			this.labelRecentIncomingCallResultsTopLineGray.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.ImageIndex")));
			this.labelRecentIncomingCallResultsTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.ImeMode")));
			this.labelRecentIncomingCallResultsTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Location")));
			this.labelRecentIncomingCallResultsTopLineGray.Name = "labelRecentIncomingCallResultsTopLineGray";
			this.labelRecentIncomingCallResultsTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.RightToLeft")));
			this.labelRecentIncomingCallResultsTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Size")));
			this.labelRecentIncomingCallResultsTopLineGray.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.TabIndex")));
			this.labelRecentIncomingCallResultsTopLineGray.Text = resources.GetString("labelRecentIncomingCallResultsTopLineGray.Text");
			this.labelRecentIncomingCallResultsTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.TextAlign")));
			this.labelRecentIncomingCallResultsTopLineGray.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineGray.Visible")));
			// 
			// labelRecentIncomingCallResultsTopLineWhite
			// 
			this.labelRecentIncomingCallResultsTopLineWhite.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsTopLineWhite.AccessibleDescription");
			this.labelRecentIncomingCallResultsTopLineWhite.AccessibleName = resources.GetString("labelRecentIncomingCallResultsTopLineWhite.AccessibleName");
			this.labelRecentIncomingCallResultsTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Anchor")));
			this.labelRecentIncomingCallResultsTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.AutoSize")));
			this.labelRecentIncomingCallResultsTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelRecentIncomingCallResultsTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Dock")));
			this.labelRecentIncomingCallResultsTopLineWhite.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Enabled")));
			this.labelRecentIncomingCallResultsTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Font")));
			this.labelRecentIncomingCallResultsTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentIncomingCallResultsTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Image")));
			this.labelRecentIncomingCallResultsTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.ImageAlign")));
			this.labelRecentIncomingCallResultsTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.ImageIndex")));
			this.labelRecentIncomingCallResultsTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.ImeMode")));
			this.labelRecentIncomingCallResultsTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Location")));
			this.labelRecentIncomingCallResultsTopLineWhite.Name = "labelRecentIncomingCallResultsTopLineWhite";
			this.labelRecentIncomingCallResultsTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.RightToLeft")));
			this.labelRecentIncomingCallResultsTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Size")));
			this.labelRecentIncomingCallResultsTopLineWhite.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.TabIndex")));
			this.labelRecentIncomingCallResultsTopLineWhite.Text = resources.GetString("labelRecentIncomingCallResultsTopLineWhite.Text");
			this.labelRecentIncomingCallResultsTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.TextAlign")));
			this.labelRecentIncomingCallResultsTopLineWhite.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsTopLineWhite.Visible")));
			// 
			// labelRecentIncomingCallResultsRowRate
			// 
			this.labelRecentIncomingCallResultsRowRate.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsRowRate.AccessibleDescription");
			this.labelRecentIncomingCallResultsRowRate.AccessibleName = resources.GetString("labelRecentIncomingCallResultsRowRate.AccessibleName");
			this.labelRecentIncomingCallResultsRowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Anchor")));
			this.labelRecentIncomingCallResultsRowRate.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowRate.AutoSize")));
			this.labelRecentIncomingCallResultsRowRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Dock")));
			this.labelRecentIncomingCallResultsRowRate.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Enabled")));
			this.labelRecentIncomingCallResultsRowRate.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Font")));
			this.labelRecentIncomingCallResultsRowRate.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Image")));
			this.labelRecentIncomingCallResultsRowRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowRate.ImageAlign")));
			this.labelRecentIncomingCallResultsRowRate.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowRate.ImageIndex")));
			this.labelRecentIncomingCallResultsRowRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsRowRate.ImeMode")));
			this.labelRecentIncomingCallResultsRowRate.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Location")));
			this.labelRecentIncomingCallResultsRowRate.Name = "labelRecentIncomingCallResultsRowRate";
			this.labelRecentIncomingCallResultsRowRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsRowRate.RightToLeft")));
			this.labelRecentIncomingCallResultsRowRate.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Size")));
			this.labelRecentIncomingCallResultsRowRate.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowRate.TabIndex")));
			this.labelRecentIncomingCallResultsRowRate.Text = resources.GetString("labelRecentIncomingCallResultsRowRate.Text");
			this.labelRecentIncomingCallResultsRowRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowRate.TextAlign")));
			this.labelRecentIncomingCallResultsRowRate.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowRate.Visible")));
			// 
			// labelRecentIncomingCallResultsRowCount
			// 
			this.labelRecentIncomingCallResultsRowCount.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsRowCount.AccessibleDescription");
			this.labelRecentIncomingCallResultsRowCount.AccessibleName = resources.GetString("labelRecentIncomingCallResultsRowCount.AccessibleName");
			this.labelRecentIncomingCallResultsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Anchor")));
			this.labelRecentIncomingCallResultsRowCount.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowCount.AutoSize")));
			this.labelRecentIncomingCallResultsRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Dock")));
			this.labelRecentIncomingCallResultsRowCount.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Enabled")));
			this.labelRecentIncomingCallResultsRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Font")));
			this.labelRecentIncomingCallResultsRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Image")));
			this.labelRecentIncomingCallResultsRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowCount.ImageAlign")));
			this.labelRecentIncomingCallResultsRowCount.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowCount.ImageIndex")));
			this.labelRecentIncomingCallResultsRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsRowCount.ImeMode")));
			this.labelRecentIncomingCallResultsRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Location")));
			this.labelRecentIncomingCallResultsRowCount.Name = "labelRecentIncomingCallResultsRowCount";
			this.labelRecentIncomingCallResultsRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsRowCount.RightToLeft")));
			this.labelRecentIncomingCallResultsRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Size")));
			this.labelRecentIncomingCallResultsRowCount.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowCount.TabIndex")));
			this.labelRecentIncomingCallResultsRowCount.Text = resources.GetString("labelRecentIncomingCallResultsRowCount.Text");
			this.labelRecentIncomingCallResultsRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowCount.TextAlign")));
			this.labelRecentIncomingCallResultsRowCount.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowCount.Visible")));
			// 
			// labelRecentIncomingCallResultsRowResult
			// 
			this.labelRecentIncomingCallResultsRowResult.AccessibleDescription = resources.GetString("labelRecentIncomingCallResultsRowResult.AccessibleDescription");
			this.labelRecentIncomingCallResultsRowResult.AccessibleName = resources.GetString("labelRecentIncomingCallResultsRowResult.AccessibleName");
			this.labelRecentIncomingCallResultsRowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Anchor")));
			this.labelRecentIncomingCallResultsRowResult.AutoSize = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowResult.AutoSize")));
			this.labelRecentIncomingCallResultsRowResult.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Dock")));
			this.labelRecentIncomingCallResultsRowResult.Enabled = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Enabled")));
			this.labelRecentIncomingCallResultsRowResult.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Font")));
			this.labelRecentIncomingCallResultsRowResult.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Image")));
			this.labelRecentIncomingCallResultsRowResult.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowResult.ImageAlign")));
			this.labelRecentIncomingCallResultsRowResult.ImageIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowResult.ImageIndex")));
			this.labelRecentIncomingCallResultsRowResult.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentIncomingCallResultsRowResult.ImeMode")));
			this.labelRecentIncomingCallResultsRowResult.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Location")));
			this.labelRecentIncomingCallResultsRowResult.Name = "labelRecentIncomingCallResultsRowResult";
			this.labelRecentIncomingCallResultsRowResult.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentIncomingCallResultsRowResult.RightToLeft")));
			this.labelRecentIncomingCallResultsRowResult.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Size")));
			this.labelRecentIncomingCallResultsRowResult.TabIndex = ((int)(resources.GetObject("labelRecentIncomingCallResultsRowResult.TabIndex")));
			this.labelRecentIncomingCallResultsRowResult.Text = resources.GetString("labelRecentIncomingCallResultsRowResult.Text");
			this.labelRecentIncomingCallResultsRowResult.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentIncomingCallResultsRowResult.TextAlign")));
			this.labelRecentIncomingCallResultsRowResult.Visible = ((bool)(resources.GetObject("labelRecentIncomingCallResultsRowResult.Visible")));
			// 
			// CampaignViewIncomingCallsRecentStatistics
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartRecentIncomingCallResultCountRel);
			this.Controls.Add(this.groupBoxChartRecentIncomingCallResultCountAbs);
			this.Controls.Add(this.groupBoxPieRecentIncomingCallResultCount);
			this.Controls.Add(this.groupBoxRecentIncomingCallResults);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewIncomingCallsRecentStatistics";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartRecentIncomingCallResultCountRel.ResumeLayout(false);
			this.panelChartRecentIncomingCallResultCountRel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartRecentIncomingCallResultCountRel)).EndInit();
			this.groupBoxChartRecentIncomingCallResultCountAbs.ResumeLayout(false);
			this.panelChartRecentIncomngCallResultCountAbs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartRecentIncomingCallResultCountAbs)).EndInit();
			this.groupBoxPieRecentIncomingCallResultCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pieRecentIncomingCallResultCount)).EndInit();
			this.groupBoxRecentIncomingCallResults.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// Anrufergebnisse aktualisieren
			int processedIncomingCallCountRcn =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.TelcoOverload) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough);
			labelRecentIncomingCallResultCountPSTNFailureAbs.Text =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure).ToString();
			labelRecentIncomingCallResultCountPSTNFailureRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.PSTNFailure), processedIncomingCallCountRcn).ToString();
			labelRecentIncomingCallResultCountTelcoOverloadAbs.Text =
				campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.TelcoOverload).ToString();
			labelRecentIncomingCallResultCountTelcoOverloadRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.TelcoOverload), processedIncomingCallCountRcn).ToString();
			labelRecentIncomingCallResultCountNoInterestAbs.Text =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest).ToString();
			labelRecentIncomingCallResultCountNoInterestRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.NoInterest), processedIncomingCallCountRcn).ToString();
			labelRecentIncomingCallResultCountLostAbs.Text =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost).ToString();
			labelRecentIncomingCallResultCountLostRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.Lost), processedIncomingCallCountRcn).ToString();
			labelRecentIncomingCallResultCountPutThroughAbs.Text =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough).ToString();
			labelRecentIncomingCallResultCountPutThroughRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountRcn(
				IncomingCallResult.PutThrough), processedIncomingCallCountRcn).ToString();
			labelRecentIncomingCallResultCountAbs.Text = processedIncomingCallCountRcn.ToString();

			// Tortengrafik aktualisieren
			pieRecentIncomingCallResultCount.Slices[0].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure);
			pieRecentIncomingCallResultCount.Slices[1].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.TelcoOverload);
			pieRecentIncomingCallResultCount.Slices[2].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest);
			pieRecentIncomingCallResultCount.Slices[3].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost);
			pieRecentIncomingCallResultCount.Slices[4].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough);

			// Verlaufsgrafiken aktualisieren
			chartRecentIncomingCallResultCountAbs.DataCollection =
				campaign.RecentIncomingCallResultCountAbsData;
			chartRecentIncomingCallResultCountRel.DataCollection =
				campaign.RecentIncomingCallResultCountRelData;
		}

		/// <summary>
		/// berechnet relativen Wert
		/// </summary>
		private int GetRelativeValue(int absoluteValue, int totalSum)
		{
			if (totalSum > 0)
			{
				return (int)Math.Round(((double)absoluteValue / totalSum) * 100);
			}
			else
			{
				return 0;
			}
		}

		#endregion

		#endregion
	}
}
