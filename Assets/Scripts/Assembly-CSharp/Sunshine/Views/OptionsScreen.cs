using UnityEngine;
using UnityEngine.UI;

namespace Sunshine.Views
{
	public class OptionsScreen : LiteSingleton<OptionsScreen>
	{
		[SerializeField]
		private Button resetSettingsButton;

		private OptionsView optionsView;

		private OptionSelectableController lastSelectedController;

		private OptionSelectableController[] selectablesControllers;

		public bool isOnControllerView;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void CloseView()
		{
		}

		public void ResetOptions()
		{
		}

		private void PreviewResetChanges()
		{
		}

		private void ApplyReset()
		{
		}

		private void CancelReset()
		{
		}

		public void SaveLastSelectedOption()
		{
		}

		public void SaveLastSelectedOption(Selectable selectable)
		{
		}

		public void SelectSavedOption()
		{
		}

		public void ReApplyAll()
		{
		}

		public void ResetValuesOnly()
		{
		}
	}
}
