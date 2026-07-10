using TMPro;
using UnityEngine;

namespace Sunshine.Journal
{
	public class JournalSubtaskUI : MonoBehaviour
	{
		public Completeable task;

		public SunshineClockTime aquisitionTime;

		public TextMeshProUGUI taskNameTextField;

		public Color undoneColor;

		public Color doneColor;

		public Color hiddenColor;

		private const string PrefixCircle = "\ufffd";

		private string UpdateStrikethrough(string text)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		public void Visualize()
		{
		}
	}
}
