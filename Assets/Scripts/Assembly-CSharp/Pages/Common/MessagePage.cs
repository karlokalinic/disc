using DG.Tweening;
using PagesSystem;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Common
{
	public class MessagePage : DiscoPage
	{
		private class MessageNavigationParameter : NavigationParameters
		{
			public string Title;

			public string Message;

			public MessageNavigationParameter(string title, string message)
			{
			}
		}

		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private TextMeshProUGUI content;

		[SerializeField]
		private Button okButton;

		public override bool CanStayOnStack => false;

		public override bool IsBackPossible => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		private void OnOkPressed()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public static void Show(string message)
		{
		}

		public static void Show(string title, string message)
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
