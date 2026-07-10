using UnityEngine;

public class FlashlightTargetBehaviour : MonoBehaviour
{
	public LayerMask layerMask;

	public float maxSpeed;

	public float jumpThreshold;

	private bool jumpDetected;

	private Plane charPlane;

	private Ray mouseRay;

	private RaycastHit physicsRayHit;

	private float mouseRayLength;

	private Vector3 moveTowards;

	private void Awake()
	{
	}

	private void ResetPosition()
	{
	}

	private void Update()
	{
	}
}
