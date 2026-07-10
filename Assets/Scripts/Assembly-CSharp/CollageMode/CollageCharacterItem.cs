using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	[ExecuteInEditMode]
	public class CollageCharacterItem : MonoBehaviour
	{
		[SerializeField]
		private SkinnedMeshRenderer wearerMeshRenderer;

		private string[] boneIds;

		private void Awake()
		{
		}

		private bool IsMatch(int index, string id)
		{
			return false;
		}

		private Transform[] MatchBones(ICollection<Transform> allBodyBones)
		{
			return null;
		}
	}
}
