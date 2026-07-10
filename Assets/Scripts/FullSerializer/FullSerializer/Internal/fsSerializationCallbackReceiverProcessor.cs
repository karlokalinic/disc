using System;

namespace FullSerializer.Internal
{
	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}
	}
}
