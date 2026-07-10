using System;
using UnityEngine;

namespace PixelCrushers
{
	public class EnabledSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public bool enabled;
		}

		[SerializeField]
		private Component m_componentToWatch;

		private Data m_data;

		public Component componentToWatch
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}
	}
}
