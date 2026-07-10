using System.Collections;
using UnityEngine;

namespace PagesSystem
{
	public class PagesList : Singleton<PagesList>
	{
		public bool autoLoad;

		public bool batchLoad;

		public bool loadAsync;

		public PagesRecordList pageList;

		private Coroutine m_LoadRoutine;

		private int m_CurrentPageIndex;

		private int m_LoadToIndex;

		private PageContent[] m_PageContentPrefabs;

		private int[] m_BatchIndices;

		protected override void Awake()
		{
		}

		public PageContent[] GetPageContentPrefabsArray()
		{
			return null;
		}

		public void SetBatchCount(int count)
		{
		}

		public void LoadBatch(int batch)
		{
		}

		public void Load()
		{
		}

		private IEnumerator LoadRoutine()
		{
			return null;
		}

		public IEnumerator WaitUntilComplete()
		{
			return null;
		}
	}
}
