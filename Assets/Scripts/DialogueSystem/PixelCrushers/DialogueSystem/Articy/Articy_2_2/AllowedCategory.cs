using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
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
