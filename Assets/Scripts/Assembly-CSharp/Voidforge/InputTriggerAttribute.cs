namespace Voidforge
{
	public abstract class InputTriggerAttribute : InputConditionsAttribute
	{
		public int minCount { get; set; }

		public int maxCount { get; set; }

		public InputManager.Trigger trigger { get; set; }

		public bool CanHandle(InputManager.TriggerEventData data)
		{
			return false;
		}

		public InputTriggerAttribute()
		{
		}
	}
}
