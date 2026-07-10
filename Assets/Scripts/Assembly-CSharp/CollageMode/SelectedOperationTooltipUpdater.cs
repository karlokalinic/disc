using I2.Loc;
using TMPro;
using UnityEngine;

namespace CollageMode
{
	public class SelectedOperationTooltipUpdater : MonoBehaviour
	{
		[SerializeField]
		private OperationsPanel operationsPanel;

		[SerializeField]
		private Localize defaultTooltipText;

		[SerializeField]
		private Localize selectedTooltipText;

		private TMP_Text selectedTooltipTextDirect;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnOperationSelectionChanged(BaseOperationButton operationButton)
		{
		}
	}
}
