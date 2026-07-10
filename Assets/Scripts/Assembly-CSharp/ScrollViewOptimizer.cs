using System.Collections.Generic;
using UnityEngine;

public class ScrollViewOptimizer : MonoBehaviour
{
	[SerializeField]
	private RectTransform viewport;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private SimpleHorizontalLayout simpleHorizontalLayout;

	private List<RectTransform> items;

	private bool isEnabled;

	private bool layoutRefreshPending;

	private void LateUpdate()
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void Add(RectTransform item)
	{
	}

	public void Remove(RectTransform item)
	{
	}

	private void ExamineItem(RectTransform item)
	{
	}
}
