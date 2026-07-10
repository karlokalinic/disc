using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class HelpOverlayView : View
	{
		private RectTransform rectTransform;

		public override void Awake()
		{
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void InitTransforms()
		{
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
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
