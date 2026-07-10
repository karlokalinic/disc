namespace XInputDotNetPure
{
	public struct GamePadButtons
	{
		private ButtonState start;

		private ButtonState back;

		private ButtonState leftStick;

		private ButtonState rightStick;

		private ButtonState leftShoulder;

		private ButtonState rightShoulder;

		private ButtonState a;

		private ButtonState b;

		private ButtonState x;

		private ButtonState y;

		public ButtonState Start => default(ButtonState);

		public ButtonState Back => default(ButtonState);

		public ButtonState LeftStick => default(ButtonState);

		public ButtonState RightStick => default(ButtonState);

		public ButtonState LeftShoulder => default(ButtonState);

		public ButtonState RightShoulder => default(ButtonState);

		public ButtonState A => default(ButtonState);

		public ButtonState B => default(ButtonState);

		public ButtonState X => default(ButtonState);

		public ButtonState Y => default(ButtonState);

		internal GamePadButtons(ButtonState start, ButtonState back, ButtonState leftStick, ButtonState rightStick, ButtonState leftShoulder, ButtonState rightShoulder, ButtonState a, ButtonState b, ButtonState x, ButtonState y)
		{
			this.start = default(ButtonState);
			this.back = default(ButtonState);
			this.leftStick = default(ButtonState);
			this.rightStick = default(ButtonState);
			this.leftShoulder = default(ButtonState);
			this.rightShoulder = default(ButtonState);
			this.a = default(ButtonState);
			this.b = default(ButtonState);
			this.x = default(ButtonState);
			this.y = default(ButtonState);
		}
	}
}
