using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public struct InputControlSource
	{
		[SerializeField]
		private InputControlSourceType sourceType;

		[SerializeField]
		private int index;

		public InputControlSourceType SourceType
		{
			get
			{
				return default(InputControlSourceType);
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public InputControlSource(InputControlSourceType sourceType, int index)
		{
			this.sourceType = default(InputControlSourceType);
			this.index = 0;
		}

		public InputControlSource(KeyCode keyCode)
		{
			sourceType = default(InputControlSourceType);
			index = 0;
		}

		public float GetValue(InputDevice inputDevice)
		{
			return 0f;
		}

		public bool GetState(InputDevice inputDevice)
		{
			return false;
		}

		public string ToCode()
		{
			return null;
		}
	}
}
