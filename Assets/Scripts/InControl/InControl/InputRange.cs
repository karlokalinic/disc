using System;

namespace InControl
{
	[Serializable]
	public struct InputRange
	{
		public static readonly InputRange None;

		public static readonly InputRange MinusOneToOne;

		public static readonly InputRange OneToMinusOne;

		public static readonly InputRange ZeroToOne;

		public static readonly InputRange ZeroToMinusOne;

		public static readonly InputRange OneToZero;

		public static readonly InputRange MinusOneToZero;

		private static readonly InputRange[] typeToRange;

		public readonly float Value0;

		public readonly float Value1;

		public readonly InputRangeType Type;

		private InputRange(float value0, float value1, InputRangeType type)
		{
			Value0 = 0f;
			Value1 = 0f;
			Type = default(InputRangeType);
		}

		public InputRange(InputRangeType type)
		{
			Value0 = 0f;
			Value1 = 0f;
			Type = default(InputRangeType);
		}

		public bool Includes(float value)
		{
			return false;
		}

		private bool Excludes(float value)
		{
			return false;
		}

		public static bool Excludes(InputRangeType rangeType, float value)
		{
			return false;
		}

		private static float Remap(float value, InputRange sourceRange, InputRange targetRange)
		{
			return 0f;
		}

		public static float Remap(float value, InputRangeType sourceRangeType, InputRangeType targetRangeType)
		{
			return 0f;
		}
	}
}
