using UnityEngine;

[ExecuteInEditMode]
public class CustomDepthRenderer : MonoBehaviour
{
	public Shader depthShader;

	public string textureName;

	public int resolutionDividor;

	public RenderTextureFormat textureFormat;

	public int depthBuffer;

	public FilterMode filterMode;

	private Camera cam;

	private int screenWidthPrev;

	private int screenHeightPrev;

	private int letterBoxPropertyId;

	private Vector4 letterBoxValue;

	private bool hasChanged;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void LateUpdate()
	{
	}
}
