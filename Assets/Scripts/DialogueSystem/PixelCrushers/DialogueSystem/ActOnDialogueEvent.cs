using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class ActOnDialogueEvent : MonoBehaviour
	{
		[Serializable]
		public class Action
		{
			public Condition condition;
		}

		public DialogueEvent trigger;

		public bool once;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnSequenceStart(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public abstract void TryStartActions(Transform actor);

		public abstract void TryEndActions(Transform actor);

		private void DestroyIfOnce()
		{
		}
	}
}
