using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class TagMask
	{
		[SerializeField]
		public string[] m_tags;

		public string[] tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsInTagMask(string tag)
		{
			return false;
		}
	}
}
