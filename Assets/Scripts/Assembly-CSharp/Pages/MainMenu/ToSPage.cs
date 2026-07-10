using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu
{
	public class ToSPage : DiscoPage
	{
		[SerializeField]
		private Button acceptToS;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override void Initialize()
		{
		}

		private void OnAcceptToSClicked()
		{
		}
	}
}
