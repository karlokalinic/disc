using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class SpecialSaveButton : SaveButton
	{
		[SerializeField]
		private Color enabledButtonColor;

		[SerializeField]
		private Color disabledButtonColor;

		[Space]
		[SerializeField]
		private Button confirmButton;

		[SerializeField]
		private List<Button> standardButtons;

		private bool isActive;

		public bool IsActive
		{
			set
			{
			}
		}

		public override bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void Submit()
		{
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
