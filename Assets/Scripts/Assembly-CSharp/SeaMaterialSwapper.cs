using System.Collections.Generic;
using UnityEngine;

public class SeaMaterialSwapper : MonoBehaviour
{
	[HideInInspector]
	public Renderer r;

	public static List<SeaMaterialSwapper> register;

	private void Start()
	{
	}

	public void SetMaterial(Material mat)
	{
	}
}
