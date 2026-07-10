using System;
using UnityEngine;

[Serializable]
public struct WeatherMask
{
	public Texture2D pattern;

	public float scale;

	public float surfaceValue;

	public float appearSmoothness;

	public float disappearSmoothness;

	private bool _currentlyAppearing;

	public float eval;

	private float Smoothness => 0f;

	private bool CurrentlyAppearing => false;

	public void ToShader(string tag)
	{
	}
}
