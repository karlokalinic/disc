using System;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class CustomEvent
	{
		public string EventName;

		public string ProspectiveName;

		public bool eventExpanded;

		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		public float distanceThreshold;

		public int frameLastFired;

		public CustomEvent(string eventName)
		{
		}
	}
}
