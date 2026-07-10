using System.Collections;
using UnityEngine;

namespace Accessibility
{
	public class InputDelayController
	{
		private const float DELAY = 0.5f;

		private static Coroutine inputDelayCor;

		public static bool AllowInput => false;

		public static void StartInputDelayCor()
		{
		}

		private static IEnumerator DelayCoroutine()
		{
			return null;
		}
	}
}
