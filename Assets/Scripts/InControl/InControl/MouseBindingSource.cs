using System.IO;

namespace InControl
{
	public class MouseBindingSource : BindingSource
	{
		public static float ScaleX;

		public static float ScaleY;

		public static float ScaleZ;

		public static float JitterThreshold;

		private static readonly int[] buttonTable;

		public Mouse Control { get; protected set; }

		public override string Name => null;

		public override string DeviceName => null;

		public override InputDeviceClass DeviceClass => default(InputDeviceClass);

		public override InputDeviceStyle DeviceStyle => default(InputDeviceStyle);

		public override BindingSourceType BindingSourceType => default(BindingSourceType);

		internal MouseBindingSource()
		{
		}

		public MouseBindingSource(Mouse mouseControl)
		{
		}

		internal static bool SafeGetMouseButton(int button)
		{
			return false;
		}

		internal static bool ButtonIsPressed(Mouse control)
		{
			return false;
		}

		internal static bool NegativeScrollWheelIsActive(float threshold)
		{
			return false;
		}

		internal static bool PositiveScrollWheelIsActive(float threshold)
		{
			return false;
		}

		internal static float GetValue(Mouse mouseControl)
		{
			return 0f;
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

		public override void Save(BinaryWriter writer)
		{
		}

		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
		}
	}
}
