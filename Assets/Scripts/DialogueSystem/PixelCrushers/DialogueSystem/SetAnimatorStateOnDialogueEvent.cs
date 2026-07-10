using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetAnimatorStateOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetAnimatorStateAction : Action
		{
			public Transform target;

			public string stateName;

			public float crossFadeDuration;
		}

		public SetAnimatorStateAction[] onStart;

		public SetAnimatorStateAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetAnimatorStateAction[] actions, Transform actor)
		{
		}

		public void DoAction(SetAnimatorStateAction action, Transform actor)
		{
		}
	}
}
