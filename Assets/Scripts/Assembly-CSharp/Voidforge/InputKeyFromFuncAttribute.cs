using System;
using UnityEngine;

namespace Voidforge
{
	public class InputKeyFromFuncAttribute : InputKeyAttribute
	{
		protected Func<KeyCode> _keyCodeFunc;

		public override KeyCode keyCode
		{
			get
			{
				return default(KeyCode);
			}
			protected set
			{
			}
		}

		public InputKeyFromFuncAttribute(Func<KeyCode> func)
			: base(default(KeyCode))
		{
		}
	}
}
