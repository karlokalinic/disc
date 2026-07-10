using System.Collections.Generic;
using System.Text;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	public static class Articy_2_4_Tools
	{
		private static bool _convertDropdownAsString;

		private static ConverterPrefs.ConvertSlotsModes _convertSlotsAs;

		private static ExportType _currentExport;

		private static ConverterPrefs _prefs;

		private static int documentDepth;

		public static bool IsSchema(string xmlFilename)
		{
			return false;
		}

		public static ArticyData LoadArticyDataFromXmlData(string xmlData, Encoding encoding, bool convertDropdownAsString = false, ConverterPrefs prefs = null)
		{
			return null;
		}

		public static ExportType LoadFromXmlData(string xmlData, Encoding encoding)
		{
			return null;
		}

		public static bool IsExportValid(ExportType export)
		{
			return false;
		}

		public static ArticyData ConvertExportToArticyData(ExportType export, bool convertDropdownAsString = false, ConverterPrefs prefs = null)
		{
			return null;
		}

		private static void ConvertProject(ArticyData articyData, ProjectType project)
		{
		}

		private static void ConvertAsset(ArticyData articyData, AssetType asset)
		{
		}

		private static void ConvertEntity(ArticyData articyData, EntityType entity, ExportType export)
		{
		}

		private static void ConvertLocation(ArticyData articyData, LocationType location)
		{
		}

		private static void ConvertFlowFragment(ArticyData articyData, FlowFragmentType flowFragment)
		{
		}

		private static void ConvertDocument(ArticyData articyData, DocumentType document)
		{
		}

		private static void ConvertDialogue(ArticyData articyData, DialogueType dialogue)
		{
		}

		private static void ConvertDialogueFragment(ArticyData articyData, DialogueFragmentType dialogueFragment)
		{
		}

		private static void ConvertHub(ArticyData articyData, HubType hub)
		{
		}

		private static void ConvertJump(ArticyData articyData, JumpType jump)
		{
		}

		private static void ConvertConnection(ArticyData articyData, ConnectionType connection)
		{
		}

		private static ArticyData.ConnectionRef ConvertConnectionRef(ConnectionRefType connectionRef)
		{
			return null;
		}

		private static void ConvertCondition(ArticyData articyData, ConditionType condition)
		{
		}

		private static void ConvertInstruction(ArticyData articyData, InstructionType instruction)
		{
		}

		private static void ConvertVariableSet(ArticyData articyData, VariableSetType variableSet)
		{
		}

		private static List<ArticyData.Variable> ConvertVariables(VariablesType variables)
		{
			return null;
		}

		private static ArticyData.VariableDataType ConvertDataType(VariableDataTypeType dataType)
		{
			return default(ArticyData.VariableDataType);
		}

		private static ArticyData.LocalizableText ConvertLocalizableText(LocalizableTextType localizableText)
		{
			return null;
		}

		private static ArticyData.LocalizableText ConvertLocalizableText(string s)
		{
			return null;
		}

		private static List<string> ConvertReferences(ReferencesType references)
		{
			return null;
		}

		private static string ConvertIdRef(ReferenceType reference)
		{
			return null;
		}

		private static List<ArticyData.Pin> ConvertPins(PinsType pins)
		{
			return null;
		}

		private static ArticyData.SemanticType ConvertSemanticType(SemanticType semanticType)
		{
			return default(ArticyData.SemanticType);
		}

		private static ArticyData.Features ConvertFeatures(FeaturesType features)
		{
			return null;
		}

		private static void ConvertItem(object item, List<Field> fields)
		{
		}

		private static string GetStripStringValue(ReferenceStripPropertyType stripPropertyType)
		{
			return null;
		}

		private static string GetEnumStringValue(string enumName, int enumIndex)
		{
			return null;
		}

		private static string GetTechnicalName(string idRef)
		{
			return null;
		}

		private static string GetDisplayName(string idRef)
		{
			return null;
		}

		private static string GetNameWithHierarchyPath(DialogueType item)
		{
			return null;
		}

		private static string GetNameWithHierarchyPathRecursion(DialogueType item, NodeType node, int safeguard)
		{
			return null;
		}

		private static string GetDefaultLocalizedString(LocalizableTextType localizableText)
		{
			return null;
		}

		private static string GetPictureFilename(ExportType export, PreviewImageType previewImage)
		{
			return null;
		}

		private static void ConvertHierarchy(ArticyData articyData, HierarchyType hierarchy)
		{
		}

		private static ArticyData.Node ConvertNode(ArticyData articyData, NodeType node)
		{
			return null;
		}

		private static ArticyData.NodeType ConvertNodeType(string nodeType)
		{
			return default(ArticyData.NodeType);
		}
	}
}
