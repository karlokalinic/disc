using UnityEngine;

[ExecuteInEditMode]
public class HighlightRenderer : MonoBehaviour
{
	public Shader highlightShader;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
