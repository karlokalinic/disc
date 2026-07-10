using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOWController : MonoBehaviour
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

	public static float globalRadiusMultiplier;

	public bool reset;

	private Renderer[] renderers;

	private List<FOWData> meshes;

	public static FOWController instance;

	public static bool isCrisisFOWActive;

	private static HashSet<FOWData> visible;

	private static readonly float RcpConstDivisor;

	private bool isVisible;

	private float alphaStart;

	private float alphaCounter;

	private float crisisTime;

	private float crisisLerper;

	private CrisisLerpDir crisisLerpDir;

	public static void SetVisibleState(FOWData fowData, bool state)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public static void SetVisible(bool b, bool instant = false)
	{
	}

	public IEnumerator FadeTo(float to)
	{
		return null;
	}

	public void CrisisFOWOn()
	{
	}

	public void CrisisFOWOff()
	{
	}

	public static void CrisisFOWReset()
	{
	}

	private IEnumerator CrisisCoR(bool to)
	{
		return null;
	}

	private void welpon()
	{
	}

	private void welpoff()
	{
	}

	private void Reset()
	{
	}
}
