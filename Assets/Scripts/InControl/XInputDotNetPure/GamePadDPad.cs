namespace XInputDotNetPure
{
	public struct GamePadDPad
	{
		private ButtonState up;

		private ButtonState down;

		private ButtonState left;

		private ButtonState right;

		public ButtonState Up => default(ButtonState);

		public ButtonState Down => default(ButtonState);

		public ButtonState Left => default(ButtonState);

		public ButtonState Right => default(ButtonState);

		internal GamePadDPad(ButtonState up, ButtonState down, ButtonState left, ButtonState right)
		{
			this.up = default(ButtonState);
			this.down = default(ButtonState);
			this.left = default(ButtonState);
			this.right = default(ButtonState);
		}
	}
}
