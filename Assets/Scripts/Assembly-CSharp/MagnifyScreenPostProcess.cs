using UnityEngine;

public class MagnifyScreenPostProcess : MonoBehaviour
{
	[SerializeField]
	private Material mat;

	[SerializeField]
	private float zoomedFactor;

	[SerializeField]
	private float defaultFactor;

	private Vector2 mousePos;

	private float zoomFactor;

	private Material matInstance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
