using System.IO;
using Ionic.Zip;

namespace Ionic
{
	internal class AttributesCriterion : SelectionCriterion
	{
		private FileAttributes _Attributes;

		internal ComparisonOperator Operator;

		internal string AttributeString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		private bool _EvaluateOne(FileAttributes fileAttrs, FileAttributes criterionAttrs)
		{
			return false;
		}

		internal override bool Evaluate(string filename)
		{
			return false;
		}

		private bool _Evaluate(FileAttributes fileAttrs)
		{
			return false;
		}

		internal override bool Evaluate(ZipEntry entry)
		{
			return false;
		}
	}
}
