namespace InControl
{
	public class UnityInputDevice : InputDevice
	{
		private static string[,] analogQueries;

		private static string[,] buttonQueries;

		public const int MaxDevices = 10;

		public const int MaxButtons = 20;

		public const int MaxAnalogs = 20;

		private readonly InputDeviceProfile profile;

		public ulong ControllerId { get; private set; }

		public int JoystickId { get; private set; }

		public override bool IsSupportedOnThisPlatform => false;

		public override bool IsKnown => false;

		public override int NumUnknownButtons => 0;

		public override int NumUnknownAnalogs => 0;

		public UnityInputDevice(int joystickId, string joystickName)
		{
		}

		public UnityInputDevice(InputDeviceProfile deviceProfile, int joystickId, string joystickName)
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		private static void SetupAnalogQueries()
		{
		}

		private static void SetupButtonQueries()
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
	}
}
