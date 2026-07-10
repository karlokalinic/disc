using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SegmentIndicator : MonoBehaviour
{
	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private AnimatedSegment segmentTemplate;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private bool invertFillDirection;

	[SerializeField]
	private bool invertOnRightToLeftText;

	[SerializeField]
	private GameObject maxSegmentTemplate;

	[SerializeField]
	private int maxVisibleSegments;

	[SerializeField]
	private int numberOfSegmentsPerLine;

	[SerializeField]
	private GameObject segmentGroupTemplate;

	[SerializeField]
	private Vector2 segmentGroupOffset;

	private int max;

	private int current;

	private Color color;

	private GameObject maxReachedIndicator;

	private List<RectTransform> segmentsGroup;

	private List<HorizontalOrVerticalLayoutGroup> segmentsLayoutGroups;

	public List<AnimatedSegment> Segments;

	private Coroutine rebuildLayoutCor;

	public int Max
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Current
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Color Color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private bool InvertToRightToLeft => false;

	public void SetPosX(float x)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public void Refresh()
	{
	}

	private void UpdateLayoutGroups()
	{
	}

	private IEnumerator RebuildLayoutAfterFrame()
	{
		return null;
	}

	public void ShowIncreasePrediction(int amount)
	{
	}

	public void ShowDecreasePrediction(int amount)
	{
	}

	public void HidePrediction()
	{
	}

	private void InstantiateMissingSegments()
	{
	}

	private void RefreshMaxPlusIndicator()
	{
	}

	private void DisableRedundantSegments()
	{
	}

	private void UpdateSegmentsDisplay()
	{
	}

	private void UpdateText()
	{
	}
}
