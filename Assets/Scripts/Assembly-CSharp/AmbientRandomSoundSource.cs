using System.Collections;
using UnityEngine;

public class AmbientRandomSoundSource : MonoBehaviour
{
	public string soundGroup;

	public string soundVariation;

	public float volume;

	private bool playing;

	private float pause;

	public float minDelay;

	public float maxDelay;

	public bool randomVariation;

	public float randomDistance;

	private Vector3 randomPosition;

	private Vector3 previousPosition;

	public float maxRange;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator playSound()
	{
		return null;
	}
}
