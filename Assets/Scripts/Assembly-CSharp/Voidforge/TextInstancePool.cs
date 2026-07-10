using UnityEngine;
using UnityEngine.UI;

namespace Voidforge
{
	public class TextInstancePool : ComponentInstancePool<Text>
	{
		[SerializeField]
		protected Font font;

		protected override void Initialize(Transform t)
		{
		}
	}
}
