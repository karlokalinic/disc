using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public static class TextUtils
{
	public const char NonBreakingSpaceChar = '\u00a0';

	public const string NonBreakingSpaceString = "\ufffd";

	private static string STRIKETHROUGH_SEPARATOR;

	private const char StrikeSeparatorChinese = '─';

	private const string StrikeSeperatorEnglish = "\ufffd";

	public static string Colon => null;

	public static char Separator => '\0';

	public static char TimeSeparation => '\0';

	public static char NewLineChar => '\0';

	public static char OpeningBracket => '\0';

	public static char ClosingBracket => '\0';

	public static string NewLineString => null;

	public static string BracketsFormat => null;

	public static IFormatProvider CultureFormatProvider => null;

	public static string StrikethroughText(string value)
	{
		return null;
	}

	private static string GenerateStrikethroughForText(string textToStrikethrough, Text textField, RectTransform rectTransform)
	{
		return null;
	}

	public static void StrikethroughText(ref string originalText, TextMeshProUGUI strikethroughTextField, RectTransform textRectTransform)
	{
	}

	private static string GenerateStrikethroughForText(string textToStrikethrough, TextMeshProUGUI textField, RectTransform rectTransform)
	{
		return null;
	}

	public static RichTextParser GetTextParser(string originalText)
	{
		return null;
	}

	public static string ForceLineBreaks(string originalText, Text textField, RectTransform rectTransform)
	{
		return null;
	}

	public static string ForceLineBreaksDefault(string originalText, Text textField, RectTransform rectTransform)
	{
		return null;
	}

	public static string ForceLineBreaksRichText(string originalText, Text textField, RectTransform rectTransform)
	{
		return null;
	}

	private static void MatchTexts(string finalText, List<string> originalTextsList)
	{
	}

	private static string ApplyTags(List<string> textsList, List<RichTextParser.Tag> tagsList, List<string> textInBetweenTags, List<int> indicesTextsInBetweenTags)
	{
		return null;
	}

	private static string ForceBreakLineAtIndex(string text, int startIndex, ref int charactersShift)
	{
		return null;
	}

	public static bool IsSpecialCharacter(char ch)
	{
		return false;
	}

	public static bool IsSimplifiedChineseSpecialCharacter(char ch)
	{
		return false;
	}

	public static bool IsKoreanSpecialCharacter(char ch)
	{
		return false;
	}

	public static bool IsNormalCharacter(char ch)
	{
		return false;
	}
}
