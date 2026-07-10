using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	internal class Fisheye : PostEffectsBase
	{
		public float strengthX;

		public float strengthY;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
