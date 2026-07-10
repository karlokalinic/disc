using System.Collections.Generic;
using UnityEngine;

public class FloatFactory : MonoBehaviour
{
	public FloatTemplate template;

	public RectTransform activeFloats;

	public float appearTime;

	private static Dictionary<FloatTemplate, Stack<FloatTemplate>> available;

	private static Dictionary<FloatTemplate, List<FloatTemplate>> active;

	public static int poolSize;

	private void Start()
	{
	}

	private FloatTemplate PopFloat()
	{
		return null;
	}

	private FloatTemplate InstantiateFloat()
	{
		return null;
	}

	private void SortActiveBarks()
	{
	}

	public void ShowFloat(string text, Transform target)
	{
	}

	public void ShowFloat(string text, Transform target, Vector3 offset, float time = 6f)
	{
	}

	public FloatTemplate ShowLocalizedFloat(string term, string fallbackText, Transform target)
	{
		return null;
	}

	public FloatTemplate ShowLocalizedFloat(string term, string fallbackText, Transform target, Vector3 offset, float time = 6f)
	{
		return null;
	}

	public static void ReturnToPool(FloatTemplate ft, FloatTemplate floatType)
	{
	}
}
