using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

namespace VOTool
{
	public class VoiceOverSystem
	{
		public const string VOICEOVER_SEQUENCE_COMMAND = "VoiceoverPlay";

		private const string SETTINGS_TAG = "VoiceOverMode";

		private const string ARTICY_FIELD_NAME_FOR_CLASSIC_MODE = "AlwaysPlayVoice";

		private const string ARTICY_FIELD_NAME_FOR_ACTIVE_IN_PSYCHOLOGICAL = "PlayVoiceInPsychologicalMode";

		private static VoiceOverSystem _instance;

		public static readonly HashSet<string> NarratorCharacters;

		public static bool HARDCODED_DISABLE_OLD_VO => false;

		public static bool ENABLE_VOICE_OVER_ON_BARKS => false;

		private static VoiceOverSystem Instance => null;

		public static VoiceOverModeOption.VOMode VoiceOverMode { get; private set; }

		private VoiceOverModeOption.VOMode LoadVoiceOverMode()
		{
			return default(VoiceOverModeOption.VOMode);
		}

		public static void SetVoMode(VoiceOverModeOption.VOMode voMode)
		{
		}

		public static bool CheckIfCanPlayBasedOnVOMode(DialogueEntry entry)
		{
			return false;
		}

		public static bool IsNarratorType(string actorName)
		{
			return false;
		}

		public static bool TextIsNarratorNPC(string text)
		{
			return false;
		}
	}
}
