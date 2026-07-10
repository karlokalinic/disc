using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace IOSCamera
{
	public class iOSCameraLock
	{
		[SerializeField]
		private HashSet<object> cameraLocks;

		public bool IsLocked => false;

		public static event Action<bool> LockedEvent
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

		public bool AddLock(object lockObj)
		{
			return false;
		}

		public bool RemoveLock(object lockObj)
		{
			return false;
		}

		public bool CheckLock(object lockObj)
		{
			return false;
		}

		public bool RemoveAllLocksAndCenterViewport()
		{
			return false;
		}
	}
}
