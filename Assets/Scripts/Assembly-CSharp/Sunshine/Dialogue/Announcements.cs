using System;

namespace Sunshine.Dialogue
{
	public static class Announcements
	{
		public static bool hack;

		public static void GainItem(string itemName)
		{
		}

		public static void LoseItem(string itemName)
		{
		}

		public static void GainThought(string thoughtName)
		{
		}

		public static void SubstanceUsed(string substanceName)
		{
		}

		public static void MoneyChanged(int amount)
		{
		}

		public static void TaskGained(string taskNameTerm)
		{
		}

		public static void TaskUpdated(string taskNameTerm)
		{
		}

		public static void TaskFinished(string taskNameTerm, int XP)
		{
		}

		public static void SecretTaskFinished(string taskNameTerm, int XP)
		{
		}

		public static void XPGained(int amount)
		{
		}

		public static void LevelUp()
		{
		}

		private static void AnnounceInDialogue(Func<string> prefixGetter, Func<string> nameGetter)
		{
		}

		private static void AnnounceInDialogueOngoing(Func<string> prefixGetter, Func<string> nameGetter)
		{
		}

		private static void AnnounceInDialogueOngoingRegular(Func<string> textGetter)
		{
		}

		public static void AnnounceInDialogueOngoingDebug(string message, string messageTypeInfo = "LUA script")
		{
		}
	}
}
