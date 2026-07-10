using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetQuestStateOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetQuestStateAction : Action
		{
			public string questName;

			[QuestState]
			public QuestState questState;

			public string alertMessage;
		}

		public SetQuestStateAction[] onStart;

		public SetQuestStateAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetQuestStateAction[] actions, Transform actor)
		{
		}

		public void DoAction(SetQuestStateAction action, Transform actor)
		{
		}
	}
}
