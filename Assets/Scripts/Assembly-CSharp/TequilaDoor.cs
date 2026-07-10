using FortressOccident;
using UnityEngine;

public class TequilaDoor : Door
{
	public static TequilaDoor singleton;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void OnUse(Transform user = null)
	{
	}

	public static void CloseDoor(bool playSound = true)
	{
	}

	public override void UseAnimation(Transform user)
	{
	}
}
