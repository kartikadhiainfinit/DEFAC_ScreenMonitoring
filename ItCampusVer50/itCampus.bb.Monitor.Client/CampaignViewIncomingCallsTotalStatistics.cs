using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Inbound Gesamtstatistik einer Kampagne.
	/// </summary>
	public class CampaignViewIncomingCallsTotalStatistics : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxTotalIncomingCallResults;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsRowResult;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsRowCount;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsRowRate;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsTopLineWhite;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsTopLineGray;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPSTNFailureCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPSTNFailureAbs;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPSTNFailureRel;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPSTNFailureRelMea;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountTelcoOverloadCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountTelcoOverloadAbs;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountTelcoOverloadRel;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountTelcoOverloadRelMea;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountNoInterestCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountNoInterestAbs;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountNoInterestRel;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountNoInterestRelMea;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountLostCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountLostAbs;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountLostRel;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountLostRelMea;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPutThroughCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPutThroughAbs;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPutThroughRel;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountPutThroughRelMea;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsBottomLineWhite;
		private System.Windows.Forms.Label labelTotalIncomingCallResultsBottomLineGray;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountCap;
		private System.Windows.Forms.Label labelTotalIncomingCallResultCountAbs;
		private System.Windows.Forms.GroupBox groupBoxPieTotalIncomingCallResultCount;
		private itCampus.bb.Graph.Pie.Pie pieTotalIncomingCallResultCount;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewIncomingCallsTotalStatistics()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Intervall Tortengrafik einstellen
			pieTotalIncomingCallResultCount.RefreshInterval =
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewIncomingCallsTotalStatistics));
			itCampus.bb.Graph.Pie.Slice slice1 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice2 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice3 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice4 = new itCampus.bb.Graph.Pie.Slice();
			itCampus.bb.Graph.Pie.Slice slice5 = new itCampus.bb.Graph.Pie.Slice();
			this.groupBoxPieTotalIncomingCallResultCount = new System.Windows.Forms.GroupBox();
			this.pieTotalIncomingCallResultCount = new itCampus.bb.Graph.Pie.Pie();
			this.groupBoxTotalIncomingCallResults = new System.Windows.Forms.GroupBox();
			this.labelTotalIncomingCallResultCountAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsBottomLineGray = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsBottomLineWhite = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPutThroughRelMea = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPutThroughRel = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPutThroughAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPutThroughCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountLostRelMea = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountLostRel = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountLostAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountLostCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountNoInterestRelMea = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountNoInterestRel = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountNoInterestAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountNoInterestCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountTelcoOverloadRel = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountTelcoOverloadCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPSTNFailureRel = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPSTNFailureAbs = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultCountPSTNFailureCap = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsTopLineGray = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsTopLineWhite = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsRowRate = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsRowCount = new System.Windows.Forms.Label();
			this.labelTotalIncomingCallResultsRowResult = new System.Windows.Forms.Label();
			this.groupBoxPieTotalIncomingCallResultCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pieTotalIncomingCallResultCount)).BeginInit();
			this.groupBoxTotalIncomingCallResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxPieTotalIncomingCallResultCount
			// 
			this.groupBoxPieTotalIncomingCallResultCount.AccessibleDescription = resources.GetString("groupBoxPieTotalIncomingCallResultCount.AccessibleDescription");
			this.groupBoxPieTotalIncomingCallResultCount.AccessibleName = resources.GetString("groupBoxPieTotalIncomingCallResultCount.AccessibleName");
			this.groupBoxPieTotalIncomingCallResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Anchor")));
			this.groupBoxPieTotalIncomingCallResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.BackgroundImage")));
			this.groupBoxPieTotalIncomingCallResultCount.Controls.Add(this.pieTotalIncomingCallResultCount);
			this.groupBoxPieTotalIncomingCallResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Dock")));
			this.groupBoxPieTotalIncomingCallResultCount.Enabled = ((bool)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Enabled")));
			this.groupBoxPieTotalIncomingCallResultCount.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Font")));
			this.groupBoxPieTotalIncomingCallResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.ImeMode")));
			this.groupBoxPieTotalIncomingCallResultCount.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Location")));
			this.groupBoxPieTotalIncomingCallResultCount.Name = "groupBoxPieTotalIncomingCallResultCount";
			this.groupBoxPieTotalIncomingCallResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.RightToLeft")));
			this.groupBoxPieTotalIncomingCallResultCount.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Size")));
			this.groupBoxPieTotalIncomingCallResultCount.TabIndex = ((int)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.TabIndex")));
			this.groupBoxPieTotalIncomingCallResultCount.TabStop = false;
			this.groupBoxPieTotalIncomingCallResultCount.Text = resources.GetString("groupBoxPieTotalIncomingCallResultCount.Text");
			this.groupBoxPieTotalIncomingCallResultCount.Visible = ((bool)(resources.GetObject("groupBoxPieTotalIncomingCallResultCount.Visible")));
			// 
			// pieTotalIncomingCallResultCount
			// 
			this.pieTotalIncomingCallResultCount.AccessibleDescription = resources.GetString("pieTotalIncomingCallResultCount.AccessibleDescription");
			this.pieTotalIncomingCallResultCount.AccessibleName = resources.GetString("pieTotalIncomingCallResultCount.AccessibleName");
			this.pieTotalIncomingCallResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pieTotalIncomingCallResultCount.Anchor")));
			this.pieTotalIncomingCallResultCount.AutoScroll = ((bool)(resources.GetObject("pieTotalIncomingCallResultCount.AutoScroll")));
			this.pieTotalIncomingCallResultCount.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pieTotalIncomingCallResultCount.AutoScrollMargin")));
			this.pieTotalIncomingCallResultCount.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pieTotalIncomingCallResultCount.AutoScrollMinSize")));
			this.pieTotalIncomingCallResultCount.BackgroundColor = ((System.Drawing.Color)(resources.GetObject("pieTotalIncomingCallResultCount.BackgroundColor")));
			this.pieTotalIncomingCallResultCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pieTotalIncomingCallResultCount.BackgroundImage")));
			this.pieTotalIncomingCallResultCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pieTotalIncomingCallResultCount.Dock")));
			this.pieTotalIncomingCallResultCount.Enabled = ((bool)(resources.GetObject("pieTotalIncomingCallResultCount.Enabled")));
			this.pieTotalIncomingCallResultCount.Font = ((System.Drawing.Font)(resources.GetObject("pieTotalIncomingCallResultCount.Font")));
			this.pieTotalIncomingCallResultCount.HorizontalSpace = ((int)(resources.GetObject("pieTotalIncomingCallResultCount.HorizontalSpace")));
			this.pieTotalIncomingCallResultCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pieTotalIncomingCallResultCount.ImeMode")));
			this.pieTotalIncomingCallResultCount.LegendAlignment = ((itCampus.bb.Graph.LegendAlignment)(resources.GetObject("pieTotalIncomingCallResultCount.LegendAlignment")));
			this.pieTotalIncomingCallResultCount.LegendColor = ((System.Drawing.Color)(resources.GetObject("pieTotalIncomingCallResultCount.LegendColor")));
			this.pieTotalIncomingCallResultCount.Location = ((System.Drawing.Point)(resources.GetObject("pieTotalIncomingCallResultCount.Location")));
			this.pieTotalIncomingCallResultCount.Name = "pieTotalIncomingCallResultCount";
			this.pieTotalIncomingCallResultCount.Painting = ((bool)(resources.GetObject("pieTotalIncomingCallResultCount.Painting")));
			this.pieTotalIncomingCallResultCount.RefreshInterval = ((int)(resources.GetObject("pieTotalIncomingCallResultCount.RefreshInterval")));
			this.pieTotalIncomingCallResultCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pieTotalIncomingCallResultCount.RightToLeft")));
			this.pieTotalIncomingCallResultCount.Size = ((System.Drawing.Size)(resources.GetObject("pieTotalIncomingCallResultCount.Size")));
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
			this.pieTotalIncomingCallResultCount.Slices.AddRange(new itCampus.bb.Graph.Pie.Slice[] {
																									   slice1,
																									   slice2,
																									   slice3,
																									   slice4,
																									   slice5});
			this.pieTotalIncomingCallResultCount.TabIndex = ((int)(resources.GetObject("pieTotalIncomingCallResultCount.TabIndex")));
			this.pieTotalIncomingCallResultCount.ValueColor = ((System.Drawing.Color)(resources.GetObject("pieTotalIncomingCallResultCount.ValueColor")));
			this.pieTotalIncomingCallResultCount.ValueType = ((itCampus.bb.Graph.ValueType)(resources.GetObject("pieTotalIncomingCallResultCount.ValueType")));
			this.pieTotalIncomingCallResultCount.VerticalSpace = ((int)(resources.GetObject("pieTotalIncomingCallResultCount.VerticalSpace")));
			this.pieTotalIncomingCallResultCount.Visible = ((bool)(resources.GetObject("pieTotalIncomingCallResultCount.Visible")));
			// 
			// groupBoxTotalIncomingCallResults
			// 
			this.groupBoxTotalIncomingCallResults.AccessibleDescription = resources.GetString("groupBoxTotalIncomingCallResults.AccessibleDescription");
			this.groupBoxTotalIncomingCallResults.AccessibleName = resources.GetString("groupBoxTotalIncomingCallResults.AccessibleName");
			this.groupBoxTotalIncomingCallResults.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxTotalIncomingCallResults.Anchor")));
			this.groupBoxTotalIncomingCallResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxTotalIncomingCallResults.BackgroundImage")));
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsBottomLineGray);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsBottomLineWhite);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPutThroughRelMea);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPutThroughRel);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPutThroughAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPutThroughCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountLostRelMea);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountLostRel);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountLostAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountLostCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountNoInterestRelMea);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountNoInterestRel);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountNoInterestAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountNoInterestCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountTelcoOverloadRelMea);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountTelcoOverloadRel);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountTelcoOverloadAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountTelcoOverloadCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPSTNFailureRelMea);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPSTNFailureRel);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPSTNFailureAbs);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultCountPSTNFailureCap);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsTopLineGray);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsTopLineWhite);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsRowRate);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsRowCount);
			this.groupBoxTotalIncomingCallResults.Controls.Add(this.labelTotalIncomingCallResultsRowResult);
			this.groupBoxTotalIncomingCallResults.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxTotalIncomingCallResults.Dock")));
			this.groupBoxTotalIncomingCallResults.Enabled = ((bool)(resources.GetObject("groupBoxTotalIncomingCallResults.Enabled")));
			this.groupBoxTotalIncomingCallResults.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxTotalIncomingCallResults.Font")));
			this.groupBoxTotalIncomingCallResults.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxTotalIncomingCallResults.ImeMode")));
			this.groupBoxTotalIncomingCallResults.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxTotalIncomingCallResults.Location")));
			this.groupBoxTotalIncomingCallResults.Name = "groupBoxTotalIncomingCallResults";
			this.groupBoxTotalIncomingCallResults.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxTotalIncomingCallResults.RightToLeft")));
			this.groupBoxTotalIncomingCallResults.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxTotalIncomingCallResults.Size")));
			this.groupBoxTotalIncomingCallResults.TabIndex = ((int)(resources.GetObject("groupBoxTotalIncomingCallResults.TabIndex")));
			this.groupBoxTotalIncomingCallResults.TabStop = false;
			this.groupBoxTotalIncomingCallResults.Text = resources.GetString("groupBoxTotalIncomingCallResults.Text");
			this.groupBoxTotalIncomingCallResults.Visible = ((bool)(resources.GetObject("groupBoxTotalIncomingCallResults.Visible")));
			// 
			// labelTotalIncomingCallResultCountAbs
			// 
			this.labelTotalIncomingCallResultCountAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Anchor")));
			this.labelTotalIncomingCallResultCountAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Dock")));
			this.labelTotalIncomingCallResultCountAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Enabled")));
			this.labelTotalIncomingCallResultCountAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Font")));
			this.labelTotalIncomingCallResultCountAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Image")));
			this.labelTotalIncomingCallResultCountAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Location")));
			this.labelTotalIncomingCallResultCountAbs.Name = "labelTotalIncomingCallResultCountAbs";
			this.labelTotalIncomingCallResultCountAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Size")));
			this.labelTotalIncomingCallResultCountAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountAbs.Text = resources.GetString("labelTotalIncomingCallResultCountAbs.Text");
			this.labelTotalIncomingCallResultCountAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountCap
			// 
			this.labelTotalIncomingCallResultCountCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountCap.AccessibleName");
			this.labelTotalIncomingCallResultCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountCap.Anchor")));
			this.labelTotalIncomingCallResultCountCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountCap.AutoSize")));
			this.labelTotalIncomingCallResultCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountCap.Dock")));
			this.labelTotalIncomingCallResultCountCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountCap.Enabled")));
			this.labelTotalIncomingCallResultCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountCap.Font")));
			this.labelTotalIncomingCallResultCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountCap.Image")));
			this.labelTotalIncomingCallResultCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountCap.ImeMode")));
			this.labelTotalIncomingCallResultCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountCap.Location")));
			this.labelTotalIncomingCallResultCountCap.Name = "labelTotalIncomingCallResultCountCap";
			this.labelTotalIncomingCallResultCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountCap.Size")));
			this.labelTotalIncomingCallResultCountCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountCap.TabIndex")));
			this.labelTotalIncomingCallResultCountCap.Text = resources.GetString("labelTotalIncomingCallResultCountCap.Text");
			this.labelTotalIncomingCallResultCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountCap.TextAlign")));
			this.labelTotalIncomingCallResultCountCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountCap.Visible")));
			// 
			// labelTotalIncomingCallResultsBottomLineGray
			// 
			this.labelTotalIncomingCallResultsBottomLineGray.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsBottomLineGray.AccessibleDescription");
			this.labelTotalIncomingCallResultsBottomLineGray.AccessibleName = resources.GetString("labelTotalIncomingCallResultsBottomLineGray.AccessibleName");
			this.labelTotalIncomingCallResultsBottomLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Anchor")));
			this.labelTotalIncomingCallResultsBottomLineGray.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.AutoSize")));
			this.labelTotalIncomingCallResultsBottomLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelTotalIncomingCallResultsBottomLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Dock")));
			this.labelTotalIncomingCallResultsBottomLineGray.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Enabled")));
			this.labelTotalIncomingCallResultsBottomLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Font")));
			this.labelTotalIncomingCallResultsBottomLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalIncomingCallResultsBottomLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Image")));
			this.labelTotalIncomingCallResultsBottomLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.ImageAlign")));
			this.labelTotalIncomingCallResultsBottomLineGray.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.ImageIndex")));
			this.labelTotalIncomingCallResultsBottomLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.ImeMode")));
			this.labelTotalIncomingCallResultsBottomLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Location")));
			this.labelTotalIncomingCallResultsBottomLineGray.Name = "labelTotalIncomingCallResultsBottomLineGray";
			this.labelTotalIncomingCallResultsBottomLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.RightToLeft")));
			this.labelTotalIncomingCallResultsBottomLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Size")));
			this.labelTotalIncomingCallResultsBottomLineGray.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.TabIndex")));
			this.labelTotalIncomingCallResultsBottomLineGray.Text = resources.GetString("labelTotalIncomingCallResultsBottomLineGray.Text");
			this.labelTotalIncomingCallResultsBottomLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.TextAlign")));
			this.labelTotalIncomingCallResultsBottomLineGray.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineGray.Visible")));
			// 
			// labelTotalIncomingCallResultsBottomLineWhite
			// 
			this.labelTotalIncomingCallResultsBottomLineWhite.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsBottomLineWhite.AccessibleDescription");
			this.labelTotalIncomingCallResultsBottomLineWhite.AccessibleName = resources.GetString("labelTotalIncomingCallResultsBottomLineWhite.AccessibleName");
			this.labelTotalIncomingCallResultsBottomLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Anchor")));
			this.labelTotalIncomingCallResultsBottomLineWhite.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.AutoSize")));
			this.labelTotalIncomingCallResultsBottomLineWhite.BackColor = System.Drawing.Color.White;
			this.labelTotalIncomingCallResultsBottomLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Dock")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Enabled")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Font")));
			this.labelTotalIncomingCallResultsBottomLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalIncomingCallResultsBottomLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Image")));
			this.labelTotalIncomingCallResultsBottomLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.ImageAlign")));
			this.labelTotalIncomingCallResultsBottomLineWhite.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.ImageIndex")));
			this.labelTotalIncomingCallResultsBottomLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.ImeMode")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Location")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Name = "labelTotalIncomingCallResultsBottomLineWhite";
			this.labelTotalIncomingCallResultsBottomLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.RightToLeft")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Size")));
			this.labelTotalIncomingCallResultsBottomLineWhite.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.TabIndex")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Text = resources.GetString("labelTotalIncomingCallResultsBottomLineWhite.Text");
			this.labelTotalIncomingCallResultsBottomLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.TextAlign")));
			this.labelTotalIncomingCallResultsBottomLineWhite.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsBottomLineWhite.Visible")));
			// 
			// labelTotalIncomingCallResultCountPutThroughRelMea
			// 
			this.labelTotalIncomingCallResultCountPutThroughRelMea.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPutThroughRelMea.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPutThroughRelMea.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPutThroughRelMea.AccessibleName");
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Anchor")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.AutoSize")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Dock")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Enabled")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Font")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Image")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.ImageAlign")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.ImageIndex")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.ImeMode")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Location")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Name = "labelTotalIncomingCallResultCountPutThroughRelMea";
			this.labelTotalIncomingCallResultCountPutThroughRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.RightToLeft")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Size")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.TabIndex")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Text = resources.GetString("labelTotalIncomingCallResultCountPutThroughRelMea.Text");
			this.labelTotalIncomingCallResultCountPutThroughRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.TextAlign")));
			this.labelTotalIncomingCallResultCountPutThroughRelMea.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRelMea.Visible")));
			// 
			// labelTotalIncomingCallResultCountPutThroughRel
			// 
			this.labelTotalIncomingCallResultCountPutThroughRel.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPutThroughRel.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPutThroughRel.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPutThroughRel.AccessibleName");
			this.labelTotalIncomingCallResultCountPutThroughRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Anchor")));
			this.labelTotalIncomingCallResultCountPutThroughRel.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.AutoSize")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Dock")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Enabled")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Font")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Image")));
			this.labelTotalIncomingCallResultCountPutThroughRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.ImageAlign")));
			this.labelTotalIncomingCallResultCountPutThroughRel.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.ImageIndex")));
			this.labelTotalIncomingCallResultCountPutThroughRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.ImeMode")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Location")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Name = "labelTotalIncomingCallResultCountPutThroughRel";
			this.labelTotalIncomingCallResultCountPutThroughRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.RightToLeft")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Size")));
			this.labelTotalIncomingCallResultCountPutThroughRel.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.TabIndex")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Text = resources.GetString("labelTotalIncomingCallResultCountPutThroughRel.Text");
			this.labelTotalIncomingCallResultCountPutThroughRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.TextAlign")));
			this.labelTotalIncomingCallResultCountPutThroughRel.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughRel.Visible")));
			// 
			// labelTotalIncomingCallResultCountPutThroughAbs
			// 
			this.labelTotalIncomingCallResultCountPutThroughAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPutThroughAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPutThroughAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPutThroughAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountPutThroughAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Anchor")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Dock")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Enabled")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Font")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Image")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Location")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Name = "labelTotalIncomingCallResultCountPutThroughAbs";
			this.labelTotalIncomingCallResultCountPutThroughAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Size")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Text = resources.GetString("labelTotalIncomingCallResultCountPutThroughAbs.Text");
			this.labelTotalIncomingCallResultCountPutThroughAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountPutThroughAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountPutThroughCap
			// 
			this.labelTotalIncomingCallResultCountPutThroughCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPutThroughCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPutThroughCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPutThroughCap.AccessibleName");
			this.labelTotalIncomingCallResultCountPutThroughCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Anchor")));
			this.labelTotalIncomingCallResultCountPutThroughCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.AutoSize")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Dock")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Enabled")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Font")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Image")));
			this.labelTotalIncomingCallResultCountPutThroughCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountPutThroughCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountPutThroughCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.ImeMode")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Location")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Name = "labelTotalIncomingCallResultCountPutThroughCap";
			this.labelTotalIncomingCallResultCountPutThroughCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Size")));
			this.labelTotalIncomingCallResultCountPutThroughCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.TabIndex")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Text = resources.GetString("labelTotalIncomingCallResultCountPutThroughCap.Text");
			this.labelTotalIncomingCallResultCountPutThroughCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.TextAlign")));
			this.labelTotalIncomingCallResultCountPutThroughCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPutThroughCap.Visible")));
			// 
			// labelTotalIncomingCallResultCountLostRelMea
			// 
			this.labelTotalIncomingCallResultCountLostRelMea.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountLostRelMea.AccessibleDescription");
			this.labelTotalIncomingCallResultCountLostRelMea.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountLostRelMea.AccessibleName");
			this.labelTotalIncomingCallResultCountLostRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Anchor")));
			this.labelTotalIncomingCallResultCountLostRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.AutoSize")));
			this.labelTotalIncomingCallResultCountLostRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Dock")));
			this.labelTotalIncomingCallResultCountLostRelMea.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Enabled")));
			this.labelTotalIncomingCallResultCountLostRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Font")));
			this.labelTotalIncomingCallResultCountLostRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Image")));
			this.labelTotalIncomingCallResultCountLostRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.ImageAlign")));
			this.labelTotalIncomingCallResultCountLostRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.ImageIndex")));
			this.labelTotalIncomingCallResultCountLostRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.ImeMode")));
			this.labelTotalIncomingCallResultCountLostRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Location")));
			this.labelTotalIncomingCallResultCountLostRelMea.Name = "labelTotalIncomingCallResultCountLostRelMea";
			this.labelTotalIncomingCallResultCountLostRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.RightToLeft")));
			this.labelTotalIncomingCallResultCountLostRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Size")));
			this.labelTotalIncomingCallResultCountLostRelMea.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.TabIndex")));
			this.labelTotalIncomingCallResultCountLostRelMea.Text = resources.GetString("labelTotalIncomingCallResultCountLostRelMea.Text");
			this.labelTotalIncomingCallResultCountLostRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.TextAlign")));
			this.labelTotalIncomingCallResultCountLostRelMea.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRelMea.Visible")));
			// 
			// labelTotalIncomingCallResultCountLostRel
			// 
			this.labelTotalIncomingCallResultCountLostRel.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountLostRel.AccessibleDescription");
			this.labelTotalIncomingCallResultCountLostRel.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountLostRel.AccessibleName");
			this.labelTotalIncomingCallResultCountLostRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Anchor")));
			this.labelTotalIncomingCallResultCountLostRel.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.AutoSize")));
			this.labelTotalIncomingCallResultCountLostRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Dock")));
			this.labelTotalIncomingCallResultCountLostRel.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Enabled")));
			this.labelTotalIncomingCallResultCountLostRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Font")));
			this.labelTotalIncomingCallResultCountLostRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Image")));
			this.labelTotalIncomingCallResultCountLostRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.ImageAlign")));
			this.labelTotalIncomingCallResultCountLostRel.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.ImageIndex")));
			this.labelTotalIncomingCallResultCountLostRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.ImeMode")));
			this.labelTotalIncomingCallResultCountLostRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Location")));
			this.labelTotalIncomingCallResultCountLostRel.Name = "labelTotalIncomingCallResultCountLostRel";
			this.labelTotalIncomingCallResultCountLostRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.RightToLeft")));
			this.labelTotalIncomingCallResultCountLostRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Size")));
			this.labelTotalIncomingCallResultCountLostRel.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.TabIndex")));
			this.labelTotalIncomingCallResultCountLostRel.Text = resources.GetString("labelTotalIncomingCallResultCountLostRel.Text");
			this.labelTotalIncomingCallResultCountLostRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.TextAlign")));
			this.labelTotalIncomingCallResultCountLostRel.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostRel.Visible")));
			// 
			// labelTotalIncomingCallResultCountLostAbs
			// 
			this.labelTotalIncomingCallResultCountLostAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountLostAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountLostAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountLostAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountLostAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Anchor")));
			this.labelTotalIncomingCallResultCountLostAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountLostAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Dock")));
			this.labelTotalIncomingCallResultCountLostAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Enabled")));
			this.labelTotalIncomingCallResultCountLostAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Font")));
			this.labelTotalIncomingCallResultCountLostAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Image")));
			this.labelTotalIncomingCallResultCountLostAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountLostAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountLostAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountLostAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Location")));
			this.labelTotalIncomingCallResultCountLostAbs.Name = "labelTotalIncomingCallResultCountLostAbs";
			this.labelTotalIncomingCallResultCountLostAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountLostAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Size")));
			this.labelTotalIncomingCallResultCountLostAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountLostAbs.Text = resources.GetString("labelTotalIncomingCallResultCountLostAbs.Text");
			this.labelTotalIncomingCallResultCountLostAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountLostAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountLostCap
			// 
			this.labelTotalIncomingCallResultCountLostCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountLostCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountLostCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountLostCap.AccessibleName");
			this.labelTotalIncomingCallResultCountLostCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Anchor")));
			this.labelTotalIncomingCallResultCountLostCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.AutoSize")));
			this.labelTotalIncomingCallResultCountLostCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Dock")));
			this.labelTotalIncomingCallResultCountLostCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Enabled")));
			this.labelTotalIncomingCallResultCountLostCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Font")));
			this.labelTotalIncomingCallResultCountLostCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Image")));
			this.labelTotalIncomingCallResultCountLostCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountLostCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountLostCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.ImeMode")));
			this.labelTotalIncomingCallResultCountLostCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Location")));
			this.labelTotalIncomingCallResultCountLostCap.Name = "labelTotalIncomingCallResultCountLostCap";
			this.labelTotalIncomingCallResultCountLostCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountLostCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Size")));
			this.labelTotalIncomingCallResultCountLostCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.TabIndex")));
			this.labelTotalIncomingCallResultCountLostCap.Text = resources.GetString("labelTotalIncomingCallResultCountLostCap.Text");
			this.labelTotalIncomingCallResultCountLostCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.TextAlign")));
			this.labelTotalIncomingCallResultCountLostCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountLostCap.Visible")));
			// 
			// labelTotalIncomingCallResultCountNoInterestRelMea
			// 
			this.labelTotalIncomingCallResultCountNoInterestRelMea.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountNoInterestRelMea.AccessibleDescription");
			this.labelTotalIncomingCallResultCountNoInterestRelMea.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountNoInterestRelMea.AccessibleName");
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Anchor")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.AutoSize")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Dock")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Enabled")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Font")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Image")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.ImageAlign")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.ImageIndex")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.ImeMode")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Location")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Name = "labelTotalIncomingCallResultCountNoInterestRelMea";
			this.labelTotalIncomingCallResultCountNoInterestRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.RightToLeft")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Size")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.TabIndex")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Text = resources.GetString("labelTotalIncomingCallResultCountNoInterestRelMea.Text");
			this.labelTotalIncomingCallResultCountNoInterestRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.TextAlign")));
			this.labelTotalIncomingCallResultCountNoInterestRelMea.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRelMea.Visible")));
			// 
			// labelTotalIncomingCallResultCountNoInterestRel
			// 
			this.labelTotalIncomingCallResultCountNoInterestRel.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountNoInterestRel.AccessibleDescription");
			this.labelTotalIncomingCallResultCountNoInterestRel.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountNoInterestRel.AccessibleName");
			this.labelTotalIncomingCallResultCountNoInterestRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Anchor")));
			this.labelTotalIncomingCallResultCountNoInterestRel.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.AutoSize")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Dock")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Enabled")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Font")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Image")));
			this.labelTotalIncomingCallResultCountNoInterestRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.ImageAlign")));
			this.labelTotalIncomingCallResultCountNoInterestRel.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.ImageIndex")));
			this.labelTotalIncomingCallResultCountNoInterestRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.ImeMode")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Location")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Name = "labelTotalIncomingCallResultCountNoInterestRel";
			this.labelTotalIncomingCallResultCountNoInterestRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.RightToLeft")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Size")));
			this.labelTotalIncomingCallResultCountNoInterestRel.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.TabIndex")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Text = resources.GetString("labelTotalIncomingCallResultCountNoInterestRel.Text");
			this.labelTotalIncomingCallResultCountNoInterestRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.TextAlign")));
			this.labelTotalIncomingCallResultCountNoInterestRel.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestRel.Visible")));
			// 
			// labelTotalIncomingCallResultCountNoInterestAbs
			// 
			this.labelTotalIncomingCallResultCountNoInterestAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountNoInterestAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountNoInterestAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountNoInterestAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountNoInterestAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Anchor")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Dock")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Enabled")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Font")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Image")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Location")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Name = "labelTotalIncomingCallResultCountNoInterestAbs";
			this.labelTotalIncomingCallResultCountNoInterestAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Size")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Text = resources.GetString("labelTotalIncomingCallResultCountNoInterestAbs.Text");
			this.labelTotalIncomingCallResultCountNoInterestAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountNoInterestAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountNoInterestCap
			// 
			this.labelTotalIncomingCallResultCountNoInterestCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountNoInterestCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountNoInterestCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountNoInterestCap.AccessibleName");
			this.labelTotalIncomingCallResultCountNoInterestCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Anchor")));
			this.labelTotalIncomingCallResultCountNoInterestCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.AutoSize")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Dock")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Enabled")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Font")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Image")));
			this.labelTotalIncomingCallResultCountNoInterestCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountNoInterestCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountNoInterestCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.ImeMode")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Location")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Name = "labelTotalIncomingCallResultCountNoInterestCap";
			this.labelTotalIncomingCallResultCountNoInterestCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Size")));
			this.labelTotalIncomingCallResultCountNoInterestCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.TabIndex")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Text = resources.GetString("labelTotalIncomingCallResultCountNoInterestCap.Text");
			this.labelTotalIncomingCallResultCountNoInterestCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.TextAlign")));
			this.labelTotalIncomingCallResultCountNoInterestCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountNoInterestCap.Visible")));
			// 
			// labelTotalIncomingCallResultCountTelcoOverloadRelMea
			// 
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRelMea.AccessibleDescription");
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRelMea.AccessibleName");
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Anchor")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.AutoSize")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Dock")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Enabled")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Font")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Image")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImageAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImageIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.ImeMode")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Location")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Name = "labelTotalIncomingCallResultCountTelcoOverloadRelMea";
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.RightToLeft")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Size")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.TabIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Text = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Text");
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.TextAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRelMea.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRelMea.Visible")));
			// 
			// labelTotalIncomingCallResultCountTelcoOverloadRel
			// 
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRel.AccessibleDescription");
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRel.AccessibleName");
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Anchor")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.AutoSize")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Dock")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Enabled")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Font")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Image")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.ImageAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.ImageIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.ImeMode")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Location")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Name = "labelTotalIncomingCallResultCountTelcoOverloadRel";
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.RightToLeft")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Size")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.TabIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Text = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadRel.Text");
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.TextAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadRel.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadRel.Visible")));
			// 
			// labelTotalIncomingCallResultCountTelcoOverloadAbs
			// 
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Anchor")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Dock")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Enabled")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Font")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Image")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Location")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Name = "labelTotalIncomingCallResultCountTelcoOverloadAbs";
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Size")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Text = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadAbs.Text");
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountTelcoOverloadCap
			// 
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadCap.AccessibleName");
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Anchor")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.AutoSize")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Dock")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Enabled")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Font")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Image")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.ImeMode")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Location")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Name = "labelTotalIncomingCallResultCountTelcoOverloadCap";
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Size")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.TabIndex")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Text = resources.GetString("labelTotalIncomingCallResultCountTelcoOverloadCap.Text");
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.TextAlign")));
			this.labelTotalIncomingCallResultCountTelcoOverloadCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountTelcoOverloadCap.Visible")));
			// 
			// labelTotalIncomingCallResultCountPSTNFailureRelMea
			// 
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRelMea.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRelMea.AccessibleName");
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Anchor")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.AutoSize")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Dock")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Enabled")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Font")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Image")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.ImageAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.ImageIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.ImeMode")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Location")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Name = "labelTotalIncomingCallResultCountPSTNFailureRelMea";
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.RightToLeft")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Size")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.TabIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Text = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRelMea.Text");
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.TextAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureRelMea.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRelMea.Visible")));
			// 
			// labelTotalIncomingCallResultCountPSTNFailureRel
			// 
			this.labelTotalIncomingCallResultCountPSTNFailureRel.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRel.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPSTNFailureRel.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRel.AccessibleName");
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Anchor")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.AutoSize")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Dock")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Enabled")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Font")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Image")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.ImageAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.ImageIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.ImeMode")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Location")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Name = "labelTotalIncomingCallResultCountPSTNFailureRel";
			this.labelTotalIncomingCallResultCountPSTNFailureRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.RightToLeft")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Size")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.TabIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Text = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureRel.Text");
			this.labelTotalIncomingCallResultCountPSTNFailureRel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.TextAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureRel.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureRel.Visible")));
			// 
			// labelTotalIncomingCallResultCountPSTNFailureAbs
			// 
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureAbs.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureAbs.AccessibleName");
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Anchor")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.AutoSize")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Dock")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Enabled")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Font")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Image")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.ImageAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.ImageIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.ImeMode")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Location")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Name = "labelTotalIncomingCallResultCountPSTNFailureAbs";
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.RightToLeft")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Size")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.TabIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Text = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureAbs.Text");
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.TextAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureAbs.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureAbs.Visible")));
			// 
			// labelTotalIncomingCallResultCountPSTNFailureCap
			// 
			this.labelTotalIncomingCallResultCountPSTNFailureCap.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureCap.AccessibleDescription");
			this.labelTotalIncomingCallResultCountPSTNFailureCap.AccessibleName = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureCap.AccessibleName");
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Anchor")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.AutoSize")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Dock")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Enabled")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Font")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Image")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.ImageAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.ImageIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.ImeMode")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Location")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Name = "labelTotalIncomingCallResultCountPSTNFailureCap";
			this.labelTotalIncomingCallResultCountPSTNFailureCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.RightToLeft")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Size")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.TabIndex")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Text = resources.GetString("labelTotalIncomingCallResultCountPSTNFailureCap.Text");
			this.labelTotalIncomingCallResultCountPSTNFailureCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.TextAlign")));
			this.labelTotalIncomingCallResultCountPSTNFailureCap.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultCountPSTNFailureCap.Visible")));
			// 
			// labelTotalIncomingCallResultsTopLineGray
			// 
			this.labelTotalIncomingCallResultsTopLineGray.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsTopLineGray.AccessibleDescription");
			this.labelTotalIncomingCallResultsTopLineGray.AccessibleName = resources.GetString("labelTotalIncomingCallResultsTopLineGray.AccessibleName");
			this.labelTotalIncomingCallResultsTopLineGray.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Anchor")));
			this.labelTotalIncomingCallResultsTopLineGray.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.AutoSize")));
			this.labelTotalIncomingCallResultsTopLineGray.BackColor = System.Drawing.Color.Gray;
			this.labelTotalIncomingCallResultsTopLineGray.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Dock")));
			this.labelTotalIncomingCallResultsTopLineGray.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Enabled")));
			this.labelTotalIncomingCallResultsTopLineGray.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Font")));
			this.labelTotalIncomingCallResultsTopLineGray.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalIncomingCallResultsTopLineGray.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Image")));
			this.labelTotalIncomingCallResultsTopLineGray.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.ImageAlign")));
			this.labelTotalIncomingCallResultsTopLineGray.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.ImageIndex")));
			this.labelTotalIncomingCallResultsTopLineGray.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.ImeMode")));
			this.labelTotalIncomingCallResultsTopLineGray.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Location")));
			this.labelTotalIncomingCallResultsTopLineGray.Name = "labelTotalIncomingCallResultsTopLineGray";
			this.labelTotalIncomingCallResultsTopLineGray.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.RightToLeft")));
			this.labelTotalIncomingCallResultsTopLineGray.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Size")));
			this.labelTotalIncomingCallResultsTopLineGray.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.TabIndex")));
			this.labelTotalIncomingCallResultsTopLineGray.Text = resources.GetString("labelTotalIncomingCallResultsTopLineGray.Text");
			this.labelTotalIncomingCallResultsTopLineGray.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.TextAlign")));
			this.labelTotalIncomingCallResultsTopLineGray.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineGray.Visible")));
			// 
			// labelTotalIncomingCallResultsTopLineWhite
			// 
			this.labelTotalIncomingCallResultsTopLineWhite.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsTopLineWhite.AccessibleDescription");
			this.labelTotalIncomingCallResultsTopLineWhite.AccessibleName = resources.GetString("labelTotalIncomingCallResultsTopLineWhite.AccessibleName");
			this.labelTotalIncomingCallResultsTopLineWhite.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Anchor")));
			this.labelTotalIncomingCallResultsTopLineWhite.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.AutoSize")));
			this.labelTotalIncomingCallResultsTopLineWhite.BackColor = System.Drawing.Color.White;
			this.labelTotalIncomingCallResultsTopLineWhite.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Dock")));
			this.labelTotalIncomingCallResultsTopLineWhite.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Enabled")));
			this.labelTotalIncomingCallResultsTopLineWhite.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Font")));
			this.labelTotalIncomingCallResultsTopLineWhite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalIncomingCallResultsTopLineWhite.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Image")));
			this.labelTotalIncomingCallResultsTopLineWhite.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.ImageAlign")));
			this.labelTotalIncomingCallResultsTopLineWhite.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.ImageIndex")));
			this.labelTotalIncomingCallResultsTopLineWhite.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.ImeMode")));
			this.labelTotalIncomingCallResultsTopLineWhite.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Location")));
			this.labelTotalIncomingCallResultsTopLineWhite.Name = "labelTotalIncomingCallResultsTopLineWhite";
			this.labelTotalIncomingCallResultsTopLineWhite.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.RightToLeft")));
			this.labelTotalIncomingCallResultsTopLineWhite.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Size")));
			this.labelTotalIncomingCallResultsTopLineWhite.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.TabIndex")));
			this.labelTotalIncomingCallResultsTopLineWhite.Text = resources.GetString("labelTotalIncomingCallResultsTopLineWhite.Text");
			this.labelTotalIncomingCallResultsTopLineWhite.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.TextAlign")));
			this.labelTotalIncomingCallResultsTopLineWhite.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsTopLineWhite.Visible")));
			// 
			// labelTotalIncomingCallResultsRowRate
			// 
			this.labelTotalIncomingCallResultsRowRate.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsRowRate.AccessibleDescription");
			this.labelTotalIncomingCallResultsRowRate.AccessibleName = resources.GetString("labelTotalIncomingCallResultsRowRate.AccessibleName");
			this.labelTotalIncomingCallResultsRowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Anchor")));
			this.labelTotalIncomingCallResultsRowRate.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowRate.AutoSize")));
			this.labelTotalIncomingCallResultsRowRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Dock")));
			this.labelTotalIncomingCallResultsRowRate.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Enabled")));
			this.labelTotalIncomingCallResultsRowRate.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Font")));
			this.labelTotalIncomingCallResultsRowRate.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Image")));
			this.labelTotalIncomingCallResultsRowRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowRate.ImageAlign")));
			this.labelTotalIncomingCallResultsRowRate.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowRate.ImageIndex")));
			this.labelTotalIncomingCallResultsRowRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsRowRate.ImeMode")));
			this.labelTotalIncomingCallResultsRowRate.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Location")));
			this.labelTotalIncomingCallResultsRowRate.Name = "labelTotalIncomingCallResultsRowRate";
			this.labelTotalIncomingCallResultsRowRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsRowRate.RightToLeft")));
			this.labelTotalIncomingCallResultsRowRate.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Size")));
			this.labelTotalIncomingCallResultsRowRate.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowRate.TabIndex")));
			this.labelTotalIncomingCallResultsRowRate.Text = resources.GetString("labelTotalIncomingCallResultsRowRate.Text");
			this.labelTotalIncomingCallResultsRowRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowRate.TextAlign")));
			this.labelTotalIncomingCallResultsRowRate.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowRate.Visible")));
			// 
			// labelTotalIncomingCallResultsRowCount
			// 
			this.labelTotalIncomingCallResultsRowCount.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsRowCount.AccessibleDescription");
			this.labelTotalIncomingCallResultsRowCount.AccessibleName = resources.GetString("labelTotalIncomingCallResultsRowCount.AccessibleName");
			this.labelTotalIncomingCallResultsRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Anchor")));
			this.labelTotalIncomingCallResultsRowCount.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowCount.AutoSize")));
			this.labelTotalIncomingCallResultsRowCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Dock")));
			this.labelTotalIncomingCallResultsRowCount.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Enabled")));
			this.labelTotalIncomingCallResultsRowCount.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Font")));
			this.labelTotalIncomingCallResultsRowCount.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Image")));
			this.labelTotalIncomingCallResultsRowCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowCount.ImageAlign")));
			this.labelTotalIncomingCallResultsRowCount.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowCount.ImageIndex")));
			this.labelTotalIncomingCallResultsRowCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsRowCount.ImeMode")));
			this.labelTotalIncomingCallResultsRowCount.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Location")));
			this.labelTotalIncomingCallResultsRowCount.Name = "labelTotalIncomingCallResultsRowCount";
			this.labelTotalIncomingCallResultsRowCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsRowCount.RightToLeft")));
			this.labelTotalIncomingCallResultsRowCount.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Size")));
			this.labelTotalIncomingCallResultsRowCount.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowCount.TabIndex")));
			this.labelTotalIncomingCallResultsRowCount.Text = resources.GetString("labelTotalIncomingCallResultsRowCount.Text");
			this.labelTotalIncomingCallResultsRowCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowCount.TextAlign")));
			this.labelTotalIncomingCallResultsRowCount.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowCount.Visible")));
			// 
			// labelTotalIncomingCallResultsRowResult
			// 
			this.labelTotalIncomingCallResultsRowResult.AccessibleDescription = resources.GetString("labelTotalIncomingCallResultsRowResult.AccessibleDescription");
			this.labelTotalIncomingCallResultsRowResult.AccessibleName = resources.GetString("labelTotalIncomingCallResultsRowResult.AccessibleName");
			this.labelTotalIncomingCallResultsRowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Anchor")));
			this.labelTotalIncomingCallResultsRowResult.AutoSize = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowResult.AutoSize")));
			this.labelTotalIncomingCallResultsRowResult.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Dock")));
			this.labelTotalIncomingCallResultsRowResult.Enabled = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Enabled")));
			this.labelTotalIncomingCallResultsRowResult.Font = ((System.Drawing.Font)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Font")));
			this.labelTotalIncomingCallResultsRowResult.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Image")));
			this.labelTotalIncomingCallResultsRowResult.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowResult.ImageAlign")));
			this.labelTotalIncomingCallResultsRowResult.ImageIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowResult.ImageIndex")));
			this.labelTotalIncomingCallResultsRowResult.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTotalIncomingCallResultsRowResult.ImeMode")));
			this.labelTotalIncomingCallResultsRowResult.Location = ((System.Drawing.Point)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Location")));
			this.labelTotalIncomingCallResultsRowResult.Name = "labelTotalIncomingCallResultsRowResult";
			this.labelTotalIncomingCallResultsRowResult.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTotalIncomingCallResultsRowResult.RightToLeft")));
			this.labelTotalIncomingCallResultsRowResult.Size = ((System.Drawing.Size)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Size")));
			this.labelTotalIncomingCallResultsRowResult.TabIndex = ((int)(resources.GetObject("labelTotalIncomingCallResultsRowResult.TabIndex")));
			this.labelTotalIncomingCallResultsRowResult.Text = resources.GetString("labelTotalIncomingCallResultsRowResult.Text");
			this.labelTotalIncomingCallResultsRowResult.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTotalIncomingCallResultsRowResult.TextAlign")));
			this.labelTotalIncomingCallResultsRowResult.Visible = ((bool)(resources.GetObject("labelTotalIncomingCallResultsRowResult.Visible")));
			// 
			// CampaignViewIncomingCallsTotalStatistics
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxPieTotalIncomingCallResultCount);
			this.Controls.Add(this.groupBoxTotalIncomingCallResults);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewIncomingCallsTotalStatistics";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxPieTotalIncomingCallResultCount.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pieTotalIncomingCallResultCount)).EndInit();
			this.groupBoxTotalIncomingCallResults.ResumeLayout(false);
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
			int processedIncomingCallCountTtl =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PSTNFailure) +
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.TelcoOverload) +
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.NoInterest) +
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.Lost) +
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PutThrough);
			labelTotalIncomingCallResultCountPSTNFailureAbs.Text =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PSTNFailure).ToString();
			labelTotalIncomingCallResultCountPSTNFailureRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.PSTNFailure), processedIncomingCallCountTtl).ToString();
			labelTotalIncomingCallResultCountTelcoOverloadAbs.Text =
				campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.TelcoOverload).ToString();
			labelTotalIncomingCallResultCountTelcoOverloadRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.TelcoOverload), processedIncomingCallCountTtl).ToString();
			labelTotalIncomingCallResultCountNoInterestAbs.Text =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.NoInterest).ToString();
			labelTotalIncomingCallResultCountNoInterestRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.NoInterest), processedIncomingCallCountTtl).ToString();
			labelTotalIncomingCallResultCountLostAbs.Text =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.Lost).ToString();
			labelTotalIncomingCallResultCountLostRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.Lost), processedIncomingCallCountTtl).ToString();
			labelTotalIncomingCallResultCountPutThroughAbs.Text =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PutThrough).ToString();
			labelTotalIncomingCallResultCountPutThroughRel.Text =
				GetRelativeValue(campaign.GetIncomingCallResultCountTtl(
				IncomingCallResult.PutThrough), processedIncomingCallCountTtl).ToString();
			labelTotalIncomingCallResultCountAbs.Text = processedIncomingCallCountTtl.ToString();

			// Tortengrafik aktualisieren
			pieTotalIncomingCallResultCount.Slices[0].Value =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PSTNFailure);
			pieTotalIncomingCallResultCount.Slices[1].Value =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.TelcoOverload);
			pieTotalIncomingCallResultCount.Slices[2].Value =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.NoInterest);
			pieTotalIncomingCallResultCount.Slices[3].Value =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.Lost);
			pieTotalIncomingCallResultCount.Slices[4].Value =
				campaign.GetIncomingCallResultCountTtl(IncomingCallResult.PutThrough);
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
