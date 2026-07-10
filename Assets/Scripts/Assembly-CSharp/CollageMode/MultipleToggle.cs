using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class MultipleToggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private Sprite[] sprites;

		public int Value { get; private set; }

		public int MaxValue => 0;

		public event Action OnValueChanged
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

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void SetNextValue()
		{
		}

		public void SetValue(int value)
		{
		}

		public void SetValueWithoutNotify(int value)
		{
		}
	}
}
