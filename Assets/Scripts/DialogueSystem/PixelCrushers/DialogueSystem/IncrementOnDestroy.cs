using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class IncrementOnDestroy : MonoBehaviour
	{
		public enum IncrementOn
		{
			Destroy = 0,
			Disable = 1,
			Manually = 2
		}

		public IncrementOn incrementOn;

		public string variable;

		public int increment;

		public int min;

		public int max;

		public string alertMessage;

		public float alertDuration;

		public Condition condition;

		public UnityEvent onIncrement;

		private bool listenForOnDestroy;

		protected string actualVariableName => null;

		protected string ActualVariableName => null;

		public void OnEnable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnDisable()
		{
		}

		public void TryIncrement()
		{
		}
	}
}
