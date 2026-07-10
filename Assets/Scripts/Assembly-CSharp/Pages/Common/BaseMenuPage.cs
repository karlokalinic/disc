using System.Collections.Generic;
using DiscoPages.Elements.MainMenu;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.Events;

namespace Pages.Common
{
	public abstract class BaseMenuPage : DiscoPage
	{
		protected List<PageSystemMenuButton> menuButtons;

		[SerializeField]
		protected PageSystemMenuButton menuItemTemplate;

		[SerializeField]
		protected Transform buttonParent;

		public override bool CanStayOnStack => false;

		public override string Title => null;

		public override ViewType ViewType => default(ViewType);

		public override void Initialize()
		{
		}

		protected void OnLoadAndContinueLastGameClicked()
		{
		}

		protected void OnContinueCurrentGameplayClicked()
		{
		}

		protected void OnNewGameClicked()
		{
		}

		protected void OnSaveClicked()
		{
		}

		protected void OnLoadClicked()
		{
		}

		protected void OnReturnToMainMenuClicked()
		{
		}

		protected void OnOptionsClicked()
		{
		}

		protected void OnMainMenuBackButtonClicked()
		{
		}

		protected PageSystemMenuButton CreateButton(string localizationTag, UnityAction onClick)
		{
			return null;
		}

		protected PageSystemMenuButton CreateButton(string label, string localizationTag, UnityAction onClick)
		{
			return null;
		}
	}
}
