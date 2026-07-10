using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetActiveOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetActiveAction : Action
		{
			public Transform target;

			public Toggle state;
		}

		public SetActiveAction[] onStart;

		public SetActiveAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetActiveAction[] actions, Transform actor)
		{
		}

		public void DoAction(SetActiveAction action, Transform actor)
		{
		}
	}
}
