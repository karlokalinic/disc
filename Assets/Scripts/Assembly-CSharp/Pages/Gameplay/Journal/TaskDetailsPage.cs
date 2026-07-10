using DG.Tweening;
using PagesSystem;
using Sunshine.Journal;
using Sunshine.Views;
using TMPro;
using UnityEngine;

namespace Pages.Gameplay.Journal
{
	public class TaskDetailsPage : SubPage
	{
		[SerializeField]
		private TextMeshProUGUI taskTitle;

		[SerializeField]
		private TextMeshProUGUI selectedTaskFiledDateTime;

		[SerializeField]
		private TextMeshProUGUI taskStateDescription;

		[SerializeField]
		private TextMeshProUGUI taskDescriptionTextField;

		[SerializeField]
		private RectTransform subtasksContainer;

		[SerializeField]
		private JournalSubtaskUI subtaskPrefab;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		private JournalSubtaskUI InstantiateJournalSubtaskUI(Completeable task, string name)
		{
			return null;
		}

		public override Sequence GetTransitionInSequence(PageContent previousPage)
		{
			return null;
		}

		public override Sequence GetTransitionOutSequence(PageContent previousPage)
		{
			return null;
		}
	}
}
