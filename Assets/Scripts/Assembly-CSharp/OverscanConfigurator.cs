using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OverscanConfigurator : MonoBehaviour
{
	public GameObject localUIFitter;

	public Image image;

	public Text MainText;

	public Text EnlargeText;

	public Text ShrinkText;

	public Text ContinueText;

	private bool startGame;

	private float overscan;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnOverscanChanged(float per, float size)
	{
	}

	private void Update()
	{
	}

	private IEnumerator FadeOutAndStartTheGame()
	{
		return null;
	}
}
