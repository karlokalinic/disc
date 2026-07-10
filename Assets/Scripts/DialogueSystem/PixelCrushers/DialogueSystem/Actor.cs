using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.ChatMapper;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Actor : Asset
	{
		public Texture2D portrait;

		public Sprite spritePortrait;

		public List<Texture2D> alternatePortraits;

		public List<Sprite> spritePortraits;

		public bool IsPlayer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string textureName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TextureName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Actor()
		{
		}

		public Actor(Actor sourceActor)
		{
		}

		public Actor(PixelCrushers.DialogueSystem.ChatMapper.Actor chatMapperActor)
		{
		}

		public void Assign(PixelCrushers.DialogueSystem.ChatMapper.Actor chatMapperActor)
		{
		}

		public Sprite GetPortraitSprite(int i)
		{
			return null;
		}

		public Sprite GetPortraitSprite()
		{
			return null;
		}

		private string LookupTextureName()
		{
			return null;
		}

		private void SetTextureName(string value)
		{
		}
	}
}
