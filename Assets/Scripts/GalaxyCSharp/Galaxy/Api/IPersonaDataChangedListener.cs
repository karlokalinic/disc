using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public abstract class IPersonaDataChangedListener : GalaxyTypeAwareListenerPersonaDataChanged
	{
		public delegate void SwigDelegateIPersonaDataChangedListener_0(IntPtr cPtr, IntPtr userID, uint personaStateChange);

		public enum PersonaStateChange
		{
			PERSONA_CHANGE_NONE = 0,
			PERSONA_CHANGE_NAME = 1,
			PERSONA_CHANGE_AVATAR = 2,
			PERSONA_CHANGE_AVATAR_DOWNLOADED_IMAGE_SMALL = 4,
			PERSONA_CHANGE_AVATAR_DOWNLOADED_IMAGE_MEDIUM = 8,
			PERSONA_CHANGE_AVATAR_DOWNLOADED_IMAGE_LARGE = 16,
			PERSONA_CHANGE_AVATAR_DOWNLOADED_IMAGE_ANY = 28
		}

		private static Dictionary<IntPtr, IPersonaDataChangedListener> listeners;

		private HandleRef swigCPtr;

		private SwigDelegateIPersonaDataChangedListener_0 swigDelegate0;

		private static Type[] swigMethodTypes0;

		internal IPersonaDataChangedListener(IntPtr cPtr, bool cMemoryOwn)
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		public IPersonaDataChangedListener()
			: base((IntPtr)0, cMemoryOwn: false)
		{
		}

		internal static HandleRef getCPtr(IPersonaDataChangedListener obj)
		{
			return default(HandleRef);
		}

		~IPersonaDataChangedListener()
		{
		}

		public override void Dispose()
		{
		}

		public abstract void OnPersonaDataChanged(GalaxyID userID, uint personaStateChange);

		private void SwigDirectorConnect()
		{
		}

		private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
		{
			return false;
		}

		private static void SwigDirectorOnPersonaDataChanged(IntPtr cPtr, IntPtr userID, uint personaStateChange)
		{
		}
	}
}
