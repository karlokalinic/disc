using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalInputDeviceTransportType
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private InputDeviceTransportType value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public InputDeviceTransportType Value
		{
			get
			{
				return default(InputDeviceTransportType);
			}
			set
			{
			}
		}

		public OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			hasValue = false;
			this.value = default(InputDeviceTransportType);
		}

		public void Clear()
		{
		}

		public InputDeviceTransportType GetValueOrDefault(InputDeviceTransportType defaultValue)
		{
			return default(InputDeviceTransportType);
		}

		public InputDeviceTransportType GetValueOrZero()
		{
			return default(InputDeviceTransportType);
		}

		public void SetValue(InputDeviceTransportType value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalInputDeviceTransportType other)
		{
			return false;
		}

		public bool Equals(InputDeviceTransportType other)
		{
			return false;
		}

		public static bool operator ==(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			return false;
		}

		public static bool operator !=(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			return false;
		}

		public static bool operator ==(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			return false;
		}

		public static bool operator !=(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			return false;
		}

		private static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			return default(OptionalInputDeviceTransportType);
		}

		public static explicit operator InputDeviceTransportType(OptionalInputDeviceTransportType optional)
		{
			return default(InputDeviceTransportType);
		}
	}
}
