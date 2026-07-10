using System;
using PixelCrushers.DialogueSystem.ChatMapper;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Item : Asset
	{
		public bool IsItem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Item()
		{
		}

		public Item(Item sourceItem)
		{
		}

		public Item(PixelCrushers.DialogueSystem.ChatMapper.Item chatMapperItem)
		{
		}

		public void Assign(PixelCrushers.DialogueSystem.ChatMapper.Item chatMapperItem)
		{
		}
	}
}
