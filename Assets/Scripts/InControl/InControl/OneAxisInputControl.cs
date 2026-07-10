namespace InControl
{
	public class OneAxisInputControl : IInputControl
	{
		private float sensitivity;

		private float lowerDeadZone;

		private float upperDeadZone;

		private float stateThreshold;

		protected bool isNullControl;

		public float FirstRepeatDelay;

		public float RepeatDelay;

		public bool Raw;

		private bool enabled;

		protected bool ownerEnabled;

		private ulong pendingTick;

		private bool pendingCommit;

		private float nextRepeatTime;

		private bool wasRepeated;

		private bool clearInputState;

		private InputControlState lastState;

		private InputControlState nextState;

		private InputControlState thisState;

		public ulong UpdateTick { get; protected set; }

		public bool State => false;

		public bool LastState => false;

		public float Value => 0f;

		public float LastValue => 0f;

		public float RawValue => 0f;

		internal float NextRawValue => 0f;

		internal bool HasInput => false;

		public bool HasChanged => false;

		public bool IsPressed => false;

		public bool WasPressed => false;

		public bool WasReleased => false;

		public bool WasRepeated => false;

		public float Sensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LowerDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UpperDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StateThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsNullControl => false;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnabledInHierarchy => false;

		private void PrepareForUpdate(ulong updateTick)
		{
		}

		public bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
		{
			return false;
		}

		public bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
		{
			return false;
		}

		internal bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
		{
			return false;
		}

		internal void SetValue(float value, ulong updateTick)
		{
		}

		public void ClearInputState()
		{
		}

		public void Commit()
		{
		}

		public void CommitWithState(bool state, ulong updateTick, float deltaTime)
		{
		}

		public void CommitWithValue(float value, ulong updateTick, float deltaTime)
		{
		}

		internal void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
		{
		}

		public static implicit operator bool(OneAxisInputControl instance)
		{
			return false;
		}

		public static implicit operator float(OneAxisInputControl instance)
		{
			return 0f;
		}
	}
}
