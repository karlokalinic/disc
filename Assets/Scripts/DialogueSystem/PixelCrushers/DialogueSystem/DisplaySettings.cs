using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DisplaySettings
	{
		[Serializable]
		public class LocalizationSettings
		{
			public string language;

			public bool useSystemLanguage;

			public TextTable textTable;
		}

		[Serializable]
		public class SubtitleSettings
		{
			public enum ContinueButtonMode
			{
				Never = 0,
				Always = 1,
				Optional = 2,
				OptionalBeforeResponseMenu = 3,
				NotBeforeResponseMenu = 4,
				OptionalBeforePCAutoresponseOrMenu = 5,
				NotBeforePCAutoresponseOrMenu = 6,
				OptionalForPC = 7,
				NotForPC = 8,
				OptionalForPCOrBeforeResponseMenu = 9,
				NotForPCOrBeforeResponseMenu = 10,
				OptionalForPCOrBeforePCAutoresponseOrMenu = 11,
				NotForPCOrBeforePCAutoresponseOrMenu = 12,
				OnlyForPC = 13
			}

			public bool showNPCSubtitlesDuringLine;

			public bool showNPCSubtitlesWithResponses;

			public bool showPCSubtitlesDuringLine;

			public bool allowPCSubtitleReminders;

			public bool skipPCSubtitleAfterResponseMenu;

			public float subtitleCharsPerSecond;

			public float minSubtitleSeconds;

			public ContinueButtonMode continueButton;

			public bool richTextEmphases;

			public bool informSequenceStartAndEnd;
		}

		[Serializable]
		public class CameraSettings
		{
			public Camera sequencerCamera;

			public GameObject alternateCameraObject;

			public GameObject cameraAngles;

			[TextArea]
			public string defaultSequence;

			[TextArea]
			public string defaultPlayerSequence;

			[TextArea]
			public string defaultResponseMenuSequence;

			public EntrytagFormat entrytagFormat;

			[HideInInspector]
			public bool disableInternalSequencerCommands;
		}

		[Serializable]
		public class InputSettings
		{
			public bool alwaysForceResponseMenu;

			public bool includeInvalidEntries;

			public float responseTimeout;

			public ResponseTimeoutAction responseTimeoutAction;

			public EmTag emTagForOldResponses;

			public EmTag emTagForInvalidResponses;

			public string[] qteButtons;

			public InputTrigger cancel;

			public InputTrigger cancelConversation;
		}

		[Serializable]
		public class BarkSettings
		{
			public bool allowBarksDuringConversations;

			public float barkCharsPerSecond;

			public float minBarkSeconds;
		}

		[Serializable]
		public class AlertSettings
		{
			public bool allowAlertsDuringConversations;

			public float alertCheckFrequency;

			public float alertCharsPerSecond;

			public float minAlertSeconds;
		}

		[HideInInspector]
		public ConversationOverrideDisplaySettings conversationOverrideSettings;

		public GameObject dialogueUI;

		public LocalizationSettings localizationSettings;

		public SubtitleSettings subtitleSettings;

		public CameraSettings cameraSettings;

		public InputSettings inputSettings;

		public BarkSettings barkSettings;

		public AlertSettings alertSettings;

		public bool ShouldUseOverrides()
		{
			return false;
		}

		public bool ShouldUseSubtitleOverrides()
		{
			return false;
		}

		public bool GetShowNPCSubtitlesDuringLine()
		{
			return false;
		}

		public bool GetShowNPCSubtitlesWithResponses()
		{
			return false;
		}

		public bool GetShowPCSubtitlesDuringLine()
		{
			return false;
		}

		public bool GetSkipPCSubtitleAfterResponseMenu()
		{
			return false;
		}

		public float GetSubtitleCharsPerSecond()
		{
			return 0f;
		}

		public float GetMinSubtitleSeconds()
		{
			return 0f;
		}

		public SubtitleSettings.ContinueButtonMode GetContinueButtonMode()
		{
			return default(SubtitleSettings.ContinueButtonMode);
		}

		public bool ShouldUseSequenceOverrides()
		{
			return false;
		}

		public string GetDefaultSequence()
		{
			return null;
		}

		public string GetDefaultPlayerSequence()
		{
			return null;
		}

		public string GetDefaultResponseMenuSequence()
		{
			return null;
		}

		public bool ShouldUseInputOverrides()
		{
			return false;
		}

		public bool GetAlwaysForceResponseMenu()
		{
			return false;
		}

		public bool GetIncludeInvalidEntries()
		{
			return false;
		}

		public float GetResponseTimeout()
		{
			return 0f;
		}
	}
}
