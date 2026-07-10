using UnityEngine;

public class TitleCardFadeOut : MonoBehaviour
{
	public SpriteRenderer title;

	public SpriteRenderer bg;

	public AnimationCurve titleFadeout;

	public AnimationCurve bgFadeout;

	public float fadeoutLength;

	private float timeStart;

	private Color titleCol;

	private Color bgCol;

	private static bool hasPlayed;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
