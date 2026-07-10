using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class AllowedCategory
	{
		private AssetCategoryType nameField;

		[XmlAttribute]
		public AssetCategoryType Name
		{
			get
			{
				return default(AssetCategoryType);
			}
			set
			{
			}
		}
	}
}
