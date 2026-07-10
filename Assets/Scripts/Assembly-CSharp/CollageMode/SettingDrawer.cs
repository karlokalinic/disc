using UnityEngine;

namespace CollageMode
{
	public class SettingDrawer : Drawer
	{
		[SerializeField]
		private string title;

		[SerializeField]
		private SubDrawerTogglePair locationSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair weatherSubDrawerTogglePair;

		[SerializeField]
		private SubDrawerTogglePair timeOfDaySubDrawerTogglePair;

		public override string TitleTerm => null;

		public override BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public override bool IsAssetDrawer => false;

		private void Update()
		{
		}

		protected override void Awake()
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
