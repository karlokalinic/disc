using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Voidforge;

public class ShowDay : VoidElement
{
	private readonly HashSet<string> languageCodesWithDayInFront;

	[SerializeField]
	private RectTransform horizontalLayoutParent;

	protected ComponentRef<TextMeshProUGUI> text;

	private int lastDay;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void UpdateTime()
	{
	}

	private void SetCorrectOrder()
	{
	}

	private void ResetLayout()
	{
	}

	private string GetDayCounterText(int day)
	{
		return null;
	}
}
