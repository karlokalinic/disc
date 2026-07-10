namespace InControl
{
	public class OuyaEverywhereDevice : InputDevice
	{
		private const float LowerDeadZone = 0.2f;

		private const float UpperDeadZone = 0.9f;

		public int DeviceIndex { get; private set; }

		public bool IsConnected => false;

		public OuyaEverywhereDevice(int deviceIndex)
		{
		}

		public void BeforeAttach()
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}
	}
}
