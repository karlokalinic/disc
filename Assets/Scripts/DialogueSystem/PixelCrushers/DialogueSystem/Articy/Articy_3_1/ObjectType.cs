using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ObjectType
	{
		private object[] itemsField;

		private int countField;

		private string typeField;

		private int allowUnsetTemplateField;

		private int allowAllTemplatesField;

		[XmlElement]
		[XmlElement]
		public object[] Items
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public string Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public int AllowUnsetTemplate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public int AllowAllTemplates
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
