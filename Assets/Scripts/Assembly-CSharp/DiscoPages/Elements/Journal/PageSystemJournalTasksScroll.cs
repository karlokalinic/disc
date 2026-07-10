using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.Journal
{
	public class PageSystemJournalTasksScroll : MonoBehaviour
	{
		[SerializeField]
		private GameObject taskDayPrefab;

		[Space]
		[SerializeField]
		private RectTransform upperPart;

		[SerializeField]
		private VerticalLayoutGroup content;

		[Space]
		[SerializeField]
		private int topPadding;

		[SerializeField]
		private int tmpTaskDayMockupCount;

		private IEnumerator SetContentTopPadding()
		{
			return null;
		}
	}
}
