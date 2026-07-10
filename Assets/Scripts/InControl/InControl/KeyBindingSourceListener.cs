namespace InControl
{
	public class KeyBindingSourceListener : BindingSourceListener
	{
		private KeyCombo detectFound;

		private int detectPhase;

		public void Reset()
		{
		}

		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			return null;
		}
	}
}
