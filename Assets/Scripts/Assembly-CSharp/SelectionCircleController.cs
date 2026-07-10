using UnityEngine;
using Voidforge;

public class SelectionCircleController : SingletonComponent<SelectionCircleController>
{
	public static float circleTarget;

	public static float tabTarget;

	private static SenseOrb pendingOrb;

	private static readonly int foOrbitState;

	private static readonly int foColSense;

	private static readonly int foHighlightThickness;

	public Transform circle;

	public Transform selection;

	public Transform orbit;

	public Transform circleRotate;

	public Renderer circleRenderer;

	public AnimationCurve aniUp;

	public AnimationCurve aniDown;

	public AnimationCurve outlineAppear;

	public AnimationCurve outlineDisappear;

	public AnimationCurve aniCurrent;

	public float circleState;

	public float tabState;

	[SerializeField]
	private float aniTime;

	[SerializeField]
	private float spinSpeed;

	private Quaternion rotation;

	public static SenseOrb PendingOrb
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool DetectiveMode => false;

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void GoUp()
	{
	}

	public void GoDown(bool closeCurrent = true)
	{
	}

	private void TestAddGlobal()
	{
	}

	private void TestRemoveGlobal()
	{
	}

	private void HideCircle()
	{
	}

	private void SceneRunningCallback(bool isRunning)
	{
	}

	private void SceneNotRunningCallback()
	{
	}
}
