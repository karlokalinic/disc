using UnityEngine;

public abstract class LiteSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	public static T Singleton { get; private set; }

	public static bool HasInstance => false;

	protected virtual void Awake()
	{
	}
}
