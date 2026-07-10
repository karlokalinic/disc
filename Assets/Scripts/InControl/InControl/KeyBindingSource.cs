using System.IO;

namespace InControl
{
	public class KeyBindingSource : BindingSource
	{
		public KeyCombo Control { get; protected set; }

		public override string Name => null;

		public override string DeviceName => null;

		public override InputDeviceClass DeviceClass => default(InputDeviceClass);

		public override InputDeviceStyle DeviceStyle => default(InputDeviceStyle);

		public override BindingSourceType BindingSourceType => default(BindingSourceType);

		internal KeyBindingSource()
		{
		}

		public KeyBindingSource(KeyCombo keyCombo)
		{
		}

		public KeyBindingSource(params Key[] keys)
		{
		}

		public override float GetValue(InputDevice inputDevice)
		{
			return 0f;
		}

		public override bool GetState(InputDevice inputDevice)
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
