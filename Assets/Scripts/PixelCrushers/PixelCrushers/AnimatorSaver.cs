using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class AnimatorSaver : Saver
	{
		[Serializable]
		public class LayerData
		{
			public int hash;

			public float time;
		}

		[Serializable]
		public class Data
		{
			public LayerData[] layers;

			public List<bool> bools;

			public List<float> floats;

			public List<int> ints;
		}

		private Data m_data;

		private Animator m_animator;

		private Animator animator => null;

		private void CheckAnimator()
		{
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
