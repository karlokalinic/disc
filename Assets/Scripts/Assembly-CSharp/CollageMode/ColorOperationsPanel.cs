using UnityEngine;

namespace CollageMode
{
	public class ColorOperationsPanel : MonoBehaviour
	{
		[SerializeField]
		private OperationsSet operationsSet;

		[SerializeField]
		private BaseOperationButton operationButtonPrefab;

		[SerializeField]
		private Transform parent;

		private void Awake()
		{
		}

		private void OnClicked(BaseOperationButton operationButton)
		{
		}
	}
}
