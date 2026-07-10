using UnityEngine;

namespace PixelCrushers
{
	public class ScenePortal : MonoBehaviour
	{
		[SerializeField]
		private string m_requiredTag;

		[SerializeField]
		private string m_destinationSceneName;

		[SerializeField]
		private string m_spawnpointNameInDestinationScene;

		private bool m_isLoadingScene;

		public string requiredTag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string destinationSceneName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string spawnpointNameInDestinationScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLoadingScene
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void UsePortal()
		{
		}

		protected void LoadScene()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
