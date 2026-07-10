using UnityEngine;

public class KimSwitchEnforcer : MonoBehaviour
{
	private const string FALLBACK_NEVERMIND_BARK = "\"\u001dNevermind.\"\u001d";

	[SerializeField]
	public string BooleanName;

	[SerializeField]
	public bool force;

	[ReadonlyProperty]
	public int collideLevel;

	private static bool quitting;

	public void Awake()
	{
	}

	public void OnTriggerExit(Collider other)
	{
	}

	private void CleanUpBeforeDataLoad()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
