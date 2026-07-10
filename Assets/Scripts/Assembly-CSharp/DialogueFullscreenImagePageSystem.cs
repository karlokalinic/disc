using UnityEngine;
using UnityEngine.UI;

public class DialogueFullscreenImagePageSystem : MonoBehaviour
{
	[SerializeField]
	private Image image;

	private static DialogueFullscreenImagePageSystem singleton;

	public static DialogueFullscreenImagePageSystem Singleton => null;

	private void Awake()
	{
	}

	public void Show(string imageName)
	{
	}

	public void Hide()
	{
	}
}
