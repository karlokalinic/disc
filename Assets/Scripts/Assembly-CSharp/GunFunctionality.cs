using UnityEngine;
using Voidforge;

public class GunFunctionality : MonoBehaviour
{
	public Transform flashPoint;

	public GameObject flashTemplate;

	public float flashTime;

	public string firingSoundGroup;

	public string firingSound;

	private Light pointLight;

	private GunFlash activeFlash;

	private Timer flashTimer;

	public void Awake()
	{
	}

	public void OnDisable()
	{
	}

	public void Fire()
	{
	}

	public void ShowFlash()
	{
	}

	public void HideFlash()
	{
	}
}
