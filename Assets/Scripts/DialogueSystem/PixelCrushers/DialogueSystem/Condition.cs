using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Condition
	{
		public enum LastEvaluationValue
		{
			None = 0,
			True = 1,
			False = 2
		}

		public string[] luaConditions;

		public QuestCondition[] questConditions;

		public string[] acceptedTags;

		public GameObject[] acceptedGameObjects;

		[HideInInspector]
		public int luaWizardIndex;

		[HideInInspector]
		public LastEvaluationValue lastEvaluationValue;

		public bool IsTrue(Transform interactor)
		{
			return false;
		}

		private bool LuaConditionsAreTrue()
		{
			return false;
		}

		private bool QuestConditionsAreTrue()
		{
			return false;
		}

		private bool IsAcceptedTag(Transform interactor)
		{
			return false;
		}

		private bool IsAcceptedGameObject(Transform interactor)
		{
			return false;
		}
	}
}
