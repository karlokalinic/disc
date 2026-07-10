using System.Collections.Generic;
using System.Text;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Articy;

namespace FeldMigration
{
	public class FeldMigration
	{
		public class ConvertedConversationObject
		{
			public FeldFlow feldFlow;

			public Conversation conversation;
		}

		public class ConvertedDialogueEntryObject
		{
			public FeldCard feldCard;

			public CardConverter.CardType entryType;

			public DialogueEntry dialogueEntry;
		}

		private enum PinType
		{
			Input = 0,
			Output = 1,
			Both = 2
		}

		public static string parentFlowId;

		public static string parentOrbsFlowId;

		public static string parentTasksFlowId;

		public static string parentFlowsFlowId;

		public static string parentFCEFlowsFlowId;

		public static string groupFlowIdBase;

		public static string emptyArticyReferenceId;

		public static string parentFlowStartCardIdFormat;

		public static string parentFlowEndCardIdFormat;

		public static string projectConfigurationFileName;

		private static bool logToConsole;

		private static StringBuilder stringBuilder;

		private static Dictionary<string, string> replaceExpressionsFunctionsPrefixesMap;

		private static Dictionary<string, string> replaceExpressionsParametersPrefixesMap;

		private static HashSet<string> ComparingFunctionsNames;

		private static Dictionary<string, string> OperatorsDict;

		private const string HookExpressionFormat = "{0}({1})";

		public const int CardsSpacing = 100;

		public const string ArticyIdFieldTitle = "Articy Id";

		public const string ParentFlowName = "Disco Elysium: Final Cut";

		public const string ParentOrbsFlowName = "Orbs";

		public const string ParentTasksFlowName = "Tasks";

		public const string ParentFlowsFlowName = "Flows";

		public static DialogueDatabase database;

		public static Dictionary<string, FeldEntity> convertedFeldEntities;

		public static Dictionary<string, FeldVariablesGroupObject> convertedVariablesGroups;

		public static Dictionary<string, ConvertedConversationObject> convertedAllFlows;

		public static Dictionary<string, ConvertedDialogueEntryObject> convertedAllCards;

		public static Dictionary<string, List<FeldCard>> convertedFeldCards;

		internal static FeldMeta MetaData;

		internal static FeldMeta ExtendedMetaData;

		internal static FeldProject exportProjectConfiguration;

		private static string name;

		private static string email;

		private static string group;

		private static string project;

		private static string data_version;

		private static float canvasPositionScale;

		private static long cachedTimestamp;

		private static bool saveExportToFile;

		private static bool useRealTimestamp;

		private static FeldFlow parentFlow;

		private static FeldFlow parentOrbsFlow;

		private static FeldFlow parentTasksFlow;

		private static FeldFlow parentFlowsFlow;

		private static Dictionary<string, List<string>> groupedOrbs;

		private static Dictionary<string, List<string>> groupedFlows;

		public static Template template;

		public static FeldProject loadedProjectConfiguration;

		public static List<FeldObject> loadedFeldEntities;

		public static Dictionary<string, FeldEntity> loadedFeldEntitiesDict;

		private static List<string> fullVariableNames;

		public static List<FeldVariablesGroupObject> loadedFeldVariablesGroups;

		public static List<FeldFlow> loadedFeldFlows;

		public static Dictionary<string, FeldCard> loadedFlowCards;

		public static Dictionary<FeldFlow, List<FeldCard>> loadedFeldCardsDict;

		public static Dictionary<string, ConvertedDialogueEntryObject> dialogueEntriesDict;

		public static List<Item> importedItemsList;

		public static List<Actor> importedActorsList;

		public static List<Variable> importedVariablesList;

		public static List<Conversation> importedConversationsList;

		private static List<DialogueEntry> jumpsToProcess;

		private static List<DialogueEntry> unusedOutputEntries;

		private static Dictionary<string, ConvertedConversationObject> importedConversationsDict;

		private static int currentVariableId;

		private static int currentActorId;

		private static int currentItemId;

		private static int conversationID;

		private static string importProjectPath;

		private static Dictionary<Conversation, int> conversationLastEntryID;

		private static readonly string LATEST_CACHE_VERSION;

		private const string AVOID_PARSING_BY_DIALOGUE_SYSTEM_STRING = "--[[ Variable[ ]]";

		private const string SET_VARIABLE_METHOD = "SetVariableValue";

		private const string VARIABLE_LUA_TABLE = "Variable";

		private const string SETTINGS_DIRECTORY = "Settings";

		public static readonly List<string> UNCONVERTABLE_FIELD_NAMES;

		private static Dictionary<string, List<string>> variables;

		private static int shortestVariableLength;

		private static SortedDictionary<string, string> oldCache;

		private static SortedDictionary<string, string> newCache;

		private const string CACHE_FILE_NAME = "XmlImportCache";

		private const string CACHE_FILE_EXTENSION = ".json";

		public static string ItemsCollectionName => null;

		public static string ActorsCollectionName => null;

