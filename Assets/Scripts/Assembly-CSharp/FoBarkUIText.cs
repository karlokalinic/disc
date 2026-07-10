using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public class FoBarkUIText : MonoBehaviour
{
	private WorldGhost ghost;

	private Tween delay;

	public Text _text;

	private Timer timer;

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 Offset
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void GoAway()
	{
	}
}
