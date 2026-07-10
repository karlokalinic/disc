using PagesSystem;
using Sunshine.Views;

namespace Pages
{
	public class DiscoPage : PageContent
	{
		public override bool IsProfileButtonVisibe => false;

		public override bool IsBackButtonVisible => false;

		public override bool IsTitleLabelVisible => false;

		public virtual ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		public override void RefreshOnStackChanged()
		{
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public override void OnNavigatedFrom()
		{
		}
	}
}
