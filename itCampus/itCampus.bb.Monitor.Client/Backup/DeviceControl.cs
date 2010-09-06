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

		// Device hinzugef�gt
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
		/// f�gt Device zu Deviceliste hinzu
		/// </summary>
		public void AddDevice(Device device)
		{
			// Device zu Liste und Index hinzuf�gen
			_devices.Add(device);
			_devicesHash.Add(device.Code, device);

			// Ereignis ausl�sen
			RaiseOnAddDevice(device);
		}

		/// <summary>
		/// aktualisiert Device
		/// </summary>
		public void RefreshDevice(Device device)
		{
			// Ereignis ausl�sen
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

			// Ereignis ausl�sen
			RaiseOnRemoveDevice(device);
		}

		#endregion

		#region----------------------------- Ausl�sen von Ereignissen -----------------------------

		/// <summary>
		/// l�st Ereignis OnAddDevice aus
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
		/// l�st Ereignis OnRefreshDevice aus
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
		/// l�st Ereignis OnRemoveDevice aus
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
		/// gibt Enumerator der Deviceliste zur�ck
		/// </summary>
		public IEnumerator GetEnumerator()
		{
			return _devices.GetEnumerator();
		}

		/// <summary>
		/// schlie�t alle Devices ab
		/// </summary>
		public void TerminateAllDevices()
		{
			// alle Devices abschlie�en
			foreach (Device device in (ArrayList)_devices.Clone())
			{
				device.Terminate();
			}
		}

		#endregion

		#endregion
	}
}
