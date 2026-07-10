using UnityEngine;

public class FOShaderUtilities
{
	public enum BlendMode
	{
		Opaque = 0,
		Cutout = 1,
		Fade = 2,
		Transparent = 3
	}

	public static void RefreshBlendmode(Material material)
	{
	}

	public static void SetupMaterialWithBlendMode(Material material, BlendMode blendMode, bool isOutlined = false)
	{
	}

	public static void SetStencilValues(Material mat, bool mouseover = false, bool isOutlined = false)
	{
	}
}
