using UnityEngine;
using UnityEngine.UI;

public class AnimatedSegment : MonoBehaviour
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private Animator animator;

	private static readonly int EnabledState;

	private static readonly int DisabledState;

	public Image Image => null;

	public void SetPredictEnable(bool isPredicting)
	{
	}

	public void SetPredictDisable(bool isPredicting)
	{
	}

	public void SetEnabled(bool isEnabled)
	{
	}

	public void SetColor(Color color)
	{
	}

	private bool CanUseAnimator()
	{
		return false;
	}
}
