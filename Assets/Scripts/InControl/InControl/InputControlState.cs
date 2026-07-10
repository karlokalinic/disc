namespace InControl
{
	public struct InputControlState
	{
		public bool State;

		public float Value;

		public float RawValue;

		public void Reset()
		{
		}

		public void Set(float value)
		{
		}

		public void Set(float value, float threshold)
		{
		}

		public void Set(bool state)
		{
		}

		public static implicit operator bool(InputControlState state)
		{
			return false;
		}

		public static implicit operator float(InputControlState state)
		{
			return 0f;
		}

		public static bool operator ==(InputControlState a, InputControlState b)
		{
			return false;
		}

		public static bool operator !=(InputControlState a, InputControlState b)
		{
			return false;
		}
	}
}
