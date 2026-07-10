using System;
using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	[CreateAssetMenu]
	public class OperationsSetCatalogue : ScriptableObject
	{
		[Serializable]
		public struct OperationsSetElement
		{
			[HideInInspector]
			public string name;

			public BaseOperationsSet operationsSet;
		}

		[SerializeField]
		private OperationsSetElement[] allOperationsSet;

		private Dictionary<Type, BaseOperationsSet> operationsDictionary;

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		private void UpdateElementsList()
		{
		}

		private void CreateDictionary()
		{
		}

		public BaseOperationsSet GetOperations<T>() where T : Operation
		{
			return null;
		}
	}
}
