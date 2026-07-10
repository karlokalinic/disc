using PagesSystem;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class MainMenuPage : DiscoPage
	{
		[SerializeField]
		private GameObject buttonGroups;

		[SerializeField]
		private Button continueGame;

		[SerializeField]
		private Button seeMoreSettings;

		private static bool wasToSShown;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}

		public override void OnNavigatedToAnimationComplete()
		{
		}

		private void OnContinueAndNewGameButtonPressed()
		{
		}

		private void ShowToSIfWasNotShown()
		{
		}

		public bool CheckIfToSShouldBeShown()
		{
			return false;
		}
	}
}
