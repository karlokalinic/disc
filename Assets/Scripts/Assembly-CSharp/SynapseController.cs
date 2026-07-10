using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynapseController : MonoBehaviour
{
	private const float Z_OFFSET_FOR_SYNAPSE = -1f;

	private const float BRAIN_Z_POSITION_FOR_UI = 100.1f;

	public static SynapseController instance;

	public static Transform[] slots;

	public static List<Transform> brainTransforms;

	[SerializeField]
	private Camera usedCamera;

	[SerializeField]
	private float offsetParameter;

	public NextSlot[] nextSlot;

	public ArcReactor_Arc arc;

	public Vector3[] positions;

	public Vector3[] activePositions;

	private int activeBrainTransform;

	private List<int> activeSlots;

	private Vector3[] offsets;

	private Coroutine[] offsetCoRs;

	private void Awake()
	{
	}

	public void Switch(bool to)
	{
	}

	private void LateUpdate()
	{
	}

	private void ResetController()
	{
	}

	public void FilterTransforms()
	{
	}

	private void UpdateWaypointsImmediate()
	{
	}

	private void UpdateWaypoint(int i)
	{
	}

	private void UpdatePositions()
	{
	}

	private void UpdatePosition(int transformIndex)
	{
	}

	private IEnumerator UpdateWaypointCoR(int i)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
