using DG.Tweening;
using Pages.Common;
using PagesSystem;

namespace Pages.Gameplay
{
	public class GamePauseMenuPage : BaseMenuPage
	{
		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override void Initialize()
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
