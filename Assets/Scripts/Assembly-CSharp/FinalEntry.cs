using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;

[Serializable]
public class FinalEntry
{
	public DialogueEntry entry;

	public string speakerName;

	public string spokenLine;

	public List<string> comments;

	private string checkTextOverride;

	public CheckResult checkResult;

	public string checkText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HasCheck => false;

	public bool OnlyCheck => false;

	public bool HasComment => false;

	public FinalEntry(DialogueEntry entry)
	{
	}

	public FinalEntry(DialogueEntry entry, string spokenLine)
	{
	}

	public FinalEntry(DialogueEntry entry, string spokenLine, string speakerName)
	{
	}

	private string GetSpeakerName()
	{
		return null;
	}

	public string GetCommentString()
	{
		return null;
	}

	public static string GetCommentString(FinalEntry entry)
	{
		return null;
	}

	public static string GetSpeakerName(DialogueEntry entry)
	{
		return null;
	}

	public static string GetSpeakerName(Subtitle subtitle)
	{
		return null;
	}

	public Color GetSpeakerColor()
	{
		return default(Color);
	}
}
