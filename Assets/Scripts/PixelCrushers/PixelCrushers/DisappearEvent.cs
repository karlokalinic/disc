using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class DisappearEvent : MonoBehaviour
	{
		public enum EventTrigger
		{
			OnDisable = 0,
			OnDestroy = 1
		}

		[SerializeField]
		private EventTrigger m_eventTrigger;

		[SerializeField]
		private UnityEvent m_onDisappeared;

		private bool m_ignore;

		public EventTrigger eventTrigger
		{
			get
			{
				return default(EventTrigger);
			}
			set
			{
			}
		}

		public UnityEvent onDisappeared
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void RunEvent()
		{
		}

		public void OnWillUnload(int sceneIndex)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
