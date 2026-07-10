using System.Collections;
using UnityEngine;

namespace Sunshine
{
	public class AnimationStateSwitcher : StateSwitcher
	{
		private Animator animator;

		public string animationName;

		private int animationHash;

		private bool activateOnActivate;

		protected override void OnAwakeInitialized()
		{
		}

		public void OnEnable()
		{
		}

		public override void BecomeActive()
		{
		}

		private IEnumerator WaitAndSetAnimator()
		{
			return null;
		}

		public override void StopBeingActive()
		{
		}
	}
}
