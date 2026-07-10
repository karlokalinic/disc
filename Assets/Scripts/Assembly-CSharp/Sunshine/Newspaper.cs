using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sunshine
{
	public class Newspaper : MonoBehaviour
	{
		private const string VO_PREFIX = "Assets/Sounds/Dialogue/NewspaperEndgame/NewspaperEndgame_";

		private const string VO_POSTFIX_TITLE = "_title.wav";

		private const string VO_POSTFIX_DESCRIPTION = "_description.wav";

		public TextMeshProUGUI title;

		public Localize titleLocalize;

		public TextMeshProUGUI opener;

		public Localize openerLocalize;

		public TextMeshProUGUI pageNr;

		public Button forward;

		public Button back;

		private int currentArticleIndex;

		private static string defaultTitle => null;

		private static string defaultOpener => null;

		public void OnEnable()
		{
		}

		public void CloseNewspaper()
		{
		}

		private void LowerSounds()
		{
		}

		private void RaiseSounds()
		{
		}

		private void TextValueOrDefaultTitle(TextMeshProUGUI text, Localize localize, string value, string defaultValue)
		{
		}

		private void TextValueOrDefaultOpener(TextMeshProUGUI text, Localize localize, string value, string defaultValue)
		{
		}

		public void ToNextArticle()
		{
		}

		public void ToPreviousArticle()
		{
		}

		private void ShowArticleAtIndex()
		{
		}

		private void RequestTitleVO(string term)
		{
		}

		private void RequestDescriptionVO(string term)
		{
		}

		private void RequestVO(string term, string postfix)
		{
		}

		private bool CheckIfAddressableExist(string path)
		{
			return false;
		}

		private void Update()
		{
		}
	}
}
