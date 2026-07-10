using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandFade : SequencerCommand
	{
		private const float SmoothMoveCutoff = 0.05f;

		private const int FaderCanvasSortOrder = 32766;

		private string direction;

		private float duration;

		private Color color;

		private bool fadeIn;

		private bool stay;

		private bool unstay;

		private float startTime;

		private float endTime;

		private static Canvas faderCanvas;

		private static Image faderImage;

		public void Awake()
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
