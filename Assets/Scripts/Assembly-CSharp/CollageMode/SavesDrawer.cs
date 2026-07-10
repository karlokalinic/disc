using UnityEngine;

namespace CollageMode
{
	public class SavesDrawer : Drawer
	{
		[SerializeField]
		private string title;

		[SerializeField]
		private SavesSubdrawer subdrawer;

		public override string TitleTerm => null;

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		private void Update()
		{
		}
	}
}
