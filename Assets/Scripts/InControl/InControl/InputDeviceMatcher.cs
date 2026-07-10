using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct InputDeviceMatcher
	{
		[SerializeField]
		[Hexadecimal]
		private OptionalUInt16 vendorID;

		[SerializeField]
		private OptionalUInt16 productID;

		[SerializeField]
		[Hexadecimal]
		private OptionalUInt32 versionNumber;

		[SerializeField]
		private OptionalInputDeviceDriverType driverType;

		[SerializeField]
		private OptionalInputDeviceTransportType transportType;

		[SerializeField]
		private string nameLiteral;

		[SerializeField]
		private string namePattern;

		public OptionalUInt16 VendorID
		{
			get
			{
				return default(OptionalUInt16);
			}
			set
			{
			}
		}

		public OptionalUInt16 ProductID
		{
			get
			{
				return default(OptionalUInt16);
			}
			set
			{
			}
		}

		public OptionalUInt32 VersionNumber
		{
			get
			{
				return default(OptionalUInt32);
			}
			set
			{
			}
		}

		public OptionalInputDeviceDriverType DriverType
		{
			get
			{
				return default(OptionalInputDeviceDriverType);
			}
			set
			{
			}
		}

		public OptionalInputDeviceTransportType TransportType
		{
			get
			{
				return default(OptionalInputDeviceTransportType);
			}
			set
			{
			}
		}

		public string NameLiteral
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NamePattern
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool Matches(InputDeviceInfo deviceInfo)
		{
			return false;
		}
	}
}
