using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DiscoPlayable
{
    public sealed class DiscoAnimationEventRelay : MonoBehaviour
    {
        private static readonly BindingFlags MethodFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Install()
        {
            AttachToAnimators();
            SceneManager.sceneLoaded += (_, __) => AttachToAnimators();
        }

        private static void AttachToAnimators()
        {
            foreach (var animator in FindObjectsByType<Animator>(FindObjectsInactive.Include))
            {
                if (animator != null && animator.GetComponent<DiscoAnimationEventRelay>() == null)
                    animator.gameObject.AddComponent<DiscoAnimationEventRelay>();
            }
        }

        public void AnimationSync(AnimationEvent animationEvent) => Dispatch(nameof(AnimationSync), animationEvent);
        public void AppearObject(AnimationEvent animationEvent) => Dispatch(nameof(AppearObject), animationEvent);
        public void AppearObjectLeftHand(AnimationEvent animationEvent) => Dispatch(nameof(AppearObjectLeftHand), animationEvent);
        public void AppearObjectRightHand(AnimationEvent animationEvent) => Dispatch(nameof(AppearObjectRightHand), animationEvent);
        public void AppearObjectZero(AnimationEvent animationEvent) => Dispatch(nameof(AppearObjectZero), animationEvent);
        public void BedIdleFinish(AnimationEvent animationEvent) => Dispatch(nameof(BedIdleFinish), animationEvent);
        public void DestroyObject(AnimationEvent animationEvent) => Dispatch(nameof(DestroyObject), animationEvent);
        public void DisappearObject(AnimationEvent animationEvent) => Dispatch(nameof(DisappearObject), animationEvent);
        public void DisappearObjectLeftHand(AnimationEvent animationEvent) => Dispatch(nameof(DisappearObjectLeftHand), animationEvent);
        public void DisappearObjectRightHand(AnimationEvent animationEvent) => Dispatch(nameof(DisappearObjectRightHand), animationEvent);
        public void DoomedDoorCrash(AnimationEvent animationEvent) => Dispatch(nameof(DoomedDoorCrash), animationEvent);
        public void EventSound(AnimationEvent animationEvent) => Dispatch(nameof(EventSound), animationEvent);
        public void EventSoundAtTransform(AnimationEvent animationEvent) => Dispatch(nameof(EventSoundAtTransform), animationEvent);
        public void GetUpFromBedFinished(AnimationEvent animationEvent) => Dispatch(nameof(GetUpFromBedFinished), animationEvent);
        public void HideFlipClock(AnimationEvent animationEvent) => Dispatch(nameof(HideFlipClock), animationEvent);
        public void HideProp(AnimationEvent animationEvent) => Dispatch(nameof(HideProp), animationEvent);
        public void HideSkillArray(AnimationEvent animationEvent) => Dispatch(nameof(HideSkillArray), animationEvent);
        public void LeaderSpeaks(AnimationEvent animationEvent) => Dispatch(nameof(LeaderSpeaks), animationEvent);
        public void MessageObject(AnimationEvent animationEvent) => Dispatch(nameof(MessageObject), animationEvent);
        public void NewEvent(AnimationEvent animationEvent) => Dispatch(nameof(NewEvent), animationEvent);
        public void NotifyDisabledAnimationEvent(AnimationEvent animationEvent) => Dispatch(nameof(NotifyDisabledAnimationEvent), animationEvent);
        public void ObjectToCharPos(AnimationEvent animationEvent) => Dispatch(nameof(ObjectToCharPos), animationEvent);
        public void OnCharacterCreationFinalized(AnimationEvent animationEvent) => Dispatch(nameof(OnCharacterCreationFinalized), animationEvent);
        public void OnCreationDesintegrationFinished(AnimationEvent animationEvent) => Dispatch(nameof(OnCreationDesintegrationFinished), animationEvent);
        public void OnDecreaseRankAnimationFinished(AnimationEvent animationEvent) => Dispatch(nameof(OnDecreaseRankAnimationFinished), animationEvent);
        public void OnDecreaseRankAnimationStarted(AnimationEvent animationEvent) => Dispatch(nameof(OnDecreaseRankAnimationStarted), animationEvent);
        public void OnIncreaseRankAnimationFinished(AnimationEvent animationEvent) => Dispatch(nameof(OnIncreaseRankAnimationFinished), animationEvent);
        public void OnIncreaseRankAnimationStarted(AnimationEvent animationEvent) => Dispatch(nameof(OnIncreaseRankAnimationStarted), animationEvent);
        public void OnLeftFootDown(AnimationEvent animationEvent) => Dispatch(nameof(OnLeftFootDown), animationEvent);
        public void OnRightFootDown(AnimationEvent animationEvent) => Dispatch(nameof(OnRightFootDown), animationEvent);
        public void OnValueChangeAnimationFinished(AnimationEvent animationEvent) => Dispatch(nameof(OnValueChangeAnimationFinished), animationEvent);
        public void PostFXOff(AnimationEvent animationEvent) => Dispatch(nameof(PostFXOff), animationEvent);
        public void PostFXOn(AnimationEvent animationEvent) => Dispatch(nameof(PostFXOn), animationEvent);
        public void ShowFlipClock(AnimationEvent animationEvent) => Dispatch(nameof(ShowFlipClock), animationEvent);
        public void ShowSkillArray(AnimationEvent animationEvent) => Dispatch(nameof(ShowSkillArray), animationEvent);
        public void TriggerFX(AnimationEvent animationEvent) => Dispatch(nameof(TriggerFX), animationEvent);
        public void TriggerOtherAnimation(AnimationEvent animationEvent) => Dispatch(nameof(TriggerOtherAnimation), animationEvent);
        public void TriggerWorldFX(AnimationEvent animationEvent) => Dispatch(nameof(TriggerWorldFX), animationEvent);
        public void WarpNavAgent(AnimationEvent animationEvent) => Dispatch(nameof(WarpNavAgent), animationEvent);

        private void Dispatch(string functionName, AnimationEvent animationEvent)
        {
            foreach (var behaviour in GetComponents<MonoBehaviour>())
            {
                if (behaviour == null || behaviour == this) continue;
                if (TryInvoke(behaviour, functionName, animationEvent)) return;
            }

            var parent = transform.parent;
            while (parent != null)
            {
                foreach (var behaviour in parent.GetComponents<MonoBehaviour>())
                {
                    if (behaviour != null && TryInvoke(behaviour, functionName, animationEvent)) return;
                }

                parent = parent.parent;
            }
        }

        private static bool TryInvoke(MonoBehaviour behaviour, string functionName, AnimationEvent animationEvent)
        {
            var method = behaviour.GetType().GetMethod(functionName, MethodFlags);
            if (method == null) return false;

            var parameters = method.GetParameters();
            try
            {
                if (parameters.Length == 0)
                {
                    method.Invoke(behaviour, null);
                    return true;
                }

                if (parameters.Length != 1) return false;

                var parameterType = parameters[0].ParameterType;
                if (parameterType == typeof(AnimationEvent)) method.Invoke(behaviour, new object[] { animationEvent });
                else if (parameterType == typeof(string)) method.Invoke(behaviour, new object[] { animationEvent.stringParameter });
                else if (parameterType == typeof(float)) method.Invoke(behaviour, new object[] { animationEvent.floatParameter });
                else if (parameterType == typeof(int)) method.Invoke(behaviour, new object[] { animationEvent.intParameter });
                else if (parameterType == typeof(UnityEngine.Object)) method.Invoke(behaviour, new object[] { animationEvent.objectReferenceParameter });
                else return false;

                return true;
            }
            catch (Exception exception)
            {
                Debug.LogWarning($"[DiscoPlayable] Animation event '{functionName}' receiver '{behaviour.GetType().Name}' failed: {exception.GetBaseException().Message}", behaviour);
                return true;
            }
        }
    }
}