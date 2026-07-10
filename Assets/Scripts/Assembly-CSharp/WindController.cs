using UnityEngine;

public class WindController : MonoBehaviour
{
	public Texture2D spatialTimeOffset;

	public float spatialScaling;

	public Texture2D windLookup;

	public float timeScaling;

	public float breezeStrength;

	public Vector2 constantComponent;

	public float treetopParallax;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void ValuesToShader()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
