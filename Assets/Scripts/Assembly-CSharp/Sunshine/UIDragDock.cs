using FortressOccident;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class UIDragDock : FOComponent, IDropHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
	{
		protected ComponentRef<RectTransform> rt;

		public Vector2 iconSize;

		public Vector2 thoughtsNormalSize;

		public Vector2 thoughtsBiggerSize;

		public UIDragDock previousDock;

		public UIDragDock nextDock;

		public int cost;

		private Color regularAlpha;

		private Button myButton;

		private Color selectedButtonColor;

		public SlotNature slotNature;

		private SlotState _status;

		public Button MyButton => null;

		public virtual RectTransform container => null;

		public SlotState Status
		{
			get
			{
				return default(SlotState);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		void ISelectHandler.OnSelect(BaseEventData eventData)
		{
		}

		public void OnSubmit()
		{
		}

		private Sprite GetPurchaseGraphics()
		{
			return null;
		}

		public void OnDrop(PointerEventData eventData)
		{
		}
	}
}
