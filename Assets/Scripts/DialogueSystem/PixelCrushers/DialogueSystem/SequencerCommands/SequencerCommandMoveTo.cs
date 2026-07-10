using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandMoveTo : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private Transform target;

		private Transform subject;

		private Rigidbody subjectRigidbody;

		private float duration;

		private float startTime;

		private float endTime;

		private Vector3 originalPosition;

		private Quaternion originalRotation;

		public void Start()
		{
		}

		private void SetPosition(Vector3 newPosition, Quaternion newRotation)
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
