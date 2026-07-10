using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAnimatorLayer : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private int layerIndex;

		private float weight;

		private Transform subject;

		private float duration;

		private Animator animator;

		private float startTime;

		private float endTime;

		private float originalWeight;

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
