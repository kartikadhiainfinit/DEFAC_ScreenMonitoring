using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Eigenschaften einer Kampagne.
	/// </summary>
	public class CampaignViewProperties : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxCommon;
		private System.Windows.Forms.Label labelCodeCap;
		private System.Windows.Forms.Label labelCode;
		private System.Windows.Forms.Label labelNameCap;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelStateCap;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.Label labelStateTimeCap;
		private System.Windows.Forms.Label labelStateTime;
		private System.Windows.Forms.GroupBox groupBoxPerformance;
		private System.Windows.Forms.Label labelPerformanceRowProperty;
		private System.Windows.Forms.Label labelPerformanceRowCurrent;
		private System.Windows.Forms.Label labelPerformanceRowTotal;
		private System.Windows.Forms.Label labelPerformanceRowLimit;
		private System.Windows.Forms.Label labelPerformanceLineWhite;
		private System.Windows.Forms.Label labelPerformanceLineGray;
		private System.Windows.Forms.Label labelDialRateCap;
		private System.Windows.Forms.Label labelDialRateCurrent;
		private System.Windows.Forms.Label labelDialRateLimit;
		private System.Windows.Forms.Label labelPreLevelCap;
		private System.Windows.Forms.Label labelPreLevelCurrent;
		private System.Windows.Forms.Label labelDropRateCap;
		private System.Windows.Forms.Label labelDropRateCurrent;
		private System.Windows.Forms.Label labelDropRateCurrentMea;
		private System.Windows.Forms.Label labelDropRateTotal;
		private System.Windows.Forms.Label labelDropRateTotalMea;
		private System.Windows.Forms.Label labelDropRateLimit;
		private System.Windows.Forms.Label labelDropRateLimitMea;
		private System.Windows.Forms.Label labelLostRateCap;
		private System.Windows.Forms.Label labelLostRateCurrent;
		private System.Windows.Forms.Label labelLostRateCurrentMea;
		private System.Windows.Forms.Label labelLostRateTotal;
		private System.Windows.Forms.Label labelLostRateTotalMea;
		private System.Windows.Forms.Label labelLostRateLimit;
		private System.Windows.Forms.Label labelLostRateLimitMea;
		private System.Windows.Forms.Label labelAgentRelaxTimeCap;
		private System.Windows.Forms.Label labelAgentRelaxTimeCurrent;
		private System.Windows.Forms.Label labelAgentRelaxTimeCurrentMea;
		private System.Windows.Forms.Label labelAgentRelaxTimeTotal;
		private System.Windows.Forms.Label labelAgentRelaxTimeTotalMea;
		private System.Windows.Forms.Label labelAgentRelaxTimeLimit;
		private System.Windows.Forms.Label labelAgentRelaxTimeLimitMea;
		private System.Windows.Forms.GroupBox groupBoxChartPerformanceSpeeds;
		private System.Windows.Forms.Panel panelChartPerformanceSpeeds;
		private itCampus.bb.Graph.Chart.Chart chartPerformanceSpeeds;
		private System.Windows.Forms.GroupBox groupBoxChartPerformanceLimits;
		private System.Windows.Forms.Panel panelChartPerformanceLimits;
		private itCampus.bb.Graph.Chart.Chart chartPerformanceLimits;
		private System.Windows.Forms.Timer timerRefresh;
		private System.ComponentModel.IContainer components;

		// Parameter
		private DateTime _lastStateChange; // Zeitpunkt für letzten Statuswechsel

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewProperties()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewProperties));
			itCampus.bb.Graph.Chart.Curve curve1 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve2 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve3 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve4 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve5 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve6 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve7 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve8 = new itCampus.bb.Graph.Chart.Curve();
			this.groupBoxChartPerformanceLimits = new System.Windows.Forms.GroupBox();
			this.panelChartPerformanceLimits = new System.Windows.Forms.Panel();
			this.chartPerformanceLimits = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxChartPerformanceSpeeds = new System.Windows.Forms.GroupBox();
			this.panelChartPerformanceSpeeds = new System.Windows.Forms.Panel();
			this.chartPerformanceSpeeds = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
			this.labelAgentRelaxTimeLimitMea = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeLimit = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeTotalMea = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeTotal = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeCurrentMea = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeCurrent = new System.Windows.Forms.Label();
			this.labelAgentRelaxTimeCap = new System.Windows.Forms.Label();
			this.labelLostRateLimitMea = new System.Windows.Forms.Label();
			this.labelLostRateLimit = new System.Windows.Forms.Label();
			this.labelLostRateTotalMea = new System.Windows.Forms.Label();
			this.labelLostRateTotal = new System.Windows.Forms.Label();
			this.labelLostRateCurrentMea = new System.Windows.Forms.Label();
			this.labelLostRateCurrent = new System.Windows.Forms.Label();
			this.labelLostRateCap = new System.Windows.Forms.Label();
			this.labelDropRateLimitMea = new System.Windows.Forms.Label();
			this.labelDropRateLimit = new System.Windows.Forms.Label();
			this.labelDropRateTotalMea = new System.Windows.Forms.Label();
			this.labelDropRateTotal = new System.Windows.Forms.Label();
			this.labelDropRateCurrentMea = new System.Windows.Forms.Label();
			this.labelDropRateCurrent = new System.Windows.Forms.Label();
			this.labelDropRateCap = new System.Windows.Forms.Label();
			this.labelPreLevelCurrent = new System.Windows.Forms.Label();
			this.labelPreLevelCap = new System.Windows.Forms.Label();
			this.labelDialRateLimit = new System.Windows.Forms.Label();
			this.labelDialRateCurrent = new System.Windows.Forms.Label();
			this.labelDialRateCap = new System.Windows.Forms.Label();
			this.labelPerformanceLineGray = new System.Windows.Forms.Label();
			this.labelPerformanceLineWhite = new System.Windows.Forms.Label();
			this.labelPerformanceRowLimit = new System.Windows.Forms.Label();
			this.labelPerformanceRowTotal = new System.Windows.Forms.Label();
			this.labelPerformanceRowCurrent = new System.Windows.Forms.Label();
			this.labelPerformanceRowProperty = new System.Windows.Forms.Label();
			this.groupBoxCommon = new System.Windows.Forms.GroupBox();
			this.labelStateTime = new System.Windows.Forms.Label();
			this.labelStateTimeCap = new System.Windows.Forms.Label();
			this.labelState = new System.Windows.Forms.Label();
			this.labelStateCap = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNameCap = new System.Windows.Forms.Label();
			this.labelCode = new System.Windows.Forms.Label();
			this.labelCodeCap = new System.Windows.Forms.Label();
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.groupBoxChartPerformanceLimits.SuspendLayout();
			this.panelChartPerformanceLimits.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPerformanceLimits)).BeginInit();
			this.groupBoxChartPerformanceSpeeds.SuspendLayout();
			this.panelChartPerformanceSpeeds.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPerformanceSpeeds)).BeginInit();
			this.groupBoxPerformance.SuspendLayout();
			this.groupBoxCommon.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartPerformanceLimits
			// 
			this.groupBoxChartPerformanceLimits.AccessibleDescription = resources.GetString("groupBoxChartPerformanceLimits.AccessibleDescription");
			this.groupBoxChartPerformanceLimits.AccessibleName = resources.GetString("groupBoxChartPerformanceLimits.AccessibleName");
			this.groupBoxChartPerformanceLimits.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartPerformanceLimits.Anchor")));
			this.groupBoxChartPerformanceLimits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartPerformanceLimits.BackgroundImage")));
			this.groupBoxChartPerformanceLimits.Controls.Add(this.panelChartPerformanceLimits);
			this.groupBoxChartPerformanceLimits.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartPerformanceLimits.Dock")));
			this.groupBoxChartPerformanceLimits.Enabled = ((bool)(resources.GetObject("groupBoxChartPerformanceLimits.Enabled")));
			this.groupBoxChartPerformanceLimits.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartPerformanceLimits.Font")));
			this.groupBoxChartPerformanceLimits.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartPerformanceLimits.ImeMode")));
			this.groupBoxChartPerformanceLimits.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartPerformanceLimits.Location")));
			this.groupBoxChartPerformanceLimits.Name = "groupBoxChartPerformanceLimits";
			this.groupBoxChartPerformanceLimits.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartPerformanceLimits.RightToLeft")));
			this.groupBoxChartPerformanceLimits.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartPerformanceLimits.Size")));
			this.groupBoxChartPerformanceLimits.TabIndex = ((int)(resources.GetObject("groupBoxChartPerformanceLimits.TabIndex")));
			this.groupBoxChartPerformanceLimits.TabStop = false;
			this.groupBoxChartPerformanceLimits.Text = resources.GetString("groupBoxChartPerformanceLimits.Text");
			this.groupBoxChartPerformanceLimits.Visible = ((bool)(resources.GetObject("groupBoxChartPerformanceLimits.Visible")));
			// 
			// panelChartPerformanceLimits
			// 
			this.panelChartPerformanceLimits.AccessibleDescription = resources.GetString("panelChartPerformanceLimits.AccessibleDescription");
			this.panelChartPerformanceLimits.AccessibleName = resources.GetString("panelChartPerformanceLimits.AccessibleName");
			this.panelChartPerformanceLimits.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartPerformanceLimits.Anchor")));
			this.panelChartPerformanceLimits.AutoScroll = ((bool)(resources.GetObject("panelChartPerformanceLimits.AutoScroll")));
			this.panelChartPerformanceLimits.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceLimits.AutoScrollMargin")));
			this.panelChartPerformanceLimits.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceLimits.AutoScrollMinSize")));
			this.panelChartPerformanceLimits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartPerformanceLimits.BackgroundImage")));
			this.panelChartPerformanceLimits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartPerformanceLimits.Controls.Add(this.chartPerformanceLimits);
			this.panelChartPerformanceLimits.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartPerformanceLimits.Dock")));
			this.panelChartPerformanceLimits.Enabled = ((bool)(resources.GetObject("panelChartPerformanceLimits.Enabled")));
			this.panelChartPerformanceLimits.Font = ((System.Drawing.Font)(resources.GetObject("panelChartPerformanceLimits.Font")));
			this.panelChartPerformanceLimits.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartPerformanceLimits.ImeMode")));
			this.panelChartPerformanceLimits.Location = ((System.Drawing.Point)(resources.GetObject("panelChartPerformanceLimits.Location")));
			this.panelChartPerformanceLimits.Name = "panelChartPerformanceLimits";
			this.panelChartPerformanceLimits.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartPerformanceLimits.RightToLeft")));
			this.panelChartPerformanceLimits.Size = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceLimits.Size")));
			this.panelChartPerformanceLimits.TabIndex = ((int)(resources.GetObject("panelChartPerformanceLimits.TabIndex")));
			this.panelChartPerformanceLimits.Text = resources.GetString("panelChartPerformanceLimits.Text");
			this.panelChartPerformanceLimits.Visible = ((bool)(resources.GetObject("panelChartPerformanceLimits.Visible")));
			// 
			// chartPerformanceLimits
			// 
			this.chartPerformanceLimits.AccessibleDescription = resources.GetString("chartPerformanceLimits.AccessibleDescription");
			this.chartPerformanceLimits.AccessibleName = resources.GetString("chartPerformanceLimits.AccessibleName");
			this.chartPerformanceLimits.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartPerformanceLimits.Anchor")));
			this.chartPerformanceLimits.AutoScroll = ((bool)(resources.GetObject("chartPerformanceLimits.AutoScroll")));
			this.chartPerformanceLimits.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartPerformanceLimits.AutoScrollMargin")));
			this.chartPerformanceLimits.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartPerformanceLimits.AutoScrollMinSize")));
			this.chartPerformanceLimits.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.BackgroundColor")));
			this.chartPerformanceLimits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartPerformanceLimits.BackgroundImage")));
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
			this.chartPerformanceLimits.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																								curve1,
																								curve2,
																								curve3,
																								curve4,
																								curve5,
																								curve6});
			this.chartPerformanceLimits.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartPerformanceLimits.DisplayedInterval")));
			this.chartPerformanceLimits.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartPerformanceLimits.Dock")));
			this.chartPerformanceLimits.Enabled = ((bool)(resources.GetObject("chartPerformanceLimits.Enabled")));
			this.chartPerformanceLimits.Font = ((System.Drawing.Font)(resources.GetObject("chartPerformanceLimits.Font")));
			this.chartPerformanceLimits.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.FrameColor")));
			this.chartPerformanceLimits.GridColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.GridColor")));
			this.chartPerformanceLimits.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartPerformanceLimits.ImeMode")));
			this.chartPerformanceLimits.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartPerformanceLimits.LegendAlignment")));
			this.chartPerformanceLimits.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.LegendColor")));
			this.chartPerformanceLimits.Location = ((System.Drawing.Point)(resources.GetObject("chartPerformanceLimits.Location")));
			this.chartPerformanceLimits.Name = "chartPerformanceLimits";
			this.chartPerformanceLimits.Painting = ((bool)(resources.GetObject("chartPerformanceLimits.Painting")));
			this.chartPerformanceLimits.RescaleRatio = ((System.Double)(resources.GetObject("chartPerformanceLimits.RescaleRatio")));
			this.chartPerformanceLimits.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartPerformanceLimits.RightToLeft")));
			this.chartPerformanceLimits.Size = ((System.Drawing.Size)(resources.GetObject("chartPerformanceLimits.Size")));
			this.chartPerformanceLimits.TabIndex = ((int)(resources.GetObject("chartPerformanceLimits.TabIndex")));
			this.chartPerformanceLimits.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.ValueColor")));
			this.chartPerformanceLimits.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartPerformanceLimits.ValueType")));
			this.chartPerformanceLimits.Visible = ((bool)(resources.GetObject("chartPerformanceLimits.Visible")));
			this.chartPerformanceLimits.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.XLabelColor")));
			this.chartPerformanceLimits.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceLimits.YLabelColor")));
			this.chartPerformanceLimits.YMax = ((System.Double)(resources.GetObject("chartPerformanceLimits.YMax")));
			this.chartPerformanceLimits.YMaxScaling = ((bool)(resources.GetObject("chartPerformanceLimits.YMaxScaling")));
			this.chartPerformanceLimits.YMin = ((System.Double)(resources.GetObject("chartPerformanceLimits.YMin")));
			this.chartPerformanceLimits.YMinScaling = ((bool)(resources.GetObject("chartPerformanceLimits.YMinScaling")));
			// 
			// groupBoxChartPerformanceSpeeds
			// 
			this.groupBoxChartPerformanceSpeeds.AccessibleDescription = resources.GetString("groupBoxChartPerformanceSpeeds.AccessibleDescription");
			this.groupBoxChartPerformanceSpeeds.AccessibleName = resources.GetString("groupBoxChartPerformanceSpeeds.AccessibleName");
			this.groupBoxChartPerformanceSpeeds.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartPerformanceSpeeds.Anchor")));
			this.groupBoxChartPerformanceSpeeds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartPerformanceSpeeds.BackgroundImage")));
			this.groupBoxChartPerformanceSpeeds.Controls.Add(this.panelChartPerformanceSpeeds);
			this.groupBoxChartPerformanceSpeeds.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartPerformanceSpeeds.Dock")));
			this.groupBoxChartPerformanceSpeeds.Enabled = ((bool)(resources.GetObject("groupBoxChartPerformanceSpeeds.Enabled")));
			this.groupBoxChartPerformanceSpeeds.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartPerformanceSpeeds.Font")));
			this.groupBoxChartPerformanceSpeeds.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartPerformanceSpeeds.ImeMode")));
			this.groupBoxChartPerformanceSpeeds.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartPerformanceSpeeds.Location")));
			this.groupBoxChartPerformanceSpeeds.Name = "groupBoxChartPerformanceSpeeds";
			this.groupBoxChartPerformanceSpeeds.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartPerformanceSpeeds.RightToLeft")));
			this.groupBoxChartPerformanceSpeeds.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartPerformanceSpeeds.Size")));
			this.groupBoxChartPerformanceSpeeds.TabIndex = ((int)(resources.GetObject("groupBoxChartPerformanceSpeeds.TabIndex")));
			this.groupBoxChartPerformanceSpeeds.TabStop = false;
			this.groupBoxChartPerformanceSpeeds.Text = resources.GetString("groupBoxChartPerformanceSpeeds.Text");
			this.groupBoxChartPerformanceSpeeds.Visible = ((bool)(resources.GetObject("groupBoxChartPerformanceSpeeds.Visible")));
			// 
			// panelChartPerformanceSpeeds
			// 
			this.panelChartPerformanceSpeeds.AccessibleDescription = resources.GetString("panelChartPerformanceSpeeds.AccessibleDescription");
			this.panelChartPerformanceSpeeds.AccessibleName = resources.GetString("panelChartPerformanceSpeeds.AccessibleName");
			this.panelChartPerformanceSpeeds.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartPerformanceSpeeds.Anchor")));
			this.panelChartPerformanceSpeeds.AutoScroll = ((bool)(resources.GetObject("panelChartPerformanceSpeeds.AutoScroll")));
			this.panelChartPerformanceSpeeds.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceSpeeds.AutoScrollMargin")));
			this.panelChartPerformanceSpeeds.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceSpeeds.AutoScrollMinSize")));
			this.panelChartPerformanceSpeeds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartPerformanceSpeeds.BackgroundImage")));
			this.panelChartPerformanceSpeeds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartPerformanceSpeeds.Controls.Add(this.chartPerformanceSpeeds);
			this.panelChartPerformanceSpeeds.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartPerformanceSpeeds.Dock")));
			this.panelChartPerformanceSpeeds.Enabled = ((bool)(resources.GetObject("panelChartPerformanceSpeeds.Enabled")));
			this.panelChartPerformanceSpeeds.Font = ((System.Drawing.Font)(resources.GetObject("panelChartPerformanceSpeeds.Font")));
			this.panelChartPerformanceSpeeds.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartPerformanceSpeeds.ImeMode")));
			this.panelChartPerformanceSpeeds.Location = ((System.Drawing.Point)(resources.GetObject("panelChartPerformanceSpeeds.Location")));
			this.panelChartPerformanceSpeeds.Name = "panelChartPerformanceSpeeds";
			this.panelChartPerformanceSpeeds.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartPerformanceSpeeds.RightToLeft")));
			this.panelChartPerformanceSpeeds.Size = ((System.Drawing.Size)(resources.GetObject("panelChartPerformanceSpeeds.Size")));
			this.panelChartPerformanceSpeeds.TabIndex = ((int)(resources.GetObject("panelChartPerformanceSpeeds.TabIndex")));
			this.panelChartPerformanceSpeeds.Text = resources.GetString("panelChartPerformanceSpeeds.Text");
			this.panelChartPerformanceSpeeds.Visible = ((bool)(resources.GetObject("panelChartPerformanceSpeeds.Visible")));
			// 
			// chartPerformanceSpeeds
			// 
			this.chartPerformanceSpeeds.AccessibleDescription = resources.GetString("chartPerformanceSpeeds.AccessibleDescription");
			this.chartPerformanceSpeeds.AccessibleName = resources.GetString("chartPerformanceSpeeds.AccessibleName");
			this.chartPerformanceSpeeds.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartPerformanceSpeeds.Anchor")));
			this.chartPerformanceSpeeds.AutoScroll = ((bool)(resources.GetObject("chartPerformanceSpeeds.AutoScroll")));
			this.chartPerformanceSpeeds.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartPerformanceSpeeds.AutoScrollMargin")));
			this.chartPerformanceSpeeds.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartPerformanceSpeeds.AutoScrollMinSize")));
			this.chartPerformanceSpeeds.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.BackgroundColor")));
			this.chartPerformanceSpeeds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartPerformanceSpeeds.BackgroundImage")));
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
			this.chartPerformanceSpeeds.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																								curve7,
																								curve8});
			this.chartPerformanceSpeeds.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartPerformanceSpeeds.DisplayedInterval")));
			this.chartPerformanceSpeeds.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartPerformanceSpeeds.Dock")));
			this.chartPerformanceSpeeds.Enabled = ((bool)(resources.GetObject("chartPerformanceSpeeds.Enabled")));
			this.chartPerformanceSpeeds.Font = ((System.Drawing.Font)(resources.GetObject("chartPerformanceSpeeds.Font")));
			this.chartPerformanceSpeeds.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.FrameColor")));
			this.chartPerformanceSpeeds.GridColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.GridColor")));
			this.chartPerformanceSpeeds.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartPerformanceSpeeds.ImeMode")));
			this.chartPerformanceSpeeds.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartPerformanceSpeeds.LegendAlignment")));
			this.chartPerformanceSpeeds.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.LegendColor")));
			this.chartPerformanceSpeeds.Location = ((System.Drawing.Point)(resources.GetObject("chartPerformanceSpeeds.Location")));
			this.chartPerformanceSpeeds.Name = "chartPerformanceSpeeds";
			this.chartPerformanceSpeeds.Painting = ((bool)(resources.GetObject("chartPerformanceSpeeds.Painting")));
			this.chartPerformanceSpeeds.RescaleRatio = ((System.Double)(resources.GetObject("chartPerformanceSpeeds.RescaleRatio")));
			this.chartPerformanceSpeeds.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartPerformanceSpeeds.RightToLeft")));
			this.chartPerformanceSpeeds.Size = ((System.Drawing.Size)(resources.GetObject("chartPerformanceSpeeds.Size")));
			this.chartPerformanceSpeeds.TabIndex = ((int)(resources.GetObject("chartPerformanceSpeeds.TabIndex")));
			this.chartPerformanceSpeeds.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.ValueColor")));
			this.chartPerformanceSpeeds.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartPerformanceSpeeds.ValueType")));
			this.chartPerformanceSpeeds.Visible = ((bool)(resources.GetObject("chartPerformanceSpeeds.Visible")));
			this.chartPerformanceSpeeds.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.XLabelColor")));
			this.chartPerformanceSpeeds.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartPerformanceSpeeds.YLabelColor")));
			this.chartPerformanceSpeeds.YMax = ((System.Double)(resources.GetObject("chartPerformanceSpeeds.YMax")));
			this.chartPerformanceSpeeds.YMaxScaling = ((bool)(resources.GetObject("chartPerformanceSpeeds.YMaxScaling")));
			this.chartPerformanceSpeeds.YMin = ((System.Double)(resources.GetObject("chartPerformanceSpeeds.YMin")));
			this.chartPerformanceSpeeds.YMinScaling = ((bool)(resources.GetObject("chartPerformanceSpeeds.YMinScaling")));
			// 
			// groupBoxPerformance
			// 
			this.groupBoxPerformance.AccessibleDescription = resources.GetString("groupBoxPerformance.AccessibleDescription");
			this.groupBoxPerformance.AccessibleName = resources.GetString("groupBoxPerformance.AccessibleName");
			this.groupBoxPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxPerformance.Anchor")));
			this.groupBoxPerformance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPerformance.BackgroundImage")));
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeLimitMea);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeLimit);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeTotalMea);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeTotal);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeCurrentMea);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelAgentRelaxTimeCap);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateLimitMea);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateLimit);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateTotalMea);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateTotal);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateCurrentMea);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelLostRateCap);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateLimitMea);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateLimit);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateTotalMea);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateTotal);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateCurrentMea);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelDropRateCap);
			this.groupBoxPerformance.Controls.Add(this.labelPreLevelCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelPreLevelCap);
			this.groupBoxPerformance.Controls.Add(this.labelDialRateLimit);
			this.groupBoxPerformance.Controls.Add(this.labelDialRateCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelDialRateCap);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceLineGray);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceLineWhite);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceRowLimit);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceRowTotal);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceRowCurrent);
			this.groupBoxPerformance.Controls.Add(this.labelPerformanceRowProperty);
			this.groupBoxPerformance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxPerformance.Dock")));
			this.groupBoxPerformance.Enabled = ((bool)(resources.GetObject("groupBoxPerformance.Enabled")));
			this.groupBoxPerformance.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxPerformance.Font")));
			this.groupBoxPerformance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxPerformance.ImeMode")));
			this.groupBoxPerformance.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxPerformance.Location")));
			this.groupBoxPerformance.Name = "groupBoxPerformance";
			this.groupBoxPerformance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxPerformance.RightToLeft")));
			this.groupBoxPerformance.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxPerformance.Size")));
			this.groupBoxPerformance.TabIndex = ((int)(resources.GetObject("groupBoxPerformance.TabIndex")));
			this.groupBoxPerformance.TabStop = false;
			this.groupBoxPerformance.Text = resources.GetString("groupBoxPerformance.Text");
			this.groupBoxPerformance.Visible = ((bool)(resources.GetObject("groupBoxPerformance.Visible")));
			// 
			// labelAgentRelaxTimeLimitMea
			// 
			this.labelAgentRelaxTimeLimitMea.AccessibleDescription = resources.GetString("labelAgentRelaxTimeLimitMea.AccessibleDescription");
			this.labelAgentRelaxTimeLimitMea.AccessibleName = resources.GetString("labelAgentRelaxTimeLimitMea.AccessibleName");
			this.labelAgentRelaxTimeLimitMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeLimitMea.Anchor")));
			this.labelAgentRelaxTimeLimitMea.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeLimitMea.AutoSize")));
			this.labelAgentRelaxTimeLimitMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeLimitMea.Dock")));
			this.labelAgentRelaxTimeLimitMea.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeLimitMea.Enabled")));
			this.labelAgentRelaxTimeLimitMea.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeLimitMea.Font")));
			this.labelAgentRelaxTimeLimitMea.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeLimitMea.Image")));
			this.labelAgentRelaxTimeLimitMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeLimitMea.ImageAlign")));
			this.labelAgentRelaxTimeLimitMea.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeLimitMea.ImageIndex")));
			this.labelAgentRelaxTimeLimitMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeLimitMea.ImeMode")));
			this.labelAgentRelaxTimeLimitMea.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeLimitMea.Location")));
			this.labelAgentRelaxTimeLimitMea.Name = "labelAgentRelaxTimeLimitMea";
			this.labelAgentRelaxTimeLimitMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeLimitMea.RightToLeft")));
			this.labelAgentRelaxTimeLimitMea.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeLimitMea.Size")));
			this.labelAgentRelaxTimeLimitMea.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeLimitMea.TabIndex")));
			this.labelAgentRelaxTimeLimitMea.Text = resources.GetString("labelAgentRelaxTimeLimitMea.Text");
			this.labelAgentRelaxTimeLimitMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeLimitMea.TextAlign")));
			this.labelAgentRelaxTimeLimitMea.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeLimitMea.Visible")));
			// 
			// labelAgentRelaxTimeLimit
			// 
			this.labelAgentRelaxTimeLimit.AccessibleDescription = resources.GetString("labelAgentRelaxTimeLimit.AccessibleDescription");
			this.labelAgentRelaxTimeLimit.AccessibleName = resources.GetString("labelAgentRelaxTimeLimit.AccessibleName");
			this.labelAgentRelaxTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeLimit.Anchor")));
			this.labelAgentRelaxTimeLimit.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeLimit.AutoSize")));
			this.labelAgentRelaxTimeLimit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeLimit.Dock")));
			this.labelAgentRelaxTimeLimit.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeLimit.Enabled")));
			this.labelAgentRelaxTimeLimit.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeLimit.Font")));
			this.labelAgentRelaxTimeLimit.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeLimit.Image")));
			this.labelAgentRelaxTimeLimit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeLimit.ImageAlign")));
			this.labelAgentRelaxTimeLimit.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeLimit.ImageIndex")));
			this.labelAgentRelaxTimeLimit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeLimit.ImeMode")));
			this.labelAgentRelaxTimeLimit.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeLimit.Location")));
			this.labelAgentRelaxTimeLimit.Name = "labelAgentRelaxTimeLimit";
			this.labelAgentRelaxTimeLimit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeLimit.RightToLeft")));
			this.labelAgentRelaxTimeLimit.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeLimit.Size")));
			this.labelAgentRelaxTimeLimit.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeLimit.TabIndex")));
			this.labelAgentRelaxTimeLimit.Text = resources.GetString("labelAgentRelaxTimeLimit.Text");
			this.labelAgentRelaxTimeLimit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeLimit.TextAlign")));
			this.labelAgentRelaxTimeLimit.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeLimit.Visible")));
			// 
			// labelAgentRelaxTimeTotalMea
			// 
			this.labelAgentRelaxTimeTotalMea.AccessibleDescription = resources.GetString("labelAgentRelaxTimeTotalMea.AccessibleDescription");
			this.labelAgentRelaxTimeTotalMea.AccessibleName = resources.GetString("labelAgentRelaxTimeTotalMea.AccessibleName");
			this.labelAgentRelaxTimeTotalMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeTotalMea.Anchor")));
			this.labelAgentRelaxTimeTotalMea.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeTotalMea.AutoSize")));
			this.labelAgentRelaxTimeTotalMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeTotalMea.Dock")));
			this.labelAgentRelaxTimeTotalMea.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeTotalMea.Enabled")));
			this.labelAgentRelaxTimeTotalMea.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeTotalMea.Font")));
			this.labelAgentRelaxTimeTotalMea.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeTotalMea.Image")));
			this.labelAgentRelaxTimeTotalMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeTotalMea.ImageAlign")));
			this.labelAgentRelaxTimeTotalMea.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeTotalMea.ImageIndex")));
			this.labelAgentRelaxTimeTotalMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeTotalMea.ImeMode")));
			this.labelAgentRelaxTimeTotalMea.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeTotalMea.Location")));
			this.labelAgentRelaxTimeTotalMea.Name = "labelAgentRelaxTimeTotalMea";
			this.labelAgentRelaxTimeTotalMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeTotalMea.RightToLeft")));
			this.labelAgentRelaxTimeTotalMea.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeTotalMea.Size")));
			this.labelAgentRelaxTimeTotalMea.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeTotalMea.TabIndex")));
			this.labelAgentRelaxTimeTotalMea.Text = resources.GetString("labelAgentRelaxTimeTotalMea.Text");
			this.labelAgentRelaxTimeTotalMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeTotalMea.TextAlign")));
			this.labelAgentRelaxTimeTotalMea.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeTotalMea.Visible")));
			// 
			// labelAgentRelaxTimeTotal
			// 
			this.labelAgentRelaxTimeTotal.AccessibleDescription = resources.GetString("labelAgentRelaxTimeTotal.AccessibleDescription");
			this.labelAgentRelaxTimeTotal.AccessibleName = resources.GetString("labelAgentRelaxTimeTotal.AccessibleName");
			this.labelAgentRelaxTimeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeTotal.Anchor")));
			this.labelAgentRelaxTimeTotal.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeTotal.AutoSize")));
			this.labelAgentRelaxTimeTotal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeTotal.Dock")));
			this.labelAgentRelaxTimeTotal.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeTotal.Enabled")));
			this.labelAgentRelaxTimeTotal.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeTotal.Font")));
			this.labelAgentRelaxTimeTotal.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeTotal.Image")));
			this.labelAgentRelaxTimeTotal.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeTotal.ImageAlign")));
			this.labelAgentRelaxTimeTotal.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeTotal.ImageIndex")));
			this.labelAgentRelaxTimeTotal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeTotal.ImeMode")));
			this.labelAgentRelaxTimeTotal.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeTotal.Location")));
			this.labelAgentRelaxTimeTotal.Name = "labelAgentRelaxTimeTotal";
			this.labelAgentRelaxTimeTotal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeTotal.RightToLeft")));
			this.labelAgentRelaxTimeTotal.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeTotal.Size")));
			this.labelAgentRelaxTimeTotal.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeTotal.TabIndex")));
			this.labelAgentRelaxTimeTotal.Text = resources.GetString("labelAgentRelaxTimeTotal.Text");
			this.labelAgentRelaxTimeTotal.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeTotal.TextAlign")));
			this.labelAgentRelaxTimeTotal.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeTotal.Visible")));
			// 
			// labelAgentRelaxTimeCurrentMea
			// 
			this.labelAgentRelaxTimeCurrentMea.AccessibleDescription = resources.GetString("labelAgentRelaxTimeCurrentMea.AccessibleDescription");
			this.labelAgentRelaxTimeCurrentMea.AccessibleName = resources.GetString("labelAgentRelaxTimeCurrentMea.AccessibleName");
			this.labelAgentRelaxTimeCurrentMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Anchor")));
			this.labelAgentRelaxTimeCurrentMea.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrentMea.AutoSize")));
			this.labelAgentRelaxTimeCurrentMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Dock")));
			this.labelAgentRelaxTimeCurrentMea.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Enabled")));
			this.labelAgentRelaxTimeCurrentMea.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Font")));
			this.labelAgentRelaxTimeCurrentMea.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Image")));
			this.labelAgentRelaxTimeCurrentMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCurrentMea.ImageAlign")));
			this.labelAgentRelaxTimeCurrentMea.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCurrentMea.ImageIndex")));
			this.labelAgentRelaxTimeCurrentMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeCurrentMea.ImeMode")));
			this.labelAgentRelaxTimeCurrentMea.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Location")));
			this.labelAgentRelaxTimeCurrentMea.Name = "labelAgentRelaxTimeCurrentMea";
			this.labelAgentRelaxTimeCurrentMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeCurrentMea.RightToLeft")));
			this.labelAgentRelaxTimeCurrentMea.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Size")));
			this.labelAgentRelaxTimeCurrentMea.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCurrentMea.TabIndex")));
			this.labelAgentRelaxTimeCurrentMea.Text = resources.GetString("labelAgentRelaxTimeCurrentMea.Text");
			this.labelAgentRelaxTimeCurrentMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCurrentMea.TextAlign")));
			this.labelAgentRelaxTimeCurrentMea.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrentMea.Visible")));
			// 
			// labelAgentRelaxTimeCurrent
			// 
			this.labelAgentRelaxTimeCurrent.AccessibleDescription = resources.GetString("labelAgentRelaxTimeCurrent.AccessibleDescription");
			this.labelAgentRelaxTimeCurrent.AccessibleName = resources.GetString("labelAgentRelaxTimeCurrent.AccessibleName");
			this.labelAgentRelaxTimeCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeCurrent.Anchor")));
			this.labelAgentRelaxTimeCurrent.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrent.AutoSize")));
			this.labelAgentRelaxTimeCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeCurrent.Dock")));
			this.labelAgentRelaxTimeCurrent.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrent.Enabled")));
			this.labelAgentRelaxTimeCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeCurrent.Font")));
			this.labelAgentRelaxTimeCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeCurrent.Image")));
			this.labelAgentRelaxTimeCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCurrent.ImageAlign")));
			this.labelAgentRelaxTimeCurrent.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCurrent.ImageIndex")));
			this.labelAgentRelaxTimeCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeCurrent.ImeMode")));
			this.labelAgentRelaxTimeCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeCurrent.Location")));
			this.labelAgentRelaxTimeCurrent.Name = "labelAgentRelaxTimeCurrent";
			this.labelAgentRelaxTimeCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeCurrent.RightToLeft")));
			this.labelAgentRelaxTimeCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeCurrent.Size")));
			this.labelAgentRelaxTimeCurrent.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCurrent.TabIndex")));
			this.labelAgentRelaxTimeCurrent.Text = resources.GetString("labelAgentRelaxTimeCurrent.Text");
			this.labelAgentRelaxTimeCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCurrent.TextAlign")));
			this.labelAgentRelaxTimeCurrent.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeCurrent.Visible")));
			// 
			// labelAgentRelaxTimeCap
			// 
			this.labelAgentRelaxTimeCap.AccessibleDescription = resources.GetString("labelAgentRelaxTimeCap.AccessibleDescription");
			this.labelAgentRelaxTimeCap.AccessibleName = resources.GetString("labelAgentRelaxTimeCap.AccessibleName");
			this.labelAgentRelaxTimeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTimeCap.Anchor")));
			this.labelAgentRelaxTimeCap.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTimeCap.AutoSize")));
			this.labelAgentRelaxTimeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTimeCap.Dock")));
			this.labelAgentRelaxTimeCap.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTimeCap.Enabled")));
			this.labelAgentRelaxTimeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTimeCap.Font")));
			this.labelAgentRelaxTimeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTimeCap.Image")));
			this.labelAgentRelaxTimeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCap.ImageAlign")));
			this.labelAgentRelaxTimeCap.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCap.ImageIndex")));
			this.labelAgentRelaxTimeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTimeCap.ImeMode")));
			this.labelAgentRelaxTimeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTimeCap.Location")));
			this.labelAgentRelaxTimeCap.Name = "labelAgentRelaxTimeCap";
			this.labelAgentRelaxTimeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTimeCap.RightToLeft")));
			this.labelAgentRelaxTimeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTimeCap.Size")));
			this.labelAgentRelaxTimeCap.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTimeCap.TabIndex")));
			this.labelAgentRelaxTimeCap.Text = resources.GetString("labelAgentRelaxTimeCap.Text");
			this.labelAgentRelaxTimeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTimeCap.TextAlign")));
			this.labelAgentRelaxTimeCap.Visible = ((bool)(resources.GetObject("labelAgentRelaxTimeCap.Visible")));
			// 
			// labelLostRateLimitMea
			// 
			this.labelLostRateLimitMea.AccessibleDescription = resources.GetString("labelLostRateLimitMea.AccessibleDescription");
			this.labelLostRateLimitMea.AccessibleName = resources.GetString("labelLostRateLimitMea.AccessibleName");
			this.labelLostRateLimitMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateLimitMea.Anchor")));
			this.labelLostRateLimitMea.AutoSize = ((bool)(resources.GetObject("labelLostRateLimitMea.AutoSize")));
			this.labelLostRateLimitMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateLimitMea.Dock")));
			this.labelLostRateLimitMea.Enabled = ((bool)(resources.GetObject("labelLostRateLimitMea.Enabled")));
			this.labelLostRateLimitMea.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateLimitMea.Font")));
			this.labelLostRateLimitMea.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateLimitMea.Image")));
			this.labelLostRateLimitMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateLimitMea.ImageAlign")));
			this.labelLostRateLimitMea.ImageIndex = ((int)(resources.GetObject("labelLostRateLimitMea.ImageIndex")));
			this.labelLostRateLimitMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateLimitMea.ImeMode")));
			this.labelLostRateLimitMea.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateLimitMea.Location")));
			this.labelLostRateLimitMea.Name = "labelLostRateLimitMea";
			this.labelLostRateLimitMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateLimitMea.RightToLeft")));
			this.labelLostRateLimitMea.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateLimitMea.Size")));
			this.labelLostRateLimitMea.TabIndex = ((int)(resources.GetObject("labelLostRateLimitMea.TabIndex")));
			this.labelLostRateLimitMea.Text = resources.GetString("labelLostRateLimitMea.Text");
			this.labelLostRateLimitMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateLimitMea.TextAlign")));
			this.labelLostRateLimitMea.Visible = ((bool)(resources.GetObject("labelLostRateLimitMea.Visible")));
			// 
			// labelLostRateLimit
			// 
			this.labelLostRateLimit.AccessibleDescription = resources.GetString("labelLostRateLimit.AccessibleDescription");
			this.labelLostRateLimit.AccessibleName = resources.GetString("labelLostRateLimit.AccessibleName");
			this.labelLostRateLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateLimit.Anchor")));
			this.labelLostRateLimit.AutoSize = ((bool)(resources.GetObject("labelLostRateLimit.AutoSize")));
			this.labelLostRateLimit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateLimit.Dock")));
			this.labelLostRateLimit.Enabled = ((bool)(resources.GetObject("labelLostRateLimit.Enabled")));
			this.labelLostRateLimit.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateLimit.Font")));
			this.labelLostRateLimit.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateLimit.Image")));
			this.labelLostRateLimit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateLimit.ImageAlign")));
			this.labelLostRateLimit.ImageIndex = ((int)(resources.GetObject("labelLostRateLimit.ImageIndex")));
			this.labelLostRateLimit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateLimit.ImeMode")));
			this.labelLostRateLimit.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateLimit.Location")));
			this.labelLostRateLimit.Name = "labelLostRateLimit";
			this.labelLostRateLimit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateLimit.RightToLeft")));
			this.labelLostRateLimit.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateLimit.Size")));
			this.labelLostRateLimit.TabIndex = ((int)(resources.GetObject("labelLostRateLimit.TabIndex")));
			this.labelLostRateLimit.Text = resources.GetString("labelLostRateLimit.Text");
			this.labelLostRateLimit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateLimit.TextAlign")));
			this.labelLostRateLimit.Visible = ((bool)(resources.GetObject("labelLostRateLimit.Visible")));
			// 
			// labelLostRateTotalMea
			// 
			this.labelLostRateTotalMea.AccessibleDescription = resources.GetString("labelLostRateTotalMea.AccessibleDescription");
			this.labelLostRateTotalMea.AccessibleName = resources.GetString("labelLostRateTotalMea.AccessibleName");
			this.labelLostRateTotalMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateTotalMea.Anchor")));
			this.labelLostRateTotalMea.AutoSize = ((bool)(resources.GetObject("labelLostRateTotalMea.AutoSize")));
			this.labelLostRateTotalMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateTotalMea.Dock")));
			this.labelLostRateTotalMea.Enabled = ((bool)(resources.GetObject("labelLostRateTotalMea.Enabled")));
			this.labelLostRateTotalMea.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateTotalMea.Font")));
			this.labelLostRateTotalMea.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateTotalMea.Image")));
			this.labelLostRateTotalMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateTotalMea.ImageAlign")));
			this.labelLostRateTotalMea.ImageIndex = ((int)(resources.GetObject("labelLostRateTotalMea.ImageIndex")));
			this.labelLostRateTotalMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateTotalMea.ImeMode")));
			this.labelLostRateTotalMea.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateTotalMea.Location")));
			this.labelLostRateTotalMea.Name = "labelLostRateTotalMea";
			this.labelLostRateTotalMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateTotalMea.RightToLeft")));
			this.labelLostRateTotalMea.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateTotalMea.Size")));
			this.labelLostRateTotalMea.TabIndex = ((int)(resources.GetObject("labelLostRateTotalMea.TabIndex")));
			this.labelLostRateTotalMea.Text = resources.GetString("labelLostRateTotalMea.Text");
			this.labelLostRateTotalMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateTotalMea.TextAlign")));
			this.labelLostRateTotalMea.Visible = ((bool)(resources.GetObject("labelLostRateTotalMea.Visible")));
			// 
			// labelLostRateTotal
			// 
			this.labelLostRateTotal.AccessibleDescription = resources.GetString("labelLostRateTotal.AccessibleDescription");
			this.labelLostRateTotal.AccessibleName = resources.GetString("labelLostRateTotal.AccessibleName");
			this.labelLostRateTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateTotal.Anchor")));
			this.labelLostRateTotal.AutoSize = ((bool)(resources.GetObject("labelLostRateTotal.AutoSize")));
			this.labelLostRateTotal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateTotal.Dock")));
			this.labelLostRateTotal.Enabled = ((bool)(resources.GetObject("labelLostRateTotal.Enabled")));
			this.labelLostRateTotal.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateTotal.Font")));
			this.labelLostRateTotal.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateTotal.Image")));
			this.labelLostRateTotal.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateTotal.ImageAlign")));
			this.labelLostRateTotal.ImageIndex = ((int)(resources.GetObject("labelLostRateTotal.ImageIndex")));
			this.labelLostRateTotal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateTotal.ImeMode")));
			this.labelLostRateTotal.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateTotal.Location")));
			this.labelLostRateTotal.Name = "labelLostRateTotal";
			this.labelLostRateTotal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateTotal.RightToLeft")));
			this.labelLostRateTotal.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateTotal.Size")));
			this.labelLostRateTotal.TabIndex = ((int)(resources.GetObject("labelLostRateTotal.TabIndex")));
			this.labelLostRateTotal.Text = resources.GetString("labelLostRateTotal.Text");
			this.labelLostRateTotal.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateTotal.TextAlign")));
			this.labelLostRateTotal.Visible = ((bool)(resources.GetObject("labelLostRateTotal.Visible")));
			// 
			// labelLostRateCurrentMea
			// 
			this.labelLostRateCurrentMea.AccessibleDescription = resources.GetString("labelLostRateCurrentMea.AccessibleDescription");
			this.labelLostRateCurrentMea.AccessibleName = resources.GetString("labelLostRateCurrentMea.AccessibleName");
			this.labelLostRateCurrentMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateCurrentMea.Anchor")));
			this.labelLostRateCurrentMea.AutoSize = ((bool)(resources.GetObject("labelLostRateCurrentMea.AutoSize")));
			this.labelLostRateCurrentMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateCurrentMea.Dock")));
			this.labelLostRateCurrentMea.Enabled = ((bool)(resources.GetObject("labelLostRateCurrentMea.Enabled")));
			this.labelLostRateCurrentMea.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateCurrentMea.Font")));
			this.labelLostRateCurrentMea.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateCurrentMea.Image")));
			this.labelLostRateCurrentMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCurrentMea.ImageAlign")));
			this.labelLostRateCurrentMea.ImageIndex = ((int)(resources.GetObject("labelLostRateCurrentMea.ImageIndex")));
			this.labelLostRateCurrentMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateCurrentMea.ImeMode")));
			this.labelLostRateCurrentMea.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateCurrentMea.Location")));
			this.labelLostRateCurrentMea.Name = "labelLostRateCurrentMea";
			this.labelLostRateCurrentMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateCurrentMea.RightToLeft")));
			this.labelLostRateCurrentMea.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateCurrentMea.Size")));
			this.labelLostRateCurrentMea.TabIndex = ((int)(resources.GetObject("labelLostRateCurrentMea.TabIndex")));
			this.labelLostRateCurrentMea.Text = resources.GetString("labelLostRateCurrentMea.Text");
			this.labelLostRateCurrentMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCurrentMea.TextAlign")));
			this.labelLostRateCurrentMea.Visible = ((bool)(resources.GetObject("labelLostRateCurrentMea.Visible")));
			// 
			// labelLostRateCurrent
			// 
			this.labelLostRateCurrent.AccessibleDescription = resources.GetString("labelLostRateCurrent.AccessibleDescription");
			this.labelLostRateCurrent.AccessibleName = resources.GetString("labelLostRateCurrent.AccessibleName");
			this.labelLostRateCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateCurrent.Anchor")));
			this.labelLostRateCurrent.AutoSize = ((bool)(resources.GetObject("labelLostRateCurrent.AutoSize")));
			this.labelLostRateCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateCurrent.Dock")));
			this.labelLostRateCurrent.Enabled = ((bool)(resources.GetObject("labelLostRateCurrent.Enabled")));
			this.labelLostRateCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateCurrent.Font")));
			this.labelLostRateCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateCurrent.Image")));
			this.labelLostRateCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCurrent.ImageAlign")));
			this.labelLostRateCurrent.ImageIndex = ((int)(resources.GetObject("labelLostRateCurrent.ImageIndex")));
			this.labelLostRateCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateCurrent.ImeMode")));
			this.labelLostRateCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateCurrent.Location")));
			this.labelLostRateCurrent.Name = "labelLostRateCurrent";
			this.labelLostRateCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateCurrent.RightToLeft")));
			this.labelLostRateCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateCurrent.Size")));
			this.labelLostRateCurrent.TabIndex = ((int)(resources.GetObject("labelLostRateCurrent.TabIndex")));
			this.labelLostRateCurrent.Text = resources.GetString("labelLostRateCurrent.Text");
			this.labelLostRateCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCurrent.TextAlign")));
			this.labelLostRateCurrent.Visible = ((bool)(resources.GetObject("labelLostRateCurrent.Visible")));
			// 
			// labelLostRateCap
			// 
			this.labelLostRateCap.AccessibleDescription = resources.GetString("labelLostRateCap.AccessibleDescription");
			this.labelLostRateCap.AccessibleName = resources.GetString("labelLostRateCap.AccessibleName");
			this.labelLostRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelLostRateCap.Anchor")));
			this.labelLostRateCap.AutoSize = ((bool)(resources.GetObject("labelLostRateCap.AutoSize")));
			this.labelLostRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelLostRateCap.Dock")));
			this.labelLostRateCap.Enabled = ((bool)(resources.GetObject("labelLostRateCap.Enabled")));
			this.labelLostRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelLostRateCap.Font")));
			this.labelLostRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelLostRateCap.Image")));
			this.labelLostRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCap.ImageAlign")));
			this.labelLostRateCap.ImageIndex = ((int)(resources.GetObject("labelLostRateCap.ImageIndex")));
			this.labelLostRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelLostRateCap.ImeMode")));
			this.labelLostRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelLostRateCap.Location")));
			this.labelLostRateCap.Name = "labelLostRateCap";
			this.labelLostRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelLostRateCap.RightToLeft")));
			this.labelLostRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelLostRateCap.Size")));
			this.labelLostRateCap.TabIndex = ((int)(resources.GetObject("labelLostRateCap.TabIndex")));
			this.labelLostRateCap.Text = resources.GetString("labelLostRateCap.Text");
			this.labelLostRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelLostRateCap.TextAlign")));
			this.labelLostRateCap.Visible = ((bool)(resources.GetObject("labelLostRateCap.Visible")));
			// 
			// labelDropRateLimitMea
			// 
			this.labelDropRateLimitMea.AccessibleDescription = resources.GetString("labelDropRateLimitMea.AccessibleDescription");
			this.labelDropRateLimitMea.AccessibleName = resources.GetString("labelDropRateLimitMea.AccessibleName");
			this.labelDropRateLimitMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateLimitMea.Anchor")));
			this.labelDropRateLimitMea.AutoSize = ((bool)(resources.GetObject("labelDropRateLimitMea.AutoSize")));
			this.labelDropRateLimitMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateLimitMea.Dock")));
			this.labelDropRateLimitMea.Enabled = ((bool)(resources.GetObject("labelDropRateLimitMea.Enabled")));
			this.labelDropRateLimitMea.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateLimitMea.Font")));
			this.labelDropRateLimitMea.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateLimitMea.Image")));
			this.labelDropRateLimitMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateLimitMea.ImageAlign")));
			this.labelDropRateLimitMea.ImageIndex = ((int)(resources.GetObject("labelDropRateLimitMea.ImageIndex")));
			this.labelDropRateLimitMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateLimitMea.ImeMode")));
			this.labelDropRateLimitMea.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateLimitMea.Location")));
			this.labelDropRateLimitMea.Name = "labelDropRateLimitMea";
			this.labelDropRateLimitMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateLimitMea.RightToLeft")));
			this.labelDropRateLimitMea.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateLimitMea.Size")));
			this.labelDropRateLimitMea.TabIndex = ((int)(resources.GetObject("labelDropRateLimitMea.TabIndex")));
			this.labelDropRateLimitMea.Text = resources.GetString("labelDropRateLimitMea.Text");
			this.labelDropRateLimitMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateLimitMea.TextAlign")));
			this.labelDropRateLimitMea.Visible = ((bool)(resources.GetObject("labelDropRateLimitMea.Visible")));
			// 
			// labelDropRateLimit
			// 
			this.labelDropRateLimit.AccessibleDescription = resources.GetString("labelDropRateLimit.AccessibleDescription");
			this.labelDropRateLimit.AccessibleName = resources.GetString("labelDropRateLimit.AccessibleName");
			this.labelDropRateLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateLimit.Anchor")));
			this.labelDropRateLimit.AutoSize = ((bool)(resources.GetObject("labelDropRateLimit.AutoSize")));
			this.labelDropRateLimit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateLimit.Dock")));
			this.labelDropRateLimit.Enabled = ((bool)(resources.GetObject("labelDropRateLimit.Enabled")));
			this.labelDropRateLimit.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateLimit.Font")));
			this.labelDropRateLimit.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateLimit.Image")));
			this.labelDropRateLimit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateLimit.ImageAlign")));
			this.labelDropRateLimit.ImageIndex = ((int)(resources.GetObject("labelDropRateLimit.ImageIndex")));
			this.labelDropRateLimit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateLimit.ImeMode")));
			this.labelDropRateLimit.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateLimit.Location")));
			this.labelDropRateLimit.Name = "labelDropRateLimit";
			this.labelDropRateLimit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateLimit.RightToLeft")));
			this.labelDropRateLimit.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateLimit.Size")));
			this.labelDropRateLimit.TabIndex = ((int)(resources.GetObject("labelDropRateLimit.TabIndex")));
			this.labelDropRateLimit.Text = resources.GetString("labelDropRateLimit.Text");
			this.labelDropRateLimit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateLimit.TextAlign")));
			this.labelDropRateLimit.Visible = ((bool)(resources.GetObject("labelDropRateLimit.Visible")));
			// 
			// labelDropRateTotalMea
			// 
			this.labelDropRateTotalMea.AccessibleDescription = resources.GetString("labelDropRateTotalMea.AccessibleDescription");
			this.labelDropRateTotalMea.AccessibleName = resources.GetString("labelDropRateTotalMea.AccessibleName");
			this.labelDropRateTotalMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateTotalMea.Anchor")));
			this.labelDropRateTotalMea.AutoSize = ((bool)(resources.GetObject("labelDropRateTotalMea.AutoSize")));
			this.labelDropRateTotalMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateTotalMea.Dock")));
			this.labelDropRateTotalMea.Enabled = ((bool)(resources.GetObject("labelDropRateTotalMea.Enabled")));
			this.labelDropRateTotalMea.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateTotalMea.Font")));
			this.labelDropRateTotalMea.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateTotalMea.Image")));
			this.labelDropRateTotalMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateTotalMea.ImageAlign")));
			this.labelDropRateTotalMea.ImageIndex = ((int)(resources.GetObject("labelDropRateTotalMea.ImageIndex")));
			this.labelDropRateTotalMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateTotalMea.ImeMode")));
			this.labelDropRateTotalMea.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateTotalMea.Location")));
			this.labelDropRateTotalMea.Name = "labelDropRateTotalMea";
			this.labelDropRateTotalMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateTotalMea.RightToLeft")));
			this.labelDropRateTotalMea.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateTotalMea.Size")));
			this.labelDropRateTotalMea.TabIndex = ((int)(resources.GetObject("labelDropRateTotalMea.TabIndex")));
			this.labelDropRateTotalMea.Text = resources.GetString("labelDropRateTotalMea.Text");
			this.labelDropRateTotalMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateTotalMea.TextAlign")));
			this.labelDropRateTotalMea.Visible = ((bool)(resources.GetObject("labelDropRateTotalMea.Visible")));
			// 
			// labelDropRateTotal
			// 
			this.labelDropRateTotal.AccessibleDescription = resources.GetString("labelDropRateTotal.AccessibleDescription");
			this.labelDropRateTotal.AccessibleName = resources.GetString("labelDropRateTotal.AccessibleName");
			this.labelDropRateTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateTotal.Anchor")));
			this.labelDropRateTotal.AutoSize = ((bool)(resources.GetObject("labelDropRateTotal.AutoSize")));
			this.labelDropRateTotal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateTotal.Dock")));
			this.labelDropRateTotal.Enabled = ((bool)(resources.GetObject("labelDropRateTotal.Enabled")));
			this.labelDropRateTotal.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateTotal.Font")));
			this.labelDropRateTotal.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateTotal.Image")));
			this.labelDropRateTotal.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateTotal.ImageAlign")));
			this.labelDropRateTotal.ImageIndex = ((int)(resources.GetObject("labelDropRateTotal.ImageIndex")));
			this.labelDropRateTotal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateTotal.ImeMode")));
			this.labelDropRateTotal.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateTotal.Location")));
			this.labelDropRateTotal.Name = "labelDropRateTotal";
			this.labelDropRateTotal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateTotal.RightToLeft")));
			this.labelDropRateTotal.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateTotal.Size")));
			this.labelDropRateTotal.TabIndex = ((int)(resources.GetObject("labelDropRateTotal.TabIndex")));
			this.labelDropRateTotal.Text = resources.GetString("labelDropRateTotal.Text");
			this.labelDropRateTotal.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateTotal.TextAlign")));
			this.labelDropRateTotal.Visible = ((bool)(resources.GetObject("labelDropRateTotal.Visible")));
			// 
			// labelDropRateCurrentMea
			// 
			this.labelDropRateCurrentMea.AccessibleDescription = resources.GetString("labelDropRateCurrentMea.AccessibleDescription");
			this.labelDropRateCurrentMea.AccessibleName = resources.GetString("labelDropRateCurrentMea.AccessibleName");
			this.labelDropRateCurrentMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateCurrentMea.Anchor")));
			this.labelDropRateCurrentMea.AutoSize = ((bool)(resources.GetObject("labelDropRateCurrentMea.AutoSize")));
			this.labelDropRateCurrentMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateCurrentMea.Dock")));
			this.labelDropRateCurrentMea.Enabled = ((bool)(resources.GetObject("labelDropRateCurrentMea.Enabled")));
			this.labelDropRateCurrentMea.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateCurrentMea.Font")));
			this.labelDropRateCurrentMea.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateCurrentMea.Image")));
			this.labelDropRateCurrentMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCurrentMea.ImageAlign")));
			this.labelDropRateCurrentMea.ImageIndex = ((int)(resources.GetObject("labelDropRateCurrentMea.ImageIndex")));
			this.labelDropRateCurrentMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateCurrentMea.ImeMode")));
			this.labelDropRateCurrentMea.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateCurrentMea.Location")));
			this.labelDropRateCurrentMea.Name = "labelDropRateCurrentMea";
			this.labelDropRateCurrentMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateCurrentMea.RightToLeft")));
			this.labelDropRateCurrentMea.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateCurrentMea.Size")));
			this.labelDropRateCurrentMea.TabIndex = ((int)(resources.GetObject("labelDropRateCurrentMea.TabIndex")));
			this.labelDropRateCurrentMea.Text = resources.GetString("labelDropRateCurrentMea.Text");
			this.labelDropRateCurrentMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCurrentMea.TextAlign")));
			this.labelDropRateCurrentMea.Visible = ((bool)(resources.GetObject("labelDropRateCurrentMea.Visible")));
			// 
			// labelDropRateCurrent
			// 
			this.labelDropRateCurrent.AccessibleDescription = resources.GetString("labelDropRateCurrent.AccessibleDescription");
			this.labelDropRateCurrent.AccessibleName = resources.GetString("labelDropRateCurrent.AccessibleName");
			this.labelDropRateCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateCurrent.Anchor")));
			this.labelDropRateCurrent.AutoSize = ((bool)(resources.GetObject("labelDropRateCurrent.AutoSize")));
			this.labelDropRateCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateCurrent.Dock")));
			this.labelDropRateCurrent.Enabled = ((bool)(resources.GetObject("labelDropRateCurrent.Enabled")));
			this.labelDropRateCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateCurrent.Font")));
			this.labelDropRateCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateCurrent.Image")));
			this.labelDropRateCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCurrent.ImageAlign")));
			this.labelDropRateCurrent.ImageIndex = ((int)(resources.GetObject("labelDropRateCurrent.ImageIndex")));
			this.labelDropRateCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateCurrent.ImeMode")));
			this.labelDropRateCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateCurrent.Location")));
			this.labelDropRateCurrent.Name = "labelDropRateCurrent";
			this.labelDropRateCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateCurrent.RightToLeft")));
			this.labelDropRateCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateCurrent.Size")));
			this.labelDropRateCurrent.TabIndex = ((int)(resources.GetObject("labelDropRateCurrent.TabIndex")));
			this.labelDropRateCurrent.Text = resources.GetString("labelDropRateCurrent.Text");
			this.labelDropRateCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCurrent.TextAlign")));
			this.labelDropRateCurrent.Visible = ((bool)(resources.GetObject("labelDropRateCurrent.Visible")));
			// 
			// labelDropRateCap
			// 
			this.labelDropRateCap.AccessibleDescription = resources.GetString("labelDropRateCap.AccessibleDescription");
			this.labelDropRateCap.AccessibleName = resources.GetString("labelDropRateCap.AccessibleName");
			this.labelDropRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDropRateCap.Anchor")));
			this.labelDropRateCap.AutoSize = ((bool)(resources.GetObject("labelDropRateCap.AutoSize")));
			this.labelDropRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDropRateCap.Dock")));
			this.labelDropRateCap.Enabled = ((bool)(resources.GetObject("labelDropRateCap.Enabled")));
			this.labelDropRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDropRateCap.Font")));
			this.labelDropRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDropRateCap.Image")));
			this.labelDropRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCap.ImageAlign")));
			this.labelDropRateCap.ImageIndex = ((int)(resources.GetObject("labelDropRateCap.ImageIndex")));
			this.labelDropRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDropRateCap.ImeMode")));
			this.labelDropRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDropRateCap.Location")));
			this.labelDropRateCap.Name = "labelDropRateCap";
			this.labelDropRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDropRateCap.RightToLeft")));
			this.labelDropRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDropRateCap.Size")));
			this.labelDropRateCap.TabIndex = ((int)(resources.GetObject("labelDropRateCap.TabIndex")));
			this.labelDropRateCap.Text = resources.GetString("labelDropRateCap.Text");
			this.labelDropRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDropRateCap.TextAlign")));
			this.labelDropRateCap.Visible = ((bool)(resources.GetObject("labelDropRateCap.Visible")));
			// 
			// labelPreLevelCurrent
			// 
			this.labelPreLevelCurrent.AccessibleDescription = resources.GetString("labelPreLevelCurrent.AccessibleDescription");
			this.labelPreLevelCurrent.AccessibleName = resources.GetString("labelPreLevelCurrent.AccessibleName");
			this.labelPreLevelCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPreLevelCurrent.Anchor")));
			this.labelPreLevelCurrent.AutoSize = ((bool)(resources.GetObject("labelPreLevelCurrent.AutoSize")));
			this.labelPreLevelCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPreLevelCurrent.Dock")));
			this.labelPreLevelCurrent.Enabled = ((bool)(resources.GetObject("labelPreLevelCurrent.Enabled")));
			this.labelPreLevelCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelPreLevelCurrent.Font")));
			this.labelPreLevelCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelPreLevelCurrent.Image")));
			this.labelPreLevelCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPreLevelCurrent.ImageAlign")));
			this.labelPreLevelCurrent.ImageIndex = ((int)(resources.GetObject("labelPreLevelCurrent.ImageIndex")));
			this.labelPreLevelCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPreLevelCurrent.ImeMode")));
			this.labelPreLevelCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelPreLevelCurrent.Location")));
			this.labelPreLevelCurrent.Name = "labelPreLevelCurrent";
			this.labelPreLevelCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPreLevelCurrent.RightToLeft")));
			this.labelPreLevelCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelPreLevelCurrent.Size")));
			this.labelPreLevelCurrent.TabIndex = ((int)(resources.GetObject("labelPreLevelCurrent.TabIndex")));
			this.labelPreLevelCurrent.Text = resources.GetString("labelPreLevelCurrent.Text");
			this.labelPreLevelCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPreLevelCurrent.TextAlign")));
			this.labelPreLevelCurrent.Visible = ((bool)(resources.GetObject("labelPreLevelCurrent.Visible")));
			// 
			// labelPreLevelCap
			// 
			this.labelPreLevelCap.AccessibleDescription = resources.GetString("labelPreLevelCap.AccessibleDescription");
			this.labelPreLevelCap.AccessibleName = resources.GetString("labelPreLevelCap.AccessibleName");
			this.labelPreLevelCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPreLevelCap.Anchor")));
			this.labelPreLevelCap.AutoSize = ((bool)(resources.GetObject("labelPreLevelCap.AutoSize")));
			this.labelPreLevelCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPreLevelCap.Dock")));
			this.labelPreLevelCap.Enabled = ((bool)(resources.GetObject("labelPreLevelCap.Enabled")));
			this.labelPreLevelCap.Font = ((System.Drawing.Font)(resources.GetObject("labelPreLevelCap.Font")));
			this.labelPreLevelCap.Image = ((System.Drawing.Image)(resources.GetObject("labelPreLevelCap.Image")));
			this.labelPreLevelCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPreLevelCap.ImageAlign")));
			this.labelPreLevelCap.ImageIndex = ((int)(resources.GetObject("labelPreLevelCap.ImageIndex")));
			this.labelPreLevelCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPreLevelCap.ImeMode")));
			this.labelPreLevelCap.Location = ((System.Drawing.Point)(resources.GetObject("labelPreLevelCap.Location")));
			this.labelPreLevelCap.Name = "labelPreLevelCap";
			this.labelPreLevelCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPreLevelCap.RightToLeft")));
			this.labelPreLevelCap.Size = ((System.Drawing.Size)(resources.GetObject("labelPreLevelCap.Size")));
			this.labelPreLevelCap.TabIndex = ((int)(resources.GetObject("labelPreLevelCap.TabIndex")));
			this.labelPreLevelCap.Text = resources.GetString("labelPreLevelCap.Text");
			this.labelPreLevelCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPreLevelCap.TextAlign")));
			this.labelPreLevelCap.Visible = ((bool)(resources.GetObject("labelPreLevelCap.Visible")));
			// 
			// labelDialRateLimit
			// 
			this.labelDialRateLimit.AccessibleDescription = resources.GetString("labelDialRateLimit.AccessibleDescription");
			this.labelDialRateLimit.AccessibleName = resources.GetString("labelDialRateLimit.AccessibleName");
			this.labelDialRateLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDialRateLimit.Anchor")));
			this.labelDialRateLimit.AutoSize = ((bool)(resources.GetObject("labelDialRateLimit.AutoSize")));
			this.labelDialRateLimit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDialRateLimit.Dock")));
			this.labelDialRateLimit.Enabled = ((bool)(resources.GetObject("labelDialRateLimit.Enabled")));
			this.labelDialRateLimit.Font = ((System.Drawing.Font)(resources.GetObject("labelDialRateLimit.Font")));
			this.labelDialRateLimit.Image = ((System.Drawing.Image)(resources.GetObject("labelDialRateLimit.Image")));
			this.labelDialRateLimit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateLimit.ImageAlign")));
			this.labelDialRateLimit.ImageIndex = ((int)(resources.GetObject("labelDialRateLimit.ImageIndex")));
			this.labelDialRateLimit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDialRateLimit.ImeMode")));
			this.labelDialRateLimit.Location = ((System.Drawing.Point)(resources.GetObject("labelDialRateLimit.Location")));
			this.labelDialRateLimit.Name = "labelDialRateLimit";
			this.labelDialRateLimit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDialRateLimit.RightToLeft")));
			this.labelDialRateLimit.Size = ((System.Drawing.Size)(resources.GetObject("labelDialRateLimit.Size")));
			this.labelDialRateLimit.TabIndex = ((int)(resources.GetObject("labelDialRateLimit.TabIndex")));
			this.labelDialRateLimit.Text = resources.GetString("labelDialRateLimit.Text");
			this.labelDialRateLimit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateLimit.TextAlign")));
			this.labelDialRateLimit.Visible = ((bool)(resources.GetObject("labelDialRateLimit.Visible")));
			// 
			// labelDialRateCurrent
			// 
			this.labelDialRateCurrent.AccessibleDescription = resources.GetString("labelDialRateCurrent.AccessibleDescription");
			this.labelDialRateCurrent.AccessibleName = resources.GetString("labelDialRateCurrent.AccessibleName");
			this.labelDialRateCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDialRateCurrent.Anchor")));
			this.labelDialRateCurrent.AutoSize = ((bool)(resources.GetObject("labelDialRateCurrent.AutoSize")));
			this.labelDialRateCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDialRateCurrent.Dock")));
			this.labelDialRateCurrent.Enabled = ((bool)(resources.GetObject("labelDialRateCurrent.Enabled")));
			this.labelDialRateCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelDialRateCurrent.Font")));
			this.labelDialRateCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelDialRateCurrent.Image")));
			this.labelDialRateCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateCurrent.ImageAlign")));
			this.labelDialRateCurrent.ImageIndex = ((int)(resources.GetObject("labelDialRateCurrent.ImageIndex")));
			this.labelDialRateCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDialRateCurrent.ImeMode")));
			this.labelDialRateCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelDialRateCurrent.Location")));
			this.labelDialRateCurrent.Name = "labelDialRateCurrent";
			this.labelDialRateCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDialRateCurrent.RightToLeft")));
			this.labelDialRateCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelDialRateCurrent.Size")));
			this.labelDialRateCurrent.TabIndex = ((int)(resources.GetObject("labelDialRateCurrent.TabIndex")));
			this.labelDialRateCurrent.Text = resources.GetString("labelDialRateCurrent.Text");
			this.labelDialRateCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateCurrent.TextAlign")));
			this.labelDialRateCurrent.Visible = ((bool)(resources.GetObject("labelDialRateCurrent.Visible")));
			// 
			// labelDialRateCap
			// 
			this.labelDialRateCap.AccessibleDescription = resources.GetString("labelDialRateCap.AccessibleDescription");
			this.labelDialRateCap.AccessibleName = resources.GetString("labelDialRateCap.AccessibleName");
			this.labelDialRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDialRateCap.Anchor")));
			this.labelDialRateCap.AutoSize = ((bool)(resources.GetObject("labelDialRateCap.AutoSize")));
			this.labelDialRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDialRateCap.Dock")));
			this.labelDialRateCap.Enabled = ((bool)(resources.GetObject("labelDialRateCap.Enabled")));
			this.labelDialRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDialRateCap.Font")));
			this.labelDialRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDialRateCap.Image")));
			this.labelDialRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateCap.ImageAlign")));
			this.labelDialRateCap.ImageIndex = ((int)(resources.GetObject("labelDialRateCap.ImageIndex")));
			this.labelDialRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDialRateCap.ImeMode")));
			this.labelDialRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDialRateCap.Location")));
			this.labelDialRateCap.Name = "labelDialRateCap";
			this.labelDialRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDialRateCap.RightToLeft")));
			this.labelDialRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDialRateCap.Size")));
			this.labelDialRateCap.TabIndex = ((int)(resources.GetObject("labelDialRateCap.TabIndex")));
			this.labelDialRateCap.Text = resources.GetString("labelDialRateCap.Text");
			this.labelDialRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialRateCap.TextAlign")));
			this.labelDialRateCap.Visible = ((bool)(resources.GetObject("labelDialRateCap.Visible")));
			// 
			// labelPerformanceLineGray
			// 
			this.labelPerformanceLineGray.AccessibleDescription = resources.GetString("labelPerformanceLineGray.AccessibleDescription");
			this.labelPerformanceLineGray.AccessibleName = resources.GetString("labelPerformanceLineGray.AccessibleName");
			this.labelPerformanceLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceLineGray.Anchor")));
			this.labelPerformanceLineGray.AutoSize = ((bool)(resources.GetObject("labelPerformanceLineGray.AutoSize")));
			this.labelPerformanceLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelPerformanceLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceLineGray.Dock")));
			this.labelPerformanceLineGray.Enabled = ((bool)(resources.GetObject("labelPerformanceLineGray.Enabled")));
			this.labelPerformanceLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceLineGray.Font")));
			this.labelPerformanceLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelPerformanceLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceLineGray.Image")));
			this.labelPerformanceLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceLineGray.ImageAlign")));
			this.labelPerformanceLineGray.ImageIndex = ((int)(resources.GetObject("labelPerformanceLineGray.ImageIndex")));
			this.labelPerformanceLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceLineGray.ImeMode")));
			this.labelPerformanceLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceLineGray.Location")));
			this.labelPerformanceLineGray.Name = "labelPerformanceLineGray";
			this.labelPerformanceLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceLineGray.RightToLeft")));
			this.labelPerformanceLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceLineGray.Size")));
			this.labelPerformanceLineGray.TabIndex = ((int)(resources.GetObject("labelPerformanceLineGray.TabIndex")));
			this.labelPerformanceLineGray.Text = resources.GetString("labelPerformanceLineGray.Text");
			this.labelPerformanceLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceLineGray.TextAlign")));
			this.labelPerformanceLineGray.Visible = ((bool)(resources.GetObject("labelPerformanceLineGray.Visible")));
			// 
			// labelPerformanceLineWhite
			// 
			this.labelPerformanceLineWhite.AccessibleDescription = resources.GetString("labelPerformanceLineWhite.AccessibleDescription");
			this.labelPerformanceLineWhite.AccessibleName = resources.GetString("labelPerformanceLineWhite.AccessibleName");
			this.labelPerformanceLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceLineWhite.Anchor")));
			this.labelPerformanceLineWhite.AutoSize = ((bool)(resources.GetObject("labelPerformanceLineWhite.AutoSize")));
			this.labelPerformanceLineWhite.BackColor = System.Drawing.Color.White;
			this.labelPerformanceLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceLineWhite.Dock")));
			this.labelPerformanceLineWhite.Enabled = ((bool)(resources.GetObject("labelPerformanceLineWhite.Enabled")));
			this.labelPerformanceLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceLineWhite.Font")));
			this.labelPerformanceLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelPerformanceLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceLineWhite.Image")));
			this.labelPerformanceLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceLineWhite.ImageAlign")));
			this.labelPerformanceLineWhite.ImageIndex = ((int)(resources.GetObject("labelPerformanceLineWhite.ImageIndex")));
			this.labelPerformanceLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceLineWhite.ImeMode")));
			this.labelPerformanceLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceLineWhite.Location")));
			this.labelPerformanceLineWhite.Name = "labelPerformanceLineWhite";
			this.labelPerformanceLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceLineWhite.RightToLeft")));
			this.labelPerformanceLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceLineWhite.Size")));
			this.labelPerformanceLineWhite.TabIndex = ((int)(resources.GetObject("labelPerformanceLineWhite.TabIndex")));
			this.labelPerformanceLineWhite.Text = resources.GetString("labelPerformanceLineWhite.Text");
			this.labelPerformanceLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceLineWhite.TextAlign")));
			this.labelPerformanceLineWhite.Visible = ((bool)(resources.GetObject("labelPerformanceLineWhite.Visible")));
			// 
			// labelPerformanceRowLimit
			// 
			this.labelPerformanceRowLimit.AccessibleDescription = resources.GetString("labelPerformanceRowLimit.AccessibleDescription");
			this.labelPerformanceRowLimit.AccessibleName = resources.GetString("labelPerformanceRowLimit.AccessibleName");
			this.labelPerformanceRowLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceRowLimit.Anchor")));
			this.labelPerformanceRowLimit.AutoSize = ((bool)(resources.GetObject("labelPerformanceRowLimit.AutoSize")));
			this.labelPerformanceRowLimit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceRowLimit.Dock")));
			this.labelPerformanceRowLimit.Enabled = ((bool)(resources.GetObject("labelPerformanceRowLimit.Enabled")));
			this.labelPerformanceRowLimit.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceRowLimit.Font")));
			this.labelPerformanceRowLimit.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceRowLimit.Image")));
			this.labelPerformanceRowLimit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowLimit.ImageAlign")));
			this.labelPerformanceRowLimit.ImageIndex = ((int)(resources.GetObject("labelPerformanceRowLimit.ImageIndex")));
			this.labelPerformanceRowLimit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceRowLimit.ImeMode")));
			this.labelPerformanceRowLimit.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceRowLimit.Location")));
			this.labelPerformanceRowLimit.Name = "labelPerformanceRowLimit";
			this.labelPerformanceRowLimit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceRowLimit.RightToLeft")));
			this.labelPerformanceRowLimit.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceRowLimit.Size")));
			this.labelPerformanceRowLimit.TabIndex = ((int)(resources.GetObject("labelPerformanceRowLimit.TabIndex")));
			this.labelPerformanceRowLimit.Text = resources.GetString("labelPerformanceRowLimit.Text");
			this.labelPerformanceRowLimit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowLimit.TextAlign")));
			this.labelPerformanceRowLimit.Visible = ((bool)(resources.GetObject("labelPerformanceRowLimit.Visible")));
			// 
			// labelPerformanceRowTotal
			// 
			this.labelPerformanceRowTotal.AccessibleDescription = resources.GetString("labelPerformanceRowTotal.AccessibleDescription");
			this.labelPerformanceRowTotal.AccessibleName = resources.GetString("labelPerformanceRowTotal.AccessibleName");
			this.labelPerformanceRowTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceRowTotal.Anchor")));
			this.labelPerformanceRowTotal.AutoSize = ((bool)(resources.GetObject("labelPerformanceRowTotal.AutoSize")));
			this.labelPerformanceRowTotal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceRowTotal.Dock")));
			this.labelPerformanceRowTotal.Enabled = ((bool)(resources.GetObject("labelPerformanceRowTotal.Enabled")));
			this.labelPerformanceRowTotal.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceRowTotal.Font")));
			this.labelPerformanceRowTotal.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceRowTotal.Image")));
			this.labelPerformanceRowTotal.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowTotal.ImageAlign")));
			this.labelPerformanceRowTotal.ImageIndex = ((int)(resources.GetObject("labelPerformanceRowTotal.ImageIndex")));
			this.labelPerformanceRowTotal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceRowTotal.ImeMode")));
			this.labelPerformanceRowTotal.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceRowTotal.Location")));
			this.labelPerformanceRowTotal.Name = "labelPerformanceRowTotal";
			this.labelPerformanceRowTotal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceRowTotal.RightToLeft")));
			this.labelPerformanceRowTotal.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceRowTotal.Size")));
			this.labelPerformanceRowTotal.TabIndex = ((int)(resources.GetObject("labelPerformanceRowTotal.TabIndex")));
			this.labelPerformanceRowTotal.Text = resources.GetString("labelPerformanceRowTotal.Text");
			this.labelPerformanceRowTotal.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowTotal.TextAlign")));
			this.labelPerformanceRowTotal.Visible = ((bool)(resources.GetObject("labelPerformanceRowTotal.Visible")));
			// 
			// labelPerformanceRowCurrent
			// 
			this.labelPerformanceRowCurrent.AccessibleDescription = resources.GetString("labelPerformanceRowCurrent.AccessibleDescription");
			this.labelPerformanceRowCurrent.AccessibleName = resources.GetString("labelPerformanceRowCurrent.AccessibleName");
			this.labelPerformanceRowCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceRowCurrent.Anchor")));
			this.labelPerformanceRowCurrent.AutoSize = ((bool)(resources.GetObject("labelPerformanceRowCurrent.AutoSize")));
			this.labelPerformanceRowCurrent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceRowCurrent.Dock")));
			this.labelPerformanceRowCurrent.Enabled = ((bool)(resources.GetObject("labelPerformanceRowCurrent.Enabled")));
			this.labelPerformanceRowCurrent.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceRowCurrent.Font")));
			this.labelPerformanceRowCurrent.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceRowCurrent.Image")));
			this.labelPerformanceRowCurrent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowCurrent.ImageAlign")));
			this.labelPerformanceRowCurrent.ImageIndex = ((int)(resources.GetObject("labelPerformanceRowCurrent.ImageIndex")));
			this.labelPerformanceRowCurrent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceRowCurrent.ImeMode")));
			this.labelPerformanceRowCurrent.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceRowCurrent.Location")));
			this.labelPerformanceRowCurrent.Name = "labelPerformanceRowCurrent";
			this.labelPerformanceRowCurrent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceRowCurrent.RightToLeft")));
			this.labelPerformanceRowCurrent.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceRowCurrent.Size")));
			this.labelPerformanceRowCurrent.TabIndex = ((int)(resources.GetObject("labelPerformanceRowCurrent.TabIndex")));
			this.labelPerformanceRowCurrent.Text = resources.GetString("labelPerformanceRowCurrent.Text");
			this.labelPerformanceRowCurrent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowCurrent.TextAlign")));
			this.labelPerformanceRowCurrent.Visible = ((bool)(resources.GetObject("labelPerformanceRowCurrent.Visible")));
			// 
			// labelPerformanceRowProperty
			// 
			this.labelPerformanceRowProperty.AccessibleDescription = resources.GetString("labelPerformanceRowProperty.AccessibleDescription");
			this.labelPerformanceRowProperty.AccessibleName = resources.GetString("labelPerformanceRowProperty.AccessibleName");
			this.labelPerformanceRowProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelPerformanceRowProperty.Anchor")));
			this.labelPerformanceRowProperty.AutoSize = ((bool)(resources.GetObject("labelPerformanceRowProperty.AutoSize")));
			this.labelPerformanceRowProperty.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelPerformanceRowProperty.Dock")));
			this.labelPerformanceRowProperty.Enabled = ((bool)(resources.GetObject("labelPerformanceRowProperty.Enabled")));
			this.labelPerformanceRowProperty.Font = ((System.Drawing.Font)(resources.GetObject("labelPerformanceRowProperty.Font")));
			this.labelPerformanceRowProperty.Image = ((System.Drawing.Image)(resources.GetObject("labelPerformanceRowProperty.Image")));
			this.labelPerformanceRowProperty.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowProperty.ImageAlign")));
			this.labelPerformanceRowProperty.ImageIndex = ((int)(resources.GetObject("labelPerformanceRowProperty.ImageIndex")));
			this.labelPerformanceRowProperty.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelPerformanceRowProperty.ImeMode")));
			this.labelPerformanceRowProperty.Location = ((System.Drawing.Point)(resources.GetObject("labelPerformanceRowProperty.Location")));
			this.labelPerformanceRowProperty.Name = "labelPerformanceRowProperty";
			this.labelPerformanceRowProperty.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelPerformanceRowProperty.RightToLeft")));
			this.labelPerformanceRowProperty.Size = ((System.Drawing.Size)(resources.GetObject("labelPerformanceRowProperty.Size")));
			this.labelPerformanceRowProperty.TabIndex = ((int)(resources.GetObject("labelPerformanceRowProperty.TabIndex")));
			this.labelPerformanceRowProperty.Text = resources.GetString("labelPerformanceRowProperty.Text");
			this.labelPerformanceRowProperty.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelPerformanceRowProperty.TextAlign")));
			this.labelPerformanceRowProperty.Visible = ((bool)(resources.GetObject("labelPerformanceRowProperty.Visible")));
			// 
			// groupBoxCommon
			// 
			this.groupBoxCommon.AccessibleDescription = resources.GetString("groupBoxCommon.AccessibleDescription");
			this.groupBoxCommon.AccessibleName = resources.GetString("groupBoxCommon.AccessibleName");
			this.groupBoxCommon.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxCommon.Anchor")));
			this.groupBoxCommon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxCommon.BackgroundImage")));
			this.groupBoxCommon.Controls.Add(this.labelStateTime);
			this.groupBoxCommon.Controls.Add(this.labelStateTimeCap);
			this.groupBoxCommon.Controls.Add(this.labelState);
			this.groupBoxCommon.Controls.Add(this.labelStateCap);
			this.groupBoxCommon.Controls.Add(this.labelName);
			this.groupBoxCommon.Controls.Add(this.labelNameCap);
			this.groupBoxCommon.Controls.Add(this.labelCode);
			this.groupBoxCommon.Controls.Add(this.labelCodeCap);
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
			// labelStateTime
			// 
			this.labelStateTime.AccessibleDescription = resources.GetString("labelStateTime.AccessibleDescription");
			this.labelStateTime.AccessibleName = resources.GetString("labelStateTime.AccessibleName");
			this.labelStateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelStateTime.Anchor")));
			this.labelStateTime.AutoSize = ((bool)(resources.GetObject("labelStateTime.AutoSize")));
			this.labelStateTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelStateTime.Dock")));
			this.labelStateTime.Enabled = ((bool)(resources.GetObject("labelStateTime.Enabled")));
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
			// labelState
			// 
			this.labelState.AccessibleDescription = resources.GetString("labelState.AccessibleDescription");
			this.labelState.AccessibleName = resources.GetString("labelState.AccessibleName");
			this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelState.Anchor")));
			this.labelState.AutoSize = ((bool)(resources.GetObject("labelState.AutoSize")));
			this.labelState.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelState.Dock")));
			this.labelState.Enabled = ((bool)(resources.GetObject("labelState.Enabled")));
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
			// labelName
			// 
			this.labelName.AccessibleDescription = resources.GetString("labelName.AccessibleDescription");
			this.labelName.AccessibleName = resources.GetString("labelName.AccessibleName");
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelName.Anchor")));
			this.labelName.AutoSize = ((bool)(resources.GetObject("labelName.AutoSize")));
			this.labelName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelName.Dock")));
			this.labelName.Enabled = ((bool)(resources.GetObject("labelName.Enabled")));
			this.labelName.Font = ((System.Drawing.Font)(resources.GetObject("labelName.Font")));
			this.labelName.Image = ((System.Drawing.Image)(resources.GetObject("labelName.Image")));
			this.labelName.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelName.ImageAlign")));
			this.labelName.ImageIndex = ((int)(resources.GetObject("labelName.ImageIndex")));
			this.labelName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelName.ImeMode")));
			this.labelName.Location = ((System.Drawing.Point)(resources.GetObject("labelName.Location")));
			this.labelName.Name = "labelName";
			this.labelName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelName.RightToLeft")));
			this.labelName.Size = ((System.Drawing.Size)(resources.GetObject("labelName.Size")));
			this.labelName.TabIndex = ((int)(resources.GetObject("labelName.TabIndex")));
			this.labelName.Text = resources.GetString("labelName.Text");
			this.labelName.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelName.TextAlign")));
			this.labelName.Visible = ((bool)(resources.GetObject("labelName.Visible")));
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
			// labelCode
			// 
			this.labelCode.AccessibleDescription = resources.GetString("labelCode.AccessibleDescription");
			this.labelCode.AccessibleName = resources.GetString("labelCode.AccessibleName");
			this.labelCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCode.Anchor")));
			this.labelCode.AutoSize = ((bool)(resources.GetObject("labelCode.AutoSize")));
			this.labelCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCode.Dock")));
			this.labelCode.Enabled = ((bool)(resources.GetObject("labelCode.Enabled")));
			this.labelCode.Font = ((System.Drawing.Font)(resources.GetObject("labelCode.Font")));
			this.labelCode.Image = ((System.Drawing.Image)(resources.GetObject("labelCode.Image")));
			this.labelCode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCode.ImageAlign")));
			this.labelCode.ImageIndex = ((int)(resources.GetObject("labelCode.ImageIndex")));
			this.labelCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCode.ImeMode")));
			this.labelCode.Location = ((System.Drawing.Point)(resources.GetObject("labelCode.Location")));
			this.labelCode.Name = "labelCode";
			this.labelCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCode.RightToLeft")));
			this.labelCode.Size = ((System.Drawing.Size)(resources.GetObject("labelCode.Size")));
			this.labelCode.TabIndex = ((int)(resources.GetObject("labelCode.TabIndex")));
			this.labelCode.Text = resources.GetString("labelCode.Text");
			this.labelCode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCode.TextAlign")));
			this.labelCode.Visible = ((bool)(resources.GetObject("labelCode.Visible")));
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
			// timerRefresh
			// 
			this.timerRefresh.Interval = 1000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// CampaignViewProperties
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartPerformanceLimits);
			this.Controls.Add(this.groupBoxChartPerformanceSpeeds);
			this.Controls.Add(this.groupBoxPerformance);
			this.Controls.Add(this.groupBoxCommon);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewProperties";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartPerformanceLimits.ResumeLayout(false);
			this.panelChartPerformanceLimits.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPerformanceLimits)).EndInit();
			this.groupBoxChartPerformanceSpeeds.ResumeLayout(false);
			this.panelChartPerformanceSpeeds.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPerformanceSpeeds)).EndInit();
			this.groupBoxPerformance.ResumeLayout(false);
			this.groupBoxCommon.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// allgemeine Eigenschaften aktualisieren
			labelCode.Text = campaign.Code;
			labelName.Text = campaign.Name;
			labelState.Text = campaign.State.ToString();

			// ggf. Statusdauer aktualisieren
			if (_lastStateChange != campaign.LastStateChange)
			{
				_lastStateChange = campaign.LastStateChange;
				labelStateTime.Text = GetStateTime(_lastStateChange);
			}

			// Performancekennzahlen aktualisieren
			labelDialRateCurrent.Text = campaign.DialRate.ToString();
			labelDialRateLimit.Text = campaign.MaxDialRate > 0 ?
				campaign.MaxDialRate.ToString() : "";
			labelPreLevelCurrent.Text = campaign.PreLevel.ToString();
			labelDropRateCurrent.Text = campaign.DropRateCur.ToString();
			labelDropRateTotal.Text = campaign.DropRateTtl.ToString();
			labelDropRateLimit.Text = campaign.MaxDropRate.ToString();
			labelLostRateCurrent.Text = campaign.LostRateCur.ToString();
			labelLostRateTotal.Text = campaign.LostRateTtl.ToString();
			labelLostRateLimit.Text = campaign.MaxLostRate.ToString();
			labelAgentRelaxTimeCurrent.Text = campaign.AgentRelaxTimeCur.ToString();
			labelAgentRelaxTimeTotal.Text = campaign.AgentRelaxTimeTtl.ToString();
			labelAgentRelaxTimeLimit.Text = campaign.AgentRelaxTarget.ToString();

			// Verlaufsgrafiken aktualisieren
			chartPerformanceSpeeds.DataCollection = campaign.PerformanceSpeedsData;
			chartPerformanceLimits.DataCollection = campaign.PerformanceLimitsData;
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
				Logger.Log.Error("Error on refreshing campaign view.", ex);
			}
		}

		/// <summary>
		/// gibt Zeitspanne vom übergebenen bis zum aktuellen Zeitpunkt im Format hh:mm:ss zurück
		/// </summary>
		private string GetStateTime(DateTime lastStateChanged)
		{
			TimeSpan timeSpan = DateTime.Now.AddSeconds(0.5) - lastStateChanged;
			return timeSpan.Hours.ToString("00") + ":" + timeSpan.Minutes.ToString("00") + ":" +
				timeSpan.Seconds.ToString("00");
		}

		#endregion

		#endregion
	}
}
