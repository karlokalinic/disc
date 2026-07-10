using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenImage : MonoBehaviour
{
	[SerializeField]
	private float fadeInDuration;

	[SerializeField]
	private Vector2 startSize;

	[SerializeField]
	private float startAlpha;

	[Space]
	[SerializeField]
	private GameObject parent;

	[SerializeField]
	private Localize subtitles;

	private RectTransform rectTransform;

	private Image image;

	private Vector2 targetPosition;

	private Vector2 targetSize;

	private Vector2 startPosition;

	private float time;

	public bool IsShown => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ShowImageFullscreen(Sprite sprite, Vector3 worldPos, string term)
	{
	}

	public void Hide()
	{
	}
}
