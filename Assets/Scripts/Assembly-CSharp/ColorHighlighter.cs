using UnityEngine;
using UnityEngine.UI;

public class ColorHighlighter : MonoBehaviour
{
	[SerializeField]
	private Graphic graphic;

	[SerializeField]
	private AnimationCurve animationCurve;

	private bool isTweenning;

	private float currentTime;

	public Color HighlightColor { get; private set; }

	public Color TargetColor { get; private set; }

	public float Duration { get; private set; }

	private void Update()
	{
	}

	public void Highlight(Color highlightColor, float time)
	{
	}
}
