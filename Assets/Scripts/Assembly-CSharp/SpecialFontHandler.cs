using System;
using I2.Loc;
using LocalizationCustomSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpecialFontHandler : MonoBehaviour
{
	[SerializeField]
	private Localize localizeFont;

	[SerializeField]
	private Text text;

	[SerializeField]
	private TMP_Text tmpText;

	[SerializeField]
	private FontTranslationString fontTranslation;

	[SerializeField]
	private Localize localizeMaterial;

	[SerializeField]
	private MaterialTranslationString materialTranslation;

	public Action OnFontUpdated;

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateTextFont()
	{
	}

	private void GetOriginalFontTerm()
	{
	}
}
