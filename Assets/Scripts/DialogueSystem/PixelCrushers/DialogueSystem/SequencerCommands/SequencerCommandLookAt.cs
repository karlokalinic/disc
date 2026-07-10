using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandLookAt : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private Transform target;

		private Transform subject;

		private float duration;

		private float startTime;

		private float endTime;

		private Quaternion originalRotation;

		private Quaternion targetRotation;

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
