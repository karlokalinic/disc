using UnityEngine;

public class OrbAttentionPuller : MonoBehaviour
{
	public GameObject pullerObject;

	private RandomizeScale _scaler;

	public float deactivationRadius;

	public float maxScaleDistance;

	private bool _attention;

	private float _distance;

	private float _distanceRatio;

	private Vector2 _offset;

	private bool DistancePermits => false;

	private void Start()
	{
	}

	public void NeedsAttention(bool attention)
	{
	}

	private void DecideAttention()
	{
	}

	private void Update()
	{
	}
}
