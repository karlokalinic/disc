using UnityEngine;

public class XPPanelHighlighter : MonoBehaviour
{
	[SerializeField]
	private ColorHighlighter textHighlighter;

	[SerializeField]
	private Color textHighlightColor;

	[SerializeField]
	private ColorHighlighter barHighlighter;

	[SerializeField]
	private Color barHighlightColor;

	[SerializeField]
	private ColorHighlighter barBackgroundHighlighter;

	[SerializeField]
	private Color barBackgroundHighlightColor;

	[SerializeField]
	private float highlightTime;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelUp(int level)
	{
	}
}
