using System;
using Sunshine;
using UnityEngine;

public class LogEntry : MonoBehaviour
{
	private const string NonBreakingSpace = "\ufffd";

	protected string overrideText;

	protected Func<string> annotationTextGetter;

	public bool isNew;

	public bool continuing;

	public bool isAnnotation;

	public ParagraphText logText;

	[SerializeField]
	protected FinalEntry entry;

	private CanvasGroup grp;

	public bool UseRichText;

	public FinalEntry Entry
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string OverrideText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Func<string> AnnotationTextGetter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string GetCheckText(FinalEntry finalEntry)
	{
		return null;
	}

	public string GetSpeakerColor(FinalEntry finalEntry)
	{
		return null;
	}

	public string GetTextColor(FinalEntry finalEntry)
	{
		return null;
	}

	public void HandleLog(string text)
	{
	}

	public void HandleLog(FinalEntry finalEntry)
	{
	}

	private void MaybePlayAppear()
	{
	}

	public void SetAsNew()
	{
	}

	public void UnsetNew()
	{
	}

	public string FormatCheckEntry(FinalEntry finalEntry)
	{
		return null;
	}

	public string FormatCheckResultEntry(FinalEntry finalEntry)
	{
		return null;
	}

	public string FormatLogEntry(FinalEntry finalEntry)
	{
		return null;
	}

	private string LogFormat(string format, string boringFormat, params object[] args)
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnEnable()
	{
	}

	private void OnEntryLocalized()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
