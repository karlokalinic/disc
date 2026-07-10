using System.Collections;
using UnityEngine;

public class SourceSoundGenerator : MonoBehaviour
{
	public enum Looping
	{
		None = 0,
		Fixed = 1,
		Random = 2
	}

	public string soundGroup;

	public string soundClip;

	public float volume;

	public float maxDistance;

	private bool playing;

	private float pause;

	private bool lran;

	public Looping looping;

	public float fixedDelay;

	public float minDelay;

	public float maxDelay;

	private AudioSource audioSource;

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

	private void OnDrawGizmosSelected()
	{
	}
}
