using System.Collections;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class I2LocalizeButton : Localize
	{
		private const string HIGHLIGHTED_STATE_NAME = "_HIGHLIGHTED";

		private const string PRESSED_STATE_NAME = "_PRESSED";

		private const string SELECTED_STATE_NAME = "_SELECTED";

		private const string DISABLED_STATE_NAME = "_DISABLED";

		private const string SUFFIX_STRING = "_IMG";

		public string defaultButtonTerm;

		public string highlightedTerm;

		public string pressedTerm;

		public string selectedTerm;

		public string disabledTerm;

		[SerializeField]
		private bool localizeHighlightedSprite;

		[SerializeField]
		private bool localizePressedSprite;

		[SerializeField]
		private bool localizeSelectedSprite;

		[SerializeField]
		private bool localizeDisabledSprite;

		[HideInInspector]
		public Button button;

		[HideInInspector]
		public Image image;

		private string _oldDefaultButtonTerm;

		private IEnumerator refreshButtonCoR;

		protected override void Awake()
		{
		}

		public void MatchLocalizationTerms()
		{
		}

		protected override void OnEnable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void UpdateButtonStates()
		{
		}

		private IEnumerator RefreshButtonImage()
		{
			return null;
		}

		protected virtual bool CheckTerm(string term, string title)
		{
			return false;
		}
	}
}
