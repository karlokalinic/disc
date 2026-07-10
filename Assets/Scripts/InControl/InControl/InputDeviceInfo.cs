namespace InControl
{
	public struct InputDeviceInfo
	{
		public string name;

		public string location;

		public string serialNumber;

		public ushort vendorID;

		public ushort productID;

		public uint versionNumber;

		public InputDeviceDriverType driverType;

		public InputDeviceTransportType transportType;

		public uint numButtons;

		public uint numAnalogs;

		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			return false;
		}

		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			return false;
		}
	}
}
