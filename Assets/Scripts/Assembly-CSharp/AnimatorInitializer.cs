using System.Collections.Generic;

public static class AnimatorInitializer
{
	private static List<object> animatorLocks;

	public static void AddAnimatorLock(object locker)
	{
	}

	public static void RemoveAnimatorLock(object locker)
	{
	}

	public static bool IsAnimatorsWorking()
	{
		return false;
	}

	public static int Locks()
	{
		return 0;
	}
}
