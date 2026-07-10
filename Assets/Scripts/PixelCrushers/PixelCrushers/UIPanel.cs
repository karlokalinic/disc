using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class UIPanel : MonoBehaviour
	{
		public enum StartState
		{
			GameObjectState = 0,
			Open = 1,
			Closed = 2
		}

		public enum PanelState
		{
			Uninitialized = 0,
			Opening = 1,
			Open = 2,
			Closing = 3,
			Closed = 4
		}

		public GameObject firstSelected;

		public float focusCheckFrequency;

		public float refreshSelectablesFrequency;

		public bool selectPreviousOnDisable;

		public string showAnimationTrigger;

		public string hideAnimationTrigger;

		public StartState startState;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public UnityEvent onBackButtonDown;

		protected GameObject m_previousSelected;

		protected GameObject m_lastSelected;

		protected List<GameObject> selectables;

		private float m_timeNextCheck;

		private float m_timeNextRefresh;

		protected bool m_deactivateOnHidden;

		public static bool monitorSelection;

		protected static List<UIPanel> panelStack;

		private PanelState m_panelState;

		private UIAnimatorMonitor m_animatorMonitor;

		public bool deactivateOnHidden
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected static UIPanel topPanel => null;

		public PanelState panelState
		{
			get
			{
				return default(PanelState);
			}
			set
			{
			}
		}

		public virtual bool waitForShowAnimation => false;

		public bool isOpen => false;

		public UIAnimatorMonitor animatorMonitor => null;

		protected virtual void Start()
		{
		}

		public void RefreshSelectablesList()
		{
		}

		public void RefreshAfterOneFrame()
		{
		}

		private IEnumerator RefreshAfterOneFrameCoroutine()
		{
			return null;
		}

		protected void PushToPanelStack()
		{
		}

		protected void PopFromPanelStack()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void SetOpen(bool value)
		{
		}

		public virtual void Toggle()
		{
		}

		protected virtual void OnVisible()
		{
		}

		protected virtual void OnHidden()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void CheckFocus()
		{
		}

		protected GameObject GetFirstInteractableButton()
		{
			return null;
		}
	}
}
