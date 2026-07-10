using System;

[Serializable]
public class MinMaxGamma
{
	public float min;

	public float max;

	public float gamma;

	public static MinMaxGamma init;

	public MinMaxGamma(float _min = 0f, float _max = 1f, float _gamma = 1f)
	{
	}

	public static MinMaxGamma Lerp(MinMaxGamma a, MinMaxGamma b, float t)
	{
		return null;
	}

	public static MinMaxGamma Cumulate(MinMaxGamma a, MinMaxGamma b)
	{
		return null;
	}
}
