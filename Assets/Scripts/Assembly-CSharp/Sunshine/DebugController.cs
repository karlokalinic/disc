namespace Sunshine
{
	public class DebugController
	{
		private static bool forceControllerModeActive;

		public static bool IsForceShowControllerModeActive => false;

		public static InputHotplugHandler.InputDeviceType SelectedInputDevice { get; private set; }

		public static void ActivateForceController(InputHotplugHandler.InputDeviceType inputDeviceType)
		{
		}

		public static void DeactivateForceController()
		{
		}

		public static CrossPlatformInputManager.ButtonsState GetButtonState()
		{
			return default(CrossPlatformInputManager.ButtonsState);
		}
	}
}
