using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

namespace FeldMigration
{
	public class CardConverter : MonoBehaviour
	{
		public enum FragmentType
		{
			Regular = 0,
			WhiteCheck = 1,
			RedCheck = 2,
			AtmosphericCheck = 3,
			PassiveCheck = 4,
			AntiPassiveCheck = 5,
			JanusNode = 6,
			KimWatch = 7,
			MoneyOption = 8,
			TestOption = 9,
			NodeWithTutorial = 10
		}

		public enum CardType
		{
			Start = 0,
			End = 1,
			DialogueFragment = 2,
			Instruction = 3,
			Hub = 4,
			Jump = 5,
			Fork = 6,
			Omit = 7,
			Flow = 8
		}

		private static Dictionary<string, string> antiPassiveCheckFieldsExportMap;

		private static Dictionary<string, string> atmosphericCheckFieldsExportMap;

		private static Dictionary<string, string> JanusNodeFieldsExportMap;

		private static Dictionary<string, string> janusAlternativesExportMap;

		private static Dictionary<string, string> kimWatchFieldsExportMap;

		private static Dictionary<string, string> moneyOptionFieldsExportMap;

		private static Dictionary<string, string> nodeWithTutorialFieldsExportMap;

		private static Dictionary<string, string> passiveCheckFieldsExportMap;

		private static Dictionary<string, string> redCheckFieldsExportMap;

		private static Dictionary<string, string> modifiersImportMap;

		private static Dictionary<string, string> testOptionFieldsExportMap;

		private static Dictionary<string, string> whiteCheckFieldsExportMap;

		public const int FlowNodeWidth = 295;

		public const int FlowNodeHeight = 189;

		public const int StartEndNodesWidth = 100;

		public const int StartEndNodesHeight = 50;

		private static List<EdgeData> tempFromEdgeList;

		private static List<EdgeData> tempToEdgeList;

		private static HashSet<string> FieldsToExportIgnore;

		private static Dictionary<string, string> EntryToCardFieldNameMap;

		public static HashSet<string> FieldsToFlowExportIgnore;

		public static Dictionary<string, string> ConversationToFlowFieldNameMap;

		private static Dictionary<int, string> ThresholdToStringDict;

		private static Dictionary<int, string> EntityColorToStringDict;

		private static Dictionary<string, string> antiPassiveCheckFieldsImportMap;

		private static Dictionary<string, string> atmosphericCheckFieldsImportMap;

		private static Dictionary<string, string> janusNodeFieldsImportMap;

		private static Dictionary<string, string> janusAlternativesImportMap;

		private static Dictionary<string, string> kimWatchFieldsImportMap;

		private static Dictionary<string, string> moneyOptionFieldsImportMap;

		private static Dictionary<string, string> nodeWithTutorialFieldsImportMap;

		private static Dictionary<string, string> passiveCheckFieldsImportMap;

		private static Dictionary<string, string> redCheckFieldsImportMap;

		private static string nameVariableFormat;

		private static Dictionary<string, string> testOptionFieldsImportMap;

		private static Dictionary<string, string> whiteCheckFieldsImportMap;

		public const string DataNameFieldName = "name";

		public const string DataLabelFieldName = "label";

		public const string DataChildTypeFieldName = "child_type";

		public const string FlowActorFieldName = "actor";

		public const string FlowActorAdditionalFieldName = "_actor_text";

		public const string FlowConversantFieldName = "conversant";

		public const string FlowConversantAdditionalFieldName = "_conversant_text";

		public const string DataDescriptionFieldName = "description";

		public const string DataFlowTitleFieldName = "flow_title";

		public const string DataPlaceholderFieldName = "placeholder_text";

		public const string DataNodeReferenceName = "node_reference";

		public const string DataDialogLinesName = "dialog_lines";

		public const string ForkConditionFieldName = "fork_condition";

		public const string InstructionExpressionFieldName = "expression";

		public const string EntryCardTypeName = "DialogueEntryType";

