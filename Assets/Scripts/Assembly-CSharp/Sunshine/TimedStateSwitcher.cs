using System;
using UnityEngine;

namespace Sunshine
{
	public class TimedStateSwitcher : MonoBehaviour
	{
		[Serializable]
		public class TimedAreaState
		{
			public string Area;

			public string State;

			public int Day;

			public int Hour;

			public int Minute;
		}

		public TimedAreaState State;

		public void Start()
		{
		}

		private void CheckForStateSwitch()
		{
		}
	}
}
