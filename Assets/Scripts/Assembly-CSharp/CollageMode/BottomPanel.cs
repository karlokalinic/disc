using System;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class BottomPanel : MonoBehaviour
	{
		public enum State
		{
			Hidden = 0,
			Small = 1,
			Big = 2
		}

		[Serializable]
		public struct DrawerTogglePair
		{
			public Drawer Drawer;

			public Toggle Toggle;
		}

		[SerializeField]
		private RectTransform feldStrip;

		[SerializeField]
		private Localize titleLocalize;

		[SerializeField]
		private float hiddenPositionY;

		[SerializeField]
		private float smallPositionY;

		[SerializeField]
		private float bigPositionY;

		[SerializeField]
		private float tweenTime;

		[SerializeField]
		private float tweenDelay;

		[SerializeField]
		private DrawerTogglePair objectsDrawerTogglePair;

		[SerializeField]
		private DrawerTogglePair effectsDrawerTogglePair;

		[SerializeField]
		private DrawerTogglePair settingDrawerTogglePair;

		[SerializeField]
		private DrawerTogglePair savesDrawerTogglePair;

		[SerializeField]
		private ElementSelectedDrawer elementSelectedDrawer;

		[SerializeField]
		private CharacterEditDrawer characterEditDrawer;

		[SerializeField]
		private Highlighter objectsToggleHighlighter;

		public State CurrentState { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetSelection(CollageElement newSelected)
		{
		}

		public void Clear()
		{
		}

		private void SetState(State state)
		{
		}

		private float GetDrawerYPosition(State state)
		{
			return 0f;
		}

		private void PushDrawer(Drawer newDrawer, bool replaceLastOne = false)
		{
		}

		private void PopDrawer()
		{
		}

		private void ClearDrawer()
		{
		}

		private void RefreshStateAndTitle()
		{
		}

		private void OnEditRequested()
		{
		}

		private void OnElementSelectedDone()
		{
		}

		private void OnCharacterEditDone()
		{
		}

		private void OnObjectsDrawerDone()
		{
		}

		private void OnEffectsDrawerDone()
		{
		}

		private void OnSettingDrawerDone()
		{
		}

		private void OnSavesDrawerDone()
		{
		}

		private void UpdateDrawerToggles()
		{
		}

		private void OnNewFragmentNotification(bool isOn)
		{
		}

		private void OnSelectionChanged(CollageElement collageElement, SelectionMode selectionMode)
		{
		}
	}
}
