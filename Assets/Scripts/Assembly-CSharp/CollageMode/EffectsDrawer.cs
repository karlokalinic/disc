using UnityEngine;

namespace CollageMode
{
	public class EffectsDrawer : Drawer
	{
		[SerializeField]
		private string titleTerm;

		[SerializeField]
		private SubDrawerTogglePair filtersSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair framesSubDrawerTogglePair;

		public override string TitleTerm => null;

		public override BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public override bool IsAssetDrawer => false;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public override void Show()
		{
		}

		private void RefreshSubDrawers()
		{
		}
	}
}
