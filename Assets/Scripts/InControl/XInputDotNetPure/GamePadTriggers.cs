namespace XInputDotNetPure
{
	public struct GamePadTriggers
	{
		private float left;

		private float right;

		public float Left => 0f;

		public float Right => 0f;

		internal GamePadTriggers(float left, float right)
		{
			this.left = 0f;
			this.right = 0f;
		}
	}
}
