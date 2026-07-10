using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderBooleanSwitcher : MonoBehaviour
{
	[SerializeField]
	public string BooleanName;

	[SerializeField]
	public bool SwitchOffOnExit;

	public bool CallShakeups;

	public bool RecalcConversationOptions;

	[ReadonlyProperty]
	public int collideLevel;

	private Scene parentScene;

	private static bool quitting;

	public void Awake()
	{
	}

	private void OnSceneActivated()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnTriggerEnter(Collider other)
	{
	}

	public void OnTriggerExit(Collider other)
	{
	}

	public void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
