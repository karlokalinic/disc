namespace InControl
{
	public class XboxOneInputDevice : InputDevice
	{
		private const uint AnalogLeftStickX = 0u;

		private const uint AnalogLeftStickY = 1u;

		private const uint AnalogRightStickX = 3u;

		private const uint AnalogRightStickY = 4u;

		private const uint AnalogLeftTrigger = 8u;

		private const uint AnalogRightTrigger = 9u;

		private const float LowerDeadZone = 0.2f;

		private const float UpperDeadZone = 0.9f;

		private string[] analogAxisNameForId;

		internal uint JoystickId { get; private set; }

		public ulong ControllerId { get; private set; }

		public bool IsConnected => false;

		public XboxOneInputDevice(uint joystickId)
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		public override void Vibrate(float leftMotor, float rightMotor)
		{
		}

		public void Vibrate(float leftMotor, float rightMotor, float leftTrigger, float rightTrigger)
		{
		}

		private string AnalogAxisNameForId(uint analogId)
		{
			return null;
		}

		private void CacheAnalogAxisNameForId(uint analogId)
		{
		}

		private void CacheAnalogAxisNames()
		{
		}
	}
}
