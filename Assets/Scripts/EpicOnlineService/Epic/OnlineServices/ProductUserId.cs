using System;

namespace Epic.OnlineServices
{
	public sealed class ProductUserId : Handle
	{
		public const int ProductuseridMaxLength = 32;

		public ProductUserId()
		{
		}

		public ProductUserId(IntPtr innerHandle)
		{
		}

		public static ProductUserId FromString(string productUserIdString)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}

		public Result ToString(out string outBuffer)
		{
			outBuffer = null;
			return default(Result);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
