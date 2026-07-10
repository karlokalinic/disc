using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CollageMode
{
	public class BaseOperationButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private Image highlight;

		[SerializeField]
		private Image selection;

		private bool isSelected;

		public Operation Operation { get; private set; }

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<BaseOperationButton, bool> onFavoruiteChanged
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

		public event Action<BaseOperationButton> onClicked
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

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Init(Operation operation)
		{
		}

		public void RefreshHighlight()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		protected void InvokeOnFavoruiteChanged(bool isOn)
		{
		}
	}
}
