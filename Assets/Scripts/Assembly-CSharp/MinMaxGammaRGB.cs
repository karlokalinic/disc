using System;

[Serializable]
public class MinMaxGammaRGB
{
	public MinMaxGamma rgb;

	public MinMaxGamma r;

	public MinMaxGamma g;

	public MinMaxGamma b;

	public static MinMaxGammaRGB init;

	public MinMaxGammaRGB()
	{
	}

	public MinMaxGammaRGB(MinMaxGamma _rgb, MinMaxGamma _r, MinMaxGamma _g, MinMaxGamma _b)
	{
	}

	public static MinMaxGammaRGB Lerp(MinMaxGammaRGB a, MinMaxGammaRGB b, float t)
	{
		return null;
	}

	public static MinMaxGammaRGB Cumulate(MinMaxGammaRGB a, MinMaxGammaRGB b)
	{
		return null;
	}
}
