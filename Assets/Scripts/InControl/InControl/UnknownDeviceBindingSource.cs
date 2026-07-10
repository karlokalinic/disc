using System.IO;

namespace InControl
{
	public class UnknownDeviceBindingSource : BindingSource
	{
		public UnknownDeviceControl Control { get; protected set; }

		public override string Name => null;

		public override string DeviceName => null;

		public override InputDeviceClass DeviceClass => default(InputDeviceClass);

		public override InputDeviceStyle DeviceStyle => default(InputDeviceStyle);

		public override BindingSourceType BindingSourceType => default(BindingSourceType);

		internal override bool IsValid => false;

		internal UnknownDeviceBindingSource()
		{
		}

		public UnknownDeviceBindingSource(UnknownDeviceControl control)
		{
		}

		public override float GetValue(InputDevice device)
		{
			return 0f;
		}

		public override bool GetState(InputDevice device)
		{
			return false;
		}

		public override bool Equals(BindingSource other)
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

		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}

		public override void Save(BinaryWriter writer)
		{
		}
	}
}
