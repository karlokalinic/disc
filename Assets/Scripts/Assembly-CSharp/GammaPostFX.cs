using UnityEngine;

public class GammaPostFX : MonoBehaviour
{
	public static GammaPostFX singleton;

	private static float rememberedAmount;

	public Material mat;

	public float amount;

	private Material _localMat;

	private static bool _enabled;

	public bool debugMode;

	private Material LocalMat => null;

	public static bool Enabled
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	public static void SetValue(float val)
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
