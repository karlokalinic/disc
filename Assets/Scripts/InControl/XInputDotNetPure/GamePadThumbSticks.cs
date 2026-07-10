using UnityEngine;

namespace XInputDotNetPure
{
	public struct GamePadThumbSticks
	{
		public struct StickValue
		{
			private Vector2 vector;

			public float X => 0f;

			public float Y => 0f;

			public Vector2 Vector => default(Vector2);

			internal StickValue(float x, float y)
			{
				vector = default(Vector2);
			}
		}

		private StickValue left;

		private StickValue right;

		public StickValue Left => default(StickValue);

		public StickValue Right => default(StickValue);

		internal GamePadThumbSticks(StickValue left, StickValue right)
		{
			this.left = default(StickValue);
			this.right = default(StickValue);
		}
	}
}
