using System.Collections.Generic;
using FortressOccident;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	[ExecuteInEditMode]
	public class SkinnedCharacterItem : CharacterItem
	{
		protected ComponentRef<SkinnedMeshRenderer> skinnedRenderer;

		protected List<bool> bakedBlendShapes;

		public string[] blendshapeModifiers;

		private string[] _blendshapes;

		public string[] boneIds { get; protected set; }

		public string[] blendshapes => null;

		public override Character wearer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool BakeBlendShape(int blendShapeIndex)
		{
			return false;
		}

		public void ClearBakedBlendShapes()
		{
		}

		public bool IsBakedBlendShape(int blendShapeIndex)
		{
			return false;
		}

		public bool IsMatch(int index, string id)
		{
			return false;
		}

		public Transform[] MatchBones(ICollection<Transform> allBodyBones)
		{
			return null;
		}

		protected override void Awake()
		{
		}

		public void ChangeBlendshape(string blendshapeName, bool equipping)
		{
		}

		private void BuildBlendshapesList()
		{
		}
	}
}
