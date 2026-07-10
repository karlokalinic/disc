using System;
using System.Collections.Generic;
using FullSerializer.Internal;

namespace FullSerializer
{
	public class fsAotCompilationManager
	{
		public static HashSet<Type> AotCandidateTypes;

		private static bool HasMember(fsAotVersionInfo versionInfo, fsAotVersionInfo.Member member)
		{
			return false;
		}

		public static bool IsAotModelUpToDate(fsMetaType currentModel, fsIAotConverter aotModel)
		{
			return false;
		}

		public static string RunAotCompilationForType(fsConfig config, Type type)
		{
			return null;
		}

		private static string EmitVersionInfo(string prefix, Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
			return null;
		}

		private static string GetConverterString(fsMetaProperty member)
		{
			return null;
		}

		public static string GetQualifiedConverterNameForType(Type type)
		{
			return null;
		}

		private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
		{
			return null;
		}
	}
}