		public const string EntryUserScriptTrueName = "user_script_true";

		public const string EntryUserScriptFalseName = "user_script_false";

		public const string EntryUserScriptName = "user_script";

		public const string EntryConditionsStringName = "condition";

		public const string DataEntityFilterFieldName = "entity_filter";

		public const string DataEntityAnnotationFieldName = "annotation_text";

		private static HashSet<string> FieldsToImportIgnore;

		private static Dictionary<string, string> CardToEntryFieldNameMap;

		private static HashSet<string> ExpressionsToIgnore;

		private static string antiPassiveThresholdTextFieldName => null;

		public static string identityAntiPassiveCheckFieldName => null;

		public static string antiPassiveCheckAdditionalFieldName => null;

		private static string atmosphericCheckSkillTextFieldName => null;

		private static string atmosphericCheckThresholdTextFieldName => null;

		private static string atmosphericCheckCharacterTextFieldName => null;

		private static string atmosphericCheckFlagTextFieldName => null;

		private static string identityAtmosphericCheckFieldName => null;

		private static string identityJanusNodeFieldName => null;

		public static string identityKimWatchFieldName => null;

		public static string identityMoneyOptionFieldName => null;

		public static string nodeWithTutorialColorTextFieldName => null;

		public static string identityNodeWithTutorialFieldName => null;

		private static string passiveThresholdTextFieldName => null;

		private static string identityPassiveCheckFieldName => null;

		private static string redCheckSkillTextFieldName => null;

		private static string redCheckThresholdTextFieldName => null;

		private static string redCheckCharacterTextFieldName => null;

		private static string redCheckFlagTextFieldName => null;

		private static string identityRedCheckFieldName => null;

		public static string identityTestOptionFieldName => null;

		private static string whiteCheckSkillTextFieldName => null;

		private static string whiteCheckThresholdTextFieldName => null;

		private static string whiteCheckCharacterTextFieldName => null;

		private static string whiteCheckFlagTextFieldName => null;

		private static string identityWhiteCheckFieldName => null;

		private static bool IsAntiPassiveCheckFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToAntiPassiveCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static bool IsAtmosphericCheckFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToAtmosphericCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static void AddAdditionalFeldAtmosphericCheckFields(FeldCard feldCard)
		{
		}

		private static bool IsJanusNodeFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToJanusNodeTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static GraphData CreateAlternate(string condition, string dialog_lines)
		{
			return null;
		}

		private static bool IsKimWatchFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToKimWatchTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static bool IsMoneyOptionFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToMoneyOptionTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static bool IsNodeWithTutorialFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToNodeWithTutorialTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static void AddAdditionalFeldNodeWithTutorialFields(FeldCard feldCard)
		{
		}

		private static bool IsPassiveCheckFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToPassiveCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static bool IsRedCheckFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToRedCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static void AddAdditionalFeldRedCheckFields(FeldCard feldCard)
		{
		}

		public static void ApplyExportToTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		public static FragmentType GetDialogueFragmentType(DialogueEntry entry)
		{
			return default(FragmentType);
		}

		public static void AssignActorToCard(FeldCard card, DialogueEntry entry)
		{
		}

		private static GraphData CreateModifier(string bonus, string condition, string explanation)
		{
			return null;
		}

		private static bool IsTestOptionFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToTestOptionTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static bool IsWhiteCheckFragment(DialogueEntry entry)
		{
			return false;
		}

		private static void ApplyExportToWhiteCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static void AddAdditionalWhiteCheckFeldFields(FeldCard feldCard)
		{
		}

		private static void AddAdditionalEntityNameField(FeldCard feldCard, string fieldName, string additionalFieldName)
		{
		}

		private static void AssignCheckTargetActorToCard(FeldCard feldCard, DialogueEntry entry, Conversation conversation)
		{
		}

		private static string GetThresholdString(string variable)
		{
			return null;
		}

