using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CollageMode
{
	public class CollageDialogueOpener : MonoBehaviour
	{
		[SerializeField]
		private MultipleToggle dialogueToggle;

		[SerializeField]
		private RectTransform dialogueFeldStrip;

		[SerializeField]
		private float closedPositionX;

		[SerializeField]
		private float openPositionX;

		[SerializeField]
		private float tweenTime;

		public bool IsOpen { get; private set; }

		public event Action<bool> OnOpenedChanged
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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetIsOpen(bool isOpen)
		{
		}

		private void OnDialogueToggleValueChanged()
		{
		}
	}
}
