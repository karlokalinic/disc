using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class SequenceStarter : DialogueEventStarter
	{
		[TextArea]
		public string sequence;

		public Transform speaker;

		public Transform listener;

		public Condition condition;

		private bool tryingToStart;

		public void TryStartSequence(Transform actor)
		{
		}

		public void TryStartSequence(Transform actor, Transform interactor)
		{
		}
	}
}
