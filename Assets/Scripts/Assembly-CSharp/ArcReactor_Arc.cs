using System;
using UnityEngine;

public class ArcReactor_Arc : MonoBehaviour
{
	public enum PropagationType
	{
		instant = 0,
		globalSpaceSpeed = 1,
		localTimeCurve = 2
	}

	public enum ArcsPlaybackType
	{
		once = 0,
		loop = 1,
		pingpong = 2,
		clamp = 3,
		pingpong_once = 4,
		pingpong_clamp_once = 5
	}

	public enum InterpolationType
	{
		CatmullRom_Splines = 0,
		Linear = 1
	}

	public enum SpatialNoiseType
	{
		TangentRandomization = 0,
		CubicRandomization = 1,
		BrokenTangentRandomization = 2
	}

	public enum OscillationType
	{
		sine_wave = 0,
		rectangular = 1,
		zigzag = 2
	}

	public enum FadeTypes
	{
		none = 0,
		worldspacePoint = 1,
		relativePoint = 2
	}

	public enum ShapeTypes
	{
		start_only = 0,
		start_end = 1,
		start_curve_as_shape = 2
	}

	[Serializable]
	public struct SpatialInfo
	{
		public Vector3 position;

		public Vector3 tangent;
	}

	[Serializable]
	public class ArcNestingOptions
	{
		public bool Nested;

		public int parentArcIndex;

		public bool combinedNesting;

		public int secondaryArcIndex;

		public float nestingCoef;
	}

	[Serializable]
	public class EaseInOutOptions
	{
		public bool useEaseInOut;

		public AnimationCurve easeInOutCurve;

		public float distance;
	}

	[Serializable]
	public class ArcPropagationOptions
	{
		public PropagationType propagationType;

		public float globalSpeed;

		public AnimationCurve timeCurve;
	}

	[Serializable]
	public class ArcColorOptions
	{
		public Gradient startColor;

		public bool onlyStartColor;

		public Gradient endColor;

		public Gradient coreColor;

		public AnimationCurve coreCurve;

		public float coreJitter;

		public FadeTypes fade;

		public float fadePoint;

		public FadeTypes frontFade;

		public float frontFadePoint;
	}

	[Serializable]
	public class ArcSizeOptions
	{
		public InterpolationType interpolation;

		public ShapeTypes shapeType;

		public AnimationCurve startWidthCurve;

		public AnimationCurve endWidthCurve;

		public float segmentLength;

		public bool snapSegmentsToShape;

		public int numberOfSmoothingSegments;

		public int minNumberOfSegments;

		public int cornerVertices;

		public int capVectices;
	}

	[Serializable]
	public class TextureAnimationOptions
	{
		public Texture shapeTexture;

		public Texture noiseTexture;

		public AnimationCurve noiseCoef;

		public bool animateTexture;

		public float tileSize;

		public float noiseSpeed;
	}

	[Serializable]
	public class ArcSpatialNoiseOptions
	{
		public SpatialNoiseType type;

		public float scale;

		public float scaleMovement;

		public float scaleLimit;

		public float resetFrequency;

		public int invisiblePriority;
	}

	[Serializable]
	public class ArcLightsOptions
	{
		public bool lights;

		public float lightsRange;

		public float lightsIntensityMultiplyer;

		public LightRenderMode renderMode;

		public int priority;
	}

	[Serializable]
	public class OscillationInfo
	{
		public OscillationType type;

		public bool swirl;

		public float planeRotation;

		public float wavelength;

		public bool integerPeriods;

		public WavelengthMetric metric;

		public float amplitude;

		public float phase;

		public float phaseMovementSpeed;

		public int invisiblePriority;
	}

	[Serializable]
	public class ParticleEmissionOptions
	{
		public bool emit;

		public ParticleSystem shurikenPrefab;

		public bool emitAfterRayDeath;

		public float particlesPerMeter;

		public AnimationCurve emissionDuringLifetime;

		public AnimationCurve radiusCoefDuringLifetime;

		public AnimationCurve directionDuringLifetime;

		public float arcColorInfluence;
	}

	public enum WavelengthMetric
	{
		globalSpace = 0,
		localSpace = 1
	}

	[Serializable]
	public class ArcFlaresInfo
	{
		public FlareInfo startFlare;

		public FlareInfo endFlare;

		public bool useNoiseMask;

		public AnimationCurve noiseMaskPowerCurve;
	}

	[Serializable]
	public class FlareInfo
	{
		public bool enabled;

		public LensFlare flarePrefab;

		public Flare flare;

		public float fadeSpeed;

		public float maxBrightness;

		public float maxBrightnessDistance;

		public float minBrightness;

		public float minBrightnessDistance;
	}

	[Serializable]
	public class ShiftCurveInfo
	{
		public AnimationCurve shapeCurve;

		public float curveWidth;

		public float planeRotation;

		public WavelengthMetric metric;

		public float curveLength;

		public bool notAffectedByEaseInOut;

		public int invisiblePriority;
	}

	[Serializable]
	public class LineRendererInfo
	{
		public Material material;

		public ArcColorOptions colorOptions;

		public ArcSizeOptions sizeOptions;

		public ArcPropagationOptions propagationOptions;

		public ParticleEmissionOptions[] emissionOptions;

