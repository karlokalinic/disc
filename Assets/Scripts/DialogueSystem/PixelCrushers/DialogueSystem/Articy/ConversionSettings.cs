using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem.Articy
{
	public class ConversionSettings
	{
		public enum DropdownOverrideMode
		{
			UseGlobalSetting = 0,
			Int = 1,
			String = 2
		}

		[Serializable]
		public class DropdownOverrideSetting
		{
			public string id;

			public DropdownOverrideMode mode;

			public DropdownOverrideSetting()
			{
			}

			public DropdownOverrideSetting(string id, DropdownOverrideMode mode = DropdownOverrideMode.UseGlobalSetting)
			{
			}
		}

		private Dictionary<string, ConversionSetting> dict;

		public List<ConversionSetting> list;

		private Dictionary<string, DropdownOverrideSetting> dropdownOverrideDict;

		public List<DropdownOverrideSetting> dropdownOverrideList;

		public static ConversionSettings FromXml(string xml)
		{
			return null;
		}

		public string ToXml()
		{
			return null;
		}

		private void BeforeSerialization()
		{
		}

		private void AfterDeserialization()
		{
		}

		public void Clear()
		{
		}

		public ConversionSetting GetConversionSetting(string Id)
		{
			return null;
		}

		public bool ConversionSettingExists(string Id)
		{
			return false;
		}

		public DropdownOverrideSetting GetDropdownOverrideSetting(string id)
		{
			return null;
		}

		public void AllDropdownOverrides(DropdownOverrideMode mode)
		{
		}
	}
}
