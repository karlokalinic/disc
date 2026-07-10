using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SendMessageOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SendMessageAction : Action
		{
			public Transform target;

			public string methodName;

			public string parameter;
		}

		public SendMessageAction[] onStart;

		public SendMessageAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SendMessageAction[] actions, Transform actor)
		{
		}

		private void DoAction(SendMessageAction action, Transform actor)
		{
		}
	}
}
