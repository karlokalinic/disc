using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAnimatorFloat : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private int animatorParameterHash;

		private float targetValue;

		private Transform subject;

		private float duration;

		private Animator animator;

		private float startTime;

		private float endTime;

		private float originalValue;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
