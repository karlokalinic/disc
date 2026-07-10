using System.Collections.Generic;

namespace InControl
{
	public class UnityInputDeviceManager : InputDeviceManager
	{
		private const float deviceRefreshInterval = 1f;

		private float deviceRefreshTimer;

		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		private readonly List<InputDeviceProfile> customDeviceProfiles;

		private string[] joystickNames;

		private int lastJoystickCount;

		private int lastJoystickHash;

		private int joystickCount;

		private int joystickHash;

		private bool JoystickInfoHasChanged => false;

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		private void QueryJoystickInfo()
		{
		}

		private void AttachDevices()
		{
		}

		private void DetachDevices()
		{
		}

		public void ReloadDevices()
		{
		}

		private void AttachDevice(UnityInputDevice device)
		{
		}

		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			return false;
		}

		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
		}

		private InputDeviceProfile DetectDevice(string unityJoystickName)
		{
			return null;
		}

		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
		}

		private void AddSystemDeviceProfiles()
		{
		}
	}
}
