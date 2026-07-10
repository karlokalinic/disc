using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[NotKeyable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
	{
		public enum LoopMode
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}

		private enum Versions
		{
			Initial = 0,
			RotationAsEuler = 1
		}

		private static class AnimationPlayableAssetUpgrade
		{
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset)
			{
			}
		}

		[SerializeField]
		private AnimationClip m_Clip;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private bool m_UseTrackMatchFields;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private bool m_RemoveStartOffset;

		[SerializeField]
		private bool m_ApplyFootIK;

		[SerializeField]
		private LoopMode m_Loop;

		private static readonly int k_LatestVersion;

		[SerializeField]
		[HideInInspector]
		private int m_Version;

		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private Quaternion m_Rotation;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool useTrackMatchFields
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MatchTargetFields matchTargetFields
		{
			get
			{
				return default(MatchTargetFields);
			}
			set
			{
			}
		}

		public bool removeStartOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool applyFootIK
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LoopMode loop
		{
			get
			{
				return default(LoopMode);
			}
			set
			{
			}
		}

		internal bool hasRootTransforms => false;

		internal AppliedOffsetMode appliedOffsetMode { get; set; }

		public AnimationClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override double duration => 0.0;

		public override IEnumerable<PlayableBinding> outputs => null;

		public ClipCaps clipCaps => default(ClipCaps);

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop)
		{
			return default(Playable);
		}

		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip)
		{
			return false;
		}

		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode)
		{
			return false;
		}

		public void ResetOffsets()
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal static bool HasRootTransforms(AnimationClip clip)
		{
			return false;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		private void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
