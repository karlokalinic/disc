namespace InControl
{
	public class MouseBindingSourceListener : BindingSourceListener
	{
		public static float ScrollWheelThreshold;

		private Mouse detectFound;

		private int detectPhase;

		public void Reset()
		{
		}

		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			return null;
		}

		private bool IsPressed(Mouse control)
		{
			return false;
		}

		private Mouse ListenForControl(BindingListenOptions listenOptions)
		{
			return default(Mouse);
		}
	}
}
