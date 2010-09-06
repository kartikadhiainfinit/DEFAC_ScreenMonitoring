using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf alle Konferenzen.
	/// </summary>
	public class ConferencePage : itCampus.bb.Monitor.Client.Page
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.ColumnHeader columnHeaderInitiator;
		private System.Windows.Forms.ColumnHeader columnHeaderState;
		private System.Windows.Forms.ColumnHeader columnHeaderConfereeCount;
		private System.ComponentModel.IContainer components = null;

		// Konferenzverwaltung
		private ConferenceControl _conferenceControl; 

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Konferenzseite
		/// </summary>
		public ConferencePage(ConferenceControl conferenceControl)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Konferenzverwaltung referenzieren
			_conferenceControl = conferenceControl;
			_conferenceControl.OnAddConference += new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnAddConference);
			_conferenceControl.OnRefreshConference += new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnRefreshConference);
			_conferenceControl.OnRemoveConference += new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnRemoveConference);

			// Seitenmodus initialisieren
			this.Mode = PageMode.List;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Konferenzverwaltung freigeben
			_conferenceControl.OnAddConference -= new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnAddConference);
			_conferenceControl.OnRefreshConference -= new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnRefreshConference);
			_conferenceControl.OnRemoveConference -= new ConferenceControl.ConferenceEventHandler(
				_conferenceControl_OnRemoveConference);
			_conferenceControl = null;

			if( disposing )
			{
				if (components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConferencePage));
			this.columnHeaderInitiator = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderState = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderConfereeCount = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Text = resources.GetString("labelTitle.Text");
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeaderInitiator,
																					   this.columnHeaderState,
																					   this.columnHeaderConfereeCount});
			this.listView.Name = "listView";
			// 
			// panelBottom
			// 
			this.panelBottom.Name = "panelBottom";
			// 
			// columnHeaderInitiator
			// 
			this.columnHeaderInitiator.Text = resources.GetString("columnHeaderInitiator.Text");
			this.columnHeaderInitiator.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderInitiator.TextAlign")));
			this.columnHeaderInitiator.Width = ((int)(resources.GetObject("columnHeaderInitiator.Width")));
			// 
			// columnHeaderState
			// 
			this.columnHeaderState.Text = resources.GetString("columnHeaderState.Text");
			this.columnHeaderState.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderState.TextAlign")));
			this.columnHeaderState.Width = ((int)(resources.GetObject("columnHeaderState.Width")));
			// 
			// columnHeaderConfereeCount
			// 
			this.columnHeaderConfereeCount.Text = resources.GetString("columnHeaderConfereeCount.Text");
			this.columnHeaderConfereeCount.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeaderConfereeCount.TextAlign")));
			this.columnHeaderConfereeCount.Width = ((int)(resources.GetObject("columnHeaderConfereeCount.Width")));
			// 
			// ConferencePage
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ConferencePage";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Konferenzverwaltung ---------------

		/// <summary>
		/// fügt Konferenz zu Seite hinzu
		/// </summary>
		private void _conferenceControl_OnAddConference(Conference conference)
		{
			try
			{
				// neuen Listeneintrag erzeugen
				ListViewItem item = new ListViewItem(conference.Initiator);
				item.SubItems.Add(conference.State.ToString());
				item.SubItems.Add(conference.ConfereeCount.ToString());
				item.Tag = conference.Key;

				// Listeneintrag zu Ansicht und Index hinzufügen
				listView.Items.Add(item);
				_listViewHash.Add(conference.Key, item);

				// initialen Listeneintrag selektieren
				if (listView.Items.Count == 1)
				{
					item.Selected = true;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding conference.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Konferenz
		/// </summary>
		private void _conferenceControl_OnRefreshConference(Conference conference)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[conference.Key];

				// wenn Listeneintrag gefunden, aktualisieren
				if (item != null)
				{
					item.Text = conference.Initiator;
					item.SubItems[1].Text = conference.State.ToString();
					item.SubItems[2].Text = conference.ConfereeCount.ToString();
				}

				// wenn Listeneintrag ausgewählt, Änderung signalisieren
				if ((listView.SelectedItems.Count > 0) &&
					(listView.SelectedItems[0].Tag.ToString() == conference.Key))
				{
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing conference.", ex);
			}
		}

		/// <summary>
		/// entfernt Konferenz von Seite
		/// </summary>
		private void _conferenceControl_OnRemoveConference(Conference conference)
		{
			try
			{
				// Listeneintrag in Index suchen
				ListViewItem item = (ListViewItem)_listViewHash[conference.Key];

				// wenn Listeneintrag gefunden, aus Ansicht und Index entfernen
				if (item != null)
				{
					listView.Items.Remove(item);
					_listViewHash.Remove(conference.Key);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing conference.", ex);
			}
		}

		#endregion

		#endregion
	}
}
