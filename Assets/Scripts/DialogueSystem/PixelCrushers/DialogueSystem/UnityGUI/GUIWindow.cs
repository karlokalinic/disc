using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIWindow : GUIVisibleControl
	{
		private Vector2 currentChildMousePosition;

		protected override GUIStyle DefaultGUIStyle => null;

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}

		public override void DrawChildren(Vector2 relativeMousePosition)
		{
		}

		private void WindowFunction(int windowID)
		{
		}
	}
}
