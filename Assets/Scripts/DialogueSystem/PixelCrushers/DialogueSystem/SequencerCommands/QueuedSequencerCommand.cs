using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class QueuedSequencerCommand
	{
		public string command;

		public string[] parameters;

		public float startTime;

		public string messageToWaitFor;

		public string endMessage;

		public bool required;

		public Transform speaker;

		public Transform listener;

		public QueuedSequencerCommand(string command, string[] parameters, float startTime, string messageToWaitFor, string endMessage, bool required, Transform speaker = null, Transform listener = null)
		{
		}
	}
}
