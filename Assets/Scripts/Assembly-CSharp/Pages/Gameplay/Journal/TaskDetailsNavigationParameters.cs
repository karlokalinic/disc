using PagesSystem;
using Sunshine.Journal;

namespace Pages.Gameplay.Journal
{
	public class TaskDetailsNavigationParameters : NavigationParameters
	{
		public JournalTask task;

		public TaskDetailsNavigationParameters(JournalTask task)
		{
		}
	}
}
