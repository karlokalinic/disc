using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine;
using UnityEngine;
using Voidforge;

public class ScabBrain : MonoBehaviour
{
	private Animator animator;

	private FoBarkUI barkUI;

	private static List<ScabBrain> brainList;

	private Timer _barkTimer;

	private Timer _waveTimer;

	public const string SCAB_FIST_TRIGGER = "Fist";

	private static string[] scabBarks;

	public static int triggerHash;

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public static void LeaderHasSpoken()
	{
	}

	public void RaiseFist(Animator animator)
	{
	}

	public static DialogueEntry PickBarkEntry()
	{
		return null;
	}
}
