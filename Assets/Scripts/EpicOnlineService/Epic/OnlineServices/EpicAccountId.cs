using System;

namespace Epic.OnlineServices
{
	public sealed class EpicAccountId : Handle
	{
		public const int EpicaccountidMaxLength = 32;

		public EpicAccountId()
		{
		}

		public EpicAccountId(IntPtr innerHandle)
		{
		}

		public static EpicAccountId FromString(string accountIdString)
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
