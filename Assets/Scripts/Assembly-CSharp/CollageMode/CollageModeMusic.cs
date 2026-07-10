using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	public class CollageModeMusic : MonoBehaviour
	{
		[SerializeField]
		private float songChangeInterval;

		[SerializeField]
		private string[] songs;

		private List<string> songsPool;

		private Coroutine musicCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator PlayCollageMusicCoroutine()
		{
			return null;
		}

		private string PickRandomSong()
		{
			return null;
		}
	}
}
