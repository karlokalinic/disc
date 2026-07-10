using UnityEngine;

public class SunBehaviour : MonoBehaviour
{
	public enum ShadowQuality
	{
		POTATO = 0,
		LOW = 1,
		MEDIUM = 2,
		HIGH = 3
	}

	private const string ShadowOptionId = "SHADOWS";

	public Camera camSun;

	public Shader sunShader;

	public static SunBehaviour instance;

	public ShadowQuality shadowFilterQuality;

	public ShadowQuality shadowResolutionQuality;

	public float shadowFilterRadius;

	public Texture2D blueNoise;

	private bool forceDisableShadows;

	private RenderTexture sunShadowmap0;

	private static readonly int[] ShadowResolutionPerQuality;

	public static bool isOn;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	private void CameraParametersToShader()
	{
	}

	private void DestroyShadowMap()
	{
	}

	private void CheckShadowMap()
	{
	}

	private void Encapsulate()
	{
	}

	private void OnRenderingQualityChanged(int value)
	{
	}

	private void ToggleShadowsInst(bool to)
	{
	}

	public static void ToggleShadows(bool to)
	{
	}

	private void on()
	{
	}

	private void off()
	{
	}
}
