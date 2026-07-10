using System;

[Serializable]
public class Cloudiness
{
	public float position;

	public LevelCorrection levelCorrection;

	public float cloudinessEval;

	public float shadowLift;

	private static readonly int wShadowLift;

	public Cloudiness(float _position, LevelCorrection _levelCorrection, float _cloudinessEval, float _shadowLift)
	{
	}

	public static void SetShaderGlobals(Cloudiness c)
	{
	}

	public static Cloudiness Lerp(Cloudiness a, Cloudiness b, float t)
	{
		return null;
	}
}
