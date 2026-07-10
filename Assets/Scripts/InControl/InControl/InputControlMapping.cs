using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public class InputControlMapping
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private bool invert;

		[SerializeField]
		private float scale;

		[SerializeField]
		private bool raw;

		[SerializeField]
		private bool passive;

		[SerializeField]
		private bool ignoreInitialZeroValue;

		[SerializeField]
		private float sensitivity;

		[SerializeField]
		private float lowerDeadZone;

		[SerializeField]
		private float upperDeadZone;

		[SerializeField]
		private InputControlSource source;

		[SerializeField]
		private InputControlType target;

		[SerializeField]
		private InputRangeType sourceRange;

		[SerializeField]
		private InputRangeType targetRange;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Invert
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Raw
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Passive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IgnoreInitialZeroValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public InputControlSource Source
		{
			get
			{
				return default(InputControlSource);
			}
			set
			{
			}
		}

		public InputControlType Target
		{
			get
			{
				return default(InputControlType);
			}
			set
			{
			}
		}

		public InputRangeType SourceRange
		{
			get
			{
				return default(InputRangeType);
			}
			set
			{
			}
		}

		public InputRangeType TargetRange
		{
			get
			{
				return default(InputRangeType);
			}
			set
			{
			}
		}

		public float ApplyToValue(float value)
		{
			return 0f;
		}
	}
}
