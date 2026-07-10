using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IApps : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IApps(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IApps obj)
		{
			return default(HandleRef);
		}

		~IApps()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual bool IsDlcInstalled(ulong productID)
		{
			return false;
		}

		public virtual void IsDlcOwned(ulong productID, IIsDlcOwnedListener listener)
		{
		}

		public virtual string GetCurrentGameLanguage(ulong productID)
		{
			return null;
		}

		public virtual string GetCurrentGameLanguage()
		{
			return null;
		}

		public virtual void GetCurrentGameLanguageCopy(out string buffer, uint bufferLength, ulong productID)
		{
			buffer = null;
		}

		public virtual void GetCurrentGameLanguageCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}

		public virtual string GetCurrentGameLanguageCode(ulong productID)
		{
			return null;
		}

		public virtual string GetCurrentGameLanguageCode()
		{
			return null;
		}

		public virtual void GetCurrentGameLanguageCodeCopy(out string buffer, uint bufferLength, ulong productID)
		{
			buffer = null;
		}

		public virtual void GetCurrentGameLanguageCodeCopy(out string buffer, uint bufferLength)
		{
			buffer = null;
		}
	}
}
