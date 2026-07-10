using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class NewspaperPage : DiscoPage
	{
		[SerializeField]
		private TextMeshProUGUI title;

		[SerializeField]
		private Localize titleLocalize;

		[SerializeField]
		private TextMeshProUGUI opener;

		[SerializeField]
		private Localize openerLocalize;

		[SerializeField]
		private TextMeshProUGUI pageNr;

		[SerializeField]
		private Button forward;

		[SerializeField]
		private Button back;

		[SerializeField]
		private Button closeNewspaperButton;

		private int currentArticleIndex;

		private static string defaultTitle => null;

		private static string defaultOpener => null;

		public override void Initialize()
		{
		}

		public void CloseNewspaper()
		{
		}

		private void TextValueOrDefault(TextMeshProUGUI text, Localize localize, string value, string defaultValue)
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
	}
}
