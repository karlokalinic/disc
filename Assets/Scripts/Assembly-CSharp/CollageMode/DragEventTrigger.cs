using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CollageMode
{
	public class DragEventTrigger : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		public event Action<PointerEventData> onBeginDrag
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

		public event Action<PointerEventData> onEndDrag
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

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
