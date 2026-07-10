using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class CharacterInfo
	{
		public int id;

		public string nameInDatabase;

		public CharacterType characterType;

		public Transform transform;

		public Sprite portrait;

		private static Dictionary<string, Transform> registeredActorTransforms;

		public bool isPlayer => false;

		public bool isNPC => false;

		public string Name { get; set; }

		public bool IsPlayer => false;

		public bool IsNPC => false;

		public CharacterInfo(int id, string nameInDatabase, Transform transform, CharacterType characterType, Sprite portrait)
		{
		}

		public static string GetLocalizedDisplayNameInDatabase(string nameInDatabase)
		{
			return null;
		}

		public Sprite GetPicOverride(int picNum)
		{
			return null;
		}

		public static void RegisterActorTransform(string actorName, Transform actorTransform)
		{
		}

		public static void UnregisterActorTransform(string actorName, Transform actorTransform)
		{
		}

		public static Transform GetRegisteredActorTransform(string actorName)
		{
			return null;
		}
	}
}
