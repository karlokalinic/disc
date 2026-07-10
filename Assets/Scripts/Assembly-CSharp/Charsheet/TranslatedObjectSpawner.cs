using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Charsheet
{
	public class TranslatedObjectSpawner : MonoBehaviour
	{
		[SerializeField]
		private TranslationObject[] translationList;

		private string currentLanguageCode;

		public UnityAction<GameObject> OnObjectSpawned;

		private Dictionary<string, GameObject> cache;

		private bool isInitialize;

		public GameObject CurrentlySpawnedObject { get; private set; }

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		public GameObject TryInitialSpawn()
		{
			return null;
		}

		private GameObject FindTranslatedObject(string languageCode)
		{
			return null;
		}

		public void SpawnCachedObject()
		{
		}

		private bool WasLanguageChanged()
		{
			return false;
		}
	}
}
