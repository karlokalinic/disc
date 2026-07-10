using System.Collections;
using DG.Tweening;
using DiscoPages.Elements.MainMenu;
using DiscoPages.Elements.OnSwipeDetected;
using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class SelectArchetypePage : DiscoPage
	{
		[SerializeField]
		private ArchetypeSelectMenuButton buttonTemplate;

		[SerializeField]
		private ArchetypeSelectMenuButton customCharacter;

		[SerializeField]
		private Transform buttonsParent;

		[SerializeField]
		private ScrollRect selectionScrollView;

		[SerializeField]
		private Button showNextTemplate;

		[SerializeField]
		private Button showPreviousTemplate;

		[SerializeField]
		private ArchetypeSelectionIndicator selectionIndicator;

		[SerializeField]
		private Image flash;

		[SerializeField]
		private Sprite[] portraits;

		[SerializeField]
		private SunshineCharacterTemplate[] archetypes;

		[SerializeField]
		private EventOnSwipeDetected swipeDetector;

		private RectTransform[] archetypesRectTransforms;

		private static SelectArchetypePage singleton;

		private int currentTemplateId;

		public readonly UnityEvent onSelectedArchetypeChanged;

		public static SelectArchetypePage Singleton => null;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public int CurrentTemplateId => 0;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void Initialize()
		{
		}

		private IEnumerator GotToFirstTemplateCor()
		{
			return null;
		}

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		private void GoToNextSelection()
		{
		}

		private void GoToPreviousSelection()
		{
		}

		private void GoToTemplateId(int newTemplateId, bool makeFlash = true)
		{
		}

		private void Flash()
		{
		}
	}
}
