using Sunshine.Feld;

namespace Sunshine.Views
{
	public class CutsceneView : View
	{
		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override void SetInitialSelect()
		{
		}
	}
}
