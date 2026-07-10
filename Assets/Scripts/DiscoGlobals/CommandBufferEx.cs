using UnityEngine;
using UnityEngine.Rendering;

public static class CommandBufferEx
{
	public static void CustomBlit(this CommandBuffer target, Material mat, int pass = -1)
	{
	}

	public static void CustomBlit(this CommandBuffer target, Material mat, MaterialPropertyBlock block, int pass = -1)
	{
	}
}
