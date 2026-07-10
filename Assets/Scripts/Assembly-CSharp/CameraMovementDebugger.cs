using FortressOccident;
using UnityEngine;

public class CameraMovementDebugger : MonoBehaviour
{
	public enum Mode
	{
		UPDATE = 0,
		LATE = 1,
		FIXED = 2
	}

	public float speed;

	public float radius;

	private Vector3 lastPos;

	private CameraController cc;

	private string output;

	public Mode mode;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private static void WriteString(string writable)
	{
	}

	private static void ReadString()
	{
	}
}
