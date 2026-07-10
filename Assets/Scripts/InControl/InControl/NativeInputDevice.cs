namespace InControl
{
	public class NativeInputDevice : InputDevice
	{
		private const int maxUnknownButtons = 20;

		private const int maxUnknownAnalogs = 20;

		private short[] buttons;

		private short[] analogs;

		private InputDeviceProfile profile;

		private int skipUpdateFrames;

		private int numUnknownButtons;

		private int numUnknownAnalogs;

		public uint Handle { get; private set; }

		public InputDeviceInfo Info { get; private set; }

		public override bool IsSupportedOnThisPlatform => false;

		public override bool IsKnown => false;

		public override int NumUnknownButtons => 0;

		public override int NumUnknownAnalogs => 0;

		internal NativeInputDevice()
		{
		}

		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo, InputDeviceProfile deviceProfile)
		{
		}

		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		public override bool ReadRawButtonState(int index)
		{
			return false;
		}

		public override float ReadRawAnalogValue(int index)
		{
			return 0f;
		}

		private static byte FloatToByte(float value)
		{
			return 0;
		}

		public override void Vibrate(float leftMotor, float rightMotor)
		{
		}

		public override void SetLightColor(float red, float green, float blue)
		{
		}

		public override void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
		}

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
