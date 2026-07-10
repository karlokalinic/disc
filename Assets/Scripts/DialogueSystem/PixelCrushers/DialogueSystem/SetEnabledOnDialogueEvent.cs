using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetEnabledOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetEnabledAction : Action
		{
			public MonoBehaviour target;

			public Toggle state;
		}

		public SetEnabledAction[] onStart;

		public bool waitOneFrameOnStart;

		public SetEnabledAction[] onEnd;

		public bool waitOneFrameOnEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetEnabledAction[] actions, Transform actor, bool waitOneFrame)
		{
		}

		private void TryActionsNow(SetEnabledAction[] actions, Transform actor)
		{
		}

		private IEnumerator TryActionsAfterOneFrameCoroutine(SetEnabledAction[] actions, Transform actor)
		{
			return null;
		}

		public void DoAction(SetEnabledAction action, Transform actor)
		{
		}
	}
}
