using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Voidforge
{
	public class GetComponentAttribute : Attribute
	{
		protected bool? _addWhenMissing;

		public static GetComponentAttribute defaultValues;

		public bool addWhenMissing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool includeInactive { get; set; }

		public bool inChildren { get; set; }

		public bool inParents { get; set; }

		public bool inSelf { get; set; }

		public bool logWhenAdding { get; set; }

		public bool multiple { get; set; }

		public string name { get; set; }

		public bool regex { get; set; }

		public bool ShouldAdd<T>() where T : Component
		{
			return false;
		}

		public Regex GetRegex()
		{
			return null;
		}
	}
}
