using System.Collections.Generic;
using UnityEngine;

public class ShadowEnforcer : MonoBehaviour
{
	public static List<Light> registry;

	private Light lightComponent;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
