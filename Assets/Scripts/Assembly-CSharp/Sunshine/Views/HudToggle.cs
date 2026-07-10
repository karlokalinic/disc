using System.Collections;
using UnityEngine;
using Voidforge;

namespace Sunshine.Views
{
	public class HudToggle : SingletonComponent<HudToggle>
	{
		[SerializeField]
		private HudMainMenuButtonTrigger hudMainMenuButtonTrigger;

		[SerializeField]
		private HudController target;

		[SerializeField]
		private GameObject[] hudsToToActivate;

		private bool _isPhotoMode;

		private bool lastVisibilityState;

		private bool lastHudVisibilityState;

		private bool _suppressHud;

		private bool _isLoading;

		public bool IsPhotoMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HudVisible => false;

		public bool HudMenuVisible => false;

		public bool CanBeToggled => false;

		public bool SuppressHud
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void FixForDreamScene()
		{
		}

		public void InitHud()
		{
		}

		public void HudChange()
		{
		}

		public void HudMenuChange()
		{
		}

		public void FeldVisibility()
		{
		}

		public void Start()
		{
		}

		public void Initialize()
		{
		}

		private IEnumerator ChangeHudMenuButtons()
		{
			return null;
		}

		private void ShowHud()
		{
		}

		private void HideHud()
		{
		}

		public void ShowClock()
		{
		}

		public void HideClock()
		{
		}

		public void FadeOutClock()
		{
		}

		public void FadeInClock()
		{
		}

		public void ShowMoney()
		{
		}

		public void HideMoney()
		{
		}

		public void ShowHeldPanel()
		{
		}

		public void HideHeldPanel()
		{
		}

		private void ShowHudMenu()
		{
		}

		private void HideHudMenu()
		{
		}

		public void TogglePhotoMode()
		{
		}
	}
}
