using UnityEngine;

namespace InControl
{
	public class TwoAxisInputControl : IInputControl
	{
		public static readonly TwoAxisInputControl Null;

		public DeadZoneFunc DeadZoneFunc;

		private float sensitivity;

		private float lowerDeadZone;

		private float upperDeadZone;

		private float stateThreshold;

		public bool Raw;

		private bool thisState;

		private bool lastState;

		private Vector2 thisValue;

		private Vector2 lastValue;

		private bool clearInputState;

		public float X { get; protected set; }

		public float Y { get; protected set; }

		public OneAxisInputControl Left { get; protected set; }

		public OneAxisInputControl Right { get; protected set; }

		public OneAxisInputControl Up { get; protected set; }

		public OneAxisInputControl Down { get; protected set; }

		public ulong UpdateTick { get; protected set; }

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

		public bool State => false;

		public bool LastState => false;

		public Vector2 Value => default(Vector2);

		public Vector2 LastValue => default(Vector2);

		public Vector2 Vector => default(Vector2);

		public bool HasChanged { get; protected set; }

		public bool IsPressed => false;

		public bool WasPressed => false;

		public bool WasReleased => false;

		public float Angle => 0f;

		public void ClearInputState()
		{
		}

		public void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime)
		{
		}

		internal void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime)
		{
		}

		public static implicit operator bool(TwoAxisInputControl instance)
		{
			return false;
		}

		public static implicit operator Vector2(TwoAxisInputControl instance)
		{
			return default(Vector2);
		}

		public static implicit operator Vector3(TwoAxisInputControl instance)
		{
			return default(Vector3);
		}
	}
}
