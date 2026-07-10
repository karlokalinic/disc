using DarkTonic.MasterAudio;
using UnityEngine;

public class AmbientSoundSource : MonoBehaviour
{
	public string soundGroup;

	public string soundVariation;

	public float volume;

	private PlaySoundResult soundThatPlays;

	private bool isInitialized;

	public float maxRange;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void Start()
	{
	}
}
