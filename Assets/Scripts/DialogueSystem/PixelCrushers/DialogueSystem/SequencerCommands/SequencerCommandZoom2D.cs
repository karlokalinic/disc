using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandZoom2D : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private bool original;

		private Transform subject;

		private Vector3 targetPosition;

		private Vector3 originalPosition;

		private float targetSize;

		private float originalSize;

		private float duration;

		private float startTime;

		private float endTime;

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
