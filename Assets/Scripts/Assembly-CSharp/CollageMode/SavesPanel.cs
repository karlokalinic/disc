using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class SavesPanel : MonoBehaviour, INavigationReceiver
	{
		[SerializeField]
		private SaveButton savesButtonPrefab;

		public Transform buttonsParent;

		[SerializeField]
		private Transform specialButtonsParent;

		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private float gamepadScrollSpeed;

		private List<SaveButton> actionButtons;

		private ListComposite<SaveButton> allButtons;

		private int lastSelectedIndex;

		private SaveButton selected;

		public SaveButton Selected
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<SaveButton> OnSelectionChanged
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

		public void Show(List<SaveButton> savesButtons)
		{
		}

		public SaveButton CreateNewButton()
		{
			return null;
		}

		public void SelectNext()
		{
		}

		public void SelectPrevious()
		{
		}

		private void SelectDefaultOperationButton()
		{
		}

		private IEnumerator ResetScrollPositionCoroutine()
		{
			return null;
		}
	}
}
