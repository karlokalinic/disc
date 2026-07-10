using System.Collections.Generic;
using UnityEngine;
using Voidforge;

namespace Sunshine.Unseen
{
	[ExecuteInEditMode]
	public class Zone : ShaderScript
	{
		public enum Status
		{
			UNSEEN = 0,
			ACTIVE = 1,
			INACTIVE = 2
		}

		private static ComponentRegistry<Zone> allZones;

		[SerializeField]
		private Shader unseenZoneShader;

		[SerializeField]
		private Material zoneMaterial;

		[SerializeField]
		private Status _status;

		private Dictionary<Observer, int> observers;

		private List<MonoBehaviour> interactables;

		[GetComponent]
		private ComponentRef<Renderer> renderers;

		private ActiveCurve cachedActiveCurve;

		private ActiveValues cachedActiveValues;

		private InactiveCurve cachedInactiveCurve;

		private InactiveValues cachedInactiveValues;

		private UnseenValues cachedUnseenValues;

		private Vector4 prevValues;

		private float _statusTime;

		private bool updateCache;

		private List<Observer> observersList;

		public Status status
		{
			get
			{
				return default(Status);
			}
			set
			{
			}
		}

		[NormalUpdate]
		public float timer
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private Vector4 unseenValues => default(Vector4);

		public bool hasObservers => false;

		private T GetComponent<T>(ref T cachedValues) where T : Component
		{
			return null;
		}

		private void Reset()
		{
		}

		public bool AddObserver(Observer o)
		{
			return false;
		}

		public bool RemoveObserver(Observer o)
		{
			return false;
		}

		public bool AddInteractable(MonoBehaviour o)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
