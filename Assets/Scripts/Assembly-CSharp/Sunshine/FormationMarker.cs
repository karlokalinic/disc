using UnityEngine;

namespace Sunshine
{
	public class FormationMarker : MonoBehaviour
	{
		[SerializeField]
		protected Formation.Purpose _purpose;

		[SerializeField]
		protected Formation _formation;

		[SerializeField]
		protected bool _ignoreTransformRotation;

		public Formation formation
		{
			get
			{
				return default(Formation);
			}
			set
			{
			}
		}

		public Formation.Purpose purpose
		{
			get
			{
				return default(Formation.Purpose);
			}
			set
			{
			}
		}

		public Formation worldFormation
		{
			get
			{
				return default(Formation);
			}
			set
			{
			}
		}

		public float angle => 0f;

		public bool HasPurpose(params Formation.Purpose[] purposes)
		{
			return false;
		}

		public static void Copy(FormationMarker from, FormationMarker to)
		{
		}
	}
}
