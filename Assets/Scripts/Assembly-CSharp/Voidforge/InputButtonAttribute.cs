namespace Voidforge
{
	public class InputButtonAttribute : InputTriggerAttribute
	{
		public string button { get; set; }

		public bool CanHandle(InputManager.ButtonEventData data)
		{
			return false;
		}

		public InputButtonAttribute(string button)
		{
		}
	}
}
