using UnityEngine;

namespace PixelCrushers
{
	public abstract class Saver : MonoBehaviour
	{
		[SerializeField]
		private string m_key;

		[SerializeField]
		private bool m_appendSaverTypeToKey;

		[SerializeField]
		private bool m_saveAcrossSceneChanges;

		[SerializeField]
		private bool m_restoreStateOnStart;

		protected string m_runtimeKey;

		public bool appendSaverTypeToKey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string _internalKeyValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool saveAcrossSceneChanges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool restoreStateOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public abstract string RecordData();

		public abstract void ApplyData(string s);

		public virtual void ApplyDataImmediate()
		{
		}

		public virtual void OnBeforeSceneChange()
		{
		}

		public virtual void OnRestartGame()
		{
		}
	}
}
