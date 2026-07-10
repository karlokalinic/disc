using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class LODManager : MonoBehaviour
	{
		[Serializable]
		public class LOD
		{
			[SerializeField]
			private float m_minDistance;

			[SerializeField]
			private float m_maxDistance;

			public float minDistance
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float maxDistance
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool Contains(float distance)
			{
				return false;
			}
		}

		[SerializeField]
		private LOD[] m_levels;

		[SerializeField]
		private float m_monitorFrequency;

		private int m_currentLevel;

		private WaitForSeconds m_currentWaitForSeconds;

		private float m_currentWaitForSecondsValue;

		public LOD[] levels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float monitorFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Transform player { get; set; }

		private void Start()
		{
		}

		public void FindPlayer()
		{
		}

		private IEnumerator MonitorLOD()
		{
			return null;
		}

		public void CheckLOD()
		{
		}

		public static List<string> ZonePluginActivator()
		{
			return null;
		}
	}
}
