using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class HiddenImageCreateData : ScriptableObject
	{
		[SerializeField]
		private HiddenImage hiddenImagePrefab;

		public Sprite image;

		public string serializableID;

		[SerializeField]
		private Vector3 spawnPosition;

		[SerializeField]
		private Vector3 spawnRotation;

		[SerializeField]
		private Vector3 spawnScale;

		[SerializeField]
		private SpecialFilter specialFilter;

		public HiddenImageCompleteData completeData;

		public GameObject SpawnOnScene(Transform parent)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void Debug_PrintOutImageID()
		{
		}
	}
}
