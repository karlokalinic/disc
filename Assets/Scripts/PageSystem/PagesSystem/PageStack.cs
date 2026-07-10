using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PagesSystem
{
	public class PageStack : MonoBehaviour
	{
		private readonly Queue<IEnumerator> _navigationQueue;

		private readonly Stack<Page> pages;

		private static PageStack main;

		private static PageStack sub;

		[SerializeField]
		private PageContent[] PageContentPrefabs;

		[SerializeField]
		private Page PagePrefab;

		[SerializeField]
		private string InitialPageContentName;

		public bool LoadPageContentFromResources;

		private static HashSet<string> InitializedPagesList { get; set; }

		public static Stack<PageContent> ContentsStack { get; }

		public static PageStack Main => null;

		public static PageStack Sub
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static PageStack TopmostStack => null;

		public bool CanGoBack => false;

		public Page CurrentPage => null;

		public PageContent CurrentContent => null;

		public int PagesCount => 0;

		public event Action<PageContent> OnPagePop
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PageContent> OnPagePush
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void Awake()
		{
		}

		public void ClearStack()
		{
		}

		public void Navigate(string pageContentName, NavigationParameters parameters, bool isPopUp = false, bool animate = true, bool absolute = false, bool force = false)
		{
		}

		public void Navigate<T>(NavigationParameters parameters, bool isPopUp = false, bool animate = true, bool absolute = false, bool force = false) where T : PageContent
		{
		}

		public void GoBack(bool animate = true, bool forceBack = false)
		{
		}

		public void GoBack(NavigationParameters parameters, bool animate = true, bool forceBack = false)
		{
		}

		private PageContent GetPageContentPrefab(string pageContentName)
		{
			return null;
		}

		private T GetPageContentPrefab<T>() where T : PageContent
		{
			return null;
		}

		private IEnumerator NavigateCo(PageContent pageContentPrefab, NavigationParameters parameters, bool isPopUp, bool animate, bool absolute)
		{
			return null;
		}

		private Page CreatePage(PageContent pageContentPrefab)
		{
			return null;
		}

		private IEnumerator GoBackCo(NavigationParameters parameters, bool animate, bool force)
		{
			return null;
		}

		private IEnumerator PushPage(Page newPage, NavigationParameters parameters, bool isPopUp, bool animate, bool absolute)
		{
			return null;
		}

		private IEnumerator PopPage(NavigationParameters parameters, bool animate)
		{
			return null;
		}

		private IEnumerator EnqueueNavigation(IEnumerator navigation, bool force)
		{
			return null;
		}

		public bool ContainsPage<T>() where T : PageContent
		{
			return false;
		}
	}
}
