using FortressOccident;
using UnityEngine;

namespace Sunshine
{
	public class ParentedCharacterItem : CharacterItem
	{
		[SerializeField]
		protected string mountObjectId;

		[SerializeField]
		protected Vector3 mountPosition;

		[SerializeField]
		protected Quaternion mountRotation;

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
	}
}
