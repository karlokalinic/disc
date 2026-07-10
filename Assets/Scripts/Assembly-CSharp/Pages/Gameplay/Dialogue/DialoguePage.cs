using DG.Tweening;
using DiscoPages.Elements.Dialogue;
using PagesSystem;
using PixelCrushers.DialogueSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Pages.Gameplay.Dialogue
{
	public class DialoguePage : SubPage
	{
		private const float ANIMATION_DURATION = 0.39f;

		private const float MAX_ANCHOR_MINIMIZED = 0.22f;

		private const float FULLSCREEN_IMAGE_MINIMIZED_ANCHORED_X = 280f;

		private const float FULLSCREEN_IMAGE_MAXIMIZE_MIN_ANCHOR_Y = 0.6f;

		private const float FULLSCREEN_IMAGE_MINIMIZE_MIN_ANCHOR_Y = 0.1f;

		public static UnityEvent OnMinimalizeDialogue;

		public static UnityEvent OnMaximalizeDialogue;

		[SerializeField]
		private Button[] minimizeButtons;

		[SerializeField]
		private RectTransform dialoguePanel;

		[SerializeField]
		private SunshineContinueButton psContinueButton;

		[SerializeField]
		private ScrollDown psScrollDown;

		[SerializeField]
		private Image psPortraitImg;

		[SerializeField]
		private AbstractDialogueUI psUnityUI;

		[SerializeField]
		private ScrollRect psScrollController;

		[SerializeField]
		private LogRenderer psLogRenderer;

		[SerializeField]
		private ContinueResponseTogglePageSystem psInteractionToggler;

		[SerializeField]
		private RectTransform fullscreenImageRect;

		private float minAnchorY;

		private float maxAnchorY;

		private float normalizedHeight;

		private Sequence minimizeDialogueSeq;

		private bool isMinimized;

		public override bool HideMainMenuButton => false;

		public override bool HideMoneyTimePortraits => false;

		public override bool HideQuickAccessBar => false;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		protected override void Awake()
		{
		}

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private void GoBack()
		{
		}

		private void TriggerMinimize()
		{
		}

		private void MinimizeDialoguePanel()
		{
		}

		private void MaximizeDialoguePanel()
		{
		}
	}
}
