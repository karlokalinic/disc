using UnityEngine;

public class WorldGhost : MonoBehaviour
{
	public Transform target;

	public Vector3 offset;

	public bool clampToView;

	public RectTransform labelContainer;

	protected RectTransform parentRectTransform;

	protected RectTransform rectTransform;

	private RectTransform currentRectTransform;

	private const float Margin = 5f;

	private Vector2 defaultCurrentRectSize;

	private Vector2 defaultCurrentLocalPosition;

	private Vector2 defaultCurrentAnchoredPosition;

	private Vector2 defaultAnchorMax;

	private Vector2 defaultAnchorMin;

	private Vector2 defaultLocalPosition;

	private Vector2 defaultAnchoredPosition;

	private Vector2 defaultRectSize;

	private Vector2 defaultLayoutRectSize;

	private bool refreshedAfterAppearDone;

	private bool appearedOutsideOfView;

	public bool RefreshAfterAppearDone
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AppearedOutsideOfView
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void CheckAppearedOutsideOfView()
	{
	}

	public void ClampToViewport(bool checkIfOnScreen = false)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void SaveDefaultParameters()
	{
	}

	protected virtual void RestoreDefaultParameters()
	{
	}

	protected void SetParentLayoutWidth()
	{
	}
}
