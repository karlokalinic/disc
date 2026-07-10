using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class NavMeshDataCollection : ScriptableObject
{
	[Serializable]
	public class Entry
	{
		public string ScenePath;

		public NavMeshData NavMeshData;

		public Entry(string scenePath, NavMeshData navMeshData)
		{
		}
	}

	public List<Entry> NavMeshes;

	private Dictionary<string, NavMeshData> dict;

	private bool IsCached()
	{
		return false;
	}

	private void Cache()
	{
	}

	public NavMeshData GetNavMeshDataByScene(string scenePath)
	{
		return null;
	}
}
