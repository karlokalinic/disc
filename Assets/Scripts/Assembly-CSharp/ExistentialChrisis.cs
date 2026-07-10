using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sunshine.Metric;
using UnityEngine;

public class ExistentialChrisis : LiteSingleton<ExistentialChrisis>
{
	public const int EXISTENTIAL_GRACE_PERIOD = 10;

	private Coroutine graceTimeCoroutine;

	public event Action OnStartExistentialChrisis
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

	public event Action OnEndExistentialChrisis
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void BreakGraceCoroutineOnLoadGame()
	{
	}

	public void Execute(Skill skill)
	{
	}

	private IEnumerator GraceTime(Skill skill)
	{
		return null;
	}

	private static bool ShouldGraceTimerTick()
	{
		return false;
	}

	private void EndExistentialChrisis(bool wasHealed)
	{
	}
}
