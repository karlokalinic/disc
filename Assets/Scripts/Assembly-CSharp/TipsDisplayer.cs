using System.Collections;
using System.Collections.Generic;
using I2.Loc;
using TMPro;
using UnityEngine;

public class TipsDisplayer : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI tipText;

	[SerializeField]
	private Localize tipLocalize;

	private List<string> tipsTerms;

	private bool useBlackScreen;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void ToggleTipsInTheNextLoad(bool usingBlack)
	{
	}

	private void ToggleTipsImmediate(bool usingBlack)
	{
	}

	private void LoadTipsTerms()
	{
	}

	private void OnEnable()
	{
	}

	private void ChooseRandomTip()
	{
	}
}
