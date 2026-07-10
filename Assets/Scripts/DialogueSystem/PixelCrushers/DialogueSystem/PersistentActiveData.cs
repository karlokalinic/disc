using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class PersistentActiveData : MonoBehaviour
	{
		public GameObject target;

		public Condition condition;

		public bool checkOnStart;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		public virtual void Check()
		{
		}
	}
}
