using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PixelCrushers.DialogueSystem
{
	public static class SymbolExtensions
	{
		public static MethodInfo GetMethodInfo(Expression<Action> expression)
		{
			return null;
		}

		public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression)
		{
			return null;
		}

		public static MethodInfo GetMethodInfo<T, TResult>(Expression<Func<T, TResult>> expression)
		{
			return null;
		}

		public static MethodInfo GetMethodInfo(LambdaExpression expression)
		{
			return null;
		}
	}
}
