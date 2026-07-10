using FortressOccident;
using TMPro;
using UnityEngine;
using Voidforge;

public class FloatTemplate : FOComponent
{
	public RectTransform offscreen;

	public FloatFlash flash;

	public FloatLabel label;

	protected ComponentRef<WorldGhost> ghost;

	public bool destroyTarget;

	public FloatTemplate floatType;

	public TextMeshProUGUI _text;

	public AudioSource _audioSource;

	public string _fallbackText;

	public string _localizeTerm;

	private Canvas canvas;

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

	public string fallbackText
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

	public float AppearTime
	{
		set
		{
		}
	}

	public AudioSource audioSource => null;

	private void OnEnable()
	{
	}

	public void Appear()
	{
	}

	public void AppearDone()
	{
	}

	public void LevelChanged(bool whaa)
	{
	}

	public void SetSortValue(int sortingValue)
	{
	}

	private void Hide()
	{
	}

	private void Cleanup()
	{
	}

	private void OnLanguageChange()
	{
	}
}
