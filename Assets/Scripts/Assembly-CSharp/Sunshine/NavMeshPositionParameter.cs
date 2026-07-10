using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class NavMeshPositionParameter : BaseParameter
	{
		public override bool boolValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override Vector3 vector3Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}
	}
}
