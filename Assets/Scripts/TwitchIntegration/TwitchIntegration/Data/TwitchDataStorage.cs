using UnityEngine.Events;

namespace TwitchIntegration.Data
{
	internal class TwitchDataStorage
	{
		internal string Secret { get; private set; }

		internal bool Enabled { get; private set; }

		internal UnityEvent<bool> OnEnableStateChanged { get; private set; }

		internal void Disable()
		{
		}

		internal void Enable()
		{
		}

		internal void SetSecret(string secret)
		{
		}

		internal void ValidateIfEnabled()
		{
		}
	}
}
