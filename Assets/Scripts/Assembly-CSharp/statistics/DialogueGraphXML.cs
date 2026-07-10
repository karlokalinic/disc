using System.Collections.Generic;
using System.Xml;

namespace statistics
{
	public static class DialogueGraphXML
	{
		private static int edgeCounter;

		private static Dictionary<int, List<int>> trackedNodes;

		private static List<string> preConditions;

		private static List<string> postConditions;

		public static void Do()
		{
		}

		private static XmlDocument CreateDocumentDeclaration()
		{
			return null;
		}

		private static XmlNode CreateGraphNode(XmlDocument xmlDoc)
		{
			return null;
		}

		private static void CreateGraph(XmlDocument xmlDoc, XmlNode graphNode)
		{
		}

		private static void BacktrackNode(DialogueGraph.Node currentEndNode, XmlDocument xmlDoc, XmlNode nodesNode, XmlNode edgesNode)
		{
		}

		private static XmlNode AddNode(XmlDocument xmlDoc, DialogueGraph.Node dialogue)
		{
			return null;
		}

		private static XmlNode AddEdge(XmlDocument xmlDoc, DialogueGraph.Node start, DialogueGraph.Node end)
		{
			return null;
		}

		private static string CreateNodeId(int conversationId, int dialogueEntryId)
		{
			return null;
		}
	}
}
