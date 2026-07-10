using UnityEngine;

public class PostOutlines : MonoBehaviour
{
	public Material mat;

	private Material _localMat;

	public bool debugMode;

	private Material LocalMat => null;

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
