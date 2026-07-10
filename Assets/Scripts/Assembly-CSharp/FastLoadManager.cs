using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FastLoadManager : MonoBehaviour
{
	public static FastLoadManager m_FastLoadManager;

	public NavMeshDataCollection navMeshDataCollection;

	public bool LobbyLoad;

	public bool allScenesLoaded;

	public Dictionary<string, Scene> allScenes;

	public readonly string[] scenesToSkip;

	public readonly string[] ignoreNavMesh;

	private void LoadProcessScene(Scene scene)
	{
	}

	public IEnumerator LoadAllScenes(bool firsttime = false)
	{
		return null;
	}

	private void showAnim()
	{
	}

	private void Awake()
	{
	}
}
