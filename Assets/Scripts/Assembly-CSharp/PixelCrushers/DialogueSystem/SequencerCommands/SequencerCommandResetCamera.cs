using System.Collections;
using Sunshine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandResetCamera : SequencerCommand
	{
		private Transform conversant;

		private float zoomAmount;

		private float tweenDuration;

		private Vector3 targetPosition;

		protected Vector2 focus;

		public void Start()
		{
		}

		public void CameraZoomOut()
		{
		}

		private IEnumerator StupidUnityDoesntSupportAnonymousCoroutines(TweenCamera tween)
		{
			return null;
		}
	}
}
