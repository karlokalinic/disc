using UnityEngine;

public class SimpleBobber : MonoBehaviour
{
	public AnimationCurve largeSine;

	public AnimationCurve bobberX;

	public AnimationCurve bobberZ;

	public bool inverse;

	private Renderer rendererComp;

	private float time;

	private Vector3 initialPosition;

	private Quaternion initialRotation;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	private void Update()
	{
	}
}
