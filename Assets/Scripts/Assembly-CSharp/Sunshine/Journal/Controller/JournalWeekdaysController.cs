using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Sunshine.Journal.Controller
{
	public class JournalWeekdaysController : MonoBehaviour
	{
		private static readonly string NonBreakingSpace;

		public static readonly string WEEK_TITLE_PADDING;

		[SerializeField]
		private TextMeshProUGUI weekDayTextPrefab;

		private Dictionary<DayOfWeek, TextMeshProUGUI> weekdayLabels;

		public void LocaliseWeekdays()
		{
		}

		public Transform GetOrCreateWeekday(DayOfWeek weekDay, Transform taskListContainer)
		{
			return null;
		}

		public void CreateWeekdays(DayOfWeek lastWeekday, Transform taskListContainer)
		{
		}

		public void MoveTaskToWeekday(Transform task, DayOfWeek weekday, Transform taskListContainer)
		{
		}

		private void SetWeekday(TextMeshProUGUI textComponent, string weekDayTitle)
		{
		}

		private string GetWeekdayText(DayOfWeek weekday)
		{
			return null;
		}

		public void Refresh()
		{
		}
	}
}
