using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Outbound Gesamtstatistik einer Kampagne.
	/// </summary>
	public class CampaignViewCallJobsTotalStatistics : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxTotalCallJobResults;
		private System.Windows.Forms.Label labelTotalCallJobResultsRowResult;
		private System.Windows.Forms.Label labelTotalCallJobResultsRowCount;
		private System.Windows.Forms.Label labelTotalCallJobResultsRowRate;
		private System.Windows.Forms.Label labelTotalCallJobResultsTopLineWhite;
		private System.Windows.Forms.Label labelTotalCallJobResultsTopLineGray;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBusyCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBusyAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBusyRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBusyRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoAnswerCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoAnswerAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoAnswerRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoAnswerRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountWrongNumberCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountWrongNumberAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountWrongNumberRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountWrongNumberRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBlacklistCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBlacklistAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBlacklistRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountBlacklistRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountRouteDeniedCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountRouteDeniedAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountRouteDeniedRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountRouteDeniedRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPSTNFailureCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPSTNFailureAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPSTNFailureRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPSTNFailureRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountTelcoOverloadCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountTelcoOverloadAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountTelcoOverloadRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountTelcoOverloadRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountACRCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountACRAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountACRRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountACRRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountFaxCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountFaxAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountFaxRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountFaxRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountAnsweringMachineCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountAnsweringMachineAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountAnsweringMachineRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountAnsweringMachineRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoInterestCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoInterestAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoInterestRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountNoInterestRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountLostCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountLostAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountLostRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountLostRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPutThroughCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPutThroughAbs;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPutThroughRel;
		private System.Windows.Forms.Label labelTotalCallJobResultCountPutThroughRelMea;
		private System.Windows.Forms.Label labelTotalCallJobResultsBottomLineWhite;
		private System.Windows.Forms.Label labelTotalCallJobResultsBottomLineGray;
		private System.Windows.Forms.Label labelTotalCallJobResultCountCap;
		private System.Windows.Forms.Label labelTotalCallJobResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxPieTotalCallJobResultCount;
		private itCampus.bb.Graph.Pie.Pie pieTotalCallJobResultCount;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewCallJobsTotalStatistics()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Intervall Tortengrafik einstellen
			pieTotalCallJobResultCount.RefreshInterval = Settings.Instance.RefreshInterval * 1000;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewCallJobsTotalStatistics));
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
			this.groupBoxPieTotalCallJobResultCount = new System.Windows.Forms.GroupBox();
			this.pieTotalCallJobResultCount = new itCampus.bb.Graph.Pie.Pie();
			this.groupBoxTotalCallJobResults = new System.Windows.Forms.GroupBox();
			this.labelTotalCallJobResultCountAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsBottomLineGray = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsBottomLineWhite = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPutThroughRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPutThroughRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPutThroughAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPutThroughCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountLostRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountLostRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountLostAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountLostCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoInterestRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoInterestRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoInterestAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoInterestCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountAnsweringMachineRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountAnsweringMachineRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountAnsweringMachineAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountAnsweringMachineCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountFaxRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountFaxRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountFaxAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountFaxCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountACRRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountACRRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountACRAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountACRCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountTelcoOverloadRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountTelcoOverloadRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountTelcoOverloadAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountTelcoOverloadCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPSTNFailureRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPSTNFailureRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPSTNFailureAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountPSTNFailureCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountRouteDeniedRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountRouteDeniedRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountRouteDeniedAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountRouteDeniedCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBlacklistRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBlacklistRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBlacklistAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBlacklistCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountWrongNumberRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountWrongNumberRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountWrongNumberAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountWrongNumberCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoAnswerRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoAnswerRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoAnswerAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountNoAnswerCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBusyRelMea = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBusyRel = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBusyAbs = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultCountBusyCap = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsTopLineGray = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsTopLineWhite = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsRowRate = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsRowCount = new System.Windows.Forms.Label();
			this.labelTotalCallJobResultsRowResult = new System.Windows.Forms.Label();
			this.groupBoxPieTotalCallJobResultCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pieTotalCallJobResultCount)).BeginInit();
			this.groupBoxTotalCallJobResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxPieTotalCallJobResultCount
			// 
			this.groupBoxPieTotalCallJobResultCount.AccessibleDescription = resources.GetString("groupBoxPieTotalCallJobResultCount.AccessibleDescription");
			this.groupBoxPieTotalCallJobResultCount.AccessibleName = resources.GetString("groupBoxPieTotalCallJobResultCount.AccessibleName");
			this.groupBoxPieTotalCallJobResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Anchor")));
			this.groupBoxPieTotalCallJobResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPieTotalCallJobResultCount.BackgroundImage")));
			this.groupBoxPieTotalCallJobResultCount.Controls.Add(this.pieTotalCallJobResultCount);
			this.groupBoxPieTotalCallJobResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Dock")));
			this.groupBoxPieTotalCallJobResultCount.Enabled = ((bool)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Enabled")));
			this.groupBoxPieTotalCallJobResultCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Font")));
			this.groupBoxPieTotalCallJobResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxPieTotalCallJobResultCount.ImeMode")));
			this.groupBoxPieTotalCallJobResultCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Location")));
			this.groupBoxPieTotalCallJobResultCount.Name = "groupBoxPieTotalCallJobResultCount";
			this.groupBoxPieTotalCallJobResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxPieTotalCallJobResultCount.RightToLeft")));
			this.groupBoxPieTotalCallJobResultCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Size")));
			this.groupBoxPieTotalCallJobResultCount.TabIndex = ((int)(resources.GetObject("groupBoxPieTotalCallJobResultCount.TabIndex")));
			this.groupBoxPieTotalCallJobResultCount.TabStop = false;
			this.groupBoxPieTotalCallJobResultCount.Text = resources.GetString("groupBoxPieTotalCallJobResultCount.Text");
			this.groupBoxPieTotalCallJobResultCount.Visible = ((bool)(resources.GetObject("groupBoxPieTotalCallJobResultCount.Visible")));
			// 
			// pieTotalCallJobResultCount
			// 
			this.pieTotalCallJobResultCount.AccessibleDescription = resources.GetString("pieTotalCallJobResultCount.AccessibleDescription");
			this.pieTotalCallJobResultCount.AccessibleName = resources.GetString("pieTotalCallJobResultCount.AccessibleName");
			this.pieTotalCallJobResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pieTotalCallJobResultCount.Anchor")));
			this.pieTotalCallJobResultCount.AutoScroll = ((bool)(resources.GetObject("pieTotalCallJobResultCount.AutoScroll")));
			this.pieTotalCallJobResultCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pieTotalCallJobResultCount.AutoScrollMargin")));
			this.pieTotalCallJobResultCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pieTotalCallJobResultCount.AutoScrollMinSize")));
			this.pieTotalCallJobResultCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("pieTotalCallJobResultCount.BackgroundColor")));
			this.pieTotalCallJobResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieTotalCallJobResultCount.BackgroundImage")));
			this.pieTotalCallJobResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pieTotalCallJobResultCount.Dock")));
			this.pieTotalCallJobResultCount.Enabled = ((bool)(resources.GetObject("pieTotalCallJobResultCount.Enabled")));
			this.pieTotalCallJobResultCount.Font = ((System.Drawing.Font)(resources.GetObject("pieTotalCallJobResultCount.Font")));
			this.pieTotalCallJobResultCount.HorizontalSpace = ((int)(resources.GetObject("pieTotalCallJobResultCount.HorizontalSpace")));
			this.pieTotalCallJobResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pieTotalCallJobResultCount.ImeMode")));
			this.pieTotalCallJobResultCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("pieTotalCallJobResultCount.LegendAlignment")));
			this.pieTotalCallJobResultCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("pieTotalCallJobResultCount.LegendColor")));
			this.pieTotalCallJobResultCount.Location = ((System.Drawing.Point)(resources.GetObject("pieTotalCallJobResultCount.Location")));
			this.pieTotalCallJobResultCount.Name = "pieTotalCallJobResultCount";
			this.pieTotalCallJobResultCount.Painting = ((bool)(resources.GetObject("pieTotalCallJobResultCount.Painting")));
			this.pieTotalCallJobResultCount.RefreshInterval = ((int)(resources.GetObject("pieTotalCallJobResultCount.RefreshInterval")));
			this.pieTotalCallJobResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pieTotalCallJobResultCount.RightToLeft")));
			this.pieTotalCallJobResultCount.Size = ((System.Drawing.Size)(resources.GetObject("pieTotalCallJobResultCount.Size")));
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
			this.pieTotalCallJobResultCount.Slices.AddRange(new itCampus.bb.Graph.Pie.Slice[] {
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
			this.pieTotalCallJobResultCount.TabIndex = ((int)(resources.GetObject("pieTotalCallJobResultCount.TabIndex")));
			this.pieTotalCallJobResultCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("pieTotalCallJobResultCount.ValueColor")));
			this.pieTotalCallJobResultCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("pieTotalCallJobResultCount.ValueType")));
			this.pieTotalCallJobResultCount.VerticalSpace = ((int)(resources.GetObject("pieTotalCallJobResultCount.VerticalSpace")));
			this.pieTotalCallJobResultCount.Visible = ((bool)(resources.GetObject("pieTotalCallJobResultCount.Visible")));
			// 
			// groupBoxTotalCallJobResults
			// 
			this.groupBoxTotalCallJobResults.AccessibleDescription = resources.GetString("groupBoxTotalCallJobResults.AccessibleDescription");
			this.groupBoxTotalCallJobResults.AccessibleName = resources.GetString("groupBoxTotalCallJobResults.AccessibleName");
			this.groupBoxTotalCallJobResults.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxTotalCallJobResults.Anchor")));
			this.groupBoxTotalCallJobResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxTotalCallJobResults.BackgroundImage")));
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsBottomLineGray);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsBottomLineWhite);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPutThroughRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPutThroughRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPutThroughAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPutThroughCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountLostRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountLostRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountLostAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountLostCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoInterestRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoInterestRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoInterestAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoInterestCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountAnsweringMachineRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountAnsweringMachineRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountAnsweringMachineAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountAnsweringMachineCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountFaxRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountFaxRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountFaxAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountFaxCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountACRRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountACRRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountACRAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountACRCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountTelcoOverloadRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountTelcoOverloadRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountTelcoOverloadAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountTelcoOverloadCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPSTNFailureRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPSTNFailureRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPSTNFailureAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountPSTNFailureCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountRouteDeniedRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountRouteDeniedRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountRouteDeniedAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountRouteDeniedCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBlacklistRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBlacklistRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBlacklistAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBlacklistCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountWrongNumberRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountWrongNumberRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountWrongNumberAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountWrongNumberCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoAnswerRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoAnswerRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoAnswerAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountNoAnswerCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBusyRelMea);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBusyRel);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBusyAbs);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultCountBusyCap);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsTopLineGray);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsTopLineWhite);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsRowRate);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsRowCount);
			this.groupBoxTotalCallJobResults.Controls.Add(this.labelTotalCallJobResultsRowResult);
			this.groupBoxTotalCallJobResults.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxTotalCallJobResults.Dock")));
			this.groupBoxTotalCallJobResults.Enabled = ((bool)(resources.GetObject("groupBoxTotalCallJobResults.Enabled")));
			this.groupBoxTotalCallJobResults.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxTotalCallJobResults.Font")));
			this.groupBoxTotalCallJobResults.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxTotalCallJobResults.ImeMode")));
			this.groupBoxTotalCallJobResults.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxTotalCallJobResults.Location")));
			this.groupBoxTotalCallJobResults.Name = "groupBoxTotalCallJobResults";
			this.groupBoxTotalCallJobResults.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxTotalCallJobResults.RightToLeft")));
			this.groupBoxTotalCallJobResults.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxTotalCallJobResults.Size")));
			this.groupBoxTotalCallJobResults.TabIndex = ((int)(resources.GetObject("groupBoxTotalCallJobResults.TabIndex")));
			this.groupBoxTotalCallJobResults.TabStop = false;
			this.groupBoxTotalCallJobResults.Text = resources.GetString("groupBoxTotalCallJobResults.Text");
			this.groupBoxTotalCallJobResults.Visible = ((bool)(resources.GetObject("groupBoxTotalCallJobResults.Visible")));
			// 
			// labelTotalCallJobResultCountAbs
			// 
			this.labelTotalCallJobResultCountAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountAbs.AccessibleName");
			this.labelTotalCallJobResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountAbs.Anchor")));
			this.labelTotalCallJobResultCountAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountAbs.AutoSize")));
			this.labelTotalCallJobResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountAbs.Dock")));
			this.labelTotalCallJobResultCountAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountAbs.Enabled")));
			this.labelTotalCallJobResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountAbs.Font")));
			this.labelTotalCallJobResultCountAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountAbs.Image")));
			this.labelTotalCallJobResultCountAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAbs.ImageAlign")));
			this.labelTotalCallJobResultCountAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAbs.ImageIndex")));
			this.labelTotalCallJobResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountAbs.ImeMode")));
			this.labelTotalCallJobResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountAbs.Location")));
			this.labelTotalCallJobResultCountAbs.Name = "labelTotalCallJobResultCountAbs";
			this.labelTotalCallJobResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountAbs.RightToLeft")));
			this.labelTotalCallJobResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountAbs.Size")));
			this.labelTotalCallJobResultCountAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAbs.TabIndex")));
			this.labelTotalCallJobResultCountAbs.Text = resources.GetString("labelTotalCallJobResultCountAbs.Text");
			this.labelTotalCallJobResultCountAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAbs.TextAlign")));
			this.labelTotalCallJobResultCountAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountAbs.Visible")));
			// 
			// labelTotalCallJobResultCountCap
			// 
			this.labelTotalCallJobResultCountCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountCap.AccessibleDescription");
			this.labelTotalCallJobResultCountCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountCap.AccessibleName");
			this.labelTotalCallJobResultCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountCap.Anchor")));
			this.labelTotalCallJobResultCountCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountCap.AutoSize")));
			this.labelTotalCallJobResultCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountCap.Dock")));
			this.labelTotalCallJobResultCountCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountCap.Enabled")));
			this.labelTotalCallJobResultCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountCap.Font")));
			this.labelTotalCallJobResultCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountCap.Image")));
			this.labelTotalCallJobResultCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountCap.ImageAlign")));
			this.labelTotalCallJobResultCountCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountCap.ImageIndex")));
			this.labelTotalCallJobResultCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountCap.ImeMode")));
			this.labelTotalCallJobResultCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountCap.Location")));
			this.labelTotalCallJobResultCountCap.Name = "labelTotalCallJobResultCountCap";
			this.labelTotalCallJobResultCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountCap.RightToLeft")));
			this.labelTotalCallJobResultCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountCap.Size")));
			this.labelTotalCallJobResultCountCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountCap.TabIndex")));
			this.labelTotalCallJobResultCountCap.Text = resources.GetString("labelTotalCallJobResultCountCap.Text");
			this.labelTotalCallJobResultCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountCap.TextAlign")));
			this.labelTotalCallJobResultCountCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountCap.Visible")));
			// 
			// labelTotalCallJobResultsBottomLineGray
			// 
			this.labelTotalCallJobResultsBottomLineGray.AccessibleDescription = resources.GetString("labelTotalCallJobResultsBottomLineGray.AccessibleDescription");
			this.labelTotalCallJobResultsBottomLineGray.AccessibleName = resources.GetString("labelTotalCallJobResultsBottomLineGray.AccessibleName");
			this.labelTotalCallJobResultsBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Anchor")));
			this.labelTotalCallJobResultsBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.AutoSize")));
			this.labelTotalCallJobResultsBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelTotalCallJobResultsBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Dock")));
			this.labelTotalCallJobResultsBottomLineGray.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Enabled")));
			this.labelTotalCallJobResultsBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Font")));
			this.labelTotalCallJobResultsBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalCallJobResultsBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Image")));
			this.labelTotalCallJobResultsBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.ImageAlign")));
			this.labelTotalCallJobResultsBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.ImageIndex")));
			this.labelTotalCallJobResultsBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.ImeMode")));
			this.labelTotalCallJobResultsBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Location")));
			this.labelTotalCallJobResultsBottomLineGray.Name = "labelTotalCallJobResultsBottomLineGray";
			this.labelTotalCallJobResultsBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.RightToLeft")));
			this.labelTotalCallJobResultsBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Size")));
			this.labelTotalCallJobResultsBottomLineGray.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.TabIndex")));
			this.labelTotalCallJobResultsBottomLineGray.Text = resources.GetString("labelTotalCallJobResultsBottomLineGray.Text");
			this.labelTotalCallJobResultsBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.TextAlign")));
			this.labelTotalCallJobResultsBottomLineGray.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineGray.Visible")));
			// 
			// labelTotalCallJobResultsBottomLineWhite
			// 
			this.labelTotalCallJobResultsBottomLineWhite.AccessibleDescription = resources.GetString("labelTotalCallJobResultsBottomLineWhite.AccessibleDescription");
			this.labelTotalCallJobResultsBottomLineWhite.AccessibleName = resources.GetString("labelTotalCallJobResultsBottomLineWhite.AccessibleName");
			this.labelTotalCallJobResultsBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Anchor")));
			this.labelTotalCallJobResultsBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.AutoSize")));
			this.labelTotalCallJobResultsBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelTotalCallJobResultsBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Dock")));
			this.labelTotalCallJobResultsBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Enabled")));
			this.labelTotalCallJobResultsBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Font")));
			this.labelTotalCallJobResultsBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalCallJobResultsBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Image")));
			this.labelTotalCallJobResultsBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.ImageAlign")));
			this.labelTotalCallJobResultsBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.ImageIndex")));
			this.labelTotalCallJobResultsBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.ImeMode")));
			this.labelTotalCallJobResultsBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Location")));
			this.labelTotalCallJobResultsBottomLineWhite.Name = "labelTotalCallJobResultsBottomLineWhite";
			this.labelTotalCallJobResultsBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.RightToLeft")));
			this.labelTotalCallJobResultsBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Size")));
			this.labelTotalCallJobResultsBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.TabIndex")));
			this.labelTotalCallJobResultsBottomLineWhite.Text = resources.GetString("labelTotalCallJobResultsBottomLineWhite.Text");
			this.labelTotalCallJobResultsBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.TextAlign")));
			this.labelTotalCallJobResultsBottomLineWhite.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsBottomLineWhite.Visible")));
			// 
			// labelTotalCallJobResultCountPutThroughRelMea
			// 
			this.labelTotalCallJobResultCountPutThroughRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPutThroughRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountPutThroughRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountPutThroughRelMea.AccessibleName");
			this.labelTotalCallJobResultCountPutThroughRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Anchor")));
			this.labelTotalCallJobResultCountPutThroughRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.AutoSize")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Dock")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Enabled")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Font")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Image")));
			this.labelTotalCallJobResultCountPutThroughRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountPutThroughRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountPutThroughRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.ImeMode")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Location")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Name = "labelTotalCallJobResultCountPutThroughRelMea";
			this.labelTotalCallJobResultCountPutThroughRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Size")));
			this.labelTotalCallJobResultCountPutThroughRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.TabIndex")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Text = resources.GetString("labelTotalCallJobResultCountPutThroughRelMea.Text");
			this.labelTotalCallJobResultCountPutThroughRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.TextAlign")));
			this.labelTotalCallJobResultCountPutThroughRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountPutThroughRel
			// 
			this.labelTotalCallJobResultCountPutThroughRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPutThroughRel.AccessibleDescription");
			this.labelTotalCallJobResultCountPutThroughRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountPutThroughRel.AccessibleName");
			this.labelTotalCallJobResultCountPutThroughRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Anchor")));
			this.labelTotalCallJobResultCountPutThroughRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.AutoSize")));
			this.labelTotalCallJobResultCountPutThroughRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Dock")));
			this.labelTotalCallJobResultCountPutThroughRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Enabled")));
			this.labelTotalCallJobResultCountPutThroughRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Font")));
			this.labelTotalCallJobResultCountPutThroughRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Image")));
			this.labelTotalCallJobResultCountPutThroughRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.ImageAlign")));
			this.labelTotalCallJobResultCountPutThroughRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.ImageIndex")));
			this.labelTotalCallJobResultCountPutThroughRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.ImeMode")));
			this.labelTotalCallJobResultCountPutThroughRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Location")));
			this.labelTotalCallJobResultCountPutThroughRel.Name = "labelTotalCallJobResultCountPutThroughRel";
			this.labelTotalCallJobResultCountPutThroughRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.RightToLeft")));
			this.labelTotalCallJobResultCountPutThroughRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Size")));
			this.labelTotalCallJobResultCountPutThroughRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.TabIndex")));
			this.labelTotalCallJobResultCountPutThroughRel.Text = resources.GetString("labelTotalCallJobResultCountPutThroughRel.Text");
			this.labelTotalCallJobResultCountPutThroughRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.TextAlign")));
			this.labelTotalCallJobResultCountPutThroughRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughRel.Visible")));
			// 
			// labelTotalCallJobResultCountPutThroughAbs
			// 
			this.labelTotalCallJobResultCountPutThroughAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPutThroughAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountPutThroughAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountPutThroughAbs.AccessibleName");
			this.labelTotalCallJobResultCountPutThroughAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Anchor")));
			this.labelTotalCallJobResultCountPutThroughAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.AutoSize")));
			this.labelTotalCallJobResultCountPutThroughAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Dock")));
			this.labelTotalCallJobResultCountPutThroughAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Enabled")));
			this.labelTotalCallJobResultCountPutThroughAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Font")));
			this.labelTotalCallJobResultCountPutThroughAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Image")));
			this.labelTotalCallJobResultCountPutThroughAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.ImageAlign")));
			this.labelTotalCallJobResultCountPutThroughAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.ImageIndex")));
			this.labelTotalCallJobResultCountPutThroughAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.ImeMode")));
			this.labelTotalCallJobResultCountPutThroughAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Location")));
			this.labelTotalCallJobResultCountPutThroughAbs.Name = "labelTotalCallJobResultCountPutThroughAbs";
			this.labelTotalCallJobResultCountPutThroughAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.RightToLeft")));
			this.labelTotalCallJobResultCountPutThroughAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Size")));
			this.labelTotalCallJobResultCountPutThroughAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.TabIndex")));
			this.labelTotalCallJobResultCountPutThroughAbs.Text = resources.GetString("labelTotalCallJobResultCountPutThroughAbs.Text");
			this.labelTotalCallJobResultCountPutThroughAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.TextAlign")));
			this.labelTotalCallJobResultCountPutThroughAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughAbs.Visible")));
			// 
			// labelTotalCallJobResultCountPutThroughCap
			// 
			this.labelTotalCallJobResultCountPutThroughCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPutThroughCap.AccessibleDescription");
			this.labelTotalCallJobResultCountPutThroughCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountPutThroughCap.AccessibleName");
			this.labelTotalCallJobResultCountPutThroughCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Anchor")));
			this.labelTotalCallJobResultCountPutThroughCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.AutoSize")));
			this.labelTotalCallJobResultCountPutThroughCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Dock")));
			this.labelTotalCallJobResultCountPutThroughCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Enabled")));
			this.labelTotalCallJobResultCountPutThroughCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Font")));
			this.labelTotalCallJobResultCountPutThroughCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Image")));
			this.labelTotalCallJobResultCountPutThroughCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.ImageAlign")));
			this.labelTotalCallJobResultCountPutThroughCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.ImageIndex")));
			this.labelTotalCallJobResultCountPutThroughCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.ImeMode")));
			this.labelTotalCallJobResultCountPutThroughCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Location")));
			this.labelTotalCallJobResultCountPutThroughCap.Name = "labelTotalCallJobResultCountPutThroughCap";
			this.labelTotalCallJobResultCountPutThroughCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.RightToLeft")));
			this.labelTotalCallJobResultCountPutThroughCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Size")));
			this.labelTotalCallJobResultCountPutThroughCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.TabIndex")));
			this.labelTotalCallJobResultCountPutThroughCap.Text = resources.GetString("labelTotalCallJobResultCountPutThroughCap.Text");
			this.labelTotalCallJobResultCountPutThroughCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.TextAlign")));
			this.labelTotalCallJobResultCountPutThroughCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPutThroughCap.Visible")));
			// 
			// labelTotalCallJobResultCountLostRelMea
			// 
			this.labelTotalCallJobResultCountLostRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountLostRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountLostRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountLostRelMea.AccessibleName");
			this.labelTotalCallJobResultCountLostRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Anchor")));
			this.labelTotalCallJobResultCountLostRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.AutoSize")));
			this.labelTotalCallJobResultCountLostRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Dock")));
			this.labelTotalCallJobResultCountLostRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Enabled")));
			this.labelTotalCallJobResultCountLostRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Font")));
			this.labelTotalCallJobResultCountLostRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Image")));
			this.labelTotalCallJobResultCountLostRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountLostRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountLostRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.ImeMode")));
			this.labelTotalCallJobResultCountLostRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Location")));
			this.labelTotalCallJobResultCountLostRelMea.Name = "labelTotalCallJobResultCountLostRelMea";
			this.labelTotalCallJobResultCountLostRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountLostRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Size")));
			this.labelTotalCallJobResultCountLostRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.TabIndex")));
			this.labelTotalCallJobResultCountLostRelMea.Text = resources.GetString("labelTotalCallJobResultCountLostRelMea.Text");
			this.labelTotalCallJobResultCountLostRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.TextAlign")));
			this.labelTotalCallJobResultCountLostRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountLostRel
			// 
			this.labelTotalCallJobResultCountLostRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountLostRel.AccessibleDescription");
			this.labelTotalCallJobResultCountLostRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountLostRel.AccessibleName");
			this.labelTotalCallJobResultCountLostRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountLostRel.Anchor")));
			this.labelTotalCallJobResultCountLostRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRel.AutoSize")));
			this.labelTotalCallJobResultCountLostRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountLostRel.Dock")));
			this.labelTotalCallJobResultCountLostRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRel.Enabled")));
			this.labelTotalCallJobResultCountLostRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountLostRel.Font")));
			this.labelTotalCallJobResultCountLostRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountLostRel.Image")));
			this.labelTotalCallJobResultCountLostRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostRel.ImageAlign")));
			this.labelTotalCallJobResultCountLostRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostRel.ImageIndex")));
			this.labelTotalCallJobResultCountLostRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountLostRel.ImeMode")));
			this.labelTotalCallJobResultCountLostRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountLostRel.Location")));
			this.labelTotalCallJobResultCountLostRel.Name = "labelTotalCallJobResultCountLostRel";
			this.labelTotalCallJobResultCountLostRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountLostRel.RightToLeft")));
			this.labelTotalCallJobResultCountLostRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountLostRel.Size")));
			this.labelTotalCallJobResultCountLostRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostRel.TabIndex")));
			this.labelTotalCallJobResultCountLostRel.Text = resources.GetString("labelTotalCallJobResultCountLostRel.Text");
			this.labelTotalCallJobResultCountLostRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostRel.TextAlign")));
			this.labelTotalCallJobResultCountLostRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostRel.Visible")));
			// 
			// labelTotalCallJobResultCountLostAbs
			// 
			this.labelTotalCallJobResultCountLostAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountLostAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountLostAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountLostAbs.AccessibleName");
			this.labelTotalCallJobResultCountLostAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Anchor")));
			this.labelTotalCallJobResultCountLostAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostAbs.AutoSize")));
			this.labelTotalCallJobResultCountLostAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Dock")));
			this.labelTotalCallJobResultCountLostAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Enabled")));
			this.labelTotalCallJobResultCountLostAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Font")));
			this.labelTotalCallJobResultCountLostAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Image")));
			this.labelTotalCallJobResultCountLostAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostAbs.ImageAlign")));
			this.labelTotalCallJobResultCountLostAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostAbs.ImageIndex")));
			this.labelTotalCallJobResultCountLostAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountLostAbs.ImeMode")));
			this.labelTotalCallJobResultCountLostAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Location")));
			this.labelTotalCallJobResultCountLostAbs.Name = "labelTotalCallJobResultCountLostAbs";
			this.labelTotalCallJobResultCountLostAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountLostAbs.RightToLeft")));
			this.labelTotalCallJobResultCountLostAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Size")));
			this.labelTotalCallJobResultCountLostAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostAbs.TabIndex")));
			this.labelTotalCallJobResultCountLostAbs.Text = resources.GetString("labelTotalCallJobResultCountLostAbs.Text");
			this.labelTotalCallJobResultCountLostAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostAbs.TextAlign")));
			this.labelTotalCallJobResultCountLostAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostAbs.Visible")));
			// 
			// labelTotalCallJobResultCountLostCap
			// 
			this.labelTotalCallJobResultCountLostCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountLostCap.AccessibleDescription");
			this.labelTotalCallJobResultCountLostCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountLostCap.AccessibleName");
			this.labelTotalCallJobResultCountLostCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountLostCap.Anchor")));
			this.labelTotalCallJobResultCountLostCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostCap.AutoSize")));
			this.labelTotalCallJobResultCountLostCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountLostCap.Dock")));
			this.labelTotalCallJobResultCountLostCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostCap.Enabled")));
			this.labelTotalCallJobResultCountLostCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountLostCap.Font")));
			this.labelTotalCallJobResultCountLostCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountLostCap.Image")));
			this.labelTotalCallJobResultCountLostCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostCap.ImageAlign")));
			this.labelTotalCallJobResultCountLostCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostCap.ImageIndex")));
			this.labelTotalCallJobResultCountLostCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountLostCap.ImeMode")));
			this.labelTotalCallJobResultCountLostCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountLostCap.Location")));
			this.labelTotalCallJobResultCountLostCap.Name = "labelTotalCallJobResultCountLostCap";
			this.labelTotalCallJobResultCountLostCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountLostCap.RightToLeft")));
			this.labelTotalCallJobResultCountLostCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountLostCap.Size")));
			this.labelTotalCallJobResultCountLostCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountLostCap.TabIndex")));
			this.labelTotalCallJobResultCountLostCap.Text = resources.GetString("labelTotalCallJobResultCountLostCap.Text");
			this.labelTotalCallJobResultCountLostCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountLostCap.TextAlign")));
			this.labelTotalCallJobResultCountLostCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountLostCap.Visible")));
			// 
			// labelTotalCallJobResultCountNoInterestRelMea
			// 
			this.labelTotalCallJobResultCountNoInterestRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoInterestRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountNoInterestRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoInterestRelMea.AccessibleName");
			this.labelTotalCallJobResultCountNoInterestRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Anchor")));
			this.labelTotalCallJobResultCountNoInterestRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.AutoSize")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Dock")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Enabled")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Font")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Image")));
			this.labelTotalCallJobResultCountNoInterestRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountNoInterestRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountNoInterestRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.ImeMode")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Location")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Name = "labelTotalCallJobResultCountNoInterestRelMea";
			this.labelTotalCallJobResultCountNoInterestRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Size")));
			this.labelTotalCallJobResultCountNoInterestRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.TabIndex")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Text = resources.GetString("labelTotalCallJobResultCountNoInterestRelMea.Text");
			this.labelTotalCallJobResultCountNoInterestRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.TextAlign")));
			this.labelTotalCallJobResultCountNoInterestRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountNoInterestRel
			// 
			this.labelTotalCallJobResultCountNoInterestRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoInterestRel.AccessibleDescription");
			this.labelTotalCallJobResultCountNoInterestRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoInterestRel.AccessibleName");
			this.labelTotalCallJobResultCountNoInterestRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Anchor")));
			this.labelTotalCallJobResultCountNoInterestRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.AutoSize")));
			this.labelTotalCallJobResultCountNoInterestRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Dock")));
			this.labelTotalCallJobResultCountNoInterestRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Enabled")));
			this.labelTotalCallJobResultCountNoInterestRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Font")));
			this.labelTotalCallJobResultCountNoInterestRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Image")));
			this.labelTotalCallJobResultCountNoInterestRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.ImageAlign")));
			this.labelTotalCallJobResultCountNoInterestRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.ImageIndex")));
			this.labelTotalCallJobResultCountNoInterestRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.ImeMode")));
			this.labelTotalCallJobResultCountNoInterestRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Location")));
			this.labelTotalCallJobResultCountNoInterestRel.Name = "labelTotalCallJobResultCountNoInterestRel";
			this.labelTotalCallJobResultCountNoInterestRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.RightToLeft")));
			this.labelTotalCallJobResultCountNoInterestRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Size")));
			this.labelTotalCallJobResultCountNoInterestRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.TabIndex")));
			this.labelTotalCallJobResultCountNoInterestRel.Text = resources.GetString("labelTotalCallJobResultCountNoInterestRel.Text");
			this.labelTotalCallJobResultCountNoInterestRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.TextAlign")));
			this.labelTotalCallJobResultCountNoInterestRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestRel.Visible")));
			// 
			// labelTotalCallJobResultCountNoInterestAbs
			// 
			this.labelTotalCallJobResultCountNoInterestAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoInterestAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountNoInterestAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoInterestAbs.AccessibleName");
			this.labelTotalCallJobResultCountNoInterestAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Anchor")));
			this.labelTotalCallJobResultCountNoInterestAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.AutoSize")));
			this.labelTotalCallJobResultCountNoInterestAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Dock")));
			this.labelTotalCallJobResultCountNoInterestAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Enabled")));
			this.labelTotalCallJobResultCountNoInterestAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Font")));
			this.labelTotalCallJobResultCountNoInterestAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Image")));
			this.labelTotalCallJobResultCountNoInterestAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.ImageAlign")));
			this.labelTotalCallJobResultCountNoInterestAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.ImageIndex")));
			this.labelTotalCallJobResultCountNoInterestAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.ImeMode")));
			this.labelTotalCallJobResultCountNoInterestAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Location")));
			this.labelTotalCallJobResultCountNoInterestAbs.Name = "labelTotalCallJobResultCountNoInterestAbs";
			this.labelTotalCallJobResultCountNoInterestAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.RightToLeft")));
			this.labelTotalCallJobResultCountNoInterestAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Size")));
			this.labelTotalCallJobResultCountNoInterestAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.TabIndex")));
			this.labelTotalCallJobResultCountNoInterestAbs.Text = resources.GetString("labelTotalCallJobResultCountNoInterestAbs.Text");
			this.labelTotalCallJobResultCountNoInterestAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.TextAlign")));
			this.labelTotalCallJobResultCountNoInterestAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestAbs.Visible")));
			// 
			// labelTotalCallJobResultCountNoInterestCap
			// 
			this.labelTotalCallJobResultCountNoInterestCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoInterestCap.AccessibleDescription");
			this.labelTotalCallJobResultCountNoInterestCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoInterestCap.AccessibleName");
			this.labelTotalCallJobResultCountNoInterestCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Anchor")));
			this.labelTotalCallJobResultCountNoInterestCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.AutoSize")));
			this.labelTotalCallJobResultCountNoInterestCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Dock")));
			this.labelTotalCallJobResultCountNoInterestCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Enabled")));
			this.labelTotalCallJobResultCountNoInterestCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Font")));
			this.labelTotalCallJobResultCountNoInterestCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Image")));
			this.labelTotalCallJobResultCountNoInterestCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.ImageAlign")));
			this.labelTotalCallJobResultCountNoInterestCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.ImageIndex")));
			this.labelTotalCallJobResultCountNoInterestCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.ImeMode")));
			this.labelTotalCallJobResultCountNoInterestCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Location")));
			this.labelTotalCallJobResultCountNoInterestCap.Name = "labelTotalCallJobResultCountNoInterestCap";
			this.labelTotalCallJobResultCountNoInterestCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.RightToLeft")));
			this.labelTotalCallJobResultCountNoInterestCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Size")));
			this.labelTotalCallJobResultCountNoInterestCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.TabIndex")));
			this.labelTotalCallJobResultCountNoInterestCap.Text = resources.GetString("labelTotalCallJobResultCountNoInterestCap.Text");
			this.labelTotalCallJobResultCountNoInterestCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.TextAlign")));
			this.labelTotalCallJobResultCountNoInterestCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoInterestCap.Visible")));
			// 
			// labelTotalCallJobResultCountAnsweringMachineRelMea
			// 
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRelMea.AccessibleName");
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Anchor")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.AutoSize")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Dock")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Enabled")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Font")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Image")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.ImeMode")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Location")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Name = "labelTotalCallJobResultCountAnsweringMachineRelMea";
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Size")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.TabIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Text = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRelMea.Text");
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.TextAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountAnsweringMachineRel
			// 
			this.labelTotalCallJobResultCountAnsweringMachineRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRel.AccessibleDescription");
			this.labelTotalCallJobResultCountAnsweringMachineRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRel.AccessibleName");
			this.labelTotalCallJobResultCountAnsweringMachineRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Anchor")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.AutoSize")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Dock")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Enabled")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Font")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Image")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.ImageAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.ImageIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.ImeMode")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Location")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Name = "labelTotalCallJobResultCountAnsweringMachineRel";
			this.labelTotalCallJobResultCountAnsweringMachineRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.RightToLeft")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Size")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.TabIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Text = resources.GetString("labelTotalCallJobResultCountAnsweringMachineRel.Text");
			this.labelTotalCallJobResultCountAnsweringMachineRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.TextAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineRel.Visible")));
			// 
			// labelTotalCallJobResultCountAnsweringMachineAbs
			// 
			this.labelTotalCallJobResultCountAnsweringMachineAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountAnsweringMachineAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountAnsweringMachineAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountAnsweringMachineAbs.AccessibleName");
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Anchor")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.AutoSize")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Dock")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Enabled")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Font")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Image")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.ImageAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.ImageIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.ImeMode")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Location")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Name = "labelTotalCallJobResultCountAnsweringMachineAbs";
			this.labelTotalCallJobResultCountAnsweringMachineAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.RightToLeft")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Size")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.TabIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Text = resources.GetString("labelTotalCallJobResultCountAnsweringMachineAbs.Text");
			this.labelTotalCallJobResultCountAnsweringMachineAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.TextAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineAbs.Visible")));
			// 
			// labelTotalCallJobResultCountAnsweringMachineCap
			// 
			this.labelTotalCallJobResultCountAnsweringMachineCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountAnsweringMachineCap.AccessibleDescription");
			this.labelTotalCallJobResultCountAnsweringMachineCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountAnsweringMachineCap.AccessibleName");
			this.labelTotalCallJobResultCountAnsweringMachineCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Anchor")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.AutoSize")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Dock")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Enabled")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Font")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Image")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.ImageAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.ImageIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.ImeMode")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Location")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Name = "labelTotalCallJobResultCountAnsweringMachineCap";
			this.labelTotalCallJobResultCountAnsweringMachineCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.RightToLeft")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Size")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.TabIndex")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Text = resources.GetString("labelTotalCallJobResultCountAnsweringMachineCap.Text");
			this.labelTotalCallJobResultCountAnsweringMachineCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.TextAlign")));
			this.labelTotalCallJobResultCountAnsweringMachineCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountAnsweringMachineCap.Visible")));
			// 
			// labelTotalCallJobResultCountFaxRelMea
			// 
			this.labelTotalCallJobResultCountFaxRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountFaxRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountFaxRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountFaxRelMea.AccessibleName");
			this.labelTotalCallJobResultCountFaxRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Anchor")));
			this.labelTotalCallJobResultCountFaxRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.AutoSize")));
			this.labelTotalCallJobResultCountFaxRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Dock")));
			this.labelTotalCallJobResultCountFaxRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Enabled")));
			this.labelTotalCallJobResultCountFaxRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Font")));
			this.labelTotalCallJobResultCountFaxRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Image")));
			this.labelTotalCallJobResultCountFaxRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountFaxRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountFaxRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.ImeMode")));
			this.labelTotalCallJobResultCountFaxRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Location")));
			this.labelTotalCallJobResultCountFaxRelMea.Name = "labelTotalCallJobResultCountFaxRelMea";
			this.labelTotalCallJobResultCountFaxRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountFaxRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Size")));
			this.labelTotalCallJobResultCountFaxRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.TabIndex")));
			this.labelTotalCallJobResultCountFaxRelMea.Text = resources.GetString("labelTotalCallJobResultCountFaxRelMea.Text");
			this.labelTotalCallJobResultCountFaxRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.TextAlign")));
			this.labelTotalCallJobResultCountFaxRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountFaxRel
			// 
			this.labelTotalCallJobResultCountFaxRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountFaxRel.AccessibleDescription");
			this.labelTotalCallJobResultCountFaxRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountFaxRel.AccessibleName");
			this.labelTotalCallJobResultCountFaxRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Anchor")));
			this.labelTotalCallJobResultCountFaxRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRel.AutoSize")));
			this.labelTotalCallJobResultCountFaxRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Dock")));
			this.labelTotalCallJobResultCountFaxRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Enabled")));
			this.labelTotalCallJobResultCountFaxRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Font")));
			this.labelTotalCallJobResultCountFaxRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Image")));
			this.labelTotalCallJobResultCountFaxRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxRel.ImageAlign")));
			this.labelTotalCallJobResultCountFaxRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxRel.ImageIndex")));
			this.labelTotalCallJobResultCountFaxRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountFaxRel.ImeMode")));
			this.labelTotalCallJobResultCountFaxRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Location")));
			this.labelTotalCallJobResultCountFaxRel.Name = "labelTotalCallJobResultCountFaxRel";
			this.labelTotalCallJobResultCountFaxRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountFaxRel.RightToLeft")));
			this.labelTotalCallJobResultCountFaxRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Size")));
			this.labelTotalCallJobResultCountFaxRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxRel.TabIndex")));
			this.labelTotalCallJobResultCountFaxRel.Text = resources.GetString("labelTotalCallJobResultCountFaxRel.Text");
			this.labelTotalCallJobResultCountFaxRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxRel.TextAlign")));
			this.labelTotalCallJobResultCountFaxRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxRel.Visible")));
			// 
			// labelTotalCallJobResultCountFaxAbs
			// 
			this.labelTotalCallJobResultCountFaxAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountFaxAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountFaxAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountFaxAbs.AccessibleName");
			this.labelTotalCallJobResultCountFaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Anchor")));
			this.labelTotalCallJobResultCountFaxAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.AutoSize")));
			this.labelTotalCallJobResultCountFaxAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Dock")));
			this.labelTotalCallJobResultCountFaxAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Enabled")));
			this.labelTotalCallJobResultCountFaxAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Font")));
			this.labelTotalCallJobResultCountFaxAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Image")));
			this.labelTotalCallJobResultCountFaxAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.ImageAlign")));
			this.labelTotalCallJobResultCountFaxAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.ImageIndex")));
			this.labelTotalCallJobResultCountFaxAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.ImeMode")));
			this.labelTotalCallJobResultCountFaxAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Location")));
			this.labelTotalCallJobResultCountFaxAbs.Name = "labelTotalCallJobResultCountFaxAbs";
			this.labelTotalCallJobResultCountFaxAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.RightToLeft")));
			this.labelTotalCallJobResultCountFaxAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Size")));
			this.labelTotalCallJobResultCountFaxAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.TabIndex")));
			this.labelTotalCallJobResultCountFaxAbs.Text = resources.GetString("labelTotalCallJobResultCountFaxAbs.Text");
			this.labelTotalCallJobResultCountFaxAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.TextAlign")));
			this.labelTotalCallJobResultCountFaxAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxAbs.Visible")));
			// 
			// labelTotalCallJobResultCountFaxCap
			// 
			this.labelTotalCallJobResultCountFaxCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountFaxCap.AccessibleDescription");
			this.labelTotalCallJobResultCountFaxCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountFaxCap.AccessibleName");
			this.labelTotalCallJobResultCountFaxCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Anchor")));
			this.labelTotalCallJobResultCountFaxCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxCap.AutoSize")));
			this.labelTotalCallJobResultCountFaxCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Dock")));
			this.labelTotalCallJobResultCountFaxCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Enabled")));
			this.labelTotalCallJobResultCountFaxCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Font")));
			this.labelTotalCallJobResultCountFaxCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Image")));
			this.labelTotalCallJobResultCountFaxCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxCap.ImageAlign")));
			this.labelTotalCallJobResultCountFaxCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxCap.ImageIndex")));
			this.labelTotalCallJobResultCountFaxCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountFaxCap.ImeMode")));
			this.labelTotalCallJobResultCountFaxCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Location")));
			this.labelTotalCallJobResultCountFaxCap.Name = "labelTotalCallJobResultCountFaxCap";
			this.labelTotalCallJobResultCountFaxCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountFaxCap.RightToLeft")));
			this.labelTotalCallJobResultCountFaxCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Size")));
			this.labelTotalCallJobResultCountFaxCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountFaxCap.TabIndex")));
			this.labelTotalCallJobResultCountFaxCap.Text = resources.GetString("labelTotalCallJobResultCountFaxCap.Text");
			this.labelTotalCallJobResultCountFaxCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountFaxCap.TextAlign")));
			this.labelTotalCallJobResultCountFaxCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountFaxCap.Visible")));
			// 
			// labelTotalCallJobResultCountACRRelMea
			// 
			this.labelTotalCallJobResultCountACRRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountACRRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountACRRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountACRRelMea.AccessibleName");
			this.labelTotalCallJobResultCountACRRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Anchor")));
			this.labelTotalCallJobResultCountACRRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.AutoSize")));
			this.labelTotalCallJobResultCountACRRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Dock")));
			this.labelTotalCallJobResultCountACRRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Enabled")));
			this.labelTotalCallJobResultCountACRRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Font")));
			this.labelTotalCallJobResultCountACRRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Image")));
			this.labelTotalCallJobResultCountACRRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountACRRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountACRRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.ImeMode")));
			this.labelTotalCallJobResultCountACRRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Location")));
			this.labelTotalCallJobResultCountACRRelMea.Name = "labelTotalCallJobResultCountACRRelMea";
			this.labelTotalCallJobResultCountACRRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountACRRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Size")));
			this.labelTotalCallJobResultCountACRRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.TabIndex")));
			this.labelTotalCallJobResultCountACRRelMea.Text = resources.GetString("labelTotalCallJobResultCountACRRelMea.Text");
			this.labelTotalCallJobResultCountACRRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.TextAlign")));
			this.labelTotalCallJobResultCountACRRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountACRRel
			// 
			this.labelTotalCallJobResultCountACRRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountACRRel.AccessibleDescription");
			this.labelTotalCallJobResultCountACRRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountACRRel.AccessibleName");
			this.labelTotalCallJobResultCountACRRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountACRRel.Anchor")));
			this.labelTotalCallJobResultCountACRRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRel.AutoSize")));
			this.labelTotalCallJobResultCountACRRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountACRRel.Dock")));
			this.labelTotalCallJobResultCountACRRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRel.Enabled")));
			this.labelTotalCallJobResultCountACRRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountACRRel.Font")));
			this.labelTotalCallJobResultCountACRRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountACRRel.Image")));
			this.labelTotalCallJobResultCountACRRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRRel.ImageAlign")));
			this.labelTotalCallJobResultCountACRRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRRel.ImageIndex")));
			this.labelTotalCallJobResultCountACRRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountACRRel.ImeMode")));
			this.labelTotalCallJobResultCountACRRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountACRRel.Location")));
			this.labelTotalCallJobResultCountACRRel.Name = "labelTotalCallJobResultCountACRRel";
			this.labelTotalCallJobResultCountACRRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountACRRel.RightToLeft")));
			this.labelTotalCallJobResultCountACRRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountACRRel.Size")));
			this.labelTotalCallJobResultCountACRRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRRel.TabIndex")));
			this.labelTotalCallJobResultCountACRRel.Text = resources.GetString("labelTotalCallJobResultCountACRRel.Text");
			this.labelTotalCallJobResultCountACRRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRRel.TextAlign")));
			this.labelTotalCallJobResultCountACRRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRRel.Visible")));
			// 
			// labelTotalCallJobResultCountACRAbs
			// 
			this.labelTotalCallJobResultCountACRAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountACRAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountACRAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountACRAbs.AccessibleName");
			this.labelTotalCallJobResultCountACRAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Anchor")));
			this.labelTotalCallJobResultCountACRAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRAbs.AutoSize")));
			this.labelTotalCallJobResultCountACRAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Dock")));
			this.labelTotalCallJobResultCountACRAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Enabled")));
			this.labelTotalCallJobResultCountACRAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Font")));
			this.labelTotalCallJobResultCountACRAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Image")));
			this.labelTotalCallJobResultCountACRAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRAbs.ImageAlign")));
			this.labelTotalCallJobResultCountACRAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRAbs.ImageIndex")));
			this.labelTotalCallJobResultCountACRAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountACRAbs.ImeMode")));
			this.labelTotalCallJobResultCountACRAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Location")));
			this.labelTotalCallJobResultCountACRAbs.Name = "labelTotalCallJobResultCountACRAbs";
			this.labelTotalCallJobResultCountACRAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountACRAbs.RightToLeft")));
			this.labelTotalCallJobResultCountACRAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Size")));
			this.labelTotalCallJobResultCountACRAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRAbs.TabIndex")));
			this.labelTotalCallJobResultCountACRAbs.Text = resources.GetString("labelTotalCallJobResultCountACRAbs.Text");
			this.labelTotalCallJobResultCountACRAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRAbs.TextAlign")));
			this.labelTotalCallJobResultCountACRAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRAbs.Visible")));
			// 
			// labelTotalCallJobResultCountACRCap
			// 
			this.labelTotalCallJobResultCountACRCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountACRCap.AccessibleDescription");
			this.labelTotalCallJobResultCountACRCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountACRCap.AccessibleName");
			this.labelTotalCallJobResultCountACRCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountACRCap.Anchor")));
			this.labelTotalCallJobResultCountACRCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRCap.AutoSize")));
			this.labelTotalCallJobResultCountACRCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountACRCap.Dock")));
			this.labelTotalCallJobResultCountACRCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRCap.Enabled")));
			this.labelTotalCallJobResultCountACRCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountACRCap.Font")));
			this.labelTotalCallJobResultCountACRCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountACRCap.Image")));
			this.labelTotalCallJobResultCountACRCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRCap.ImageAlign")));
			this.labelTotalCallJobResultCountACRCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRCap.ImageIndex")));
			this.labelTotalCallJobResultCountACRCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountACRCap.ImeMode")));
			this.labelTotalCallJobResultCountACRCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountACRCap.Location")));
			this.labelTotalCallJobResultCountACRCap.Name = "labelTotalCallJobResultCountACRCap";
			this.labelTotalCallJobResultCountACRCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountACRCap.RightToLeft")));
			this.labelTotalCallJobResultCountACRCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountACRCap.Size")));
			this.labelTotalCallJobResultCountACRCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountACRCap.TabIndex")));
			this.labelTotalCallJobResultCountACRCap.Text = resources.GetString("labelTotalCallJobResultCountACRCap.Text");
			this.labelTotalCallJobResultCountACRCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountACRCap.TextAlign")));
			this.labelTotalCallJobResultCountACRCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountACRCap.Visible")));
			// 
			// labelTotalCallJobResultCountTelcoOverloadRelMea
			// 
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRelMea.AccessibleName");
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Anchor")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.AutoSize")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Dock")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Enabled")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Font")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Image")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.ImeMode")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Location")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Name = "labelTotalCallJobResultCountTelcoOverloadRelMea";
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Size")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.TabIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Text = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRelMea.Text");
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.TextAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountTelcoOverloadRel
			// 
			this.labelTotalCallJobResultCountTelcoOverloadRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRel.AccessibleDescription");
			this.labelTotalCallJobResultCountTelcoOverloadRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRel.AccessibleName");
			this.labelTotalCallJobResultCountTelcoOverloadRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Anchor")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.AutoSize")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Dock")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Enabled")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Font")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Image")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.ImageAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.ImageIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.ImeMode")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Location")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Name = "labelTotalCallJobResultCountTelcoOverloadRel";
			this.labelTotalCallJobResultCountTelcoOverloadRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.RightToLeft")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Size")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.TabIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Text = resources.GetString("labelTotalCallJobResultCountTelcoOverloadRel.Text");
			this.labelTotalCallJobResultCountTelcoOverloadRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.TextAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadRel.Visible")));
			// 
			// labelTotalCallJobResultCountTelcoOverloadAbs
			// 
			this.labelTotalCallJobResultCountTelcoOverloadAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountTelcoOverloadAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountTelcoOverloadAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountTelcoOverloadAbs.AccessibleName");
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Anchor")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.AutoSize")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Dock")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Enabled")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Font")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Image")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.ImageAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.ImageIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.ImeMode")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Location")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Name = "labelTotalCallJobResultCountTelcoOverloadAbs";
			this.labelTotalCallJobResultCountTelcoOverloadAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.RightToLeft")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Size")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.TabIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Text = resources.GetString("labelTotalCallJobResultCountTelcoOverloadAbs.Text");
			this.labelTotalCallJobResultCountTelcoOverloadAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.TextAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadAbs.Visible")));
			// 
			// labelTotalCallJobResultCountTelcoOverloadCap
			// 
			this.labelTotalCallJobResultCountTelcoOverloadCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountTelcoOverloadCap.AccessibleDescription");
			this.labelTotalCallJobResultCountTelcoOverloadCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountTelcoOverloadCap.AccessibleName");
			this.labelTotalCallJobResultCountTelcoOverloadCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Anchor")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.AutoSize")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Dock")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Enabled")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Font")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Image")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.ImageAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.ImageIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.ImeMode")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Location")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Name = "labelTotalCallJobResultCountTelcoOverloadCap";
			this.labelTotalCallJobResultCountTelcoOverloadCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.RightToLeft")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Size")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.TabIndex")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Text = resources.GetString("labelTotalCallJobResultCountTelcoOverloadCap.Text");
			this.labelTotalCallJobResultCountTelcoOverloadCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.TextAlign")));
			this.labelTotalCallJobResultCountTelcoOverloadCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountTelcoOverloadCap.Visible")));
			// 
			// labelTotalCallJobResultCountPSTNFailureRelMea
			// 
			this.labelTotalCallJobResultCountPSTNFailureRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPSTNFailureRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountPSTNFailureRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountPSTNFailureRelMea.AccessibleName");
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Anchor")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.AutoSize")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Dock")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Enabled")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Font")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Image")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.ImeMode")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Location")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Name = "labelTotalCallJobResultCountPSTNFailureRelMea";
			this.labelTotalCallJobResultCountPSTNFailureRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Size")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.TabIndex")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Text = resources.GetString("labelTotalCallJobResultCountPSTNFailureRelMea.Text");
			this.labelTotalCallJobResultCountPSTNFailureRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.TextAlign")));
			this.labelTotalCallJobResultCountPSTNFailureRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountPSTNFailureRel
			// 
			this.labelTotalCallJobResultCountPSTNFailureRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPSTNFailureRel.AccessibleDescription");
			this.labelTotalCallJobResultCountPSTNFailureRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountPSTNFailureRel.AccessibleName");
			this.labelTotalCallJobResultCountPSTNFailureRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Anchor")));
			this.labelTotalCallJobResultCountPSTNFailureRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.AutoSize")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Dock")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Enabled")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Font")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Image")));
			this.labelTotalCallJobResultCountPSTNFailureRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.ImageAlign")));
			this.labelTotalCallJobResultCountPSTNFailureRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.ImageIndex")));
			this.labelTotalCallJobResultCountPSTNFailureRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.ImeMode")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Location")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Name = "labelTotalCallJobResultCountPSTNFailureRel";
			this.labelTotalCallJobResultCountPSTNFailureRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.RightToLeft")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Size")));
			this.labelTotalCallJobResultCountPSTNFailureRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.TabIndex")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Text = resources.GetString("labelTotalCallJobResultCountPSTNFailureRel.Text");
			this.labelTotalCallJobResultCountPSTNFailureRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.TextAlign")));
			this.labelTotalCallJobResultCountPSTNFailureRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureRel.Visible")));
			// 
			// labelTotalCallJobResultCountPSTNFailureAbs
			// 
			this.labelTotalCallJobResultCountPSTNFailureAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPSTNFailureAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountPSTNFailureAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountPSTNFailureAbs.AccessibleName");
			this.labelTotalCallJobResultCountPSTNFailureAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Anchor")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.AutoSize")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Dock")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Enabled")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Font")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Image")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.ImageAlign")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.ImageIndex")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.ImeMode")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Location")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Name = "labelTotalCallJobResultCountPSTNFailureAbs";
			this.labelTotalCallJobResultCountPSTNFailureAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.RightToLeft")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Size")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.TabIndex")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Text = resources.GetString("labelTotalCallJobResultCountPSTNFailureAbs.Text");
			this.labelTotalCallJobResultCountPSTNFailureAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.TextAlign")));
			this.labelTotalCallJobResultCountPSTNFailureAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureAbs.Visible")));
			// 
			// labelTotalCallJobResultCountPSTNFailureCap
			// 
			this.labelTotalCallJobResultCountPSTNFailureCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountPSTNFailureCap.AccessibleDescription");
			this.labelTotalCallJobResultCountPSTNFailureCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountPSTNFailureCap.AccessibleName");
			this.labelTotalCallJobResultCountPSTNFailureCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Anchor")));
			this.labelTotalCallJobResultCountPSTNFailureCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.AutoSize")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Dock")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Enabled")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Font")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Image")));
			this.labelTotalCallJobResultCountPSTNFailureCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.ImageAlign")));
			this.labelTotalCallJobResultCountPSTNFailureCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.ImageIndex")));
			this.labelTotalCallJobResultCountPSTNFailureCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.ImeMode")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Location")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Name = "labelTotalCallJobResultCountPSTNFailureCap";
			this.labelTotalCallJobResultCountPSTNFailureCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.RightToLeft")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Size")));
			this.labelTotalCallJobResultCountPSTNFailureCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.TabIndex")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Text = resources.GetString("labelTotalCallJobResultCountPSTNFailureCap.Text");
			this.labelTotalCallJobResultCountPSTNFailureCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.TextAlign")));
			this.labelTotalCallJobResultCountPSTNFailureCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountPSTNFailureCap.Visible")));
			// 
			// labelTotalCallJobResultCountRouteDeniedRelMea
			// 
			this.labelTotalCallJobResultCountRouteDeniedRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountRouteDeniedRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountRouteDeniedRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountRouteDeniedRelMea.AccessibleName");
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Anchor")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.AutoSize")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Dock")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Enabled")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Font")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Image")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.ImeMode")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Location")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Name = "labelTotalCallJobResultCountRouteDeniedRelMea";
			this.labelTotalCallJobResultCountRouteDeniedRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Size")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.TabIndex")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Text = resources.GetString("labelTotalCallJobResultCountRouteDeniedRelMea.Text");
			this.labelTotalCallJobResultCountRouteDeniedRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.TextAlign")));
			this.labelTotalCallJobResultCountRouteDeniedRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountRouteDeniedRel
			// 
			this.labelTotalCallJobResultCountRouteDeniedRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountRouteDeniedRel.AccessibleDescription");
			this.labelTotalCallJobResultCountRouteDeniedRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountRouteDeniedRel.AccessibleName");
			this.labelTotalCallJobResultCountRouteDeniedRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Anchor")));
			this.labelTotalCallJobResultCountRouteDeniedRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.AutoSize")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Dock")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Enabled")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Font")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Image")));
			this.labelTotalCallJobResultCountRouteDeniedRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.ImageAlign")));
			this.labelTotalCallJobResultCountRouteDeniedRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.ImageIndex")));
			this.labelTotalCallJobResultCountRouteDeniedRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.ImeMode")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Location")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Name = "labelTotalCallJobResultCountRouteDeniedRel";
			this.labelTotalCallJobResultCountRouteDeniedRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.RightToLeft")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Size")));
			this.labelTotalCallJobResultCountRouteDeniedRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.TabIndex")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Text = resources.GetString("labelTotalCallJobResultCountRouteDeniedRel.Text");
			this.labelTotalCallJobResultCountRouteDeniedRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.TextAlign")));
			this.labelTotalCallJobResultCountRouteDeniedRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedRel.Visible")));
			// 
			// labelTotalCallJobResultCountRouteDeniedAbs
			// 
			this.labelTotalCallJobResultCountRouteDeniedAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountRouteDeniedAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountRouteDeniedAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountRouteDeniedAbs.AccessibleName");
			this.labelTotalCallJobResultCountRouteDeniedAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Anchor")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.AutoSize")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Dock")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Enabled")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Font")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Image")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.ImageAlign")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.ImageIndex")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.ImeMode")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Location")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Name = "labelTotalCallJobResultCountRouteDeniedAbs";
			this.labelTotalCallJobResultCountRouteDeniedAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.RightToLeft")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Size")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.TabIndex")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Text = resources.GetString("labelTotalCallJobResultCountRouteDeniedAbs.Text");
			this.labelTotalCallJobResultCountRouteDeniedAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.TextAlign")));
			this.labelTotalCallJobResultCountRouteDeniedAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedAbs.Visible")));
			// 
			// labelTotalCallJobResultCountRouteDeniedCap
			// 
			this.labelTotalCallJobResultCountRouteDeniedCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountRouteDeniedCap.AccessibleDescription");
			this.labelTotalCallJobResultCountRouteDeniedCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountRouteDeniedCap.AccessibleName");
			this.labelTotalCallJobResultCountRouteDeniedCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Anchor")));
			this.labelTotalCallJobResultCountRouteDeniedCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.AutoSize")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Dock")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Enabled")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Font")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Image")));
			this.labelTotalCallJobResultCountRouteDeniedCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.ImageAlign")));
			this.labelTotalCallJobResultCountRouteDeniedCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.ImageIndex")));
			this.labelTotalCallJobResultCountRouteDeniedCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.ImeMode")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Location")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Name = "labelTotalCallJobResultCountRouteDeniedCap";
			this.labelTotalCallJobResultCountRouteDeniedCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.RightToLeft")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Size")));
			this.labelTotalCallJobResultCountRouteDeniedCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.TabIndex")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Text = resources.GetString("labelTotalCallJobResultCountRouteDeniedCap.Text");
			this.labelTotalCallJobResultCountRouteDeniedCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.TextAlign")));
			this.labelTotalCallJobResultCountRouteDeniedCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountRouteDeniedCap.Visible")));
			// 
			// labelTotalCallJobResultCountBlacklistRelMea
			// 
			this.labelTotalCallJobResultCountBlacklistRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBlacklistRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountBlacklistRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountBlacklistRelMea.AccessibleName");
			this.labelTotalCallJobResultCountBlacklistRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Anchor")));
			this.labelTotalCallJobResultCountBlacklistRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.AutoSize")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Dock")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Enabled")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Font")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Image")));
			this.labelTotalCallJobResultCountBlacklistRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountBlacklistRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountBlacklistRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.ImeMode")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Location")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Name = "labelTotalCallJobResultCountBlacklistRelMea";
			this.labelTotalCallJobResultCountBlacklistRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Size")));
			this.labelTotalCallJobResultCountBlacklistRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.TabIndex")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Text = resources.GetString("labelTotalCallJobResultCountBlacklistRelMea.Text");
			this.labelTotalCallJobResultCountBlacklistRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.TextAlign")));
			this.labelTotalCallJobResultCountBlacklistRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountBlacklistRel
			// 
			this.labelTotalCallJobResultCountBlacklistRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBlacklistRel.AccessibleDescription");
			this.labelTotalCallJobResultCountBlacklistRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountBlacklistRel.AccessibleName");
			this.labelTotalCallJobResultCountBlacklistRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Anchor")));
			this.labelTotalCallJobResultCountBlacklistRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.AutoSize")));
			this.labelTotalCallJobResultCountBlacklistRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Dock")));
			this.labelTotalCallJobResultCountBlacklistRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Enabled")));
			this.labelTotalCallJobResultCountBlacklistRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Font")));
			this.labelTotalCallJobResultCountBlacklistRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Image")));
			this.labelTotalCallJobResultCountBlacklistRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.ImageAlign")));
			this.labelTotalCallJobResultCountBlacklistRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.ImageIndex")));
			this.labelTotalCallJobResultCountBlacklistRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.ImeMode")));
			this.labelTotalCallJobResultCountBlacklistRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Location")));
			this.labelTotalCallJobResultCountBlacklistRel.Name = "labelTotalCallJobResultCountBlacklistRel";
			this.labelTotalCallJobResultCountBlacklistRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.RightToLeft")));
			this.labelTotalCallJobResultCountBlacklistRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Size")));
			this.labelTotalCallJobResultCountBlacklistRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.TabIndex")));
			this.labelTotalCallJobResultCountBlacklistRel.Text = resources.GetString("labelTotalCallJobResultCountBlacklistRel.Text");
			this.labelTotalCallJobResultCountBlacklistRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.TextAlign")));
			this.labelTotalCallJobResultCountBlacklistRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistRel.Visible")));
			// 
			// labelTotalCallJobResultCountBlacklistAbs
			// 
			this.labelTotalCallJobResultCountBlacklistAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBlacklistAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountBlacklistAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountBlacklistAbs.AccessibleName");
			this.labelTotalCallJobResultCountBlacklistAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Anchor")));
			this.labelTotalCallJobResultCountBlacklistAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.AutoSize")));
			this.labelTotalCallJobResultCountBlacklistAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Dock")));
			this.labelTotalCallJobResultCountBlacklistAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Enabled")));
			this.labelTotalCallJobResultCountBlacklistAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Font")));
			this.labelTotalCallJobResultCountBlacklistAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Image")));
			this.labelTotalCallJobResultCountBlacklistAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.ImageAlign")));
			this.labelTotalCallJobResultCountBlacklistAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.ImageIndex")));
			this.labelTotalCallJobResultCountBlacklistAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.ImeMode")));
			this.labelTotalCallJobResultCountBlacklistAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Location")));
			this.labelTotalCallJobResultCountBlacklistAbs.Name = "labelTotalCallJobResultCountBlacklistAbs";
			this.labelTotalCallJobResultCountBlacklistAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.RightToLeft")));
			this.labelTotalCallJobResultCountBlacklistAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Size")));
			this.labelTotalCallJobResultCountBlacklistAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.TabIndex")));
			this.labelTotalCallJobResultCountBlacklistAbs.Text = resources.GetString("labelTotalCallJobResultCountBlacklistAbs.Text");
			this.labelTotalCallJobResultCountBlacklistAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.TextAlign")));
			this.labelTotalCallJobResultCountBlacklistAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistAbs.Visible")));
			// 
			// labelTotalCallJobResultCountBlacklistCap
			// 
			this.labelTotalCallJobResultCountBlacklistCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBlacklistCap.AccessibleDescription");
			this.labelTotalCallJobResultCountBlacklistCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountBlacklistCap.AccessibleName");
			this.labelTotalCallJobResultCountBlacklistCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Anchor")));
			this.labelTotalCallJobResultCountBlacklistCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.AutoSize")));
			this.labelTotalCallJobResultCountBlacklistCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Dock")));
			this.labelTotalCallJobResultCountBlacklistCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Enabled")));
			this.labelTotalCallJobResultCountBlacklistCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Font")));
			this.labelTotalCallJobResultCountBlacklistCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Image")));
			this.labelTotalCallJobResultCountBlacklistCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.ImageAlign")));
			this.labelTotalCallJobResultCountBlacklistCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.ImageIndex")));
			this.labelTotalCallJobResultCountBlacklistCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.ImeMode")));
			this.labelTotalCallJobResultCountBlacklistCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Location")));
			this.labelTotalCallJobResultCountBlacklistCap.Name = "labelTotalCallJobResultCountBlacklistCap";
			this.labelTotalCallJobResultCountBlacklistCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.RightToLeft")));
			this.labelTotalCallJobResultCountBlacklistCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Size")));
			this.labelTotalCallJobResultCountBlacklistCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.TabIndex")));
			this.labelTotalCallJobResultCountBlacklistCap.Text = resources.GetString("labelTotalCallJobResultCountBlacklistCap.Text");
			this.labelTotalCallJobResultCountBlacklistCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.TextAlign")));
			this.labelTotalCallJobResultCountBlacklistCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBlacklistCap.Visible")));
			// 
			// labelTotalCallJobResultCountWrongNumberRelMea
			// 
			this.labelTotalCallJobResultCountWrongNumberRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountWrongNumberRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountWrongNumberRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountWrongNumberRelMea.AccessibleName");
			this.labelTotalCallJobResultCountWrongNumberRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Anchor")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.AutoSize")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Dock")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Enabled")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Font")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Image")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.ImeMode")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Location")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Name = "labelTotalCallJobResultCountWrongNumberRelMea";
			this.labelTotalCallJobResultCountWrongNumberRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Size")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.TabIndex")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Text = resources.GetString("labelTotalCallJobResultCountWrongNumberRelMea.Text");
			this.labelTotalCallJobResultCountWrongNumberRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.TextAlign")));
			this.labelTotalCallJobResultCountWrongNumberRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountWrongNumberRel
			// 
			this.labelTotalCallJobResultCountWrongNumberRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountWrongNumberRel.AccessibleDescription");
			this.labelTotalCallJobResultCountWrongNumberRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountWrongNumberRel.AccessibleName");
			this.labelTotalCallJobResultCountWrongNumberRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Anchor")));
			this.labelTotalCallJobResultCountWrongNumberRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.AutoSize")));
			this.labelTotalCallJobResultCountWrongNumberRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Dock")));
			this.labelTotalCallJobResultCountWrongNumberRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Enabled")));
			this.labelTotalCallJobResultCountWrongNumberRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Font")));
			this.labelTotalCallJobResultCountWrongNumberRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Image")));
			this.labelTotalCallJobResultCountWrongNumberRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.ImageAlign")));
			this.labelTotalCallJobResultCountWrongNumberRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.ImageIndex")));
			this.labelTotalCallJobResultCountWrongNumberRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.ImeMode")));
			this.labelTotalCallJobResultCountWrongNumberRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Location")));
			this.labelTotalCallJobResultCountWrongNumberRel.Name = "labelTotalCallJobResultCountWrongNumberRel";
			this.labelTotalCallJobResultCountWrongNumberRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.RightToLeft")));
			this.labelTotalCallJobResultCountWrongNumberRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Size")));
			this.labelTotalCallJobResultCountWrongNumberRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.TabIndex")));
			this.labelTotalCallJobResultCountWrongNumberRel.Text = resources.GetString("labelTotalCallJobResultCountWrongNumberRel.Text");
			this.labelTotalCallJobResultCountWrongNumberRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.TextAlign")));
			this.labelTotalCallJobResultCountWrongNumberRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberRel.Visible")));
			// 
			// labelTotalCallJobResultCountWrongNumberAbs
			// 
			this.labelTotalCallJobResultCountWrongNumberAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountWrongNumberAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountWrongNumberAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountWrongNumberAbs.AccessibleName");
			this.labelTotalCallJobResultCountWrongNumberAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Anchor")));
			this.labelTotalCallJobResultCountWrongNumberAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.AutoSize")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Dock")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Enabled")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Font")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Image")));
			this.labelTotalCallJobResultCountWrongNumberAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.ImageAlign")));
			this.labelTotalCallJobResultCountWrongNumberAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.ImageIndex")));
			this.labelTotalCallJobResultCountWrongNumberAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.ImeMode")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Location")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Name = "labelTotalCallJobResultCountWrongNumberAbs";
			this.labelTotalCallJobResultCountWrongNumberAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.RightToLeft")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Size")));
			this.labelTotalCallJobResultCountWrongNumberAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.TabIndex")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Text = resources.GetString("labelTotalCallJobResultCountWrongNumberAbs.Text");
			this.labelTotalCallJobResultCountWrongNumberAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.TextAlign")));
			this.labelTotalCallJobResultCountWrongNumberAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberAbs.Visible")));
			// 
			// labelTotalCallJobResultCountWrongNumberCap
			// 
			this.labelTotalCallJobResultCountWrongNumberCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountWrongNumberCap.AccessibleDescription");
			this.labelTotalCallJobResultCountWrongNumberCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountWrongNumberCap.AccessibleName");
			this.labelTotalCallJobResultCountWrongNumberCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Anchor")));
			this.labelTotalCallJobResultCountWrongNumberCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.AutoSize")));
			this.labelTotalCallJobResultCountWrongNumberCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Dock")));
			this.labelTotalCallJobResultCountWrongNumberCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Enabled")));
			this.labelTotalCallJobResultCountWrongNumberCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Font")));
			this.labelTotalCallJobResultCountWrongNumberCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Image")));
			this.labelTotalCallJobResultCountWrongNumberCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.ImageAlign")));
			this.labelTotalCallJobResultCountWrongNumberCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.ImageIndex")));
			this.labelTotalCallJobResultCountWrongNumberCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.ImeMode")));
			this.labelTotalCallJobResultCountWrongNumberCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Location")));
			this.labelTotalCallJobResultCountWrongNumberCap.Name = "labelTotalCallJobResultCountWrongNumberCap";
			this.labelTotalCallJobResultCountWrongNumberCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.RightToLeft")));
			this.labelTotalCallJobResultCountWrongNumberCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Size")));
			this.labelTotalCallJobResultCountWrongNumberCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.TabIndex")));
			this.labelTotalCallJobResultCountWrongNumberCap.Text = resources.GetString("labelTotalCallJobResultCountWrongNumberCap.Text");
			this.labelTotalCallJobResultCountWrongNumberCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.TextAlign")));
			this.labelTotalCallJobResultCountWrongNumberCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountWrongNumberCap.Visible")));
			// 
			// labelTotalCallJobResultCountNoAnswerRelMea
			// 
			this.labelTotalCallJobResultCountNoAnswerRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoAnswerRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountNoAnswerRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoAnswerRelMea.AccessibleName");
			this.labelTotalCallJobResultCountNoAnswerRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Anchor")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.AutoSize")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Dock")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Enabled")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Font")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Image")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.ImeMode")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Location")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Name = "labelTotalCallJobResultCountNoAnswerRelMea";
			this.labelTotalCallJobResultCountNoAnswerRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Size")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.TabIndex")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Text = resources.GetString("labelTotalCallJobResultCountNoAnswerRelMea.Text");
			this.labelTotalCallJobResultCountNoAnswerRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.TextAlign")));
			this.labelTotalCallJobResultCountNoAnswerRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountNoAnswerRel
			// 
			this.labelTotalCallJobResultCountNoAnswerRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoAnswerRel.AccessibleDescription");
			this.labelTotalCallJobResultCountNoAnswerRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoAnswerRel.AccessibleName");
			this.labelTotalCallJobResultCountNoAnswerRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Anchor")));
			this.labelTotalCallJobResultCountNoAnswerRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.AutoSize")));
			this.labelTotalCallJobResultCountNoAnswerRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Dock")));
			this.labelTotalCallJobResultCountNoAnswerRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Enabled")));
			this.labelTotalCallJobResultCountNoAnswerRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Font")));
			this.labelTotalCallJobResultCountNoAnswerRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Image")));
			this.labelTotalCallJobResultCountNoAnswerRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.ImageAlign")));
			this.labelTotalCallJobResultCountNoAnswerRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.ImageIndex")));
			this.labelTotalCallJobResultCountNoAnswerRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.ImeMode")));
			this.labelTotalCallJobResultCountNoAnswerRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Location")));
			this.labelTotalCallJobResultCountNoAnswerRel.Name = "labelTotalCallJobResultCountNoAnswerRel";
			this.labelTotalCallJobResultCountNoAnswerRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.RightToLeft")));
			this.labelTotalCallJobResultCountNoAnswerRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Size")));
			this.labelTotalCallJobResultCountNoAnswerRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.TabIndex")));
			this.labelTotalCallJobResultCountNoAnswerRel.Text = resources.GetString("labelTotalCallJobResultCountNoAnswerRel.Text");
			this.labelTotalCallJobResultCountNoAnswerRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.TextAlign")));
			this.labelTotalCallJobResultCountNoAnswerRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerRel.Visible")));
			// 
			// labelTotalCallJobResultCountNoAnswerAbs
			// 
			this.labelTotalCallJobResultCountNoAnswerAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoAnswerAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountNoAnswerAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoAnswerAbs.AccessibleName");
			this.labelTotalCallJobResultCountNoAnswerAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Anchor")));
			this.labelTotalCallJobResultCountNoAnswerAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.AutoSize")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Dock")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Enabled")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Font")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Image")));
			this.labelTotalCallJobResultCountNoAnswerAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.ImageAlign")));
			this.labelTotalCallJobResultCountNoAnswerAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.ImageIndex")));
			this.labelTotalCallJobResultCountNoAnswerAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.ImeMode")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Location")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Name = "labelTotalCallJobResultCountNoAnswerAbs";
			this.labelTotalCallJobResultCountNoAnswerAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.RightToLeft")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Size")));
			this.labelTotalCallJobResultCountNoAnswerAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.TabIndex")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Text = resources.GetString("labelTotalCallJobResultCountNoAnswerAbs.Text");
			this.labelTotalCallJobResultCountNoAnswerAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.TextAlign")));
			this.labelTotalCallJobResultCountNoAnswerAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerAbs.Visible")));
			// 
			// labelTotalCallJobResultCountNoAnswerCap
			// 
			this.labelTotalCallJobResultCountNoAnswerCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountNoAnswerCap.AccessibleDescription");
			this.labelTotalCallJobResultCountNoAnswerCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountNoAnswerCap.AccessibleName");
			this.labelTotalCallJobResultCountNoAnswerCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Anchor")));
			this.labelTotalCallJobResultCountNoAnswerCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.AutoSize")));
			this.labelTotalCallJobResultCountNoAnswerCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Dock")));
			this.labelTotalCallJobResultCountNoAnswerCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Enabled")));
			this.labelTotalCallJobResultCountNoAnswerCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Font")));
			this.labelTotalCallJobResultCountNoAnswerCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Image")));
			this.labelTotalCallJobResultCountNoAnswerCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.ImageAlign")));
			this.labelTotalCallJobResultCountNoAnswerCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.ImageIndex")));
			this.labelTotalCallJobResultCountNoAnswerCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.ImeMode")));
			this.labelTotalCallJobResultCountNoAnswerCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Location")));
			this.labelTotalCallJobResultCountNoAnswerCap.Name = "labelTotalCallJobResultCountNoAnswerCap";
			this.labelTotalCallJobResultCountNoAnswerCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.RightToLeft")));
			this.labelTotalCallJobResultCountNoAnswerCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Size")));
			this.labelTotalCallJobResultCountNoAnswerCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.TabIndex")));
			this.labelTotalCallJobResultCountNoAnswerCap.Text = resources.GetString("labelTotalCallJobResultCountNoAnswerCap.Text");
			this.labelTotalCallJobResultCountNoAnswerCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.TextAlign")));
			this.labelTotalCallJobResultCountNoAnswerCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountNoAnswerCap.Visible")));
			// 
			// labelTotalCallJobResultCountBusyRelMea
			// 
			this.labelTotalCallJobResultCountBusyRelMea.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBusyRelMea.AccessibleDescription");
			this.labelTotalCallJobResultCountBusyRelMea.AccessibleName = resources.GetString("labelTotalCallJobResultCountBusyRelMea.AccessibleName");
			this.labelTotalCallJobResultCountBusyRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Anchor")));
			this.labelTotalCallJobResultCountBusyRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.AutoSize")));
			this.labelTotalCallJobResultCountBusyRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Dock")));
			this.labelTotalCallJobResultCountBusyRelMea.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Enabled")));
			this.labelTotalCallJobResultCountBusyRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Font")));
			this.labelTotalCallJobResultCountBusyRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Image")));
			this.labelTotalCallJobResultCountBusyRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.ImageAlign")));
			this.labelTotalCallJobResultCountBusyRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.ImageIndex")));
			this.labelTotalCallJobResultCountBusyRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.ImeMode")));
			this.labelTotalCallJobResultCountBusyRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Location")));
			this.labelTotalCallJobResultCountBusyRelMea.Name = "labelTotalCallJobResultCountBusyRelMea";
			this.labelTotalCallJobResultCountBusyRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.RightToLeft")));
			this.labelTotalCallJobResultCountBusyRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Size")));
			this.labelTotalCallJobResultCountBusyRelMea.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.TabIndex")));
			this.labelTotalCallJobResultCountBusyRelMea.Text = resources.GetString("labelTotalCallJobResultCountBusyRelMea.Text");
			this.labelTotalCallJobResultCountBusyRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.TextAlign")));
			this.labelTotalCallJobResultCountBusyRelMea.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRelMea.Visible")));
			// 
			// labelTotalCallJobResultCountBusyRel
			// 
			this.labelTotalCallJobResultCountBusyRel.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBusyRel.AccessibleDescription");
			this.labelTotalCallJobResultCountBusyRel.AccessibleName = resources.GetString("labelTotalCallJobResultCountBusyRel.AccessibleName");
			this.labelTotalCallJobResultCountBusyRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Anchor")));
			this.labelTotalCallJobResultCountBusyRel.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRel.AutoSize")));
			this.labelTotalCallJobResultCountBusyRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Dock")));
			this.labelTotalCallJobResultCountBusyRel.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Enabled")));
			this.labelTotalCallJobResultCountBusyRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Font")));
			this.labelTotalCallJobResultCountBusyRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Image")));
			this.labelTotalCallJobResultCountBusyRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyRel.ImageAlign")));
			this.labelTotalCallJobResultCountBusyRel.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyRel.ImageIndex")));
			this.labelTotalCallJobResultCountBusyRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBusyRel.ImeMode")));
			this.labelTotalCallJobResultCountBusyRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Location")));
			this.labelTotalCallJobResultCountBusyRel.Name = "labelTotalCallJobResultCountBusyRel";
			this.labelTotalCallJobResultCountBusyRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBusyRel.RightToLeft")));
			this.labelTotalCallJobResultCountBusyRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Size")));
			this.labelTotalCallJobResultCountBusyRel.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyRel.TabIndex")));
			this.labelTotalCallJobResultCountBusyRel.Text = resources.GetString("labelTotalCallJobResultCountBusyRel.Text");
			this.labelTotalCallJobResultCountBusyRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyRel.TextAlign")));
			this.labelTotalCallJobResultCountBusyRel.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyRel.Visible")));
			// 
			// labelTotalCallJobResultCountBusyAbs
			// 
			this.labelTotalCallJobResultCountBusyAbs.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBusyAbs.AccessibleDescription");
			this.labelTotalCallJobResultCountBusyAbs.AccessibleName = resources.GetString("labelTotalCallJobResultCountBusyAbs.AccessibleName");
			this.labelTotalCallJobResultCountBusyAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Anchor")));
			this.labelTotalCallJobResultCountBusyAbs.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.AutoSize")));
			this.labelTotalCallJobResultCountBusyAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Dock")));
			this.labelTotalCallJobResultCountBusyAbs.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Enabled")));
			this.labelTotalCallJobResultCountBusyAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Font")));
			this.labelTotalCallJobResultCountBusyAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Image")));
			this.labelTotalCallJobResultCountBusyAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.ImageAlign")));
			this.labelTotalCallJobResultCountBusyAbs.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.ImageIndex")));
			this.labelTotalCallJobResultCountBusyAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.ImeMode")));
			this.labelTotalCallJobResultCountBusyAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Location")));
			this.labelTotalCallJobResultCountBusyAbs.Name = "labelTotalCallJobResultCountBusyAbs";
			this.labelTotalCallJobResultCountBusyAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.RightToLeft")));
			this.labelTotalCallJobResultCountBusyAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Size")));
			this.labelTotalCallJobResultCountBusyAbs.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.TabIndex")));
			this.labelTotalCallJobResultCountBusyAbs.Text = resources.GetString("labelTotalCallJobResultCountBusyAbs.Text");
			this.labelTotalCallJobResultCountBusyAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.TextAlign")));
			this.labelTotalCallJobResultCountBusyAbs.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyAbs.Visible")));
			// 
			// labelTotalCallJobResultCountBusyCap
			// 
			this.labelTotalCallJobResultCountBusyCap.AccessibleDescription = resources.GetString("labelTotalCallJobResultCountBusyCap.AccessibleDescription");
			this.labelTotalCallJobResultCountBusyCap.AccessibleName = resources.GetString("labelTotalCallJobResultCountBusyCap.AccessibleName");
			this.labelTotalCallJobResultCountBusyCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Anchor")));
			this.labelTotalCallJobResultCountBusyCap.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyCap.AutoSize")));
			this.labelTotalCallJobResultCountBusyCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Dock")));
			this.labelTotalCallJobResultCountBusyCap.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Enabled")));
			this.labelTotalCallJobResultCountBusyCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Font")));
			this.labelTotalCallJobResultCountBusyCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Image")));
			this.labelTotalCallJobResultCountBusyCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyCap.ImageAlign")));
			this.labelTotalCallJobResultCountBusyCap.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyCap.ImageIndex")));
			this.labelTotalCallJobResultCountBusyCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultCountBusyCap.ImeMode")));
			this.labelTotalCallJobResultCountBusyCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Location")));
			this.labelTotalCallJobResultCountBusyCap.Name = "labelTotalCallJobResultCountBusyCap";
			this.labelTotalCallJobResultCountBusyCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultCountBusyCap.RightToLeft")));
			this.labelTotalCallJobResultCountBusyCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Size")));
			this.labelTotalCallJobResultCountBusyCap.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultCountBusyCap.TabIndex")));
			this.labelTotalCallJobResultCountBusyCap.Text = resources.GetString("labelTotalCallJobResultCountBusyCap.Text");
			this.labelTotalCallJobResultCountBusyCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultCountBusyCap.TextAlign")));
			this.labelTotalCallJobResultCountBusyCap.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultCountBusyCap.Visible")));
			// 
			// labelTotalCallJobResultsTopLineGray
			// 
			this.labelTotalCallJobResultsTopLineGray.AccessibleDescription = resources.GetString("labelTotalCallJobResultsTopLineGray.AccessibleDescription");
			this.labelTotalCallJobResultsTopLineGray.AccessibleName = resources.GetString("labelTotalCallJobResultsTopLineGray.AccessibleName");
			this.labelTotalCallJobResultsTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Anchor")));
			this.labelTotalCallJobResultsTopLineGray.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineGray.AutoSize")));
			this.labelTotalCallJobResultsTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelTotalCallJobResultsTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Dock")));
			this.labelTotalCallJobResultsTopLineGray.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Enabled")));
			this.labelTotalCallJobResultsTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Font")));
			this.labelTotalCallJobResultsTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalCallJobResultsTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Image")));
			this.labelTotalCallJobResultsTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsTopLineGray.ImageAlign")));
			this.labelTotalCallJobResultsTopLineGray.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsTopLineGray.ImageIndex")));
			this.labelTotalCallJobResultsTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsTopLineGray.ImeMode")));
			this.labelTotalCallJobResultsTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Location")));
			this.labelTotalCallJobResultsTopLineGray.Name = "labelTotalCallJobResultsTopLineGray";
			this.labelTotalCallJobResultsTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsTopLineGray.RightToLeft")));
			this.labelTotalCallJobResultsTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Size")));
			this.labelTotalCallJobResultsTopLineGray.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsTopLineGray.TabIndex")));
			this.labelTotalCallJobResultsTopLineGray.Text = resources.GetString("labelTotalCallJobResultsTopLineGray.Text");
			this.labelTotalCallJobResultsTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsTopLineGray.TextAlign")));
			this.labelTotalCallJobResultsTopLineGray.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineGray.Visible")));
			// 
			// labelTotalCallJobResultsTopLineWhite
			// 
			this.labelTotalCallJobResultsTopLineWhite.AccessibleDescription = resources.GetString("labelTotalCallJobResultsTopLineWhite.AccessibleDescription");
			this.labelTotalCallJobResultsTopLineWhite.AccessibleName = resources.GetString("labelTotalCallJobResultsTopLineWhite.AccessibleName");
			this.labelTotalCallJobResultsTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Anchor")));
			this.labelTotalCallJobResultsTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.AutoSize")));
			this.labelTotalCallJobResultsTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelTotalCallJobResultsTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Dock")));
			this.labelTotalCallJobResultsTopLineWhite.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Enabled")));
			this.labelTotalCallJobResultsTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Font")));
			this.labelTotalCallJobResultsTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalCallJobResultsTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Image")));
			this.labelTotalCallJobResultsTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.ImageAlign")));
			this.labelTotalCallJobResultsTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.ImageIndex")));
			this.labelTotalCallJobResultsTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.ImeMode")));
			this.labelTotalCallJobResultsTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Location")));
			this.labelTotalCallJobResultsTopLineWhite.Name = "labelTotalCallJobResultsTopLineWhite";
			this.labelTotalCallJobResultsTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.RightToLeft")));
			this.labelTotalCallJobResultsTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Size")));
			this.labelTotalCallJobResultsTopLineWhite.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.TabIndex")));
			this.labelTotalCallJobResultsTopLineWhite.Text = resources.GetString("labelTotalCallJobResultsTopLineWhite.Text");
			this.labelTotalCallJobResultsTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.TextAlign")));
			this.labelTotalCallJobResultsTopLineWhite.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsTopLineWhite.Visible")));
			// 
			// labelTotalCallJobResultsRowRate
			// 
			this.labelTotalCallJobResultsRowRate.AccessibleDescription = resources.GetString("labelTotalCallJobResultsRowRate.AccessibleDescription");
			this.labelTotalCallJobResultsRowRate.AccessibleName = resources.GetString("labelTotalCallJobResultsRowRate.AccessibleName");
			this.labelTotalCallJobResultsRowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsRowRate.Anchor")));
			this.labelTotalCallJobResultsRowRate.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsRowRate.AutoSize")));
			this.labelTotalCallJobResultsRowRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsRowRate.Dock")));
			this.labelTotalCallJobResultsRowRate.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsRowRate.Enabled")));
			this.labelTotalCallJobResultsRowRate.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsRowRate.Font")));
			this.labelTotalCallJobResultsRowRate.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsRowRate.Image")));
			this.labelTotalCallJobResultsRowRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowRate.ImageAlign")));
			this.labelTotalCallJobResultsRowRate.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowRate.ImageIndex")));
			this.labelTotalCallJobResultsRowRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsRowRate.ImeMode")));
			this.labelTotalCallJobResultsRowRate.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsRowRate.Location")));
			this.labelTotalCallJobResultsRowRate.Name = "labelTotalCallJobResultsRowRate";
			this.labelTotalCallJobResultsRowRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsRowRate.RightToLeft")));
			this.labelTotalCallJobResultsRowRate.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsRowRate.Size")));
			this.labelTotalCallJobResultsRowRate.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowRate.TabIndex")));
			this.labelTotalCallJobResultsRowRate.Text = resources.GetString("labelTotalCallJobResultsRowRate.Text");
			this.labelTotalCallJobResultsRowRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowRate.TextAlign")));
			this.labelTotalCallJobResultsRowRate.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsRowRate.Visible")));
			// 
			// labelTotalCallJobResultsRowCount
			// 
			this.labelTotalCallJobResultsRowCount.AccessibleDescription = resources.GetString("labelTotalCallJobResultsRowCount.AccessibleDescription");
			this.labelTotalCallJobResultsRowCount.AccessibleName = resources.GetString("labelTotalCallJobResultsRowCount.AccessibleName");
			this.labelTotalCallJobResultsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsRowCount.Anchor")));
			this.labelTotalCallJobResultsRowCount.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsRowCount.AutoSize")));
			this.labelTotalCallJobResultsRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsRowCount.Dock")));
			this.labelTotalCallJobResultsRowCount.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsRowCount.Enabled")));
			this.labelTotalCallJobResultsRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsRowCount.Font")));
			this.labelTotalCallJobResultsRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsRowCount.Image")));
			this.labelTotalCallJobResultsRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowCount.ImageAlign")));
			this.labelTotalCallJobResultsRowCount.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowCount.ImageIndex")));
			this.labelTotalCallJobResultsRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsRowCount.ImeMode")));
			this.labelTotalCallJobResultsRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsRowCount.Location")));
			this.labelTotalCallJobResultsRowCount.Name = "labelTotalCallJobResultsRowCount";
			this.labelTotalCallJobResultsRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsRowCount.RightToLeft")));
			this.labelTotalCallJobResultsRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsRowCount.Size")));
			this.labelTotalCallJobResultsRowCount.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowCount.TabIndex")));
			this.labelTotalCallJobResultsRowCount.Text = resources.GetString("labelTotalCallJobResultsRowCount.Text");
			this.labelTotalCallJobResultsRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowCount.TextAlign")));
			this.labelTotalCallJobResultsRowCount.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsRowCount.Visible")));
			// 
			// labelTotalCallJobResultsRowResult
			// 
			this.labelTotalCallJobResultsRowResult.AccessibleDescription = resources.GetString("labelTotalCallJobResultsRowResult.AccessibleDescription");
			this.labelTotalCallJobResultsRowResult.AccessibleName = resources.GetString("labelTotalCallJobResultsRowResult.AccessibleName");
			this.labelTotalCallJobResultsRowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalCallJobResultsRowResult.Anchor")));
			this.labelTotalCallJobResultsRowResult.AutoSize = ((bool)(resources.GetObject("labelTotalCallJobResultsRowResult.AutoSize")));
			this.labelTotalCallJobResultsRowResult.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalCallJobResultsRowResult.Dock")));
			this.labelTotalCallJobResultsRowResult.Enabled = ((bool)(resources.GetObject("labelTotalCallJobResultsRowResult.Enabled")));
			this.labelTotalCallJobResultsRowResult.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalCallJobResultsRowResult.Font")));
			this.labelTotalCallJobResultsRowResult.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalCallJobResultsRowResult.Image")));
			this.labelTotalCallJobResultsRowResult.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowResult.ImageAlign")));
			this.labelTotalCallJobResultsRowResult.ImageIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowResult.ImageIndex")));
			this.labelTotalCallJobResultsRowResult.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalCallJobResultsRowResult.ImeMode")));
			this.labelTotalCallJobResultsRowResult.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalCallJobResultsRowResult.Location")));
			this.labelTotalCallJobResultsRowResult.Name = "labelTotalCallJobResultsRowResult";
			this.labelTotalCallJobResultsRowResult.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalCallJobResultsRowResult.RightToLeft")));
			this.labelTotalCallJobResultsRowResult.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalCallJobResultsRowResult.Size")));
			this.labelTotalCallJobResultsRowResult.TabIndex = ((int)(resources.GetObject("labelTotalCallJobResultsRowResult.TabIndex")));
			this.labelTotalCallJobResultsRowResult.Text = resources.GetString("labelTotalCallJobResultsRowResult.Text");
			this.labelTotalCallJobResultsRowResult.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalCallJobResultsRowResult.TextAlign")));
			this.labelTotalCallJobResultsRowResult.Visible = ((bool)(resources.GetObject("labelTotalCallJobResultsRowResult.Visible")));
			// 
			// CampaignViewCallJobsTotalStatistics
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxPieTotalCallJobResultCount);
			this.Controls.Add(this.groupBoxTotalCallJobResults);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewCallJobsTotalStatistics";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxPieTotalCallJobResultCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pieTotalCallJobResultCount)).EndInit();
			this.groupBoxTotalCallJobResults.ResumeLayout(false);
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
			int processedCallJobCountTtl =
				campaign.GetCallJobResultCountTtl(CallJobResult.Busy) +
				campaign.GetCallJobResultCountTtl(CallJobResult.NoAnswer) +
				campaign.GetCallJobResultCountTtl(CallJobResult.WrongNumber) +
				campaign.GetCallJobResultCountTtl(CallJobResult.Blacklist) +
				campaign.GetCallJobResultCountTtl(CallJobResult.RouteDenied) +
				campaign.GetCallJobResultCountTtl(CallJobResult.PSTNFailure) +
				campaign.GetCallJobResultCountTtl(CallJobResult.TelcoOverload) +
				campaign.GetCallJobResultCountTtl(CallJobResult.ACR) +
				campaign.GetCallJobResultCountTtl(CallJobResult.Fax) +
				campaign.GetCallJobResultCountTtl(CallJobResult.AnsweringMachine) +
				campaign.GetCallJobResultCountTtl(CallJobResult.NoInterest) +
				campaign.GetCallJobResultCountTtl(CallJobResult.Lost) +
				campaign.GetCallJobResultCountTtl(CallJobResult.PutThrough);
			labelTotalCallJobResultCountBusyAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.Busy).ToString();
			labelTotalCallJobResultCountBusyRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.Busy),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountNoAnswerAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.NoAnswer).ToString();
			labelTotalCallJobResultCountNoAnswerRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.NoAnswer),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountWrongNumberAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.WrongNumber).ToString();
			labelTotalCallJobResultCountWrongNumberRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.WrongNumber),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountBlacklistAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.Blacklist).ToString();
			labelTotalCallJobResultCountBlacklistRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.Blacklist),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountRouteDeniedAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.RouteDenied).ToString();
			labelTotalCallJobResultCountRouteDeniedRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.RouteDenied),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountPSTNFailureAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.PSTNFailure).ToString();
			labelTotalCallJobResultCountPSTNFailureRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.PSTNFailure),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountTelcoOverloadAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.TelcoOverload).ToString();
			labelTotalCallJobResultCountTelcoOverloadRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.TelcoOverload),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountACRAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.ACR).ToString();
			labelTotalCallJobResultCountACRRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.ACR),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountFaxAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.Fax).ToString();
			labelTotalCallJobResultCountFaxRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.Fax),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountAnsweringMachineAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.AnsweringMachine).ToString();
			labelTotalCallJobResultCountAnsweringMachineRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.AnsweringMachine),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountNoInterestAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.NoInterest).ToString();
			labelTotalCallJobResultCountNoInterestRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.NoInterest),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountLostAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.Lost).ToString();
			labelTotalCallJobResultCountLostRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.Lost),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountPutThroughAbs.Text =
				campaign.GetCallJobResultCountTtl(CallJobResult.PutThrough).ToString();
			labelTotalCallJobResultCountPutThroughRel.Text =
				GetRelativeValue(campaign.GetCallJobResultCountTtl(CallJobResult.PutThrough),
				processedCallJobCountTtl).ToString();
			labelTotalCallJobResultCountAbs.Text = processedCallJobCountTtl.ToString();

			// Tortengrafik aktualisieren
			pieTotalCallJobResultCount.Slices[0].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.Busy);
			pieTotalCallJobResultCount.Slices[1].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.NoAnswer);
			pieTotalCallJobResultCount.Slices[2].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.WrongNumber);
			pieTotalCallJobResultCount.Slices[3].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.Blacklist);
			pieTotalCallJobResultCount.Slices[4].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.RouteDenied);
			pieTotalCallJobResultCount.Slices[5].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.PSTNFailure);
			pieTotalCallJobResultCount.Slices[6].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.TelcoOverload);
			pieTotalCallJobResultCount.Slices[7].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.ACR);
			pieTotalCallJobResultCount.Slices[8].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.Fax);
			pieTotalCallJobResultCount.Slices[9].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.AnsweringMachine);
			pieTotalCallJobResultCount.Slices[10].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.NoInterest);
			pieTotalCallJobResultCount.Slices[11].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.Lost);
			pieTotalCallJobResultCount.Slices[12].Value =
				campaign.GetCallJobResultCountTtl(CallJobResult.PutThrough);
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
