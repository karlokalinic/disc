using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	[ExecuteInEditMode]
	public class TouchManager : SingletonMonoBehavior<TouchManager>
	{
		public enum GizmoShowOption
		{
			Never = 0,
			WhenSelected = 1,
			UnlessPlaying = 2,
			Always = 3
		}

		[Space]
		public Camera touchCamera;

		public GizmoShowOption controlsShowGizmos;

		[HideInInspector]
		public bool enableControlsOnTouch;

		[SerializeField]
		[HideInInspector]
		private bool _controlsEnabled;

		[HideInInspector]
		public int controlsLayer;

		private InputDevice device;

		private Vector3 viewSize;

		private Vector2 screenSize;

		private Vector2 halfScreenSize;

		private float percentToWorld;

		private float halfPercentToWorld;

		private float pixelToWorld;

		private float halfPixelToWorld;

		private TouchControl[] touchControls;

		private TouchPool cachedTouches;

		private List<Touch> activeTouches;

		private ReadOnlyCollection<Touch> readOnlyActiveTouches;

		private bool isReady;

		private readonly Touch[] mouseTouches;

		public bool controlsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static ReadOnlyCollection<Touch> Touches => null;

		public static int TouchCount => 0;

		public static Camera Camera => null;

		public static InputDevice Device => null;

		public static Vector3 ViewSize => default(Vector3);

		public static float PercentToWorld => 0f;

		public static float HalfPercentToWorld => 0f;

		public static float PixelToWorld => 0f;

		public static float HalfPixelToWorld => 0f;

		public static Vector2 ScreenSize => default(Vector2);

		public static Vector2 HalfScreenSize => default(Vector2);

		public static GizmoShowOption ControlsShowGizmos => default(GizmoShowOption);

		public static bool ControlsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Action OnSetup
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

		protected TouchManager()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Setup()
		{
		}

		private void Reset()
		{
		}

		private IEnumerator UpdateScreenSizeAtEndOfFrame()
		{
			return null;
		}

		private void Update()
		{
		}

		private void CreateDevice()
		{
		}

		private void UpdateDevice(ulong updateTick, float deltaTime)
		{
		}

		private void CommitDevice(ulong updateTick, float deltaTime)
		{
		}

		private void SubmitControlStates(ulong updateTick, float deltaTime)
		{
		}

		private void CommitControlStates(ulong updateTick, float deltaTime)
		{
		}

		private void UpdateScreenSize(Vector2 currentScreenSize)
		{
		}

		private void CreateTouches()
		{
		}

		private void UpdateTouches(ulong updateTick, float deltaTime)
		{
		}

		private void SendTouchBegan(Touch touch)
		{
		}

		private void SendTouchMoved(Touch touch)
		{
		}

		private void SendTouchEnded(Touch touch)
		{
		}

		private void InvokeTouchEvents()
		{
		}

		private bool TouchCameraIsValid()
		{
			return false;
		}

		private Vector3 ConvertScreenToWorldPoint(Vector2 point)
		{
			return default(Vector3);
		}

		private Vector3 ConvertViewToWorldPoint(Vector2 point)
		{
			return default(Vector3);
		}

		private Vector3 ConvertScreenToViewPoint(Vector2 point)
		{
			return default(Vector3);
		}

		private Vector2 GetCurrentScreenSize()
		{
			return default(Vector2);
		}

		public static Touch GetTouch(int touchIndex)
		{
			return null;
		}

		public static Touch GetTouchByFingerId(int fingerId)
		{
			return null;
		}

		public static Vector3 ScreenToWorldPoint(Vector2 point)
		{
			return default(Vector3);
		}

		public static Vector3 ViewToWorldPoint(Vector2 point)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenToViewPoint(Vector2 point)
		{
			return default(Vector3);
		}

		public static float ConvertToWorld(float value, TouchUnitType unitType)
		{
			return 0f;
		}

		public static Rect PercentToWorldRect(Rect rect)
		{
			return default(Rect);
		}

		public static Rect PixelToWorldRect(Rect rect)
		{
			return default(Rect);
		}

		public static Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
		{
			return default(Rect);
		}

		public static implicit operator bool(TouchManager instance)
		{
			return false;
		}
	}
}
