using System.Collections.Generic;
using System.Text;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	public static class Articy_2_2_Tools
	{
		public static bool IsSchema(string xmlFilename)
		{
			return false;
		}

		public static ArticyData LoadArticyDataFromXmlData(string xmlData, Encoding encoding)
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

		public static ArticyData ConvertExportToArticyData(ExportType export)
		{
			return null;
		}

		private static void ConvertProject(ArticyData articyData, ProjectType project)
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

		private static string GetPictureFilename(ExportType export, PreviewImageType previewImage)
		{
			return null;
		}

		private static void ConvertHierarchy(ArticyData articyData, HierarchyType hierarchy)
		{
		}

		private static ArticyData.Node ConvertNode(NodeType node)
		{
			return null;
		}

		private static ArticyData.NodeType ConvertNodeType(string nodeType)
		{
			return default(ArticyData.NodeType);
		}
	}
}
