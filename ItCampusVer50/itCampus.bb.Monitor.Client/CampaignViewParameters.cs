using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung der Parameter einer Kampagne.
	/// </summary>
	public class CampaignViewParameters : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.GroupBox groupBoxParameters;
		private System.Windows.Forms.Label labelAvailabilityModeCap;
		private System.Windows.Forms.Label labelAvailabilityMode;
		private System.Windows.Forms.Label labelDialModeCap;
		private System.Windows.Forms.Label labelDialMode;
		private System.Windows.Forms.Label labelTrunkGroupCap;
		private System.Windows.Forms.Label labelTrunkGroup;
		private System.Windows.Forms.Label labelCarrierCodeCap;
		private System.Windows.Forms.Label labelCarrierCode;
		private System.Windows.Forms.Label labelCallingNumberCap;
		private System.Windows.Forms.Label labelCallingNumber;
		private System.Windows.Forms.Label labelMinRingCountCap;
		private System.Windows.Forms.Label labelMinRingCount;
		private System.Windows.Forms.Label labelMaxRingCountCap;
		private System.Windows.Forms.Label labelMaxRingCount;
		private System.Windows.Forms.Label labelMaxSwitchingTimeCap;
		private System.Windows.Forms.Label labelMaxSwitchingTime;
		private System.Windows.Forms.Label labelMaxSwitchingTimeMea;
		private System.Windows.Forms.Label labelMaxDialRateCap;
		private System.Windows.Forms.Label labelMaxDialRate;
		private System.Windows.Forms.Label labelMaxDropRateCap;
		private System.Windows.Forms.Label labelMaxDropRate;
		private System.Windows.Forms.Label labelMaxDropRateMea;
		private System.Windows.Forms.Label labelMaxLostRateCap;
		private System.Windows.Forms.Label labelMaxLostRate;
		private System.Windows.Forms.Label labelMaxLostRateMea;
		private System.Windows.Forms.Label labelAgentRelaxTargetCap;
		private System.Windows.Forms.Label labelAgentRelaxTarget;
		private System.Windows.Forms.Label labelAgentRelaxTargetMea;
		private System.Windows.Forms.Label labelCPALevelCap;
		private System.Windows.Forms.Label labelCPALevel;
		private System.Windows.Forms.Label labelCallPriorityCap;
		private System.Windows.Forms.Label labelCallPriority;
		private System.Windows.Forms.Label labelMusicOnReadyFileCap;
		private System.Windows.Forms.TextBox textBoxMusicOnReadyFile;
		private System.Windows.Forms.Label labelGreetingFileCap;
		private System.Windows.Forms.TextBox textBoxGreetingFile;
		private System.Windows.Forms.Label labelWaitingFileCap;
		private System.Windows.Forms.TextBox textBoxWaitingFile;
		private System.Windows.Forms.Label labelAnsweringMachineFileCap;
		private System.Windows.Forms.TextBox textBoxAnsweringMachineFile;
		private System.Windows.Forms.Label labelAbandonmentFileCap;
		private System.Windows.Forms.TextBox textBoxAbandonmentFile;
		private System.Windows.Forms.Label labelAutoRecordingCap;
		private System.Windows.Forms.Label labelAutoRecording;
		private System.Windows.Forms.GroupBox groupBoxHotlineParameters;
		private System.Windows.Forms.Label labelHotlineNumbersCap;
		private System.Windows.Forms.TextBox textBoxHotlineNumbers;
		private System.Windows.Forms.Label labelHotlineQueueSizeFactorCap;
		private System.Windows.Forms.Label labelHotlineQueueSizeFactor;
		private System.Windows.Forms.Label labelHotlineCallPriorityCap;
		private System.Windows.Forms.Label labelHotlineCallPriority;
		private System.Windows.Forms.Label labelHotlineGreetingFileCap;
		private System.Windows.Forms.TextBox textBoxHotlineGreetingFile;
		private System.Windows.Forms.Label labelHotlineWaitingFileCap;
		private System.Windows.Forms.TextBox textBoxHotlineWaitingFile;
		private System.Windows.Forms.Label labelHotlineAbandonmentFileCap;
		private System.Windows.Forms.TextBox textBoxHotlineAbandonmentFile;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagnenteilansicht
		/// </summary>
		public CampaignViewParameters()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CampaignViewParameters));
			this.groupBoxHotlineParameters = new System.Windows.Forms.GroupBox();
			this.textBoxHotlineAbandonmentFile = new System.Windows.Forms.TextBox();
			this.labelHotlineAbandonmentFileCap = new System.Windows.Forms.Label();
			this.textBoxHotlineWaitingFile = new System.Windows.Forms.TextBox();
			this.labelHotlineWaitingFileCap = new System.Windows.Forms.Label();
			this.textBoxHotlineGreetingFile = new System.Windows.Forms.TextBox();
			this.labelHotlineGreetingFileCap = new System.Windows.Forms.Label();
			this.labelHotlineCallPriority = new System.Windows.Forms.Label();
			this.labelHotlineCallPriorityCap = new System.Windows.Forms.Label();
			this.labelHotlineQueueSizeFactor = new System.Windows.Forms.Label();
			this.labelHotlineQueueSizeFactorCap = new System.Windows.Forms.Label();
			this.textBoxHotlineNumbers = new System.Windows.Forms.TextBox();
			this.labelHotlineNumbersCap = new System.Windows.Forms.Label();
			this.groupBoxParameters = new System.Windows.Forms.GroupBox();
			this.labelAutoRecording = new System.Windows.Forms.Label();
			this.labelAutoRecordingCap = new System.Windows.Forms.Label();
			this.textBoxAbandonmentFile = new System.Windows.Forms.TextBox();
			this.labelAbandonmentFileCap = new System.Windows.Forms.Label();
			this.textBoxAnsweringMachineFile = new System.Windows.Forms.TextBox();
			this.labelAnsweringMachineFileCap = new System.Windows.Forms.Label();
			this.textBoxWaitingFile = new System.Windows.Forms.TextBox();
			this.labelWaitingFileCap = new System.Windows.Forms.Label();
			this.textBoxGreetingFile = new System.Windows.Forms.TextBox();
			this.labelGreetingFileCap = new System.Windows.Forms.Label();
			this.textBoxMusicOnReadyFile = new System.Windows.Forms.TextBox();
			this.labelMusicOnReadyFileCap = new System.Windows.Forms.Label();
			this.labelCallPriority = new System.Windows.Forms.Label();
			this.labelCallPriorityCap = new System.Windows.Forms.Label();
			this.labelCPALevel = new System.Windows.Forms.Label();
			this.labelCPALevelCap = new System.Windows.Forms.Label();
			this.labelAgentRelaxTargetMea = new System.Windows.Forms.Label();
			this.labelAgentRelaxTarget = new System.Windows.Forms.Label();
			this.labelAgentRelaxTargetCap = new System.Windows.Forms.Label();
			this.labelMaxLostRateMea = new System.Windows.Forms.Label();
			this.labelMaxLostRate = new System.Windows.Forms.Label();
			this.labelMaxLostRateCap = new System.Windows.Forms.Label();
			this.labelMaxDropRateMea = new System.Windows.Forms.Label();
			this.labelMaxDropRate = new System.Windows.Forms.Label();
			this.labelMaxDropRateCap = new System.Windows.Forms.Label();
			this.labelMaxDialRate = new System.Windows.Forms.Label();
			this.labelMaxDialRateCap = new System.Windows.Forms.Label();
			this.labelMaxSwitchingTimeMea = new System.Windows.Forms.Label();
			this.labelMaxSwitchingTime = new System.Windows.Forms.Label();
			this.labelMaxSwitchingTimeCap = new System.Windows.Forms.Label();
			this.labelMaxRingCount = new System.Windows.Forms.Label();
			this.labelMaxRingCountCap = new System.Windows.Forms.Label();
			this.labelMinRingCount = new System.Windows.Forms.Label();
			this.labelMinRingCountCap = new System.Windows.Forms.Label();
			this.labelCallingNumber = new System.Windows.Forms.Label();
			this.labelCallingNumberCap = new System.Windows.Forms.Label();
			this.labelCarrierCode = new System.Windows.Forms.Label();
			this.labelCarrierCodeCap = new System.Windows.Forms.Label();
			this.labelTrunkGroup = new System.Windows.Forms.Label();
			this.labelTrunkGroupCap = new System.Windows.Forms.Label();
			this.labelDialMode = new System.Windows.Forms.Label();
			this.labelDialModeCap = new System.Windows.Forms.Label();
			this.labelAvailabilityMode = new System.Windows.Forms.Label();
			this.labelAvailabilityModeCap = new System.Windows.Forms.Label();
			this.groupBoxHotlineParameters.SuspendLayout();
			this.groupBoxParameters.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxHotlineParameters
			// 
			this.groupBoxHotlineParameters.AccessibleDescription = resources.GetString("groupBoxHotlineParameters.AccessibleDescription");
			this.groupBoxHotlineParameters.AccessibleName = resources.GetString("groupBoxHotlineParameters.AccessibleName");
			this.groupBoxHotlineParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxHotlineParameters.Anchor")));
			this.groupBoxHotlineParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxHotlineParameters.BackgroundImage")));
			this.groupBoxHotlineParameters.Controls.Add(this.textBoxHotlineAbandonmentFile);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineAbandonmentFileCap);
			this.groupBoxHotlineParameters.Controls.Add(this.textBoxHotlineWaitingFile);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineWaitingFileCap);
			this.groupBoxHotlineParameters.Controls.Add(this.textBoxHotlineGreetingFile);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineGreetingFileCap);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineCallPriority);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineCallPriorityCap);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineQueueSizeFactor);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineQueueSizeFactorCap);
			this.groupBoxHotlineParameters.Controls.Add(this.textBoxHotlineNumbers);
			this.groupBoxHotlineParameters.Controls.Add(this.labelHotlineNumbersCap);
			this.groupBoxHotlineParameters.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxHotlineParameters.Dock")));
			this.groupBoxHotlineParameters.Enabled = ((bool)(resources.GetObject("groupBoxHotlineParameters.Enabled")));
			this.groupBoxHotlineParameters.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxHotlineParameters.Font")));
			this.groupBoxHotlineParameters.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxHotlineParameters.ImeMode")));
			this.groupBoxHotlineParameters.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxHotlineParameters.Location")));
			this.groupBoxHotlineParameters.Name = "groupBoxHotlineParameters";
			this.groupBoxHotlineParameters.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxHotlineParameters.RightToLeft")));
			this.groupBoxHotlineParameters.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxHotlineParameters.Size")));
			this.groupBoxHotlineParameters.TabIndex = ((int)(resources.GetObject("groupBoxHotlineParameters.TabIndex")));
			this.groupBoxHotlineParameters.TabStop = false;
			this.groupBoxHotlineParameters.Text = resources.GetString("groupBoxHotlineParameters.Text");
			this.groupBoxHotlineParameters.Visible = ((bool)(resources.GetObject("groupBoxHotlineParameters.Visible")));
			// 
			// textBoxHotlineAbandonmentFile
			// 
			this.textBoxHotlineAbandonmentFile.AccessibleDescription = resources.GetString("textBoxHotlineAbandonmentFile.AccessibleDescription");
			this.textBoxHotlineAbandonmentFile.AccessibleName = resources.GetString("textBoxHotlineAbandonmentFile.AccessibleName");
			this.textBoxHotlineAbandonmentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxHotlineAbandonmentFile.Anchor")));
			this.textBoxHotlineAbandonmentFile.AutoSize = ((bool)(resources.GetObject("textBoxHotlineAbandonmentFile.AutoSize")));
			this.textBoxHotlineAbandonmentFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxHotlineAbandonmentFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxHotlineAbandonmentFile.BackgroundImage")));
			this.textBoxHotlineAbandonmentFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHotlineAbandonmentFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxHotlineAbandonmentFile.Dock")));
			this.textBoxHotlineAbandonmentFile.Enabled = ((bool)(resources.GetObject("textBoxHotlineAbandonmentFile.Enabled")));
			this.textBoxHotlineAbandonmentFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxHotlineAbandonmentFile.Font")));
			this.textBoxHotlineAbandonmentFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxHotlineAbandonmentFile.ImeMode")));
			this.textBoxHotlineAbandonmentFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxHotlineAbandonmentFile.Location")));
			this.textBoxHotlineAbandonmentFile.MaxLength = ((int)(resources.GetObject("textBoxHotlineAbandonmentFile.MaxLength")));
			this.textBoxHotlineAbandonmentFile.Multiline = ((bool)(resources.GetObject("textBoxHotlineAbandonmentFile.Multiline")));
			this.textBoxHotlineAbandonmentFile.Name = "textBoxHotlineAbandonmentFile";
			this.textBoxHotlineAbandonmentFile.PasswordChar = ((char)(resources.GetObject("textBoxHotlineAbandonmentFile.PasswordChar")));
			this.textBoxHotlineAbandonmentFile.ReadOnly = true;
			this.textBoxHotlineAbandonmentFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxHotlineAbandonmentFile.RightToLeft")));
			this.textBoxHotlineAbandonmentFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxHotlineAbandonmentFile.ScrollBars")));
			this.textBoxHotlineAbandonmentFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxHotlineAbandonmentFile.Size")));
			this.textBoxHotlineAbandonmentFile.TabIndex = ((int)(resources.GetObject("textBoxHotlineAbandonmentFile.TabIndex")));
			this.textBoxHotlineAbandonmentFile.TabStop = false;
			this.textBoxHotlineAbandonmentFile.Text = resources.GetString("textBoxHotlineAbandonmentFile.Text");
			this.textBoxHotlineAbandonmentFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxHotlineAbandonmentFile.TextAlign")));
			this.textBoxHotlineAbandonmentFile.Visible = ((bool)(resources.GetObject("textBoxHotlineAbandonmentFile.Visible")));
			this.textBoxHotlineAbandonmentFile.WordWrap = ((bool)(resources.GetObject("textBoxHotlineAbandonmentFile.WordWrap")));
			// 
			// labelHotlineAbandonmentFileCap
			// 
			this.labelHotlineAbandonmentFileCap.AccessibleDescription = resources.GetString("labelHotlineAbandonmentFileCap.AccessibleDescription");
			this.labelHotlineAbandonmentFileCap.AccessibleName = resources.GetString("labelHotlineAbandonmentFileCap.AccessibleName");
			this.labelHotlineAbandonmentFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineAbandonmentFileCap.Anchor")));
			this.labelHotlineAbandonmentFileCap.AutoSize = ((bool)(resources.GetObject("labelHotlineAbandonmentFileCap.AutoSize")));
			this.labelHotlineAbandonmentFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineAbandonmentFileCap.Dock")));
			this.labelHotlineAbandonmentFileCap.Enabled = ((bool)(resources.GetObject("labelHotlineAbandonmentFileCap.Enabled")));
			this.labelHotlineAbandonmentFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineAbandonmentFileCap.Font")));
			this.labelHotlineAbandonmentFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineAbandonmentFileCap.Image")));
			this.labelHotlineAbandonmentFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineAbandonmentFileCap.ImageAlign")));
			this.labelHotlineAbandonmentFileCap.ImageIndex = ((int)(resources.GetObject("labelHotlineAbandonmentFileCap.ImageIndex")));
			this.labelHotlineAbandonmentFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineAbandonmentFileCap.ImeMode")));
			this.labelHotlineAbandonmentFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineAbandonmentFileCap.Location")));
			this.labelHotlineAbandonmentFileCap.Name = "labelHotlineAbandonmentFileCap";
			this.labelHotlineAbandonmentFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineAbandonmentFileCap.RightToLeft")));
			this.labelHotlineAbandonmentFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineAbandonmentFileCap.Size")));
			this.labelHotlineAbandonmentFileCap.TabIndex = ((int)(resources.GetObject("labelHotlineAbandonmentFileCap.TabIndex")));
			this.labelHotlineAbandonmentFileCap.Text = resources.GetString("labelHotlineAbandonmentFileCap.Text");
			this.labelHotlineAbandonmentFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineAbandonmentFileCap.TextAlign")));
			this.labelHotlineAbandonmentFileCap.Visible = ((bool)(resources.GetObject("labelHotlineAbandonmentFileCap.Visible")));
			// 
			// textBoxHotlineWaitingFile
			// 
			this.textBoxHotlineWaitingFile.AccessibleDescription = resources.GetString("textBoxHotlineWaitingFile.AccessibleDescription");
			this.textBoxHotlineWaitingFile.AccessibleName = resources.GetString("textBoxHotlineWaitingFile.AccessibleName");
			this.textBoxHotlineWaitingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxHotlineWaitingFile.Anchor")));
			this.textBoxHotlineWaitingFile.AutoSize = ((bool)(resources.GetObject("textBoxHotlineWaitingFile.AutoSize")));
			this.textBoxHotlineWaitingFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxHotlineWaitingFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxHotlineWaitingFile.BackgroundImage")));
			this.textBoxHotlineWaitingFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHotlineWaitingFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxHotlineWaitingFile.Dock")));
			this.textBoxHotlineWaitingFile.Enabled = ((bool)(resources.GetObject("textBoxHotlineWaitingFile.Enabled")));
			this.textBoxHotlineWaitingFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxHotlineWaitingFile.Font")));
			this.textBoxHotlineWaitingFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxHotlineWaitingFile.ImeMode")));
			this.textBoxHotlineWaitingFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxHotlineWaitingFile.Location")));
			this.textBoxHotlineWaitingFile.MaxLength = ((int)(resources.GetObject("textBoxHotlineWaitingFile.MaxLength")));
			this.textBoxHotlineWaitingFile.Multiline = ((bool)(resources.GetObject("textBoxHotlineWaitingFile.Multiline")));
			this.textBoxHotlineWaitingFile.Name = "textBoxHotlineWaitingFile";
			this.textBoxHotlineWaitingFile.PasswordChar = ((char)(resources.GetObject("textBoxHotlineWaitingFile.PasswordChar")));
			this.textBoxHotlineWaitingFile.ReadOnly = true;
			this.textBoxHotlineWaitingFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxHotlineWaitingFile.RightToLeft")));
			this.textBoxHotlineWaitingFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxHotlineWaitingFile.ScrollBars")));
			this.textBoxHotlineWaitingFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxHotlineWaitingFile.Size")));
			this.textBoxHotlineWaitingFile.TabIndex = ((int)(resources.GetObject("textBoxHotlineWaitingFile.TabIndex")));
			this.textBoxHotlineWaitingFile.TabStop = false;
			this.textBoxHotlineWaitingFile.Text = resources.GetString("textBoxHotlineWaitingFile.Text");
			this.textBoxHotlineWaitingFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxHotlineWaitingFile.TextAlign")));
			this.textBoxHotlineWaitingFile.Visible = ((bool)(resources.GetObject("textBoxHotlineWaitingFile.Visible")));
			this.textBoxHotlineWaitingFile.WordWrap = ((bool)(resources.GetObject("textBoxHotlineWaitingFile.WordWrap")));
			// 
			// labelHotlineWaitingFileCap
			// 
			this.labelHotlineWaitingFileCap.AccessibleDescription = resources.GetString("labelHotlineWaitingFileCap.AccessibleDescription");
			this.labelHotlineWaitingFileCap.AccessibleName = resources.GetString("labelHotlineWaitingFileCap.AccessibleName");
			this.labelHotlineWaitingFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineWaitingFileCap.Anchor")));
			this.labelHotlineWaitingFileCap.AutoSize = ((bool)(resources.GetObject("labelHotlineWaitingFileCap.AutoSize")));
			this.labelHotlineWaitingFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineWaitingFileCap.Dock")));
			this.labelHotlineWaitingFileCap.Enabled = ((bool)(resources.GetObject("labelHotlineWaitingFileCap.Enabled")));
			this.labelHotlineWaitingFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineWaitingFileCap.Font")));
			this.labelHotlineWaitingFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineWaitingFileCap.Image")));
			this.labelHotlineWaitingFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineWaitingFileCap.ImageAlign")));
			this.labelHotlineWaitingFileCap.ImageIndex = ((int)(resources.GetObject("labelHotlineWaitingFileCap.ImageIndex")));
			this.labelHotlineWaitingFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineWaitingFileCap.ImeMode")));
			this.labelHotlineWaitingFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineWaitingFileCap.Location")));
			this.labelHotlineWaitingFileCap.Name = "labelHotlineWaitingFileCap";
			this.labelHotlineWaitingFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineWaitingFileCap.RightToLeft")));
			this.labelHotlineWaitingFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineWaitingFileCap.Size")));
			this.labelHotlineWaitingFileCap.TabIndex = ((int)(resources.GetObject("labelHotlineWaitingFileCap.TabIndex")));
			this.labelHotlineWaitingFileCap.Text = resources.GetString("labelHotlineWaitingFileCap.Text");
			this.labelHotlineWaitingFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineWaitingFileCap.TextAlign")));
			this.labelHotlineWaitingFileCap.Visible = ((bool)(resources.GetObject("labelHotlineWaitingFileCap.Visible")));
			// 
			// textBoxHotlineGreetingFile
			// 
			this.textBoxHotlineGreetingFile.AccessibleDescription = resources.GetString("textBoxHotlineGreetingFile.AccessibleDescription");
			this.textBoxHotlineGreetingFile.AccessibleName = resources.GetString("textBoxHotlineGreetingFile.AccessibleName");
			this.textBoxHotlineGreetingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxHotlineGreetingFile.Anchor")));
			this.textBoxHotlineGreetingFile.AutoSize = ((bool)(resources.GetObject("textBoxHotlineGreetingFile.AutoSize")));
			this.textBoxHotlineGreetingFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxHotlineGreetingFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxHotlineGreetingFile.BackgroundImage")));
			this.textBoxHotlineGreetingFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHotlineGreetingFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxHotlineGreetingFile.Dock")));
			this.textBoxHotlineGreetingFile.Enabled = ((bool)(resources.GetObject("textBoxHotlineGreetingFile.Enabled")));
			this.textBoxHotlineGreetingFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxHotlineGreetingFile.Font")));
			this.textBoxHotlineGreetingFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxHotlineGreetingFile.ImeMode")));
			this.textBoxHotlineGreetingFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxHotlineGreetingFile.Location")));
			this.textBoxHotlineGreetingFile.MaxLength = ((int)(resources.GetObject("textBoxHotlineGreetingFile.MaxLength")));
			this.textBoxHotlineGreetingFile.Multiline = ((bool)(resources.GetObject("textBoxHotlineGreetingFile.Multiline")));
			this.textBoxHotlineGreetingFile.Name = "textBoxHotlineGreetingFile";
			this.textBoxHotlineGreetingFile.PasswordChar = ((char)(resources.GetObject("textBoxHotlineGreetingFile.PasswordChar")));
			this.textBoxHotlineGreetingFile.ReadOnly = true;
			this.textBoxHotlineGreetingFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxHotlineGreetingFile.RightToLeft")));
			this.textBoxHotlineGreetingFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxHotlineGreetingFile.ScrollBars")));
			this.textBoxHotlineGreetingFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxHotlineGreetingFile.Size")));
			this.textBoxHotlineGreetingFile.TabIndex = ((int)(resources.GetObject("textBoxHotlineGreetingFile.TabIndex")));
			this.textBoxHotlineGreetingFile.TabStop = false;
			this.textBoxHotlineGreetingFile.Text = resources.GetString("textBoxHotlineGreetingFile.Text");
			this.textBoxHotlineGreetingFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxHotlineGreetingFile.TextAlign")));
			this.textBoxHotlineGreetingFile.Visible = ((bool)(resources.GetObject("textBoxHotlineGreetingFile.Visible")));
			this.textBoxHotlineGreetingFile.WordWrap = ((bool)(resources.GetObject("textBoxHotlineGreetingFile.WordWrap")));
			// 
			// labelHotlineGreetingFileCap
			// 
			this.labelHotlineGreetingFileCap.AccessibleDescription = resources.GetString("labelHotlineGreetingFileCap.AccessibleDescription");
			this.labelHotlineGreetingFileCap.AccessibleName = resources.GetString("labelHotlineGreetingFileCap.AccessibleName");
			this.labelHotlineGreetingFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineGreetingFileCap.Anchor")));
			this.labelHotlineGreetingFileCap.AutoSize = ((bool)(resources.GetObject("labelHotlineGreetingFileCap.AutoSize")));
			this.labelHotlineGreetingFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineGreetingFileCap.Dock")));
			this.labelHotlineGreetingFileCap.Enabled = ((bool)(resources.GetObject("labelHotlineGreetingFileCap.Enabled")));
			this.labelHotlineGreetingFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineGreetingFileCap.Font")));
			this.labelHotlineGreetingFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineGreetingFileCap.Image")));
			this.labelHotlineGreetingFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineGreetingFileCap.ImageAlign")));
			this.labelHotlineGreetingFileCap.ImageIndex = ((int)(resources.GetObject("labelHotlineGreetingFileCap.ImageIndex")));
			this.labelHotlineGreetingFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineGreetingFileCap.ImeMode")));
			this.labelHotlineGreetingFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineGreetingFileCap.Location")));
			this.labelHotlineGreetingFileCap.Name = "labelHotlineGreetingFileCap";
			this.labelHotlineGreetingFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineGreetingFileCap.RightToLeft")));
			this.labelHotlineGreetingFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineGreetingFileCap.Size")));
			this.labelHotlineGreetingFileCap.TabIndex = ((int)(resources.GetObject("labelHotlineGreetingFileCap.TabIndex")));
			this.labelHotlineGreetingFileCap.Text = resources.GetString("labelHotlineGreetingFileCap.Text");
			this.labelHotlineGreetingFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineGreetingFileCap.TextAlign")));
			this.labelHotlineGreetingFileCap.Visible = ((bool)(resources.GetObject("labelHotlineGreetingFileCap.Visible")));
			// 
			// labelHotlineCallPriority
			// 
			this.labelHotlineCallPriority.AccessibleDescription = resources.GetString("labelHotlineCallPriority.AccessibleDescription");
			this.labelHotlineCallPriority.AccessibleName = resources.GetString("labelHotlineCallPriority.AccessibleName");
			this.labelHotlineCallPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineCallPriority.Anchor")));
			this.labelHotlineCallPriority.AutoSize = ((bool)(resources.GetObject("labelHotlineCallPriority.AutoSize")));
			this.labelHotlineCallPriority.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineCallPriority.Dock")));
			this.labelHotlineCallPriority.Enabled = ((bool)(resources.GetObject("labelHotlineCallPriority.Enabled")));
			this.labelHotlineCallPriority.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineCallPriority.Font")));
			this.labelHotlineCallPriority.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineCallPriority.Image")));
			this.labelHotlineCallPriority.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineCallPriority.ImageAlign")));
			this.labelHotlineCallPriority.ImageIndex = ((int)(resources.GetObject("labelHotlineCallPriority.ImageIndex")));
			this.labelHotlineCallPriority.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineCallPriority.ImeMode")));
			this.labelHotlineCallPriority.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineCallPriority.Location")));
			this.labelHotlineCallPriority.Name = "labelHotlineCallPriority";
			this.labelHotlineCallPriority.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineCallPriority.RightToLeft")));
			this.labelHotlineCallPriority.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineCallPriority.Size")));
			this.labelHotlineCallPriority.TabIndex = ((int)(resources.GetObject("labelHotlineCallPriority.TabIndex")));
			this.labelHotlineCallPriority.Text = resources.GetString("labelHotlineCallPriority.Text");
			this.labelHotlineCallPriority.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineCallPriority.TextAlign")));
			this.labelHotlineCallPriority.Visible = ((bool)(resources.GetObject("labelHotlineCallPriority.Visible")));
			// 
			// labelHotlineCallPriorityCap
			// 
			this.labelHotlineCallPriorityCap.AccessibleDescription = resources.GetString("labelHotlineCallPriorityCap.AccessibleDescription");
			this.labelHotlineCallPriorityCap.AccessibleName = resources.GetString("labelHotlineCallPriorityCap.AccessibleName");
			this.labelHotlineCallPriorityCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineCallPriorityCap.Anchor")));
			this.labelHotlineCallPriorityCap.AutoSize = ((bool)(resources.GetObject("labelHotlineCallPriorityCap.AutoSize")));
			this.labelHotlineCallPriorityCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineCallPriorityCap.Dock")));
			this.labelHotlineCallPriorityCap.Enabled = ((bool)(resources.GetObject("labelHotlineCallPriorityCap.Enabled")));
			this.labelHotlineCallPriorityCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineCallPriorityCap.Font")));
			this.labelHotlineCallPriorityCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineCallPriorityCap.Image")));
			this.labelHotlineCallPriorityCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineCallPriorityCap.ImageAlign")));
			this.labelHotlineCallPriorityCap.ImageIndex = ((int)(resources.GetObject("labelHotlineCallPriorityCap.ImageIndex")));
			this.labelHotlineCallPriorityCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineCallPriorityCap.ImeMode")));
			this.labelHotlineCallPriorityCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineCallPriorityCap.Location")));
			this.labelHotlineCallPriorityCap.Name = "labelHotlineCallPriorityCap";
			this.labelHotlineCallPriorityCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineCallPriorityCap.RightToLeft")));
			this.labelHotlineCallPriorityCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineCallPriorityCap.Size")));
			this.labelHotlineCallPriorityCap.TabIndex = ((int)(resources.GetObject("labelHotlineCallPriorityCap.TabIndex")));
			this.labelHotlineCallPriorityCap.Text = resources.GetString("labelHotlineCallPriorityCap.Text");
			this.labelHotlineCallPriorityCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineCallPriorityCap.TextAlign")));
			this.labelHotlineCallPriorityCap.Visible = ((bool)(resources.GetObject("labelHotlineCallPriorityCap.Visible")));
			// 
			// labelHotlineQueueSizeFactor
			// 
			this.labelHotlineQueueSizeFactor.AccessibleDescription = resources.GetString("labelHotlineQueueSizeFactor.AccessibleDescription");
			this.labelHotlineQueueSizeFactor.AccessibleName = resources.GetString("labelHotlineQueueSizeFactor.AccessibleName");
			this.labelHotlineQueueSizeFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineQueueSizeFactor.Anchor")));
			this.labelHotlineQueueSizeFactor.AutoSize = ((bool)(resources.GetObject("labelHotlineQueueSizeFactor.AutoSize")));
			this.labelHotlineQueueSizeFactor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineQueueSizeFactor.Dock")));
			this.labelHotlineQueueSizeFactor.Enabled = ((bool)(resources.GetObject("labelHotlineQueueSizeFactor.Enabled")));
			this.labelHotlineQueueSizeFactor.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineQueueSizeFactor.Font")));
			this.labelHotlineQueueSizeFactor.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineQueueSizeFactor.Image")));
			this.labelHotlineQueueSizeFactor.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineQueueSizeFactor.ImageAlign")));
			this.labelHotlineQueueSizeFactor.ImageIndex = ((int)(resources.GetObject("labelHotlineQueueSizeFactor.ImageIndex")));
			this.labelHotlineQueueSizeFactor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineQueueSizeFactor.ImeMode")));
			this.labelHotlineQueueSizeFactor.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineQueueSizeFactor.Location")));
			this.labelHotlineQueueSizeFactor.Name = "labelHotlineQueueSizeFactor";
			this.labelHotlineQueueSizeFactor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineQueueSizeFactor.RightToLeft")));
			this.labelHotlineQueueSizeFactor.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineQueueSizeFactor.Size")));
			this.labelHotlineQueueSizeFactor.TabIndex = ((int)(resources.GetObject("labelHotlineQueueSizeFactor.TabIndex")));
			this.labelHotlineQueueSizeFactor.Text = resources.GetString("labelHotlineQueueSizeFactor.Text");
			this.labelHotlineQueueSizeFactor.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineQueueSizeFactor.TextAlign")));
			this.labelHotlineQueueSizeFactor.Visible = ((bool)(resources.GetObject("labelHotlineQueueSizeFactor.Visible")));
			// 
			// labelHotlineQueueSizeFactorCap
			// 
			this.labelHotlineQueueSizeFactorCap.AccessibleDescription = resources.GetString("labelHotlineQueueSizeFactorCap.AccessibleDescription");
			this.labelHotlineQueueSizeFactorCap.AccessibleName = resources.GetString("labelHotlineQueueSizeFactorCap.AccessibleName");
			this.labelHotlineQueueSizeFactorCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineQueueSizeFactorCap.Anchor")));
			this.labelHotlineQueueSizeFactorCap.AutoSize = ((bool)(resources.GetObject("labelHotlineQueueSizeFactorCap.AutoSize")));
			this.labelHotlineQueueSizeFactorCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineQueueSizeFactorCap.Dock")));
			this.labelHotlineQueueSizeFactorCap.Enabled = ((bool)(resources.GetObject("labelHotlineQueueSizeFactorCap.Enabled")));
			this.labelHotlineQueueSizeFactorCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineQueueSizeFactorCap.Font")));
			this.labelHotlineQueueSizeFactorCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineQueueSizeFactorCap.Image")));
			this.labelHotlineQueueSizeFactorCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineQueueSizeFactorCap.ImageAlign")));
			this.labelHotlineQueueSizeFactorCap.ImageIndex = ((int)(resources.GetObject("labelHotlineQueueSizeFactorCap.ImageIndex")));
			this.labelHotlineQueueSizeFactorCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineQueueSizeFactorCap.ImeMode")));
			this.labelHotlineQueueSizeFactorCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineQueueSizeFactorCap.Location")));
			this.labelHotlineQueueSizeFactorCap.Name = "labelHotlineQueueSizeFactorCap";
			this.labelHotlineQueueSizeFactorCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineQueueSizeFactorCap.RightToLeft")));
			this.labelHotlineQueueSizeFactorCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineQueueSizeFactorCap.Size")));
			this.labelHotlineQueueSizeFactorCap.TabIndex = ((int)(resources.GetObject("labelHotlineQueueSizeFactorCap.TabIndex")));
			this.labelHotlineQueueSizeFactorCap.Text = resources.GetString("labelHotlineQueueSizeFactorCap.Text");
			this.labelHotlineQueueSizeFactorCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineQueueSizeFactorCap.TextAlign")));
			this.labelHotlineQueueSizeFactorCap.Visible = ((bool)(resources.GetObject("labelHotlineQueueSizeFactorCap.Visible")));
			// 
			// textBoxHotlineNumbers
			// 
			this.textBoxHotlineNumbers.AccessibleDescription = resources.GetString("textBoxHotlineNumbers.AccessibleDescription");
			this.textBoxHotlineNumbers.AccessibleName = resources.GetString("textBoxHotlineNumbers.AccessibleName");
			this.textBoxHotlineNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxHotlineNumbers.Anchor")));
			this.textBoxHotlineNumbers.AutoSize = ((bool)(resources.GetObject("textBoxHotlineNumbers.AutoSize")));
			this.textBoxHotlineNumbers.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxHotlineNumbers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxHotlineNumbers.BackgroundImage")));
			this.textBoxHotlineNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHotlineNumbers.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxHotlineNumbers.Dock")));
			this.textBoxHotlineNumbers.Enabled = ((bool)(resources.GetObject("textBoxHotlineNumbers.Enabled")));
			this.textBoxHotlineNumbers.Font = ((System.Drawing.Font)(resources.GetObject("textBoxHotlineNumbers.Font")));
			this.textBoxHotlineNumbers.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxHotlineNumbers.ImeMode")));
			this.textBoxHotlineNumbers.Location = ((System.Drawing.Point)(resources.GetObject("textBoxHotlineNumbers.Location")));
			this.textBoxHotlineNumbers.MaxLength = ((int)(resources.GetObject("textBoxHotlineNumbers.MaxLength")));
			this.textBoxHotlineNumbers.Multiline = ((bool)(resources.GetObject("textBoxHotlineNumbers.Multiline")));
			this.textBoxHotlineNumbers.Name = "textBoxHotlineNumbers";
			this.textBoxHotlineNumbers.PasswordChar = ((char)(resources.GetObject("textBoxHotlineNumbers.PasswordChar")));
			this.textBoxHotlineNumbers.ReadOnly = true;
			this.textBoxHotlineNumbers.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxHotlineNumbers.RightToLeft")));
			this.textBoxHotlineNumbers.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxHotlineNumbers.ScrollBars")));
			this.textBoxHotlineNumbers.Size = ((System.Drawing.Size)(resources.GetObject("textBoxHotlineNumbers.Size")));
			this.textBoxHotlineNumbers.TabIndex = ((int)(resources.GetObject("textBoxHotlineNumbers.TabIndex")));
			this.textBoxHotlineNumbers.TabStop = false;
			this.textBoxHotlineNumbers.Text = resources.GetString("textBoxHotlineNumbers.Text");
			this.textBoxHotlineNumbers.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxHotlineNumbers.TextAlign")));
			this.textBoxHotlineNumbers.Visible = ((bool)(resources.GetObject("textBoxHotlineNumbers.Visible")));
			this.textBoxHotlineNumbers.WordWrap = ((bool)(resources.GetObject("textBoxHotlineNumbers.WordWrap")));
			// 
			// labelHotlineNumbersCap
			// 
			this.labelHotlineNumbersCap.AccessibleDescription = resources.GetString("labelHotlineNumbersCap.AccessibleDescription");
			this.labelHotlineNumbersCap.AccessibleName = resources.GetString("labelHotlineNumbersCap.AccessibleName");
			this.labelHotlineNumbersCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelHotlineNumbersCap.Anchor")));
			this.labelHotlineNumbersCap.AutoSize = ((bool)(resources.GetObject("labelHotlineNumbersCap.AutoSize")));
			this.labelHotlineNumbersCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelHotlineNumbersCap.Dock")));
			this.labelHotlineNumbersCap.Enabled = ((bool)(resources.GetObject("labelHotlineNumbersCap.Enabled")));
			this.labelHotlineNumbersCap.Font = ((System.Drawing.Font)(resources.GetObject("labelHotlineNumbersCap.Font")));
			this.labelHotlineNumbersCap.Image = ((System.Drawing.Image)(resources.GetObject("labelHotlineNumbersCap.Image")));
			this.labelHotlineNumbersCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineNumbersCap.ImageAlign")));
			this.labelHotlineNumbersCap.ImageIndex = ((int)(resources.GetObject("labelHotlineNumbersCap.ImageIndex")));
			this.labelHotlineNumbersCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelHotlineNumbersCap.ImeMode")));
			this.labelHotlineNumbersCap.Location = ((System.Drawing.Point)(resources.GetObject("labelHotlineNumbersCap.Location")));
			this.labelHotlineNumbersCap.Name = "labelHotlineNumbersCap";
			this.labelHotlineNumbersCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelHotlineNumbersCap.RightToLeft")));
			this.labelHotlineNumbersCap.Size = ((System.Drawing.Size)(resources.GetObject("labelHotlineNumbersCap.Size")));
			this.labelHotlineNumbersCap.TabIndex = ((int)(resources.GetObject("labelHotlineNumbersCap.TabIndex")));
			this.labelHotlineNumbersCap.Text = resources.GetString("labelHotlineNumbersCap.Text");
			this.labelHotlineNumbersCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelHotlineNumbersCap.TextAlign")));
			this.labelHotlineNumbersCap.Visible = ((bool)(resources.GetObject("labelHotlineNumbersCap.Visible")));
			// 
			// groupBoxParameters
			// 
			this.groupBoxParameters.AccessibleDescription = resources.GetString("groupBoxParameters.AccessibleDescription");
			this.groupBoxParameters.AccessibleName = resources.GetString("groupBoxParameters.AccessibleName");
			this.groupBoxParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBoxParameters.Anchor")));
			this.groupBoxParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxParameters.BackgroundImage")));
			this.groupBoxParameters.Controls.Add(this.labelAutoRecording);
			this.groupBoxParameters.Controls.Add(this.labelAutoRecordingCap);
			this.groupBoxParameters.Controls.Add(this.textBoxAbandonmentFile);
			this.groupBoxParameters.Controls.Add(this.labelAbandonmentFileCap);
			this.groupBoxParameters.Controls.Add(this.textBoxAnsweringMachineFile);
			this.groupBoxParameters.Controls.Add(this.labelAnsweringMachineFileCap);
			this.groupBoxParameters.Controls.Add(this.textBoxWaitingFile);
			this.groupBoxParameters.Controls.Add(this.labelWaitingFileCap);
			this.groupBoxParameters.Controls.Add(this.textBoxGreetingFile);
			this.groupBoxParameters.Controls.Add(this.labelGreetingFileCap);
			this.groupBoxParameters.Controls.Add(this.textBoxMusicOnReadyFile);
			this.groupBoxParameters.Controls.Add(this.labelMusicOnReadyFileCap);
			this.groupBoxParameters.Controls.Add(this.labelCallPriority);
			this.groupBoxParameters.Controls.Add(this.labelCallPriorityCap);
			this.groupBoxParameters.Controls.Add(this.labelCPALevel);
			this.groupBoxParameters.Controls.Add(this.labelCPALevelCap);
			this.groupBoxParameters.Controls.Add(this.labelAgentRelaxTargetMea);
			this.groupBoxParameters.Controls.Add(this.labelAgentRelaxTarget);
			this.groupBoxParameters.Controls.Add(this.labelAgentRelaxTargetCap);
			this.groupBoxParameters.Controls.Add(this.labelMaxLostRateMea);
			this.groupBoxParameters.Controls.Add(this.labelMaxLostRate);
			this.groupBoxParameters.Controls.Add(this.labelMaxLostRateCap);
			this.groupBoxParameters.Controls.Add(this.labelMaxDropRateMea);
			this.groupBoxParameters.Controls.Add(this.labelMaxDropRate);
			this.groupBoxParameters.Controls.Add(this.labelMaxDropRateCap);
			this.groupBoxParameters.Controls.Add(this.labelMaxDialRate);
			this.groupBoxParameters.Controls.Add(this.labelMaxDialRateCap);
			this.groupBoxParameters.Controls.Add(this.labelMaxSwitchingTimeMea);
			this.groupBoxParameters.Controls.Add(this.labelMaxSwitchingTime);
			this.groupBoxParameters.Controls.Add(this.labelMaxSwitchingTimeCap);
			this.groupBoxParameters.Controls.Add(this.labelMaxRingCount);
			this.groupBoxParameters.Controls.Add(this.labelMaxRingCountCap);
			this.groupBoxParameters.Controls.Add(this.labelMinRingCount);
			this.groupBoxParameters.Controls.Add(this.labelMinRingCountCap);
			this.groupBoxParameters.Controls.Add(this.labelCallingNumber);
			this.groupBoxParameters.Controls.Add(this.labelCallingNumberCap);
			this.groupBoxParameters.Controls.Add(this.labelCarrierCode);
			this.groupBoxParameters.Controls.Add(this.labelCarrierCodeCap);
			this.groupBoxParameters.Controls.Add(this.labelTrunkGroup);
			this.groupBoxParameters.Controls.Add(this.labelTrunkGroupCap);
			this.groupBoxParameters.Controls.Add(this.labelDialMode);
			this.groupBoxParameters.Controls.Add(this.labelDialModeCap);
			this.groupBoxParameters.Controls.Add(this.labelAvailabilityMode);
			this.groupBoxParameters.Controls.Add(this.labelAvailabilityModeCap);
			this.groupBoxParameters.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBoxParameters.Dock")));
			this.groupBoxParameters.Enabled = ((bool)(resources.GetObject("groupBoxParameters.Enabled")));
			this.groupBoxParameters.Font = ((System.Drawing.Font)(resources.GetObject("groupBoxParameters.Font")));
			this.groupBoxParameters.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBoxParameters.ImeMode")));
			this.groupBoxParameters.Location = ((System.Drawing.Point)(resources.GetObject("groupBoxParameters.Location")));
			this.groupBoxParameters.Name = "groupBoxParameters";
			this.groupBoxParameters.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBoxParameters.RightToLeft")));
			this.groupBoxParameters.Size = ((System.Drawing.Size)(resources.GetObject("groupBoxParameters.Size")));
			this.groupBoxParameters.TabIndex = ((int)(resources.GetObject("groupBoxParameters.TabIndex")));
			this.groupBoxParameters.TabStop = false;
			this.groupBoxParameters.Text = resources.GetString("groupBoxParameters.Text");
			this.groupBoxParameters.Visible = ((bool)(resources.GetObject("groupBoxParameters.Visible")));
			// 
			// labelAutoRecording
			// 
			this.labelAutoRecording.AccessibleDescription = resources.GetString("labelAutoRecording.AccessibleDescription");
			this.labelAutoRecording.AccessibleName = resources.GetString("labelAutoRecording.AccessibleName");
			this.labelAutoRecording.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAutoRecording.Anchor")));
			this.labelAutoRecording.AutoSize = ((bool)(resources.GetObject("labelAutoRecording.AutoSize")));
			this.labelAutoRecording.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAutoRecording.Dock")));
			this.labelAutoRecording.Enabled = ((bool)(resources.GetObject("labelAutoRecording.Enabled")));
			this.labelAutoRecording.Font = ((System.Drawing.Font)(resources.GetObject("labelAutoRecording.Font")));
			this.labelAutoRecording.Image = ((System.Drawing.Image)(resources.GetObject("labelAutoRecording.Image")));
			this.labelAutoRecording.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAutoRecording.ImageAlign")));
			this.labelAutoRecording.ImageIndex = ((int)(resources.GetObject("labelAutoRecording.ImageIndex")));
			this.labelAutoRecording.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAutoRecording.ImeMode")));
			this.labelAutoRecording.Location = ((System.Drawing.Point)(resources.GetObject("labelAutoRecording.Location")));
			this.labelAutoRecording.Name = "labelAutoRecording";
			this.labelAutoRecording.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAutoRecording.RightToLeft")));
			this.labelAutoRecording.Size = ((System.Drawing.Size)(resources.GetObject("labelAutoRecording.Size")));
			this.labelAutoRecording.TabIndex = ((int)(resources.GetObject("labelAutoRecording.TabIndex")));
			this.labelAutoRecording.Text = resources.GetString("labelAutoRecording.Text");
			this.labelAutoRecording.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAutoRecording.TextAlign")));
			this.labelAutoRecording.Visible = ((bool)(resources.GetObject("labelAutoRecording.Visible")));
			// 
			// labelAutoRecordingCap
			// 
			this.labelAutoRecordingCap.AccessibleDescription = resources.GetString("labelAutoRecordingCap.AccessibleDescription");
			this.labelAutoRecordingCap.AccessibleName = resources.GetString("labelAutoRecordingCap.AccessibleName");
			this.labelAutoRecordingCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAutoRecordingCap.Anchor")));
			this.labelAutoRecordingCap.AutoSize = ((bool)(resources.GetObject("labelAutoRecordingCap.AutoSize")));
			this.labelAutoRecordingCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAutoRecordingCap.Dock")));
			this.labelAutoRecordingCap.Enabled = ((bool)(resources.GetObject("labelAutoRecordingCap.Enabled")));
			this.labelAutoRecordingCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAutoRecordingCap.Font")));
			this.labelAutoRecordingCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAutoRecordingCap.Image")));
			this.labelAutoRecordingCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAutoRecordingCap.ImageAlign")));
			this.labelAutoRecordingCap.ImageIndex = ((int)(resources.GetObject("labelAutoRecordingCap.ImageIndex")));
			this.labelAutoRecordingCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAutoRecordingCap.ImeMode")));
			this.labelAutoRecordingCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAutoRecordingCap.Location")));
			this.labelAutoRecordingCap.Name = "labelAutoRecordingCap";
			this.labelAutoRecordingCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAutoRecordingCap.RightToLeft")));
			this.labelAutoRecordingCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAutoRecordingCap.Size")));
			this.labelAutoRecordingCap.TabIndex = ((int)(resources.GetObject("labelAutoRecordingCap.TabIndex")));
			this.labelAutoRecordingCap.Text = resources.GetString("labelAutoRecordingCap.Text");
			this.labelAutoRecordingCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAutoRecordingCap.TextAlign")));
			this.labelAutoRecordingCap.Visible = ((bool)(resources.GetObject("labelAutoRecordingCap.Visible")));
			// 
			// textBoxAbandonmentFile
			// 
			this.textBoxAbandonmentFile.AccessibleDescription = resources.GetString("textBoxAbandonmentFile.AccessibleDescription");
			this.textBoxAbandonmentFile.AccessibleName = resources.GetString("textBoxAbandonmentFile.AccessibleName");
			this.textBoxAbandonmentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxAbandonmentFile.Anchor")));
			this.textBoxAbandonmentFile.AutoSize = ((bool)(resources.GetObject("textBoxAbandonmentFile.AutoSize")));
			this.textBoxAbandonmentFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxAbandonmentFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxAbandonmentFile.BackgroundImage")));
			this.textBoxAbandonmentFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAbandonmentFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxAbandonmentFile.Dock")));
			this.textBoxAbandonmentFile.Enabled = ((bool)(resources.GetObject("textBoxAbandonmentFile.Enabled")));
			this.textBoxAbandonmentFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxAbandonmentFile.Font")));
			this.textBoxAbandonmentFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxAbandonmentFile.ImeMode")));
			this.textBoxAbandonmentFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxAbandonmentFile.Location")));
			this.textBoxAbandonmentFile.MaxLength = ((int)(resources.GetObject("textBoxAbandonmentFile.MaxLength")));
			this.textBoxAbandonmentFile.Multiline = ((bool)(resources.GetObject("textBoxAbandonmentFile.Multiline")));
			this.textBoxAbandonmentFile.Name = "textBoxAbandonmentFile";
			this.textBoxAbandonmentFile.PasswordChar = ((char)(resources.GetObject("textBoxAbandonmentFile.PasswordChar")));
			this.textBoxAbandonmentFile.ReadOnly = true;
			this.textBoxAbandonmentFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxAbandonmentFile.RightToLeft")));
			this.textBoxAbandonmentFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxAbandonmentFile.ScrollBars")));
			this.textBoxAbandonmentFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxAbandonmentFile.Size")));
			this.textBoxAbandonmentFile.TabIndex = ((int)(resources.GetObject("textBoxAbandonmentFile.TabIndex")));
			this.textBoxAbandonmentFile.TabStop = false;
			this.textBoxAbandonmentFile.Text = resources.GetString("textBoxAbandonmentFile.Text");
			this.textBoxAbandonmentFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxAbandonmentFile.TextAlign")));
			this.textBoxAbandonmentFile.Visible = ((bool)(resources.GetObject("textBoxAbandonmentFile.Visible")));
			this.textBoxAbandonmentFile.WordWrap = ((bool)(resources.GetObject("textBoxAbandonmentFile.WordWrap")));
			// 
			// labelAbandonmentFileCap
			// 
			this.labelAbandonmentFileCap.AccessibleDescription = resources.GetString("labelAbandonmentFileCap.AccessibleDescription");
			this.labelAbandonmentFileCap.AccessibleName = resources.GetString("labelAbandonmentFileCap.AccessibleName");
			this.labelAbandonmentFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAbandonmentFileCap.Anchor")));
			this.labelAbandonmentFileCap.AutoSize = ((bool)(resources.GetObject("labelAbandonmentFileCap.AutoSize")));
			this.labelAbandonmentFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAbandonmentFileCap.Dock")));
			this.labelAbandonmentFileCap.Enabled = ((bool)(resources.GetObject("labelAbandonmentFileCap.Enabled")));
			this.labelAbandonmentFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAbandonmentFileCap.Font")));
			this.labelAbandonmentFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAbandonmentFileCap.Image")));
			this.labelAbandonmentFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAbandonmentFileCap.ImageAlign")));
			this.labelAbandonmentFileCap.ImageIndex = ((int)(resources.GetObject("labelAbandonmentFileCap.ImageIndex")));
			this.labelAbandonmentFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAbandonmentFileCap.ImeMode")));
			this.labelAbandonmentFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAbandonmentFileCap.Location")));
			this.labelAbandonmentFileCap.Name = "labelAbandonmentFileCap";
			this.labelAbandonmentFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAbandonmentFileCap.RightToLeft")));
			this.labelAbandonmentFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAbandonmentFileCap.Size")));
			this.labelAbandonmentFileCap.TabIndex = ((int)(resources.GetObject("labelAbandonmentFileCap.TabIndex")));
			this.labelAbandonmentFileCap.Text = resources.GetString("labelAbandonmentFileCap.Text");
			this.labelAbandonmentFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAbandonmentFileCap.TextAlign")));
			this.labelAbandonmentFileCap.Visible = ((bool)(resources.GetObject("labelAbandonmentFileCap.Visible")));
			// 
			// textBoxAnsweringMachineFile
			// 
			this.textBoxAnsweringMachineFile.AccessibleDescription = resources.GetString("textBoxAnsweringMachineFile.AccessibleDescription");
			this.textBoxAnsweringMachineFile.AccessibleName = resources.GetString("textBoxAnsweringMachineFile.AccessibleName");
			this.textBoxAnsweringMachineFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxAnsweringMachineFile.Anchor")));
			this.textBoxAnsweringMachineFile.AutoSize = ((bool)(resources.GetObject("textBoxAnsweringMachineFile.AutoSize")));
			this.textBoxAnsweringMachineFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxAnsweringMachineFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxAnsweringMachineFile.BackgroundImage")));
			this.textBoxAnsweringMachineFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAnsweringMachineFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxAnsweringMachineFile.Dock")));
			this.textBoxAnsweringMachineFile.Enabled = ((bool)(resources.GetObject("textBoxAnsweringMachineFile.Enabled")));
			this.textBoxAnsweringMachineFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxAnsweringMachineFile.Font")));
			this.textBoxAnsweringMachineFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxAnsweringMachineFile.ImeMode")));
			this.textBoxAnsweringMachineFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxAnsweringMachineFile.Location")));
			this.textBoxAnsweringMachineFile.MaxLength = ((int)(resources.GetObject("textBoxAnsweringMachineFile.MaxLength")));
			this.textBoxAnsweringMachineFile.Multiline = ((bool)(resources.GetObject("textBoxAnsweringMachineFile.Multiline")));
			this.textBoxAnsweringMachineFile.Name = "textBoxAnsweringMachineFile";
			this.textBoxAnsweringMachineFile.PasswordChar = ((char)(resources.GetObject("textBoxAnsweringMachineFile.PasswordChar")));
			this.textBoxAnsweringMachineFile.ReadOnly = true;
			this.textBoxAnsweringMachineFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxAnsweringMachineFile.RightToLeft")));
			this.textBoxAnsweringMachineFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxAnsweringMachineFile.ScrollBars")));
			this.textBoxAnsweringMachineFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxAnsweringMachineFile.Size")));
			this.textBoxAnsweringMachineFile.TabIndex = ((int)(resources.GetObject("textBoxAnsweringMachineFile.TabIndex")));
			this.textBoxAnsweringMachineFile.TabStop = false;
			this.textBoxAnsweringMachineFile.Text = resources.GetString("textBoxAnsweringMachineFile.Text");
			this.textBoxAnsweringMachineFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxAnsweringMachineFile.TextAlign")));
			this.textBoxAnsweringMachineFile.Visible = ((bool)(resources.GetObject("textBoxAnsweringMachineFile.Visible")));
			this.textBoxAnsweringMachineFile.WordWrap = ((bool)(resources.GetObject("textBoxAnsweringMachineFile.WordWrap")));
			// 
			// labelAnsweringMachineFileCap
			// 
			this.labelAnsweringMachineFileCap.AccessibleDescription = resources.GetString("labelAnsweringMachineFileCap.AccessibleDescription");
			this.labelAnsweringMachineFileCap.AccessibleName = resources.GetString("labelAnsweringMachineFileCap.AccessibleName");
			this.labelAnsweringMachineFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAnsweringMachineFileCap.Anchor")));
			this.labelAnsweringMachineFileCap.AutoSize = ((bool)(resources.GetObject("labelAnsweringMachineFileCap.AutoSize")));
			this.labelAnsweringMachineFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAnsweringMachineFileCap.Dock")));
			this.labelAnsweringMachineFileCap.Enabled = ((bool)(resources.GetObject("labelAnsweringMachineFileCap.Enabled")));
			this.labelAnsweringMachineFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAnsweringMachineFileCap.Font")));
			this.labelAnsweringMachineFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAnsweringMachineFileCap.Image")));
			this.labelAnsweringMachineFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAnsweringMachineFileCap.ImageAlign")));
			this.labelAnsweringMachineFileCap.ImageIndex = ((int)(resources.GetObject("labelAnsweringMachineFileCap.ImageIndex")));
			this.labelAnsweringMachineFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAnsweringMachineFileCap.ImeMode")));
			this.labelAnsweringMachineFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAnsweringMachineFileCap.Location")));
			this.labelAnsweringMachineFileCap.Name = "labelAnsweringMachineFileCap";
			this.labelAnsweringMachineFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAnsweringMachineFileCap.RightToLeft")));
			this.labelAnsweringMachineFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAnsweringMachineFileCap.Size")));
			this.labelAnsweringMachineFileCap.TabIndex = ((int)(resources.GetObject("labelAnsweringMachineFileCap.TabIndex")));
			this.labelAnsweringMachineFileCap.Text = resources.GetString("labelAnsweringMachineFileCap.Text");
			this.labelAnsweringMachineFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAnsweringMachineFileCap.TextAlign")));
			this.labelAnsweringMachineFileCap.Visible = ((bool)(resources.GetObject("labelAnsweringMachineFileCap.Visible")));
			// 
			// textBoxWaitingFile
			// 
			this.textBoxWaitingFile.AccessibleDescription = resources.GetString("textBoxWaitingFile.AccessibleDescription");
			this.textBoxWaitingFile.AccessibleName = resources.GetString("textBoxWaitingFile.AccessibleName");
			this.textBoxWaitingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxWaitingFile.Anchor")));
			this.textBoxWaitingFile.AutoSize = ((bool)(resources.GetObject("textBoxWaitingFile.AutoSize")));
			this.textBoxWaitingFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxWaitingFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxWaitingFile.BackgroundImage")));
			this.textBoxWaitingFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxWaitingFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxWaitingFile.Dock")));
			this.textBoxWaitingFile.Enabled = ((bool)(resources.GetObject("textBoxWaitingFile.Enabled")));
			this.textBoxWaitingFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxWaitingFile.Font")));
			this.textBoxWaitingFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxWaitingFile.ImeMode")));
			this.textBoxWaitingFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxWaitingFile.Location")));
			this.textBoxWaitingFile.MaxLength = ((int)(resources.GetObject("textBoxWaitingFile.MaxLength")));
			this.textBoxWaitingFile.Multiline = ((bool)(resources.GetObject("textBoxWaitingFile.Multiline")));
			this.textBoxWaitingFile.Name = "textBoxWaitingFile";
			this.textBoxWaitingFile.PasswordChar = ((char)(resources.GetObject("textBoxWaitingFile.PasswordChar")));
			this.textBoxWaitingFile.ReadOnly = true;
			this.textBoxWaitingFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxWaitingFile.RightToLeft")));
			this.textBoxWaitingFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxWaitingFile.ScrollBars")));
			this.textBoxWaitingFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxWaitingFile.Size")));
			this.textBoxWaitingFile.TabIndex = ((int)(resources.GetObject("textBoxWaitingFile.TabIndex")));
			this.textBoxWaitingFile.TabStop = false;
			this.textBoxWaitingFile.Text = resources.GetString("textBoxWaitingFile.Text");
			this.textBoxWaitingFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxWaitingFile.TextAlign")));
			this.textBoxWaitingFile.Visible = ((bool)(resources.GetObject("textBoxWaitingFile.Visible")));
			this.textBoxWaitingFile.WordWrap = ((bool)(resources.GetObject("textBoxWaitingFile.WordWrap")));
			// 
			// labelWaitingFileCap
			// 
			this.labelWaitingFileCap.AccessibleDescription = resources.GetString("labelWaitingFileCap.AccessibleDescription");
			this.labelWaitingFileCap.AccessibleName = resources.GetString("labelWaitingFileCap.AccessibleName");
			this.labelWaitingFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelWaitingFileCap.Anchor")));
			this.labelWaitingFileCap.AutoSize = ((bool)(resources.GetObject("labelWaitingFileCap.AutoSize")));
			this.labelWaitingFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelWaitingFileCap.Dock")));
			this.labelWaitingFileCap.Enabled = ((bool)(resources.GetObject("labelWaitingFileCap.Enabled")));
			this.labelWaitingFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelWaitingFileCap.Font")));
			this.labelWaitingFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelWaitingFileCap.Image")));
			this.labelWaitingFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelWaitingFileCap.ImageAlign")));
			this.labelWaitingFileCap.ImageIndex = ((int)(resources.GetObject("labelWaitingFileCap.ImageIndex")));
			this.labelWaitingFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelWaitingFileCap.ImeMode")));
			this.labelWaitingFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelWaitingFileCap.Location")));
			this.labelWaitingFileCap.Name = "labelWaitingFileCap";
			this.labelWaitingFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelWaitingFileCap.RightToLeft")));
			this.labelWaitingFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelWaitingFileCap.Size")));
			this.labelWaitingFileCap.TabIndex = ((int)(resources.GetObject("labelWaitingFileCap.TabIndex")));
			this.labelWaitingFileCap.Text = resources.GetString("labelWaitingFileCap.Text");
			this.labelWaitingFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelWaitingFileCap.TextAlign")));
			this.labelWaitingFileCap.Visible = ((bool)(resources.GetObject("labelWaitingFileCap.Visible")));
			// 
			// textBoxGreetingFile
			// 
			this.textBoxGreetingFile.AccessibleDescription = resources.GetString("textBoxGreetingFile.AccessibleDescription");
			this.textBoxGreetingFile.AccessibleName = resources.GetString("textBoxGreetingFile.AccessibleName");
			this.textBoxGreetingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxGreetingFile.Anchor")));
			this.textBoxGreetingFile.AutoSize = ((bool)(resources.GetObject("textBoxGreetingFile.AutoSize")));
			this.textBoxGreetingFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxGreetingFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxGreetingFile.BackgroundImage")));
			this.textBoxGreetingFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxGreetingFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxGreetingFile.Dock")));
			this.textBoxGreetingFile.Enabled = ((bool)(resources.GetObject("textBoxGreetingFile.Enabled")));
			this.textBoxGreetingFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxGreetingFile.Font")));
			this.textBoxGreetingFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxGreetingFile.ImeMode")));
			this.textBoxGreetingFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxGreetingFile.Location")));
			this.textBoxGreetingFile.MaxLength = ((int)(resources.GetObject("textBoxGreetingFile.MaxLength")));
			this.textBoxGreetingFile.Multiline = ((bool)(resources.GetObject("textBoxGreetingFile.Multiline")));
			this.textBoxGreetingFile.Name = "textBoxGreetingFile";
			this.textBoxGreetingFile.PasswordChar = ((char)(resources.GetObject("textBoxGreetingFile.PasswordChar")));
			this.textBoxGreetingFile.ReadOnly = true;
			this.textBoxGreetingFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxGreetingFile.RightToLeft")));
			this.textBoxGreetingFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxGreetingFile.ScrollBars")));
			this.textBoxGreetingFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxGreetingFile.Size")));
			this.textBoxGreetingFile.TabIndex = ((int)(resources.GetObject("textBoxGreetingFile.TabIndex")));
			this.textBoxGreetingFile.TabStop = false;
			this.textBoxGreetingFile.Text = resources.GetString("textBoxGreetingFile.Text");
			this.textBoxGreetingFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxGreetingFile.TextAlign")));
			this.textBoxGreetingFile.Visible = ((bool)(resources.GetObject("textBoxGreetingFile.Visible")));
			this.textBoxGreetingFile.WordWrap = ((bool)(resources.GetObject("textBoxGreetingFile.WordWrap")));
			// 
			// labelGreetingFileCap
			// 
			this.labelGreetingFileCap.AccessibleDescription = resources.GetString("labelGreetingFileCap.AccessibleDescription");
			this.labelGreetingFileCap.AccessibleName = resources.GetString("labelGreetingFileCap.AccessibleName");
			this.labelGreetingFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelGreetingFileCap.Anchor")));
			this.labelGreetingFileCap.AutoSize = ((bool)(resources.GetObject("labelGreetingFileCap.AutoSize")));
			this.labelGreetingFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelGreetingFileCap.Dock")));
			this.labelGreetingFileCap.Enabled = ((bool)(resources.GetObject("labelGreetingFileCap.Enabled")));
			this.labelGreetingFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelGreetingFileCap.Font")));
			this.labelGreetingFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelGreetingFileCap.Image")));
			this.labelGreetingFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelGreetingFileCap.ImageAlign")));
			this.labelGreetingFileCap.ImageIndex = ((int)(resources.GetObject("labelGreetingFileCap.ImageIndex")));
			this.labelGreetingFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelGreetingFileCap.ImeMode")));
			this.labelGreetingFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelGreetingFileCap.Location")));
			this.labelGreetingFileCap.Name = "labelGreetingFileCap";
			this.labelGreetingFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelGreetingFileCap.RightToLeft")));
			this.labelGreetingFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelGreetingFileCap.Size")));
			this.labelGreetingFileCap.TabIndex = ((int)(resources.GetObject("labelGreetingFileCap.TabIndex")));
			this.labelGreetingFileCap.Text = resources.GetString("labelGreetingFileCap.Text");
			this.labelGreetingFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelGreetingFileCap.TextAlign")));
			this.labelGreetingFileCap.Visible = ((bool)(resources.GetObject("labelGreetingFileCap.Visible")));
			// 
			// textBoxMusicOnReadyFile
			// 
			this.textBoxMusicOnReadyFile.AccessibleDescription = resources.GetString("textBoxMusicOnReadyFile.AccessibleDescription");
			this.textBoxMusicOnReadyFile.AccessibleName = resources.GetString("textBoxMusicOnReadyFile.AccessibleName");
			this.textBoxMusicOnReadyFile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBoxMusicOnReadyFile.Anchor")));
			this.textBoxMusicOnReadyFile.AutoSize = ((bool)(resources.GetObject("textBoxMusicOnReadyFile.AutoSize")));
			this.textBoxMusicOnReadyFile.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxMusicOnReadyFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxMusicOnReadyFile.BackgroundImage")));
			this.textBoxMusicOnReadyFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxMusicOnReadyFile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBoxMusicOnReadyFile.Dock")));
			this.textBoxMusicOnReadyFile.Enabled = ((bool)(resources.GetObject("textBoxMusicOnReadyFile.Enabled")));
			this.textBoxMusicOnReadyFile.Font = ((System.Drawing.Font)(resources.GetObject("textBoxMusicOnReadyFile.Font")));
			this.textBoxMusicOnReadyFile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBoxMusicOnReadyFile.ImeMode")));
			this.textBoxMusicOnReadyFile.Location = ((System.Drawing.Point)(resources.GetObject("textBoxMusicOnReadyFile.Location")));
			this.textBoxMusicOnReadyFile.MaxLength = ((int)(resources.GetObject("textBoxMusicOnReadyFile.MaxLength")));
			this.textBoxMusicOnReadyFile.Multiline = ((bool)(resources.GetObject("textBoxMusicOnReadyFile.Multiline")));
			this.textBoxMusicOnReadyFile.Name = "textBoxMusicOnReadyFile";
			this.textBoxMusicOnReadyFile.PasswordChar = ((char)(resources.GetObject("textBoxMusicOnReadyFile.PasswordChar")));
			this.textBoxMusicOnReadyFile.ReadOnly = true;
			this.textBoxMusicOnReadyFile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBoxMusicOnReadyFile.RightToLeft")));
			this.textBoxMusicOnReadyFile.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBoxMusicOnReadyFile.ScrollBars")));
			this.textBoxMusicOnReadyFile.Size = ((System.Drawing.Size)(resources.GetObject("textBoxMusicOnReadyFile.Size")));
			this.textBoxMusicOnReadyFile.TabIndex = ((int)(resources.GetObject("textBoxMusicOnReadyFile.TabIndex")));
			this.textBoxMusicOnReadyFile.TabStop = false;
			this.textBoxMusicOnReadyFile.Text = resources.GetString("textBoxMusicOnReadyFile.Text");
			this.textBoxMusicOnReadyFile.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBoxMusicOnReadyFile.TextAlign")));
			this.textBoxMusicOnReadyFile.Visible = ((bool)(resources.GetObject("textBoxMusicOnReadyFile.Visible")));
			this.textBoxMusicOnReadyFile.WordWrap = ((bool)(resources.GetObject("textBoxMusicOnReadyFile.WordWrap")));
			// 
			// labelMusicOnReadyFileCap
			// 
			this.labelMusicOnReadyFileCap.AccessibleDescription = resources.GetString("labelMusicOnReadyFileCap.AccessibleDescription");
			this.labelMusicOnReadyFileCap.AccessibleName = resources.GetString("labelMusicOnReadyFileCap.AccessibleName");
			this.labelMusicOnReadyFileCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMusicOnReadyFileCap.Anchor")));
			this.labelMusicOnReadyFileCap.AutoSize = ((bool)(resources.GetObject("labelMusicOnReadyFileCap.AutoSize")));
			this.labelMusicOnReadyFileCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMusicOnReadyFileCap.Dock")));
			this.labelMusicOnReadyFileCap.Enabled = ((bool)(resources.GetObject("labelMusicOnReadyFileCap.Enabled")));
			this.labelMusicOnReadyFileCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMusicOnReadyFileCap.Font")));
			this.labelMusicOnReadyFileCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMusicOnReadyFileCap.Image")));
			this.labelMusicOnReadyFileCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMusicOnReadyFileCap.ImageAlign")));
			this.labelMusicOnReadyFileCap.ImageIndex = ((int)(resources.GetObject("labelMusicOnReadyFileCap.ImageIndex")));
			this.labelMusicOnReadyFileCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMusicOnReadyFileCap.ImeMode")));
			this.labelMusicOnReadyFileCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMusicOnReadyFileCap.Location")));
			this.labelMusicOnReadyFileCap.Name = "labelMusicOnReadyFileCap";
			this.labelMusicOnReadyFileCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMusicOnReadyFileCap.RightToLeft")));
			this.labelMusicOnReadyFileCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMusicOnReadyFileCap.Size")));
			this.labelMusicOnReadyFileCap.TabIndex = ((int)(resources.GetObject("labelMusicOnReadyFileCap.TabIndex")));
			this.labelMusicOnReadyFileCap.Text = resources.GetString("labelMusicOnReadyFileCap.Text");
			this.labelMusicOnReadyFileCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMusicOnReadyFileCap.TextAlign")));
			this.labelMusicOnReadyFileCap.Visible = ((bool)(resources.GetObject("labelMusicOnReadyFileCap.Visible")));
			// 
			// labelCallPriority
			// 
			this.labelCallPriority.AccessibleDescription = resources.GetString("labelCallPriority.AccessibleDescription");
			this.labelCallPriority.AccessibleName = resources.GetString("labelCallPriority.AccessibleName");
			this.labelCallPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallPriority.Anchor")));
			this.labelCallPriority.AutoSize = ((bool)(resources.GetObject("labelCallPriority.AutoSize")));
			this.labelCallPriority.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallPriority.Dock")));
			this.labelCallPriority.Enabled = ((bool)(resources.GetObject("labelCallPriority.Enabled")));
			this.labelCallPriority.Font = ((System.Drawing.Font)(resources.GetObject("labelCallPriority.Font")));
			this.labelCallPriority.Image = ((System.Drawing.Image)(resources.GetObject("labelCallPriority.Image")));
			this.labelCallPriority.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallPriority.ImageAlign")));
			this.labelCallPriority.ImageIndex = ((int)(resources.GetObject("labelCallPriority.ImageIndex")));
			this.labelCallPriority.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallPriority.ImeMode")));
			this.labelCallPriority.Location = ((System.Drawing.Point)(resources.GetObject("labelCallPriority.Location")));
			this.labelCallPriority.Name = "labelCallPriority";
			this.labelCallPriority.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallPriority.RightToLeft")));
			this.labelCallPriority.Size = ((System.Drawing.Size)(resources.GetObject("labelCallPriority.Size")));
			this.labelCallPriority.TabIndex = ((int)(resources.GetObject("labelCallPriority.TabIndex")));
			this.labelCallPriority.Text = resources.GetString("labelCallPriority.Text");
			this.labelCallPriority.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallPriority.TextAlign")));
			this.labelCallPriority.Visible = ((bool)(resources.GetObject("labelCallPriority.Visible")));
			// 
			// labelCallPriorityCap
			// 
			this.labelCallPriorityCap.AccessibleDescription = resources.GetString("labelCallPriorityCap.AccessibleDescription");
			this.labelCallPriorityCap.AccessibleName = resources.GetString("labelCallPriorityCap.AccessibleName");
			this.labelCallPriorityCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallPriorityCap.Anchor")));
			this.labelCallPriorityCap.AutoSize = ((bool)(resources.GetObject("labelCallPriorityCap.AutoSize")));
			this.labelCallPriorityCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallPriorityCap.Dock")));
			this.labelCallPriorityCap.Enabled = ((bool)(resources.GetObject("labelCallPriorityCap.Enabled")));
			this.labelCallPriorityCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallPriorityCap.Font")));
			this.labelCallPriorityCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallPriorityCap.Image")));
			this.labelCallPriorityCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallPriorityCap.ImageAlign")));
			this.labelCallPriorityCap.ImageIndex = ((int)(resources.GetObject("labelCallPriorityCap.ImageIndex")));
			this.labelCallPriorityCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallPriorityCap.ImeMode")));
			this.labelCallPriorityCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallPriorityCap.Location")));
			this.labelCallPriorityCap.Name = "labelCallPriorityCap";
			this.labelCallPriorityCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallPriorityCap.RightToLeft")));
			this.labelCallPriorityCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallPriorityCap.Size")));
			this.labelCallPriorityCap.TabIndex = ((int)(resources.GetObject("labelCallPriorityCap.TabIndex")));
			this.labelCallPriorityCap.Text = resources.GetString("labelCallPriorityCap.Text");
			this.labelCallPriorityCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallPriorityCap.TextAlign")));
			this.labelCallPriorityCap.Visible = ((bool)(resources.GetObject("labelCallPriorityCap.Visible")));
			// 
			// labelCPALevel
			// 
			this.labelCPALevel.AccessibleDescription = resources.GetString("labelCPALevel.AccessibleDescription");
			this.labelCPALevel.AccessibleName = resources.GetString("labelCPALevel.AccessibleName");
			this.labelCPALevel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCPALevel.Anchor")));
			this.labelCPALevel.AutoSize = ((bool)(resources.GetObject("labelCPALevel.AutoSize")));
			this.labelCPALevel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCPALevel.Dock")));
			this.labelCPALevel.Enabled = ((bool)(resources.GetObject("labelCPALevel.Enabled")));
			this.labelCPALevel.Font = ((System.Drawing.Font)(resources.GetObject("labelCPALevel.Font")));
			this.labelCPALevel.Image = ((System.Drawing.Image)(resources.GetObject("labelCPALevel.Image")));
			this.labelCPALevel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCPALevel.ImageAlign")));
			this.labelCPALevel.ImageIndex = ((int)(resources.GetObject("labelCPALevel.ImageIndex")));
			this.labelCPALevel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCPALevel.ImeMode")));
			this.labelCPALevel.Location = ((System.Drawing.Point)(resources.GetObject("labelCPALevel.Location")));
			this.labelCPALevel.Name = "labelCPALevel";
			this.labelCPALevel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCPALevel.RightToLeft")));
			this.labelCPALevel.Size = ((System.Drawing.Size)(resources.GetObject("labelCPALevel.Size")));
			this.labelCPALevel.TabIndex = ((int)(resources.GetObject("labelCPALevel.TabIndex")));
			this.labelCPALevel.Text = resources.GetString("labelCPALevel.Text");
			this.labelCPALevel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCPALevel.TextAlign")));
			this.labelCPALevel.Visible = ((bool)(resources.GetObject("labelCPALevel.Visible")));
			// 
			// labelCPALevelCap
			// 
			this.labelCPALevelCap.AccessibleDescription = resources.GetString("labelCPALevelCap.AccessibleDescription");
			this.labelCPALevelCap.AccessibleName = resources.GetString("labelCPALevelCap.AccessibleName");
			this.labelCPALevelCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCPALevelCap.Anchor")));
			this.labelCPALevelCap.AutoSize = ((bool)(resources.GetObject("labelCPALevelCap.AutoSize")));
			this.labelCPALevelCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCPALevelCap.Dock")));
			this.labelCPALevelCap.Enabled = ((bool)(resources.GetObject("labelCPALevelCap.Enabled")));
			this.labelCPALevelCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCPALevelCap.Font")));
			this.labelCPALevelCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCPALevelCap.Image")));
			this.labelCPALevelCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCPALevelCap.ImageAlign")));
			this.labelCPALevelCap.ImageIndex = ((int)(resources.GetObject("labelCPALevelCap.ImageIndex")));
			this.labelCPALevelCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCPALevelCap.ImeMode")));
			this.labelCPALevelCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCPALevelCap.Location")));
			this.labelCPALevelCap.Name = "labelCPALevelCap";
			this.labelCPALevelCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCPALevelCap.RightToLeft")));
			this.labelCPALevelCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCPALevelCap.Size")));
			this.labelCPALevelCap.TabIndex = ((int)(resources.GetObject("labelCPALevelCap.TabIndex")));
			this.labelCPALevelCap.Text = resources.GetString("labelCPALevelCap.Text");
			this.labelCPALevelCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCPALevelCap.TextAlign")));
			this.labelCPALevelCap.Visible = ((bool)(resources.GetObject("labelCPALevelCap.Visible")));
			// 
			// labelAgentRelaxTargetMea
			// 
			this.labelAgentRelaxTargetMea.AccessibleDescription = resources.GetString("labelAgentRelaxTargetMea.AccessibleDescription");
			this.labelAgentRelaxTargetMea.AccessibleName = resources.GetString("labelAgentRelaxTargetMea.AccessibleName");
			this.labelAgentRelaxTargetMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTargetMea.Anchor")));
			this.labelAgentRelaxTargetMea.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTargetMea.AutoSize")));
			this.labelAgentRelaxTargetMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTargetMea.Dock")));
			this.labelAgentRelaxTargetMea.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTargetMea.Enabled")));
			this.labelAgentRelaxTargetMea.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTargetMea.Font")));
			this.labelAgentRelaxTargetMea.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTargetMea.Image")));
			this.labelAgentRelaxTargetMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTargetMea.ImageAlign")));
			this.labelAgentRelaxTargetMea.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTargetMea.ImageIndex")));
			this.labelAgentRelaxTargetMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTargetMea.ImeMode")));
			this.labelAgentRelaxTargetMea.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTargetMea.Location")));
			this.labelAgentRelaxTargetMea.Name = "labelAgentRelaxTargetMea";
			this.labelAgentRelaxTargetMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTargetMea.RightToLeft")));
			this.labelAgentRelaxTargetMea.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTargetMea.Size")));
			this.labelAgentRelaxTargetMea.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTargetMea.TabIndex")));
			this.labelAgentRelaxTargetMea.Text = resources.GetString("labelAgentRelaxTargetMea.Text");
			this.labelAgentRelaxTargetMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTargetMea.TextAlign")));
			this.labelAgentRelaxTargetMea.Visible = ((bool)(resources.GetObject("labelAgentRelaxTargetMea.Visible")));
			// 
			// labelAgentRelaxTarget
			// 
			this.labelAgentRelaxTarget.AccessibleDescription = resources.GetString("labelAgentRelaxTarget.AccessibleDescription");
			this.labelAgentRelaxTarget.AccessibleName = resources.GetString("labelAgentRelaxTarget.AccessibleName");
			this.labelAgentRelaxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTarget.Anchor")));
			this.labelAgentRelaxTarget.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTarget.AutoSize")));
			this.labelAgentRelaxTarget.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTarget.Dock")));
			this.labelAgentRelaxTarget.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTarget.Enabled")));
			this.labelAgentRelaxTarget.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTarget.Font")));
			this.labelAgentRelaxTarget.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTarget.Image")));
			this.labelAgentRelaxTarget.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTarget.ImageAlign")));
			this.labelAgentRelaxTarget.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTarget.ImageIndex")));
			this.labelAgentRelaxTarget.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTarget.ImeMode")));
			this.labelAgentRelaxTarget.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTarget.Location")));
			this.labelAgentRelaxTarget.Name = "labelAgentRelaxTarget";
			this.labelAgentRelaxTarget.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTarget.RightToLeft")));
			this.labelAgentRelaxTarget.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTarget.Size")));
			this.labelAgentRelaxTarget.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTarget.TabIndex")));
			this.labelAgentRelaxTarget.Text = resources.GetString("labelAgentRelaxTarget.Text");
			this.labelAgentRelaxTarget.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTarget.TextAlign")));
			this.labelAgentRelaxTarget.Visible = ((bool)(resources.GetObject("labelAgentRelaxTarget.Visible")));
			// 
			// labelAgentRelaxTargetCap
			// 
			this.labelAgentRelaxTargetCap.AccessibleDescription = resources.GetString("labelAgentRelaxTargetCap.AccessibleDescription");
			this.labelAgentRelaxTargetCap.AccessibleName = resources.GetString("labelAgentRelaxTargetCap.AccessibleName");
			this.labelAgentRelaxTargetCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAgentRelaxTargetCap.Anchor")));
			this.labelAgentRelaxTargetCap.AutoSize = ((bool)(resources.GetObject("labelAgentRelaxTargetCap.AutoSize")));
			this.labelAgentRelaxTargetCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAgentRelaxTargetCap.Dock")));
			this.labelAgentRelaxTargetCap.Enabled = ((bool)(resources.GetObject("labelAgentRelaxTargetCap.Enabled")));
			this.labelAgentRelaxTargetCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAgentRelaxTargetCap.Font")));
			this.labelAgentRelaxTargetCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAgentRelaxTargetCap.Image")));
			this.labelAgentRelaxTargetCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTargetCap.ImageAlign")));
			this.labelAgentRelaxTargetCap.ImageIndex = ((int)(resources.GetObject("labelAgentRelaxTargetCap.ImageIndex")));
			this.labelAgentRelaxTargetCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAgentRelaxTargetCap.ImeMode")));
			this.labelAgentRelaxTargetCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAgentRelaxTargetCap.Location")));
			this.labelAgentRelaxTargetCap.Name = "labelAgentRelaxTargetCap";
			this.labelAgentRelaxTargetCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAgentRelaxTargetCap.RightToLeft")));
			this.labelAgentRelaxTargetCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAgentRelaxTargetCap.Size")));
			this.labelAgentRelaxTargetCap.TabIndex = ((int)(resources.GetObject("labelAgentRelaxTargetCap.TabIndex")));
			this.labelAgentRelaxTargetCap.Text = resources.GetString("labelAgentRelaxTargetCap.Text");
			this.labelAgentRelaxTargetCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAgentRelaxTargetCap.TextAlign")));
			this.labelAgentRelaxTargetCap.Visible = ((bool)(resources.GetObject("labelAgentRelaxTargetCap.Visible")));
			// 
			// labelMaxLostRateMea
			// 
			this.labelMaxLostRateMea.AccessibleDescription = resources.GetString("labelMaxLostRateMea.AccessibleDescription");
			this.labelMaxLostRateMea.AccessibleName = resources.GetString("labelMaxLostRateMea.AccessibleName");
			this.labelMaxLostRateMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxLostRateMea.Anchor")));
			this.labelMaxLostRateMea.AutoSize = ((bool)(resources.GetObject("labelMaxLostRateMea.AutoSize")));
			this.labelMaxLostRateMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxLostRateMea.Dock")));
			this.labelMaxLostRateMea.Enabled = ((bool)(resources.GetObject("labelMaxLostRateMea.Enabled")));
			this.labelMaxLostRateMea.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxLostRateMea.Font")));
			this.labelMaxLostRateMea.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxLostRateMea.Image")));
			this.labelMaxLostRateMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRateMea.ImageAlign")));
			this.labelMaxLostRateMea.ImageIndex = ((int)(resources.GetObject("labelMaxLostRateMea.ImageIndex")));
			this.labelMaxLostRateMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxLostRateMea.ImeMode")));
			this.labelMaxLostRateMea.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxLostRateMea.Location")));
			this.labelMaxLostRateMea.Name = "labelMaxLostRateMea";
			this.labelMaxLostRateMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxLostRateMea.RightToLeft")));
			this.labelMaxLostRateMea.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxLostRateMea.Size")));
			this.labelMaxLostRateMea.TabIndex = ((int)(resources.GetObject("labelMaxLostRateMea.TabIndex")));
			this.labelMaxLostRateMea.Text = resources.GetString("labelMaxLostRateMea.Text");
			this.labelMaxLostRateMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRateMea.TextAlign")));
			this.labelMaxLostRateMea.Visible = ((bool)(resources.GetObject("labelMaxLostRateMea.Visible")));
			// 
			// labelMaxLostRate
			// 
			this.labelMaxLostRate.AccessibleDescription = resources.GetString("labelMaxLostRate.AccessibleDescription");
			this.labelMaxLostRate.AccessibleName = resources.GetString("labelMaxLostRate.AccessibleName");
			this.labelMaxLostRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxLostRate.Anchor")));
			this.labelMaxLostRate.AutoSize = ((bool)(resources.GetObject("labelMaxLostRate.AutoSize")));
			this.labelMaxLostRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxLostRate.Dock")));
			this.labelMaxLostRate.Enabled = ((bool)(resources.GetObject("labelMaxLostRate.Enabled")));
			this.labelMaxLostRate.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxLostRate.Font")));
			this.labelMaxLostRate.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxLostRate.Image")));
			this.labelMaxLostRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRate.ImageAlign")));
			this.labelMaxLostRate.ImageIndex = ((int)(resources.GetObject("labelMaxLostRate.ImageIndex")));
			this.labelMaxLostRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxLostRate.ImeMode")));
			this.labelMaxLostRate.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxLostRate.Location")));
			this.labelMaxLostRate.Name = "labelMaxLostRate";
			this.labelMaxLostRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxLostRate.RightToLeft")));
			this.labelMaxLostRate.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxLostRate.Size")));
			this.labelMaxLostRate.TabIndex = ((int)(resources.GetObject("labelMaxLostRate.TabIndex")));
			this.labelMaxLostRate.Text = resources.GetString("labelMaxLostRate.Text");
			this.labelMaxLostRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRate.TextAlign")));
			this.labelMaxLostRate.Visible = ((bool)(resources.GetObject("labelMaxLostRate.Visible")));
			// 
			// labelMaxLostRateCap
			// 
			this.labelMaxLostRateCap.AccessibleDescription = resources.GetString("labelMaxLostRateCap.AccessibleDescription");
			this.labelMaxLostRateCap.AccessibleName = resources.GetString("labelMaxLostRateCap.AccessibleName");
			this.labelMaxLostRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxLostRateCap.Anchor")));
			this.labelMaxLostRateCap.AutoSize = ((bool)(resources.GetObject("labelMaxLostRateCap.AutoSize")));
			this.labelMaxLostRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxLostRateCap.Dock")));
			this.labelMaxLostRateCap.Enabled = ((bool)(resources.GetObject("labelMaxLostRateCap.Enabled")));
			this.labelMaxLostRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxLostRateCap.Font")));
			this.labelMaxLostRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxLostRateCap.Image")));
			this.labelMaxLostRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRateCap.ImageAlign")));
			this.labelMaxLostRateCap.ImageIndex = ((int)(resources.GetObject("labelMaxLostRateCap.ImageIndex")));
			this.labelMaxLostRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxLostRateCap.ImeMode")));
			this.labelMaxLostRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxLostRateCap.Location")));
			this.labelMaxLostRateCap.Name = "labelMaxLostRateCap";
			this.labelMaxLostRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxLostRateCap.RightToLeft")));
			this.labelMaxLostRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxLostRateCap.Size")));
			this.labelMaxLostRateCap.TabIndex = ((int)(resources.GetObject("labelMaxLostRateCap.TabIndex")));
			this.labelMaxLostRateCap.Text = resources.GetString("labelMaxLostRateCap.Text");
			this.labelMaxLostRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxLostRateCap.TextAlign")));
			this.labelMaxLostRateCap.Visible = ((bool)(resources.GetObject("labelMaxLostRateCap.Visible")));
			// 
			// labelMaxDropRateMea
			// 
			this.labelMaxDropRateMea.AccessibleDescription = resources.GetString("labelMaxDropRateMea.AccessibleDescription");
			this.labelMaxDropRateMea.AccessibleName = resources.GetString("labelMaxDropRateMea.AccessibleName");
			this.labelMaxDropRateMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxDropRateMea.Anchor")));
			this.labelMaxDropRateMea.AutoSize = ((bool)(resources.GetObject("labelMaxDropRateMea.AutoSize")));
			this.labelMaxDropRateMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxDropRateMea.Dock")));
			this.labelMaxDropRateMea.Enabled = ((bool)(resources.GetObject("labelMaxDropRateMea.Enabled")));
			this.labelMaxDropRateMea.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxDropRateMea.Font")));
			this.labelMaxDropRateMea.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxDropRateMea.Image")));
			this.labelMaxDropRateMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRateMea.ImageAlign")));
			this.labelMaxDropRateMea.ImageIndex = ((int)(resources.GetObject("labelMaxDropRateMea.ImageIndex")));
			this.labelMaxDropRateMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxDropRateMea.ImeMode")));
			this.labelMaxDropRateMea.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxDropRateMea.Location")));
			this.labelMaxDropRateMea.Name = "labelMaxDropRateMea";
			this.labelMaxDropRateMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxDropRateMea.RightToLeft")));
			this.labelMaxDropRateMea.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxDropRateMea.Size")));
			this.labelMaxDropRateMea.TabIndex = ((int)(resources.GetObject("labelMaxDropRateMea.TabIndex")));
			this.labelMaxDropRateMea.Text = resources.GetString("labelMaxDropRateMea.Text");
			this.labelMaxDropRateMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRateMea.TextAlign")));
			this.labelMaxDropRateMea.Visible = ((bool)(resources.GetObject("labelMaxDropRateMea.Visible")));
			// 
			// labelMaxDropRate
			// 
			this.labelMaxDropRate.AccessibleDescription = resources.GetString("labelMaxDropRate.AccessibleDescription");
			this.labelMaxDropRate.AccessibleName = resources.GetString("labelMaxDropRate.AccessibleName");
			this.labelMaxDropRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxDropRate.Anchor")));
			this.labelMaxDropRate.AutoSize = ((bool)(resources.GetObject("labelMaxDropRate.AutoSize")));
			this.labelMaxDropRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxDropRate.Dock")));
			this.labelMaxDropRate.Enabled = ((bool)(resources.GetObject("labelMaxDropRate.Enabled")));
			this.labelMaxDropRate.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxDropRate.Font")));
			this.labelMaxDropRate.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxDropRate.Image")));
			this.labelMaxDropRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRate.ImageAlign")));
			this.labelMaxDropRate.ImageIndex = ((int)(resources.GetObject("labelMaxDropRate.ImageIndex")));
			this.labelMaxDropRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxDropRate.ImeMode")));
			this.labelMaxDropRate.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxDropRate.Location")));
			this.labelMaxDropRate.Name = "labelMaxDropRate";
			this.labelMaxDropRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxDropRate.RightToLeft")));
			this.labelMaxDropRate.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxDropRate.Size")));
			this.labelMaxDropRate.TabIndex = ((int)(resources.GetObject("labelMaxDropRate.TabIndex")));
			this.labelMaxDropRate.Text = resources.GetString("labelMaxDropRate.Text");
			this.labelMaxDropRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRate.TextAlign")));
			this.labelMaxDropRate.Visible = ((bool)(resources.GetObject("labelMaxDropRate.Visible")));
			// 
			// labelMaxDropRateCap
			// 
			this.labelMaxDropRateCap.AccessibleDescription = resources.GetString("labelMaxDropRateCap.AccessibleDescription");
			this.labelMaxDropRateCap.AccessibleName = resources.GetString("labelMaxDropRateCap.AccessibleName");
			this.labelMaxDropRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxDropRateCap.Anchor")));
			this.labelMaxDropRateCap.AutoSize = ((bool)(resources.GetObject("labelMaxDropRateCap.AutoSize")));
			this.labelMaxDropRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxDropRateCap.Dock")));
			this.labelMaxDropRateCap.Enabled = ((bool)(resources.GetObject("labelMaxDropRateCap.Enabled")));
			this.labelMaxDropRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxDropRateCap.Font")));
			this.labelMaxDropRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxDropRateCap.Image")));
			this.labelMaxDropRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRateCap.ImageAlign")));
			this.labelMaxDropRateCap.ImageIndex = ((int)(resources.GetObject("labelMaxDropRateCap.ImageIndex")));
			this.labelMaxDropRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxDropRateCap.ImeMode")));
			this.labelMaxDropRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxDropRateCap.Location")));
			this.labelMaxDropRateCap.Name = "labelMaxDropRateCap";
			this.labelMaxDropRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxDropRateCap.RightToLeft")));
			this.labelMaxDropRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxDropRateCap.Size")));
			this.labelMaxDropRateCap.TabIndex = ((int)(resources.GetObject("labelMaxDropRateCap.TabIndex")));
			this.labelMaxDropRateCap.Text = resources.GetString("labelMaxDropRateCap.Text");
			this.labelMaxDropRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDropRateCap.TextAlign")));
			this.labelMaxDropRateCap.Visible = ((bool)(resources.GetObject("labelMaxDropRateCap.Visible")));
			// 
			// labelMaxDialRate
			// 
			this.labelMaxDialRate.AccessibleDescription = resources.GetString("labelMaxDialRate.AccessibleDescription");
			this.labelMaxDialRate.AccessibleName = resources.GetString("labelMaxDialRate.AccessibleName");
			this.labelMaxDialRate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxDialRate.Anchor")));
			this.labelMaxDialRate.AutoSize = ((bool)(resources.GetObject("labelMaxDialRate.AutoSize")));
			this.labelMaxDialRate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxDialRate.Dock")));
			this.labelMaxDialRate.Enabled = ((bool)(resources.GetObject("labelMaxDialRate.Enabled")));
			this.labelMaxDialRate.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxDialRate.Font")));
			this.labelMaxDialRate.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxDialRate.Image")));
			this.labelMaxDialRate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDialRate.ImageAlign")));
			this.labelMaxDialRate.ImageIndex = ((int)(resources.GetObject("labelMaxDialRate.ImageIndex")));
			this.labelMaxDialRate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxDialRate.ImeMode")));
			this.labelMaxDialRate.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxDialRate.Location")));
			this.labelMaxDialRate.Name = "labelMaxDialRate";
			this.labelMaxDialRate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxDialRate.RightToLeft")));
			this.labelMaxDialRate.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxDialRate.Size")));
			this.labelMaxDialRate.TabIndex = ((int)(resources.GetObject("labelMaxDialRate.TabIndex")));
			this.labelMaxDialRate.Text = resources.GetString("labelMaxDialRate.Text");
			this.labelMaxDialRate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDialRate.TextAlign")));
			this.labelMaxDialRate.Visible = ((bool)(resources.GetObject("labelMaxDialRate.Visible")));
			// 
			// labelMaxDialRateCap
			// 
			this.labelMaxDialRateCap.AccessibleDescription = resources.GetString("labelMaxDialRateCap.AccessibleDescription");
			this.labelMaxDialRateCap.AccessibleName = resources.GetString("labelMaxDialRateCap.AccessibleName");
			this.labelMaxDialRateCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxDialRateCap.Anchor")));
			this.labelMaxDialRateCap.AutoSize = ((bool)(resources.GetObject("labelMaxDialRateCap.AutoSize")));
			this.labelMaxDialRateCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxDialRateCap.Dock")));
			this.labelMaxDialRateCap.Enabled = ((bool)(resources.GetObject("labelMaxDialRateCap.Enabled")));
			this.labelMaxDialRateCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxDialRateCap.Font")));
			this.labelMaxDialRateCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxDialRateCap.Image")));
			this.labelMaxDialRateCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDialRateCap.ImageAlign")));
			this.labelMaxDialRateCap.ImageIndex = ((int)(resources.GetObject("labelMaxDialRateCap.ImageIndex")));
			this.labelMaxDialRateCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxDialRateCap.ImeMode")));
			this.labelMaxDialRateCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxDialRateCap.Location")));
			this.labelMaxDialRateCap.Name = "labelMaxDialRateCap";
			this.labelMaxDialRateCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxDialRateCap.RightToLeft")));
			this.labelMaxDialRateCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxDialRateCap.Size")));
			this.labelMaxDialRateCap.TabIndex = ((int)(resources.GetObject("labelMaxDialRateCap.TabIndex")));
			this.labelMaxDialRateCap.Text = resources.GetString("labelMaxDialRateCap.Text");
			this.labelMaxDialRateCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxDialRateCap.TextAlign")));
			this.labelMaxDialRateCap.Visible = ((bool)(resources.GetObject("labelMaxDialRateCap.Visible")));
			// 
			// labelMaxSwitchingTimeMea
			// 
			this.labelMaxSwitchingTimeMea.AccessibleDescription = resources.GetString("labelMaxSwitchingTimeMea.AccessibleDescription");
			this.labelMaxSwitchingTimeMea.AccessibleName = resources.GetString("labelMaxSwitchingTimeMea.AccessibleName");
			this.labelMaxSwitchingTimeMea.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxSwitchingTimeMea.Anchor")));
			this.labelMaxSwitchingTimeMea.AutoSize = ((bool)(resources.GetObject("labelMaxSwitchingTimeMea.AutoSize")));
			this.labelMaxSwitchingTimeMea.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxSwitchingTimeMea.Dock")));
			this.labelMaxSwitchingTimeMea.Enabled = ((bool)(resources.GetObject("labelMaxSwitchingTimeMea.Enabled")));
			this.labelMaxSwitchingTimeMea.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxSwitchingTimeMea.Font")));
			this.labelMaxSwitchingTimeMea.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxSwitchingTimeMea.Image")));
			this.labelMaxSwitchingTimeMea.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTimeMea.ImageAlign")));
			this.labelMaxSwitchingTimeMea.ImageIndex = ((int)(resources.GetObject("labelMaxSwitchingTimeMea.ImageIndex")));
			this.labelMaxSwitchingTimeMea.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxSwitchingTimeMea.ImeMode")));
			this.labelMaxSwitchingTimeMea.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxSwitchingTimeMea.Location")));
			this.labelMaxSwitchingTimeMea.Name = "labelMaxSwitchingTimeMea";
			this.labelMaxSwitchingTimeMea.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxSwitchingTimeMea.RightToLeft")));
			this.labelMaxSwitchingTimeMea.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxSwitchingTimeMea.Size")));
			this.labelMaxSwitchingTimeMea.TabIndex = ((int)(resources.GetObject("labelMaxSwitchingTimeMea.TabIndex")));
			this.labelMaxSwitchingTimeMea.Text = resources.GetString("labelMaxSwitchingTimeMea.Text");
			this.labelMaxSwitchingTimeMea.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTimeMea.TextAlign")));
			this.labelMaxSwitchingTimeMea.Visible = ((bool)(resources.GetObject("labelMaxSwitchingTimeMea.Visible")));
			// 
			// labelMaxSwitchingTime
			// 
			this.labelMaxSwitchingTime.AccessibleDescription = resources.GetString("labelMaxSwitchingTime.AccessibleDescription");
			this.labelMaxSwitchingTime.AccessibleName = resources.GetString("labelMaxSwitchingTime.AccessibleName");
			this.labelMaxSwitchingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxSwitchingTime.Anchor")));
			this.labelMaxSwitchingTime.AutoSize = ((bool)(resources.GetObject("labelMaxSwitchingTime.AutoSize")));
			this.labelMaxSwitchingTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxSwitchingTime.Dock")));
			this.labelMaxSwitchingTime.Enabled = ((bool)(resources.GetObject("labelMaxSwitchingTime.Enabled")));
			this.labelMaxSwitchingTime.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxSwitchingTime.Font")));
			this.labelMaxSwitchingTime.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxSwitchingTime.Image")));
			this.labelMaxSwitchingTime.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTime.ImageAlign")));
			this.labelMaxSwitchingTime.ImageIndex = ((int)(resources.GetObject("labelMaxSwitchingTime.ImageIndex")));
			this.labelMaxSwitchingTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxSwitchingTime.ImeMode")));
			this.labelMaxSwitchingTime.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxSwitchingTime.Location")));
			this.labelMaxSwitchingTime.Name = "labelMaxSwitchingTime";
			this.labelMaxSwitchingTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxSwitchingTime.RightToLeft")));
			this.labelMaxSwitchingTime.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxSwitchingTime.Size")));
			this.labelMaxSwitchingTime.TabIndex = ((int)(resources.GetObject("labelMaxSwitchingTime.TabIndex")));
			this.labelMaxSwitchingTime.Text = resources.GetString("labelMaxSwitchingTime.Text");
			this.labelMaxSwitchingTime.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTime.TextAlign")));
			this.labelMaxSwitchingTime.Visible = ((bool)(resources.GetObject("labelMaxSwitchingTime.Visible")));
			// 
			// labelMaxSwitchingTimeCap
			// 
			this.labelMaxSwitchingTimeCap.AccessibleDescription = resources.GetString("labelMaxSwitchingTimeCap.AccessibleDescription");
			this.labelMaxSwitchingTimeCap.AccessibleName = resources.GetString("labelMaxSwitchingTimeCap.AccessibleName");
			this.labelMaxSwitchingTimeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxSwitchingTimeCap.Anchor")));
			this.labelMaxSwitchingTimeCap.AutoSize = ((bool)(resources.GetObject("labelMaxSwitchingTimeCap.AutoSize")));
			this.labelMaxSwitchingTimeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxSwitchingTimeCap.Dock")));
			this.labelMaxSwitchingTimeCap.Enabled = ((bool)(resources.GetObject("labelMaxSwitchingTimeCap.Enabled")));
			this.labelMaxSwitchingTimeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxSwitchingTimeCap.Font")));
			this.labelMaxSwitchingTimeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxSwitchingTimeCap.Image")));
			this.labelMaxSwitchingTimeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTimeCap.ImageAlign")));
			this.labelMaxSwitchingTimeCap.ImageIndex = ((int)(resources.GetObject("labelMaxSwitchingTimeCap.ImageIndex")));
			this.labelMaxSwitchingTimeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxSwitchingTimeCap.ImeMode")));
			this.labelMaxSwitchingTimeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxSwitchingTimeCap.Location")));
			this.labelMaxSwitchingTimeCap.Name = "labelMaxSwitchingTimeCap";
			this.labelMaxSwitchingTimeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxSwitchingTimeCap.RightToLeft")));
			this.labelMaxSwitchingTimeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxSwitchingTimeCap.Size")));
			this.labelMaxSwitchingTimeCap.TabIndex = ((int)(resources.GetObject("labelMaxSwitchingTimeCap.TabIndex")));
			this.labelMaxSwitchingTimeCap.Text = resources.GetString("labelMaxSwitchingTimeCap.Text");
			this.labelMaxSwitchingTimeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxSwitchingTimeCap.TextAlign")));
			this.labelMaxSwitchingTimeCap.Visible = ((bool)(resources.GetObject("labelMaxSwitchingTimeCap.Visible")));
			// 
			// labelMaxRingCount
			// 
			this.labelMaxRingCount.AccessibleDescription = resources.GetString("labelMaxRingCount.AccessibleDescription");
			this.labelMaxRingCount.AccessibleName = resources.GetString("labelMaxRingCount.AccessibleName");
			this.labelMaxRingCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxRingCount.Anchor")));
			this.labelMaxRingCount.AutoSize = ((bool)(resources.GetObject("labelMaxRingCount.AutoSize")));
			this.labelMaxRingCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxRingCount.Dock")));
			this.labelMaxRingCount.Enabled = ((bool)(resources.GetObject("labelMaxRingCount.Enabled")));
			this.labelMaxRingCount.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxRingCount.Font")));
			this.labelMaxRingCount.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxRingCount.Image")));
			this.labelMaxRingCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxRingCount.ImageAlign")));
			this.labelMaxRingCount.ImageIndex = ((int)(resources.GetObject("labelMaxRingCount.ImageIndex")));
			this.labelMaxRingCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxRingCount.ImeMode")));
			this.labelMaxRingCount.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxRingCount.Location")));
			this.labelMaxRingCount.Name = "labelMaxRingCount";
			this.labelMaxRingCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxRingCount.RightToLeft")));
			this.labelMaxRingCount.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxRingCount.Size")));
			this.labelMaxRingCount.TabIndex = ((int)(resources.GetObject("labelMaxRingCount.TabIndex")));
			this.labelMaxRingCount.Text = resources.GetString("labelMaxRingCount.Text");
			this.labelMaxRingCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxRingCount.TextAlign")));
			this.labelMaxRingCount.Visible = ((bool)(resources.GetObject("labelMaxRingCount.Visible")));
			// 
			// labelMaxRingCountCap
			// 
			this.labelMaxRingCountCap.AccessibleDescription = resources.GetString("labelMaxRingCountCap.AccessibleDescription");
			this.labelMaxRingCountCap.AccessibleName = resources.GetString("labelMaxRingCountCap.AccessibleName");
			this.labelMaxRingCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMaxRingCountCap.Anchor")));
			this.labelMaxRingCountCap.AutoSize = ((bool)(resources.GetObject("labelMaxRingCountCap.AutoSize")));
			this.labelMaxRingCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMaxRingCountCap.Dock")));
			this.labelMaxRingCountCap.Enabled = ((bool)(resources.GetObject("labelMaxRingCountCap.Enabled")));
			this.labelMaxRingCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMaxRingCountCap.Font")));
			this.labelMaxRingCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMaxRingCountCap.Image")));
			this.labelMaxRingCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxRingCountCap.ImageAlign")));
			this.labelMaxRingCountCap.ImageIndex = ((int)(resources.GetObject("labelMaxRingCountCap.ImageIndex")));
			this.labelMaxRingCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMaxRingCountCap.ImeMode")));
			this.labelMaxRingCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMaxRingCountCap.Location")));
			this.labelMaxRingCountCap.Name = "labelMaxRingCountCap";
			this.labelMaxRingCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMaxRingCountCap.RightToLeft")));
			this.labelMaxRingCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMaxRingCountCap.Size")));
			this.labelMaxRingCountCap.TabIndex = ((int)(resources.GetObject("labelMaxRingCountCap.TabIndex")));
			this.labelMaxRingCountCap.Text = resources.GetString("labelMaxRingCountCap.Text");
			this.labelMaxRingCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMaxRingCountCap.TextAlign")));
			this.labelMaxRingCountCap.Visible = ((bool)(resources.GetObject("labelMaxRingCountCap.Visible")));
			// 
			// labelMinRingCount
			// 
			this.labelMinRingCount.AccessibleDescription = resources.GetString("labelMinRingCount.AccessibleDescription");
			this.labelMinRingCount.AccessibleName = resources.GetString("labelMinRingCount.AccessibleName");
			this.labelMinRingCount.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMinRingCount.Anchor")));
			this.labelMinRingCount.AutoSize = ((bool)(resources.GetObject("labelMinRingCount.AutoSize")));
			this.labelMinRingCount.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMinRingCount.Dock")));
			this.labelMinRingCount.Enabled = ((bool)(resources.GetObject("labelMinRingCount.Enabled")));
			this.labelMinRingCount.Font = ((System.Drawing.Font)(resources.GetObject("labelMinRingCount.Font")));
			this.labelMinRingCount.Image = ((System.Drawing.Image)(resources.GetObject("labelMinRingCount.Image")));
			this.labelMinRingCount.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMinRingCount.ImageAlign")));
			this.labelMinRingCount.ImageIndex = ((int)(resources.GetObject("labelMinRingCount.ImageIndex")));
			this.labelMinRingCount.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMinRingCount.ImeMode")));
			this.labelMinRingCount.Location = ((System.Drawing.Point)(resources.GetObject("labelMinRingCount.Location")));
			this.labelMinRingCount.Name = "labelMinRingCount";
			this.labelMinRingCount.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMinRingCount.RightToLeft")));
			this.labelMinRingCount.Size = ((System.Drawing.Size)(resources.GetObject("labelMinRingCount.Size")));
			this.labelMinRingCount.TabIndex = ((int)(resources.GetObject("labelMinRingCount.TabIndex")));
			this.labelMinRingCount.Text = resources.GetString("labelMinRingCount.Text");
			this.labelMinRingCount.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMinRingCount.TextAlign")));
			this.labelMinRingCount.Visible = ((bool)(resources.GetObject("labelMinRingCount.Visible")));
			// 
			// labelMinRingCountCap
			// 
			this.labelMinRingCountCap.AccessibleDescription = resources.GetString("labelMinRingCountCap.AccessibleDescription");
			this.labelMinRingCountCap.AccessibleName = resources.GetString("labelMinRingCountCap.AccessibleName");
			this.labelMinRingCountCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelMinRingCountCap.Anchor")));
			this.labelMinRingCountCap.AutoSize = ((bool)(resources.GetObject("labelMinRingCountCap.AutoSize")));
			this.labelMinRingCountCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelMinRingCountCap.Dock")));
			this.labelMinRingCountCap.Enabled = ((bool)(resources.GetObject("labelMinRingCountCap.Enabled")));
			this.labelMinRingCountCap.Font = ((System.Drawing.Font)(resources.GetObject("labelMinRingCountCap.Font")));
			this.labelMinRingCountCap.Image = ((System.Drawing.Image)(resources.GetObject("labelMinRingCountCap.Image")));
			this.labelMinRingCountCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMinRingCountCap.ImageAlign")));
			this.labelMinRingCountCap.ImageIndex = ((int)(resources.GetObject("labelMinRingCountCap.ImageIndex")));
			this.labelMinRingCountCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelMinRingCountCap.ImeMode")));
			this.labelMinRingCountCap.Location = ((System.Drawing.Point)(resources.GetObject("labelMinRingCountCap.Location")));
			this.labelMinRingCountCap.Name = "labelMinRingCountCap";
			this.labelMinRingCountCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelMinRingCountCap.RightToLeft")));
			this.labelMinRingCountCap.Size = ((System.Drawing.Size)(resources.GetObject("labelMinRingCountCap.Size")));
			this.labelMinRingCountCap.TabIndex = ((int)(resources.GetObject("labelMinRingCountCap.TabIndex")));
			this.labelMinRingCountCap.Text = resources.GetString("labelMinRingCountCap.Text");
			this.labelMinRingCountCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelMinRingCountCap.TextAlign")));
			this.labelMinRingCountCap.Visible = ((bool)(resources.GetObject("labelMinRingCountCap.Visible")));
			// 
			// labelCallingNumber
			// 
			this.labelCallingNumber.AccessibleDescription = resources.GetString("labelCallingNumber.AccessibleDescription");
			this.labelCallingNumber.AccessibleName = resources.GetString("labelCallingNumber.AccessibleName");
			this.labelCallingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallingNumber.Anchor")));
			this.labelCallingNumber.AutoSize = ((bool)(resources.GetObject("labelCallingNumber.AutoSize")));
			this.labelCallingNumber.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallingNumber.Dock")));
			this.labelCallingNumber.Enabled = ((bool)(resources.GetObject("labelCallingNumber.Enabled")));
			this.labelCallingNumber.Font = ((System.Drawing.Font)(resources.GetObject("labelCallingNumber.Font")));
			this.labelCallingNumber.Image = ((System.Drawing.Image)(resources.GetObject("labelCallingNumber.Image")));
			this.labelCallingNumber.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallingNumber.ImageAlign")));
			this.labelCallingNumber.ImageIndex = ((int)(resources.GetObject("labelCallingNumber.ImageIndex")));
			this.labelCallingNumber.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallingNumber.ImeMode")));
			this.labelCallingNumber.Location = ((System.Drawing.Point)(resources.GetObject("labelCallingNumber.Location")));
			this.labelCallingNumber.Name = "labelCallingNumber";
			this.labelCallingNumber.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallingNumber.RightToLeft")));
			this.labelCallingNumber.Size = ((System.Drawing.Size)(resources.GetObject("labelCallingNumber.Size")));
			this.labelCallingNumber.TabIndex = ((int)(resources.GetObject("labelCallingNumber.TabIndex")));
			this.labelCallingNumber.Text = resources.GetString("labelCallingNumber.Text");
			this.labelCallingNumber.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallingNumber.TextAlign")));
			this.labelCallingNumber.Visible = ((bool)(resources.GetObject("labelCallingNumber.Visible")));
			// 
			// labelCallingNumberCap
			// 
			this.labelCallingNumberCap.AccessibleDescription = resources.GetString("labelCallingNumberCap.AccessibleDescription");
			this.labelCallingNumberCap.AccessibleName = resources.GetString("labelCallingNumberCap.AccessibleName");
			this.labelCallingNumberCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCallingNumberCap.Anchor")));
			this.labelCallingNumberCap.AutoSize = ((bool)(resources.GetObject("labelCallingNumberCap.AutoSize")));
			this.labelCallingNumberCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCallingNumberCap.Dock")));
			this.labelCallingNumberCap.Enabled = ((bool)(resources.GetObject("labelCallingNumberCap.Enabled")));
			this.labelCallingNumberCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCallingNumberCap.Font")));
			this.labelCallingNumberCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCallingNumberCap.Image")));
			this.labelCallingNumberCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallingNumberCap.ImageAlign")));
			this.labelCallingNumberCap.ImageIndex = ((int)(resources.GetObject("labelCallingNumberCap.ImageIndex")));
			this.labelCallingNumberCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCallingNumberCap.ImeMode")));
			this.labelCallingNumberCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCallingNumberCap.Location")));
			this.labelCallingNumberCap.Name = "labelCallingNumberCap";
			this.labelCallingNumberCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCallingNumberCap.RightToLeft")));
			this.labelCallingNumberCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCallingNumberCap.Size")));
			this.labelCallingNumberCap.TabIndex = ((int)(resources.GetObject("labelCallingNumberCap.TabIndex")));
			this.labelCallingNumberCap.Text = resources.GetString("labelCallingNumberCap.Text");
			this.labelCallingNumberCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCallingNumberCap.TextAlign")));
			this.labelCallingNumberCap.Visible = ((bool)(resources.GetObject("labelCallingNumberCap.Visible")));
			// 
			// labelCarrierCode
			// 
			this.labelCarrierCode.AccessibleDescription = resources.GetString("labelCarrierCode.AccessibleDescription");
			this.labelCarrierCode.AccessibleName = resources.GetString("labelCarrierCode.AccessibleName");
			this.labelCarrierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCarrierCode.Anchor")));
			this.labelCarrierCode.AutoSize = ((bool)(resources.GetObject("labelCarrierCode.AutoSize")));
			this.labelCarrierCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCarrierCode.Dock")));
			this.labelCarrierCode.Enabled = ((bool)(resources.GetObject("labelCarrierCode.Enabled")));
			this.labelCarrierCode.Font = ((System.Drawing.Font)(resources.GetObject("labelCarrierCode.Font")));
			this.labelCarrierCode.Image = ((System.Drawing.Image)(resources.GetObject("labelCarrierCode.Image")));
			this.labelCarrierCode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCarrierCode.ImageAlign")));
			this.labelCarrierCode.ImageIndex = ((int)(resources.GetObject("labelCarrierCode.ImageIndex")));
			this.labelCarrierCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCarrierCode.ImeMode")));
			this.labelCarrierCode.Location = ((System.Drawing.Point)(resources.GetObject("labelCarrierCode.Location")));
			this.labelCarrierCode.Name = "labelCarrierCode";
			this.labelCarrierCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCarrierCode.RightToLeft")));
			this.labelCarrierCode.Size = ((System.Drawing.Size)(resources.GetObject("labelCarrierCode.Size")));
			this.labelCarrierCode.TabIndex = ((int)(resources.GetObject("labelCarrierCode.TabIndex")));
			this.labelCarrierCode.Text = resources.GetString("labelCarrierCode.Text");
			this.labelCarrierCode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCarrierCode.TextAlign")));
			this.labelCarrierCode.Visible = ((bool)(resources.GetObject("labelCarrierCode.Visible")));
			// 
			// labelCarrierCodeCap
			// 
			this.labelCarrierCodeCap.AccessibleDescription = resources.GetString("labelCarrierCodeCap.AccessibleDescription");
			this.labelCarrierCodeCap.AccessibleName = resources.GetString("labelCarrierCodeCap.AccessibleName");
			this.labelCarrierCodeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelCarrierCodeCap.Anchor")));
			this.labelCarrierCodeCap.AutoSize = ((bool)(resources.GetObject("labelCarrierCodeCap.AutoSize")));
			this.labelCarrierCodeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelCarrierCodeCap.Dock")));
			this.labelCarrierCodeCap.Enabled = ((bool)(resources.GetObject("labelCarrierCodeCap.Enabled")));
			this.labelCarrierCodeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelCarrierCodeCap.Font")));
			this.labelCarrierCodeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelCarrierCodeCap.Image")));
			this.labelCarrierCodeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCarrierCodeCap.ImageAlign")));
			this.labelCarrierCodeCap.ImageIndex = ((int)(resources.GetObject("labelCarrierCodeCap.ImageIndex")));
			this.labelCarrierCodeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelCarrierCodeCap.ImeMode")));
			this.labelCarrierCodeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelCarrierCodeCap.Location")));
			this.labelCarrierCodeCap.Name = "labelCarrierCodeCap";
			this.labelCarrierCodeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelCarrierCodeCap.RightToLeft")));
			this.labelCarrierCodeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelCarrierCodeCap.Size")));
			this.labelCarrierCodeCap.TabIndex = ((int)(resources.GetObject("labelCarrierCodeCap.TabIndex")));
			this.labelCarrierCodeCap.Text = resources.GetString("labelCarrierCodeCap.Text");
			this.labelCarrierCodeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelCarrierCodeCap.TextAlign")));
			this.labelCarrierCodeCap.Visible = ((bool)(resources.GetObject("labelCarrierCodeCap.Visible")));
			// 
			// labelTrunkGroup
			// 
			this.labelTrunkGroup.AccessibleDescription = resources.GetString("labelTrunkGroup.AccessibleDescription");
			this.labelTrunkGroup.AccessibleName = resources.GetString("labelTrunkGroup.AccessibleName");
			this.labelTrunkGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTrunkGroup.Anchor")));
			this.labelTrunkGroup.AutoSize = ((bool)(resources.GetObject("labelTrunkGroup.AutoSize")));
			this.labelTrunkGroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTrunkGroup.Dock")));
			this.labelTrunkGroup.Enabled = ((bool)(resources.GetObject("labelTrunkGroup.Enabled")));
			this.labelTrunkGroup.Font = ((System.Drawing.Font)(resources.GetObject("labelTrunkGroup.Font")));
			this.labelTrunkGroup.Image = ((System.Drawing.Image)(resources.GetObject("labelTrunkGroup.Image")));
			this.labelTrunkGroup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTrunkGroup.ImageAlign")));
			this.labelTrunkGroup.ImageIndex = ((int)(resources.GetObject("labelTrunkGroup.ImageIndex")));
			this.labelTrunkGroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTrunkGroup.ImeMode")));
			this.labelTrunkGroup.Location = ((System.Drawing.Point)(resources.GetObject("labelTrunkGroup.Location")));
			this.labelTrunkGroup.Name = "labelTrunkGroup";
			this.labelTrunkGroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTrunkGroup.RightToLeft")));
			this.labelTrunkGroup.Size = ((System.Drawing.Size)(resources.GetObject("labelTrunkGroup.Size")));
			this.labelTrunkGroup.TabIndex = ((int)(resources.GetObject("labelTrunkGroup.TabIndex")));
			this.labelTrunkGroup.Text = resources.GetString("labelTrunkGroup.Text");
			this.labelTrunkGroup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTrunkGroup.TextAlign")));
			this.labelTrunkGroup.Visible = ((bool)(resources.GetObject("labelTrunkGroup.Visible")));
			// 
			// labelTrunkGroupCap
			// 
			this.labelTrunkGroupCap.AccessibleDescription = resources.GetString("labelTrunkGroupCap.AccessibleDescription");
			this.labelTrunkGroupCap.AccessibleName = resources.GetString("labelTrunkGroupCap.AccessibleName");
			this.labelTrunkGroupCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelTrunkGroupCap.Anchor")));
			this.labelTrunkGroupCap.AutoSize = ((bool)(resources.GetObject("labelTrunkGroupCap.AutoSize")));
			this.labelTrunkGroupCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelTrunkGroupCap.Dock")));
			this.labelTrunkGroupCap.Enabled = ((bool)(resources.GetObject("labelTrunkGroupCap.Enabled")));
			this.labelTrunkGroupCap.Font = ((System.Drawing.Font)(resources.GetObject("labelTrunkGroupCap.Font")));
			this.labelTrunkGroupCap.Image = ((System.Drawing.Image)(resources.GetObject("labelTrunkGroupCap.Image")));
			this.labelTrunkGroupCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTrunkGroupCap.ImageAlign")));
			this.labelTrunkGroupCap.ImageIndex = ((int)(resources.GetObject("labelTrunkGroupCap.ImageIndex")));
			this.labelTrunkGroupCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelTrunkGroupCap.ImeMode")));
			this.labelTrunkGroupCap.Location = ((System.Drawing.Point)(resources.GetObject("labelTrunkGroupCap.Location")));
			this.labelTrunkGroupCap.Name = "labelTrunkGroupCap";
			this.labelTrunkGroupCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelTrunkGroupCap.RightToLeft")));
			this.labelTrunkGroupCap.Size = ((System.Drawing.Size)(resources.GetObject("labelTrunkGroupCap.Size")));
			this.labelTrunkGroupCap.TabIndex = ((int)(resources.GetObject("labelTrunkGroupCap.TabIndex")));
			this.labelTrunkGroupCap.Text = resources.GetString("labelTrunkGroupCap.Text");
			this.labelTrunkGroupCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelTrunkGroupCap.TextAlign")));
			this.labelTrunkGroupCap.Visible = ((bool)(resources.GetObject("labelTrunkGroupCap.Visible")));
			// 
			// labelDialMode
			// 
			this.labelDialMode.AccessibleDescription = resources.GetString("labelDialMode.AccessibleDescription");
			this.labelDialMode.AccessibleName = resources.GetString("labelDialMode.AccessibleName");
			this.labelDialMode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDialMode.Anchor")));
			this.labelDialMode.AutoSize = ((bool)(resources.GetObject("labelDialMode.AutoSize")));
			this.labelDialMode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDialMode.Dock")));
			this.labelDialMode.Enabled = ((bool)(resources.GetObject("labelDialMode.Enabled")));
			this.labelDialMode.Font = ((System.Drawing.Font)(resources.GetObject("labelDialMode.Font")));
			this.labelDialMode.Image = ((System.Drawing.Image)(resources.GetObject("labelDialMode.Image")));
			this.labelDialMode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialMode.ImageAlign")));
			this.labelDialMode.ImageIndex = ((int)(resources.GetObject("labelDialMode.ImageIndex")));
			this.labelDialMode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDialMode.ImeMode")));
			this.labelDialMode.Location = ((System.Drawing.Point)(resources.GetObject("labelDialMode.Location")));
			this.labelDialMode.Name = "labelDialMode";
			this.labelDialMode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDialMode.RightToLeft")));
			this.labelDialMode.Size = ((System.Drawing.Size)(resources.GetObject("labelDialMode.Size")));
			this.labelDialMode.TabIndex = ((int)(resources.GetObject("labelDialMode.TabIndex")));
			this.labelDialMode.Text = resources.GetString("labelDialMode.Text");
			this.labelDialMode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialMode.TextAlign")));
			this.labelDialMode.Visible = ((bool)(resources.GetObject("labelDialMode.Visible")));
			// 
			// labelDialModeCap
			// 
			this.labelDialModeCap.AccessibleDescription = resources.GetString("labelDialModeCap.AccessibleDescription");
			this.labelDialModeCap.AccessibleName = resources.GetString("labelDialModeCap.AccessibleName");
			this.labelDialModeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelDialModeCap.Anchor")));
			this.labelDialModeCap.AutoSize = ((bool)(resources.GetObject("labelDialModeCap.AutoSize")));
			this.labelDialModeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelDialModeCap.Dock")));
			this.labelDialModeCap.Enabled = ((bool)(resources.GetObject("labelDialModeCap.Enabled")));
			this.labelDialModeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelDialModeCap.Font")));
			this.labelDialModeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelDialModeCap.Image")));
			this.labelDialModeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialModeCap.ImageAlign")));
			this.labelDialModeCap.ImageIndex = ((int)(resources.GetObject("labelDialModeCap.ImageIndex")));
			this.labelDialModeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelDialModeCap.ImeMode")));
			this.labelDialModeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelDialModeCap.Location")));
			this.labelDialModeCap.Name = "labelDialModeCap";
			this.labelDialModeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelDialModeCap.RightToLeft")));
			this.labelDialModeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelDialModeCap.Size")));
			this.labelDialModeCap.TabIndex = ((int)(resources.GetObject("labelDialModeCap.TabIndex")));
			this.labelDialModeCap.Text = resources.GetString("labelDialModeCap.Text");
			this.labelDialModeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelDialModeCap.TextAlign")));
			this.labelDialModeCap.Visible = ((bool)(resources.GetObject("labelDialModeCap.Visible")));
			// 
			// labelAvailabilityMode
			// 
			this.labelAvailabilityMode.AccessibleDescription = resources.GetString("labelAvailabilityMode.AccessibleDescription");
			this.labelAvailabilityMode.AccessibleName = resources.GetString("labelAvailabilityMode.AccessibleName");
			this.labelAvailabilityMode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAvailabilityMode.Anchor")));
			this.labelAvailabilityMode.AutoSize = ((bool)(resources.GetObject("labelAvailabilityMode.AutoSize")));
			this.labelAvailabilityMode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAvailabilityMode.Dock")));
			this.labelAvailabilityMode.Enabled = ((bool)(resources.GetObject("labelAvailabilityMode.Enabled")));
			this.labelAvailabilityMode.Font = ((System.Drawing.Font)(resources.GetObject("labelAvailabilityMode.Font")));
			this.labelAvailabilityMode.Image = ((System.Drawing.Image)(resources.GetObject("labelAvailabilityMode.Image")));
			this.labelAvailabilityMode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAvailabilityMode.ImageAlign")));
			this.labelAvailabilityMode.ImageIndex = ((int)(resources.GetObject("labelAvailabilityMode.ImageIndex")));
			this.labelAvailabilityMode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAvailabilityMode.ImeMode")));
			this.labelAvailabilityMode.Location = ((System.Drawing.Point)(resources.GetObject("labelAvailabilityMode.Location")));
			this.labelAvailabilityMode.Name = "labelAvailabilityMode";
			this.labelAvailabilityMode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAvailabilityMode.RightToLeft")));
			this.labelAvailabilityMode.Size = ((System.Drawing.Size)(resources.GetObject("labelAvailabilityMode.Size")));
			this.labelAvailabilityMode.TabIndex = ((int)(resources.GetObject("labelAvailabilityMode.TabIndex")));
			this.labelAvailabilityMode.Text = resources.GetString("labelAvailabilityMode.Text");
			this.labelAvailabilityMode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAvailabilityMode.TextAlign")));
			this.labelAvailabilityMode.Visible = ((bool)(resources.GetObject("labelAvailabilityMode.Visible")));
			// 
			// labelAvailabilityModeCap
			// 
			this.labelAvailabilityModeCap.AccessibleDescription = resources.GetString("labelAvailabilityModeCap.AccessibleDescription");
			this.labelAvailabilityModeCap.AccessibleName = resources.GetString("labelAvailabilityModeCap.AccessibleName");
			this.labelAvailabilityModeCap.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("labelAvailabilityModeCap.Anchor")));
			this.labelAvailabilityModeCap.AutoSize = ((bool)(resources.GetObject("labelAvailabilityModeCap.AutoSize")));
			this.labelAvailabilityModeCap.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("labelAvailabilityModeCap.Dock")));
			this.labelAvailabilityModeCap.Enabled = ((bool)(resources.GetObject("labelAvailabilityModeCap.Enabled")));
			this.labelAvailabilityModeCap.Font = ((System.Drawing.Font)(resources.GetObject("labelAvailabilityModeCap.Font")));
			this.labelAvailabilityModeCap.Image = ((System.Drawing.Image)(resources.GetObject("labelAvailabilityModeCap.Image")));
			this.labelAvailabilityModeCap.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAvailabilityModeCap.ImageAlign")));
			this.labelAvailabilityModeCap.ImageIndex = ((int)(resources.GetObject("labelAvailabilityModeCap.ImageIndex")));
			this.labelAvailabilityModeCap.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("labelAvailabilityModeCap.ImeMode")));
			this.labelAvailabilityModeCap.Location = ((System.Drawing.Point)(resources.GetObject("labelAvailabilityModeCap.Location")));
			this.labelAvailabilityModeCap.Name = "labelAvailabilityModeCap";
			this.labelAvailabilityModeCap.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("labelAvailabilityModeCap.RightToLeft")));
			this.labelAvailabilityModeCap.Size = ((System.Drawing.Size)(resources.GetObject("labelAvailabilityModeCap.Size")));
			this.labelAvailabilityModeCap.TabIndex = ((int)(resources.GetObject("labelAvailabilityModeCap.TabIndex")));
			this.labelAvailabilityModeCap.Text = resources.GetString("labelAvailabilityModeCap.Text");
			this.labelAvailabilityModeCap.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("labelAvailabilityModeCap.TextAlign")));
			this.labelAvailabilityModeCap.Visible = ((bool)(resources.GetObject("labelAvailabilityModeCap.Visible")));
			// 
			// CampaignViewParameters
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.groupBoxHotlineParameters);
			this.Controls.Add(this.groupBoxParameters);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CampaignViewParameters";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.groupBoxHotlineParameters.ResumeLayout(false);
			this.groupBoxParameters.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(Campaign campaign)
		{
			// Parameter aktualisieren
			labelAvailabilityMode.Text = campaign.AvailabilityMode.ToString();
			labelDialMode.Text = campaign.DialMode.ToString();
			labelTrunkGroup.Text = campaign.TrunkGroup;
			labelCarrierCode.Text = campaign.CarrierCode;
			labelCallingNumber.Text = campaign.CallingNumber;
			labelMinRingCount.Text = campaign.MinRingCount.ToString();
			labelMaxRingCount.Text = campaign.MaxRingCount.ToString();
			labelMaxSwitchingTime.Text = campaign.MaxSwitchingTime.ToString();
			labelMaxDialRate.Text = campaign.MaxDialRate.ToString();
			labelMaxDropRate.Text = campaign.MaxDropRate.ToString();
			labelMaxLostRate.Text = campaign.MaxLostRate.ToString();
			labelAgentRelaxTarget.Text = campaign.AgentRelaxTarget.ToString();
			labelCPALevel.Text = campaign.CPALevel.ToString();
			labelCallPriority.Text = campaign.CallPriority.ToString();
			textBoxMusicOnReadyFile.Text = campaign.MusicOnReadyFile;
			textBoxGreetingFile.Text = campaign.GreetingFile;
			textBoxWaitingFile.Text = campaign.WaitingFile;
			textBoxAnsweringMachineFile.Text = campaign.AnsweringMachineFile;
			textBoxAbandonmentFile.Text = campaign.AbandonmentFile;
			labelAutoRecording.Text = campaign.AutoRecording.ToString();

			// Hotlineparameter aktualisieren
			textBoxHotlineNumbers.Text = campaign.HotlineNumbers;
			labelHotlineQueueSizeFactor.Text = campaign.HotlineQueueSizeFactor.ToString();
			labelHotlineCallPriority.Text = campaign.HotlineCallPriority.ToString();
			textBoxHotlineGreetingFile.Text = campaign.HotlineGreetingFile;
			textBoxHotlineWaitingFile.Text = campaign.HotlineWaitingFile;
			textBoxHotlineAbandonmentFile.Text = campaign.HotlineAbandonmentFile;
		}

		#endregion

		#endregion
	}
}
