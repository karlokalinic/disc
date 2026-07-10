using DG.Tweening;
using PagesSystem;
using Sunshine.Views;

namespace Pages.Common
{
	public class OptionsPage : DiscoPage
	{
		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

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
