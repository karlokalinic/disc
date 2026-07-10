using UnityEngine;

[ExecuteInEditMode]
public class MaskRenderer : MonoBehaviour
{
	public Shader shaderLF;

	public Shader shaderAmbient;

	public Shader shaderMask;

	public RenderTexture targetLF;

	public RenderTexture targetAmbient;

	public RenderTexture targetMask;

	private Camera camMain;

	private Camera camMask;

	private void Start()
	{
	}
}
