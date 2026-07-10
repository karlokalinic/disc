using System;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class DyslexicFontConfiguration : LiteSingleton<DyslexicFontConfiguration>
	{
		public static string DyslexicLocalizationTerm;

		public static bool useDyslexic;

		public static Action OnFontChange;

		private string settingName;

		private bool valueBeforePreview;

		public Toggle toggle;

		private bool DefaultValue => false;

		public bool Value
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public static bool AreWeOnPlatformWithDyslexicFontDisabled()
		{
			return false;
		}

		public void OnEnable()
		{
		}

		public void ReApply()
		{
		}

		private void OnDestroy()
		{
		}

		public void PreviewReset()
		{
		}

		public void CancelPreview()
		{
		}

		public void ResetSettings()
		{
		}

		public void OnValueChanged(bool value)
		{
		}

		public void ChangeImageBundles()
		{
		}
	}
}
