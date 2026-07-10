using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CharacterEditDrawer : Drawer
	{
		[SerializeField]
		private Button doneButton;

		[SerializeField]
		private OperationPanelSubDrawer subDrawer;

		private CollageCharacter selectedElement;

		public override string TitleTerm => null;

		public override BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public override bool IsSelectionDrawer => false;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		private void OnDoneButtonClicked()
		{
		}
	}
}
