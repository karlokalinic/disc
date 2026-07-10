using System.Collections.Generic;
using LocalizationCustomSystem;
using UnityEngine;

public class ToggleLocalization : MonoBehaviour
{
	[SerializeField]
	private bool snapToggle;

	private SmoothLanguageSwitch baseSwitch;

	private List<string> languagesNames;

	private int firstKeyCode;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ToggleLanguage(int languageId)
	{
	}
}
