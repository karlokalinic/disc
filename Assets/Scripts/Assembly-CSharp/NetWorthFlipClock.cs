using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NetWorthFlipClock : MonoBehaviour
{
	private const float ANIMATION_DURATION = 0.5f;

	[SerializeField]
	private RectMask2D topMask;

	[SerializeField]
	private TextMeshProUGUI topText;

	[SerializeField]
	private TextMeshProUGUI topFallingText;

	[SerializeField]
	private TextMeshProUGUI bottomText;

	[SerializeField]
	private TextMeshProUGUI bottomFallingText;

	private Sequence setValueSequence;

	private Vector2 TopMaskScale
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public void SetValue(int value)
	{
	}

	private Vector3 ChangeYScale(Vector3 vec, float y)
	{
		return default(Vector3);
	}
}
