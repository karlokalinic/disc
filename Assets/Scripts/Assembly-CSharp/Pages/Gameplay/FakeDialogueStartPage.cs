using DG.Tweening;
using PagesSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Pages.Gameplay
{
	public class FakeDialogueStartPage : DiscoPage
	{
		public class FakeDialogueStartNavigationParameters : NavigationParameters
		{
			public ContinueButtonType buttonType;

			public FakeDialogueStartNavigationParameters(ContinueButtonType buttonType)
			{
			}
		}

		public enum ContinueButtonType
		{
			Real = 0,
			Ledger = 1,
			Fake = 2
		}

		[SerializeField]
		private Button continueButton;

		[SerializeField]
		private Image dialogueImage;

		private ContinueButtonType buttonType;

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void DisplayFuriesQuote()
		{
		}
	}
}
