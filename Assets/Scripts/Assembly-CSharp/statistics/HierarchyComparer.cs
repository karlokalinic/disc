using System.Collections.Generic;
using PixelCrushers.DialogueSystem.Articy;

namespace statistics
{
	public static class HierarchyComparer
	{
		private static ArticyData ARTICY_DATA_1;

		private static ArticyData ARTICY_DATA_2;

		private const string UNKNOWN_HEADER = "[unknown]";

		public static void CompareHierarchy(ArticyData articyData1, ArticyData articyData2)
		{
		}

		private static void CompareSubnodes(ArticyData.Node node1, ArticyData.Node node2, List<string> path)
		{
		}

		private static void CompareNodeObjects(ArticyData.Node subnode1, ArticyData.Node subnode2, List<string> path)
		{
		}

		private static bool AddNodeToPath(List<string> path, ArticyData.Node node1, ArticyData.Node node2)
		{
			return false;
		}

		private static string GetNodeObjectName(ArticyData articyData, ArticyData.Node node)
		{
			return null;
		}

		private static bool ValidateNodeEquality(ArticyData.Node node1, ArticyData.Node node2)
		{
			return false;
		}

		private static List<string> ConvertMissingElements(List<string> identifiers, Dictionary<string, ArticyData.Node> nodeMap, ArticyData articyData)
		{
			return null;
		}
	}
}
