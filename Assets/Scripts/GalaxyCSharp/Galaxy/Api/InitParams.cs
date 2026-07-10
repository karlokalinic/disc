using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public class InitParams : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string clientID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string clientSecret
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string configFilePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string storagePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string galaxyModulePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool loadModule
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal InitParams(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		public InitParams(string _clientID, string _clientSecret, string _configFilePath, string _galaxyModulePath, bool _loadModule, string _storagePath)
		{
		}

		public InitParams(string _clientID, string _clientSecret, string _configFilePath, string _galaxyModulePath, bool _loadModule)
		{
		}

		public InitParams(string _clientID, string _clientSecret, string _configFilePath, string _galaxyModulePath)
		{
		}

		public InitParams(string _clientID, string _clientSecret, string _configFilePath)
		{
		}

		public InitParams(string _clientID, string _clientSecret)
		{
		}

		internal static HandleRef getCPtr(InitParams obj)
		{
			return default(HandleRef);
		}

		~InitParams()
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
