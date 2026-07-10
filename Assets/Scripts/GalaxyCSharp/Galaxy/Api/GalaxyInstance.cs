using System;
using System.Runtime.InteropServices;

namespace Galaxy.Api
{
	public static class GalaxyInstance
	{
		public class Error : ApplicationException
		{
			public Error(string message)
			{
			}
		}

		public class UnauthorizedAccessError : Error
		{
			public UnauthorizedAccessError(string message)
				: base(null)
			{
			}
		}

		public class InvalidArgumentError : Error
		{
			public InvalidArgumentError(string message)
				: base(null)
			{
			}
		}

		public class InvalidStateError : Error
		{
			public InvalidStateError(string message)
				: base(null)
			{
			}
		}

		public class RuntimeError : Error
		{
			public RuntimeError(string message)
				: base(null)
			{
			}
		}

		private class CustomExceptionHelper
		{
			public delegate void CustomExceptionDelegate(IError.Type type, string message);

			private static CustomExceptionDelegate customDelegate;

			static CustomExceptionHelper()
			{
			}

			[PreserveSig]
			public static extern void CustomExceptionRegisterCallback(CustomExceptionDelegate customCallback);

			private static void SetPendingCustomException(IError.Type type, string message)
			{
			}
		}

		private static CustomExceptionHelper exceptionHelper;

		static GalaxyInstance()
		{
		}

		public static IError GetError()
		{
			return null;
		}

		public static IListenerRegistrar ListenerRegistrar()
		{
			return null;
		}

		public static IListenerRegistrar GameServerListenerRegistrar()
		{
			return null;
		}

		public static void Init(InitParams initpParams)
		{
		}

		public static void InitGameServer(InitParams initpParams)
		{
		}

		public static void Shutdown(bool unloadModule)
		{
		}

		public static void ShutdownEx(ShutdownParams shutdownParams)
		{
		}

		public static void ShutdownGameServerEx(ShutdownParams shutdownParams)
		{
		}

		public static IUser User()
		{
			return null;
		}

		public static IFriends Friends()
		{
			return null;
		}

		public static IChat Chat()
		{
			return null;
		}

		public static IMatchmaking Matchmaking()
		{
			return null;
		}

		public static INetworking Networking()
		{
			return null;
		}

		public static IStats Stats()
		{
			return null;
		}

		public static IUtils Utils()
		{
			return null;
		}

		public static IApps Apps()
		{
			return null;
		}

		public static IStorage Storage()
		{
			return null;
		}

		public static ICustomNetworking CustomNetworking()
		{
			return null;
		}

		public static ILogger Logger()
		{
			return null;
		}

		public static ITelemetry Telemetry()
		{
			return null;
		}

		public static ICloudStorage CloudStorage()
		{
			return null;
		}

		public static void ProcessData()
		{
		}

		public static void ShutdownGameServer()
		{
		}

		public static IUser GameServerUser()
		{
			return null;
		}

		public static IMatchmaking GameServerMatchmaking()
		{
			return null;
		}

		public static INetworking GameServerNetworking()
		{
			return null;
		}

		public static IUtils GameServerUtils()
		{
			return null;
		}

		public static ITelemetry GameServerTelemetry()
		{
			return null;
		}

		public static ILogger GameServerLogger()
		{
			return null;
		}

		public static void ProcessGameServerData()
		{
		}
	}
}
