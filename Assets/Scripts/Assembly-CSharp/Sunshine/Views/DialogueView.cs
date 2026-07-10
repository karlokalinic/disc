using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class DialogueView : View
	{
		public static DialogueView INSTANCE;

		public void OnEnable()
		{
		}

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

		private VIEW_STACK_OPERATION GetViewStackOperation()
		{
			return default(VIEW_STACK_OPERATION);
		}

		public RectTransform GetViewTransform()
		{
			return null;
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		private void Update()
		{
		}

		public override void SetInitialSelect()
		{
		}
	}
}
