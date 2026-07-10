using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using Voidforge;

public class SituationalCursorSource : ICursorSource
{
	private static Dictionary<CursorType, SituationalCursorSource> dictionary;

	private CursorType cursorType;

	public Texture2D texture => null;

	public Vector2 hotspot => default(Vector2);

	private SituationalCursorSource(CursorType cursorType)
	{
	}

	public static SituationalCursorSource GetCursorSource(CursorType cursorType)
	{
		return null;
	}
}
