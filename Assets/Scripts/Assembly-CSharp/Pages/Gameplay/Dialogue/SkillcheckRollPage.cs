using DG.Tweening;
using PagesSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Dialogue
{
	public class SkillcheckRollPage : DiscoPage
	{
		public enum SkillcheckRollType
		{
			Whitecheck = 0,
			Redcheck = 1,
			Fakecheck = 2
		}

		public class SkillcheckRollNavigationParameters : NavigationParameters
		{
			public SkillcheckRollType rollType;

			public SunshineResponseButtonPageSystem responseButton;

			public TooltipData tooltipData;

			public SkillcheckRollNavigationParameters(SkillcheckRollType rollType, SunshineResponseButtonPageSystem responseButton, TooltipData tooltipData)
			{
			}
		}

		[SerializeField]
		private Button rollButton;

		[SerializeField]
		private Button goBackButton;

		[SerializeField]
		private CheckAdvisor advisor;

		private SkillcheckRollType rollType;

		private SunshineResponseButtonPageSystem responseButton;

		private TooltipData tooltipData;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		public override void Initialize()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		protected void PlaySound()
		{
		}

		private void GoBack()
		{
		}
	}
}
