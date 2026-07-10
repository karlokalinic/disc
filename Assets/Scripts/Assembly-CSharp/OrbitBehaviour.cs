using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class OrbitBehaviour : SingletonComponent<OrbitBehaviour>
{
	private const float ORB_OFFSET = 0.55f;

	public Dictionary<SenseOrb, OrbitPoint> orbToOrbitPoint;

	public List<SenseOrb> orbiting;

	public List<SenseOrb> cachedObsessions;

	[SerializeField]
	private OrbitPoint template;

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SceneChange()
	{
	}

	public OrbitPoint Register(SenseOrb orb)
	{
		return null;
	}

	public void Unregister(SenseOrb orb)
	{
	}

	public void CacheObsession(SenseOrb orb)
	{
	}

	public void PopCachedOrbs()
	{
	}

	private void UpdatePending()
	{
	}

	private void PositionOrbs()
	{
	}

	private void PositionOrb(OrbitPoint orbitPoint, int index)
	{
	}
}
