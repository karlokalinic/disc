using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class StandardSceneTransitionManager : SceneTransitionManager
	{
		[Serializable]
		public class TransitionInfo
		{
			public Animator animator;

			public string trigger;

			public float animationDuration;

			public float minTransitionDuration;

			public UnityEvent onTransitionStart;

			public UnityEvent onTransitionEnd;

			public void TriggerAnimation()
			{
			}
		}

		public bool pauseDuringTransition;

		public TransitionInfo leaveSceneTransition;

		public string loadingSceneName;

		public TransitionInfo enterSceneTransition;

		public override IEnumerator LeaveScene()
		{
			return null;
		}

		public override IEnumerator EnterScene()
		{
			return null;
		}
	}
}