		public ArcSpatialNoiseOptions[] spatialNoise;

		public TextureAnimationOptions textureOptions;

		public ArcLightsOptions lightsOptions;

		public ArcFlaresInfo flaresOptions;

		public ArcNestingOptions nesting;

		public OscillationInfo[] oscillations;

		public ShiftCurveInfo[] shapeCurves;
	}

	public LineRendererInfo[] arcs;

	public float lifetime;

	public ArcsPlaybackType playbackType;

	public float elapsedTime;

	public bool playBackward;

	public bool freeze;

	public bool playbackMessages;

	public GameObject messageReciever;

	public Vector3[] shapePoints;

	public Transform[] shapeTransforms;

	public bool closedShape;

	public float sizeMultiplier;

	public InterpolationType interpolation;

	public EaseInOutOptions easeInOutOptions;

	public bool tangentsFromTransforms;

	public float tangentsFromTransformsPower;

	public bool[] transformsDestructionFlags;

	public Vector3 oscillationNormal;

	public bool localSpaceOcillations;

	public float reinitThreshold;

	public int performancePriority;

	public ArcReactorSingleLayer linerendererLayer;

	public Transform currentCameraTranform;

	public bool customSorting;

	public string sortingLayerName;

	public int sortingOrder;

	[NonSerialized]
	public bool currentlyInPool;

	private const int maxCalcDetalization = 10;

	protected SpatialInfo[] resultingShape;

	protected int oldShapeTransformsSize;

	protected float overlap;

	protected float[] noiseOffsets;

	protected float[] noiseScale;

	protected Vector3[,] arcPoints;

	protected Vector3[,] shiftVectors;

	protected Vector3[,] arcTangents;

	protected Quaternion[,] arcTangentsShift;

	protected Vector3[] shapeTangents;

	protected Vector3[][] vertices;

	protected Vector3[][] oldVertices;

	protected ParticleSystem.Particle[][][] particleBuffers;

	protected Transform[,] lightsTransforms;

	protected Light[,] lights;

	protected LineRenderer[] lrends;

	protected int[] segmNums;

	protected int[] vertexCount;

	protected int[] oldVertexCount;

	protected int[] lightsCount;

	protected float shapeLength;

	protected float oldShapeLength;

	protected float[] shapeKeyLocations;

	protected float[] shapeKeyNormalizedLocations;

	protected float[] maxStartWidth;

	protected float[] maxEndWidth;

	protected float[] coreCoefs;

	protected Vector3 oscNormal;

	protected LensFlare[] startFlares;

	protected LensFlare[] endFlares;

	protected ParticleSystem[][] emitterSystems;

	protected ArcReactor_EmitterDestructor[][] emitterDestructors;

	public float ShapeLength => 0f;

	public int PerformancePriority => 0;

	protected static float VectorFlatLength(Vector3 vector)
	{
		return 0f;
	}

	public static Vector3 HermiteCurvePoint(float t, Vector3 p0, Vector3 m0, Vector3 p1, Vector3 m1)
	{
		return default(Vector3);
	}

	public void FillResultingShape()
	{
	}

	public void SetPerformancePriority(int newPriority)
	{
	}

	protected Vector3 CalculateCurveShift(Vector3 direction, float position, int arcInd)
	{
		return default(Vector3);
	}

	protected Vector3 CalculateOscillationShift(Vector3 direction, float position, int arcInd)
	{
		return default(Vector3);
	}

	public float GetArcWidthAtPoint(int arc, float point)
	{
		return 0f;
	}

	protected void CalculateShape()
	{
	}

	protected int AddCyclicShift(int a, int b, int size)
	{
		return 0;
	}

	protected float AddCyclicShift(float a, float b, float size)
	{
		return 0f;
	}

	protected Quaternion RandomXYQuaternion(float angle)
	{
		return default(Quaternion);
	}

	protected void SetArcShape(int n)
	{
	}

	protected Vector3 CalcArcPoint(float point, int n)
	{
		return default(Vector3);
	}

	public Vector3 CalcShapePoint(float point)
	{
		return default(Vector3);
	}

	public Vector3 GetArcPoint(float point, int arcIndex)
	{
		return default(Vector3);
	}

	public Vector3 GetOldArcPoint(float point, int arcIndex)
	{
		return default(Vector3);
	}

	public float GetShiftCoef(float point)
	{
		return 0f;
	}

	public void ResetArc(int n)
	{
	}

	public void ResetArcNoise(int n, int noiseInd)
	{
	}

	protected float GetFlareBrightness(Vector3 currentCameraPosition, Vector3 flarePosition, FlareInfo flInfo, float multiplier = 1f)
	{
		return 0f;
	}

	protected void SetFlares(int n)
	{
	}

	public void Initialize()
	{
	}

	protected void SetShapeArrays()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public Vector3 RandomVector3(float range)
	{
		return default(Vector3);
	}

	public void DestroyArc()
	{
	}

	public void DisableArc()
	{
	}

	public void EnableArc()
	{
	}

	private void Update()
	{
	}

	public Vector3 GetArcEndPosition(int arcIndex)
	{
		return default(Vector3);
	}

	public float GetArcEndPoint(int arcIndex)
	{
		return 0f;
	}

	public void ExcludeFromPool()
	{
	}

	private void LateUpdate()
	{
	}
}
