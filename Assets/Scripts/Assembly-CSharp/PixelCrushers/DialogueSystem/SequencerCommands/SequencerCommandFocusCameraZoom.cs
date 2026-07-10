using System.Collections;
using Sunshine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandFocusCameraZoom : SequencerCommand, ICameraBackPosition
	{
		private float cameraZoom;

		private float newZoomAmount;

		private Transform conversant;

		private float tweenDuration;

		private bool dontBlockSequence;

		private bool isHeadAdjustmentOff;

		private bool isCharacter;

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

		public void RunBack(bool instant = false)
		{
		}

		public bool HaveConversant()
		{
			return false;
		}
	}
}
