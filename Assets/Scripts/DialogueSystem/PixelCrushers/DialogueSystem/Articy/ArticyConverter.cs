using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Articy
{
	public class ArticyConverter
	{
		public delegate void ProgressCallbackDelegate(string info, float progress);

		public const string DialogueEntryTypeName = "DialogueEntryType";

		public static bool ConvertExpressionsFlag;

		private const string ArticyIdFieldTitle = "Articy Id";

		private const string ArticyTechnicalNameFieldTitle = "Technical Name";

		private const string DestinationArticyIdFieldTitle = "destinationArticyId";

		private const int StartEntryID = 0;

		private ArticyData articyData;

		private ConverterPrefs prefs;

		private DialogueDatabase database;

		private Template template;

		private int conversationID;

		private int actorID;

		private int itemID;

		private int locationID;

		private static List<string> fullVariableNames;

		private HashSet<string> otherScriptFieldTitles;

		private List<string> flowFragmentNameStack;

		private List<Conversation> conversationStack;

		private Dictionary<Conversation, int> conversationLastEntryID;

		private Dictionary<string, List<DialogueEntry>> entriesByArticyId;

		private Dictionary<string, DialogueEntry> entriesByPinID;

		private Dictionary<ArticyData.Jump, DialogueEntry> jumpsToProcess;

		private List<DialogueEntry> unusedOutputEntries;

		private const int MaxRecursionDepth = 1000;

		public static event ProgressCallbackDelegate onProgressCallback
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

		public static DialogueDatabase ConvertXmlDataToDatabase(string xmlData, ConverterPrefs prefs = null, Template template = null)
		{
			return null;
		}

		public static void ConvertArticyDataToDatabase(ArticyData articyData, ConverterPrefs prefs, Template template, DialogueDatabase database)
		{
		}

		private void ResetStacks()
		{
		}

		private void PushFlowFragment(ArticyData.FlowFragment flowFragment)
		{
		}

		private void PopFlowFragment()
		{
		}

		private void PushConversation(Conversation conversation)
		{
		}

		private void PopConversation()
		{
		}

		private Conversation GetConversationStackTop()
		{
			return null;
		}

		private int GetNextConversationEntryID(Conversation conversation)
		{
			return 0;
		}

		private void ResetArticyIdIndex()
		{
		}

		private void IndexDialogueEntryByArticyId(DialogueEntry entry, string articyId)
		{
		}

		public void Convert(ArticyData articyData, ConverterPrefs prefs, Template template, DialogueDatabase database)
		{
		}

		private void Setup(ArticyData articyData, ConverterPrefs prefs, Template template, DialogueDatabase database)
		{
		}

		private void ConvertProjectAttributes()
		{
		}

		private void ConvertEntities()
		{
		}

		private void ConvertLocations()
		{
		}

		private void ConvertFlowFragmentsToQuests()
		{
		}

		private void SetFeatureFields(List<Field> fields, ArticyData.Features features)
		{
		}

		private bool IsOtherScriptField(string fieldTitle)
		{
			return false;
		}

		private string ConvertSpecialTechnicalNames(string technicalName)
		{
			return null;
		}

		public static bool HasField(ArticyData.Features features, string fieldName, bool mustBeTrue)
		{
			return false;
		}

		private void ConvertVariables()
		{
		}

		private void ConvertDialogues()
		{
		}

		private bool IncludeDialogue(string dialogueId)
		{
			return false;
		}

		private void ConvertDialoguesToConversations()
		{
		}

		private Conversation CreateNewConversation(ArticyData.Dialogue articyDialogue)
		{
			return null;
		}

		private Conversation FindOrCreateFlowFragmentConversation(ArticyData.FlowFragment articyFlowFragment)
		{
			return null;
		}

		private void ProcessHierarchy()
		{
		}

		private void BuildDialogueEntriesFromNode(ArticyData.Node node, int recursionDepth)
		{
		}

		private void PrependFlowStackToConversationTitle(Conversation conversation)
		{
		}

		private void RecordPins(List<ArticyData.Pin> pins, DialogueEntry entry)
		{
		}

		private void RecordPin(ArticyData.Pin pin, DialogueEntry entry)
		{
		}

		private void ProcessConnections()
		{
		}

		private void ProcessConnectionNew(ArticyData.Connection connection)
		{
		}

		private void ProcessJumpConnection(ArticyData.Jump jump, DialogueEntry jumpEntry)
		{
		}

		private void MarkTargetUsed(DialogueEntry targetEntry)
		{
		}

		private void RemoveUnusedOutputEntries()
		{
		}

		private ArticyData.DialogueFragment LookupArticyDialogueFragment(string id)
		{
			return null;
		}

		private ArticyData.Hub LookupArticyHub(string id)
		{
			return null;
		}

		private ArticyData.Jump LookupArticyJump(string id)
		{
			return null;
		}

		private ArticyData.Condition LookupArticyCondition(string id)
		{
			return null;
		}

		private ArticyData.Instruction LookupArticyInstruction(string id)
		{
			return null;
		}

		private ArticyData.Connection LookupArticyConnection(string id)
		{
			return null;
		}

		private ArticyData.FlowFragment LookupArticyFlowFragment(string id)
		{
			return null;
		}

		private void BuildDialogueEntryFromDialogueFragment(Conversation conversation, ArticyData.DialogueFragment fragment)
		{
		}

		private bool DoesLinkExist(List<Link> outgoingLinks, DialogueEntry destination)
		{
			return false;
		}

		private void AddFlowFragmentAsDialogueEntry(Conversation conversation, ArticyData.FlowFragment flowFragment)
		{
		}

		private void BuildDialogueEntryFromHub(Conversation conversation, ArticyData.Hub hub)
		{
		}

		private void BuildDialogueEntryFromJump(Conversation conversation, ArticyData.Jump jump)
		{
		}

		private void CheckJumpsForGroupNodes()
		{
		}

		private void BuildDialogueEntriesFromCondition(Conversation conversation, ArticyData.Condition condition)
		{
		}

		private void BuildDialogueEntryFromInstruction(Conversation conversation, ArticyData.Instruction instruction)
		{
		}

		public static string AddToConditions(string conditions, string moreConditions)
		{
			return null;
		}

		public static string AddToUserScript(string script, string moreScript)
		{
			return null;
		}

		private DialogueEntry CreateNewDialogueEntry(Conversation conversation, string title, string articyId)
		{
			return null;
		}

		private void ConvertPinExpressionsToConditionsAndScripts(DialogueEntry entry, List<ArticyData.Pin> pins, bool convertInput = true, bool convertOutput = true)
		{
		}

		public static string ConvertExpression(string expression)
		{
			return null;
		}

		public static string ConvertSingleExpression(string expression)
		{
			return null;
		}

		private static string ConvertExpressionFragment(string expression)
		{
			return null;
		}

		private static bool ContainsArithmeticAssignment(string s)
		{
			return false;
		}

		private void ConvertLocalizableText(DialogueEntry entry, string baseFieldTitle, ArticyData.LocalizableText localizableText)
		{
		}

		private void ConvertLocalizableText(List<Field> fields, string baseFieldTitle, ArticyData.LocalizableText localizableText)
		{
		}

		private string RemoveFormattingTags(string s)
		{
			return null;
		}

		private static void SetConversationStartCutsceneToNone(Conversation conversation)
		{
		}

		private Conversation FindConversationByArticyId(string articyId)
		{
			return null;
		}

		private DialogueEntry FindDialogueEntryByArticyId(Conversation conversation, string articyId)
		{
			return null;
		}

		private DialogueEntry FindDialogueEntryByArticyId(string articyId)
		{
			return null;
		}

		private List<DialogueEntry> FindAllDialogueEntriesByArticyId(string articyId)
		{
			return null;
		}

		private ArticyData.FlowFragment FindFlowFragment(string articyId)
		{
			return null;
		}

		private Actor FindActorByArticyId(string articyId)
		{
			return null;
		}

		private Actor FindActorByTechnicalName(string technicalName)
		{
			return null;
		}

		private Actor FindActorByDisplayName(string displayName)
		{
			return null;
		}

		private int FindActorIdFromArticyDialogue(ArticyData.Dialogue articyDialogue, int index)
		{
			return 0;
		}

		private void SplitPipesIntoEntries()
		{
		}

		private void SortAllLinksByPosition()
		{
		}

		private void SortLinksByPosition(Conversation conversation)
		{
		}

		private void RedirectLinkbacksToStartToLinkOutFromStart()
		{
		}

		private bool DoesEntryLinkOutsideConversation(DialogueEntry entry)
		{
			return false;
		}

		private void ConvertVoiceOverProperties()
		{
		}

		private void ConvertVoiceOverProperty(DialogueEntry entry)
		{
		}

		private void FindPortraitTextureInResources(Actor actor)
		{
		}

		private Texture2D LoadTexture(string originalPath)
		{
			return null;
		}

		private void ConvertEmVarSet()
		{
		}

		private void ConvertEmVars(ArticyEmVars emVars, EmphasisSetting emSetting)
		{
		}

		private Variable GetEmVar(string variableName)
		{
			return null;
		}
	}
}
