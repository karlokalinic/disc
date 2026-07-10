using UnityEngine;
using UnityEngine.UI;

public class CalculatedLayoutSize : MonoBehaviour
{
	[SerializeField]
	private RectTransform topMarker;

	[SerializeField]
	private RectTransform bottomMarker;

	private LayoutElement layout;

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	private void RecalculateLayoutSize()
	{
	}
}
