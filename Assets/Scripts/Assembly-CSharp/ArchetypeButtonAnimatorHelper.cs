using UnityEngine;

public class ArchetypeButtonAnimatorHelper : MonoBehaviour
{
	[SerializeField]
	private float flickerRandomization;

	private Animator animator;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Hovered
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Selected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OtherSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float FlickerSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void RandomizeFlickerSpeed()
	{
	}
}
