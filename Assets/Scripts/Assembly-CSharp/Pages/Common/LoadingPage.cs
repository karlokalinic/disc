using System;
using System.Collections;
using DG.Tweening;
using PagesSystem;
using Sunshine.Views;

namespace Pages.Common
{
	public class LoadingPage : DiscoPage
	{
		private class LoadingNavigationParameter : NavigationParameters
		{
			public Action OnLoadFinished;

			public LoadingNavigationParameter(Action onAction)
			{
			}
		}

		private Action OnLoadingFinished;

		public override bool CanStayOnStack => false;

		public override bool IsBackPossible => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		private IEnumerator DEBUG_WaitAndCallEvent()
		{
			return null;
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public static void Show(bool absolute = false)
		{
		}

		public static void Show(Action onLoadFinished, bool absolute)
		{
		}

		public static void Hide()
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
