using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class DTVTimeTweenTemp : VoidElement
{
	public DaytimeVisualController dtv;

	public float start;

	public float length;

	public static bool playing;

	private float counter;

	public static List<Animator> animators;

	public AnimationCurve aniEasing;

	protected override void Awake()
	{
	}

	public void OnPageUp()
	{
	}

	private void Update()
	{
	}
}
