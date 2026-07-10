using UnityEngine;

[ExecuteInEditMode]
public class FXAA : MonoBehaviour
{
	[SerializeField]
	private Shader shader;

	private Material mat;

	private void CreateMaterialIfNeeded()
	{
	}

	private void Start()
	{
	}

	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
