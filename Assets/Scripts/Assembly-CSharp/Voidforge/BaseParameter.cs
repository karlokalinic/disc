using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voidforge
{
	public abstract class BaseParameter : VoidElement
	{
		public virtual bool boolValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float floatValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual int intValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual string stringValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Vector3 vector3Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public event Action UpdateEvent
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

		protected void SendUpdateEvent()
		{
		}
	}
}
