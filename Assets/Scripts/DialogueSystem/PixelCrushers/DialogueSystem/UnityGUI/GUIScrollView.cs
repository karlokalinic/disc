using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIScrollView : GUIControl
	{
		public bool showVerticalScrollbar;

		public bool showHorizontalScrollbar;

		public int padding;

		private Vector2 scrollViewVector;

		public float contentWidth { get; set; }

		public float contentHeight { get; set; }

		public event Action MeasureContentHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action DrawContentHandler
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ResetScrollPosition()
		{
		}

		public override void DrawChildren(Vector2 relativeMousePosition)
		{
		}

		private Rect GetScrollContentRect()
		{
			return default(Rect);
		}

		private void MeasureChildrenAsContent()
		{
		}

		private float GetChildXMax(GUIControl child)
		{
			return 0f;
		}

		private float GetChildYMax(GUIControl child)
		{
			return 0f;
		}
	}
}
