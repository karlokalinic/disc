using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.HUD
{
	public class PageSystemHUDPortraitsAnimator : MonoBehaviour
	{
		[SerializeField]
		private Button showPortraitsButton;

		[SerializeField]
		private RectTransform companionPortrait;

		[SerializeField]
		private RectTransform parentRectTransform;

		[SerializeField]
		private RectTransform healingPanelRectTransform;

		[SerializeField]
		private RectTransform arrowRect;

		[SerializeField]
		private Image arrowImage;

		[SerializeField]
		private Color arrowOpenedColor;

		[SerializeField]
		private Color arrowClosedColor;

		private bool isOpened;

		private Sequence currSequence;

		private Vector2 initialCompanionPos;

		public Button ShowPortraitsButton => null;

		public bool IsOpened => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnButtonClicked()
		{
		}

		public void Hide()
		{
		}

		public void Show()
		{
		}

		private Sequence HideSequence()
		{
			return null;
		}

		private Sequence ShowSequence()
		{
			return null;
		}
	}
}
