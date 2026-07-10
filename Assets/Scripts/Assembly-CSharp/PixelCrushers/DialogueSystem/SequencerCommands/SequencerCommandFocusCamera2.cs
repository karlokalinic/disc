using System.Collections;
using Sunshine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandFocusCamera2 : SequencerCommand
	{
		private Transform conversant1;

		private Transform conversant2;

		private float zoomAmount;

		private float tweenDuration;

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
