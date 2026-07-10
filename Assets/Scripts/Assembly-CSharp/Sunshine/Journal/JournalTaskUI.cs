using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sunshine.Journal
{
	public class JournalTaskUI : Selectable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
	{
		private const string TimeFormat = "HH:mm";

		private const string SubtaskSuffix = " \ufffd";

		private const int SubtaskIndent = 20;

		public static JournalTaskUI CURRENTLY_SELECTED_TASK;

		public static JournalTaskUI LAST_ACTIVE_TASK;

		public static JournalTaskUI LAST_DONE_TASK;

		public Completeable task;

		public SunshineClockTime aquisitionTime;

		public TextMeshProUGUI taskNameTextField;

		public Color undoneColor;

		public Color doneColor;

		public Color highlightedColor;

		public Color hiddenColor;

		public Image selectionBackground;

		public Image timedTaskNotifier;

		public Image freshDot;

		public int Indent;

		public bool AlwaysIndentForTimedTaskImage;

		private static string CancelledTask => null;

		private void SetIndentation()
		{
		}

		protected override void OnEnable()
		{
		}

		public void Visualize()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		public void SelectThisTask()
		{
		}

		private void SetupTimedTaskNotifier()
		{
		}

		private void SetTimedTask(bool state)
		{
		}
	}
}
