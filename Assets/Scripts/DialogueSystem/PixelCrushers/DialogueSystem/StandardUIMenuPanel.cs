using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIMenuPanel : UIPanel
	{
		public Graphic panel;

		public Image pcImage;

		public UITextField pcName;

		public Slider timerSlider;

		public ResponseButtonAlignment buttonAlignment;

		public bool showUnusedButtons;

		public StandardUIResponseButton[] buttons;

		public StandardUIResponseButton buttonTemplate;

		public Graphic buttonTemplateHolder;

		public Scrollbar buttonTemplateScrollbar;

		public UIScrollbarEnabler scrollbarEnabler;

		public float buttonTemplateScrollbarResetValue;

		public bool explicitNavigationForTemplateButtons;

		public bool loopExplicitNavigation;

		public UIAutonumberSettings autonumber;

		public UnityEvent onContentChanged;

		public string focusAnimationTrigger;

		public string unfocusAnimationTrigger;

		public UnityEvent onFocus;

		public UnityEvent onUnfocus;

		[SerializeField]
		private bool m_hasFocus;

		private List<GameObject> m_instantiatedButtons;

		private List<GameObject> m_instantiatedButtonPool;

		protected StandardUITimer m_timer;

		protected Action m_timeoutHandler;

		public virtual bool hasFocus
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public override bool waitForShowAnimation => false;

		public List<GameObject> instantiatedButtons => null;

		protected List<GameObject> instantiatedButtonPool => null;

		public virtual void Awake()
		{
		}

		public virtual void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		[Obsolete]
		public virtual void SetPCPortrait(Texture2D portraitTexture, string portraitName)
		{
		}

		public virtual void ShowResponses(Subtitle subtitle, Response[] responses, Transform target)
		{
		}

		public virtual void HideResponses()
		{
		}

		public override void Close()
		{
		}

		public virtual void Focus()
		{
		}

		protected IEnumerator FocusWhenOpen()
		{
			return null;
		}

		protected virtual void FocusNow()
		{
		}

		private void OnFocused()
		{
		}

		public virtual void Unfocus()
		{
		}

		protected void ActivateUIElements()
		{
		}

		protected void DeactivateUIElements()
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void HideImmediate()
		{
		}

		protected virtual void ClearResponseButtons()
		{
		}

		protected virtual void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		protected virtual void SetResponseButton(StandardUIResponseButton button, Response response, Transform target, int buttonNumber)
		{
		}

		protected int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		public virtual void SetupTemplateButtonNavigation()
		{
		}

		protected GameObject InstantiateButton()
		{
			return null;
		}

		public void DestroyInstantiatedButtons()
		{
		}

		public void MakeButtonsNonclickable()
		{
		}

		protected void NotifyContentChanged()
		{
		}

		public virtual void StartTimer(float timeout, Action timeoutHandler)
		{
		}

		public virtual void StopTimer()
		{
		}
	}
}
