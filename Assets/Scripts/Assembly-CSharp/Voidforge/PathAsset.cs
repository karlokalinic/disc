using UnityEngine;

namespace Voidforge
{
	[CreateAssetMenu]
	public class PathAsset : ScriptableObject
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
