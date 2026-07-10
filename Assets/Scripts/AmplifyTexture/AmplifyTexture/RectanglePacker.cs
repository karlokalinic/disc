using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public abstract class RectanglePacker
	{
		[SerializeField]
		private int m_packingAreaWidth;

		[SerializeField]
		private int m_packingAreaHeight;

		public int PackingAreaWidth => 0;

		public int PackingAreaHeight => 0;

		protected RectanglePacker(int packingAreaWidth, int packingAreaHeight)
		{
		}

		internal abstract void Clear();

		internal abstract bool TryPack(int rectangleWidth, int rectangleHeight, string key, out Point placement);

		internal abstract void RemoveByKey(string key);

		internal virtual Point Pack(int rectangleWidth, int rectangleHeight, string key)
		{
			return null;
		}
	}
}
