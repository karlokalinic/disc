using System.Collections;
using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class SaveView : View
	{
		private SaveLoadController saveLoadController;

		private Coroutine resetViewCoroutine;

		public override void Awake()
		{
		}

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

		public override void OnExitView(ViewType nextView)
		{
		}

		private IEnumerator ResetViewDataCoroutine()
		{
			return null;
		}

		public override void SetInitialSelect()
		{
		}

		protected override void OnFrameAfterSwitchedToCompleated()
		{
		}
	}
}
