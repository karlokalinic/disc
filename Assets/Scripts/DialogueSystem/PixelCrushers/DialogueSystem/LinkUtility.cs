using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public static class LinkUtility
	{
		public class PrioritySorter : IComparer<Link>
		{
			public int Compare(Link link1, Link link2)
			{
				return 0;
			}
		}

		public static void SortOutgoingLinks(DialogueDatabase database, Conversation conversation)
		{
		}

		public static void SortOutgoingLinks(DialogueDatabase database, DialogueEntry dialogueEntry)
		{
		}

		public static bool IsPassthroughOnFalse(DialogueEntry entry)
		{
			return false;
		}
	}
}
