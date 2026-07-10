using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetAnimationOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetAnimationAction : Action
		{
			public Transform target;

			public AnimationClip animationClip;
		}

		public SetAnimationAction[] onStart;

		public SetAnimationAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetAnimationAction[] actions, Transform actor)
		{
		}

		public void DoAction(SetAnimationAction action, Transform actor)
		{
		}
	}
}
