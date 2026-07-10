using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueActor : MonoBehaviour
	{
		[Serializable]
		public class BarkUISettings
		{
			public AbstractBarkUI barkUI;

			public Vector3 barkUIOffset;
		}

		public enum UseMenuPanelFor
		{
			OnlyMe = 0,
			MeAndResponsesToMe = 1
		}

		[Serializable]
		public class StandardDialogueUISettings
		{
			public SubtitlePanelNumber subtitlePanelNumber;

			public StandardUISubtitlePanel customSubtitlePanel;

			public Vector3 customSubtitlePanelOffset;

			public MenuPanelNumber menuPanelNumber;

			public StandardUIMenuPanel customMenuPanel;

			public Vector3 customMenuPanelOffset;

			public UseMenuPanelFor useMenuPanelFor;

			public RuntimeAnimatorController portraitAnimatorController;

			public bool setSubtitleColor;

			public bool applyColorToPrependedName;

			public string prependActorNameSeparator;

			public Color subtitleColor;
		}

		public string actor;

		public string persistentDataName;

		public Texture2D portrait;

		public Sprite spritePortrait;

		public BarkUISettings barkUISettings;

		public StandardDialogueUISettings standardDialogueUISettings;

		private void Start()
		{
		}

		public Sprite GetPortraitSprite()
		{
			return null;
		}

		private void SetupBarkUI()
		{
		}

		private void SetupDialoguePanels()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public string GetName()
		{
			return null;
		}

		public string GetActorName()
		{
			return null;
		}

		public string GetPersistentDataName()
		{
			return null;
		}

		public SubtitlePanelNumber GetSubtitlePanelNumber()
		{
			return default(SubtitlePanelNumber);
		}

		public void SetSubtitlePanelNumber(SubtitlePanelNumber newSubtitlePanelNumber)
		{
		}

		public MenuPanelNumber GetMenuPanelNumber()
		{
			return default(MenuPanelNumber);
		}

		public void SetMenuPanelNumber(MenuPanelNumber newMenuPanelNumber)
		{
		}

		public string AdjustSubtitleColor(Subtitle subtitle)
		{
			return null;
		}

		public static DialogueActor GetDialogueActorComponent(Transform t)
		{
			return null;
		}

		public static string GetActorName(Transform t)
		{
			return null;
		}

		public static string GetPersistentDataName(Transform t)
		{
			return null;
		}

		public static SubtitlePanelNumber GetSubtitlePanelNumber(Transform t)
		{
			return default(SubtitlePanelNumber);
		}

		public static IBarkUI GetBarkUI(Transform t)
		{
			return null;
		}
	}
}
