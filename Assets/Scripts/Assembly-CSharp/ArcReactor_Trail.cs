using System.Collections.Generic;
using UnityEngine;

public class ArcReactor_Trail : MonoBehaviour
{
	public class SegmentInfo
	{
		public Vector3 pos;

		public float birthtime;

		public SegmentInfo(Vector3 pos, float birthtime)
		{
		}
	}

	public GameObject arcPrefab;

	public bool truncateByDistance;

	public float distanceThreshold;

	public bool truncateByLifetime;

	public float lifetimeThreshold;

	public float precision;

	public Transform globalSpaceTransform;

	public List<SegmentInfo> segments;

	[HideInInspector]
	public ArcReactor_Arc currentArc;

	public ArcReactor_Arc DetachRay(bool newshape = false)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
