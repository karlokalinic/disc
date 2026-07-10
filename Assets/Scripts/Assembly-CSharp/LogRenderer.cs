using System;
using System.Collections;
using System.Collections.Generic;
using LocalizationCustomSystem;
using UnityEngine;
using Voidforge;

public class LogRenderer : SingletonComponent<LogRenderer>
{
	public RectTransform logPanel;

	public LogEntry logTemplate;

	public float fadedAlpha;

	public MaterialTranslationString newTextMaterialTranslation;

	public MaterialTranslationString faderTextMaterialTranslation;

	public FontTranslationString fontTranslation;

	public int cullToHere;

	public int cullThreshold;

	private static List<FinalEntry> queue;

	private static List<LogEntry> logsList;

	private static List<LogEntry> newList;

	[NonSerialized]
	public bool isHeld;

	private bool isLogRelative;

	private RectTransform savedRelativeMarker;

	private RectTransform savedLogRect;

	private bool _isInMidCheck;

	private bool _waitingOnSequence;

	public LogEntry lastEntry;

	private string lastName;

	private IEnumerator textLocalizeCoR;

	private IEnumerator textSizeChangedCoR;

	public static bool IsInMidCheck
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool WaitingOnSequence
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsDelaying => false;

	public static bool HasQueue => false;

	public static bool IsBusy => false;

	public string LastName => null;

	protected override void Awake()
	{
	}

	public void Start()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	protected void OnFontSizeChangePrepared(TextSizeConfiguration.TextSize textSize)
	{
	}

	protected void OnFontSizeChanged(TextSizeConfiguration.TextSize textSize)
	{
	}

	protected void OnLanguageChanged()
	{
	}

	protected void OnLanguageChangedDelayed()
	{
	}

	protected IEnumerator DelayedRestorePosition()
	{
		return null;
	}

	public void SavePosition()
	{
	}

	public RectTransform GetCenterVisibleLogRect()
	{
		return null;
	}

	public RectTransform GetTopVisibleLogRect()
	{
		return null;
	}

	public RectTransform GetBottomVisibleLogRect()
	{
		return null;
	}

	public void RestorePosition()
	{
	}

	public void AddToLog(FinalEntry entry)
	{
	}

	public void Hold()
	{
	}

	public void Release(bool releaseQueue = true)
	{
	}

	public void HoldText()
	{
	}

	public void ReleaseText(bool forceShowPortrait)
	{
	}

	public void HidePortrait()
	{
	}

	private void FinishCheck()
	{
	}

	private IEnumerator FinishCheckCoroutine()
	{
		return null;
	}

	private void MaybeReleaseQueue()
	{
	}

	private bool EntriesHaveTheSameSpeaker(FinalEntry first, FinalEntry second)
	{
		return false;
	}

	private void DelayedAdd(FinalEntry entry)
	{
	}

	private IEnumerator DelayedScrollDown()
	{
		return null;
	}

	public void PlaySkillEffects(FinalEntry finalEntry)
	{
	}

	public void AddAnnotation(Func<string> annotationGetter)
	{
	}

	public void AddAnnotation(string text)
	{
	}

	public void AddAnnotationOngoing(Func<string> annotationGetter)
	{
	}

	public void AddAnnotationOngoing(string text)
	{
	}

	public LogEntry AddToLog(string text)
	{
		return null;
	}

	public void ClearLog()
	{
	}

	public void CullLog()
	{
	}

	public void CullCallback()
	{
	}

	protected void RefreshFadedAlpha()
	{
	}

	protected void MarkAsNew(LogEntry newEntry)
	{
	}

	public static void ClearNew()
	{
	}
}
