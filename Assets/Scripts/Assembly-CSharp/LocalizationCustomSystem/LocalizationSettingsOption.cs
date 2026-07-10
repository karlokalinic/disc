using TMPro;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizationSettingsOption : LiteSingleton<LocalizationSettingsOption>
	{
		[SerializeField]
		private SwitchableLocalizationSettingsOption switchableLocalizationSettingsOption;

		public LocalizationOption lastOption;

		private string settingName;

		private TMP_Dropdown dropdown;

		private int valueBeforePreview;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeDropdownOptions()
		{
		}

		private void UpdateDropdownSelection()
		{
		}

		private int GetCurrentLanguageOptionIndex()
		{
			return 0;
		}

		private void SwitchLanguagesSettings()
		{
		}

		public void SetValueWithoutNotify(int value)
		{
		}

		public void OnValueChanged(bool invokeEvents)
		{
		}

		public void SwitchLanguageSource(int index, string newLanguageName, bool invokeEvents)
		{
		}

		public void ReApply()
		{
		}

		private bool ShouldUnloadLastOptionLanguageSources(string languageName)
		{
			return false;
		}

		private bool ShouldLoadNewLanguageSources(string languageName)
		{
			return false;
		}

		public void ResetSettings()
		{
		}

		public void PreviewReset()
		{
		}

		public void CancelPreview()
		{
		}
	}
}
