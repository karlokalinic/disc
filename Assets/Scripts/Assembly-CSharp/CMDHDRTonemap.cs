using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class CMDHDRTonemap : MonoBehaviour
{
	public Shader blitShader;

	private Material blitMaterial;

	private CommandBuffer commandBuffer;

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWhiteNitsChanged(float value)
	{
	}

	private IEnumerator CustomHDRTonemapPass()
	{
		return null;
	}

	private void ApplyMaterialParams()
	{
	}

	private void CreateCommandBuffer(bool hdrOn)
	{
	}
}
