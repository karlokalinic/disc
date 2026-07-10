using System.Collections.Generic;
using UnityEngine;

public class AnimatorCulling : MonoBehaviour
{
	private class AnimatorDesc
	{
		public Animator animator;

		public AnimatorCullingMode cullingMode;

		public Bounds bounds;

		public bool forceCullingMode;

		public AnimatorDesc(Animator animator, Bounds bounds)
		{
		}
	}

	public bool DebugAll;

	public bool DebugNames;

	public string DebugAnimator;

	public float DebugMinRadius;

	private int currentIndex;

	private static HashSet<Animator> registry;

	private static List<AnimatorDesc> list;

	private static List<AnimatorDesc> stableList;

	private const float MinCullDistance = 10f;

	private const float MaxCullDistance = 20f;

	private const float MinAnimatorRadius = 5f;

	private static readonly Vector3 MinAnimatorSize;

	private static readonly Vector3 EmptyBoundsMin;

	private static readonly Vector3 EmptyBoundsMax;

	private void OnDisable()
	{
	}

	public static void Clear()
	{
	}

	public static void RegisterAnimator(Animator animator)
	{
	}

	public static void UpdateAndForceCullingMode(Animator animator)
	{
	}

	public static void DisableForceCullingMode(Animator animator)
	{
	}

	public void Update()
	{
	}

	private static Bounds ComputeBounds(Animator root)
	{
		return default(Bounds);
	}

	private void OnDrawGizmos()
	{
	}
}
