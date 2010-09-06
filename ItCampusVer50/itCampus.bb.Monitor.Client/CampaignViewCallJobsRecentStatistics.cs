using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Outbound Kurzzeitstatistik einer Kampagne.
	/// </summary>
	public class CampaignViewCallJobsRecentStatistics : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxRecentCallJobResults;
		private System.Windows.Forms.Label labelRecentCallJobResultsRowResult;
		private System.Windows.Forms.Label labelRecentCallJobResultsRowCount;
		private System.Windows.Forms.Label labelRecentCallJobResultsRowRate;
		private System.Windows.Forms.Label labelRecentCallJobResultsTopLineWhite;
		private System.Windows.Forms.Label labelRecentCallJobResultsTopLineGray;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBusyCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBusyAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBusyRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBusyRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoAnswerCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoAnswerAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoAnswerRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoAnswerRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountWrongNumberCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountWrongNumberAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountWrongNumberRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountWrongNumberRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBlacklistCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBlacklistAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBlacklistRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountBlacklistRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountRouteDeniedCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountRouteDeniedAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountRouteDeniedRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountRouteDeniedRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPSTNFailureCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPSTNFailureAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPSTNFailureRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPSTNFailureRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountTelcoOverloadCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountTelcoOverloadAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountTelcoOverloadRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountTelcoOverloadRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountACRCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountACRAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountACRRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountACRRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountFaxCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountFaxAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountFaxRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountFaxRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountAnsweringMachineCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountAnsweringMachineAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountAnsweringMachineRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountAnsweringMachineRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoInterestCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoInterestAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoInterestRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountNoInterestRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountLostCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountLostAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountLostRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountLostRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPutThroughCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPutThroughAbs;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPutThroughRel;
		private System.Windows.Forms.Label labelRecentCallJobResultCountPutThroughRelMea;
		private System.Windows.Forms.Label labelRecentCallJobResultsBottomLineWhite;
		private System.Windows.Forms.Label labelRecentCallJobResultsBottomLineGray;
		private System.Windows.Forms.Label labelRecentCallJobResultCountCap;
		private System.Windows.Forms.Label labelRecentCallJobResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxPieRecentCallJobResultCount;
		private itCampus.bb.Graph.Pie.Pie pieRecentCallJobResultCount;
		private System.Windows.Forms.GroupBox groupBoxChartRecentCallJobResultCountAbs;
		private System.Windows.Forms.Panel panelChartRecentCallJobResultCountAbs;
		private itCampus.bb.Graph.Chart.Chart chartRecentCallJobResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxChartRecentCallJobResultCountRel;
		private System.Windows.Forms.Panel panelChartRecentCallJobResultCountRel;
		private itCampus.bb.Graph.Chart.Chart chartRecentCallJobResultCountRel;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewCallJobsRecentStatistics()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Intervall Tortengrafik einstellen
			pieRecentCallJobResultCount.RefreshInterval = Settings.Instance.RefreshInterval * 1000;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewCallJobsRecentStatistics));
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
			itCampus.bb.Graph.Chart.Curve curve22 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve23 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve24 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve25 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve26 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Chart.Curve curve27 = new itCampus.bb.Graph.Chart.Curve();
			itCampus.bb.Graph.Pie.Slice slice1 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice2 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice3 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice4 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice5 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice6 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice7 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice8 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice9 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice10 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice11 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice12 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice13 = new itCampus.bb.Graph.Pie.Slice();
			this.groupBoxChartRecentCallJobResultCountRel = new System.Windows.Forms.GroupBox();
			this.panelChartRecentCallJobResultCountRel = new System.Windows.Forms.Panel();
			this.chartRecentCallJobResultCountRel = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxChartRecentCallJobResultCountAbs = new System.Windows.Forms.GroupBox();
			this.panelChartRecentCallJobResultCountAbs = new System.Windows.Forms.Panel();
			this.chartRecentCallJobResultCountAbs = new itCampus.bb.Graph.Chart.Chart();
			this.groupBoxPieRecentCallJobResultCount = new System.Windows.Forms.GroupBox();
			this.pieRecentCallJobResultCount = new itCampus.bb.Graph.Pie.Pie();
			this.groupBoxRecentCallJobResults = new System.Windows.Forms.GroupBox();
			this.labelRecentCallJobResultCountAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsBottomLineGray = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsBottomLineWhite = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPutThroughRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPutThroughRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPutThroughAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPutThroughCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountLostRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountLostRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountLostAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountLostCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoInterestRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoInterestRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoInterestAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoInterestCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountAnsweringMachineRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountAnsweringMachineRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountAnsweringMachineAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountAnsweringMachineCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountFaxRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountFaxRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountFaxAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountFaxCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountACRRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountACRRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountACRAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountACRCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountTelcoOverloadRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountTelcoOverloadRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountTelcoOverloadAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountTelcoOverloadCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPSTNFailureRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPSTNFailureRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPSTNFailureAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountPSTNFailureCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountRouteDeniedRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountRouteDeniedRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountRouteDeniedAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountRouteDeniedCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBlacklistRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBlacklistRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBlacklistAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBlacklistCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountWrongNumberRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountWrongNumberRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountWrongNumberAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountWrongNumberCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoAnswerRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoAnswerRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoAnswerAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountNoAnswerCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBusyRelMea = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBusyRel = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBusyAbs = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultCountBusyCap = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsTopLineGray = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsTopLineWhite = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsRowRate = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsRowCount = new System.Windows.Forms.Label();
			this.labelRecentCallJobResultsRowResult = new System.Windows.Forms.Label();
			this.groupBoxChartRecentCallJobResultCountRel.SuspendLayout();
			this.panelChartRecentCallJobResultCountRel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartRecentCallJobResultCountRel)).BeginInit();
			this.groupBoxChartRecentCallJobResultCountAbs.SuspendLayout();
			this.panelChartRecentCallJobResultCountAbs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartRecentCallJobResultCountAbs)).BeginInit();
			this.groupBoxPieRecentCallJobResultCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pieRecentCallJobResultCount)).BeginInit();
			this.groupBoxRecentCallJobResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChartRecentCallJobResultCountRel
			// 
			this.groupBoxChartRecentCallJobResultCountRel.AccessibleDescription = resources.GetString("groupBoxChartRecentCallJobResultCountRel.AccessibleDescription");
			this.groupBoxChartRecentCallJobResultCountRel.AccessibleName = resources.GetString("groupBoxChartRecentCallJobResultCountRel.AccessibleName");
			this.groupBoxChartRecentCallJobResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Anchor")));
			this.groupBoxChartRecentCallJobResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.BackgroundImage")));
			this.groupBoxChartRecentCallJobResultCountRel.Controls.Add(this.panelChartRecentCallJobResultCountRel);
			this.groupBoxChartRecentCallJobResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Dock")));
			this.groupBoxChartRecentCallJobResultCountRel.Enabled = ((bool)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Enabled")));
			this.groupBoxChartRecentCallJobResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Font")));
			this.groupBoxChartRecentCallJobResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.ImeMode")));
			this.groupBoxChartRecentCallJobResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Location")));
			this.groupBoxChartRecentCallJobResultCountRel.Name = "groupBoxChartRecentCallJobResultCountRel";
			this.groupBoxChartRecentCallJobResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.RightToLeft")));
			this.groupBoxChartRecentCallJobResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Size")));
			this.groupBoxChartRecentCallJobResultCountRel.TabIndex = ((int)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.TabIndex")));
			this.groupBoxChartRecentCallJobResultCountRel.TabStop = false;
			this.groupBoxChartRecentCallJobResultCountRel.Text = resources.GetString("groupBoxChartRecentCallJobResultCountRel.Text");
			this.groupBoxChartRecentCallJobResultCountRel.Visible = ((bool)(resources.GetObject("groupBoxChartRecentCallJobResultCountRel.Visible")));
			// 
			// panelChartRecentCallJobResultCountRel
			// 
			this.panelChartRecentCallJobResultCountRel.AccessibleDescription = resources.GetString("panelChartRecentCallJobResultCountRel.AccessibleDescription");
			this.panelChartRecentCallJobResultCountRel.AccessibleName = resources.GetString("panelChartRecentCallJobResultCountRel.AccessibleName");
			this.panelChartRecentCallJobResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartRecentCallJobResultCountRel.Anchor")));
			this.panelChartRecentCallJobResultCountRel.AutoScroll = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountRel.AutoScroll")));
			this.panelChartRecentCallJobResultCountRel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountRel.AutoScrollMargin")));
			this.panelChartRecentCallJobResultCountRel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountRel.AutoScrollMinSize")));
			this.panelChartRecentCallJobResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartRecentCallJobResultCountRel.BackgroundImage")));
			this.panelChartRecentCallJobResultCountRel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartRecentCallJobResultCountRel.Controls.Add(this.chartRecentCallJobResultCountRel);
			this.panelChartRecentCallJobResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartRecentCallJobResultCountRel.Dock")));
			this.panelChartRecentCallJobResultCountRel.Enabled = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountRel.Enabled")));
			this.panelChartRecentCallJobResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("panelChartRecentCallJobResultCountRel.Font")));
			this.panelChartRecentCallJobResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartRecentCallJobResultCountRel.ImeMode")));
			this.panelChartRecentCallJobResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("panelChartRecentCallJobResultCountRel.Location")));
			this.panelChartRecentCallJobResultCountRel.Name = "panelChartRecentCallJobResultCountRel";
			this.panelChartRecentCallJobResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartRecentCallJobResultCountRel.RightToLeft")));
			this.panelChartRecentCallJobResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountRel.Size")));
			this.panelChartRecentCallJobResultCountRel.TabIndex = ((int)(resources.GetObject("panelChartRecentCallJobResultCountRel.TabIndex")));
			this.panelChartRecentCallJobResultCountRel.Text = resources.GetString("panelChartRecentCallJobResultCountRel.Text");
			this.panelChartRecentCallJobResultCountRel.Visible = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountRel.Visible")));
			// 
			// chartRecentCallJobResultCountRel
			// 
			this.chartRecentCallJobResultCountRel.AccessibleDescription = resources.GetString("chartRecentCallJobResultCountRel.AccessibleDescription");
			this.chartRecentCallJobResultCountRel.AccessibleName = resources.GetString("chartRecentCallJobResultCountRel.AccessibleName");
			this.chartRecentCallJobResultCountRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartRecentCallJobResultCountRel.Anchor")));
			this.chartRecentCallJobResultCountRel.AutoScroll = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.AutoScroll")));
			this.chartRecentCallJobResultCountRel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountRel.AutoScrollMargin")));
			this.chartRecentCallJobResultCountRel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountRel.AutoScrollMinSize")));
			this.chartRecentCallJobResultCountRel.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.BackgroundColor")));
			this.chartRecentCallJobResultCountRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartRecentCallJobResultCountRel.BackgroundImage")));
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
			this.chartRecentCallJobResultCountRel.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																										  curve1,
																										  curve2,
																										  curve3,
																										  curve4,
																										  curve5,
																										  curve6,
																										  curve7,
																										  curve8,
																										  curve9,
																										  curve10,
																										  curve11,
																										  curve12,
																										  curve13});
			this.chartRecentCallJobResultCountRel.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartRecentCallJobResultCountRel.DisplayedInterval")));
			this.chartRecentCallJobResultCountRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartRecentCallJobResultCountRel.Dock")));
			this.chartRecentCallJobResultCountRel.Enabled = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.Enabled")));
			this.chartRecentCallJobResultCountRel.Font = ((System.Drawing.Font)(resources.GetObject("chartRecentCallJobResultCountRel.Font")));
			this.chartRecentCallJobResultCountRel.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.FrameColor")));
			this.chartRecentCallJobResultCountRel.GridColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.GridColor")));
			this.chartRecentCallJobResultCountRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartRecentCallJobResultCountRel.ImeMode")));
			this.chartRecentCallJobResultCountRel.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartRecentCallJobResultCountRel.LegendAlignment")));
			this.chartRecentCallJobResultCountRel.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.LegendColor")));
			this.chartRecentCallJobResultCountRel.Location = ((System.Drawing.Point)(resources.GetObject("chartRecentCallJobResultCountRel.Location")));
			this.chartRecentCallJobResultCountRel.Name = "chartRecentCallJobResultCountRel";
			this.chartRecentCallJobResultCountRel.Painting = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.Painting")));
			this.chartRecentCallJobResultCountRel.RescaleRatio = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountRel.RescaleRatio")));
			this.chartRecentCallJobResultCountRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartRecentCallJobResultCountRel.RightToLeft")));
			this.chartRecentCallJobResultCountRel.Size = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountRel.Size")));
			this.chartRecentCallJobResultCountRel.TabIndex = ((int)(resources.GetObject("chartRecentCallJobResultCountRel.TabIndex")));
			this.chartRecentCallJobResultCountRel.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.ValueColor")));
			this.chartRecentCallJobResultCountRel.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartRecentCallJobResultCountRel.ValueType")));
			this.chartRecentCallJobResultCountRel.Visible = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.Visible")));
			this.chartRecentCallJobResultCountRel.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.XLabelColor")));
			this.chartRecentCallJobResultCountRel.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountRel.YLabelColor")));
			this.chartRecentCallJobResultCountRel.YMax = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountRel.YMax")));
			this.chartRecentCallJobResultCountRel.YMaxScaling = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.YMaxScaling")));
			this.chartRecentCallJobResultCountRel.YMin = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountRel.YMin")));
			this.chartRecentCallJobResultCountRel.YMinScaling = ((bool)(resources.GetObject("chartRecentCallJobResultCountRel.YMinScaling")));
			// 
			// groupBoxChartRecentCallJobResultCountAbs
			// 
			this.groupBoxChartRecentCallJobResultCountAbs.AccessibleDescription = resources.GetString("groupBoxChartRecentCallJobResultCountAbs.AccessibleDescription");
			this.groupBoxChartRecentCallJobResultCountAbs.AccessibleName = resources.GetString("groupBoxChartRecentCallJobResultCountAbs.AccessibleName");
			this.groupBoxChartRecentCallJobResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Anchor")));
			this.groupBoxChartRecentCallJobResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.BackgroundImage")));
			this.groupBoxChartRecentCallJobResultCountAbs.Controls.Add(this.panelChartRecentCallJobResultCountAbs);
			this.groupBoxChartRecentCallJobResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Dock")));
			this.groupBoxChartRecentCallJobResultCountAbs.Enabled = ((bool)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Enabled")));
			this.groupBoxChartRecentCallJobResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Font")));
			this.groupBoxChartRecentCallJobResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.ImeMode")));
			this.groupBoxChartRecentCallJobResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Location")));
			this.groupBoxChartRecentCallJobResultCountAbs.Name = "groupBoxChartRecentCallJobResultCountAbs";
			this.groupBoxChartRecentCallJobResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.RightToLeft")));
			this.groupBoxChartRecentCallJobResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Size")));
			this.groupBoxChartRecentCallJobResultCountAbs.TabIndex = ((int)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.TabIndex")));
			this.groupBoxChartRecentCallJobResultCountAbs.TabStop = false;
			this.groupBoxChartRecentCallJobResultCountAbs.Text = resources.GetString("groupBoxChartRecentCallJobResultCountAbs.Text");
			this.groupBoxChartRecentCallJobResultCountAbs.Visible = ((bool)(resources.GetObject("groupBoxChartRecentCallJobResultCountAbs.Visible")));
			// 
			// panelChartRecentCallJobResultCountAbs
			// 
			this.panelChartRecentCallJobResultCountAbs.AccessibleDescription = resources.GetString("panelChartRecentCallJobResultCountAbs.AccessibleDescription");
			this.panelChartRecentCallJobResultCountAbs.AccessibleName = resources.GetString("panelChartRecentCallJobResultCountAbs.AccessibleName");
			this.panelChartRecentCallJobResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Anchor")));
			this.panelChartRecentCallJobResultCountAbs.AutoScroll = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountAbs.AutoScroll")));
			this.panelChartRecentCallJobResultCountAbs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountAbs.AutoScrollMargin")));
			this.panelChartRecentCallJobResultCountAbs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountAbs.AutoScrollMinSize")));
			this.panelChartRecentCallJobResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChartRecentCallJobResultCountAbs.BackgroundImage")));
			this.panelChartRecentCallJobResultCountAbs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChartRecentCallJobResultCountAbs.Controls.Add(this.chartRecentCallJobResultCountAbs);
			this.panelChartRecentCallJobResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Dock")));
			this.panelChartRecentCallJobResultCountAbs.Enabled = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Enabled")));
			this.panelChartRecentCallJobResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Font")));
			this.panelChartRecentCallJobResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panelChartRecentCallJobResultCountAbs.ImeMode")));
			this.panelChartRecentCallJobResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Location")));
			this.panelChartRecentCallJobResultCountAbs.Name = "panelChartRecentCallJobResultCountAbs";
			this.panelChartRecentCallJobResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panelChartRecentCallJobResultCountAbs.RightToLeft")));
			this.panelChartRecentCallJobResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Size")));
			this.panelChartRecentCallJobResultCountAbs.TabIndex = ((int)(resources.GetObject("panelChartRecentCallJobResultCountAbs.TabIndex")));
			this.panelChartRecentCallJobResultCountAbs.Text = resources.GetString("panelChartRecentCallJobResultCountAbs.Text");
			this.panelChartRecentCallJobResultCountAbs.Visible = ((bool)(resources.GetObject("panelChartRecentCallJobResultCountAbs.Visible")));
			// 
			// chartRecentCallJobResultCountAbs
			// 
			this.chartRecentCallJobResultCountAbs.AccessibleDescription = resources.GetString("chartRecentCallJobResultCountAbs.AccessibleDescription");
			this.chartRecentCallJobResultCountAbs.AccessibleName = resources.GetString("chartRecentCallJobResultCountAbs.AccessibleName");
			this.chartRecentCallJobResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("chartRecentCallJobResultCountAbs.Anchor")));
			this.chartRecentCallJobResultCountAbs.AutoScroll = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.AutoScroll")));
			this.chartRecentCallJobResultCountAbs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountAbs.AutoScrollMargin")));
			this.chartRecentCallJobResultCountAbs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountAbs.AutoScrollMinSize")));
			this.chartRecentCallJobResultCountAbs.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.BackgroundColor")));
			this.chartRecentCallJobResultCountAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chartRecentCallJobResultCountAbs.BackgroundImage")));
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
			curve22.Caption = resources.GetString("curve22.Caption");
			curve22.Color = ((System.Drawing.Color)(resources.GetObject("curve22.Color")));
			curve22.ContinuesLine = ((bool)(resources.GetObject("curve22.ContinuesLine")));
			curve22.MappingName = resources.GetString("curve22.MappingName");
			curve22.Visible = ((bool)(resources.GetObject("curve22.Visible")));
			curve23.Caption = resources.GetString("curve23.Caption");
			curve23.Color = ((System.Drawing.Color)(resources.GetObject("curve23.Color")));
			curve23.ContinuesLine = ((bool)(resources.GetObject("curve23.ContinuesLine")));
			curve23.MappingName = resources.GetString("curve23.MappingName");
			curve23.Visible = ((bool)(resources.GetObject("curve23.Visible")));
			curve24.Caption = resources.GetString("curve24.Caption");
			curve24.Color = ((System.Drawing.Color)(resources.GetObject("curve24.Color")));
			curve24.ContinuesLine = ((bool)(resources.GetObject("curve24.ContinuesLine")));
			curve24.MappingName = resources.GetString("curve24.MappingName");
			curve24.Visible = ((bool)(resources.GetObject("curve24.Visible")));
			curve25.Caption = resources.GetString("curve25.Caption");
			curve25.Color = ((System.Drawing.Color)(resources.GetObject("curve25.Color")));
			curve25.ContinuesLine = ((bool)(resources.GetObject("curve25.ContinuesLine")));
			curve25.MappingName = resources.GetString("curve25.MappingName");
			curve25.Visible = ((bool)(resources.GetObject("curve25.Visible")));
			curve26.Caption = resources.GetString("curve26.Caption");
			curve26.Color = ((System.Drawing.Color)(resources.GetObject("curve26.Color")));
			curve26.ContinuesLine = ((bool)(resources.GetObject("curve26.ContinuesLine")));
			curve26.MappingName = resources.GetString("curve26.MappingName");
			curve26.Visible = ((bool)(resources.GetObject("curve26.Visible")));
			curve27.Caption = resources.GetString("curve27.Caption");
			curve27.Color = ((System.Drawing.Color)(resources.GetObject("curve27.Color")));
			curve27.ContinuesLine = ((bool)(resources.GetObject("curve27.ContinuesLine")));
			curve27.MappingName = resources.GetString("curve27.MappingName");
			curve27.Visible = ((bool)(resources.GetObject("curve27.Visible")));
			this.chartRecentCallJobResultCountAbs.Curves.AddRange(new itCampus.bb.Graph.Chart.Curve[] {
																										  curve14,
																										  curve15,
																										  curve16,
																										  curve17,
																										  curve18,
																										  curve19,
																										  curve20,
																										  curve21,
																										  curve22,
																										  curve23,
																										  curve24,
																										  curve25,
																										  curve26,
																										  curve27});
			this.chartRecentCallJobResultCountAbs.DisplayedInterval = ((itCampus.bb.Graph.Chart.Interval)(resources.GetObject("chartRecentCallJobResultCountAbs.DisplayedInterval")));
			this.chartRecentCallJobResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("chartRecentCallJobResultCountAbs.Dock")));
			this.chartRecentCallJobResultCountAbs.Enabled = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.Enabled")));
			this.chartRecentCallJobResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("chartRecentCallJobResultCountAbs.Font")));
			this.chartRecentCallJobResultCountAbs.FrameColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.FrameColor")));
			this.chartRecentCallJobResultCountAbs.GridColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.GridColor")));
			this.chartRecentCallJobResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("chartRecentCallJobResultCountAbs.ImeMode")));
			this.chartRecentCallJobResultCountAbs.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("chartRecentCallJobResultCountAbs.LegendAlignment")));
			this.chartRecentCallJobResultCountAbs.LegendColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.LegendColor")));
			this.chartRecentCallJobResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("chartRecentCallJobResultCountAbs.Location")));
			this.chartRecentCallJobResultCountAbs.Name = "chartRecentCallJobResultCountAbs";
			this.chartRecentCallJobResultCountAbs.Painting = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.Painting")));
			this.chartRecentCallJobResultCountAbs.RescaleRatio = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountAbs.RescaleRatio")));
			this.chartRecentCallJobResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("chartRecentCallJobResultCountAbs.RightToLeft")));
			this.chartRecentCallJobResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("chartRecentCallJobResultCountAbs.Size")));
			this.chartRecentCallJobResultCountAbs.TabIndex = ((int)(resources.GetObject("chartRecentCallJobResultCountAbs.TabIndex")));
			this.chartRecentCallJobResultCountAbs.ValueColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.ValueColor")));
			this.chartRecentCallJobResultCountAbs.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("chartRecentCallJobResultCountAbs.ValueType")));
			this.chartRecentCallJobResultCountAbs.Visible = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.Visible")));
			this.chartRecentCallJobResultCountAbs.XLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.XLabelColor")));
			this.chartRecentCallJobResultCountAbs.YLabelColor = ((System.Drawing.Color)(resources.GetObject("chartRecentCallJobResultCountAbs.YLabelColor")));
			this.chartRecentCallJobResultCountAbs.YMax = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountAbs.YMax")));
			this.chartRecentCallJobResultCountAbs.YMaxScaling = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.YMaxScaling")));
			this.chartRecentCallJobResultCountAbs.YMin = ((System.Double)(resources.GetObject("chartRecentCallJobResultCountAbs.YMin")));
			this.chartRecentCallJobResultCountAbs.YMinScaling = ((bool)(resources.GetObject("chartRecentCallJobResultCountAbs.YMinScaling")));
			// 
			// groupBoxPieRecentCallJobResultCount
			// 
			this.groupBoxPieRecentCallJobResultCount.AccessibleDescription = resources.GetString("groupBoxPieRecentCallJobResultCount.AccessibleDescription");
			this.groupBoxPieRecentCallJobResultCount.AccessibleName = resources.GetString("groupBoxPieRecentCallJobResultCount.AccessibleName");
			this.groupBoxPieRecentCallJobResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Anchor")));
			this.groupBoxPieRecentCallJobResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPieRecentCallJobResultCount.BackgroundImage")));
			this.groupBoxPieRecentCallJobResultCount.Controls.Add(this.pieRecentCallJobResultCount);
			this.groupBoxPieRecentCallJobResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Dock")));
			this.groupBoxPieRecentCallJobResultCount.Enabled = ((bool)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Enabled")));
			this.groupBoxPieRecentCallJobResultCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Font")));
			this.groupBoxPieRecentCallJobResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxPieRecentCallJobResultCount.ImeMode")));
			this.groupBoxPieRecentCallJobResultCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Location")));
			this.groupBoxPieRecentCallJobResultCount.Name = "groupBoxPieRecentCallJobResultCount";
			this.groupBoxPieRecentCallJobResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxPieRecentCallJobResultCount.RightToLeft")));
			this.groupBoxPieRecentCallJobResultCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Size")));
			this.groupBoxPieRecentCallJobResultCount.TabIndex = ((int)(resources.GetObject("groupBoxPieRecentCallJobResultCount.TabIndex")));
			this.groupBoxPieRecentCallJobResultCount.TabStop = false;
			this.groupBoxPieRecentCallJobResultCount.Text = resources.GetString("groupBoxPieRecentCallJobResultCount.Text");
			this.groupBoxPieRecentCallJobResultCount.Visible = ((bool)(resources.GetObject("groupBoxPieRecentCallJobResultCount.Visible")));
			// 
			// pieRecentCallJobResultCount
			// 
			this.pieRecentCallJobResultCount.AccessibleDescription = resources.GetString("pieRecentCallJobResultCount.AccessibleDescription");
			this.pieRecentCallJobResultCount.AccessibleName = resources.GetString("pieRecentCallJobResultCount.AccessibleName");
			this.pieRecentCallJobResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pieRecentCallJobResultCount.Anchor")));
			this.pieRecentCallJobResultCount.AutoScroll = ((bool)(resources.GetObject("pieRecentCallJobResultCount.AutoScroll")));
			this.pieRecentCallJobResultCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pieRecentCallJobResultCount.AutoScrollMargin")));
			this.pieRecentCallJobResultCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pieRecentCallJobResultCount.AutoScrollMinSize")));
			this.pieRecentCallJobResultCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("pieRecentCallJobResultCount.BackgroundColor")));
			this.pieRecentCallJobResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieRecentCallJobResultCount.BackgroundImage")));
			this.pieRecentCallJobResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pieRecentCallJobResultCount.Dock")));
			this.pieRecentCallJobResultCount.Enabled = ((bool)(resources.GetObject("pieRecentCallJobResultCount.Enabled")));
			this.pieRecentCallJobResultCount.Font = ((System.Drawing.Font)(resources.GetObject("pieRecentCallJobResultCount.Font")));
			this.pieRecentCallJobResultCount.HorizontalSpace = ((int)(resources.GetObject("pieRecentCallJobResultCount.HorizontalSpace")));
			this.pieRecentCallJobResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pieRecentCallJobResultCount.ImeMode")));
			this.pieRecentCallJobResultCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("pieRecentCallJobResultCount.LegendAlignment")));
			this.pieRecentCallJobResultCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("pieRecentCallJobResultCount.LegendColor")));
			this.pieRecentCallJobResultCount.Location = ((System.Drawing.Point)(resources.GetObject("pieRecentCallJobResultCount.Location")));
			this.pieRecentCallJobResultCount.Name = "pieRecentCallJobResultCount";
			this.pieRecentCallJobResultCount.Painting = ((bool)(resources.GetObject("pieRecentCallJobResultCount.Painting")));
			this.pieRecentCallJobResultCount.RefreshInterval = ((int)(resources.GetObject("pieRecentCallJobResultCount.RefreshInterval")));
			this.pieRecentCallJobResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pieRecentCallJobResultCount.RightToLeft")));
			this.pieRecentCallJobResultCount.Size = ((System.Drawing.Size)(resources.GetObject("pieRecentCallJobResultCount.Size")));
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
			slice10.Caption = resources.GetString("slice10.Caption");
			slice10.Color = ((System.Drawing.Color)(resources.GetObject("slice10.Color")));
			slice10.Value = ((System.Double)(resources.GetObject("slice10.Value")));
			slice10.Visible = ((bool)(resources.GetObject("slice10.Visible")));
			slice11.Caption = resources.GetString("slice11.Caption");
			slice11.Color = ((System.Drawing.Color)(resources.GetObject("slice11.Color")));
			slice11.Value = ((System.Double)(resources.GetObject("slice11.Value")));
			slice11.Visible = ((bool)(resources.GetObject("slice11.Visible")));
			slice12.Caption = resources.GetString("slice12.Caption");
			slice12.Color = ((System.Drawing.Color)(resources.GetObject("slice12.Color")));
			slice12.Value = ((System.Double)(resources.GetObject("slice12.Value")));
			slice12.Visible = ((bool)(resources.GetObject("slice12.Visible")));
			slice13.Caption = resources.GetString("slice13.Caption");
			slice13.Color = ((System.Drawing.Color)(resources.GetObject("slice13.Color")));
			slice13.Value = ((System.Double)(resources.GetObject("slice13.Value")));
			slice13.Visible = ((bool)(resources.GetObject("slice13.Visible")));
			this.pieRecentCallJobResultCount.Slices.AddRange(new itCampus.bb.Graph.Pie.Slice[] {
																								   slice1,
																								   slice2,
																								   slice3,
																								   slice4,
																								   slice5,
																								   slice6,
																								   slice7,
																								   slice8,
																								   slice9,
																								   slice10,
																								   slice11,
																								   slice12,
																								   slice13});
			this.pieRecentCallJobResultCount.TabIndex = ((int)(resources.GetObject("pieRecentCallJobResultCount.TabIndex")));
			this.pieRecentCallJobResultCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("pieRecentCallJobResultCount.ValueColor")));
			this.pieRecentCallJobResultCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("pieRecentCallJobResultCount.ValueType")));
			this.pieRecentCallJobResultCount.VerticalSpace = ((int)(resources.GetObject("pieRecentCallJobResultCount.VerticalSpace")));
			this.pieRecentCallJobResultCount.Visible = ((bool)(resources.GetObject("pieRecentCallJobResultCount.Visible")));
			// 
			// groupBoxRecentCallJobResults
			// 
			this.groupBoxRecentCallJobResults.AccessibleDescription = resources.GetString("groupBoxRecentCallJobResults.AccessibleDescription");
			this.groupBoxRecentCallJobResults.AccessibleName = resources.GetString("groupBoxRecentCallJobResults.AccessibleName");
			this.groupBoxRecentCallJobResults.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxRecentCallJobResults.Anchor")));
			this.groupBoxRecentCallJobResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxRecentCallJobResults.BackgroundImage")));
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsBottomLineGray);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsBottomLineWhite);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPutThroughRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPutThroughRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPutThroughAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPutThroughCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountLostRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountLostRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountLostAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountLostCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoInterestRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoInterestRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoInterestAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoInterestCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountAnsweringMachineRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountAnsweringMachineRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountAnsweringMachineAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountAnsweringMachineCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountFaxRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountFaxRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountFaxAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountFaxCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountACRRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountACRRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountACRAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountACRCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountTelcoOverloadRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountTelcoOverloadRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountTelcoOverloadAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountTelcoOverloadCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPSTNFailureRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPSTNFailureRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPSTNFailureAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountPSTNFailureCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountRouteDeniedRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountRouteDeniedRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountRouteDeniedAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountRouteDeniedCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBlacklistRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBlacklistRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBlacklistAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBlacklistCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountWrongNumberRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountWrongNumberRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountWrongNumberAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountWrongNumberCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoAnswerRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoAnswerRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoAnswerAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountNoAnswerCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBusyRelMea);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBusyRel);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBusyAbs);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultCountBusyCap);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsTopLineGray);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsTopLineWhite);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsRowRate);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsRowCount);
			this.groupBoxRecentCallJobResults.Controls.Add(this.labelRecentCallJobResultsRowResult);
			this.groupBoxRecentCallJobResults.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxRecentCallJobResults.Dock")));
			this.groupBoxRecentCallJobResults.Enabled = ((bool)(resources.GetObject("groupBoxRecentCallJobResults.Enabled")));
			this.groupBoxRecentCallJobResults.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxRecentCallJobResults.Font")));
			this.groupBoxRecentCallJobResults.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxRecentCallJobResults.ImeMode")));
			this.groupBoxRecentCallJobResults.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxRecentCallJobResults.Location")));
			this.groupBoxRecentCallJobResults.Name = "groupBoxRecentCallJobResults";
			this.groupBoxRecentCallJobResults.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxRecentCallJobResults.RightToLeft")));
			this.groupBoxRecentCallJobResults.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxRecentCallJobResults.Size")));
			this.groupBoxRecentCallJobResults.TabIndex = ((int)(resources.GetObject("groupBoxRecentCallJobResults.TabIndex")));
			this.groupBoxRecentCallJobResults.TabStop = false;
			this.groupBoxRecentCallJobResults.Text = resources.GetString("groupBoxRecentCallJobResults.Text");
			this.groupBoxRecentCallJobResults.Visible = ((bool)(resources.GetObject("groupBoxRecentCallJobResults.Visible")));
			// 
			// labelRecentCallJobResultCountAbs
			// 
			this.labelRecentCallJobResultCountAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountAbs.AccessibleName");
			this.labelRecentCallJobResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountAbs.Anchor")));
			this.labelRecentCallJobResultCountAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountAbs.AutoSize")));
			this.labelRecentCallJobResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountAbs.Dock")));
			this.labelRecentCallJobResultCountAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountAbs.Enabled")));
			this.labelRecentCallJobResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountAbs.Font")));
			this.labelRecentCallJobResultCountAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountAbs.Image")));
			this.labelRecentCallJobResultCountAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAbs.ImageAlign")));
			this.labelRecentCallJobResultCountAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAbs.ImageIndex")));
			this.labelRecentCallJobResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountAbs.ImeMode")));
			this.labelRecentCallJobResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountAbs.Location")));
			this.labelRecentCallJobResultCountAbs.Name = "labelRecentCallJobResultCountAbs";
			this.labelRecentCallJobResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountAbs.RightToLeft")));
			this.labelRecentCallJobResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountAbs.Size")));
			this.labelRecentCallJobResultCountAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAbs.TabIndex")));
			this.labelRecentCallJobResultCountAbs.Text = resources.GetString("labelRecentCallJobResultCountAbs.Text");
			this.labelRecentCallJobResultCountAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAbs.TextAlign")));
			this.labelRecentCallJobResultCountAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountAbs.Visible")));
			// 
			// labelRecentCallJobResultCountCap
			// 
			this.labelRecentCallJobResultCountCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountCap.AccessibleDescription");
			this.labelRecentCallJobResultCountCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountCap.AccessibleName");
			this.labelRecentCallJobResultCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountCap.Anchor")));
			this.labelRecentCallJobResultCountCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountCap.AutoSize")));
			this.labelRecentCallJobResultCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountCap.Dock")));
			this.labelRecentCallJobResultCountCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountCap.Enabled")));
			this.labelRecentCallJobResultCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountCap.Font")));
			this.labelRecentCallJobResultCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountCap.Image")));
			this.labelRecentCallJobResultCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountCap.ImageAlign")));
			this.labelRecentCallJobResultCountCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountCap.ImageIndex")));
			this.labelRecentCallJobResultCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountCap.ImeMode")));
			this.labelRecentCallJobResultCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountCap.Location")));
			this.labelRecentCallJobResultCountCap.Name = "labelRecentCallJobResultCountCap";
			this.labelRecentCallJobResultCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountCap.RightToLeft")));
			this.labelRecentCallJobResultCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountCap.Size")));
			this.labelRecentCallJobResultCountCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountCap.TabIndex")));
			this.labelRecentCallJobResultCountCap.Text = resources.GetString("labelRecentCallJobResultCountCap.Text");
			this.labelRecentCallJobResultCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountCap.TextAlign")));
			this.labelRecentCallJobResultCountCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountCap.Visible")));
			// 
			// labelRecentCallJobResultsBottomLineGray
			// 
			this.labelRecentCallJobResultsBottomLineGray.AccessibleDescription = resources.GetString("labelRecentCallJobResultsBottomLineGray.AccessibleDescription");
			this.labelRecentCallJobResultsBottomLineGray.AccessibleName = resources.GetString("labelRecentCallJobResultsBottomLineGray.AccessibleName");
			this.labelRecentCallJobResultsBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Anchor")));
			this.labelRecentCallJobResultsBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.AutoSize")));
			this.labelRecentCallJobResultsBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelRecentCallJobResultsBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Dock")));
			this.labelRecentCallJobResultsBottomLineGray.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Enabled")));
			this.labelRecentCallJobResultsBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Font")));
			this.labelRecentCallJobResultsBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentCallJobResultsBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Image")));
			this.labelRecentCallJobResultsBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.ImageAlign")));
			this.labelRecentCallJobResultsBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.ImageIndex")));
			this.labelRecentCallJobResultsBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.ImeMode")));
			this.labelRecentCallJobResultsBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Location")));
			this.labelRecentCallJobResultsBottomLineGray.Name = "labelRecentCallJobResultsBottomLineGray";
			this.labelRecentCallJobResultsBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.RightToLeft")));
			this.labelRecentCallJobResultsBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Size")));
			this.labelRecentCallJobResultsBottomLineGray.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.TabIndex")));
			this.labelRecentCallJobResultsBottomLineGray.Text = resources.GetString("labelRecentCallJobResultsBottomLineGray.Text");
			this.labelRecentCallJobResultsBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.TextAlign")));
			this.labelRecentCallJobResultsBottomLineGray.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineGray.Visible")));
			// 
			// labelRecentCallJobResultsBottomLineWhite
			// 
			this.labelRecentCallJobResultsBottomLineWhite.AccessibleDescription = resources.GetString("labelRecentCallJobResultsBottomLineWhite.AccessibleDescription");
			this.labelRecentCallJobResultsBottomLineWhite.AccessibleName = resources.GetString("labelRecentCallJobResultsBottomLineWhite.AccessibleName");
			this.labelRecentCallJobResultsBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Anchor")));
			this.labelRecentCallJobResultsBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.AutoSize")));
			this.labelRecentCallJobResultsBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelRecentCallJobResultsBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Dock")));
			this.labelRecentCallJobResultsBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Enabled")));
			this.labelRecentCallJobResultsBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Font")));
			this.labelRecentCallJobResultsBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentCallJobResultsBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Image")));
			this.labelRecentCallJobResultsBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.ImageAlign")));
			this.labelRecentCallJobResultsBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.ImageIndex")));
			this.labelRecentCallJobResultsBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.ImeMode")));
			this.labelRecentCallJobResultsBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Location")));
			this.labelRecentCallJobResultsBottomLineWhite.Name = "labelRecentCallJobResultsBottomLineWhite";
			this.labelRecentCallJobResultsBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.RightToLeft")));
			this.labelRecentCallJobResultsBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Size")));
			this.labelRecentCallJobResultsBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.TabIndex")));
			this.labelRecentCallJobResultsBottomLineWhite.Text = resources.GetString("labelRecentCallJobResultsBottomLineWhite.Text");
			this.labelRecentCallJobResultsBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.TextAlign")));
			this.labelRecentCallJobResultsBottomLineWhite.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsBottomLineWhite.Visible")));
			// 
			// labelRecentCallJobResultCountPutThroughRelMea
			// 
			this.labelRecentCallJobResultCountPutThroughRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPutThroughRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountPutThroughRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountPutThroughRelMea.AccessibleName");
			this.labelRecentCallJobResultCountPutThroughRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Anchor")));
			this.labelRecentCallJobResultCountPutThroughRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.AutoSize")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Dock")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Enabled")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Font")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Image")));
			this.labelRecentCallJobResultCountPutThroughRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountPutThroughRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountPutThroughRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.ImeMode")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Location")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Name = "labelRecentCallJobResultCountPutThroughRelMea";
			this.labelRecentCallJobResultCountPutThroughRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Size")));
			this.labelRecentCallJobResultCountPutThroughRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.TabIndex")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Text = resources.GetString("labelRecentCallJobResultCountPutThroughRelMea.Text");
			this.labelRecentCallJobResultCountPutThroughRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.TextAlign")));
			this.labelRecentCallJobResultCountPutThroughRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountPutThroughRel
			// 
			this.labelRecentCallJobResultCountPutThroughRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPutThroughRel.AccessibleDescription");
			this.labelRecentCallJobResultCountPutThroughRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountPutThroughRel.AccessibleName");
			this.labelRecentCallJobResultCountPutThroughRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Anchor")));
			this.labelRecentCallJobResultCountPutThroughRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.AutoSize")));
			this.labelRecentCallJobResultCountPutThroughRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Dock")));
			this.labelRecentCallJobResultCountPutThroughRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Enabled")));
			this.labelRecentCallJobResultCountPutThroughRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Font")));
			this.labelRecentCallJobResultCountPutThroughRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Image")));
			this.labelRecentCallJobResultCountPutThroughRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.ImageAlign")));
			this.labelRecentCallJobResultCountPutThroughRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.ImageIndex")));
			this.labelRecentCallJobResultCountPutThroughRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.ImeMode")));
			this.labelRecentCallJobResultCountPutThroughRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Location")));
			this.labelRecentCallJobResultCountPutThroughRel.Name = "labelRecentCallJobResultCountPutThroughRel";
			this.labelRecentCallJobResultCountPutThroughRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.RightToLeft")));
			this.labelRecentCallJobResultCountPutThroughRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Size")));
			this.labelRecentCallJobResultCountPutThroughRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.TabIndex")));
			this.labelRecentCallJobResultCountPutThroughRel.Text = resources.GetString("labelRecentCallJobResultCountPutThroughRel.Text");
			this.labelRecentCallJobResultCountPutThroughRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.TextAlign")));
			this.labelRecentCallJobResultCountPutThroughRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughRel.Visible")));
			// 
			// labelRecentCallJobResultCountPutThroughAbs
			// 
			this.labelRecentCallJobResultCountPutThroughAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPutThroughAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountPutThroughAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountPutThroughAbs.AccessibleName");
			this.labelRecentCallJobResultCountPutThroughAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Anchor")));
			this.labelRecentCallJobResultCountPutThroughAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.AutoSize")));
			this.labelRecentCallJobResultCountPutThroughAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Dock")));
			this.labelRecentCallJobResultCountPutThroughAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Enabled")));
			this.labelRecentCallJobResultCountPutThroughAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Font")));
			this.labelRecentCallJobResultCountPutThroughAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Image")));
			this.labelRecentCallJobResultCountPutThroughAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.ImageAlign")));
			this.labelRecentCallJobResultCountPutThroughAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.ImageIndex")));
			this.labelRecentCallJobResultCountPutThroughAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.ImeMode")));
			this.labelRecentCallJobResultCountPutThroughAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Location")));
			this.labelRecentCallJobResultCountPutThroughAbs.Name = "labelRecentCallJobResultCountPutThroughAbs";
			this.labelRecentCallJobResultCountPutThroughAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.RightToLeft")));
			this.labelRecentCallJobResultCountPutThroughAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Size")));
			this.labelRecentCallJobResultCountPutThroughAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.TabIndex")));
			this.labelRecentCallJobResultCountPutThroughAbs.Text = resources.GetString("labelRecentCallJobResultCountPutThroughAbs.Text");
			this.labelRecentCallJobResultCountPutThroughAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.TextAlign")));
			this.labelRecentCallJobResultCountPutThroughAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughAbs.Visible")));
			// 
			// labelRecentCallJobResultCountPutThroughCap
			// 
			this.labelRecentCallJobResultCountPutThroughCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPutThroughCap.AccessibleDescription");
			this.labelRecentCallJobResultCountPutThroughCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountPutThroughCap.AccessibleName");
			this.labelRecentCallJobResultCountPutThroughCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Anchor")));
			this.labelRecentCallJobResultCountPutThroughCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.AutoSize")));
			this.labelRecentCallJobResultCountPutThroughCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Dock")));
			this.labelRecentCallJobResultCountPutThroughCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Enabled")));
			this.labelRecentCallJobResultCountPutThroughCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Font")));
			this.labelRecentCallJobResultCountPutThroughCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Image")));
			this.labelRecentCallJobResultCountPutThroughCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.ImageAlign")));
			this.labelRecentCallJobResultCountPutThroughCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.ImageIndex")));
			this.labelRecentCallJobResultCountPutThroughCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.ImeMode")));
			this.labelRecentCallJobResultCountPutThroughCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Location")));
			this.labelRecentCallJobResultCountPutThroughCap.Name = "labelRecentCallJobResultCountPutThroughCap";
			this.labelRecentCallJobResultCountPutThroughCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.RightToLeft")));
			this.labelRecentCallJobResultCountPutThroughCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Size")));
			this.labelRecentCallJobResultCountPutThroughCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.TabIndex")));
			this.labelRecentCallJobResultCountPutThroughCap.Text = resources.GetString("labelRecentCallJobResultCountPutThroughCap.Text");
			this.labelRecentCallJobResultCountPutThroughCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.TextAlign")));
			this.labelRecentCallJobResultCountPutThroughCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPutThroughCap.Visible")));
			// 
			// labelRecentCallJobResultCountLostRelMea
			// 
			this.labelRecentCallJobResultCountLostRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountLostRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountLostRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountLostRelMea.AccessibleName");
			this.labelRecentCallJobResultCountLostRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Anchor")));
			this.labelRecentCallJobResultCountLostRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.AutoSize")));
			this.labelRecentCallJobResultCountLostRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Dock")));
			this.labelRecentCallJobResultCountLostRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Enabled")));
			this.labelRecentCallJobResultCountLostRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Font")));
			this.labelRecentCallJobResultCountLostRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Image")));
			this.labelRecentCallJobResultCountLostRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountLostRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountLostRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.ImeMode")));
			this.labelRecentCallJobResultCountLostRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Location")));
			this.labelRecentCallJobResultCountLostRelMea.Name = "labelRecentCallJobResultCountLostRelMea";
			this.labelRecentCallJobResultCountLostRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountLostRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Size")));
			this.labelRecentCallJobResultCountLostRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.TabIndex")));
			this.labelRecentCallJobResultCountLostRelMea.Text = resources.GetString("labelRecentCallJobResultCountLostRelMea.Text");
			this.labelRecentCallJobResultCountLostRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.TextAlign")));
			this.labelRecentCallJobResultCountLostRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountLostRel
			// 
			this.labelRecentCallJobResultCountLostRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountLostRel.AccessibleDescription");
			this.labelRecentCallJobResultCountLostRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountLostRel.AccessibleName");
			this.labelRecentCallJobResultCountLostRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountLostRel.Anchor")));
			this.labelRecentCallJobResultCountLostRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRel.AutoSize")));
			this.labelRecentCallJobResultCountLostRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountLostRel.Dock")));
			this.labelRecentCallJobResultCountLostRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRel.Enabled")));
			this.labelRecentCallJobResultCountLostRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountLostRel.Font")));
			this.labelRecentCallJobResultCountLostRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountLostRel.Image")));
			this.labelRecentCallJobResultCountLostRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostRel.ImageAlign")));
			this.labelRecentCallJobResultCountLostRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostRel.ImageIndex")));
			this.labelRecentCallJobResultCountLostRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountLostRel.ImeMode")));
			this.labelRecentCallJobResultCountLostRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountLostRel.Location")));
			this.labelRecentCallJobResultCountLostRel.Name = "labelRecentCallJobResultCountLostRel";
			this.labelRecentCallJobResultCountLostRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountLostRel.RightToLeft")));
			this.labelRecentCallJobResultCountLostRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountLostRel.Size")));
			this.labelRecentCallJobResultCountLostRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostRel.TabIndex")));
			this.labelRecentCallJobResultCountLostRel.Text = resources.GetString("labelRecentCallJobResultCountLostRel.Text");
			this.labelRecentCallJobResultCountLostRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostRel.TextAlign")));
			this.labelRecentCallJobResultCountLostRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostRel.Visible")));
			// 
			// labelRecentCallJobResultCountLostAbs
			// 
			this.labelRecentCallJobResultCountLostAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountLostAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountLostAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountLostAbs.AccessibleName");
			this.labelRecentCallJobResultCountLostAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Anchor")));
			this.labelRecentCallJobResultCountLostAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostAbs.AutoSize")));
			this.labelRecentCallJobResultCountLostAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Dock")));
			this.labelRecentCallJobResultCountLostAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Enabled")));
			this.labelRecentCallJobResultCountLostAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Font")));
			this.labelRecentCallJobResultCountLostAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Image")));
			this.labelRecentCallJobResultCountLostAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostAbs.ImageAlign")));
			this.labelRecentCallJobResultCountLostAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostAbs.ImageIndex")));
			this.labelRecentCallJobResultCountLostAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountLostAbs.ImeMode")));
			this.labelRecentCallJobResultCountLostAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Location")));
			this.labelRecentCallJobResultCountLostAbs.Name = "labelRecentCallJobResultCountLostAbs";
			this.labelRecentCallJobResultCountLostAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountLostAbs.RightToLeft")));
			this.labelRecentCallJobResultCountLostAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Size")));
			this.labelRecentCallJobResultCountLostAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostAbs.TabIndex")));
			this.labelRecentCallJobResultCountLostAbs.Text = resources.GetString("labelRecentCallJobResultCountLostAbs.Text");
			this.labelRecentCallJobResultCountLostAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostAbs.TextAlign")));
			this.labelRecentCallJobResultCountLostAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostAbs.Visible")));
			// 
			// labelRecentCallJobResultCountLostCap
			// 
			this.labelRecentCallJobResultCountLostCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountLostCap.AccessibleDescription");
			this.labelRecentCallJobResultCountLostCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountLostCap.AccessibleName");
			this.labelRecentCallJobResultCountLostCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountLostCap.Anchor")));
			this.labelRecentCallJobResultCountLostCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostCap.AutoSize")));
			this.labelRecentCallJobResultCountLostCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountLostCap.Dock")));
			this.labelRecentCallJobResultCountLostCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostCap.Enabled")));
			this.labelRecentCallJobResultCountLostCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountLostCap.Font")));
			this.labelRecentCallJobResultCountLostCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountLostCap.Image")));
			this.labelRecentCallJobResultCountLostCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostCap.ImageAlign")));
			this.labelRecentCallJobResultCountLostCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostCap.ImageIndex")));
			this.labelRecentCallJobResultCountLostCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountLostCap.ImeMode")));
			this.labelRecentCallJobResultCountLostCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountLostCap.Location")));
			this.labelRecentCallJobResultCountLostCap.Name = "labelRecentCallJobResultCountLostCap";
			this.labelRecentCallJobResultCountLostCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountLostCap.RightToLeft")));
			this.labelRecentCallJobResultCountLostCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountLostCap.Size")));
			this.labelRecentCallJobResultCountLostCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountLostCap.TabIndex")));
			this.labelRecentCallJobResultCountLostCap.Text = resources.GetString("labelRecentCallJobResultCountLostCap.Text");
			this.labelRecentCallJobResultCountLostCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountLostCap.TextAlign")));
			this.labelRecentCallJobResultCountLostCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountLostCap.Visible")));
			// 
			// labelRecentCallJobResultCountNoInterestRelMea
			// 
			this.labelRecentCallJobResultCountNoInterestRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoInterestRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountNoInterestRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoInterestRelMea.AccessibleName");
			this.labelRecentCallJobResultCountNoInterestRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Anchor")));
			this.labelRecentCallJobResultCountNoInterestRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.AutoSize")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Dock")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Enabled")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Font")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Image")));
			this.labelRecentCallJobResultCountNoInterestRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountNoInterestRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountNoInterestRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.ImeMode")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Location")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Name = "labelRecentCallJobResultCountNoInterestRelMea";
			this.labelRecentCallJobResultCountNoInterestRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Size")));
			this.labelRecentCallJobResultCountNoInterestRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.TabIndex")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Text = resources.GetString("labelRecentCallJobResultCountNoInterestRelMea.Text");
			this.labelRecentCallJobResultCountNoInterestRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.TextAlign")));
			this.labelRecentCallJobResultCountNoInterestRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountNoInterestRel
			// 
			this.labelRecentCallJobResultCountNoInterestRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoInterestRel.AccessibleDescription");
			this.labelRecentCallJobResultCountNoInterestRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoInterestRel.AccessibleName");
			this.labelRecentCallJobResultCountNoInterestRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Anchor")));
			this.labelRecentCallJobResultCountNoInterestRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.AutoSize")));
			this.labelRecentCallJobResultCountNoInterestRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Dock")));
			this.labelRecentCallJobResultCountNoInterestRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Enabled")));
			this.labelRecentCallJobResultCountNoInterestRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Font")));
			this.labelRecentCallJobResultCountNoInterestRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Image")));
			this.labelRecentCallJobResultCountNoInterestRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.ImageAlign")));
			this.labelRecentCallJobResultCountNoInterestRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.ImageIndex")));
			this.labelRecentCallJobResultCountNoInterestRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.ImeMode")));
			this.labelRecentCallJobResultCountNoInterestRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Location")));
			this.labelRecentCallJobResultCountNoInterestRel.Name = "labelRecentCallJobResultCountNoInterestRel";
			this.labelRecentCallJobResultCountNoInterestRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.RightToLeft")));
			this.labelRecentCallJobResultCountNoInterestRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Size")));
			this.labelRecentCallJobResultCountNoInterestRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.TabIndex")));
			this.labelRecentCallJobResultCountNoInterestRel.Text = resources.GetString("labelRecentCallJobResultCountNoInterestRel.Text");
			this.labelRecentCallJobResultCountNoInterestRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.TextAlign")));
			this.labelRecentCallJobResultCountNoInterestRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestRel.Visible")));
			// 
			// labelRecentCallJobResultCountNoInterestAbs
			// 
			this.labelRecentCallJobResultCountNoInterestAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoInterestAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountNoInterestAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoInterestAbs.AccessibleName");
			this.labelRecentCallJobResultCountNoInterestAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Anchor")));
			this.labelRecentCallJobResultCountNoInterestAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.AutoSize")));
			this.labelRecentCallJobResultCountNoInterestAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Dock")));
			this.labelRecentCallJobResultCountNoInterestAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Enabled")));
			this.labelRecentCallJobResultCountNoInterestAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Font")));
			this.labelRecentCallJobResultCountNoInterestAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Image")));
			this.labelRecentCallJobResultCountNoInterestAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.ImageAlign")));
			this.labelRecentCallJobResultCountNoInterestAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.ImageIndex")));
			this.labelRecentCallJobResultCountNoInterestAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.ImeMode")));
			this.labelRecentCallJobResultCountNoInterestAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Location")));
			this.labelRecentCallJobResultCountNoInterestAbs.Name = "labelRecentCallJobResultCountNoInterestAbs";
			this.labelRecentCallJobResultCountNoInterestAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.RightToLeft")));
			this.labelRecentCallJobResultCountNoInterestAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Size")));
			this.labelRecentCallJobResultCountNoInterestAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.TabIndex")));
			this.labelRecentCallJobResultCountNoInterestAbs.Text = resources.GetString("labelRecentCallJobResultCountNoInterestAbs.Text");
			this.labelRecentCallJobResultCountNoInterestAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.TextAlign")));
			this.labelRecentCallJobResultCountNoInterestAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestAbs.Visible")));
			// 
			// labelRecentCallJobResultCountNoInterestCap
			// 
			this.labelRecentCallJobResultCountNoInterestCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoInterestCap.AccessibleDescription");
			this.labelRecentCallJobResultCountNoInterestCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoInterestCap.AccessibleName");
			this.labelRecentCallJobResultCountNoInterestCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Anchor")));
			this.labelRecentCallJobResultCountNoInterestCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.AutoSize")));
			this.labelRecentCallJobResultCountNoInterestCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Dock")));
			this.labelRecentCallJobResultCountNoInterestCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Enabled")));
			this.labelRecentCallJobResultCountNoInterestCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Font")));
			this.labelRecentCallJobResultCountNoInterestCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Image")));
			this.labelRecentCallJobResultCountNoInterestCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.ImageAlign")));
			this.labelRecentCallJobResultCountNoInterestCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.ImageIndex")));
			this.labelRecentCallJobResultCountNoInterestCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.ImeMode")));
			this.labelRecentCallJobResultCountNoInterestCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Location")));
			this.labelRecentCallJobResultCountNoInterestCap.Name = "labelRecentCallJobResultCountNoInterestCap";
			this.labelRecentCallJobResultCountNoInterestCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.RightToLeft")));
			this.labelRecentCallJobResultCountNoInterestCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Size")));
			this.labelRecentCallJobResultCountNoInterestCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.TabIndex")));
			this.labelRecentCallJobResultCountNoInterestCap.Text = resources.GetString("labelRecentCallJobResultCountNoInterestCap.Text");
			this.labelRecentCallJobResultCountNoInterestCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.TextAlign")));
			this.labelRecentCallJobResultCountNoInterestCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoInterestCap.Visible")));
			// 
			// labelRecentCallJobResultCountAnsweringMachineRelMea
			// 
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRelMea.AccessibleName");
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Anchor")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.AutoSize")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Dock")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Enabled")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Font")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Image")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.ImeMode")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Location")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Name = "labelRecentCallJobResultCountAnsweringMachineRelMea";
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Size")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.TabIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Text = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRelMea.Text");
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.TextAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountAnsweringMachineRel
			// 
			this.labelRecentCallJobResultCountAnsweringMachineRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRel.AccessibleDescription");
			this.labelRecentCallJobResultCountAnsweringMachineRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRel.AccessibleName");
			this.labelRecentCallJobResultCountAnsweringMachineRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Anchor")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.AutoSize")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Dock")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Enabled")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Font")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Image")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.ImageAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.ImageIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.ImeMode")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Location")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Name = "labelRecentCallJobResultCountAnsweringMachineRel";
			this.labelRecentCallJobResultCountAnsweringMachineRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.RightToLeft")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Size")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.TabIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Text = resources.GetString("labelRecentCallJobResultCountAnsweringMachineRel.Text");
			this.labelRecentCallJobResultCountAnsweringMachineRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.TextAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineRel.Visible")));
			// 
			// labelRecentCallJobResultCountAnsweringMachineAbs
			// 
			this.labelRecentCallJobResultCountAnsweringMachineAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountAnsweringMachineAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountAnsweringMachineAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountAnsweringMachineAbs.AccessibleName");
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Anchor")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.AutoSize")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Dock")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Enabled")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Font")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Image")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.ImageAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.ImageIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.ImeMode")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Location")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Name = "labelRecentCallJobResultCountAnsweringMachineAbs";
			this.labelRecentCallJobResultCountAnsweringMachineAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.RightToLeft")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Size")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.TabIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Text = resources.GetString("labelRecentCallJobResultCountAnsweringMachineAbs.Text");
			this.labelRecentCallJobResultCountAnsweringMachineAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.TextAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineAbs.Visible")));
			// 
			// labelRecentCallJobResultCountAnsweringMachineCap
			// 
			this.labelRecentCallJobResultCountAnsweringMachineCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountAnsweringMachineCap.AccessibleDescription");
			this.labelRecentCallJobResultCountAnsweringMachineCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountAnsweringMachineCap.AccessibleName");
			this.labelRecentCallJobResultCountAnsweringMachineCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Anchor")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.AutoSize")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Dock")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Enabled")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Font")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Image")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.ImageAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.ImageIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.ImeMode")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Location")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Name = "labelRecentCallJobResultCountAnsweringMachineCap";
			this.labelRecentCallJobResultCountAnsweringMachineCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.RightToLeft")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Size")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.TabIndex")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Text = resources.GetString("labelRecentCallJobResultCountAnsweringMachineCap.Text");
			this.labelRecentCallJobResultCountAnsweringMachineCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.TextAlign")));
			this.labelRecentCallJobResultCountAnsweringMachineCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountAnsweringMachineCap.Visible")));
			// 
			// labelRecentCallJobResultCountFaxRelMea
			// 
			this.labelRecentCallJobResultCountFaxRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountFaxRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountFaxRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountFaxRelMea.AccessibleName");
			this.labelRecentCallJobResultCountFaxRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Anchor")));
			this.labelRecentCallJobResultCountFaxRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.AutoSize")));
			this.labelRecentCallJobResultCountFaxRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Dock")));
			this.labelRecentCallJobResultCountFaxRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Enabled")));
			this.labelRecentCallJobResultCountFaxRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Font")));
			this.labelRecentCallJobResultCountFaxRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Image")));
			this.labelRecentCallJobResultCountFaxRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountFaxRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountFaxRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.ImeMode")));
			this.labelRecentCallJobResultCountFaxRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Location")));
			this.labelRecentCallJobResultCountFaxRelMea.Name = "labelRecentCallJobResultCountFaxRelMea";
			this.labelRecentCallJobResultCountFaxRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountFaxRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Size")));
			this.labelRecentCallJobResultCountFaxRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.TabIndex")));
			this.labelRecentCallJobResultCountFaxRelMea.Text = resources.GetString("labelRecentCallJobResultCountFaxRelMea.Text");
			this.labelRecentCallJobResultCountFaxRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.TextAlign")));
			this.labelRecentCallJobResultCountFaxRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountFaxRel
			// 
			this.labelRecentCallJobResultCountFaxRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountFaxRel.AccessibleDescription");
			this.labelRecentCallJobResultCountFaxRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountFaxRel.AccessibleName");
			this.labelRecentCallJobResultCountFaxRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Anchor")));
			this.labelRecentCallJobResultCountFaxRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRel.AutoSize")));
			this.labelRecentCallJobResultCountFaxRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Dock")));
			this.labelRecentCallJobResultCountFaxRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Enabled")));
			this.labelRecentCallJobResultCountFaxRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Font")));
			this.labelRecentCallJobResultCountFaxRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Image")));
			this.labelRecentCallJobResultCountFaxRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxRel.ImageAlign")));
			this.labelRecentCallJobResultCountFaxRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxRel.ImageIndex")));
			this.labelRecentCallJobResultCountFaxRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountFaxRel.ImeMode")));
			this.labelRecentCallJobResultCountFaxRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Location")));
			this.labelRecentCallJobResultCountFaxRel.Name = "labelRecentCallJobResultCountFaxRel";
			this.labelRecentCallJobResultCountFaxRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountFaxRel.RightToLeft")));
			this.labelRecentCallJobResultCountFaxRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Size")));
			this.labelRecentCallJobResultCountFaxRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxRel.TabIndex")));
			this.labelRecentCallJobResultCountFaxRel.Text = resources.GetString("labelRecentCallJobResultCountFaxRel.Text");
			this.labelRecentCallJobResultCountFaxRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxRel.TextAlign")));
			this.labelRecentCallJobResultCountFaxRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxRel.Visible")));
			// 
			// labelRecentCallJobResultCountFaxAbs
			// 
			this.labelRecentCallJobResultCountFaxAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountFaxAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountFaxAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountFaxAbs.AccessibleName");
			this.labelRecentCallJobResultCountFaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Anchor")));
			this.labelRecentCallJobResultCountFaxAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.AutoSize")));
			this.labelRecentCallJobResultCountFaxAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Dock")));
			this.labelRecentCallJobResultCountFaxAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Enabled")));
			this.labelRecentCallJobResultCountFaxAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Font")));
			this.labelRecentCallJobResultCountFaxAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Image")));
			this.labelRecentCallJobResultCountFaxAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.ImageAlign")));
			this.labelRecentCallJobResultCountFaxAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.ImageIndex")));
			this.labelRecentCallJobResultCountFaxAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.ImeMode")));
			this.labelRecentCallJobResultCountFaxAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Location")));
			this.labelRecentCallJobResultCountFaxAbs.Name = "labelRecentCallJobResultCountFaxAbs";
			this.labelRecentCallJobResultCountFaxAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.RightToLeft")));
			this.labelRecentCallJobResultCountFaxAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Size")));
			this.labelRecentCallJobResultCountFaxAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.TabIndex")));
			this.labelRecentCallJobResultCountFaxAbs.Text = resources.GetString("labelRecentCallJobResultCountFaxAbs.Text");
			this.labelRecentCallJobResultCountFaxAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.TextAlign")));
			this.labelRecentCallJobResultCountFaxAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxAbs.Visible")));
			// 
			// labelRecentCallJobResultCountFaxCap
			// 
			this.labelRecentCallJobResultCountFaxCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountFaxCap.AccessibleDescription");
			this.labelRecentCallJobResultCountFaxCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountFaxCap.AccessibleName");
			this.labelRecentCallJobResultCountFaxCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Anchor")));
			this.labelRecentCallJobResultCountFaxCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxCap.AutoSize")));
			this.labelRecentCallJobResultCountFaxCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Dock")));
			this.labelRecentCallJobResultCountFaxCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Enabled")));
			this.labelRecentCallJobResultCountFaxCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Font")));
			this.labelRecentCallJobResultCountFaxCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Image")));
			this.labelRecentCallJobResultCountFaxCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxCap.ImageAlign")));
			this.labelRecentCallJobResultCountFaxCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxCap.ImageIndex")));
			this.labelRecentCallJobResultCountFaxCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountFaxCap.ImeMode")));
			this.labelRecentCallJobResultCountFaxCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Location")));
			this.labelRecentCallJobResultCountFaxCap.Name = "labelRecentCallJobResultCountFaxCap";
			this.labelRecentCallJobResultCountFaxCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountFaxCap.RightToLeft")));
			this.labelRecentCallJobResultCountFaxCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Size")));
			this.labelRecentCallJobResultCountFaxCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountFaxCap.TabIndex")));
			this.labelRecentCallJobResultCountFaxCap.Text = resources.GetString("labelRecentCallJobResultCountFaxCap.Text");
			this.labelRecentCallJobResultCountFaxCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountFaxCap.TextAlign")));
			this.labelRecentCallJobResultCountFaxCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountFaxCap.Visible")));
			// 
			// labelRecentCallJobResultCountACRRelMea
			// 
			this.labelRecentCallJobResultCountACRRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountACRRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountACRRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountACRRelMea.AccessibleName");
			this.labelRecentCallJobResultCountACRRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Anchor")));
			this.labelRecentCallJobResultCountACRRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.AutoSize")));
			this.labelRecentCallJobResultCountACRRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Dock")));
			this.labelRecentCallJobResultCountACRRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Enabled")));
			this.labelRecentCallJobResultCountACRRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Font")));
			this.labelRecentCallJobResultCountACRRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Image")));
			this.labelRecentCallJobResultCountACRRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountACRRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountACRRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.ImeMode")));
			this.labelRecentCallJobResultCountACRRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Location")));
			this.labelRecentCallJobResultCountACRRelMea.Name = "labelRecentCallJobResultCountACRRelMea";
			this.labelRecentCallJobResultCountACRRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountACRRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Size")));
			this.labelRecentCallJobResultCountACRRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.TabIndex")));
			this.labelRecentCallJobResultCountACRRelMea.Text = resources.GetString("labelRecentCallJobResultCountACRRelMea.Text");
			this.labelRecentCallJobResultCountACRRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.TextAlign")));
			this.labelRecentCallJobResultCountACRRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountACRRel
			// 
			this.labelRecentCallJobResultCountACRRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountACRRel.AccessibleDescription");
			this.labelRecentCallJobResultCountACRRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountACRRel.AccessibleName");
			this.labelRecentCallJobResultCountACRRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountACRRel.Anchor")));
			this.labelRecentCallJobResultCountACRRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRel.AutoSize")));
			this.labelRecentCallJobResultCountACRRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountACRRel.Dock")));
			this.labelRecentCallJobResultCountACRRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRel.Enabled")));
			this.labelRecentCallJobResultCountACRRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountACRRel.Font")));
			this.labelRecentCallJobResultCountACRRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountACRRel.Image")));
			this.labelRecentCallJobResultCountACRRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRRel.ImageAlign")));
			this.labelRecentCallJobResultCountACRRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRRel.ImageIndex")));
			this.labelRecentCallJobResultCountACRRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountACRRel.ImeMode")));
			this.labelRecentCallJobResultCountACRRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountACRRel.Location")));
			this.labelRecentCallJobResultCountACRRel.Name = "labelRecentCallJobResultCountACRRel";
			this.labelRecentCallJobResultCountACRRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountACRRel.RightToLeft")));
			this.labelRecentCallJobResultCountACRRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountACRRel.Size")));
			this.labelRecentCallJobResultCountACRRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRRel.TabIndex")));
			this.labelRecentCallJobResultCountACRRel.Text = resources.GetString("labelRecentCallJobResultCountACRRel.Text");
			this.labelRecentCallJobResultCountACRRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRRel.TextAlign")));
			this.labelRecentCallJobResultCountACRRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRRel.Visible")));
			// 
			// labelRecentCallJobResultCountACRAbs
			// 
			this.labelRecentCallJobResultCountACRAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountACRAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountACRAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountACRAbs.AccessibleName");
			this.labelRecentCallJobResultCountACRAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Anchor")));
			this.labelRecentCallJobResultCountACRAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRAbs.AutoSize")));
			this.labelRecentCallJobResultCountACRAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Dock")));
			this.labelRecentCallJobResultCountACRAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Enabled")));
			this.labelRecentCallJobResultCountACRAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Font")));
			this.labelRecentCallJobResultCountACRAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Image")));
			this.labelRecentCallJobResultCountACRAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRAbs.ImageAlign")));
			this.labelRecentCallJobResultCountACRAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRAbs.ImageIndex")));
			this.labelRecentCallJobResultCountACRAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountACRAbs.ImeMode")));
			this.labelRecentCallJobResultCountACRAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Location")));
			this.labelRecentCallJobResultCountACRAbs.Name = "labelRecentCallJobResultCountACRAbs";
			this.labelRecentCallJobResultCountACRAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountACRAbs.RightToLeft")));
			this.labelRecentCallJobResultCountACRAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Size")));
			this.labelRecentCallJobResultCountACRAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRAbs.TabIndex")));
			this.labelRecentCallJobResultCountACRAbs.Text = resources.GetString("labelRecentCallJobResultCountACRAbs.Text");
			this.labelRecentCallJobResultCountACRAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRAbs.TextAlign")));
			this.labelRecentCallJobResultCountACRAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRAbs.Visible")));
			// 
			// labelRecentCallJobResultCountACRCap
			// 
			this.labelRecentCallJobResultCountACRCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountACRCap.AccessibleDescription");
			this.labelRecentCallJobResultCountACRCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountACRCap.AccessibleName");
			this.labelRecentCallJobResultCountACRCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountACRCap.Anchor")));
			this.labelRecentCallJobResultCountACRCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRCap.AutoSize")));
			this.labelRecentCallJobResultCountACRCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountACRCap.Dock")));
			this.labelRecentCallJobResultCountACRCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRCap.Enabled")));
			this.labelRecentCallJobResultCountACRCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountACRCap.Font")));
			this.labelRecentCallJobResultCountACRCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountACRCap.Image")));
			this.labelRecentCallJobResultCountACRCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRCap.ImageAlign")));
			this.labelRecentCallJobResultCountACRCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRCap.ImageIndex")));
			this.labelRecentCallJobResultCountACRCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountACRCap.ImeMode")));
			this.labelRecentCallJobResultCountACRCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountACRCap.Location")));
			this.labelRecentCallJobResultCountACRCap.Name = "labelRecentCallJobResultCountACRCap";
			this.labelRecentCallJobResultCountACRCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountACRCap.RightToLeft")));
			this.labelRecentCallJobResultCountACRCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountACRCap.Size")));
			this.labelRecentCallJobResultCountACRCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountACRCap.TabIndex")));
			this.labelRecentCallJobResultCountACRCap.Text = resources.GetString("labelRecentCallJobResultCountACRCap.Text");
			this.labelRecentCallJobResultCountACRCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountACRCap.TextAlign")));
			this.labelRecentCallJobResultCountACRCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountACRCap.Visible")));
			// 
			// labelRecentCallJobResultCountTelcoOverloadRelMea
			// 
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRelMea.AccessibleName");
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Anchor")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.AutoSize")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Dock")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Enabled")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Font")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Image")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.ImeMode")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Location")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Name = "labelRecentCallJobResultCountTelcoOverloadRelMea";
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Size")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.TabIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Text = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRelMea.Text");
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.TextAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountTelcoOverloadRel
			// 
			this.labelRecentCallJobResultCountTelcoOverloadRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRel.AccessibleDescription");
			this.labelRecentCallJobResultCountTelcoOverloadRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRel.AccessibleName");
			this.labelRecentCallJobResultCountTelcoOverloadRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Anchor")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.AutoSize")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Dock")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Enabled")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Font")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Image")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.ImageAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.ImageIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.ImeMode")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Location")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Name = "labelRecentCallJobResultCountTelcoOverloadRel";
			this.labelRecentCallJobResultCountTelcoOverloadRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.RightToLeft")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Size")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.TabIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Text = resources.GetString("labelRecentCallJobResultCountTelcoOverloadRel.Text");
			this.labelRecentCallJobResultCountTelcoOverloadRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.TextAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadRel.Visible")));
			// 
			// labelRecentCallJobResultCountTelcoOverloadAbs
			// 
			this.labelRecentCallJobResultCountTelcoOverloadAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountTelcoOverloadAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountTelcoOverloadAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountTelcoOverloadAbs.AccessibleName");
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Anchor")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.AutoSize")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Dock")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Enabled")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Font")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Image")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.ImageAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.ImageIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.ImeMode")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Location")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Name = "labelRecentCallJobResultCountTelcoOverloadAbs";
			this.labelRecentCallJobResultCountTelcoOverloadAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.RightToLeft")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Size")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.TabIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Text = resources.GetString("labelRecentCallJobResultCountTelcoOverloadAbs.Text");
			this.labelRecentCallJobResultCountTelcoOverloadAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.TextAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadAbs.Visible")));
			// 
			// labelRecentCallJobResultCountTelcoOverloadCap
			// 
			this.labelRecentCallJobResultCountTelcoOverloadCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountTelcoOverloadCap.AccessibleDescription");
			this.labelRecentCallJobResultCountTelcoOverloadCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountTelcoOverloadCap.AccessibleName");
			this.labelRecentCallJobResultCountTelcoOverloadCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Anchor")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.AutoSize")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Dock")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Enabled")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Font")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Image")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.ImageAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.ImageIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.ImeMode")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Location")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Name = "labelRecentCallJobResultCountTelcoOverloadCap";
			this.labelRecentCallJobResultCountTelcoOverloadCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.RightToLeft")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Size")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.TabIndex")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Text = resources.GetString("labelRecentCallJobResultCountTelcoOverloadCap.Text");
			this.labelRecentCallJobResultCountTelcoOverloadCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.TextAlign")));
			this.labelRecentCallJobResultCountTelcoOverloadCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountTelcoOverloadCap.Visible")));
			// 
			// labelRecentCallJobResultCountPSTNFailureRelMea
			// 
			this.labelRecentCallJobResultCountPSTNFailureRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPSTNFailureRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountPSTNFailureRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountPSTNFailureRelMea.AccessibleName");
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Anchor")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.AutoSize")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Dock")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Enabled")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Font")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Image")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.ImeMode")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Location")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Name = "labelRecentCallJobResultCountPSTNFailureRelMea";
			this.labelRecentCallJobResultCountPSTNFailureRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Size")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.TabIndex")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Text = resources.GetString("labelRecentCallJobResultCountPSTNFailureRelMea.Text");
			this.labelRecentCallJobResultCountPSTNFailureRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.TextAlign")));
			this.labelRecentCallJobResultCountPSTNFailureRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountPSTNFailureRel
			// 
			this.labelRecentCallJobResultCountPSTNFailureRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPSTNFailureRel.AccessibleDescription");
			this.labelRecentCallJobResultCountPSTNFailureRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountPSTNFailureRel.AccessibleName");
			this.labelRecentCallJobResultCountPSTNFailureRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Anchor")));
			this.labelRecentCallJobResultCountPSTNFailureRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.AutoSize")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Dock")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Enabled")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Font")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Image")));
			this.labelRecentCallJobResultCountPSTNFailureRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.ImageAlign")));
			this.labelRecentCallJobResultCountPSTNFailureRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.ImageIndex")));
			this.labelRecentCallJobResultCountPSTNFailureRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.ImeMode")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Location")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Name = "labelRecentCallJobResultCountPSTNFailureRel";
			this.labelRecentCallJobResultCountPSTNFailureRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.RightToLeft")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Size")));
			this.labelRecentCallJobResultCountPSTNFailureRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.TabIndex")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Text = resources.GetString("labelRecentCallJobResultCountPSTNFailureRel.Text");
			this.labelRecentCallJobResultCountPSTNFailureRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.TextAlign")));
			this.labelRecentCallJobResultCountPSTNFailureRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureRel.Visible")));
			// 
			// labelRecentCallJobResultCountPSTNFailureAbs
			// 
			this.labelRecentCallJobResultCountPSTNFailureAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPSTNFailureAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountPSTNFailureAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountPSTNFailureAbs.AccessibleName");
			this.labelRecentCallJobResultCountPSTNFailureAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Anchor")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.AutoSize")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Dock")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Enabled")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Font")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Image")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.ImageAlign")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.ImageIndex")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.ImeMode")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Location")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Name = "labelRecentCallJobResultCountPSTNFailureAbs";
			this.labelRecentCallJobResultCountPSTNFailureAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.RightToLeft")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Size")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.TabIndex")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Text = resources.GetString("labelRecentCallJobResultCountPSTNFailureAbs.Text");
			this.labelRecentCallJobResultCountPSTNFailureAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.TextAlign")));
			this.labelRecentCallJobResultCountPSTNFailureAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureAbs.Visible")));
			// 
			// labelRecentCallJobResultCountPSTNFailureCap
			// 
			this.labelRecentCallJobResultCountPSTNFailureCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountPSTNFailureCap.AccessibleDescription");
			this.labelRecentCallJobResultCountPSTNFailureCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountPSTNFailureCap.AccessibleName");
			this.labelRecentCallJobResultCountPSTNFailureCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Anchor")));
			this.labelRecentCallJobResultCountPSTNFailureCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.AutoSize")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Dock")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Enabled")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Font")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Image")));
			this.labelRecentCallJobResultCountPSTNFailureCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.ImageAlign")));
			this.labelRecentCallJobResultCountPSTNFailureCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.ImageIndex")));
			this.labelRecentCallJobResultCountPSTNFailureCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.ImeMode")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Location")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Name = "labelRecentCallJobResultCountPSTNFailureCap";
			this.labelRecentCallJobResultCountPSTNFailureCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.RightToLeft")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Size")));
			this.labelRecentCallJobResultCountPSTNFailureCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.TabIndex")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Text = resources.GetString("labelRecentCallJobResultCountPSTNFailureCap.Text");
			this.labelRecentCallJobResultCountPSTNFailureCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.TextAlign")));
			this.labelRecentCallJobResultCountPSTNFailureCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountPSTNFailureCap.Visible")));
			// 
			// labelRecentCallJobResultCountRouteDeniedRelMea
			// 
			this.labelRecentCallJobResultCountRouteDeniedRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountRouteDeniedRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountRouteDeniedRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountRouteDeniedRelMea.AccessibleName");
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Anchor")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.AutoSize")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Dock")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Enabled")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Font")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Image")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.ImeMode")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Location")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Name = "labelRecentCallJobResultCountRouteDeniedRelMea";
			this.labelRecentCallJobResultCountRouteDeniedRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Size")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.TabIndex")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Text = resources.GetString("labelRecentCallJobResultCountRouteDeniedRelMea.Text");
			this.labelRecentCallJobResultCountRouteDeniedRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.TextAlign")));
			this.labelRecentCallJobResultCountRouteDeniedRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountRouteDeniedRel
			// 
			this.labelRecentCallJobResultCountRouteDeniedRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountRouteDeniedRel.AccessibleDescription");
			this.labelRecentCallJobResultCountRouteDeniedRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountRouteDeniedRel.AccessibleName");
			this.labelRecentCallJobResultCountRouteDeniedRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Anchor")));
			this.labelRecentCallJobResultCountRouteDeniedRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.AutoSize")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Dock")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Enabled")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Font")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Image")));
			this.labelRecentCallJobResultCountRouteDeniedRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.ImageAlign")));
			this.labelRecentCallJobResultCountRouteDeniedRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.ImageIndex")));
			this.labelRecentCallJobResultCountRouteDeniedRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.ImeMode")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Location")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Name = "labelRecentCallJobResultCountRouteDeniedRel";
			this.labelRecentCallJobResultCountRouteDeniedRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.RightToLeft")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Size")));
			this.labelRecentCallJobResultCountRouteDeniedRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.TabIndex")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Text = resources.GetString("labelRecentCallJobResultCountRouteDeniedRel.Text");
			this.labelRecentCallJobResultCountRouteDeniedRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.TextAlign")));
			this.labelRecentCallJobResultCountRouteDeniedRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedRel.Visible")));
			// 
			// labelRecentCallJobResultCountRouteDeniedAbs
			// 
			this.labelRecentCallJobResultCountRouteDeniedAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountRouteDeniedAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountRouteDeniedAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountRouteDeniedAbs.AccessibleName");
			this.labelRecentCallJobResultCountRouteDeniedAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Anchor")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.AutoSize")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Dock")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Enabled")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Font")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Image")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.ImageAlign")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.ImageIndex")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.ImeMode")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Location")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Name = "labelRecentCallJobResultCountRouteDeniedAbs";
			this.labelRecentCallJobResultCountRouteDeniedAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.RightToLeft")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Size")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.TabIndex")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Text = resources.GetString("labelRecentCallJobResultCountRouteDeniedAbs.Text");
			this.labelRecentCallJobResultCountRouteDeniedAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.TextAlign")));
			this.labelRecentCallJobResultCountRouteDeniedAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedAbs.Visible")));
			// 
			// labelRecentCallJobResultCountRouteDeniedCap
			// 
			this.labelRecentCallJobResultCountRouteDeniedCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountRouteDeniedCap.AccessibleDescription");
			this.labelRecentCallJobResultCountRouteDeniedCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountRouteDeniedCap.AccessibleName");
			this.labelRecentCallJobResultCountRouteDeniedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Anchor")));
			this.labelRecentCallJobResultCountRouteDeniedCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.AutoSize")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Dock")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Enabled")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Font")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Image")));
			this.labelRecentCallJobResultCountRouteDeniedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.ImageAlign")));
			this.labelRecentCallJobResultCountRouteDeniedCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.ImageIndex")));
			this.labelRecentCallJobResultCountRouteDeniedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.ImeMode")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Location")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Name = "labelRecentCallJobResultCountRouteDeniedCap";
			this.labelRecentCallJobResultCountRouteDeniedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.RightToLeft")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Size")));
			this.labelRecentCallJobResultCountRouteDeniedCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.TabIndex")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Text = resources.GetString("labelRecentCallJobResultCountRouteDeniedCap.Text");
			this.labelRecentCallJobResultCountRouteDeniedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.TextAlign")));
			this.labelRecentCallJobResultCountRouteDeniedCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountRouteDeniedCap.Visible")));
			// 
			// labelRecentCallJobResultCountBlacklistRelMea
			// 
			this.labelRecentCallJobResultCountBlacklistRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBlacklistRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountBlacklistRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountBlacklistRelMea.AccessibleName");
			this.labelRecentCallJobResultCountBlacklistRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Anchor")));
			this.labelRecentCallJobResultCountBlacklistRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.AutoSize")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Dock")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Enabled")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Font")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Image")));
			this.labelRecentCallJobResultCountBlacklistRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountBlacklistRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountBlacklistRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.ImeMode")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Location")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Name = "labelRecentCallJobResultCountBlacklistRelMea";
			this.labelRecentCallJobResultCountBlacklistRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Size")));
			this.labelRecentCallJobResultCountBlacklistRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.TabIndex")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Text = resources.GetString("labelRecentCallJobResultCountBlacklistRelMea.Text");
			this.labelRecentCallJobResultCountBlacklistRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.TextAlign")));
			this.labelRecentCallJobResultCountBlacklistRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountBlacklistRel
			// 
			this.labelRecentCallJobResultCountBlacklistRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBlacklistRel.AccessibleDescription");
			this.labelRecentCallJobResultCountBlacklistRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountBlacklistRel.AccessibleName");
			this.labelRecentCallJobResultCountBlacklistRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Anchor")));
			this.labelRecentCallJobResultCountBlacklistRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.AutoSize")));
			this.labelRecentCallJobResultCountBlacklistRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Dock")));
			this.labelRecentCallJobResultCountBlacklistRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Enabled")));
			this.labelRecentCallJobResultCountBlacklistRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Font")));
			this.labelRecentCallJobResultCountBlacklistRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Image")));
			this.labelRecentCallJobResultCountBlacklistRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.ImageAlign")));
			this.labelRecentCallJobResultCountBlacklistRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.ImageIndex")));
			this.labelRecentCallJobResultCountBlacklistRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.ImeMode")));
			this.labelRecentCallJobResultCountBlacklistRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Location")));
			this.labelRecentCallJobResultCountBlacklistRel.Name = "labelRecentCallJobResultCountBlacklistRel";
			this.labelRecentCallJobResultCountBlacklistRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.RightToLeft")));
			this.labelRecentCallJobResultCountBlacklistRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Size")));
			this.labelRecentCallJobResultCountBlacklistRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.TabIndex")));
			this.labelRecentCallJobResultCountBlacklistRel.Text = resources.GetString("labelRecentCallJobResultCountBlacklistRel.Text");
			this.labelRecentCallJobResultCountBlacklistRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.TextAlign")));
			this.labelRecentCallJobResultCountBlacklistRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistRel.Visible")));
			// 
			// labelRecentCallJobResultCountBlacklistAbs
			// 
			this.labelRecentCallJobResultCountBlacklistAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBlacklistAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountBlacklistAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountBlacklistAbs.AccessibleName");
			this.labelRecentCallJobResultCountBlacklistAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Anchor")));
			this.labelRecentCallJobResultCountBlacklistAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.AutoSize")));
			this.labelRecentCallJobResultCountBlacklistAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Dock")));
			this.labelRecentCallJobResultCountBlacklistAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Enabled")));
			this.labelRecentCallJobResultCountBlacklistAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Font")));
			this.labelRecentCallJobResultCountBlacklistAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Image")));
			this.labelRecentCallJobResultCountBlacklistAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.ImageAlign")));
			this.labelRecentCallJobResultCountBlacklistAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.ImageIndex")));
			this.labelRecentCallJobResultCountBlacklistAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.ImeMode")));
			this.labelRecentCallJobResultCountBlacklistAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Location")));
			this.labelRecentCallJobResultCountBlacklistAbs.Name = "labelRecentCallJobResultCountBlacklistAbs";
			this.labelRecentCallJobResultCountBlacklistAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.RightToLeft")));
			this.labelRecentCallJobResultCountBlacklistAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Size")));
			this.labelRecentCallJobResultCountBlacklistAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.TabIndex")));
			this.labelRecentCallJobResultCountBlacklistAbs.Text = resources.GetString("labelRecentCallJobResultCountBlacklistAbs.Text");
			this.labelRecentCallJobResultCountBlacklistAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.TextAlign")));
			this.labelRecentCallJobResultCountBlacklistAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistAbs.Visible")));
			// 
			// labelRecentCallJobResultCountBlacklistCap
			// 
			this.labelRecentCallJobResultCountBlacklistCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBlacklistCap.AccessibleDescription");
			this.labelRecentCallJobResultCountBlacklistCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountBlacklistCap.AccessibleName");
			this.labelRecentCallJobResultCountBlacklistCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Anchor")));
			this.labelRecentCallJobResultCountBlacklistCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.AutoSize")));
			this.labelRecentCallJobResultCountBlacklistCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Dock")));
			this.labelRecentCallJobResultCountBlacklistCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Enabled")));
			this.labelRecentCallJobResultCountBlacklistCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Font")));
			this.labelRecentCallJobResultCountBlacklistCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Image")));
			this.labelRecentCallJobResultCountBlacklistCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.ImageAlign")));
			this.labelRecentCallJobResultCountBlacklistCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.ImageIndex")));
			this.labelRecentCallJobResultCountBlacklistCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.ImeMode")));
			this.labelRecentCallJobResultCountBlacklistCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Location")));
			this.labelRecentCallJobResultCountBlacklistCap.Name = "labelRecentCallJobResultCountBlacklistCap";
			this.labelRecentCallJobResultCountBlacklistCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.RightToLeft")));
			this.labelRecentCallJobResultCountBlacklistCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Size")));
			this.labelRecentCallJobResultCountBlacklistCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.TabIndex")));
			this.labelRecentCallJobResultCountBlacklistCap.Text = resources.GetString("labelRecentCallJobResultCountBlacklistCap.Text");
			this.labelRecentCallJobResultCountBlacklistCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.TextAlign")));
			this.labelRecentCallJobResultCountBlacklistCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBlacklistCap.Visible")));
			// 
			// labelRecentCallJobResultCountWrongNumberRelMea
			// 
			this.labelRecentCallJobResultCountWrongNumberRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountWrongNumberRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountWrongNumberRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountWrongNumberRelMea.AccessibleName");
			this.labelRecentCallJobResultCountWrongNumberRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Anchor")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.AutoSize")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Dock")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Enabled")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Font")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Image")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.ImeMode")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Location")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Name = "labelRecentCallJobResultCountWrongNumberRelMea";
			this.labelRecentCallJobResultCountWrongNumberRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Size")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.TabIndex")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Text = resources.GetString("labelRecentCallJobResultCountWrongNumberRelMea.Text");
			this.labelRecentCallJobResultCountWrongNumberRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.TextAlign")));
			this.labelRecentCallJobResultCountWrongNumberRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountWrongNumberRel
			// 
			this.labelRecentCallJobResultCountWrongNumberRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountWrongNumberRel.AccessibleDescription");
			this.labelRecentCallJobResultCountWrongNumberRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountWrongNumberRel.AccessibleName");
			this.labelRecentCallJobResultCountWrongNumberRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Anchor")));
			this.labelRecentCallJobResultCountWrongNumberRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.AutoSize")));
			this.labelRecentCallJobResultCountWrongNumberRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Dock")));
			this.labelRecentCallJobResultCountWrongNumberRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Enabled")));
			this.labelRecentCallJobResultCountWrongNumberRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Font")));
			this.labelRecentCallJobResultCountWrongNumberRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Image")));
			this.labelRecentCallJobResultCountWrongNumberRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.ImageAlign")));
			this.labelRecentCallJobResultCountWrongNumberRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.ImageIndex")));
			this.labelRecentCallJobResultCountWrongNumberRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.ImeMode")));
			this.labelRecentCallJobResultCountWrongNumberRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Location")));
			this.labelRecentCallJobResultCountWrongNumberRel.Name = "labelRecentCallJobResultCountWrongNumberRel";
			this.labelRecentCallJobResultCountWrongNumberRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.RightToLeft")));
			this.labelRecentCallJobResultCountWrongNumberRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Size")));
			this.labelRecentCallJobResultCountWrongNumberRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.TabIndex")));
			this.labelRecentCallJobResultCountWrongNumberRel.Text = resources.GetString("labelRecentCallJobResultCountWrongNumberRel.Text");
			this.labelRecentCallJobResultCountWrongNumberRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.TextAlign")));
			this.labelRecentCallJobResultCountWrongNumberRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberRel.Visible")));
			// 
			// labelRecentCallJobResultCountWrongNumberAbs
			// 
			this.labelRecentCallJobResultCountWrongNumberAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountWrongNumberAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountWrongNumberAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountWrongNumberAbs.AccessibleName");
			this.labelRecentCallJobResultCountWrongNumberAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Anchor")));
			this.labelRecentCallJobResultCountWrongNumberAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.AutoSize")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Dock")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Enabled")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Font")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Image")));
			this.labelRecentCallJobResultCountWrongNumberAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.ImageAlign")));
			this.labelRecentCallJobResultCountWrongNumberAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.ImageIndex")));
			this.labelRecentCallJobResultCountWrongNumberAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.ImeMode")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Location")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Name = "labelRecentCallJobResultCountWrongNumberAbs";
			this.labelRecentCallJobResultCountWrongNumberAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.RightToLeft")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Size")));
			this.labelRecentCallJobResultCountWrongNumberAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.TabIndex")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Text = resources.GetString("labelRecentCallJobResultCountWrongNumberAbs.Text");
			this.labelRecentCallJobResultCountWrongNumberAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.TextAlign")));
			this.labelRecentCallJobResultCountWrongNumberAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberAbs.Visible")));
			// 
			// labelRecentCallJobResultCountWrongNumberCap
			// 
			this.labelRecentCallJobResultCountWrongNumberCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountWrongNumberCap.AccessibleDescription");
			this.labelRecentCallJobResultCountWrongNumberCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountWrongNumberCap.AccessibleName");
			this.labelRecentCallJobResultCountWrongNumberCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Anchor")));
			this.labelRecentCallJobResultCountWrongNumberCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.AutoSize")));
			this.labelRecentCallJobResultCountWrongNumberCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Dock")));
			this.labelRecentCallJobResultCountWrongNumberCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Enabled")));
			this.labelRecentCallJobResultCountWrongNumberCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Font")));
			this.labelRecentCallJobResultCountWrongNumberCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Image")));
			this.labelRecentCallJobResultCountWrongNumberCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.ImageAlign")));
			this.labelRecentCallJobResultCountWrongNumberCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.ImageIndex")));
			this.labelRecentCallJobResultCountWrongNumberCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.ImeMode")));
			this.labelRecentCallJobResultCountWrongNumberCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Location")));
			this.labelRecentCallJobResultCountWrongNumberCap.Name = "labelRecentCallJobResultCountWrongNumberCap";
			this.labelRecentCallJobResultCountWrongNumberCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.RightToLeft")));
			this.labelRecentCallJobResultCountWrongNumberCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Size")));
			this.labelRecentCallJobResultCountWrongNumberCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.TabIndex")));
			this.labelRecentCallJobResultCountWrongNumberCap.Text = resources.GetString("labelRecentCallJobResultCountWrongNumberCap.Text");
			this.labelRecentCallJobResultCountWrongNumberCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.TextAlign")));
			this.labelRecentCallJobResultCountWrongNumberCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountWrongNumberCap.Visible")));
			// 
			// labelRecentCallJobResultCountNoAnswerRelMea
			// 
			this.labelRecentCallJobResultCountNoAnswerRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoAnswerRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountNoAnswerRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoAnswerRelMea.AccessibleName");
			this.labelRecentCallJobResultCountNoAnswerRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Anchor")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.AutoSize")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Dock")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Enabled")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Font")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Image")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.ImeMode")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Location")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Name = "labelRecentCallJobResultCountNoAnswerRelMea";
			this.labelRecentCallJobResultCountNoAnswerRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Size")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.TabIndex")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Text = resources.GetString("labelRecentCallJobResultCountNoAnswerRelMea.Text");
			this.labelRecentCallJobResultCountNoAnswerRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.TextAlign")));
			this.labelRecentCallJobResultCountNoAnswerRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountNoAnswerRel
			// 
			this.labelRecentCallJobResultCountNoAnswerRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoAnswerRel.AccessibleDescription");
			this.labelRecentCallJobResultCountNoAnswerRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoAnswerRel.AccessibleName");
			this.labelRecentCallJobResultCountNoAnswerRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Anchor")));
			this.labelRecentCallJobResultCountNoAnswerRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.AutoSize")));
			this.labelRecentCallJobResultCountNoAnswerRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Dock")));
			this.labelRecentCallJobResultCountNoAnswerRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Enabled")));
			this.labelRecentCallJobResultCountNoAnswerRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Font")));
			this.labelRecentCallJobResultCountNoAnswerRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Image")));
			this.labelRecentCallJobResultCountNoAnswerRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.ImageAlign")));
			this.labelRecentCallJobResultCountNoAnswerRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.ImageIndex")));
			this.labelRecentCallJobResultCountNoAnswerRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.ImeMode")));
			this.labelRecentCallJobResultCountNoAnswerRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Location")));
			this.labelRecentCallJobResultCountNoAnswerRel.Name = "labelRecentCallJobResultCountNoAnswerRel";
			this.labelRecentCallJobResultCountNoAnswerRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.RightToLeft")));
			this.labelRecentCallJobResultCountNoAnswerRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Size")));
			this.labelRecentCallJobResultCountNoAnswerRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.TabIndex")));
			this.labelRecentCallJobResultCountNoAnswerRel.Text = resources.GetString("labelRecentCallJobResultCountNoAnswerRel.Text");
			this.labelRecentCallJobResultCountNoAnswerRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.TextAlign")));
			this.labelRecentCallJobResultCountNoAnswerRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerRel.Visible")));
			// 
			// labelRecentCallJobResultCountNoAnswerAbs
			// 
			this.labelRecentCallJobResultCountNoAnswerAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoAnswerAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountNoAnswerAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoAnswerAbs.AccessibleName");
			this.labelRecentCallJobResultCountNoAnswerAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Anchor")));
			this.labelRecentCallJobResultCountNoAnswerAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.AutoSize")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Dock")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Enabled")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Font")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Image")));
			this.labelRecentCallJobResultCountNoAnswerAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.ImageAlign")));
			this.labelRecentCallJobResultCountNoAnswerAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.ImageIndex")));
			this.labelRecentCallJobResultCountNoAnswerAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.ImeMode")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Location")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Name = "labelRecentCallJobResultCountNoAnswerAbs";
			this.labelRecentCallJobResultCountNoAnswerAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.RightToLeft")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Size")));
			this.labelRecentCallJobResultCountNoAnswerAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.TabIndex")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Text = resources.GetString("labelRecentCallJobResultCountNoAnswerAbs.Text");
			this.labelRecentCallJobResultCountNoAnswerAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.TextAlign")));
			this.labelRecentCallJobResultCountNoAnswerAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerAbs.Visible")));
			// 
			// labelRecentCallJobResultCountNoAnswerCap
			// 
			this.labelRecentCallJobResultCountNoAnswerCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountNoAnswerCap.AccessibleDescription");
			this.labelRecentCallJobResultCountNoAnswerCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountNoAnswerCap.AccessibleName");
			this.labelRecentCallJobResultCountNoAnswerCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Anchor")));
			this.labelRecentCallJobResultCountNoAnswerCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.AutoSize")));
			this.labelRecentCallJobResultCountNoAnswerCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Dock")));
			this.labelRecentCallJobResultCountNoAnswerCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Enabled")));
			this.labelRecentCallJobResultCountNoAnswerCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Font")));
			this.labelRecentCallJobResultCountNoAnswerCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Image")));
			this.labelRecentCallJobResultCountNoAnswerCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.ImageAlign")));
			this.labelRecentCallJobResultCountNoAnswerCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.ImageIndex")));
			this.labelRecentCallJobResultCountNoAnswerCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.ImeMode")));
			this.labelRecentCallJobResultCountNoAnswerCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Location")));
			this.labelRecentCallJobResultCountNoAnswerCap.Name = "labelRecentCallJobResultCountNoAnswerCap";
			this.labelRecentCallJobResultCountNoAnswerCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.RightToLeft")));
			this.labelRecentCallJobResultCountNoAnswerCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Size")));
			this.labelRecentCallJobResultCountNoAnswerCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.TabIndex")));
			this.labelRecentCallJobResultCountNoAnswerCap.Text = resources.GetString("labelRecentCallJobResultCountNoAnswerCap.Text");
			this.labelRecentCallJobResultCountNoAnswerCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.TextAlign")));
			this.labelRecentCallJobResultCountNoAnswerCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountNoAnswerCap.Visible")));
			// 
			// labelRecentCallJobResultCountBusyRelMea
			// 
			this.labelRecentCallJobResultCountBusyRelMea.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBusyRelMea.AccessibleDescription");
			this.labelRecentCallJobResultCountBusyRelMea.AccessibleName = resources.GetString("labelRecentCallJobResultCountBusyRelMea.AccessibleName");
			this.labelRecentCallJobResultCountBusyRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Anchor")));
			this.labelRecentCallJobResultCountBusyRelMea.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.AutoSize")));
			this.labelRecentCallJobResultCountBusyRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Dock")));
			this.labelRecentCallJobResultCountBusyRelMea.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Enabled")));
			this.labelRecentCallJobResultCountBusyRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Font")));
			this.labelRecentCallJobResultCountBusyRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Image")));
			this.labelRecentCallJobResultCountBusyRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.ImageAlign")));
			this.labelRecentCallJobResultCountBusyRelMea.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.ImageIndex")));
			this.labelRecentCallJobResultCountBusyRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.ImeMode")));
			this.labelRecentCallJobResultCountBusyRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Location")));
			this.labelRecentCallJobResultCountBusyRelMea.Name = "labelRecentCallJobResultCountBusyRelMea";
			this.labelRecentCallJobResultCountBusyRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.RightToLeft")));
			this.labelRecentCallJobResultCountBusyRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Size")));
			this.labelRecentCallJobResultCountBusyRelMea.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.TabIndex")));
			this.labelRecentCallJobResultCountBusyRelMea.Text = resources.GetString("labelRecentCallJobResultCountBusyRelMea.Text");
			this.labelRecentCallJobResultCountBusyRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.TextAlign")));
			this.labelRecentCallJobResultCountBusyRelMea.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRelMea.Visible")));
			// 
			// labelRecentCallJobResultCountBusyRel
			// 
			this.labelRecentCallJobResultCountBusyRel.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBusyRel.AccessibleDescription");
			this.labelRecentCallJobResultCountBusyRel.AccessibleName = resources.GetString("labelRecentCallJobResultCountBusyRel.AccessibleName");
			this.labelRecentCallJobResultCountBusyRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Anchor")));
			this.labelRecentCallJobResultCountBusyRel.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRel.AutoSize")));
			this.labelRecentCallJobResultCountBusyRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Dock")));
			this.labelRecentCallJobResultCountBusyRel.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Enabled")));
			this.labelRecentCallJobResultCountBusyRel.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Font")));
			this.labelRecentCallJobResultCountBusyRel.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Image")));
			this.labelRecentCallJobResultCountBusyRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyRel.ImageAlign")));
			this.labelRecentCallJobResultCountBusyRel.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyRel.ImageIndex")));
			this.labelRecentCallJobResultCountBusyRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBusyRel.ImeMode")));
			this.labelRecentCallJobResultCountBusyRel.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Location")));
			this.labelRecentCallJobResultCountBusyRel.Name = "labelRecentCallJobResultCountBusyRel";
			this.labelRecentCallJobResultCountBusyRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBusyRel.RightToLeft")));
			this.labelRecentCallJobResultCountBusyRel.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Size")));
			this.labelRecentCallJobResultCountBusyRel.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyRel.TabIndex")));
			this.labelRecentCallJobResultCountBusyRel.Text = resources.GetString("labelRecentCallJobResultCountBusyRel.Text");
			this.labelRecentCallJobResultCountBusyRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyRel.TextAlign")));
			this.labelRecentCallJobResultCountBusyRel.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyRel.Visible")));
			// 
			// labelRecentCallJobResultCountBusyAbs
			// 
			this.labelRecentCallJobResultCountBusyAbs.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBusyAbs.AccessibleDescription");
			this.labelRecentCallJobResultCountBusyAbs.AccessibleName = resources.GetString("labelRecentCallJobResultCountBusyAbs.AccessibleName");
			this.labelRecentCallJobResultCountBusyAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Anchor")));
			this.labelRecentCallJobResultCountBusyAbs.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.AutoSize")));
			this.labelRecentCallJobResultCountBusyAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Dock")));
			this.labelRecentCallJobResultCountBusyAbs.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Enabled")));
			this.labelRecentCallJobResultCountBusyAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Font")));
			this.labelRecentCallJobResultCountBusyAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Image")));
			this.labelRecentCallJobResultCountBusyAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.ImageAlign")));
			this.labelRecentCallJobResultCountBusyAbs.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.ImageIndex")));
			this.labelRecentCallJobResultCountBusyAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.ImeMode")));
			this.labelRecentCallJobResultCountBusyAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Location")));
			this.labelRecentCallJobResultCountBusyAbs.Name = "labelRecentCallJobResultCountBusyAbs";
			this.labelRecentCallJobResultCountBusyAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.RightToLeft")));
			this.labelRecentCallJobResultCountBusyAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Size")));
			this.labelRecentCallJobResultCountBusyAbs.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.TabIndex")));
			this.labelRecentCallJobResultCountBusyAbs.Text = resources.GetString("labelRecentCallJobResultCountBusyAbs.Text");
			this.labelRecentCallJobResultCountBusyAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.TextAlign")));
			this.labelRecentCallJobResultCountBusyAbs.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyAbs.Visible")));
			// 
			// labelRecentCallJobResultCountBusyCap
			// 
			this.labelRecentCallJobResultCountBusyCap.AccessibleDescription = resources.GetString("labelRecentCallJobResultCountBusyCap.AccessibleDescription");
			this.labelRecentCallJobResultCountBusyCap.AccessibleName = resources.GetString("labelRecentCallJobResultCountBusyCap.AccessibleName");
			this.labelRecentCallJobResultCountBusyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Anchor")));
			this.labelRecentCallJobResultCountBusyCap.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyCap.AutoSize")));
			this.labelRecentCallJobResultCountBusyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Dock")));
			this.labelRecentCallJobResultCountBusyCap.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Enabled")));
			this.labelRecentCallJobResultCountBusyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Font")));
			this.labelRecentCallJobResultCountBusyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Image")));
			this.labelRecentCallJobResultCountBusyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyCap.ImageAlign")));
			this.labelRecentCallJobResultCountBusyCap.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyCap.ImageIndex")));
			this.labelRecentCallJobResultCountBusyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultCountBusyCap.ImeMode")));
			this.labelRecentCallJobResultCountBusyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Location")));
			this.labelRecentCallJobResultCountBusyCap.Name = "labelRecentCallJobResultCountBusyCap";
			this.labelRecentCallJobResultCountBusyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultCountBusyCap.RightToLeft")));
			this.labelRecentCallJobResultCountBusyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Size")));
			this.labelRecentCallJobResultCountBusyCap.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultCountBusyCap.TabIndex")));
			this.labelRecentCallJobResultCountBusyCap.Text = resources.GetString("labelRecentCallJobResultCountBusyCap.Text");
			this.labelRecentCallJobResultCountBusyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultCountBusyCap.TextAlign")));
			this.labelRecentCallJobResultCountBusyCap.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultCountBusyCap.Visible")));
			// 
			// labelRecentCallJobResultsTopLineGray
			// 
			this.labelRecentCallJobResultsTopLineGray.AccessibleDescription = resources.GetString("labelRecentCallJobResultsTopLineGray.AccessibleDescription");
			this.labelRecentCallJobResultsTopLineGray.AccessibleName = resources.GetString("labelRecentCallJobResultsTopLineGray.AccessibleName");
			this.labelRecentCallJobResultsTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Anchor")));
			this.labelRecentCallJobResultsTopLineGray.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineGray.AutoSize")));
			this.labelRecentCallJobResultsTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelRecentCallJobResultsTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Dock")));
			this.labelRecentCallJobResultsTopLineGray.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Enabled")));
			this.labelRecentCallJobResultsTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Font")));
			this.labelRecentCallJobResultsTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentCallJobResultsTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Image")));
			this.labelRecentCallJobResultsTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsTopLineGray.ImageAlign")));
			this.labelRecentCallJobResultsTopLineGray.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsTopLineGray.ImageIndex")));
			this.labelRecentCallJobResultsTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsTopLineGray.ImeMode")));
			this.labelRecentCallJobResultsTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Location")));
			this.labelRecentCallJobResultsTopLineGray.Name = "labelRecentCallJobResultsTopLineGray";
			this.labelRecentCallJobResultsTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsTopLineGray.RightToLeft")));
			this.labelRecentCallJobResultsTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Size")));
			this.labelRecentCallJobResultsTopLineGray.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsTopLineGray.TabIndex")));
			this.labelRecentCallJobResultsTopLineGray.Text = resources.GetString("labelRecentCallJobResultsTopLineGray.Text");
			this.labelRecentCallJobResultsTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsTopLineGray.TextAlign")));
			this.labelRecentCallJobResultsTopLineGray.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineGray.Visible")));
			// 
			// labelRecentCallJobResultsTopLineWhite
			// 
			this.labelRecentCallJobResultsTopLineWhite.AccessibleDescription = resources.GetString("labelRecentCallJobResultsTopLineWhite.AccessibleDescription");
			this.labelRecentCallJobResultsTopLineWhite.AccessibleName = resources.GetString("labelRecentCallJobResultsTopLineWhite.AccessibleName");
			this.labelRecentCallJobResultsTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Anchor")));
			this.labelRecentCallJobResultsTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.AutoSize")));
			this.labelRecentCallJobResultsTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelRecentCallJobResultsTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Dock")));
			this.labelRecentCallJobResultsTopLineWhite.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Enabled")));
			this.labelRecentCallJobResultsTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Font")));
			this.labelRecentCallJobResultsTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelRecentCallJobResultsTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Image")));
			this.labelRecentCallJobResultsTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.ImageAlign")));
			this.labelRecentCallJobResultsTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.ImageIndex")));
			this.labelRecentCallJobResultsTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.ImeMode")));
			this.labelRecentCallJobResultsTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Location")));
			this.labelRecentCallJobResultsTopLineWhite.Name = "labelRecentCallJobResultsTopLineWhite";
			this.labelRecentCallJobResultsTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.RightToLeft")));
			this.labelRecentCallJobResultsTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Size")));
			this.labelRecentCallJobResultsTopLineWhite.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.TabIndex")));
			this.labelRecentCallJobResultsTopLineWhite.Text = resources.GetString("labelRecentCallJobResultsTopLineWhite.Text");
			this.labelRecentCallJobResultsTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.TextAlign")));
			this.labelRecentCallJobResultsTopLineWhite.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsTopLineWhite.Visible")));
			// 
			// labelRecentCallJobResultsRowRate
			// 
			this.labelRecentCallJobResultsRowRate.AccessibleDescription = resources.GetString("labelRecentCallJobResultsRowRate.AccessibleDescription");
			this.labelRecentCallJobResultsRowRate.AccessibleName = resources.GetString("labelRecentCallJobResultsRowRate.AccessibleName");
			this.labelRecentCallJobResultsRowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsRowRate.Anchor")));
			this.labelRecentCallJobResultsRowRate.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsRowRate.AutoSize")));
			this.labelRecentCallJobResultsRowRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsRowRate.Dock")));
			this.labelRecentCallJobResultsRowRate.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsRowRate.Enabled")));
			this.labelRecentCallJobResultsRowRate.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsRowRate.Font")));
			this.labelRecentCallJobResultsRowRate.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsRowRate.Image")));
			this.labelRecentCallJobResultsRowRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowRate.ImageAlign")));
			this.labelRecentCallJobResultsRowRate.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowRate.ImageIndex")));
			this.labelRecentCallJobResultsRowRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsRowRate.ImeMode")));
			this.labelRecentCallJobResultsRowRate.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsRowRate.Location")));
			this.labelRecentCallJobResultsRowRate.Name = "labelRecentCallJobResultsRowRate";
			this.labelRecentCallJobResultsRowRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsRowRate.RightToLeft")));
			this.labelRecentCallJobResultsRowRate.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsRowRate.Size")));
			this.labelRecentCallJobResultsRowRate.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowRate.TabIndex")));
			this.labelRecentCallJobResultsRowRate.Text = resources.GetString("labelRecentCallJobResultsRowRate.Text");
			this.labelRecentCallJobResultsRowRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowRate.TextAlign")));
			this.labelRecentCallJobResultsRowRate.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsRowRate.Visible")));
			// 
			// labelRecentCallJobResultsRowCount
			// 
			this.labelRecentCallJobResultsRowCount.AccessibleDescription = resources.GetString("labelRecentCallJobResultsRowCount.AccessibleDescription");
			this.labelRecentCallJobResultsRowCount.AccessibleName = resources.GetString("labelRecentCallJobResultsRowCount.AccessibleName");
			this.labelRecentCallJobResultsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsRowCount.Anchor")));
			this.labelRecentCallJobResultsRowCount.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsRowCount.AutoSize")));
			this.labelRecentCallJobResultsRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsRowCount.Dock")));
			this.labelRecentCallJobResultsRowCount.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsRowCount.Enabled")));
			this.labelRecentCallJobResultsRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsRowCount.Font")));
			this.labelRecentCallJobResultsRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsRowCount.Image")));
			this.labelRecentCallJobResultsRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowCount.ImageAlign")));
			this.labelRecentCallJobResultsRowCount.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowCount.ImageIndex")));
			this.labelRecentCallJobResultsRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsRowCount.ImeMode")));
			this.labelRecentCallJobResultsRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsRowCount.Location")));
			this.labelRecentCallJobResultsRowCount.Name = "labelRecentCallJobResultsRowCount";
			this.labelRecentCallJobResultsRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsRowCount.RightToLeft")));
			this.labelRecentCallJobResultsRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsRowCount.Size")));
			this.labelRecentCallJobResultsRowCount.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowCount.TabIndex")));
			this.labelRecentCallJobResultsRowCount.Text = resources.GetString("labelRecentCallJobResultsRowCount.Text");
			this.labelRecentCallJobResultsRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowCount.TextAlign")));
			this.labelRecentCallJobResultsRowCount.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsRowCount.Visible")));
			// 
			// labelRecentCallJobResultsRowResult
			// 
			this.labelRecentCallJobResultsRowResult.AccessibleDescription = resources.GetString("labelRecentCallJobResultsRowResult.AccessibleDescription");
			this.labelRecentCallJobResultsRowResult.AccessibleName = resources.GetString("labelRecentCallJobResultsRowResult.AccessibleName");
			this.labelRecentCallJobResultsRowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelRecentCallJobResultsRowResult.Anchor")));
			this.labelRecentCallJobResultsRowResult.AutoSize = ((bool)(resources.GetObject("labelRecentCallJobResultsRowResult.AutoSize")));
			this.labelRecentCallJobResultsRowResult.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelRecentCallJobResultsRowResult.Dock")));
			this.labelRecentCallJobResultsRowResult.Enabled = ((bool)(resources.GetObject("labelRecentCallJobResultsRowResult.Enabled")));
			this.labelRecentCallJobResultsRowResult.Font = ((System.Drawing.Font)(resources.GetObject("labelRecentCallJobResultsRowResult.Font")));
			this.labelRecentCallJobResultsRowResult.Image = ((System.Drawing.Image)(resources.GetObject("labelRecentCallJobResultsRowResult.Image")));
			this.labelRecentCallJobResultsRowResult.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowResult.ImageAlign")));
			this.labelRecentCallJobResultsRowResult.ImageIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowResult.ImageIndex")));
			this.labelRecentCallJobResultsRowResult.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelRecentCallJobResultsRowResult.ImeMode")));
			this.labelRecentCallJobResultsRowResult.Location = ((System.Drawing.Point)(resources.GetObject("labelRecentCallJobResultsRowResult.Location")));
			this.labelRecentCallJobResultsRowResult.Name = "labelRecentCallJobResultsRowResult";
			this.labelRecentCallJobResultsRowResult.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelRecentCallJobResultsRowResult.RightToLeft")));
			this.labelRecentCallJobResultsRowResult.Size = ((System.Drawing.Size)(resources.GetObject("labelRecentCallJobResultsRowResult.Size")));
			this.labelRecentCallJobResultsRowResult.TabIndex = ((int)(resources.GetObject("labelRecentCallJobResultsRowResult.TabIndex")));
			this.labelRecentCallJobResultsRowResult.Text = resources.GetString("labelRecentCallJobResultsRowResult.Text");
			this.labelRecentCallJobResultsRowResult.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelRecentCallJobResultsRowResult.TextAlign")));
			this.labelRecentCallJobResultsRowResult.Visible = ((bool)(resources.GetObject("labelRecentCallJobResultsRowResult.Visible")));
			// 
			// CampaignViewCallJobsRecentStatistics
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxChartRecentCallJobResultCountRel);
			this.Controls.Add(this.groupBoxChartRecentCallJobResultCountAbs);
			this.Controls.Add(this.groupBoxPieRecentCallJobResultCount);
			this.Controls.Add(this.groupBoxRecentCallJobResults);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewCallJobsRecentStatistics";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxChartRecentCallJobResultCountRel.ResumeLayout(false);
			this.panelChartRecentCallJobResultCountRel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartRecentCallJobResultCountRel)).EndInit();
			this.groupBoxChartRecentCallJobResultCountAbs.ResumeLayout(false);
			this.panelChartRecentCallJobResultCountAbs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartRecentCallJobResultCountAbs)).EndInit();
			this.groupBoxPieRecentCallJobResultCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pieRecentCallJobResultCount)).EndInit();
			this.groupBoxRecentCallJobResults.ResumeLayout(false);
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
			int processedCallJobCountRcn =
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy) +
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer) +
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist) +
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied) +
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure) +
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload) +
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax) +
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine) +
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost) +
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough);
			labelRecentCallJobResultCountBusyAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy).ToString();
			labelRecentCallJobResultCountBusyRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.Busy),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountNoAnswerAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer).ToString();
			labelRecentCallJobResultCountNoAnswerRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountWrongNumberAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber).ToString();
			labelRecentCallJobResultCountWrongNumberRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountBlacklistAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist).ToString();
			labelRecentCallJobResultCountBlacklistRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountRouteDeniedAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied).ToString();
			labelRecentCallJobResultCountRouteDeniedRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountPSTNFailureAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure).ToString();
			labelRecentCallJobResultCountPSTNFailureRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountTelcoOverloadAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload).ToString();
			labelRecentCallJobResultCountTelcoOverloadRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountACRAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR).ToString();
			labelRecentCallJobResultCountACRRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.ACR),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountFaxAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax).ToString();
			labelRecentCallJobResultCountFaxRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.Fax),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountAnsweringMachineAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine).ToString();
			labelRecentCallJobResultCountAnsweringMachineRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountNoInterestAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest).ToString();
			labelRecentCallJobResultCountNoInterestRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountLostAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost).ToString();
			labelRecentCallJobResultCountLostRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.Lost),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountPutThroughAbs.Text =
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough).ToString();
			labelRecentCallJobResultCountPutThroughRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough),
				processedCallJobCountRcn).ToString();
			labelRecentCallJobResultCountAbs.Text = processedCallJobCountRcn.ToString();

			// Tortengrafik aktualisieren
			pieRecentCallJobResultCount.Slices[0].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy);
			pieRecentCallJobResultCount.Slices[1].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer);
			pieRecentCallJobResultCount.Slices[2].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber);
			pieRecentCallJobResultCount.Slices[3].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist);
			pieRecentCallJobResultCount.Slices[4].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied);
			pieRecentCallJobResultCount.Slices[5].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure);
			pieRecentCallJobResultCount.Slices[6].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload);
			pieRecentCallJobResultCount.Slices[7].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR);
			pieRecentCallJobResultCount.Slices[8].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax);
			pieRecentCallJobResultCount.Slices[9].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine);
			pieRecentCallJobResultCount.Slices[10].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest);
			pieRecentCallJobResultCount.Slices[11].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost);
			pieRecentCallJobResultCount.Slices[12].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough);

			// Verlaufsgrafiken aktualisieren
			chartRecentCallJobResultCountAbs.DataCollection =
				campaign.RecentCallJobResultCountAbsData;
			chartRecentCallJobResultCountRel.DataCollection =
				campaign.RecentCallJobResultCountRelData;
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
