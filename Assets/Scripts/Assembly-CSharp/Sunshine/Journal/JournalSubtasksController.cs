using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Journal
{
	public class JournalSubtasksController : MonoBehaviour
	{
		[SerializeField]
		private JournalSubtaskUI subtaskTemplate;

		[SerializeField]
		private RectTransform subtaskListContainer;

		[SerializeField]
		private RectTransform subtasksPanel;

		private readonly List<JournalSubtaskUI> subtasksUI;

		public void Init()
		{
		}

		public void ShowSubtasks(JournalTask journalTask)
		{
		}

		public void UpdateSubtasks()
		{
		}

		public void HideSubtasks()
		{
		}
	}
}
