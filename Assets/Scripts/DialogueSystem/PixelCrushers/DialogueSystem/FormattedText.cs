using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class FormattedText
	{
		public static readonly FormattedText empty;

		public static readonly Emphasis[] noEmphases;

		public const int NoAssignedPosition = -1;

		public const int NoPicOverride = 0;

		public string text { get; set; }

		public Emphasis[] emphases { get; set; }

		public bool italic { get; set; }

		public int position { get; set; }

		public bool forceMenu { get; set; }

		public bool forceAuto { get; set; }

		public bool noSubtitle { get; set; }

		public int pic { get; set; }

		public int picActor { get; set; }

		public int picConversant { get; set; }

		public string variableInputPrompt { get; set; }

		public bool hasVariableInputPrompt => false;

		public int subtitlePanelNumber { get; set; }

		public FormattedText(string text = null, Emphasis[] emphases = null, bool italic = false, int position = -1, bool forceMenu = true, bool forceAuto = false, int pic = 0, int picActor = 0, int picConversant = 0, string variableInputPrompt = null, int subtitlePanelNumber = -1, bool noSubtitle = false)
		{
		}

		public static FormattedText Parse(string rawText, EmphasisSetting[] emphasisSettings = null)
		{
			return null;
		}

		public static string ParseCode(string rawText)
		{
			return null;
		}

		private static void ReplacePipes(ref string text)
		{
		}

		private static void ReplaceLuaTags(ref string text)
		{
		}

		private static void ReplaceVarTags(ref string text)
		{
		}

		private static string ExtractVariableInputPrompt(ref string text)
		{
			return null;
		}

		private static bool ExtractTag(string tag, ref string text)
		{
			return false;
		}

		private static int ExtractPositionTag(ref string text)
		{
			return 0;
		}

		private static int ExtractPanelNumberTag(ref string text)
		{
			return 0;
		}

		private static int ExtractPicTag(string tagRegex, ref string text)
		{
			return 0;
		}

		private static Emphasis[] ExtractEmphasisTags(ref string text, EmphasisSetting[] emphasisSettings)
		{
			return null;
		}

		private static Emphasis[] ReplaceEmphasisTagsWithRichText(ref string text, EmphasisSetting[] emphasisSettings)
		{
			return null;
		}

		public static FontStyle GetFontStyle(Emphasis emphasis)
		{
			return default(FontStyle);
		}
	}
}
