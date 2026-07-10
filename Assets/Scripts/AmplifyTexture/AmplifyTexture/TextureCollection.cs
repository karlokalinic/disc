using System;
using System.Collections.Generic;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class TextureCollection
	{
		public List<TextureCombo> m_current;

		[NonSerialized]
		public List<TextureCombo> m_added;

		[NonSerialized]
		public List<TextureCombo> m_removed;

		public TextureCollection()
		{
		}

		public TextureCollection(List<TextureCombo> current)
		{
		}

		public int GetCurrentMaterialCount()
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void Update(Dictionary<string, TextureCombo> currentDict)
		{
		}

		public int ComputeTargetSize(ref int totalArea)
		{
			return 0;
		}
	}
}
