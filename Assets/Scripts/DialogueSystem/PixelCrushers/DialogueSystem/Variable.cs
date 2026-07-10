using System;
using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Variable : Asset
	{
		public string InitialValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float InitialFloatValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InitialBoolValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public FieldType Type
		{
			get
			{
				return default(FieldType);
			}
			set
			{
			}
		}

		public Variable()
		{
		}

		public Variable(Variable sourceVariable)
		{
		}

		public Variable(UserVariable chatMapperUserVariable)
		{
		}

		public void Assign(UserVariable chatMapperUserVariable)
		{
		}

		private FieldType LookupInitialValueType()
		{
			return default(FieldType);
		}

		private void SetInitialValueType(FieldType type)
		{
		}
	}
}
