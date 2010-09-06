using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Steuerelement zur Darstellung eines Raumes.
	/// </summary>
	public class SiteView : System.Windows.Forms.UserControl
	{
		#region----------------------------- Member Variables -------------------------------------

		// Steuerelemente
		private System.Windows.Forms.PictureBox pictureBoxSite;

		// Required designer variable.
		private System.ComponentModel.Container components = null;

		// Deviceliste und Index
		private ArrayList _siteViewItems = new ArrayList(); 
		private Hashtable _siteViewItemsHash = new Hashtable();

		// ausgew�hltes Devicesymbol
		private SiteViewItem _selectedSiteViewItem;

		// Parameter
		private Site _site;          // Raum
		private string _pictureFile; // Dateiname Hintergrundbild
		private int _dragLeft;       // relative Mausposition horizontal
		private int _dragTop;        // relative Mausposition vertikal

		#endregion

		#region----------------------------- Delegates --------------------------------------------

		public delegate void OnSelectedItemChangedEventHandler();

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// ausgew�hltes Devicesymbol ge�ndert
		public event OnSelectedItemChangedEventHandler OnSelectedItemChanged;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Raumansicht
		/// </summary>
		public SiteView(Site site)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Raum referenzieren
			_site = site;
			_site.OnAddDevice += new Site.DeviceEventHandler(_site_OnAddDevice);
			_site.OnRefreshDevice += new Site.DeviceEventHandler(_site_OnRefreshDevice);
			_site.OnRemoveDevice += new Site.DeviceEventHandler(_site_OnRemoveDevice);

			// Bildgr��e einstellen
			pictureBoxSite.Width = 800;
			pictureBoxSite.Height = 600;
			pictureBoxSite.SizeMode = PictureBoxSizeMode.AutoSize;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			// Raum freigeben
			_site.OnAddDevice -= new Site.DeviceEventHandler(_site_OnAddDevice);
			_site.OnRefreshDevice -= new Site.DeviceEventHandler(_site_OnRefreshDevice);
			_site.OnRemoveDevice -= new Site.DeviceEventHandler(_site_OnRemoveDevice);
			_site = null;

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
		/// Ident des ausgew�hlten Devicesymbols
		/// </summary>
		public string SelectedItemTag
		{
			get
			{
				return _selectedSiteViewItem != null ? _selectedSiteViewItem.Tag.ToString() : "";
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
			this.pictureBoxSite = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBoxSite
			// 
			this.pictureBoxSite.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBoxSite.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxSite.Name = "pictureBoxSite";
			this.pictureBoxSite.Size = new System.Drawing.Size(312, 232);
			this.pictureBoxSite.TabIndex = 0;
			this.pictureBoxSite.TabStop = false;
			// 
			// SiteView
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.pictureBoxSite);
			this.Name = "SiteView";
			this.Size = new System.Drawing.Size(320, 240);
			this.ResumeLayout(false);

		}

		#endregion

		#region----------------------------- Ereignisbehandlung Raum ------------------------------

		/// <summary>
		/// f�gt Device zu Raum hinzu
		/// </summary>
		private void _site_OnAddDevice(Device device)
		{
			try
			{
				// neues Devicesymbol erzeugen und konfigurieren
				SiteViewItem siteViewItem = new SiteViewItem(device);
				siteViewItem.RefreshParameters();
				siteViewItem.Tag = device.Code;

				// Devicesymbol zu Ansicht, Liste und Index hinzuf�gen
				this.Controls.Add(siteViewItem);
				siteViewItem.Parent = pictureBoxSite;
				siteViewItem.BringToFront();
				_siteViewItems.Add(siteViewItem);
				_siteViewItemsHash.Add(device.Code, siteViewItem);

				// Devicesymbol positionieren
				ArrangeDevice(siteViewItem);

				// EventHandler f�r Devicesymbol initialisieren
				siteViewItem.MouseDown += new MouseEventHandler(siteViewItem_MouseDown);
				siteViewItem.MouseMove += new MouseEventHandler(siteViewItem_MouseMove);
				siteViewItem.Move += new EventHandler(siteViewItem_Move);
				siteViewItem.GotFocus += new EventHandler(siteViewItem_GotFocus);
				siteViewItem.LostFocus += new EventHandler(siteViewItem_LostFocus);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on adding device.", ex);
			}
		}

		/// <summary>
		/// aktualisiert Device
		/// </summary>
		private void _site_OnRefreshDevice(Device device)
		{
			try
			{
				// Devicesymbol in Index suchen
				SiteViewItem siteViewItem = (SiteViewItem)_siteViewItemsHash[device.Code];

				// wenn Devicesymbol gefunden, aktualisieren
				if (siteViewItem != null)
				{
					siteViewItem.RefreshParameters();
				}

				// wenn Devicesymbol ausgew�hlt, �nderung signalisieren
				if ((_selectedSiteViewItem != null) && (_selectedSiteViewItem == siteViewItem))
				{
					RaiseOnSelectedItemChanged();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on refreshing device.", ex);
			}
		}

		/// <summary>
		/// entfernt Device aus Raum
		/// </summary>
		private void _site_OnRemoveDevice(Device device)
		{
			try
			{
				// Devicesymbol in Index suchen
				SiteViewItem siteViewItem = (SiteViewItem)_siteViewItemsHash[device.Code];

				// wenn Devicesymbol gefunden, von Ansicht, Liste und Index entfernen
				if (siteViewItem != null)
				{
					this.Controls.Remove(siteViewItem);
					siteViewItem.Dispose();
					_siteViewItems.Remove(siteViewItem);	
					_siteViewItemsHash.Remove(device.Code);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on removing device.", ex);
			}
		}

		#endregion

		#region----------------------------- Ereignisbehandlung Devicesymbole ---------------------

		/// <summary>
		/// speichert releative Mausposition und startet Ziehoperation
		/// </summary>
		private void siteViewItem_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				// wenn linke Maustaste gedr�ckt
				if (e.Button == MouseButtons.Left)
				{
					// Devicesymbol referenzieren
					SiteViewItem siteViewItem = (SiteViewItem)sender;

					// relative Mausposition merken
					_dragLeft = e.X;
					_dragTop = e.Y;

					// Devicesymbol in den Vordergrund bringen
					siteViewItem.BringToFront();
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on moving device icon.", ex);
			}
		}

		/// <summary>
		/// verschiebt Devicesymbol
		/// </summary>
		private void siteViewItem_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				// wenn linke Maustaste gedr�ckt
				if (e.Button == MouseButtons.Left)
				{
					// Devicesymbol referenzieren
					SiteViewItem siteViewItem = (SiteViewItem)sender;

					// max. Position bestimmen
					int maxLeft = Math.Max(pictureBoxSite.Width - siteViewItem.Width, 0);
					int maxTop = Math.Max(pictureBoxSite.Height - siteViewItem.Height, 0);

					// neue Position bestimmen
					int left = siteViewItem.Left + e.X - _dragLeft;
					int top = siteViewItem.Top + e.Y - _dragTop;

					// neue Position korrigieren
					left = Math.Max(left, 0);
					left = Math.Min(left, maxLeft);
					top = Math.Max(top, 0);
					top = Math.Min(top, maxTop);

					// Devicesymbol verschieben
					siteViewItem.Left = left;
					siteViewItem.Top = top;
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on moving device icon.", ex);
			}
		}

		/// <summary>
		/// beschr�nkt Position des Devicesymbols
		/// </summary>
		private void siteViewItem_Move(object sender, EventArgs e)
		{
			try
			{
				// Devicesymbol referenzieren
				SiteViewItem siteViewItem = (SiteViewItem)sender;

				// Devicesymbol pr�fen und ggf. neu anordnen
				RearrangeDevice(siteViewItem);
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on moving device icon.", ex);
			}
		}

		/// <summary>
		/// aktualisiert ausgew�hltes Devicesymbol
		/// </summary>
		private void siteViewItem_GotFocus(object sender, EventArgs e)
		{
			// ausgew�hltes Devicesymbol aktualisieren
			_selectedSiteViewItem = (SiteViewItem)sender;

			// �nderung signalisieren
			RaiseOnSelectedItemChanged();
		}

		/// <summary>
		/// aktualisiert ausgew�hltes Devicesymbol
		/// </summary>
		private void siteViewItem_LostFocus(object sender, EventArgs e)
		{
			// ausgew�hltes Devicesymbol aktualisieren
			_selectedSiteViewItem = null;

			// �nderung signalisieren
			RaiseOnSelectedItemChanged();
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters()
		{
			// wenn Hintergrundbild ge�ndert
			if (_pictureFile != _site.PictureFile)
			{
				// Hintergrundbild aktualisieren
				_pictureFile = _site.PictureFile;
				if ((_pictureFile != null) && (_pictureFile != ""))
				{
					pictureBoxSite.Image = Bitmap.FromFile(_site.PictureFile);
				}
				else
				{
					pictureBoxSite.Image = null;
				}

				// Anordnung Devicesymbole pr�fen und ggf. anpassen
				RearrangeDevices();
			}
		}

		#endregion

		#region----------------------------- Ausl�sen von Ereignissen -----------------------------

		/// <summary>
		/// l�st Ereignis OnSelectedItemChanged aus
		/// </summary>
		private void RaiseOnSelectedItemChanged()
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
		/// ordnet Devicesymbole neu an
		/// </summary>
		private void RearrangeDevices()
		{
			// alle Devicesymbole pr�fen und ggf. neu anordnen
			foreach (SiteViewItem item in _siteViewItems)
			{
				RearrangeDevice(item);
			}
		}

		/// <summary>
		/// ordnet einzelnes Device neu an, wenn Position ung�ltig
		/// </summary>
		private void RearrangeDevice(SiteViewItem siteViewItem)
		{
			// max. Position bestimmen
			int maxLeft = Math.Max(pictureBoxSite.Width - siteViewItem.Width, 0);
			int maxTop = Math.Max(pictureBoxSite.Height - siteViewItem.Height, 0);

			// wenn Position ung�ltig, korrigieren
			if ((siteViewItem.Left > maxLeft) || (siteViewItem.Top > maxTop))
			{
				ArrangeDevice(siteViewItem);
			}
		}

		/// <summary>
		/// ordnet Devicesymbol an erster freier Position an
		/// </summary>
		private void ArrangeDevice(SiteViewItem siteViewItem)
		{
			// neue Position initialisieren
			int left = 0;
			int top = 0;

			// max. Position bestimmen
			int maxLeft = Math.Max(pictureBoxSite.Width - siteViewItem.Width, 0);
			int maxTop = Math.Max(pictureBoxSite.Height - siteViewItem.Height, 0);

			// �ber alle m�glichen Positionen suchen und nach M�glichkeit Steuerelement anordnen
			bool arranged = false;
			while ((top <= maxTop) && (!arranged))
			{
				left = 0;
				while ((left <= maxLeft) && (!arranged))
				{
					bool overlapped = false;
					foreach (SiteViewItem item in _siteViewItems)
					{
						if (item != siteViewItem)
						{
							if ((left > item.Left - siteViewItem.Width) &&
								(left < item.Left + item.Width) &&
								(top > item.Top - siteViewItem.Height) &&
								(top < item.Top + item.Height))
							{
								overlapped = true;
								break;
							}
						}
					}
					if (!overlapped)
					{
						siteViewItem.Left = left;
						siteViewItem.Top = top;
						arranged = true;
					}
					left += siteViewItem.Width;
				}
				top += siteViewItem.Height;
			}

			// wenn keine freie Position gefunden, Steuerelement links oben anordnen
			if (!arranged)
			{
				siteViewItem.Left = 0;
				siteViewItem.Top = 0;
			}
		}

		#endregion

		#endregion
	}
}
