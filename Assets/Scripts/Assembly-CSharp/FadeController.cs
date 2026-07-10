using UnityEngine;

public class FadeController : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve fadeInCurve;

	[SerializeField]
	private AnimationCurve fadeOutCurve;

	private SpriteRenderer spriteRenderer;

	private bool active;

	private AnimationCurve currentCurve;

	private float animationTimer;

	public float zoomTargetAlpha { get; set; }

	public float distanceTargetAlpha { get; set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetActive(bool newState, bool force = false)
	{
	}
}
