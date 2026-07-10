using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class UIShowHideController
	{
		public enum TransitionMode
		{
			State = 0,
			Trigger = 1
		}

		public enum State
		{
			Undefined = 0,
			Showing = 1,
			Shown = 2,
			Hiding = 3,
			Hidden = 4
		}

		public static float maxWaitDuration;

		private TransitionMode m_transitionMode;

		private Animator m_animator;

		private bool m_lookedForAnimator;

		private Coroutine m_animCoroutine;

		public Component panel { get; set; }

		public State state { get; set; }

		public bool debug { get; set; }

		public UIShowHideController(GameObject gameObjectToControl, Component panelToControl, TransitionMode animationMode = TransitionMode.Trigger, bool debug = false)
		{
		}

		public void Show(string showState, bool pauseAfterAnimation, Action callback, bool wait = true)
		{
		}

		public void Hide(string hideState, Action callback)
		{
		}

		private IEnumerator WaitForAnimationState(State stateWhenBegin, State stateWhenEnd, string stateName, bool pauseAfterAnimation, bool panelActive, bool wait, Action callback)
		{
			return null;
		}

		private IEnumerator WaitForAnimationTrigger(State stateWhenBegin, State stateWhenEnd, string triggerName, bool pauseAfterAnimation, bool panelActive, bool wait, Action callback)
		{
			return null;
		}

		private void CheckAnimatorModeAndTimescale(string triggerName)
		{
		}

		private void CancelCurrentAnim()
		{
		}

		public void ClearTrigger(string triggerName)
		{
		}

		private bool CanTriggerAnimation(string stateName)
		{
			return false;
		}

		private bool HasAnimator()
		{
			return false;
		}
	}
}
