using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class FlowSettingsType
	{
		private int builtInScriptSupportField;

		private int gridSizeField;

		private int gridSizeEnforcedField;

		private int spacingHorizontalField;

		private int spacingVerticalField;

		private int spacingEnforcedField;

		public int BuiltInScriptSupport
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GridSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int GridSizeEnforced
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpacingHorizontal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpacingVertical
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SpacingEnforced
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
