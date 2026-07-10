using System;
using System.Collections.Generic;
using UnityEngine;

public class ArcReactor_Manager : MonoBehaviour
{
	[Serializable]
	public class FPSInfo
	{
		public float minFps;

		public int priority;
	}

	public FPSInfo[] fpsPriorities;

	public float updateInterval;

	public int defaultPriority;

	protected List<ArcReactor_Arc> arcSystems;

	protected List<ArcReactor_Arc> arcSystemsForDeletion;

	protected float accum;

	protected int frames;

	protected float timeleft;

	protected int priority;

	protected FPSInfo[] fpsScales;

	protected float fps;

	public static ArcReactor_Manager Instance { get; private set; }

	public void AddArcSystem(ArcReactor_Arc arcSystem)
	{
	}

	public void DeleteArcSystem(ArcReactor_Arc arcSystem)
	{
	}

	protected void Awake()
	{
	}

	protected int GetPriority(float fps)
	{
		return 0;
	}

	protected void Start()
	{
	}

	protected void Update()
	{
	}
}
