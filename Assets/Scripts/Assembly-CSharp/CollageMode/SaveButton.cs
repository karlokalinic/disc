using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class SaveButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		private Action onSubmitAction;

		[SerializeField]
		private Image selection;

		[SerializeField]
		protected RawImage image;

		private CollageSaveData saveFile;

		private bool isSelected;

		public CollageSaveData SaveFile => null;

		public virtual bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action OnClicked
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

		public event Action OnSubmit
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

		protected virtual void Awake()
		{
		}

		public virtual void Submit()
		{
		}

		public void SetData(CollageSaveData file)
		{
		}

		private void SetImage()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void Reset()
		{
		}
	}
}
