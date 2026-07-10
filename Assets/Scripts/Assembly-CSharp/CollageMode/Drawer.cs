using System;
using DG.Tweening;
using UnityEngine;

namespace CollageMode
{
	public class Drawer : MonoBehaviour
	{
		protected const string TabTermPrefix = "TAB/";

		[SerializeField]
		private float tweenTime;

		[SerializeField]
		private float tweenDelay;

		private CanvasGroup canvasGroup;

		private Sequence sequence;

		public Action OnDone;

		public virtual string TitleTerm => null;

		public virtual BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public virtual bool IsSelectionDrawer => false;

		public virtual bool IsAssetDrawer => false;

		protected bool IsInTransition => false;

		protected virtual void Awake()
		{
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		public virtual void RefreshSelectedElement()
		{
		}
	}
}
