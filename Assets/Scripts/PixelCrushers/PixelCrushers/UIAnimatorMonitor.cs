using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers
{
	public class UIAnimatorMonitor
	{
		public static float MaxWaitDuration;

		private MonoBehaviour m_target;

		private bool m_lookedForAnimator;

		private Animator m_animator;

		private Animation m_animation;

		private Coroutine m_coroutine;

		public string currentTrigger { get; private set; }

		public UIAnimatorMonitor(GameObject target)
		{
		}

		public UIAnimatorMonitor(MonoBehaviour target)
		{
		}

		public void SetTrigger(string triggerName, Action callback, bool wait = true)
		{
		}

		private IEnumerator WaitForAnimation(string triggerName, Action callback, bool wait)
		{
			return null;
		}

		private bool HasAnimator()
		{
			return false;
		}

		private void CheckAnimatorModeAndTimescale(string triggerName)
		{
		}

		public void CancelCurrentAnimation()
		{
		}
	}
}
