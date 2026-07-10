using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public static class UITools
	{
		public static Dictionary<Texture2D, Sprite> spriteCache;

		private static AbstractDialogueUI dialogueUI;

		public const string RPGMakerCodeQuarterPause = "\\,";

		public const string RPGMakerCodeFullPause = "\\.";

		public const string RPGMakerCodeSkipToEnd = "\\^";

		public const string RPGMakerCodeInstantOpen = "\\>";

		public const string RPGMakerCodeInstantClose = "\\<";

		public static void RequireEventSystem()
		{
		}

		public static int GetAnimatorNameHash(AnimatorStateInfo animatorStateInfo)
		{
			return 0;
		}

		public static void ClearSpriteCache()
		{
		}

		public static Sprite CreateSprite(Texture2D texture)
		{
			return null;
		}

		public static Sprite GetSprite(Texture2D texture, Sprite sprite)
		{
			return null;
		}

		public static Texture2D GetTexture2D(Sprite sprite)
		{
			return null;
		}

		public static string GetUIFormattedText(FormattedText formattedText)
		{
			return null;
		}

		public static void SendTextChangeMessage(Text text)
		{
		}

		public static void SendTextChangeMessage(UITextField textField)
		{
		}

		public static void Select(Selectable selectable, bool allowStealFocus = true)
		{
		}

		public static string StripRPGMakerCodes(string s)
		{
			return null;
		}

		public static string WrapTextInColor(string text, Color color)
		{
			return null;
		}

		public static void EnableInteractivity(GameObject go)
		{
		}
	}
}
