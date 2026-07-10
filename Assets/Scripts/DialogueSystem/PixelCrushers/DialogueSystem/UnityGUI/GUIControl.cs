using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIControl : MonoBehaviour
	{
		public int depth;

		public bool depthSortChildren;

		public ScaledRect scaledRect;

		public AutoSize autoSize;

		public Fit fit;

		public Navigation navigation;

		public bool visible;

		public bool clipChildren;

		private string fullName;

		private List<GUIControl> children;

		private bool needToUpdateLayout;

		private Vector2 windowSize;

		private bool navigationSelectButtonClicked;

		public Rect rect { get; set; }

		public Vector2 Offset { get; set; }

		protected List<GUIControl> Children => null;

		public bool NeedToUpdateLayout
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected Vector2 WindowSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool IsNavigationEnabled => false;

		public string FullName => null;

		public Vector2 dRect { get; set; }

		public virtual void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public void Draw(Vector2 relativeMousePosition)
		{
		}

		public virtual void DrawSelf(Vector2 relativeMousePosition)
		{
		}

		public virtual void DrawChildren(Vector2 relativeMousePosition)
		{
		}

		public virtual void Update()
		{
		}

		public virtual void Refresh(Vector2 windowSize)
		{
		}

		public virtual void Refresh()
		{
		}

		public virtual void UpdateLayout()
		{
		}

		public virtual void UpdateLayoutSelf()
		{
		}

		public virtual void AutoSizeSelf()
		{
		}

		protected virtual void FitSelf()
		{
		}

		private void UpdateLayoutChildren()
		{
		}

		private void UpdateLayoutChild(GUIControl child, Vector2 childWindowSize)
		{
		}

		private void FitChildren()
		{
		}

		private void FindChildren()
		{
		}

		private void SortChildren()
		{
		}
	}
}
