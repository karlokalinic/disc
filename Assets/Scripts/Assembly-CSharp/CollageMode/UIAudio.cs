using UnityEngine;

namespace CollageMode
{
	public abstract class UIAudio : MonoBehaviour
	{
		[SerializeField]
		private string sound;

		[SerializeField]
		private string variation;

		[SerializeField]
		private float volume;

		protected void Play()
		{
		}
	}
}
