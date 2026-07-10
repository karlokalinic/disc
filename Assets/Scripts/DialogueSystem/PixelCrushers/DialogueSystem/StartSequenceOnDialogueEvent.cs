using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StartSequenceOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SequenceAction : Action
		{
			public Transform actor;

			public Transform otherParticipant;

			[Multiline]
			public string sequence;
		}

		public SequenceAction[] onStart;

		public SequenceAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SequenceAction[] actions, Transform actor)
		{
		}

		public void DoAction(SequenceAction action, Transform actor)
		{
		}
	}
}
