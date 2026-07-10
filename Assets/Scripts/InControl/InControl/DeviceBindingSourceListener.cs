namespace InControl
{
	public class DeviceBindingSourceListener : BindingSourceListener
	{
		private InputControlType detectFound;

		private int detectPhase;

		public void Reset()
		{
		}

		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			return null;
		}

		private bool IsPressed(InputControl control)
		{
			return false;
		}

		private bool IsPressed(InputControlType control, InputDevice device)
		{
			return false;
		}

		private InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			return default(InputControlType);
		}
	}
}
