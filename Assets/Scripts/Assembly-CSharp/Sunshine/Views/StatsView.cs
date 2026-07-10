using System.Collections;
using I2.Loc;
using UnityEngine;
using Voidforge;

namespace Sunshine.Views
{
	public class StatsView : SingletonComponent<StatsView>
	{
		[SerializeField]
		private RectTransform equipButtonPrompt;

		[SerializeField]
		private RectTransform closeButtonPrompt;

		public Localize localizedHelpfulText;

		[SerializeField]
		private GameObject thoughtCabinetTitle;

		[SerializeField]
		private GameObject inventoryTitle;

		private bool refreshQueued;

		protected StatDisplay statDisplay;

		protected AttributeDisplayField[] attributes;

		protected AttributeVisualizeField attributeVisuals;

		protected override void Awake()
		{
		}

		public void Refresh(ViewType currentView)
		{
		}

		private void StatRefresh(ViewType currentView)
		{
		}

		public void QueueRefresh()
		{
		}

		private IEnumerator RefreshNextFrame(ViewType type)
		{
			return null;
		}
	}
}
