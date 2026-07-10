using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandVoice : SequencerCommand
	{
		private float stopTime;

		private Transform subject;

		private string finalClipName;

		private Animation anim;

		private Animator animator;

		private AudioSource audioSource;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
