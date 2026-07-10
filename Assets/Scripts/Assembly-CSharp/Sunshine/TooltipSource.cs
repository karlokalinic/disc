using FortressOccident;
using Sunshine.Views;
using UnityEngine;
using UnityEngine.EventSystems;
using Voidforge;

namespace Sunshine
{
	public class TooltipSource : FOComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		protected float tooltipDelay;

		protected ComponentRef<RectTransform> rt;

		public TooltipType tooltipType;

		public virtual Vector2 WorldPosition => default(Vector2);

		public TooltipData Data => null;

		public float Delay => 0f;

		private void OnChangeView(ViewType view)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		private void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		public void ShowTooltip(bool setByKeyboard = false)
		{
		}

		public void UpdateTooltipData()
		{
		}

		public void HideTooltip()
		{
		}

		private ITooltip GetTooltipForType(TooltipType tooltipType)
		{
			return null;
		}

		private bool IsShownInCheckTooltip()
		{
			return false;
		}
	}
}
