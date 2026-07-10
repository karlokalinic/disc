using UnityEngine;

public class CameraPositionQuantizer : MonoBehaviour
{
	public int quantizeInterval;

	private Vector3 originalPositionInParentSpace;

	private Vector3 localPixel;

	private Vector3 worldPixel;

	private Vector3 projectedPixel;

	private Vector3 unQuantizedWorldPosition;

	private Vector3 quantizedWorldPosition;

	private float quantizedYZlength;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
