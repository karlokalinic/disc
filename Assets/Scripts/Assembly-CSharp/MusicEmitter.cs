using UnityEngine;

public class MusicEmitter : MonoBehaviour
{
	[SerializeField]
	public string playlist;

	[SerializeField]
	public string song;

	[SerializeField]
	public float priority;

	[SerializeField]
	public float radius;

	[SerializeField]
	public bool aggressive;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
