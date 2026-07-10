using TMPro;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class SwitchableLocalizationSettingsOption : LiteSingleton<SwitchableLocalizationSettingsOption>
	{
		[HideInInspector]
		public TMP_Dropdown dropdown;

		[HideInInspector]
		public LocalizationOption lastOption;

		private int defaultIndex;

		private string settingName;

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

		public void InitializeSettings(int defaultIndex)
		{
		}

		private void InitializeComponents()
		{
		}

		private void InitializeDropdownOptions()
		{
		}

		public void SetValueWithoutNotify(int value)
		{
		}

		private void OnValueChanged(bool invokeEvents)
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
