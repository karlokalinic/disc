using System;

namespace PixelCrushers
{
	[Serializable]
	public struct MessageArgs
	{
		public object sender;

		public object target;

		public string message;

		public string parameter;

		public object[] values;

		public bool hasTarget => false;

		public bool isTargetString => false;

		public string targetString => null;

		public object firstValue => null;

		public int intValue => 0;

		public MessageArgs(object sender, object target, string message, string parameter, object[] values = null)
		{
			this.sender = null;
			this.target = null;
			this.message = null;
			this.parameter = null;
			this.values = null;
		}

		public MessageArgs(object sender, string message, string parameter, object[] values = null)
		{
			this.sender = null;
			target = null;
			this.message = null;
			this.parameter = null;
			this.values = null;
		}

		public bool Matches(string message, string parameter)
		{
			return false;
		}

		public bool Matches(StringField message, StringField parameter)
		{
			return false;
		}

		public bool Matches(StringField message, string parameter)
		{
			return false;
		}

		public bool Matches(string message, StringField parameter)
		{
			return false;
		}

		public bool IsRequiredSender(string requiredSender)
		{
			return false;
		}

		public bool IsRequiredTarget(string requiredTarget)
		{
			return false;
		}

		public string GetSenderString()
		{
			return null;
		}

		public string GetTargetString()
		{
			return null;
		}

		private string GetObjectString(object obj)
		{
			return null;
		}
	}
}
