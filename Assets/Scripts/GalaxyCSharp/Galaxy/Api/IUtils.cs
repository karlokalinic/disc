using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class IUtils : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal IUtils(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(IUtils obj)
		{
			return default(HandleRef);
		}

		~IUtils()
		{
		}

		public virtual void Dispose()
		{
		}

		public virtual void GetImageSize(uint imageID, ref int width, ref int height)
		{
		}

		public virtual void GetImageRGBA(uint imageID, byte[] buffer, uint bufferLength)
		{
		}

		public virtual void RegisterForNotification(string type)
		{
		}

		public virtual uint GetNotification(ulong notificationID, ref bool consumable, ref byte[] type, uint typeLength, byte[] content, uint contentSize)
		{
			return 0u;
		}

		public virtual void ShowOverlayWithWebPage(string url)
		{
		}

		public virtual bool IsOverlayVisible()
		{
			return false;
		}

		public virtual OverlayState GetOverlayState()
		{
			return default(OverlayState);
		}

		public virtual void DisableOverlayPopups(string popupGroup)
		{
		}

		public virtual GogServicesConnectionState GetGogServicesConnectionState()
		{
			return default(GogServicesConnectionState);
		}
	}
}
