using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CharacterEditSubDrawer : OperationPanelSubDrawer
	{
		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private DestructiveButtonHoldHandler removeHoldHandler;

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		protected override void RefreshButtons()
		{
		}

		private void OnResetButtonClicked()
		{
		}

		private void OnRemoveButtonClicked()
		{
		}
	}
}
