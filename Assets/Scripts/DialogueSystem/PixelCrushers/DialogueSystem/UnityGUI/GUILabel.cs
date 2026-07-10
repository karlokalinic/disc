using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUILabel : GUIVisibleControl
	{
		public TextStyle textStyle;

		public Color textStyleColor;

		public Color imageColor;

		public Texture2D image;

		public ImageAnimation imageAnimation;

		private List<string> closureTags;

		private bool useSubstring;

		private int substringLength;

		private int substringLengthLastGetRichTextClosedString;

		private string richTextClosedString;

		public int currentLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public void ResetClosureTags()
		{
		}

		public void PushClosureTag(string tag)
		{
		}

		public void PopClosureTag()
		{
		}

		public override void SetFormattedText(FormattedText formattedText)
		{
		}

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}

		private void DrawSubstring()
		{
		}

		private bool IsLeftAligned(TextAnchor textAnchor)
		{
			return false;
		}

		private bool IsCenterAligned(TextAnchor textAnchor)
		{
			return false;
		}

		private TextAnchor GetLeftAlignedVersion(TextAnchor textAnchor)
		{
			return default(TextAnchor);
		}

		private void DrawSubstringLeftAligned()
		{
		}

		private void DrawSubstringNotLeftAligned()
		{
		}

		private string GetNextLine(string text, int start)
		{
			return null;
		}

		private string GetRichTextClosedText(string s)
		{
			return null;
		}

		private void DrawImage()
		{
		}

		public override void Refresh()
		{
		}
	}
}
