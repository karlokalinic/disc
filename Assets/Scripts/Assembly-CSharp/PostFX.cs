using UnityEngine;
using UnityEngine.Rendering;

public class PostFX : PostFXBase
{
	private CommandBuffer cmd;

	private MaterialPropertyBlock block;

	protected void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	private void OnDisable()
	{
	}
}
