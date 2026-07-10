using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIContainerTemplate : StandardUIContentTemplate
	{
		[NonSerialized]
		private List<StandardUIContentTemplate> m_instances;

		public List<StandardUIContentTemplate> instances => null;

		public void AddInstanceToContainer(StandardUIContentTemplate instance)
		{
		}

		public override void Despawn()
		{
		}
	}
}
