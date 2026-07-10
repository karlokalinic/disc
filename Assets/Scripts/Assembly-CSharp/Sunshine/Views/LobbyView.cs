using System.Collections;
using Sunshine.Feld;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class LobbyView : View
	{
		[SerializeField]
		private Selectable initialSelected;

		private bool isDestroyed;

		private Coroutine subscribeCor;

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

		private void OnDestroy()
		{
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		public override void SetInitialSelect()
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		private IEnumerator SubscribeAfterFrame()
		{
			return null;
		}

		protected override void CloseOnEscapeKey()
		{
		}
	}
}
