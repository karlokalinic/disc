using System.Collections;
using System.Collections.Generic;
using Sunshine.Views;
using UnityEngine;

public class ModusMullen : MonoBehaviour
{
	public static bool engaged;

	public static ModusMullen instance;

	[SerializeField]
	private GameObject mulenOrbsPrefab;

	private SenseOrb mullenInitializeOrb;

	[SerializeField]
	private SenseOrb initializeMullenOrbPrefab;

	private GameObject mullenOrbs;

	public float fadeTime;

	public float mullenTime;

	private float mullenness;

	private Coroutine mullenCoR;

	private Coroutine orbCoR;

	private List<SenseOrb> sorbs;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator WaitForWorldToBeRunAndInitializeOrb()
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnViewChanged(ViewType next)
	{
	}

	public void Reset()
	{
	}

	public void Engage(bool to)
	{
	}

	private void On()
	{
	}

	private void Off()
	{
	}

	private IEnumerator FadeToMullen(bool to)
	{
		return null;
	}

	private IEnumerator ShowOrbs()
	{
		return null;
	}
}
