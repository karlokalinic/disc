namespace InControl
{
	public class UnknownDeviceBindingSourceListener : BindingSourceListener
	{
		private enum DetectPhase
		{
			WaitForInitialRelease = 0,
			WaitForControlPress = 1,
			WaitForControlRelease = 2
		}

		private UnknownDeviceControl detectFound;

		private DetectPhase detectPhase;

		public void Reset()
		{
		}

		private void TakeSnapshotOnUnknownDevices()
		{
		}

		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			return null;
		}

		private bool IsPressed(UnknownDeviceControl control, InputDevice device)
		{
			return false;
		}

		private UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			return default(UnknownDeviceControl);
		}
	}
}
