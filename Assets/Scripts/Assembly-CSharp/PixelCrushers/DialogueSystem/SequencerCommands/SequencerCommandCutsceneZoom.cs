using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandCutsceneZoom : SequencerCommand
	{
		private Transform conversant;

		private float zoomPercentage;

		private float tweenDuration;

		private float timeTweened;

		private float startZoomAmount;

		private bool engage;

		protected Vector2 focus;

		public void Start()
		{
		}

		private IEnumerator StupidUnityDoesntSupportAnonymousCoroutines()
		{
			return null;
		}
	}
}
