using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace CollageMode
{
	public class CollageSerializer : LiteSingleton<CollageSerializer>
	{
		public class CollageData : Dictionary<string, SerializableData>
		{
		}

		public OperationsSetCatalogue operationsSets;

		[SerializeField]
		private TMP_InputField debugSaveInputField;

		[TextArea]
		public string testString;

		public static T GetOperation<T>(string identifier) where T : Operation
		{
			return null;
		}

		protected override void Awake()
		{
		}

		private List<ISerializableManager> GetAllSerializableManagers()
		{
			return null;
		}

		public void Save()
		{
		}

		public void Load()
		{
		}

		public void Load(CollageData save)
		{
		}
	}
}
