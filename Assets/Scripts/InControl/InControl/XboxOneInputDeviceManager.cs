using System.Collections.Generic;

namespace InControl
{
	public class XboxOneInputDeviceManager : InputDeviceManager
	{
		private const int maxDevices = 8;

		private bool[] deviceConnected;

		private void UpdateInternal(ulong updateTick, float deltaTime)
		{
		}

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		public override void Destroy()
		{
		}

		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			return false;
		}

		internal static bool Enable()
		{
			return false;
		}
	}
}
