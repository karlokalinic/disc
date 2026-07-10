using UnityEngine;
using UnityEngine.UI;

public class LayoutElementLimiter : MonoBehaviour, ILayoutElement
{
	[SerializeField]
	private RectTransform child;

	[SerializeField]
	private float maxHeight;

	[SerializeField]
	private float maxWidth;

	[SerializeField]
	private int priority;

	private float _preferredHeight;

	public int layoutPriority => 0;

	public float preferredWidth => 0f;

	public float preferredHeight => 0f;

	public float minWidth { get; }

	public float minHeight { get; }

	public float flexibleWidth { get; }

	public float flexibleHeight { get; }

	public void CalculateLayoutInputHorizontal()
	{
	}

	public void CalculateLayoutInputVertical()
	{
	}
}