		public static ConverterPrefs CreateImportSettings(string projectPath = "FeldMigration")
		{
			return null;
		}

		public static string GetArticyId(Asset asset)
		{
			return null;
		}

		public static string GetArticyId(DialogueEntry entry)
		{
			return null;
		}

		public static string GetArticyId(Conversation conversation)
		{
			return null;
		}

		public static string GetFormattedArticyId(string articyId)
		{
			return null;
		}

		public static string GetShardFromId(string id, FeldProject conf)
		{
			return null;
		}

		public static string GetConcatenatedArguments(string[] args)
		{
			return null;
		}

		public static string RemoveFeldPrefixes(string expression)
		{
			return null;
		}

		public static string AddParametersApostrophes(string expression)
		{
			return null;
		}

		public static string GetInputExpressionFromHook(HookData hook)
		{
			return null;
		}

		public static string GetFormattedInputExpressionFromHook(HookData hook)
		{
			return null;
		}

		public static string GetCardExpressionFromHook(HookData hook)
		{
			return null;
		}

		public static string GetOutputExpressionFromHook(HookData hook)
		{
			return null;
		}

		private static void LogToConsole(string text)
		{
		}

		public static void ExportDialogueDatabaseToFeld(DialogueDatabase dialogueDatabase)
		{
		}

		public static void ExportVariablesData(bool saveToFile)
		{
		}

		private static FeldVariablesGroupObject CreateVariablesGroup(string name)
		{
			return null;
		}

		private static FeldVariablesSubgroupObject GetFlagsSubgroup(FeldVariablesGroupObject variablesGroup)
		{
			return null;
		}

		private static FeldVariablesSubgroupObject GetCountersSubgroup(FeldVariablesGroupObject variablesGroup)
		{
			return null;
		}

		public static void ExportActorsData(bool saveToFile)
		{
		}

		public static void ExportItemsData(bool saveToFile)
		{
		}

		public static void ExportDialoguesData(bool saveToFile, int startIndex = 0, int batchSize = -1)
		{
		}

		private static void ExportDialogues(int startIndex = 0, int batchSize = -1)
		{
		}

		public static void ResetExportStacks()
		{
		}

		private static void CreateParentFlows()
		{
		}

		private static void CreateInitialCards(FeldFlow parentFlow)
		{
		}

		private static FeldCard CreateStartCard(FeldFlow parentFlow)
		{
			return null;
		}

		private static FeldCard CreateEndCard(FeldFlow parentFlow)
		{
			return null;
		}

		private static void ConvertConversations(int startIndex = 0, int batchSize = -1)
		{
		}

		private static void CreateConversationsSubflows()
		{
		}

		private static List<string> CreateGroupsFlows(Dictionary<string, List<string>> groupedFlows, FeldFlow parentFlow, ref int lastSubflowIndex)
		{
			return null;
		}

		private static void AddToFlowsGroups(ConvertedConversationObject convertedFlow, Dictionary<string, List<string>> groupedFlows)
		{
		}

		private static void SortConversationsSubflows()
		{
		}

		private static void SortConversationsSubflows(FeldFlow flow)
		{
		}

		private static void PositionStartAndEndNodes()
		{
		}

		private static void PositionInitialNodes(FeldFlow flow)
		{
		}

		private static void ConvertDialogueEntries()
		{
		}

		private static Dictionary<string, ConvertedDialogueEntryObject> ConvertEntriesToCards(List<DialogueEntry> entries, FeldFlow flow, Conversation conversation, out FeldCard endCard)
		{
			endCard = null;
			return null;
		}

		private static FeldCard GenerateEndCard(DialogueEntry entry, FeldFlow flow, Dictionary<string, ConvertedDialogueEntryObject> convertedConversationCards)
		{
			return null;
		}

		private static void AddEdges(Dictionary<string, ConvertedDialogueEntryObject> convertedConversationCards, FeldCard endCard)
		{
		}

		private static void AddDialogueFragmentEdges(FeldCard feldCard, DialogueEntry entry, Dictionary<string, ConvertedDialogueEntryObject> convertedConversationCards)
		{
		}

		private static void AddForkEdges(FeldCard feldCard, DialogueEntry entry, Dictionary<string, ConvertedDialogueEntryObject> convertedConversationCards)
		{
		}

		private static void AddJumpReference(FeldCard feldCard, DialogueEntry entry)
		{
		}

		private static void SaveProjectToFile()
		{
		}

		private static void SaveFlowsToFiles()
		{
		}

		private static void SaveFlowToFile(FeldFlow flow)
		{
		}

		private static void SaveCardsToFiles()
		{
		}

		private static void SimpleSaveCardsToFiles()
		{
		}

		private static void SaveCardToFile(FeldCard card)
		{
		}

		private static bool IsConnectedToEndCard(DialogueEntry entry)
		{
			return false;
		}

		private static void GenerateMetaData()
		{
		}

		public static DialogueDatabase ImportDatabase(string feldProjectPath = null)
		{
			return null;
		}

		private static void FixMissingEdges()
		{
		}

		public static void ConvertVariables()
		{
		}

