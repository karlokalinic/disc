using System;
using UnityEngine;

namespace CollageMode
{
	public class FilterManager : MonoBehaviour, ISerializableManager
	{
		public class FilterSerializableData : SingularSerializableData
		{
			public float Intensity;
		}

		public Action OnSpecialFilterChanged;

		public string CurrentFilter { get; private set; }

		public float CurrentIntensity { get; private set; }

		public SpecialFilter CurrentSpecialFilter { get; private set; }

		public string SerializedCategoryName => null;

		public void SetFilter(string filterName, float intensity)
		{
		}

		public void SetPreview(bool isPreview)
		{
		}

		private void ToggleFilter(string filterName, bool isOn)
		{
		}

		private void CheckSpecialFilter(string filterName)
		{
		}

		public SerializableData Save()
		{
			return null;
		}

		public void Load(SerializableData data)
		{
		}
	}
}
