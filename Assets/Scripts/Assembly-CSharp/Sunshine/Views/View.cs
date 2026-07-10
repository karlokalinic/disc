using System.Collections;
using System.Collections.Generic;
using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public abstract class View : MonoBehaviour
	{
		public static List<ViewType> HAS_CAMERA_MAKER;

		protected RectTransform viewTransform;

		private Coroutine frameAfterSwitchedToCoroutine;

		public abstract ViewType GetViewType();

		public abstract void SwitchToView(ViewType previousView);

		public abstract bool CanTransitionFromCurrentView();

		public abstract FeldView GetFeldViewType();

		public abstract void SetInitialSelect();

		public virtual void OnExitView(ViewType nextView)
		{
		}

		public virtual void InitTransforms()
		{
		}

		public virtual bool CanExitView(ViewType nextView)
		{
			return false;
		}

		public virtual void OnFailedExitAttempt(ViewType nextView)
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		protected void RegisterEscapeKeyListener()
		{
		}

		protected void UnregisterEscapeKeyListener()
		{
		}

		protected virtual void CloseOnUICancel()
		{
		}

		protected virtual void CloseOnEscapeKey()
		{
		}

		public void StartFrameAfterSwitchedToCor(int framesAmount = 1)
		{
		}

		public void StopFrameAfterSwitchedToCor()
		{
		}

		protected IEnumerator FrameAfterSwitchedToCor(int framesAmount = 1)
		{
			return null;
		}

		protected virtual void OnFrameAfterSwitchedToCompleated()
		{
		}
	}
}