		public static void ConvertEntities()
		{
		}

		public static void ConvertDialogues()
		{
		}

		public static DialogueDatabase PrepareDialogueDatabase()
		{
			return null;
		}

		public static void ResetImportStacks()
		{
		}

		private static void LoadFeldElements()
		{
		}

		private static List<FeldFlow> LoadFeldFlowFromPath(string flowsPath, string graphsPath)
		{
			return null;
		}

		private static List<FeldVariablesGroupObject> LoadFeldVariablesGroupsFromPath(string variablesPath)
		{
			return null;
		}

		private static List<FeldObject> LoadFeldEntitiesFromPath(string entitiesPath)
		{
			return null;
		}

		private static List<FeldCard> LoadSimpleFeldCardsAtPath(string cardsPath)
		{
			return null;
		}

		private static void ConvertDialoguesToConversations()
		{
		}

		private static void ProcessHierarchy()
		{
		}

		private static void RemoveTempFields()
		{
		}

		private static void ProcessDialogueEntries()
		{
		}

		private static void AddStartEntry(Conversation conversation)
		{
		}

		public static int GetNextConversationEntryID(Conversation conversation)
		{
			return 0;
		}

		private static void ProcessConnections()
		{
		}

		private static void ProcessStartConnections()
		{
		}

		private static void ProcessDialogueEntriesConnections()
		{
		}

		private static void ProcessJumpConnection(FeldCard card, DialogueEntry entry)
		{
		}

		private static void ProcessForkConnection(FeldCard card, DialogueEntry entry)
		{
		}

		private static void ProcessDialogueEntryConnection(FeldCard card, DialogueEntry entry)
		{
		}

		private static void AddLink(DialogueEntry fromEntry, DialogueEntry destinationEntry)
		{
		}

		private static void RecordLink(DialogueEntry fromEntry, string destinedArticyId, PinType pinType)
		{
		}

		private static void MarkTargetUsed(DialogueEntry entry)
		{
		}

		private static void RemoveUnusedOutputEntries()
		{
		}

		private static void RemoveParentConversations()
		{
		}

		private static void RemoveEndEntries()
		{
		}

		private static void CheckJumpsForGroupNodes()
		{
		}

		private static void AssignActorToEntry(DialogueEntry entry, FeldCard card, Conversation conversation)
		{
		}

		private static void AssignConversantToEntry(DialogueEntry entry, FeldCard card, Conversation conversation)
		{
		}

		private static void SortAllLinksByPosition()
		{
		}

		private static void SortLinksByPosition(Conversation conversation)
		{
		}

		private static List<FeldCard> LoadShardedFeldCardsAtPath(string cardsPath, string flow)
		{
			return null;
		}

		public static List<FeldCard> GetFeldCardsFromShard(string shardJson, string flow)
		{
			return null;
		}

		private static List<string> GetJsonCardsFromShard(string shardJson, string flow)
		{
			return null;
		}

		private static string ExtractCardIdFromShardLine(string shardLine, string flow)
		{
			return null;
		}

		private static bool IsNewCardLine(string shardLine, string flow)
		{
			return false;
		}

		private static List<FeldCard> ConvertJsonCardsToFeldCards(List<string> jsonCards)
		{
			return null;
		}

		private static void ShardSaveCardsToFiles()
		{
		}

		public static Dictionary<string, Dictionary<string, string>> GetFlowsShardsJson(Dictionary<string, ConvertedDialogueEntryObject> convertedCards)
		{
			return null;
		}

		private static Dictionary<string, Dictionary<string, List<FeldCard>>> GetFlowsShardsDict(Dictionary<string, ConvertedDialogueEntryObject> convertedCards)
		{
			return null;
		}

		private static Dictionary<string, string> GetShardsJsons(Dictionary<string, List<FeldCard>> shardsCardsDict)
		{
			return null;
		}

		private static string GetShardJson(List<FeldCard> feldCards)
		{
			return null;
		}

		public static void InitializeExpressionsConverter()
		{
		}

		private static void InitializeVariables(List<FeldVariablesGroupObject> variableSets)
		{
		}

		private static void AddDistinctToDictionary<K, V>(K key, V value, IDictionary<K, List<V>> dictionary)
		{
		}

		private static void ResetArticyConverterVariables()
		{
		}

		private static void DeleteCacheIfExpired()
		{
		}

		public static string ParseExpression(string expression)
		{
			return null;
		}

		private static string PrepareForArticyConverterAndConvert(string expression)
		{
			return null;
		}

		private static string DoVariableReplacements(string expression, string variable)
		{
			return null;
		}

		private static bool IsTokenQuoted(string value, string token, int index)
		{
			return false;
		}

		private static void InitializeVariables(Dictionary<string, ArticyData.VariableSet> variableSets)
		{
		}

		public static void FinalizeConverter()
		{
		}

		private static string GetCurrentVersionCacheFileName()
		{
			return null;
		}

		public static void ReplaceVariableReferencesInFieldsProperties(List<Field> fields)
		{
		}
	}
}
