using System.Collections;
using Sunshine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandMoveCamera : SequencerCommand, ICameraBackPosition
	{
		private Transform conversant;

		private float xOffset;

		private float yOffset;

		private float zOffset;

		private float zoomAmount;

		private float tweenDuration;

		private Vector2 viewportFocus;

		private Vector3 position;

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

		public void RunBack(bool instant = false)
		{
		}

		public bool HaveConversant()
		{
			return false;
		}
	}
}
