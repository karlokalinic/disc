using UnityEngine;
using UnityEngine.Events;

namespace PagesSystem
{
	public class PageSortingLayerController : MonoBehaviour
	{
		public class IntEvent : UnityEvent<int>
		{
		}

		private const string PAGE_SORTING_LAYER_NAME_BOTTOM = "BottomPage";

		private const string PAGE_SORTING_LAYER_NAME_TOP = "TopPage";

		private int _bottomPageSortingLayer;

		private int _topPageSortingLayer;

		private int _sortingLayer;

		private IntEvent _onSortingLayerValueChangedEvent;

		private int SortingLayer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IntEvent OnSortingLayerValueChanged => null;

		public bool IsMostTopPage
		{
			set
			{
			}
		}

		private void Awake()
		{
		}
	}
}
