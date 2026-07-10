using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class InputLock : MonoBehaviour
	{
		[SerializeField]
		private Image inputLockImage;

		private bool inputLock;

		public bool Locked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
