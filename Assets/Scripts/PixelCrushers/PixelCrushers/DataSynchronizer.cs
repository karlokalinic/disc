using UnityEngine;

namespace PixelCrushers
{
	public class DataSynchronizer : MonoBehaviour, IMessageHandler
	{
		public const string DataSourceValueChangedMessage = "Data Source Value Changed";

		public const string RequestDataSourceChangeValueMessage = "Request Data Source Change Value";

		[SerializeField]
		private string m_dataSourceName;

		[SerializeField]
		private ObjectUnityEvent m_onRequestDataSourceChangeValue;

		public string dataSourceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectUnityEvent onRequestDataSourceChangeValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnMessage(MessageArgs messageArgs)
		{
		}

		public void DataSourceValueChanged(object newValue)
		{
		}
	}
}
