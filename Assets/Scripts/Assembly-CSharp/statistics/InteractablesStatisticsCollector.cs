using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Articy;
using UnityEngine;

namespace statistics
{
	public static class InteractablesStatisticsCollector
	{
		private enum INTERACTABLE_TYPES
		{
			NONE = 0,
			NPC = 1,
			ITEM = 2,
			THOUGHT = 3
		}

		private const string INTERACTABLE_STATISTICS_FILENAME = "Interactables";

		private static Dictionary<string, Dictionary<Type, List<string>>> listOfInteractables;

		private static Dictionary<string, INTERACTABLE_TYPES> entityFeatures;

		public static void Do(DialogueDatabase ntwtfDD)
		{
		}

		private static void CollectObjectsFromArticy()
		{
		}

		private static INTERACTABLE_TYPES GetInteractableType(ArticyData.Entity entity)
		{
			return default(INTERACTABLE_TYPES);
		}

		private static void Print()
		{
		}

		private static void CollectMouseOverHighlights()
		{
		}

		private static void SearchInteractablesInGameObject(GameObject gameObject, Dictionary<Type, List<string>> sceneDictionary)
		{
		}
	}
}
