using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 128)]
	internal struct CatalogOfferInternal : ISettable, IDisposable
	{
		private int m_ApiVersion;

		private int m_ServerIndex;

		private IntPtr m_CatalogNamespace;

		private IntPtr m_Id;

		private IntPtr m_TitleText;

		private IntPtr m_DescriptionText;

		private IntPtr m_LongDescriptionText;

		private IntPtr m_TechnicalDetailsText_DEPRECATED;

		private IntPtr m_CurrencyCode;

		private Result m_PriceResult;

		private uint m_OriginalPrice_DEPRECATED;

		private uint m_CurrentPrice_DEPRECATED;

		private byte m_DiscountPercentage;

		private long m_ExpirationTimestamp;

		private uint m_PurchasedCount;

		private int m_PurchaseLimit;

		private int m_AvailableForPurchase;

		private ulong m_OriginalPrice64;

		private ulong m_CurrentPrice64;

		private uint m_DecimalPoint;

		public int ServerIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string CatalogNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DescriptionText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LongDescriptionText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TechnicalDetailsText_DEPRECATED
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrencyCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Result PriceResult
		{
			get
			{
				return default(Result);
			}
			set
			{
			}
		}

		public uint OriginalPrice_DEPRECATED
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint CurrentPrice_DEPRECATED
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public byte DiscountPercentage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long ExpirationTimestamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public uint PurchasedCount
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public int PurchaseLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool AvailableForPurchase
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ulong OriginalPrice64
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong CurrentPrice64
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public uint DecimalPoint
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public void Set(CatalogOffer other)
		{
		}

		public void Set(object other)
		{
		}

		public void Dispose()
		{
		}
	}
}
