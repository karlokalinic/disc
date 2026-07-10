using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class TypewriterEffect : GUIEffect
	{
		public float charactersPerSecond;

		public AudioClip audioClip;

		private const string RichTextBoldOpen = "<b>";

		private const string RichTextBoldClose = "</b>";

		private const string RichTextItalicOpen = "<i>";

		private const string RichTextItalicClose = "</i>";

		private const string RichTextColorOpenPrefix = "<color=";

		private const string RichTextColorClose = "</color>";

		public bool IsPlaying { get; private set; }

		public override IEnumerator Play()
		{
			return null;
		}

		private void AdvanceOneCharacter(GUILabel control)
		{
		}

		public override void Stop()
		{
		}
	}
}
