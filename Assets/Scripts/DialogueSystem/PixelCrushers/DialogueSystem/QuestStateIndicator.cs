using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestStateIndicator : MonoBehaviour
	{
		public GameObject[] indicators;

		private List<List<QuestStateListener>> m_currentIndicatorCount;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeCurrentIndicatorCount()
		{
		}

		public void SetIndicatorLevel(QuestStateListener listener, int indicatorLevel)
		{
		}

		public void UpdateIndicator()
		{
		}
	}
}
