using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten eines Raumes.
	/// </summary>
	public class Site
	{
		#region----------------------------- Member Variables -------------------------------------

		// Raumverwaltung
		private SiteControl _siteControl;

		// Parameter
		private string _code;        // Raumcode
		private string _name;        // Raumname
		private string _pictureFile; // Dateiname Hintergrundbild

		// Deviceliste
		private ArrayList _devices = new ArrayList();

		#endregion

		#region----------------------------- Delegates --------------------------------------------
		
		public delegate void DeviceEventHandler(Device device);

		#endregion

		#region----------------------------- Events -----------------------------------------------

		// Device hinzugefügt
		public event DeviceEventHandler OnAddDevice;

		// Device aktualisiert
		public event DeviceEventHandler OnRefreshDevice;

		// Device entfernt
		public event DeviceEventHandler OnRemoveDevice;

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Raum
		/// </summary>
		public Site(string code, SiteControl siteControl)
		{
			// Parameter initialisieren
			_code = code;

			// Raum zu Raumverwaltung hinzufügen
			_siteControl = siteControl;
			_siteControl.AddSite(this);
		}

		/// <summary>
		/// schließt Raum ab
		/// </summary>
		public void Terminate()
		{
			// alle Devices aus Raum entfernen
			foreach (Device device in (ArrayList)_devices.Clone())
			{
				device.UnassignSite();
			}

			// Raum aus Raumverwaltung entfernen
			_siteControl.RemoveSite(this);
			_siteControl = null;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Raumcode
		/// </summary>
		public string Code
		{
			get
			{
				return _code;
			}
		}

		/// <summary>
		/// Raumname
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// Dateiname Hintergrundbild
		/// </summary>
		public string PictureFile
		{
			get
			{
				return _pictureFile;
			}
		}

		/// <summary>
		/// Deviceanzahl
		/// </summary>
		public int DeviceCount
		{
			get
			{
				return _devices.Count;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(string name, string pictureFile)
		{
			// Parameter aktualisieren
			_name = name;
			_pictureFile = pictureFile;

			// Raumverwaltung aktualisieren
			_siteControl.RefreshSite(this);

			// zugeordnete Devices aktualisieren
			foreach (Device device in _devices)
			{
				device.RefreshSite();
			}
		}

		#endregion

		#region----------------------------- Deviceverwaltung -------------------------------------

		/// <summary>
		/// fügt Device hinzu
		/// </summary>
		public void AddDevice(Device device)
		{
			// Device zu Liste hinzufügen
			_devices.Add(device);

			// Ereignis auslösen
			RaiseOnAddDevice(device);

			// Raumverwaltung aktualisieren
			_siteControl.RefreshSite(this);
		}

		/// <summary>
		/// aktualisiert Device
		/// </summary>
		public void RefreshDevice(Device device)
		{
			// Ereignis aktualisieren
			RaiseOnRefreshDevice(device);
		}

		/// <summary>
		/// entfernt Device
		/// </summary>
		public void RemoveDevice(Device device)
		{
			// Device aus Liste entfernen
			_devices.Remove(device);

			// Ereignis auslösen
			RaiseOnRemoveDevice(device);

			// Raumverwaltung aktualisieren
			_siteControl.RefreshSite(this);
		}

		#endregion

		#region----------------------------- Auslösen von Ereignissen -----------------------------

		/// <summary>
		/// löst Ereignis OnAddDevice aus
		/// </summary>
		private void RaiseOnAddDevice(Device device)
		{
			try
			{
				if (OnAddDevice != null)
				{
					OnAddDevice(device);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRefreshDevice aus
		/// </summary>
		private void RaiseOnRefreshDevice(Device device)
		{
			try
			{
				if (OnRefreshDevice != null)
				{
					OnRefreshDevice(device);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		/// <summary>
		/// löst Ereignis OnRemoveDevice aus
		/// </summary>
		private void RaiseOnRemoveDevice(Device device)
		{
			try
			{
				if (OnRemoveDevice != null)
				{
					OnRemoveDevice(device);
				}
			}
			catch (Exception ex)
			{
				Logger.Log.Error("Error on raising event.", ex);
			}
		}

		#endregion

		#endregion
	}
}
