using UnityEngine;

namespace PagesSystem
{
	public class Page : MonoBehaviour
	{
		[SerializeField]
		private Transform _contentContainer;

		[SerializeField]
		private TitleBar _titleBar;

		private PageContent _content;

		public Canvas Canvas { get; private set; }

		public PageContent Content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PageSortingLayerController SortingLayerController { get; private set; }

		private void Awake()
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatedToAnimationComplete()
		{
		}

		public void OnNavigatedFrom()
		{
		}

		public void OnNavigatedFromAnimationComplete()
		{
		}
	}
}
