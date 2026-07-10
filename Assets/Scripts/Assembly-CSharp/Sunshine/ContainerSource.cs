using System;
using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Sunshine
{
	public class ContainerSource : BasicEntity
	{
		public static int LoadedContainersSourcesToLoad;

		public static int LoadedContainersSourcesToUnload;

		private static readonly List<string> PRYING_TOOLS;

		[SerializeField]
		public bool openedWithCrowbar;

		[SerializeField]
		public Difficulty difficulty;

		[SerializeField]
		public SkillType skillType;

		[SerializeField]
		[TextArea]
		public string conditionString;

		[SerializeField]
		public ItemSlot[] slots;

		[SerializeField]
		public bool destroyContainer;

		[NonSerialized]
		public List<ContainerItem> containedItems;

		public static Dictionary<string, ContainerItem[]> itemRegistry;

		public static Dictionary<string, ContainerSource> registry;

		public bool isLocked;

		private Coroutine updateIsInInteractionRadiusCor;

		private List<AsyncOperationHandle<Sprite>> itemIconHandlesitemIconHandle;

		public virtual Vector3 WorldPosition => default(Vector3);

		protected int Count => 0;

		public override bool PrerequisitesMet => false;

		public override SkillType InteractableSkill => default(SkillType);

		public override bool IsCheckPassed => false;

		public bool ContainsVisibleItems => false;

		protected override void OnAwakeInitialized()
		{
		}

		private void UpdateRegistry()
		{
		}

		protected override void OnSceneActivated()
		{
		}

		protected override void OnSceneDeactivated()
		{
		}

		private void OnItemIconLoaded(AsyncOperationHandle<Sprite> handle)
		{
		}

		public static void ApplyItems()
		{
		}

		public static void ClearRegistry()
		{
		}

		protected override void SetOutlineBySkill()
		{
		}

		public void StartUpdateIsWithinInteractionRadius()
		{
		}

		public void StopUpdateIsWithinInteractionRadius()
		{
		}

		public override void OnUse(Transform user = null)
		{
		}

		protected void CreateItems()
		{
		}

		public void RollItems()
		{
		}

		public void RollItemsOnce()
		{
		}

		public void RemoveItem(ContainerItem item)
		{
		}

		protected string GetItem(int index)
		{
			return null;
		}

		protected override void OnDisable()
		{
		}

		public void Emptied()
		{
		}

		private IEnumerator UpdateIsWithinInteractionRadius()
		{
			return null;
		}
	}
}
