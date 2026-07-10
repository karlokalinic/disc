using InControl;

namespace MultiplayerWithBindingsExample
{
	public class PlayerActions : PlayerActionSet
	{
		public PlayerAction Green;

		public PlayerAction Red;

		public PlayerAction Blue;

		public PlayerAction Yellow;

		public PlayerAction Left;

		public PlayerAction Right;

		public PlayerAction Up;

		public PlayerAction Down;

		public PlayerTwoAxisAction Rotate;

		public static PlayerActions CreateWithKeyboardBindings()
		{
			return null;
		}

		public static PlayerActions CreateWithJoystickBindings()
		{
			return null;
		}
	}
}
