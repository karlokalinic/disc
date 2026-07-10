using InControl;
using UnityEngine;

namespace CollageMode
{
	public abstract class NavigationInputHandler : MonoBehaviour
	{
		private const float REPEAT_INITIAL_WAIT = 0.5f;

		private const float REPEAT_SPEEDUP_WAIT = 2f;

		private const float REPEAT_INTERVAL = 0.12f;

		private const float REPEAT_SPEEDUP_INTERVAL = 0.06f;

		[SerializeField]
		private CollageInputType inputType;

		private INavigationReceiver navigationReceiver;

		private float repeatTime;

		private float holdStartedTime;

		protected abstract PlayerAction NextAction { get; }

		protected abstract PlayerAction PreviousAction { get; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private float CalculateRepeatInterval()
		{
			return 0f;
		}
	}
}
