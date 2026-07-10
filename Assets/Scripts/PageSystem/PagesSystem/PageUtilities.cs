using UnityEngine.UI;

namespace PagesSystem
{
	public static class PageUtilities
	{
		public static void AddGoBackToPageButton(this Button button, bool forceBack = false)
		{
		}

		public static void AddListenerToPageButton<T>(this Button button, PageStack stack, NavigationParameters parameters, bool isPopUp = false, bool animate = true, bool absolute = false, bool force = false) where T : PageContent
		{
		}

		public static void AddListenerToPageButton<T>(this Button[] buttons, NavigationParameters parameters, PageStack stack, bool isPopUp = false, bool animate = true) where T : PageContent
		{
		}

		public static void AddListenerToPageButton<T>(this Button button, PageStack stack, bool isPopUp = false, bool animate = true) where T : PageContent
		{
		}

		public static void AddListenerToPageButton(this Button button, PageStack stack, string pageContentName, bool isPopUp = false, bool animate = true)
		{
		}

		public static void AddListenerToPageButton(this Button button, PageStack stack, string pageContentName, NavigationParameters parameters, bool isPopUp = false, bool animate = true)
		{
		}
	}
}
