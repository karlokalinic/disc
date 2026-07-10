using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TextSizeConfiguration : LiteSingleton<TextSizeConfiguration>
{
	public enum TextSize
	{
		normal = 0,
		large = 1,
		humungous = 2,
		tremendous = 3
	}

	public const string dialogueFontSizeConfName = "dialogueFontSize";

	public RectTransform targetUI;

	public RectTransform hiddenUI;

	public Slider slider;

	private static int curSize;

	private static TextSize currTextSize;

	private float valueBeforePreview;

	public static readonly int[] fontSizes;

	private const int DefaultTextSize = 2;

	public static int CurSize => 0;

	public static TextSize CurrTextSize => default(TextSize);

	public static event Action<TextSize> OnFontSizeChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<TextSize> OnFontSizeChangePrepared
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Start()
	{
	}

	public void ReApply()
	{
	}

	public void ResetSettings()
	{
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	public void WasChanged()
	{
	}

	public void SizeSwitch(int sizeValue)
	{
	}

	private void ResetScrollDownToUpdateConversationLog()
	{
	}

	public void SetSize(Transform target, int size)
	{
	}

	public void TestSetNormal()
	{
	}

	public void TestSetLarge()
	{
	}

	public void TestSetHumungous()
	{
	}

	public void TestSetTremendous()
	{
	}
}
