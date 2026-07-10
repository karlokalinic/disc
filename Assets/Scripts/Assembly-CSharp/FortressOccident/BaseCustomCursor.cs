using UnityEngine;
using UnityEngine.EventSystems;
using Voidforge;

namespace FortressOccident
{
	public abstract class BaseCustomCursor : FOComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ICursorSource
	{
		[SerializeField]
		protected CursorMode mode;

		protected bool _isCustomCursor;

		Texture2D ICursorSource.texture => null;

		Vector2 ICursorSource.hotspot => default(Vector2);

		protected virtual bool isCustomCursor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected abstract CursorType GetCustomCursor();

		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
