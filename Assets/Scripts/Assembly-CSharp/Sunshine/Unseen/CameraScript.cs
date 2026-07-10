using UnityEngine;
using Voidforge;

namespace Sunshine.Unseen
{
	[ExecuteInEditMode]
	public class CameraScript : ShaderScript
	{
		public enum BlurType
		{
			StandardGauss = 0,
			SgxGauss = 1
		}

		[SerializeField]
		protected float aberrationHueShift;

		[SerializeField]
		protected Color aberrationColor;

		[SerializeField]
		protected Camera renderCamera;

		[SerializeField]
		protected Shader unseenShader;

		[SerializeField]
		protected Shader unseenReplacementShader;

		[SerializeField]
		protected Material unseenMaterial;

		[SerializeField]
		protected RenderTexture renderTexture;

		[SerializeField]
		protected int downsample;

		[SerializeField]
		protected Shader blurShader;

		[SerializeField]
		protected Material blurMaterial;

		[SerializeField]
		protected int blurDownsample;

		[SerializeField]
		protected float blurSize;

		[SerializeField]
		protected int blurIterations;

		[SerializeField]
		protected BlurType blurType;

		protected ComponentRef<Camera> thisCamera;

		protected ComponentRef<UnseenValues> unseenValues;

		protected void Reset()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected RenderTexture Blur(RenderTexture original)
		{
			return null;
		}

		protected void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
