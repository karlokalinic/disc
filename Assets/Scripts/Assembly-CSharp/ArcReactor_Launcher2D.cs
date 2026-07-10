using System;
using System.Collections.Generic;
using UnityEngine;

public class ArcReactor_Launcher2D : MonoBehaviour
{
	public class RayInfo
	{
		public ArcReactor_Arc arc;

		public Transform[] shape;

		public GameObject startObject;

		public GameObject endObject;

		public float distance;
	}

	[Serializable]
	public class ReflectionSettings
	{
		public ReflectSettings reflections;

		public Transform[] reflectors;

		public LayerMask reflectLayers;

		public float thickness;

		public int reflectionCountLimit;

		public bool sendMessageToReflectors;
	}

	public enum LaunchMethod
	{
		forward_raycast = 0,
		double_raycast = 1
	}

	public enum RayTransformBehaivour
	{
		immobile = 0,
		stick = 1,
		follow_raycast = 2
	}

	public enum ReflectSettings
	{
		no_reflections = 0,
		reflect_specified_objects = 1,
		reflect_by_layer = 2
	}

	public GameObject arcPrefab;

	public GameObject helperPrefab;

	public LaunchMethod launchMethod;

	public float Distance;

	public float PropagationSpeed;

	public LayerMask layers;

	public RayTransformBehaivour startBehaviour;

	public RayTransformBehaivour endBehaviour;

	public bool SendMessageToHitObjects;

	public bool SendMessageToTouchedObjects;

	public LayerMask touchLayers;

	public ReflectionSettings reflectionSettings;

	public Transform globalSpaceTransform;

	public Transform currentCameraTransform;

	private const int maxReflections = 100;

	private const float reflectGap = 0.01f;

	protected List<RayInfo> rays;

	protected Vector3[] posArray;

	protected int posArrayLen;

	protected Vector3[] positions;

	protected RaycastHit2D hit;

	protected List<RayInfo> destrArr;

	private bool quitting;

	public List<RayInfo> Rays => null;

	private void Awake()
	{
	}

	protected bool CheckReflectObject(Transform checkTr)
	{
		return false;
	}

	protected Vector2 Get2DVect(Vector3 input)
	{
		return default(Vector2);
	}

	protected Vector3 Get3DVect(Vector2 input, float Z)
	{
		return default(Vector3);
	}

	protected void FillPosArray(Vector3 position, Vector3 direction, float maxDistance, RayInfo rayInfo, int reflectionCount = 0)
	{
	}

	public void LaunchRay()
	{
	}

	public void DetachArcFromLauncher(int index)
	{
	}

	public void DetachAllArcsFromLauncher()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}
}
