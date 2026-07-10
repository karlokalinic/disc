using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sunshine
{
	public class ThoughtInteractButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
	{
		public Action OnPointerEnterButton;

		public Action OnPoinerExitButton;

		[SerializeField]
		private Button button;

		[SerializeField]
		private string internalizeSound;

		[SerializeField]
		private string cancelSound;

		[SerializeField]
		private string internalizeGroup;

		[SerializeField]
		private string cancelGroup;

		private Coroutine pointerOver;

		private bool mouseOver;

		public Button MyButton => null;

		private void Awake()
		{
		}

		public void ClearActions()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		private IEnumerator PointerOver()
		{
			return null;
		}

		public void PlayInternalizeSound()
		{
		}

		public void PlayCancelSound()
		{
		}
	}
}
