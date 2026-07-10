using System;
using System.IO;

namespace InControl
{
	public struct UnknownDeviceControl : IEquatable<UnknownDeviceControl>
	{
		public static readonly UnknownDeviceControl None;

		public InputControlType Control;

		public InputRangeType SourceRange;

		public bool IsButton;

		public bool IsAnalog;

		public int Index => 0;

		public UnknownDeviceControl(InputControlType control, InputRangeType sourceRange)
		{
			Control = default(InputControlType);
			SourceRange = default(InputRangeType);
			IsButton = false;
			IsAnalog = false;
		}

		internal float GetValue(InputDevice device)
		{
			return 0f;
		}

		public static bool operator ==(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			return false;
		}

		public static bool operator !=(UnknownDeviceControl a, UnknownDeviceControl b)
		{
			return false;
		}

		public bool Equals(UnknownDeviceControl other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static implicit operator bool(UnknownDeviceControl control)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal void Save(BinaryWriter writer)
		{
		}

		internal void Load(BinaryReader reader)
		{
		}
	}
}
