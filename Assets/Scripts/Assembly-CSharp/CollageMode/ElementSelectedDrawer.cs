using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class ElementSelectedDrawer : Drawer
	{
		[SerializeField]
		private DestructiveButtonHoldHandler removeHoldHandler;

		[SerializeField]
		private Button editButton;

		[SerializeField]
		private Button editTextButton;

		[SerializeField]
		private Button resetButton;

		[SerializeField]
		private Button doneButton;

		[SerializeField]
		private GameObject rotateTooltip;

		private CollageElement selectedElement;

		public override string TitleTerm => null;

		public override BottomPanel.State BottomPanelState => default(BottomPanel.State);

		public override bool IsSelectionDrawer => false;

		public event Action OnEditRequested
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

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public override void Show()
		{
		}

		private void OnRemoveButtonClicked()
		{
		}

		private void OnEditButtonClicked()
		{
		}

		private void OnEditTextButtonClicked()
		{
		}

		private void OnResetButtonClicked()
		{
		}

		private void OnDoneButtonClicked()
		{
		}

		private void RefreshButtons()
		{
		}

		private void RefreshTooltips()
		{
		}
	}
}
