using InControl;

namespace BindingsExample
{
	public class PlayerActions : PlayerActionSet
	{
		public readonly PlayerAction Fire;

		public readonly PlayerAction Jump;

		public readonly PlayerAction Left;

		public readonly PlayerAction Right;

		public readonly PlayerAction Up;

		public readonly PlayerAction Down;

		public readonly PlayerTwoAxisAction Move;

		public static PlayerActions CreateWithDefaultBindings()
		{
			return null;
		}
	}
}
