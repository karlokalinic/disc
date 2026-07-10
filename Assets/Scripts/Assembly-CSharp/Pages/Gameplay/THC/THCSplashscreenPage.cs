using DG.Tweening;
using PagesSystem;
using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Pages.Gameplay.THC
{
	public class THCSplashscreenPage : DiscoPage
	{
		private static string thoughtsIconsPath;

		[SerializeField]
		private TextMeshProUGUI thoughtTitleText;

		[SerializeField]
		private TextMeshProUGUI conclusionText;

		[SerializeField]
		private TextMeshProUGUI propertiesText;

		[SerializeField]
		private Image thoughtImage;

		[SerializeField]
		private Button closeButton;

		private ThoughtCabinetProject currentProject;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public static void Show()
		{
		}

		public static bool CanTransferFromCurrentPage()
		{
			return false;
		}

		protected override void Awake()
		{
		}

		private void SetOnExitButton(UnityAction action)
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		private void DisplayThought()
		{
		}

		private void SetThoughtProject(ThoughtCabinetProject project)
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
	}
}
