using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIInstancedContentManager
	{
		protected List<StandardUIContentTemplate> instances;

		public List<StandardUIContentTemplate> instancedContent => null;

		public void Clear()
		{
		}

		public T Instantiate<T>(T template) where T : StandardUIContentTemplate
		{
			return null;
		}

		public void Add(StandardUIContentTemplate instance, RectTransform container)
		{
		}

		public void Remove(StandardUIContentTemplate instance)
		{
		}

		public StandardUIContentTemplate GetLastAdded()
		{
			return null;
		}
	}
}
