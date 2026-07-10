using UnityEngine;

namespace Voidforge
{
	public class PathComponent : MonoBehaviour
	{
		[SerializeField]
		protected Path _path;

		public Path path
		{
			get
			{
				return default(Path);
			}
			set
			{
			}
		}

		protected void Reset()
		{
		}
	}
}
