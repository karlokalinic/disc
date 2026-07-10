using UnityEngine;

namespace Voidforge
{
	public interface IComponentRef
	{
		void Initialize(Component container, GetComponentAttribute attr);

		void Clear();
	}
}
