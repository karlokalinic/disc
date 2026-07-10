using System.Collections;
using UnityEngine;

namespace FortressOccident
{
	public class ManualSoundRemote : MonoBehaviour
	{
		[SerializeField]
		protected int _controllerIndex;

		[SerializeField]
		protected int _playlistIndex;

		[SerializeField]
		protected int _clipIndex;

		[SerializeField]
		public string Controller;

		[SerializeField]
		public string Playlist;

		[SerializeField]
		public string Clip;

		[SerializeField]
		public string Group;

		[SerializeField]
		protected int _functionIndex;

		[SerializeField]
		protected bool activateOnStart;

		[SerializeField]
		public float Volume;

		[SerializeField]
		public float Fade;

		[SerializeField]
		public float Spatial;

		[SerializeField]
		public bool played;

		[SerializeField]
		public int typeID;

		[SerializeField]
		public int settingID;

		private IEnumerator coroutine;

		public bool ActivateOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void ActivateSound()
		{
		}

		public void ActivateSmartSound()
		{
		}

		public void DeactivateSmartSound()
		{
		}

		public void ChangeTrack()
		{
		}

		public void StartPlaylist()
		{
		}

		public void ChangeVolume()
		{
		}

		public void PausePlaylist()
		{
		}

		private IEnumerator FadeTime()
		{
			return null;
		}

		private IEnumerator DoAfterSomeTime()
		{
			return null;
		}

		public void ResumePlaylist()
		{
		}

		public void ChangeSpatial()
		{
		}

		public void MuteGroup()
		{
		}

		public void UnmuteGroup()
		{
		}
	}
}
