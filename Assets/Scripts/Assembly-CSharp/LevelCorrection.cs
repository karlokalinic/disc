using System;

[Serializable]
public class LevelCorrection
{
	public MinMaxGammaRGB values;

	private static MinMaxGammaRGB _activeLevelCorrectionA;

	private static MinMaxGammaRGB _activeLevelCorrectionB;

	private static float abLerper;

	public MinMaxGamma rgb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MinMaxGamma r
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MinMaxGamma g
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MinMaxGamma b
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static MinMaxGammaRGB ActiveLevelCorrectionA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static MinMaxGammaRGB ActiveLevelCorrectionB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void SetShaderGlobals(MinMaxGammaRGB lc)
	{
	}

	public static void UpdateShaderLC()
	{
	}

	public static void StopAndLerpTo(LevelCorrection to)
	{
	}

	public static LevelCorrection Lerp(LevelCorrection a, LevelCorrection b, float t)
	{
		return null;
	}

	public static LevelCorrection Cumulate(LevelCorrection a, LevelCorrection b)
	{
		return null;
	}
}
