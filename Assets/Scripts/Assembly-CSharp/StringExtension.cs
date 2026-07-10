using UnityEngine;

public static class StringExtension
{
	private static char[] INVALID_NAME_CHARS;

	private static char[] INVALID_LETTER_CHARS;

	public static bool HaveInvalidCharacters(this string filename)
	{
		return false;
	}

	public static string RemoveInvalidCharactersFromFilePath(this string path)
	{
		return null;
	}

	public static string RemoveInvalidCharactersFromFileName(this string fileName)
	{
		return null;
	}

	private static string ReplaceInvalidLetters(string fileName)
	{
		return null;
	}

	public static string AddColor(this string text, Color color, bool revertTagsForRTL = false)
	{
		return null;
	}

	public static string AddColorDim(this string text)
	{
		return null;
	}

	public static string AddColorText(this string text)
	{
		return null;
	}
}
