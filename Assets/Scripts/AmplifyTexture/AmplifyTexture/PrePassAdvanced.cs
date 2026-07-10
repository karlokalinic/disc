using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public struct PrePassAdvanced
	{
		public bool jitter;

		public Shader shader;

		public PrePassAdvanced(bool jitter, Shader shader)
		{
			this.jitter = false;
			this.shader = null;
		}
	}
}