		private static void ReplaceEntityPrefixedNameWithId(DialogueEntry entry, string fieldName)
		{
		}

		private static string GetEntityColorString(string variable)
		{
			return null;
		}

		public static CardType GetEntryType(DialogueEntry entry)
		{
			return default(CardType);
		}

		public static void ExportFieldsToCard(DialogueEntry dialogueEntry, FeldCard feldCard)
		{
		}

		public static FeldCard ToFeld(DialogueEntry entry, FeldFlow flow, Conversation conversation)
		{
			return null;
		}

		public static FeldCard ToFeldFlowCard(FeldFlow flow, FeldFlow parentFlow, Conversation conversation)
		{
			return null;
		}

		public static void ExportFieldsToFlowCard(FeldCard feldCard, Conversation conversation)
		{
		}

		public static void AddDefaultEdge(FeldCard fromCard, FeldCard toCard, string edgeColor = null)
		{
		}

		public static void AddForkEdge(FeldCard fromCard, FeldCard toCard, bool isPassPin, string edgeColor = null)
		{
		}

		private static FeldCard ToCardStartNode(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		public static FeldCard ToCardEndNode(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		private static FeldCard ToHubCard(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		public static FeldCard ToForkCard(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		private static FeldCard ToJumpCard(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		private static FeldCard ToDialogueFragmentCard(DialogueEntry entry, FeldFlow flow, Conversation conversation)
		{
			return null;
		}

		private static FeldCard ToInstructionCard(DialogueEntry entry, FeldFlow flow)
		{
			return null;
		}

		private static void PrepareImportAntiPassiveCheckCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportAntiPassiveCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportAtmosphericCheckCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportAtmosphericCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportJanusNodeCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportJanusNodeTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportKimWatchCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportKimWatchTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportMoneyOptionCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportMoneyOptionTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportNodeWithTutorialCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportNodeWithTutorialTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportPassiveCheckCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportPassiveCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportRedCheckCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportRedCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		public static void PrepareImportToTemplate(List<FeldCard> loadedFeldCards, int index)
		{
		}

		public static void ApplyImportToTemplate(DialogueEntry entry, FeldCard feldCard, Conversation conversation, Template template)
		{
		}

		public static FragmentType GetFeldCardFragmentType(FeldCard feldCard)
		{
			return default(FragmentType);
		}

		private static void PrepareImportTestOptionCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportTestOptionTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		private static void PrepareImportWhiteCheckCard(FeldCard sourceCard, List<FeldCard> loadedFeldCards, int index)
		{
		}

		private static void ApplyImportWhiteCheckTemplate(FeldCard feldCard, DialogueEntry entry, Conversation conversation, Template template)
		{
		}

		public static DialogueEntry ToDialogueSystem(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		public static CardType GetCardType(FeldCard feldCard)
		{
			return default(CardType);
		}

		public static void ImportFieldsToEntry(DialogueEntry dialogueEntry, FeldCard feldCard)
		{
		}

		private static DialogueEntry ToStartEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static DialogueEntry ToEndEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static DialogueEntry ToHubEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		public static DialogueEntry ToForkEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static DialogueEntry ToJumpEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static DialogueEntry ToDialogueFragmentEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static DialogueEntry ToInstructionEntry(FeldCard feldCard, Conversation conversation, Template template)
		{
			return null;
		}

		private static void AppendExpressions(DialogueEntry entry, FeldCard feldCard)
		{
		}

		private static void AppendForkExpressions(DialogueEntry mainEntry, DialogueEntry trueEntry, DialogueEntry falseEntry, FeldCard feldCard)
		{
		}

		private static void AppendInputExpressions(DialogueEntry entry, FeldCard feldCard)
		{
		}

		private static void AppendCardExpressions(DialogueEntry entry, FeldCard feldCard)
		{
		}

		private static void AppendOutputExpressions(DialogueEntry entry, FeldCard feldCard, string outputLabel = "")
		{
		}
	}
}
