using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetComponentEnabledOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetComponentEnabledAction : Action
		{
			public Component target;

			public Toggle state;
		}

		public SetComponentEnabledAction[] onStart;

		public bool waitOneFrameOnStart;

		public SetComponentEnabledAction[] onEnd;

		public bool waitOneFrameOnEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetComponentEnabledAction[] actions, Transform actor, bool waitOneFrame)
		{
		}

		private void TryActionsNow(SetComponentEnabledAction[] actions, Transform actor)
		{
		}

		private IEnumerator TryActionsAfterOneFrameCoroutine(SetComponentEnabledAction[] actions, Transform actor)
		{
			return null;
		}

		public void DoAction(SetComponentEnabledAction action, Transform actor)
		{
		}
	}
}
