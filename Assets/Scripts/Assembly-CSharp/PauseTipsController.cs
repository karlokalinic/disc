using System.Collections.Generic;
using I2.Loc;
using InControl;
using TMPro;
using UnityEngine;

public class PauseTipsController : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI tipText;

	[SerializeField]
	private Localize tipLocalize;

	private List<string> tipsTerms;

	private int tipsTermsCount;

	public PlayerAction previousTipAction;

	public PlayerAction nextTipAction;

	private int tipIndex;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void ChooseTip(int index)
	{
	}

	public void ChooseRandomTip()
	{
	}

	public void NextTip()
	{
	}

	public void PrevTip()
	{
	}
}
