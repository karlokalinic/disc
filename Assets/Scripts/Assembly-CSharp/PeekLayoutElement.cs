using UnityEngine;
using UnityEngine.UI;

public class PeekLayoutElement : MonoBehaviour, ILayoutElement
{
	private RectTransform _targetElement;

	private float currentHeight;

	public RectTransform TargetElement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float flexibleWidth => 0f;

	public float flexibleHeight => 0f;

	public int layoutPriority => 0;

	public float minWidth => 0f;

	public float preferredWidth => 0f;

	public float minHeight => 0f;

	public float preferredHeight => 0f;

	public void CalculateLayoutInputHorizontal()
	{
	}

	public void CalculateLayoutInputVertical()
	{
	}

	private void ReplaceWithTarget()
	{
	}

	private void CacheHeight()
	{
	}
}
