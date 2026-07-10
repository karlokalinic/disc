namespace Epic.OnlineServices.Ecom
{
	public class CatalogOffer : ISettable
	{
		public int ServerIndex { get; set; }

		public string CatalogNamespace { get; set; }

		public string Id { get; set; }

		public string TitleText { get; set; }

		public string DescriptionText { get; set; }

		public string LongDescriptionText { get; set; }

		public string TechnicalDetailsText_DEPRECATED { get; set; }

		public string CurrencyCode { get; set; }

		public Result PriceResult { get; set; }

		public uint OriginalPrice_DEPRECATED { get; set; }

		public uint CurrentPrice_DEPRECATED { get; set; }

		public byte DiscountPercentage { get; set; }

		public long ExpirationTimestamp { get; set; }

		public uint PurchasedCount { get; set; }

		public int PurchaseLimit { get; set; }

		public bool AvailableForPurchase { get; set; }

		public ulong OriginalPrice64 { get; set; }

		public ulong CurrentPrice64 { get; set; }

		public uint DecimalPoint { get; set; }

		internal void Set(CatalogOfferInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
