using Sunshine.Feld;

namespace Sunshine.Views
{
	public class ClearView : View
	{
		private bool isIKDisabled;

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

		private void ToggleIKOnTequila(bool isEnabled)
		{
		}

		public override void SetInitialSelect()
		{
		}
	}
}
