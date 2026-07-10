using FortressOccident;
using UnityEngine;

namespace Sunshine.Unseen
{
	public abstract class BaseValues : FOComponent
	{
		[SerializeField]
		protected Unseen values;

		public static implicit operator Vector4(BaseValues component)
		{
			return default(Vector4);
		}
	}
}
