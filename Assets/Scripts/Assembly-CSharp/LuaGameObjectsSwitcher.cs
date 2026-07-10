using UnityEngine;

public class LuaGameObjectsSwitcher : MonoBehaviour
{
	[SerializeField]
	private string booleanName;

	[SerializeField]
	private GameObject[] objectsToEnable;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	protected virtual void Refresh()
	{
	}

	public virtual void BooleanChanged(string boolean)
	{
	}

	protected virtual void OnBooleanChanged(bool value)
	{
	}
}
