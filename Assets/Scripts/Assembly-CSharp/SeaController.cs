using UnityEngine;
using UnityEngine.Rendering;

public class SeaController : MonoBehaviour
{
	public Material defaultSea;

	public Material calmSea;

	public static SeaController instance;

	public static bool calm;

	private RenderTexture grabSeaRT;

	private CommandBuffer grabSeaCmd;

	private void Awake()
	{
	}

	public static void Calm(bool _calm)
	{
	}

	private void DebugCalm()
	{
	}

	private void DebugNotCalm()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void CheckResources()
	{
	}

	private void ReleaseResources()
	{
	}
}
