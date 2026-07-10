using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public abstract class Tooltip<T> : SingletonComponent<T>, ITooltip where T : MonoBehaviour
	{
		private bool isSetByKeyboard;

		protected bool followMouseCursor;

		protected RectTransform rectTransform;

		private RectTransform lastSelectedRect;

		private bool positionNeedsUpdate;

		private Timer delayTimer;

		protected TooltipSource _source;

		public virtual TooltipSource Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 Position
		{
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public void LateUpdate()
		{
		}

		public abstract void SetTooltipContent(TooltipSource tooltipSource);

		private Vector3 GetMouseCursorPosition()
		{
			return default(Vector3);
		}

		public virtual void Hide()
		{
		}

		public virtual void Hide(TooltipSource source)
		{
		}

		public virtual void Show(TooltipSource source, RectTransform selectedRect, bool setByKeyboard = false)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
