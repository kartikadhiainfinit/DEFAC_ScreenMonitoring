using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung eines Devices in Raumansicht.
	/// </summary>
	public class SiteViewItem : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.Panel panelPageUnassigned;
		private System.Windows.Forms.Panel panelPageAssigned;
		private System.Windows.Forms.Label labelDeviceCode;
		private System.Windows.Forms.Label labelState;
		private System.Windows.Forms.Label labelStateTime;
		private System.Windows.Forms.Label labelAgentCode;
		private System.Windows.Forms.PictureBox pictureBoxCampaignSessions;
		private System.Windows.Forms.PictureBox pictureBoxCoach;
		private System.Windows.Forms.Timer timerRefresh;
		private System.Windows.Forms.ToolTip toolTip;
		private System.ComponentModel.IContainer components;

		// Parameter
		private Device _device;            // Device
		private Color _stateColor;         // Farbe für aktuallen Status
		private DateTime _lastStateChange; // Zeitpunkt für letzten Statuswechsel

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Devicesymbol
		/// </summary>
		public SiteViewItem(Device device)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Anzeige initialisieren
			this.Width = panelPageUnassigned.Width;
			this.Height = panelPageUnassigned.Height;
			panelPageAssigned.Left = panelPageUnassigned.Left;

			// Device referenzieren
			_device = device;

			// Parameter initialisieren
			_stateColor = Color.Transparent;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SiteViewItem));
			this.panelPageUnassigned = new System.Windows.Forms.Panel();
			this.labelDeviceCode = new System.Windows.Forms.Label();
			this.panelPageAssigned = new System.Windows.Forms.Panel();
			this.pictureBoxCoach = new System.Windows.Forms.PictureBox();
			this.pictureBoxCampaignSessions = new System.Windows.Forms.PictureBox();
			this.labelAgentCode = new System.Windows.Forms.Label();
			this.labelStateTime = new System.Windows.Forms.Label();
			this.labelState = new System.Windows.Forms.Label();
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panelPageUnassigned.SuspendLayout();
			this.panelPageAssigned.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPageUnassigned
			// 
			this.panelPageUnassigned.BackColor = System.Drawing.SystemColors.Window;
			this.panelPageUnassigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPageUnassigned.Controls.Add(this.labelDeviceCode);
			this.panelPageUnassigned.Location = new System.Drawing.Point(0, 0);
			this.panelPageUnassigned.Name = "panelPageUnassigned";
			this.panelPageUnassigned.Size = new System.Drawing.Size(64, 64);
			this.panelPageUnassigned.TabIndex = 0;
			this.panelPageUnassigned.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.panelPageUnassigned.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPageUnassigned_Paint);
			this.panelPageUnassigned.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.panelPageUnassigned.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// labelDeviceCode
			// 
			this.labelDeviceCode.BackColor = System.Drawing.Color.Transparent;
			this.labelDeviceCode.Location = new System.Drawing.Point(0, 24);
			this.labelDeviceCode.Name = "labelDeviceCode";
			this.labelDeviceCode.Size = new System.Drawing.Size(62, 16);
			this.labelDeviceCode.TabIndex = 0;
			this.labelDeviceCode.Text = "Code";
			this.labelDeviceCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelDeviceCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.labelDeviceCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.labelDeviceCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// panelPageAssigned
			// 
			this.panelPageAssigned.BackColor = System.Drawing.SystemColors.Window;
			this.panelPageAssigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPageAssigned.Controls.Add(this.pictureBoxCoach);
			this.panelPageAssigned.Controls.Add(this.pictureBoxCampaignSessions);
			this.panelPageAssigned.Controls.Add(this.labelAgentCode);
			this.panelPageAssigned.Controls.Add(this.labelStateTime);
			this.panelPageAssigned.Controls.Add(this.labelState);
			this.panelPageAssigned.Location = new System.Drawing.Point(72, 0);
			this.panelPageAssigned.Name = "panelPageAssigned";
			this.panelPageAssigned.Size = new System.Drawing.Size(64, 64);
			this.panelPageAssigned.TabIndex = 1;
			this.panelPageAssigned.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.panelPageAssigned.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPageAssigned_Paint);
			this.panelPageAssigned.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.panelPageAssigned.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// pictureBoxCoach
			// 
			this.pictureBoxCoach.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxCoach.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoach.Image")));
			this.pictureBoxCoach.Location = new System.Drawing.Point(46, 46);
			this.pictureBoxCoach.Name = "pictureBoxCoach";
			this.pictureBoxCoach.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxCoach.TabIndex = 4;
			this.pictureBoxCoach.TabStop = false;
			this.pictureBoxCoach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.pictureBoxCoach.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.pictureBoxCoach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// pictureBoxCampaignSessions
			// 
			this.pictureBoxCampaignSessions.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxCampaignSessions.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCampaignSessions.Image")));
			this.pictureBoxCampaignSessions.Location = new System.Drawing.Point(0, 46);
			this.pictureBoxCampaignSessions.Name = "pictureBoxCampaignSessions";
			this.pictureBoxCampaignSessions.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxCampaignSessions.TabIndex = 3;
			this.pictureBoxCampaignSessions.TabStop = false;
			this.pictureBoxCampaignSessions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.pictureBoxCampaignSessions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.pictureBoxCampaignSessions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// labelAgentCode
			// 
			this.labelAgentCode.BackColor = System.Drawing.Color.Transparent;
			this.labelAgentCode.Location = new System.Drawing.Point(0, 32);
			this.labelAgentCode.Name = "labelAgentCode";
			this.labelAgentCode.Size = new System.Drawing.Size(62, 16);
			this.labelAgentCode.TabIndex = 2;
			this.labelAgentCode.Text = "Agent";
			this.labelAgentCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.labelAgentCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.labelAgentCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// labelStateTime
			// 
			this.labelStateTime.BackColor = System.Drawing.Color.Transparent;
			this.labelStateTime.Location = new System.Drawing.Point(0, 16);
			this.labelStateTime.Name = "labelStateTime";
			this.labelStateTime.Size = new System.Drawing.Size(62, 16);
			this.labelStateTime.TabIndex = 1;
			this.labelStateTime.Text = "00:00:00";
			this.labelStateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelStateTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.labelStateTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.labelStateTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// labelState
			// 
			this.labelState.BackColor = System.Drawing.Color.Transparent;
			this.labelState.Location = new System.Drawing.Point(0, 0);
			this.labelState.Name = "labelState";
			this.labelState.Size = new System.Drawing.Size(62, 16);
			this.labelState.TabIndex = 0;
			this.labelState.Text = "State";
			this.labelState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelState.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
			this.labelState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
			this.labelState.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
			// 
			// timerRefresh
			// 
			this.timerRefresh.Interval = 1000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// SiteViewItem
			// 
			this.Controls.Add(this.panelPageUnassigned);
			this.Controls.Add(this.panelPageAssigned);
			this.Name = "SiteViewItem";
			this.Size = new System.Drawing.Size(136, 64);
			this.Move += new System.EventHandler(this.SiteViewItem_Move);
			this.Resize += new System.EventHandler(this.SiteViewItem_Resize);
			this.Enter += new System.EventHandler(this.SiteViewItem_Enter);
			this.Leave += new System.EventHandler(this.SiteViewItem_Leave);
			this.panelPageUnassigned.ResumeLayout(false);
			this.panelPageAssigned.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Steuerelemente --------------------

		/// <summary>
		/// hält Größe das Steuerelements konstant
		/// </summary>
		private void SiteViewItem_Resize(object sender, System.EventArgs e)
		{
			this.Width = panelPageUnassigned.Width;
			this.Height = panelPageUnassigned.Height;
		}

		/// <summary>
		/// aktualisiert Steuerelement
		/// </summary>
		private void SiteViewItem_Enter(object sender, System.EventArgs e)
		{
			this.Refresh();
		}

		/// <summary>
		/// aktualisiert Steuerelement
		/// </summary>
		private void SiteViewItem_Leave(object sender, System.EventArgs e)
		{
			this.Refresh();
		}

		/// <summary>
		/// speichert Position
		/// </summary>
		private void SiteViewItem_Move(object sender, System.EventArgs e)
		{
			_device.Location = this.Location;
		}

		/// <summary>
		/// zeichnet Markierung
		/// </summary>
		private void panelPageUnassigned_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// wenn Steuerelement Fokus besitzt, Markierung zeichnen
			if (this.Focused)
			{
				int width = ((Control)sender).Width - 3;
				int height = ((Control)sender).Height - 3;
				Pen pen = new Pen(Color.Black);
				e.Graphics.DrawRectangle(pen, 0, 0, width, height);
			}
		}

		/// <summary>
		/// zeichnet Farbfüllung und Markierung
		/// </summary>
		private void panelPageAssigned_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// Farbfüllung zeichnen
			int width = ((Control)sender).Width - 3;
			int height = ((Control)sender).Height - 3;
			Brush brush = new SolidBrush(_stateColor);
			Pen pen = new Pen(Color.Black);
			e.Graphics.FillRectangle(brush, 0, 0, width + 1, height / 2);
			e.Graphics.DrawLine(pen, 0, height / 2, width, height / 2);

			// wenn Steuerelement Fokus besitzt, Markierung zeichnen
			if (this.Focused)
			{
				e.Graphics.DrawRectangle(pen, 0, 0, width, height);
			}
		}

		/// <summary>
		/// signalisiert gedrückte Maustaste
		/// </summary>
		private void Control_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x = ((Control)sender).Left + e.X;
			int y = ((Control)sender).Top + e.Y;
			this.OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
		}

		/// <summary>
		/// signalisiert Mausbewegung
		/// </summary>
		private void Control_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x = ((Control)sender).Left + e.X;
			int y = ((Control)sender).Top + e.Y;
			this.OnMouseMove(new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
		}

		/// <summary>
		/// signalisiert losgelassene Maustaste
		/// </summary>
		private void Control_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x = ((Control)sender).Left + e.X;
			int y = ((Control)sender).Top + e.Y;
			this.OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, x, y, e.Delta));
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters()
		{
			// wenn kein Frontend zugeordnet
			if (_device.Frontend == null)
			{
				// Parameter aktualisieren
				RefreshLabel(labelDeviceCode, _device.Code);

				// Seite anzeigen
				panelPageUnassigned.BringToFront();
			}
			else
			{
				// Parameter aktualisieren
				RefreshLabel(labelState, _device.Frontend.State.ToString());
				_stateColor = GetStateColor(_device.Frontend.State);
				RefreshLabel(labelAgentCode, _device.Frontend.AgentCode);

				// ggf. Statusdauer aktualisieren
				if (_lastStateChange != _device.Frontend.LastStateChange)
				{
					_lastStateChange = _device.Frontend.LastStateChange;
					RefreshLabel(labelStateTime, GetStateTime(_lastStateChange));
				}

				// Kampagnenanmeldungen aktualisieren
				pictureBoxCampaignSessions.Visible = _device.Frontend.CampaignSessions.Count > 0;
				toolTip.SetToolTip(pictureBoxCampaignSessions, GetCampaignDisplayNames(
					_device.Frontend.CampaignSessions));

				// Coach aktualisieren
				pictureBoxCoach.Visible = _device.Frontend.MonitorCode != "";
				toolTip.SetToolTip(pictureBoxCoach, _device.Frontend.MonitorCode);

				// Seite anzeigen
				panelPageAssigned.BringToFront();
			}

			// ggf. Position aktualisieren
			if (this.Location != _device.Location)
			{
				this.Location = _device.Location;
			}

			// Steuerelement aktualisieren
			this.Refresh();
		}

		/// <summary>
		/// aktualisiert Steuerelement
		/// </summary>
		private void timerRefresh_Tick(object sender, System.EventArgs e)
		{
			try
			{
				// Statusdauer aktualisieren
				RefreshLabel(labelStateTime, GetStateTime(_lastStateChange));
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing device icon.", ex);
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

		/// <summary>
		/// gibt Farbe für angegebenen Status zurück
		/// </summary>
		private Color GetStateColor(FrontendState state)
		{
			switch (state)
			{
				case FrontendState.LoggedOff:
					return Color.FromArgb(192, 192, 192);
				case FrontendState.Unassigned:
					return Color.FromArgb(245, 245, 245);
				case FrontendState.NotReady:
					return Color.FromArgb(192, 192, 255);
				case FrontendState.Ready:
					return Color.FromArgb(192, 255, 192);
				case FrontendState.Pending:
					return Color.FromArgb(224, 192, 160);
				case FrontendState.Signaling:
					return Color.FromArgb(255, 240, 240);
				case FrontendState.Preparing:
					return Color.FromArgb(192, 255, 255);
				case FrontendState.Calling:
					return Color.FromArgb(255, 192, 255);
				case FrontendState.Talking:
					return Color.FromArgb(255, 192, 192);
				case FrontendState.Conferencing:
					return Color.FromArgb(255, 224, 192);
				case FrontendState.Wrapup:
					return Color.FromArgb(255, 255, 192);
				default:
					throw new Exception("FrontendState unknown.");
			}
		}

		/// <summary>
		/// aktualisiert Beschriftung und Tooltip eines Labels
		/// </summary>
		private void RefreshLabel(Label label, string text)
		{
			// Beschriftung aktualisieren und Tooltip zurücksetzen
			label.Text = text;
			toolTip.SetToolTip(label, "");

			// wenn Beschriftung zu lang
			if (TextWidth(label, label.Text) > label.Width)
			{
				// Beschriftung in Tooltip übernehmen
				toolTip.SetToolTip(label, label.Text);

				// Beschriftung abkürzen
				while ((TextWidth(label, label.Text + "...") > label.Width) &&
					(label.Text.Length > 1))
				{
					label.Text = label.Text.Substring(0, label.Text.Length - 1);
				}
				label.Text = label.Text + "...";
			}
		}

		/// <summary>
		/// gibt Textlänge auf Steuerelement zurück
		/// </summary>
		private int TextWidth(Control control, string text)
		{
			return (int)control.CreateGraphics().MeasureString(text, control.Font).Width + 1;
		}

		/// <summary>
		/// gibt Anzeigenamen der zugeordneten Kampagnen als zeilenseparierte Liste zurück
		/// </summary>
		private string GetCampaignDisplayNames(CampaignSessionList campaignSessions)
		{
			// Liste für Anzeigenamen der Kampagnen initialisieren
			string[] campaignDisplayNames = new string[campaignSessions.Count];

			// Anzeigenamen aller zugeordneten Kampagnen in Liste übertragen
			for (int i = 0; i < campaignSessions.Count; i++)
			{
				campaignDisplayNames[i] = campaignSessions[i].CampaignDisplayName;
			}

			// Liste sortieren
			Array.Sort(campaignDisplayNames);

			// Liste zeilensepariert zurückgeben
			return string.Join(Environment.NewLine, campaignDisplayNames);
		}

		#endregion

		#endregion
	}
}
