using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class CollageModeView : View
	{
		[SerializeField]
		private string exitConfirmationTerm;

		private void Update()
		{
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		private void ShowContentPolicy()
		{
		}

		private void ShowSpoilerWarning()
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override void SetInitialSelect()
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}
	}
}
