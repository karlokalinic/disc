using System;
using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class UIDraggable : FOComponent, IPointerUpHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, IDeselectHandler
	{
		public IConvertible Tab;

		private static UIDraggable lastActiveDraggable;

		private const float FAST_CLICK_DURATION = 0.2f;

		[SerializeField]
		private Image itemImage;

		[SerializeField]
		private Image glowImage;

		private Vector2 pointerOffset;

		private Vector2 currentPosition;

		private UIDragDock currentDock;

		protected ComponentRef<RectTransform> rt;

		[GetComponent]
		private ComponentRef<Canvas> canvas;

		[GetComponent]
		private ComponentRef<Graphic> graphics;

		private HashSet<Graphic> rayTargets;

		private float startTime;

		private const float timeToReachTarget = 0.2f;

		private const float curveStopPoint = 1f;

		private string previousSound;

		private bool previousSoundDone;

		private bool clickedOnceFast;

		private bool isAsyncPrepared;

		private bool isElementEnabled;

		private string prevItemName;

		private AsyncOperationHandle<Sprite> spriteHandle;

		public static UIDraggable current { get; private set; }

		public static UIDraggable LastActiveDraggable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool DeletedLastActive { get; set; }

		public static bool FocusOnLedger { get; set; }

		public UIDragDock CurrentDock => null;

		public Image ItemImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsTransitioning { get; private set; }

		public Button ItemButton { get; private set; }

		private bool SlotContentsBeingDragged => false;

		public InventoryItem item => null;

		private void Reparent(UIDragDock newDock)
		{
		}

		private void SmoothReparent(UIDragDock newDock)
		{
		}

		private IEnumerator SmoothTransition(UIDragDock newDock)
		{
			return null;
		}

		private float SmoothstepCurve(float lerpFactor)
		{
			return 0f;
		}

		private float AccelerationCurve(float lerpFactor)
		{
			return 0f;
		}

		private void AttachDraggable(UIDragDock newDock)
		{
		}

		public void SetGlow(bool isOn)
		{
		}

		public bool Dock(UIDragDock newDock, bool focusOnNew = false)
		{
			return false;
		}

		private bool DockReact(UIDragDock newDock, bool reactingToMove, bool focusOnNew = false)
		{
			return false;
		}

		private void SlotAnticipation()
		{
		}

		public void Redock(UIDragDock newDock)
		{
		}

		public void CancelDrag()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		private void DoNatureSpecificThingsOnBeginDrag()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void DoubleClickAction()
		{
		}

		public bool IsInEquipmentDock()
		{
			return false;
		}

		public bool IsInInventoryDock()
		{
			return false;
		}

		public bool IsinHeldDock()
		{
			return false;
		}

		private IEnumerator FastClickCountdown()
		{
			return null;
		}

		private bool TabNeedsAdjustment()
		{
			return false;
		}

		private bool CheckIfValidDrop(UIDragDock newDock, UIDragDock currentDock)
		{
			return false;
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void ItemDataTransfer(UIDragDock targetDock, UIDragDock sourceDock, bool reactingToMove)
		{
		}

		private void MoveReplacedTarget(UIDragDock targetDock, UIDragDock sourceDock, UIDraggable targetDraggable, bool reactingToMove)
		{
		}

		private static UIDragDock FindClosestToTopOpenSlot(UIDragDock startPoint, ref int maxDepth)
		{
			return null;
		}

		private static UIDragDock FindFurthestBottomOpenSlot(UIDragDock startPoint, ref int maxDepth)
		{
			return null;
		}

		private string GetSlottableName(UIDragDock slot)
		{
			return null;
		}

		private void PutSlottableToSlot(SlotNature slotNature, string slotName, string slottableName, bool doReplace, ref UIDragDock dock, string oldSlottableName = null)
		{
		}

		private void FunctionalizeButtonAndUpdateStatus()
		{
		}

		public void Unfresh()
		{
		}

		private void PlaySound(string soundName)
		{
		}

		private IEnumerator PlaySoundAndWaitForDone(string soundName)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		void IDeselectHandler.OnDeselect(BaseEventData eventData)
		{
		}

		void ISelectHandler.OnSelect(BaseEventData eventData)
		{
		}

		public void LoadSpriteAsync(string itemName)
		{
		}

		public void UnloadSpriteAsync()
		{
		}

		private void SetItemIcon(Sprite itemIcon)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
