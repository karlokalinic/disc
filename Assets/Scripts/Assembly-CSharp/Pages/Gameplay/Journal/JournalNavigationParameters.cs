using System.Collections.Generic;
using PagesSystem;
using Sunshine.Journal;

namespace Pages.Gameplay.Journal
{
	public class JournalNavigationParameters : NavigationParameters
	{
		public HashSet<JournalTask> gainedTasks;

		public HashSet<WhiteCheck> whiteChecks;

		public JournalNavigationParameters(HashSet<JournalTask> gainedTasks, HashSet<WhiteCheck> whiteChecks)
		{
		}
	}
}
