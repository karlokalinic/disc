using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutDisabler : MonoBehaviour, ILayoutElement
{
	[SerializeField]
	private bool changeChildren;

	[SerializeField]
	private bool updateOnRectChange;

	private readonly List<HorizontalOrVerticalLayoutGroup> layouts;

	private readonly List<ContentSizeFitter> fitters;

	private WaitForEndOfFrame waitCache;

	private RectTransform rectTransform;

	private Vector2 size;

	public float minWidth { get; private set; }

	public float preferredWidth { get; private set; }

	public float flexibleWidth { get; }

	public float minHeight { get; private set; }

	public float preferredHeight { get; private set; }

	public float flexibleHeight { get; }

	public int layoutPriority { get; private set; }

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRectTransformDimensionsChange()
	{
	}

	public void StartResetLayouts()
	{
	}

	private IEnumerator ResetLayouts()
	{
		return null;
	}

	public void CalculateLayoutInputHorizontal()
	{
	}

	public void CalculateLayoutInputVertical()
	{
	}
}
