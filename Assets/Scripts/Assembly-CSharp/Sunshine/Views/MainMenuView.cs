using System.Collections;
using InControl;
using Sunshine.Feld;
using UnityEngine;

namespace Sunshine.Views
{
	public class MainMenuView : View
	{
		[SerializeField]
		private RectTransform selectOverlayPrompt;

		[SerializeField]
		private RectTransform backOverlayPrompt;

		[SerializeField]
		private MainMenuAdButton c4AdButton;

		private NavigationGroup navigationGroup;

		public RectTransform labelBlock;

		private static float inDialogueMusicVolume;

		private PlayerAction toggleHelp;

		[SerializeField]
		private GameObject deLogo;

		private bool helpVisible;

		private Coroutine subscribeCor;

		public static float InDialogueMusicVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		private void Update()
		{
		}

		public override ViewType GetViewType()
		{
			return default(ViewType);
		}

		public override FeldView GetFeldViewType()
		{
			return default(FeldView);
		}

		public override bool CanTransitionFromCurrentView()
		{
			return false;
		}

		public override void InitTransforms()
		{
		}

		public override void SwitchToView(ViewType previousView)
		{
		}

		private IEnumerator WaitForScreenShootAndSwitchToView(ViewType previousView)
		{
			return null;
		}

		private void FinishSwitchToView(ViewType previousView)
		{
		}

		private IEnumerator SubscribeAfterFrame()
		{
			return null;
		}

		public override void OnExitView(ViewType nextView)
		{
		}

		private static void TestIfTimeZoneExist()
		{
		}

		public override void SetInitialSelect()
		{
		}
	}
}
