using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class LevelManager : MonoBehaviour
	{
		protected static List<bool?> levelStatus;

		[SerializeField]
		protected string editorOnlyTag;

		[SerializeField]
		protected int[] loadLevels;

		[SerializeField]
		protected bool[] loadAsync;

		public bool IsFinished => false;

		protected void DestroyEditModeObjects()
		{
		}

		protected bool LoadLevel(int level, bool asyncMode)
		{
			return false;
		}

		protected IEnumerator LoadLevelCoR(int level)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}
	}
}
