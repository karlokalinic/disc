using System.Collections.Generic;
using UnityEngine;

namespace Accessibility
{
	public class AudioCaptionsManager : LiteSingleton<AudioCaptionsManager>
	{
		private const int MAX_CAPTIONS_AMOUNT = 10;

		[SerializeField]
		private AudioCaptionsElement audioCaptionsPrefab;

		[SerializeField]
		private RectTransform captionsParent;

		private static bool useCaptions;

		private List<AudioCaptionsElement> audioCaptionsElements;

		public static int CaptionsInUse { get; set; }

		public static int CaptionIndex { get; set; }

		public static bool UseCaptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void OnSoundPlayed(string group, string variation)
		{
		}

		private void ShowCaptions(string audioName)
		{
		}
	}
}
