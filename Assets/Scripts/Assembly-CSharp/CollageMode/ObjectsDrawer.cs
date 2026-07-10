using UnityEngine;

namespace CollageMode
{
	public class ObjectsDrawer : Drawer
	{
		[SerializeField]
		private string titleTerm;

		[SerializeField]
		private SubDrawerTogglePair charactersSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair stickersSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair textSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair fragmentsSubDrawerTogglePair;

		[SerializeField]
		private Highlighter fragmentsTabHighlighter;

		[SerializeField]
		private GameObject[] fragmentsTabObjectsToHide;

		public override string TitleTerm => null;

		public override BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public override bool IsAssetDrawer => false;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public override void Show()
		{
		}

		public override void RefreshSelectedElement()
		{
		}

		private void RefreshFragments()
		{
		}

		private void RefreshSubDrawers()
		{
		}

		private void OnNewFragmentNotification(bool isOn)
		{
		}

		private void OnFragmentsSubdrawerShow()
		{
		}
	}
}
