using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class InteractionPromptAnimationController : MonoBehaviour
{
	private static InteractionPromptAnimationController singleton;

	private const float ANIM_DURATION = 0.3f;

	private Image image;

	private Color initColor;

	private Color failColor;

	private Sequence sequence;

	public static InteractionPromptAnimationController Singleton => null;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void PlayFailAnimation()
	{
	}
}
