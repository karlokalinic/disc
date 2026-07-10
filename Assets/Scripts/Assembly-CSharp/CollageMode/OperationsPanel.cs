using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class OperationsPanel : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, INavigationReceiver
	{
		[SerializeField]
		private BaseOperationButton operationButtonPrefab;

		[SerializeField]
		private Transform buttonsParent;

		[SerializeField]
		private Transform unusedButtonsParent;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Transform favouriteParent;

		[SerializeField]
		private ScrollViewOptimizer scrollViewOptimizer;

		[SerializeField]
		private bool selectionAllowed;

		[SerializeField]
		private bool executeOnDrag;

		[SerializeField]
		private bool executeOnClick;

		[SerializeField]
		private bool previewOnClick;

		[SerializeField]
		private bool enableShortcutSelection;

		[SerializeField]
		private DragEventTrigger[] dragEventTriggers;

		[SerializeField]
		private float gamepadScrollSpeed;

		[SerializeField]
		private List<BaseOperationButton> additionalOperationButtons;

		private List<BaseOperationButton> unusedButtons;

		private List<BaseOperationButton> favoruitesOperationButtons;

		private List<BaseOperationButton> nonFavoruitesOperationButtons;

		private ListComposite<BaseOperationButton> allOperationButtons;

		private bool isDragging;

		private bool hasExecutedOnDrag;

		private int lastSelectedIndex;

		private float lastScrollPosition;

		private bool updateScroll;

		private bool singleTimeScroll;

		private BaseOperationButton selected;

		public BaseOperationButton Selected
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public event Action<BaseOperationButton> OnSelectionChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void Show(Operation[] operations)
		{
		}

		public void Hide()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void ExecuteSelected()
		{
		}

		public void SelectPrevious()
		{
		}

		public void SelectNext()
		{
		}

		public void ClearSelection()
		{
		}

		public void SubscribeScrollButtons(OperationsPanelScrollButtons scrollButtons)
		{
		}

		public void UnsubscribeScrollButtons(OperationsPanelScrollButtons scrollButtons)
		{
		}

		private void ScrollToLast()
		{
		}

		private void ScrollToFirst()
		{
		}

		protected virtual void OnButtonClicked(BaseOperationButton operationButton)
		{
		}

		private float CalculateSelectedSrollNormalizedPosition()
		{
			return 0f;
		}

		private void SelectOperationButton(BaseOperationButton operationButton)
		{
		}

		private BaseOperationButton GetButtonFromPool()
		{
			return null;
		}

		private void HideAllButtons()
		{
		}

		private void SelectDefaultOperationButton()
		{
		}

		private IEnumerator SetScrollPositionCoroutine()
		{
			return null;
		}

		private void RefreshButtonFavoruite(BaseOperationButton button)
		{
		}

		private void OnFavoruiteChanged(BaseOperationButton button, bool isFavoruite)
		{
		}

		private IEnumerator SelectNextOperationButtonCoroutine(int buttonIndex)
		{
			return null;
		}

		private void InitAdditionalperationButtons()
		{
		}
	}
}
