using Sunshine.Feld;

namespace Sunshine.Views
{
	public class CharacterSheetView : View
	{
		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void InitTransforms()
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override bool CanExitView(ViewType nextView)
		{
			return false;
		}

		public override void OnFailedExitAttempt(ViewType nextView)
		{
		}

		public override void SetInitialSelect()
		{
		}
	}
}
