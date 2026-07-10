namespace InControl
{
	public class InputControl : OneAxisInputControl
	{
		public static readonly InputControl Null;

		public bool Passive;

		private ulong zeroTick;

		public string Handle { get; protected set; }

		public InputControlType Target { get; protected set; }

		public bool IsButton { get; protected set; }

		public bool IsAnalog { get; protected set; }

		internal bool IsOnZeroTick => false;

		public bool IsStandard => false;

		private InputControl()
		{
		}

		public InputControl(string handle, InputControlType target)
		{
		}

		public InputControl(string handle, InputControlType target, bool passive)
		{
		}

		internal void SetZeroTick()
		{
		}
	}
}
