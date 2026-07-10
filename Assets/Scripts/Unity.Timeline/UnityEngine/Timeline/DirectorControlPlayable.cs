using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	public class DirectorControlPlayable : PlayableBehaviour
	{
		public PlayableDirector director;

		private bool m_SyncTime;

		private double m_AssetDuration;

		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
		{
			return default(ScriptPlayable<DirectorControlPlayable>);
		}

		public override void OnPlayableDestroy(Playable playable)
		{
		}

		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		private void SyncSpeed(double speed)
		{
		}

		private void SyncPlayState(PlayableGraph graph, double playableTime)
		{
		}

		private bool DetectDiscontinuity(Playable playable, FrameData info)
		{
			return false;
		}

		private bool DetectOutOfSync(Playable playable)
		{
			return false;
		}

		private void UpdateTime(Playable playable)
		{
		}
	}
}
