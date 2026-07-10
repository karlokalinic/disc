using UnityEngine;

namespace FontSizeProfiles.UIChangers
{
	public abstract class TMPChanger : MonoBehaviour
	{
		[SerializeField]
		protected string textElementID;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected abstract void OnLayoutChanged();
	}
}
