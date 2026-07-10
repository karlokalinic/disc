using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sunshine
{
	[ExecuteInEditMode]
	public class LogicalEntity : MonoBehaviour
	{
		[SerializeField]
		protected string technicalName;

		[SerializeField]
		protected Scene scene;

		protected static HashSet<LogicalEntity> registry;

		public static implicit operator string(LogicalEntity entity)
		{
			return null;
		}

		public static LogicalEntity Find(string value)
		{
			return null;
		}

		public static List<LogicalEntity> FindAll(string value)
		{
			return null;
		}

		protected void Start()
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
