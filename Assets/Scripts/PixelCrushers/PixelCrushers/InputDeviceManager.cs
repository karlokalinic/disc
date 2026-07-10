using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace PixelCrushers
{
	public class InputDeviceManager : MonoBehaviour
	{
		public delegate bool GetButtonDownDelegate(string buttonName);

		public delegate float GetAxisDelegate(string axisName);

		public InputDevice inputDevice;

		public KeyCode[] joystickKeyCodesToCheck;

		public string[] joystickButtonsToCheck;

		public string[] joystickAxesToCheck;

		public float joystickAxisThreshold;

		public string[] keyButtonsToCheck;

		public KeyCode[] keyCodesToCheck;

		public bool alwaysAutoFocus;

		public bool detectMouseControl;

		public float mouseMoveThreshold;

		public bool controlCursorState;

		public bool enforceCursorOnPause;

		public bool controlGraphicRaycasters;

		public KeyCode[] backKeyCodes;

		public string[] backButtons;

		public bool singleton;

		public UnityEvent onUseKeyboard;

		public UnityEvent onUseJoystick;

		public UnityEvent onUseMouse;

		public UnityEvent onUseTouch;

		public GetButtonDownDelegate GetButtonDown;

		public GetAxisDelegate GetInputAxis;

		private Vector3 m_lastMousePosition;

		private bool m_ignoreMouse;

		private static InputDeviceManager m_instance;

		public static InputDeviceManager instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static InputDevice currentInputDevice => default(InputDevice);

		public static bool deviceUsesCursor => false;

		public static bool autoFocus => false;

		public static bool isBackButtonDown => false;

		public static bool IsButtonDown(string buttonName)
		{
			return false;
		}

		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void Start()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public void SetInputDevice(InputDevice newDevice)
		{
		}

		private void SetGraphicRaycasters(bool deviceUsesCursor)
		{
		}

		public void Update()
		{
		}

		public bool IsUsingJoystick()
		{
			return false;
		}

		public bool IsUsingMouse()
		{
			return false;
		}

		public void BrieflyIgnoreMouseMovement()
		{
		}

		private IEnumerator BrieflyIgnoreMouseMovementCoroutine()
		{
			return null;
		}

		public bool IsUsingKeyboard()
		{
			return false;
		}

		public bool IsBackButtonDown()
		{
			return false;
		}

		public bool DefaultGetButtonDown(string buttonName)
		{
			return false;
		}

		public float DefaultGetAxis(string axisName)
		{
			return 0f;
		}

		public void SetCursor(bool visible)
		{
		}

		public void ForceCursor(bool visible)
		{
		}

		private IEnumerator ForceCursorAfterOneFrameCoroutine(bool visible)
		{
			return null;
		}
	}
}
