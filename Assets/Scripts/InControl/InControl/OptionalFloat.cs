using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct OptionalFloat
	{
		[SerializeField]
		private bool hasValue;

		[SerializeField]
		private float value;

		private const float epsilon = 1E-07f;

		public bool HasValue => false;

		public bool HasNoValue => false;

		public float Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public OptionalFloat(float value)
		{
			hasValue = false;
			this.value = 0f;
		}

		public void Clear()
		{
		}

		public float GetValueOrDefault(float defaultValue)
		{
			return 0f;
		}

		public float GetValueOrZero()
		{
			return 0f;
		}

		public void SetValue(float value)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(OptionalFloat other)
		{
			return false;
		}

		public bool Equals(float other)
		{
			return false;
		}

		public static bool operator ==(OptionalFloat a, OptionalFloat b)
		{
			return false;
		}

		public static bool operator !=(OptionalFloat a, OptionalFloat b)
		{
			return false;
		}

		public static bool operator ==(OptionalFloat a, float b)
		{
			return false;
		}

		public static bool operator !=(OptionalFloat a, float b)
		{
			return false;
		}

		private static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator OptionalFloat(float value)
		{
			return default(OptionalFloat);
		}

		public static explicit operator float(OptionalFloat optional)
		{
			return 0f;
		}

		private static bool IsApproximatelyEqual(float a, float b)
		{
			return false;
		}

		public bool ApproximatelyEquals(float other)
		{
			return false;
		}
	}
}
