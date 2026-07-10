using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class SettingsType
	{
		private bool exportMarkupField;

		private bool exportQueriesField;

		private bool writeNamespaceField;

		private bool writeAllVariablesField;

		public bool ExportMarkup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ExportQueries
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WriteNamespace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool WriteAllVariables
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
