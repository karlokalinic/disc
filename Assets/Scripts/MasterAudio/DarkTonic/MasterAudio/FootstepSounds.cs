using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class FootstepSounds : MonoBehaviour
	{
		public enum FootstepTriggerMode
		{
			None = 0,
			OnCollision = 1,
			OnTriggerEnter = 2,
			OnCollision2D = 3,
			OnTriggerEnter2D = 4
		}

		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		public FootstepTriggerMode footstepEvent;

		public List<FootstepGroup> footstepGroups;

		public EventSounds.RetriggerLimMode retriggerLimitMode;

		public int limitPerXFrm;

		public float limitPerXSec;

		public int triggeredLastFrame;

		public float triggeredLastTime;

		private Transform _trans;

		private Transform Trans => null;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private bool CheckForRetriggerLimit()
		{
			return false;
		}

		private void PlaySoundsIfMatch(GameObject go)
		{
		}
	}
}
