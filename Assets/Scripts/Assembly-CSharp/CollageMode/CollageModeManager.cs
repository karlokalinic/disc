using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CollageMode
{
	public class CollageModeManager : LiteSingleton<CollageModeManager>
	{
		[SerializeField]
		private BottomPanel bottomPanel;

		[SerializeField]
		private CaptureButton captureButton;

		[SerializeField]
		private CollageModePopup popup;

		[SerializeField]
		private CollageModeContentPolicyPopup contentPolicyPopup;

		[SerializeField]
		private ScreenshotPopup screenshotPopup;

		[SerializeField]
		private InputLock inputLock;

		[SerializeField]
		private LoadingPanel loadingPanel;

		public CommandDispatcher Dispatcher { get; private set; }

		public CollageMode CollageMode { get; private set; }

		public DrawerManager DrawerManager { get; private set; }

		public static FilterManager FilterManager => null;

		public static TimeManager TimeManager => null;

		public static MapManager MapManager => null;

		public static CollageCameraController CameraManager => null;

		public static CollageElementsContainer CollageElements => null;

		public BottomPanel BottomPanel => null;

		public CaptureButton CaptureButton => null;

		public CollageModePopup Popup => null;

		public CollageModeContentPolicyPopup ContentPolicyPopup => null;

		public ScreenshotPopup ScreenshotPopup => null;

		public InputLock InputLock => null;

		public LoadingPanel LoadingPanel => null;

		public SelectionMode SelectionMode { get; private set; }

		public CollageElement CurrentlySelected { get; private set; }

		public Guid CurrentlySelectedGuid => default(Guid);

		public CollageInputType InputType => default(CollageInputType);

		public event Action<CollageElement, SelectionMode> OnSelectionChanged
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

		public event Action<bool> OnNewFragmentNotification
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

		protected override void Awake()
		{
		}

		public void InvokeNewFragmentNotification(bool isOn)
		{
		}

		public void SetSelected(CollageElement selected, SelectionMode selectionMode = SelectionMode.None)
		{
		}

		public void Enter()
		{
		}

		public void Exit(Action onComplete)
		{
		}
	}
}
