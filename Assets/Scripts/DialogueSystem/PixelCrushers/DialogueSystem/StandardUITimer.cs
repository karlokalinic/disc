using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUITimer : MonoBehaviour
	{
		private Slider slider;

		private float m_startTime;

		public virtual void Awake()
		{
		}

		public virtual void StartCountdown(float duration, Action timeoutHandler)
		{
		}

		private IEnumerator Countdown(float duration, Action timeoutHandler)
		{
			return null;
		}

		public virtual void StopCountdown()
		{
		}

		public void SkipTime(float amountToSkip)
		{
		}

		public virtual void UpdateTimeLeft(float normalizedTimeLeft)
		{
		}
	}
}
