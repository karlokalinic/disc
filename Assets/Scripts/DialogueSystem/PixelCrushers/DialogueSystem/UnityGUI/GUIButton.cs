using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIButton : GUIVisibleControl
	{
		public bool clickable;

		public GUIImageParams disabled;

		public GUIImageParams normal;

		public GUIImageParams hover;

		public GUIImageParams pressed;

		public AudioClip hoverSound;

		public AudioClip clickSound;

		public InputTrigger trigger;

		public string message;

		public string parameter;

		public Transform target;

		public object data;

		private bool isHovered;

		protected override GUIStyle DefaultGUIStyle => null;

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}

		private void DrawClickable(Vector2 relativeMousePosition)
		{
		}

		private void DrawUnclickable()
		{
		}

		public override void Update()
		{
		}

		public void Click()
		{
		}
	}
}
