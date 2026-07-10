using Sunshine.Feld;

namespace Sunshine.Views
{
	public class InventoryPawnView : InventoryView
	{
		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override void InitTransforms()
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void SwitchToView(ViewType nextView)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}
	}
}
