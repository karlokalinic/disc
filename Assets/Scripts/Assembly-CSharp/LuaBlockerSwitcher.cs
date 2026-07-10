using UnityEngine;
using UnityEngine.AI;

public class LuaBlockerSwitcher : MonoBehaviour
{
	public string booleanName;

	public bool invertBoolean;

	public NavMeshObstacle[] obstacles;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void BooleanChanged(string boolean)
	{
	}

	public void OnValidate()
	{
	}
}
