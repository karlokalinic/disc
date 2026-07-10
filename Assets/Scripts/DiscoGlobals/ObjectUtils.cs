using System;
using UnityEngine;

public static class ObjectUtils
{
	public static void SafeDestroy<T>(ref T target) where T : UnityEngine.Object
	{
	}

	public static void SafeDestroyImmediate<T>(ref T target) where T : UnityEngine.Object
	{
	}

	public static void SafeRelease<T>(ref T target) where T : class, IDisposable
	{
	}

	public static void SafeRelease(ref RenderTexture target)
	{
	}
}
