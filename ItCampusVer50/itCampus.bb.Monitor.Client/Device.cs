using System;
using System.Drawing;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten eines Devices.
	/// </summary>
	public class Device
	{
		#region----------------------------- Member Variables -------------------------------------

		// Deviceverwaltung
		private DeviceControl _deviceControl;

		// Parameter
		private string _code;       // Devicecode
		private Frontend _frontend; // Frontend
		private Site _site;         // Raum
		private Point _location;    // Position im Raum

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Device
		/// </summary>
		public Device(string code, DeviceControl deviceControl)
		{
			// Parameter initialisieren
			_code = code;

			// Device zu Deviceverwaltung hinzufügen
			_deviceControl = deviceControl;
			_deviceControl.AddDevice(this);
		}

		/// <summary>
		/// schließt Device ab
		/// </summary>
		public void Terminate()
		{
			// wenn Frontend zugewiesen, Fehler werfen
			if (_frontend != null)
			{
				throw new Exception("Device is in use and cannot be removed.");
			}

			// wenn Raum zugewiesen, Zuweisung aufheben
			if (_site != null)
			{
				UnassignSite();
			}

			// Device aus Deviceverwaltung entfernen
			_deviceControl.RemoveDevice(this);
			_deviceControl = null;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Devicecode
		/// </summary>
		public string Code
		{
			get
			{
				return _code;
			}
		}

		/// <summary>
		/// Frontend
		/// </summary>
		public Frontend Frontend
		{
			get
			{
				return _frontend;
			}
		}

		/// <summary>
		/// Raum
		/// </summary>
		public Site Site
		{
			get
			{
				return _site;
			}
		}

		/// <summary>
		/// Position im Raum
		/// </summary>
		public Point Location
		{
			get
			{
				return _location;
			}
			set
			{
				SetLocation(value);
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Devicesteuerung --------------------------------------

		/// <summary>
		/// weist Frontend zu
		/// </summary>
		public void AssignFrontend(Frontend frontend)
		{
			// Frontend zuweisen
			_frontend = frontend;

			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);

			// wenn Raum zugeordnet, aktualisieren
			if (_site != null)
			{
				_site.RefreshDevice(this);
			}
		}

		/// <summary>
		/// aktualisiert Frontend
		/// </summary>
		public void RefreshFrontend()
		{
			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);

			// wenn Raum zugeordnet, aktualisieren
			if (_site != null)
			{
				_site.RefreshDevice(this);
			}
		}

		/// <summary>
		/// hebt Frontendzuweisung auf
		/// </summary>
		public void UnassignFrontend()
		{
			// Frontend freigeben
			_frontend = null;

			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);

			// wenn Raum zugeordnet, aktualisieren
			if (_site != null)
			{
				_site.RefreshDevice(this);
			}
		}

		/// <summary>
		/// weist Raum zu
		/// </summary>
		public void AssignSite(Site site)
		{
			// Raum zuweisen
			_site = site;
			_site.AddDevice(this);

			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);
		}

		/// <summary>
		/// aktualisiert Raum
		/// </summary>
		public void RefreshSite()
		{
			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);
		}

		/// <summary>
		/// hebt Raumzuweisung auf
		/// </summary>
		public void UnassignSite()
		{
			// Raum freigeben
			_site.RemoveDevice(this);
			_site = null;

			// Deviceverwaltung aktualisieren
			_deviceControl.RefreshDevice(this);
		}

		/// <summary>
		/// aktualisiert Position im Raum
		/// </summary>
		private void SetLocation(Point location)
		{
			// Position aktualisieren
			_location = location;

			// wenn Raum zugeordnet, aktualisieren
			if (_site != null)
			{
				_site.RefreshDevice(this);
			}
		}

		#endregion

		#endregion
	}
}
