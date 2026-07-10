using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class ProceduralFOW : VoidElement
{
	private enum CrisisLerpDir
	{
		FWD = 0,
		BWD = 1,
		STOP = 2
	}

	public float radius;

	public float radius2;

	[HideInInspector]
	public float radiusMultiplier;

	public Transform player;

	private Mesh mesh;

	public bool reset;

	private Color[] colors;

	private Renderer _renderer;

	private static List<ProceduralFOW> PFOWs;

	public static float globalRadiusMultiplier;

	private bool isVisible;

	private Vector3 vertPos;

	private Color colToSet;

	private Vector3 projectedPos;

	private Renderer rnd;

	private float crisisTime;

	private float crisisLerper;

	private CrisisLerpDir crisisLerpDir;

	private float alphaStart;

	private float alphaTo;

	private float alphaCounter;

	private float alphaCounterLength;

	private bool isFading;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateFOWVertices()
	{
	}

	private void Reset()
	{
	}

	public void CrisisFOWOn()
	{
	}

	public void CrisisFOWOff()
	{
	}

	private IEnumerator CrisisCoR(bool to)
	{
		return null;
	}

	private void FadeTo(float to = 1f)
	{
	}

	public static void SetVisible(bool b, bool instant = false)
	{
	}

	public static void SetRadiusMultiplier(float mul)
	{
	}
}
