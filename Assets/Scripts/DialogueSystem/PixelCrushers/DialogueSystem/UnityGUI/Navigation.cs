using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class Navigation
	{
		public bool enabled;

		public bool focusFirstControlOnEnable;

		public bool jumpToMousePosition;

		public GUIControl[] order;

		public string clickButton;

		public KeyCode click;

		public KeyCode previous;

		public KeyCode next;

		public string axis;

		public bool invertAxis;

		public float axisRepeatDelay;

		public float mouseWheelSensitivity;

		private int current;

		private float axisRepeatTime;

		private const float AxisThreshold = 0.5f;

		private const float MinorAxisThreshold = 0.01f;

		private float mouseWheelY;

		private bool isAxisPrevDown;

		private bool isAxisNextDown;

		private float timeNextRelease;

		public string FocusedControlName => null;

		private bool IsCurrentValid => false;

		private bool IsOrderArrayValid => false;

		public bool IsClicked => false;

		public void FocusFirstControl()
		{
		}

		public void CheckNavigationInput(Vector2 relativeMousePosition)
		{
		}

		private void NavigateToMousePosition(Vector2 relativeMousePosition)
		{
		}

		public void Navigate(int direction)
		{
		}

		private bool IsClickableButton(GUIControl control)
		{
			return false;
		}

		private int NextControlIndex(int direction)
		{
			return 0;
		}

		private void CheckMouseWheel()
		{
		}

		private bool IsNextControlInputDown(float axisValue)
		{
			return false;
		}

		private bool IsPreviousControlInputDown(float axisValue)
		{
			return false;
		}

		private float GetNavigationAxis()
		{
			return 0f;
		}
	}
}
