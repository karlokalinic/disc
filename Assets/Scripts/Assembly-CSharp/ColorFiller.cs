using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorFiller : MonoBehaviour
{
	[SerializeField]
	private Color unfilledColor;

	[SerializeField]
	private Color filledColor;

	[SerializeField]
	private AnimationCurve fillingCurve;

	[SerializeField]
	private float timePerFill;

	[SerializeField]
	private List<TextMeshProUGUI> textsToFill;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void FadeOutText()
	{
	}

	private void SetTextsColor(Color color)
	{
	}

	private IEnumerator FillingCoroutine()
	{
		return null;
	}

	private IEnumerator FadeOutCoroutine()
	{
		return null;
	}
}
