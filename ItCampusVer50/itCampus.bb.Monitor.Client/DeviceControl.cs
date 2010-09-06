using System;
using System.Collections;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Verwaltet alle Devices.
	/// </summary>
	public class DeviceControl : IEnumerable
	{
		#region----------------------------- Member Variables -------------------------------------

		// Hauptobjekt
		private MainControl _mainControl;

		// Deviceliste und Index
		private ArrayList _devices = new ArrayList(); 
		private Hashtable _devicesHash = new Hashtable();

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
		/// initialisiert Deviceverwaltung
		/// </summary>
		public DeviceControl(MainControl mainControl)
		{
			// Hauptobjekt referenzieren
			_mainControl = mainControl;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Hauptobjekt
		/// </summary>
		public MainControl MainControl
		{
			get
			{
				return _mainControl;
			}
		}

		/// <summary>
		/// Standard-Eigenschaft
		/// </summary>
		public Device this[string code]
		{
			get
			{
				return (Device)_devicesHash[code];
			}
		}

		/// <summary>
		/// Anzahl Devices
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

		#region----------------------------- Deviceverwaltung -------------------------------------

		/// <summary>
		/// fügt Device zu Deviceliste hinzu
		/// </summary>
		public void AddDevice(Device device)
		{
			// Device zu Liste und Index hinzufügen
			_devices.Add(device);
			_devicesHash.Add(device.Code, device);

			// Ereignis auslösen
			RaiseOnAddDevice(device);
		}

		/// <summary>
		/// aktualisiert Device
		/// </summary>
		public void RefreshDevice(Device device)
		{
			// Ereignis auslösen
			RaiseOnRefreshDevice(device);
		}

		/// <summary>
		/// entfernt Device aus Deviceliste
		/// </summary>
		public void RemoveDevice(Device device)
		{
			// Device aus Liste und Index entfernen
			_devices.Remove(device);
			_devicesHash.Remove(device.Code);

			// Ereignis auslösen
			RaiseOnRemoveDevice(device);
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

		#region----------------------------- sonstige Methoden ------------------------------------

		/// <summary>
		/// gibt Enumerator der Deviceliste zurück
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			return _devices.GetEnumerator();
		}

		/// <summary>
		/// schließt alle Devices ab
		/// </summary>
		public void TerminateAllDevices()
		{
			// alle Devices abschließen
			foreach (Device device in (ArrayList)_devices.Clone())
			{
				device.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
