using System.Collections.Generic;
using System.Text;
using PixelCrushers.DialogueSystem;

namespace FeldMigration
{
	public class EntityConverter
	{
		public enum EntityType
		{
			Ability = 0,
			NPC = 1,
			Skill = 2,
			Player = 3,
			Item = 4,
			Thought = 5,
			None = 6
		}

		public static HashSet<string> abilityFieldsToRemoveExportMap;

		private static Dictionary<string, string> abilityFieldsExportMap;

		private static HashSet<string> abilitiesNames;

		public static HashSet<string> npcFieldsToRemoveExportMap;

		private static Dictionary<string, string> npcFieldsExportMap;

		public static HashSet<string> noneFieldsToRemoveExportMap;

		private static Dictionary<string, string> noneFieldsExportMap;

		public static HashSet<string> playerFieldsToRemoveExportMap;

		private static Dictionary<string, string> playerFieldsExportMap;

		public static HashSet<string> skillFieldsToRemoveExportMap;

		private static Dictionary<string, string> skillFieldsExportMap;

		public static HashSet<string> itemFieldsToRemoveExportMap;

		private static Dictionary<string, string> itemFieldsExportMap;

		public static HashSet<string> thoughtFieldsToRemoveExportMap;

		private static Dictionary<string, string> thoughtFieldsExportMap;

		public const string CharacterAvatarDataFieldName = "character_avatar";

		public const string CharacterDescriptionDataFieldName = "character_description";

		public const string CharacterFullNameDataFieldName = "character_full_name";

		public const string CharacterShortNameDataFieldName = "character_short_name";

		public static HashSet<string> FieldsToExportIgnore;

		public static Dictionary<string, string> ActorToFeldActorFieldNameMap;

		private static string[] removedCharactersMap;

		private static Dictionary<string, string> replaceCharactersMap;

		private static StringBuilder stringBuilder;

		private static Dictionary<string, string> abilityFieldsImportMap;

		private static Dictionary<string, string> npcFieldsImportMap;

		private static Dictionary<string, string> noneFieldsImportMap;

		private static Dictionary<string, string> playerFieldsImportMap;

		private static Dictionary<string, string> skillFieldsImportMap;

		private static Dictionary<string, string> itemFieldsImportMap;

		private static Dictionary<string, string> thoughtFieldsImportMap;

		private static HashSet<string> FieldsToImportIgnore;

		private static Dictionary<string, string> FeldEntityToActorFieldNameMap;

		public static string identityAbilityActorFieldName => null;

		public static string identityNPCActorFieldName => null;

		public static string identityPlayerActorFieldName => null;

		public static string identitySkillActorFieldName => null;

		public static string identityItemItemFieldName => null;

		public static string identityThoughtItemFieldName => null;

		private static string identityAbilityEntityFieldName => null;

		private static string identityNPCEntityFieldName => null;

		private static string identityPlayerEntityFieldName => null;

		private static string identitySkillEntityFieldName => null;

		private static string identityItemEntityFieldName => null;

		private static string identityThoughtEntityFieldName => null;

		private static bool IsAbilityActor(Actor actor)
		{
			return false;
		}

		private static void ApplyExportToAbilityTemplate(FeldEntity feldActor, Actor actor)
		{
		}

		private static bool IsNPCActor(Actor actor)
		{
			return false;
		}

		private static void ApplyExportToNPCTemplate(FeldEntity feldActor, Actor actor)
		{
		}

		private static void ApplyExportToNoneTemplate(FeldEntity feldActor, Actor actor)
		{
		}

		private static bool IsPlayerActor(Actor actor)
		{
			return false;
		}

		private static void ApplyExportToPlayerTemplate(FeldEntity feldActor, Actor actor)
		{
		}

		private static bool IsSkillActor(Actor actor)
		{
			return false;
		}

		private static void ApplyExportToSkillTemplate(FeldEntity feldActor, Actor actor)
		{
		}

		public static void ApplyExportToTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		public static EntityType GetActorEntityType(Actor actor)
		{
			return default(EntityType);
		}

		public static void ApplyExportToTemplate(FeldEntity feldEntity, Item item)
		{
		}

		public static EntityType GetItemEntityType(Item item)
		{
			return default(EntityType);
		}

		private static bool IsItemItem(Item item)
		{
			return false;
		}

		private static void ApplyExportToItemTemplate(FeldEntity feldEntity, Item item)
		{
		}

		private static bool IsThoughtItem(Item item)
		{
			return false;
		}

		private static void ApplyExportToThoughtTemplate(FeldEntity feldEntity, Item item)
		{
		}

		public static FeldEntity ExportToFeld(Actor actor, string collection)
		{
			return null;
		}

		public static FeldEntity ExportToFeld(Item item, string collection)
		{
			return null;
		}

		public static string GetShortName(string longName)
		{
			return null;
		}

		public static string GetShortName(Actor actor)
		{
			return null;
		}

		public static void ExportFieldsToEntity(Asset asset, FeldEntity feldEntity)
		{
		}

		private static void ConvertFieldsToOneJsonField(FeldEntity feldEntity)
		{
		}

		private static bool IsAbilityEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportAbilityCard(FeldEntity sourceEntity, Actor actor)
		{
		}

		private static void ApplyImportAbilityTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		private static bool IsNPCEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportNPCCard(FeldEntity sourceEntity, Actor actor)
		{
		}

		private static void ApplyImportNPCTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		private static void PrepareImportNoneCard(FeldEntity sourceEntity, Actor actor)
		{
		}

		private static void ApplyImportNoneTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		private static bool IsPlayerEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportPlayerCard(FeldEntity sourceEntity, Actor actor)
		{
		}

		private static void ApplyImportPlayerTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		private static bool IsSkillEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportSkillCard(FeldEntity sourceEntity, Actor actor)
		{
		}

		private static void ApplyImportSkillTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		public static void PrepareImportToTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		public static void ApplyImportToTemplate(FeldEntity feldEntity, Actor actor)
		{
		}

		public static EntityType GetEntityTemplateType(FeldEntity feldEntity)
		{
			return default(EntityType);
		}

		private static bool IsItemEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportItemCard(FeldEntity sourceEntity, Item item)
		{
		}

		private static void ApplyImportItemTemplate(FeldEntity feldEntity, Item item)
		{
		}

		public static void PrepareImportToTemplate(FeldEntity feldEntity, Item item)
		{
		}

		public static void ApplyImportToTemplate(FeldEntity feldEntity, Item item)
		{
		}

		private static bool IsThoughtEntity(FeldEntity feldEntity)
		{
			return false;
		}

		private static void PrepareImportThoughtCard(FeldEntity sourceEntity, Item item)
		{
		}

		private static void ApplyImportThoughtTemplate(FeldEntity feldEntity, Item item)
		{
		}

		public static Actor ToDialogueSystemActor(FeldEntity feldEntity, int actorId, Template template)
		{
			return null;
		}

		public static void ImportFieldsToActor(Actor actor, FeldEntity feldEntity)
		{
		}

		public static Item ToDialogueSystemItem(FeldEntity feldEntity, int itemId, Template template)
		{
			return null;
		}

		public static void ImportFieldsToItem(Item item, FeldEntity feldEntity)
		{
		}

		public static void ConvertOneJsonFieldToEntityFields(FeldEntity feldEntity)
		{
		}
	}
}
