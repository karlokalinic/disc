using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Timeline
{
	public class SignalAsset : ScriptableObject
	{
		internal static event Action<SignalAsset> OnEnableCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}
	}
}
