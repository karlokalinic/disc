using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalInputDeviceDriverType
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private InputDeviceDriverType value;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public InputDeviceDriverType Value
		{
			get
			{
				return default(InputDeviceDriverType);
			}
			set
			{
			}
		}

		public OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			hasValue = false;
			this.value = default(InputDeviceDriverType);
		}

		public void Clear()
		{
		}

		public InputDeviceDriverType GetValueOrDefault(InputDeviceDriverType defaultValue)
		{
			return default(InputDeviceDriverType);
		}

		public InputDeviceDriverType GetValueOrZero()
		{
			return default(InputDeviceDriverType);
		}

		public void SetValue(InputDeviceDriverType value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalInputDeviceDriverType other)
		{
			return false;
		}

		public bool Equals(InputDeviceDriverType other)
		{
			return false;
		}

		public static bool operator ==(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			return false;
		}

		public static bool operator !=(OptionalInputDeviceDriverType a, OptionalInputDeviceDriverType b)
		{
			return false;
		}

		public static bool operator ==(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
		{
			return false;
		}

		public static bool operator !=(OptionalInputDeviceDriverType a, InputDeviceDriverType b)
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

		public static implicit operator OptionalInputDeviceDriverType(InputDeviceDriverType value)
		{
			return default(OptionalInputDeviceDriverType);
		}

		public static explicit operator InputDeviceDriverType(OptionalInputDeviceDriverType optional)
		{
			return default(InputDeviceDriverType);
		}
	}
}
