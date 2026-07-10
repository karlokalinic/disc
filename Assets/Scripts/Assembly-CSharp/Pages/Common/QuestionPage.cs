using DG.Tweening;
using PagesSystem;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Pages.Common
{
	public class QuestionPage : DiscoPage
	{
		private class QuestionNavigationParameter : NavigationParameters
		{
			public string Title;

			public string Message;

			public UnityAction OnYesClicked;

			public UnityAction OnNoClicked;

			public QuestionNavigationParameter(string title, string message, UnityAction onYesClicked, UnityAction onNoClicked)
			{
			}
		}

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI content;

		[SerializeField]
		private Button yesButton;

		[SerializeField]
		private Button noButton;

		public override bool CanStayOnStack => false;

		public override bool IsBackPossible => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		private void GoBack()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public static void Show(string message, UnityAction onYesClicked, UnityAction onNoClicked)
		{
		}

		public static void Show(string title, string message, UnityAction onYesClicked, UnityAction onNoClicked)
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
