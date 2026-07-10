using DG.Tweening;
using TMPro;
using UnityEngine;

public class AudioCaptionsElement : MonoBehaviour
{
	private static float TRANSITION_DURATION;

	private static float CAPTIONS_DURATION;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private Sequence sequence;

	public void Initialize()
	{
	}

	public void ShowCaption(string captionText)
	{
	}
}
