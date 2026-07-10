using FortressOccident;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandSetDestination : SequencerCommand
	{
		private Transform target;

		private Transform subject;

		private Character subjectChar;

		private float Heading;

		public void Start()
		{
		}

		protected void OnCharacterArrival(Character c, bool wasDestinationReached)
		{
		}
	}
}
