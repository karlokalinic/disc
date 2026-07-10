using UnityEngine;
using Voidforge;

public class FoBarkUIReceiver : SingletonComponent<FoBarkUIReceiver>
{
	protected ComponentRef<FloatFactory> floatFactory;

	public float offsetExtra;

	public static void ShowBark(string text, Transform speaker)
	{
	}

	public static void ShowBark(string text, Transform speaker, Vector3 offset)
	{
	}

	public static FloatTemplate ShowLocalizedBark(string term, string fallbackText, Transform speaker)
	{
		return null;
	}

	public static FloatTemplate ShowLocalizedBark(string term, string fallbackText, Transform speaker, Vector3 offset)
	{
		return null;
	}

	private static Vector3 GetOffset(Transform target)
	{
		return default(Vector3);
	}

	public void ShowBarkTest()
	{
	}
}
