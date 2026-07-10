using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CollageMode
{
	public class SubDrawer : MonoBehaviour
	{
		public event Action OnShow
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnHide
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}
	}
}
