using System;
using UnityEngine;

namespace InControl
{
	public class Touch
	{
		public const int FingerID_None = -1;

		public const int FingerID_Mouse = -2;

		public int fingerId;

		public int mouseButton;

		public TouchPhase phase;

		public int tapCount;

		public Vector2 position;

		public Vector2 startPosition;

		public Vector2 deltaPosition;

		public Vector2 lastPosition;

		public float deltaTime;

		public ulong updateTick;

		public TouchType type;

		public float altitudeAngle;

		public float azimuthAngle;

		public float maximumPossiblePressure;

		public float pressure;

		public float radius;

		public float radiusVariance;

		[Obsolete]
		public float normalizedPressure => 0f;

		public float NormalizedPressure => 0f;

		public bool IsMouse => false;

		internal Touch()
		{
		}

		internal void Reset()
		{
		}

		internal void SetWithTouchData(UnityEngine.Touch touch, ulong updateTick, float deltaTime)
		{
		}

		internal bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
		{
			return false;
		}
	}
}
