using Sunshine.Feld;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class CharacterCreationAdjustAbilitiesView : View
	{
		[SerializeField]
		private Button randomButton;

		[SerializeField]
		private Button revertAbilitiesButton;

		[SerializeField]
		private Button nextButton;

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

		public override void SwitchToView(ViewType previousView)
		{
		}

		private void Update()
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
