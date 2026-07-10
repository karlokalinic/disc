using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sunshine.Metric;
using UnityEngine;
using Voidforge;

public class GlobalOrbManager : SingletonComponent<GlobalOrbManager>
{
	public static List<SenseOrb> afterthoughts;

	public static List<SenseOrb> obsessions;

	public static List<SenseOrb> paralyzers;

	public static List<SenseOrb> thoughts;

	public static List<ThoughtCabinetProject> queuedThoughtOrbs;

	public SenseOrb orbTemplate;

	public Material paralyzerMaterial;

	public event Action onAddParalize
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action onRemoveParalize
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void NewGame()
	{
	}

	public SenseOrb AddAfterthought(string orbName)
	{
		return null;
	}

	public SenseOrb AddObsession(string orbName, bool cached = false)
	{
		return null;
	}

	public void RemoveObsession(SenseOrb orb)
	{
	}

	public void ClearObsessions()
	{
	}

	public void AddThoughtOrb(ThoughtCabinetProject project)
	{
	}

	public void RemoveThought(SenseOrb orb)
	{
	}

	public SenseOrb AddParalyzer(string orbName)
	{
		return null;
	}

	public void ResetParalyzer()
	{
	}

	public void RemoveParalyzer()
	{
	}

	public SenseOrb FindAfterthoughtByName(string name)
	{
		return null;
	}

	public SenseOrb FindObsessionByName(string name)
	{
		return null;
	}

	public SenseOrb FindParalyzerByName(string name)
	{
		return null;
	}

	private SenseOrb FindOrbByName(string name, List<SenseOrb> orbs)
	{
		return null;
	}

	public static bool HasParalyzers()
	{
		return false;
	}

	public static bool HasThoughts()
	{
		return false;
	}

	public static bool HasObsessions()
	{
		return false;
	}

	public static bool HasOrbsBlockingTequilaMovement()
	{
		return false;
	}

	private SenseOrb AddGlobal(string orbName, bool autoremove, OrbType type, bool cached = false)
	{
		return null;
	}

	private SenseOrb AddThought(ThoughtCabinetProject project)
	{
		return null;
	}

	private void RemoveAfterthought(SenseOrb orb)
	{
	}

	private IEnumerator AddingThought()
	{
		return null;
	}
}
