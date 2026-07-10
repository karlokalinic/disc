using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class OperationPanelSubDrawer : SubDrawer, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		protected BaseOperationsSet operationsSet;

		[SerializeField]
		protected OperationsPanel operationsPanel;

		[SerializeField]
		protected Button executeButton;

		[SerializeField]
		protected OperationsPanelScrollButtons scrollButtons;

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		private void OnExecuteButtonClicked()
		{
		}

		private void OnRemoveButtonClicked()
		{
		}

		private void OnOperationSelectionChanged(BaseOperationButton operationButton)
		{
		}

		private void OnSelectionChanged(CollageElement collageElement, SelectionMode selectionMode)
		{
		}

		protected virtual void RefreshButtons()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
