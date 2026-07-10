using UnityEngine;

namespace PSNSample
{
	public class GamePad : MonoBehaviour
	{
		public struct PS4GamePad
		{
			public Vector2 thumbstick_left;

			public Vector2 thumbstick_right;

			public bool cross;

			public bool circle;

			public bool triangle;

			public bool square;

			public bool dpad_down;

			public bool dpad_right;

			public bool dpad_up;

			public bool dpad_left;

			public bool L1;

			public bool L2;

			public bool L3;

			public bool R1;

			public bool R2;

			public bool R3;

			public bool options;

			public bool touchpad;
		}

		public static GamePad activeGamePad;

		public int playerId;

		private static bool enableInput;

		private static float timeout;

		public PS4GamePad previousFrame;

		public PS4GamePad currentFrame;

		private int stickID;

		private bool hasSetupGamepad;

		private KeyCode optionsBtnKeyCode;

		private string leftStickHorizontalAxis;

		private string leftStickVerticalAxis;

		private string rightStickHorizontalAxis;

		private string rightStickVerticalAxis;

		private KeyCode L1BtnKeyCode;

		private KeyCode R1BtnKeyCode;

		private string L2Axis;

		private string R2Axis;

		private KeyCode L3BtnKeyCode;

		private KeyCode R3BtnKeyCode;

		private KeyCode CrossBtnKeyCode;

		private KeyCode CircleBtnKeyCode;

		private KeyCode SquareBtnKeyCode;

		private KeyCode TriangleBtnKeyCode;

		private string DPadRightAxis;

		private string DPadLeftAxis;

		private string DPadUpAxis;

		private string DPadDownAxis;

		public static bool IsInputEnabled => false;

		public bool IsSquarePressed => false;

		public bool IsCirclePressed => false;

		public bool IsTrianglePressed => false;

		public bool IsCrossPressed => false;

		public bool IsDpadDownPressed => false;

		public bool IsDpadRightPressed => false;

		public bool IsDpadUpPressed => false;

		public bool IsDpadLeftPressed => false;

		public bool IsR3Pressed => false;

		public Vector2 GetThumbstickLeft => default(Vector2);

		public Vector2 GetThumbstickRight => default(Vector2);

		private bool AnyInput => false;

		public bool IsConnected => false;

		public static void EnableInput(bool enable)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void ToggleGamePad(bool active)
		{
		}

		private void Thumbsticks()
		{
		}

		private void InputButtons()
		{
		}

		private void DPadButtons()
		{
		}

		private void TriggerShoulderButtons()
		{
		}
	}
}
