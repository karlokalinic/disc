using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class NavigateOnMouseClick : MonoBehaviour
	{
		public enum MouseButtonType
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}

		public string animatorSpeedParameter;

		public float stoppingDistance;

		public MouseButtonType mouseButton;

		public bool ignoreClicksOnUI;

		private Transform m_myTransform;

		private Animator m_animator;

		private NavMeshAgent m_navMeshAgent;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
