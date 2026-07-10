using System.Collections;
using UnityEngine;

public class AnimateCookieTexture : MonoBehaviour
{
	public enum AnimMode
	{
		forwards = 0,
		backwards = 1,
		random = 2
	}

	public Texture2D[] textures;

	public float fps;

	public AnimMode animMode;

	private int frameNr;

	private Light cLight;

	private void Start()
	{
	}

	private IEnumerator switchCookie()
	{
		return null;
	}
}
