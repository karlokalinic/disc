using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtSlotActionButton : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private Image image;

	[SerializeField]
	private GameObject starTemplate;

	private List<GameObject> stars;

	public Button Button
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Image Image
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitializeStars()
	{
	}

	public void SetupButtonStars(int starsToShow)
	{
	}

	private void SpawnNewStars(int starsToSpawn)
	{
	}
}
