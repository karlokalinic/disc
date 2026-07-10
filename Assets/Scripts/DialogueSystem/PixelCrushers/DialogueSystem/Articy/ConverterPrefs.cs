using System.Text;

namespace PixelCrushers.DialogueSystem.Articy
{
	public class ConverterPrefs
	{
		public enum FlowFragmentModes
		{
			NestedConversationGroups = 0,
			ConversationGroups = 1,
			Quests = 2,
			Ignore = 3
		}

		public enum StageDirModes
		{
			Sequences = 0,
			NotSequences = 1
		}

		public enum ConvertDropdownsModes
		{
			Ints = 0,
			Strings = 1
		}

		public enum ConvertSlotsModes
		{
			DisplayName = 0,
			ID = 1,
			TechnicalName = 2
		}

		public enum RecursionModes
		{
			Off = 0,
			On = 1
		}

		public ArticyEmVarSet emVarSet;

		public const string DefaultFlowFragmentScript = "OnFlowFragment";

		public const string DefaultVoiceOverProperty = "VoiceOverFile";

		public string ProjectFilename { get; set; }

		public string PortraitFolder { get; set; }

		public bool StageDirectionsAreSequences { get; set; }

		public FlowFragmentModes FlowFragmentMode { get; set; }

		public string OtherScriptFields { get; set; }

		public string DocumentsSubmenu { get; set; }

		public string TextTableDocument { get; set; }

		public string OutputFolder { get; set; }

		public bool Overwrite { get; set; }

		public ConversionSettings ConversionSettings { get; set; }

		public EncodingType EncodingType { get; set; }

		public RecursionModes RecursionMode { get; set; }

		public ConvertDropdownsModes ConvertDropdownsAs { get; set; }

		public ConvertSlotsModes ConvertSlotsAs { get; set; }

		public bool UseTechnicalNames { get; set; }

		public bool DirectConversationLinksToEntry1 { get; set; }

		public bool ConvertMarkupToRichText { get; set; }

		public bool SplitTextOnPipes { get; set; }

		public string FlowFragmentScript { get; set; }

		public string VoiceOverProperty { get; set; }

		public string LocalizationXlsx { get; set; }

		public Encoding Encoding => null;

		public bool ConvertDropdownsAsString => false;

		public void ReviewSpecialProperties(ArticyData articyData)
		{
		}
	}
}
