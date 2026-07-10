using DG.Tweening;
using TMPro;
using UnityEngine;

public class TabSwitchAnimationController : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI leftTabText;

	[SerializeField]
	private TextMeshProUGUI rightTabText;

	[SerializeField]
	private RectTransform knobRect;

	[SerializeField]
	private Color activeColor;

	[SerializeField]
	private Color inactiveColor;

	private Sequence sequence;

	public void SetHandlePosition(bool toRight, bool noAnimation, bool initialize = false)
	{
	}
}
