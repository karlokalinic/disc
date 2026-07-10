using UnityEngine;

public class CharacterTrail : MonoBehaviour
{
	public int waypointLength;

	public float waypointInterval;

	public RingBuffer<Vector3> waypoints;

	private float waypointCounter;

	private Vector4[] trailPositions;

	private static int register;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
