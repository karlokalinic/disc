using XInputDotNetPure;

namespace InControl
{
	public class XInputDevice : InputDevice
	{
		private const float LowerDeadZone = 0.2f;

		private const float UpperDeadZone = 0.9f;

		private readonly XInputDeviceManager owner;

		private GamePadState state;

		public int DeviceIndex { get; private set; }

		public bool IsConnected => false;

		public XInputDevice(int deviceIndex, XInputDeviceManager owner)
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		public override void Vibrate(float leftMotor, float rightMotor)
		{
		}

		internal void GetState()
		{
		}
	}
}
