using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FortressOccident
{
	public class BasicEntity : GameEntity
	{
		public enum InteractionState
		{
			NOT_ACTIVE = 0,
			DIALOGUE = 1,
			INTERACT = 2
		}

		private int LAYER_MOUSE;

		private int LAYER_HIDDEN;

		public bool outlinesOverride;

		public string conversation;

		public string themesong;

		public const string conditionFieldName = "Condition";

		public const string typeFieldName = "CheckType";

		public const string onUseFieldName = "OnUse";

		public const string overrideDialogueFieldName = "OverrideDialogueCondition";

		public const string difficultyField = "Difficulty";

		public const string viscalDifficultyField = "VisCalDifficulty";

		[NonSerialized]
		public bool wasShownCached;

		[NonSerialized]
		public bool isHiddenCached;

		[NonSerialized]
		public bool hasDialogueCached;

		public static List<BasicEntity> sceneEntitySet;

		public static BasicEntity[] sceneEntitiesToProcess;

		public Action DoOnceBeforeInteract;

		[NonSerialized]
		public BaseCustomCursor cursorOverride;

		private string condition;

		private Renderer _renderer;

		private Material material;

		private CameraMarker cameraMarker;

		private Renderer[] renderers;

		private Material[] materials;

		protected bool wasInit;

		private string conversantActorName;

		private string conversationActorName;

		private Scene sourceScene;

		private static HashSet<string> ignoreAreaEntities;

		private Conversation _conversationObject;

		private MouseOverHighlight moh;

		private static readonly int engage;

		protected virtual bool ResetInit => false;

		public virtual SkillType InteractableSkill => default(SkillType);

		public bool ConversationIsEmpty => false;

		public Conversation ConversationObject => null;

		public bool HasDialogue { get; private set; }

		public bool OverrideDialogue => false;

		public bool isHidden
		{
			set
			{
			}
		}

		public virtual bool IsAccessible => false;

		public virtual bool IsCheckPassed => false;

		public virtual int InteractableSkillThreshold => 0;

		public virtual bool PrerequisitesMet => false;

		public static void AddToSceneEntitySet(BasicEntity ent)
		{
		}

		public static void RemoveFromSceneEntitySet(BasicEntity ent)
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private bool AttachToAreaChange()
		{
			return false;
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnAwakeInitialized()
		{
		}

		protected virtual void OnStartInitialized()
		{
		}

		protected virtual void OnSceneActivated()
		{
		}

		protected virtual void OnSceneDeactivated()
		{
		}

		protected override void SendActivationEvent(bool active)
		{
		}

		public InteractionState GetInteractionState()
		{
			return default(InteractionState);
		}

		protected virtual bool CanPlayDialogue()
		{
			return false;
		}

		protected virtual void SetOutlineBySkill()
		{
		}

		public virtual void OnUse(Transform user = null)
		{
		}

		public virtual void ResetToDefault()
		{
		}

		private void CacheConversationData()
		{
		}

		public virtual void UpdateCache()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected void AddNPCPortraitsToCache()
		{
		}

		protected void RemoveNPCPortaitsFromCache()
		{
		}

		public void ReEvaluateAfterChange()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void StartConversation()
		{
		}

		private FormationMarker GetClosestFormation(FormationMarker[] markers)
		{
			return null;
		}

		public void PlayThemesong()
		{
		}
	}
}
