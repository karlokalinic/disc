using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Asset
	{
		public int id;

		public List<Field> fields;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string localizedName => null;

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LocalizedName => null;

		public Asset()
		{
		}

		public Asset(Asset sourceAsset)
		{
		}

		public Asset(int chatMapperID, List<PixelCrushers.DialogueSystem.ChatMapper.Field> chatMapperFields)
		{
		}

		public void Assign(int chatMapperID, List<PixelCrushers.DialogueSystem.ChatMapper.Field> chatMapperFields)
		{
		}

		public bool FieldExists(string title)
		{
			return false;
		}

		public string LookupValue(string title)
		{
			return null;
		}

		public string LookupLocalizedValue(string title)
		{
			return null;
		}

		public int LookupInt(string title)
		{
			return 0;
		}

		public float LookupFloat(string title)
		{
			return 0f;
		}

		public bool LookupBool(string title)
		{
			return false;
		}

		public bool IsFieldAssigned(string title)
		{
			return false;
		}

		public Field AssignedField(string title)
		{
			return null;
		}
	}
}
