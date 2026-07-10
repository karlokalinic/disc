using System.Collections;
using UnityEngine;
using Voidforge;

public class AudioListenerGlobalPosPersister : SingletonComponent<AudioListenerGlobalPosPersister>
{
	[SerializeField]
	private float step;

	private float initPos;

	private float inventoryPos;

	public void GoToInventoryPos()
	{
	}

	public void GoToInitialPos()
	{
	}

	private IEnumerator GoTo(float destination)
	{
		return null;
	}
}
