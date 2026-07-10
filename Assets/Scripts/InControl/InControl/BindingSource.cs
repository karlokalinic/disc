using System;
using System.IO;

namespace InControl
{
	public abstract class BindingSource : IEquatable<BindingSource>
	{
		public abstract string Name { get; }

		public abstract string DeviceName { get; }

		public abstract InputDeviceClass DeviceClass { get; }

		public abstract InputDeviceStyle DeviceStyle { get; }

		public abstract BindingSourceType BindingSourceType { get; }

		internal PlayerAction BoundTo { get; set; }

		internal virtual bool IsValid => false;

		public abstract float GetValue(InputDevice inputDevice);

		public abstract bool GetState(InputDevice inputDevice);

		public abstract bool Equals(BindingSource other);

		public static bool operator ==(BindingSource a, BindingSource b)
		{
			return false;
		}

		public static bool operator !=(BindingSource a, BindingSource b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public abstract void Save(BinaryWriter writer);

		public abstract void Load(BinaryReader reader, ushort dataFormatVersion);
	}
}
