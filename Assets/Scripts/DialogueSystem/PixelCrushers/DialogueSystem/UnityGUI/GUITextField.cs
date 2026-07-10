using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUITextField : GUIVisibleControl
	{
		public int maxLength;

		private bool takeFocus;

		protected override GUIStyle DefaultGUIStyle => null;

		public void TakeFocus()
		{
		}

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}
	}
}
