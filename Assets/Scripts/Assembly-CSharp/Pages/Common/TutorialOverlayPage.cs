using Sunshine.Views;

namespace Pages.Common
{
	public class TutorialOverlayPage : DiscoPage
	{
		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);
	}
}
