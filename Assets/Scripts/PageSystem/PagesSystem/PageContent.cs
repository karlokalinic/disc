using DG.Tweening;
using UnityEngine;

namespace PagesSystem
{
	public abstract class PageContent : MonoBehaviour
	{
		protected PageStack myStack;

		protected RectTransform rectTransform;

		protected CanvasGroup canvasGroup;

		public PageStack MyStack => null;

		public virtual string Title => null;

		public bool IsPopup { get; set; }

		public virtual bool CanStayOnStack => false;

		public virtual bool IsBackPossible => false;

		public virtual bool IsTitleLabelVisible => false;

		public virtual bool IsBackButtonVisible => false;

		public virtual bool IsProfileButtonVisibe => false;

		public virtual bool IsWholeTitleBarVisible => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public abstract void Initialize();

		public abstract void RefreshOnStackChanged();

		public virtual void OnStackInitialized()
		{
		}

		public void InjectStack(PageStack stack)
		{
		}

		public virtual void OnAndroidBackButtonPressed()
		{
		}

		public virtual Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public virtual Sequence GetTransitionOutSequence(PageContent newPage)
		{
			return null;
		}

		public abstract void OnNavigatedTo(NavigationParameters parameters);

		public abstract void OnNavigatedFrom();

		public virtual void OnNavigatedToAnimationComplete()
		{
		}

		public virtual void OnNavigatedFromAnimationComplete()
		{
		}
	}
}
