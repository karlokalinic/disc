using System;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class Usable : MonoBehaviour
	{
		[Serializable]
		public class UsableEvents
		{
			public UnityEvent onSelect;

			public UnityEvent onDeselect;

			public UnityEvent onUse;
		}

		public string overrideName;

		public string overrideUseMessage;

		public float maxUseDistance;

		public UsableEvents events;

		public virtual void Start()
		{
		}

		public string GetName()
		{
			return null;
		}

		public virtual void OnSelectUsable()
		{
		}

		public virtual void OnDeselectUsable()
		{
		}

		public virtual void OnUseUsable()
		{
		}
	}
}
