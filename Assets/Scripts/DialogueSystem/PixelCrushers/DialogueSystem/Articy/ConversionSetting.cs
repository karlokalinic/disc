using System;

namespace PixelCrushers.DialogueSystem.Articy
{
	[Serializable]
	public class ConversionSetting
	{
		public string Id { get; set; }

		public bool Include { get; set; }

		public EntityCategory Category { get; set; }

		public ConversionSetting()
		{
		}

		public ConversionSetting(string id)
		{
		}

		private void Assign(string id)
		{
		}
	}
}
