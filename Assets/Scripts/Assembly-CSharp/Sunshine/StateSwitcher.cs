using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sunshine
{
	public class StateSwitcher : MonoBehaviour
	{
		public string locationName;

		public string[] activePresetNames;

		protected DeactivatableObject deactivator;

		private Scene sourceScene;

		private static HashSet<string> ignoreAreaSwitchers;

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private bool AttachToAreaChange()
		{
			return false;
		}

		protected virtual void OnAwakeInitialized()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnStartInitialized()
		{
		}

		protected virtual void OnSceneActivated()
		{
		}

		protected virtual void OnSceneDeactivated()
		{
		}

		public virtual void BecomeActive()
		{
		}

		public virtual void StopBeingActive()
		{
		}

		public int StateIndex(string stateName)
		{
			return 0;
		}
	}
}
