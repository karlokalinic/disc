using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ShaderPropertyStartupSequence : MonoBehaviour
{
	public string property;

	public float duration;

	public UnityEvent onReady;

	public string area;

	public string state;

	private float count;

	private Material m;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator Boot()
	{
		return null;
	}
}
