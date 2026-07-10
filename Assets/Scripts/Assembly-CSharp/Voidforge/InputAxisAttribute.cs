namespace Voidforge
{
	public class InputAxisAttribute : InputConditionsAttribute
	{
		public string axis { get; set; }

		public float deadzone { get; set; }

		public bool ignoreZeroValue { get; set; }

		public bool CanHandle(InputManager.AxisEventData data)
		{
			return false;
		}

		public bool IsZero(float value)
		{
			return false;
		}

		public InputAxisAttribute(string axis)
		{
		}
	}
}
