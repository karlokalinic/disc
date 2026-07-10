using TMPro;
using UnityEngine;

namespace CollageMode
{
	public class CollageTextSubDrawer : OperationPanelSubDrawer
	{
		[SerializeField]
		private TextMeshProUGUI placeTextButtonText;

		[SerializeField]
		private TextMeshProUGUI openDialogueButtonText;

		protected override void RefreshButtons()
		{
		}
	}
}
