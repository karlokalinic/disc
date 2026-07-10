using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandLiveCamera : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private Transform subject;

		private Transform angleTransform;

		private Transform cameraTransform;

		private bool isLocalTransform;

		private Quaternion targetRotation;

		private Vector3 targetPosition;

		private float duration;

		private float startTime;

		private float endTime;

		private Quaternion originalRotation;

		private Vector3 originalPosition;

		private bool isOriginal;

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
