using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement für Sicht auf überwachte Objekte.
	/// </summary>
	public class Page : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.Panel panelTitle;
		protected System.Windows.Forms.Label labelTitle;
		protected System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Splitter splitterHorizontal;
		protected System.Windows.Forms.Panel panelBottom;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		// Index ListViewItems
		protected Hashtable _listViewHash = new Hashtable();

		// Sortierobjet
		private ListViewColumnSorter _listViewColumnSorter;

		// Parameter
		private PageMode _mode; // Seitenmodus

		#endregion

		#region----------------------------- Delegates --------------------------------------------

		public delegate void OnSelectedItemChangedEventHandler();

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// ausgewählter Listeneintrag geändert
		public event OnSelectedItemChangedEventHandler OnSelectedItemChanged;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Seite
		/// </summary>
		public Page()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Seitenmodus initialisieren
			_mode = PageMode.Preview;

			// Sortierobjekt initialisieren und zuweisen
			_listViewColumnSorter = new ListViewColumnSorter();
			listView.ListViewItemSorter = _listViewColumnSorter;
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

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Seitenmodus
		/// </summary>
		public PageMode Mode
		{
			get
			{
				return _mode;
			}
			set
			{
				SetPageMode(value);
			}
		}

		/// <summary>
		/// Ident des ausgewählten Listeneintrags
		/// </summary>
		public string SelectedItemTag
		{
			get
			{
				return listView.SelectedItems.Count > 0 ?
					listView.SelectedItems[0].Tag.ToString() : "";
			}
		}

		/// <summary>
		/// Kontextmenü der Listenansicht
		/// </summary>
		public override ContextMenu ContextMenu
		{
			get
			{
				return listView.ContextMenu;
			}
			set
			{
				listView.ContextMenu = value;
			}
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
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.listView = new System.Windows.Forms.ListView();
			this.splitterHorizontal = new System.Windows.Forms.Splitter();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(640, 24);
			this.panelTitle.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.BackColor = System.Drawing.SystemColors.ControlDark;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.SystemColors.Window;
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(639, 21);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listView
			// 
			this.listView.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView.FullRowSelect = true;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(0, 24);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(640, 136);
			this.listView.TabIndex = 1;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// splitterHorizontal
			// 
			this.splitterHorizontal.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.splitterHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitterHorizontal.Location = new System.Drawing.Point(0, 160);
			this.splitterHorizontal.Name = "splitterHorizontal";
			this.splitterHorizontal.Size = new System.Drawing.Size(640, 3);
			this.splitterHorizontal.TabIndex = 2;
			this.splitterHorizontal.TabStop = false;
			// 
			// panelBottom
			// 
			this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBottom.Location = new System.Drawing.Point(0, 163);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(640, 317);
			this.panelBottom.TabIndex = 3;
			// 
			// Page
			// 
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.splitterHorizontal);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.panelTitle);
			this.Name = "Page";
			this.Size = new System.Drawing.Size(640, 480);
			this.panelTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Listenansicht ---------------------

		/// <summary>
		/// sortiert Listenansicht nach angeklickter Spalte
		/// </summary>
		private void listView_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			try
			{
				// Sortierung konfigurieren
				if (_listViewColumnSorter.SortColumn != e.Column)
				{
					_listViewColumnSorter.SortColumn = e.Column;
					_listViewColumnSorter.SortOrder = SortOrder.Ascending;
				}
				else
				{
					_listViewColumnSorter.SortOrder =
						_listViewColumnSorter.SortOrder == SortOrder.Ascending ?
						SortOrder.Descending : SortOrder.Ascending;
				}

				// Sortierung aktualisieren
				listView.Sort();
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on sorting list view.", ex);
			}
		}

		/// <summary>
		/// signalisiert Auswahl Listeneintrag
		/// </summary>
		private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Ereignis auslösen
			RaiseOnSelectedItemChanged();
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnSelectedItemChanged aus
		/// </summary>
		protected void RaiseOnSelectedItemChanged()
		{
			try
			{
				if (OnSelectedItemChanged != null)
				{
					OnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		#endregion

		#region----------------------------- sonstige Methoden ------------------------------------

		/// <summary>
		/// aktualisiert Ansicht
		/// </summary>
		public void RefreshView()
		{
			// Sortierung aktualisieren
			listView.Sort();
		}

		/// <summary>
		/// stellt Seitenmodus ein
		/// </summary>
		private void SetPageMode(PageMode mode)
		{
			// Seitenmodus setzen
			_mode = mode;

			// Steuerelemente anzeigen/verbergen
			this.SuspendLayout();
			switch (_mode)
			{
				case PageMode.List:
					panelTitle.Visible = true;
					listView.Visible = true;
					listView.Dock = DockStyle.Fill;
					splitterHorizontal.Visible = false;
					panelBottom.Visible = false;
					break;
				case PageMode.Preview:
					panelTitle.Visible = true;
					listView.Visible = true;
					listView.Dock = DockStyle.Top;
					splitterHorizontal.Visible = true;
					panelBottom.Visible = true;
					break;
				case PageMode.Detail:
					panelTitle.Visible = false;
					listView.Visible = false;
					splitterHorizontal.Visible = false;
					panelBottom.Visible = true;
					break;
			}
			this.ResumeLayout();
		}

		#endregion

		#endregion
	}
}
