using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voidforge;

namespace Sunshine.Views
{
	public class ViewController : SingletonComponent<ViewController>
	{
		public FeldSlide feldslide;

		public AnimationCurve curve;

		public static Action<ViewType> OnChangeView;

		public static Action<ViewType> OnSwitchedView;

		[SerializeField]
		private List<ViewType> cameraLockViews;

		private Dictionary<ViewType, View> viewCache;

		private static ViewType viewThatFailedToSwitch;

		private bool popStackOnSuccess;

		[SerializeField]
		private ViewType current;

		private Stack<ViewType> stack;

		private bool _viewHasPortraits;

		private bool _viewHasHudMenu;

		private bool isTransitioning;

		private bool isHUDTween;

		private bool _forceView;

		public static ViewType Current => default(ViewType);

		public bool ViewHasPortraits
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ViewHasHudMenu
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsTransitioning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ForceView
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public bool IsActiveOnStart(ViewType type)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ClearViewStack()
		{
		}

		public void RegisterViewType(View view)
		{
		}

		public View GetViewByType(ViewType viewType)
		{
			return null;
		}

		public static View GetCurrentView()
		{
			return null;
		}

		public bool HideInterface(ViewType viewType)
		{
			return false;
		}

		public bool IsInThatState(ViewType viewType)
		{
			return false;
		}

		public static void ToggleView(ViewType nextView, bool forceTransition = false)
		{
		}

		private static void DoExitViewProcedures(ViewType nextView)
		{
		}

		private static ViewType GetNextView()
		{
			return default(ViewType);
		}

		public void SwitchToFullScreenView(View view, RectTransform feldSlideRect = null, bool viewHasPortraits = false, bool viewHasHudMenu = false, VIEW_STACK_OPERATION stackOperation = VIEW_STACK_OPERATION.DO_NOTHING)
		{
		}

		public void SwitchToView(View view, bool viewHasPortraits = false, bool viewHasHudMenu = false, VIEW_STACK_OPERATION stackOperation = VIEW_STACK_OPERATION.DO_NOTHING)
		{
		}

		public static void ClearViewIfNecessary()
		{
		}

		public static bool TryProceedToFailedView()
		{
			return false;
		}

		private void OnAreaReady()
		{
		}

		private void OnAreaNotReady()
		{
		}

		public bool IsViewOnStack(ViewType viewType)
		{
			return false;
		}

		public static bool IsOneOfGameplayViewCurrent()
		{
			return false;
		}
	}
}
