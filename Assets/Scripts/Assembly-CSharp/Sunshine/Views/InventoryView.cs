using System.Collections;
using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class InventoryView : View
	{
		public RectTransform characterColumn;

		public RectTransform statsColumn;

		public GameObject bumperPrompt;

		private Coroutine waitForPlayerStop;

		private Coroutine setInitialSelectionCoroutine;

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override void Start()
		{
		}

		private void ClearCoroutine(ViewType obj)
		{
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void InitTransforms()
		{
		}

		public override void SwitchToView(ViewType nextView)
		{
		}

		protected void SwitchToView(ViewType previousView, VIEW_STACK_OPERATION stackOperation, bool viewHasPortraits = false)
		{
		}

		private IEnumerator WaitForStopRunning(VIEW_STACK_OPERATION stackOperation, bool viewHasPortraits)
		{
			return null;
		}

		private void FinishSwitchToView(VIEW_STACK_OPERATION stackOperation, bool viewHasPortraits)
		{
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override void SetInitialSelect()
		{
		}

		private IEnumerator SetInitialAfterInventoryRefresh()
		{
			return null;
		}
	}
}
