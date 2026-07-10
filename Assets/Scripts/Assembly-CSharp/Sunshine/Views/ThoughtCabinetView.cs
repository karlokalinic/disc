using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class ThoughtCabinetView : View
	{
		public RectTransform statsColumn;

		public RectTransform thoughtEquipment;

		public RectTransform thoughtInventory;

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override void InitTransforms()
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

		public override void SetInitialSelect()
		{
		}
	}
}
