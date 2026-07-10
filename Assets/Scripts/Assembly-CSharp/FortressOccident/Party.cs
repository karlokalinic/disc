using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sunshine;
using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class Party : FOComponent
	{
		public const string YOU_ACTOR = "You";

		public const string KIM_ACTOR = "Kim Kitsuragi";

		public const string CUNO_ACTOR = "Cuno";

		[SerializeField]
		private bool isPlayerParty;

		[GetComponent]
		protected ComponentRef<Character> characters;

		[GetComponent]
		protected ComponentRef<FormationMarker> formations;

		private const float CHECK_CHARACTER_POSITION_INTERVAL = 1f;

		private WaitForSeconds characterCheckerWaitTime;

		public CameraMarker lastCameraMarker;

		public FormationMarker lastFormationMarker;

		private Formation _worldFormation;

		private Formation _defaultFormation;

		private Formation _dynamicFormation;

		public static Party Player { get; private set; }

		public Character this[int index] => null;

		public int this[long index] => 0;

		public int Count => 0;

		public Formation worldFormation
		{
			get
			{
				return default(Formation);
			}
			set
			{
			}
		}

		public Character Main => null;

		public event Action ChangeEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, bool> SelectedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static Party Create(params Character[] members)
		{
			return null;
		}

		public bool Add(Character character)
		{
			return false;
		}

		public Formation GetDefaultFormation(Formation.Purpose purpose = Formation.Purpose.UNIVERSAL)
		{
			return default(Formation);
		}

		public Formation GetDynamicFormation(Sector sector, bool predefinedSectorPos = false)
		{
			return default(Formation);
		}

		public bool ExecuteCommand(MovementCommand command)
		{
			return false;
		}

		private void SetDestination(MovementCommand command, int partyMemberIndex)
		{
		}

		public bool CheckMinimumDistanceToTequila(Vector3 endPosition)
		{
			return false;
		}

		public IEnumerator ExecuteCommandWithDelay(MovementCommand command, int partyMemberIndex)
		{
			return null;
		}

		public void CancelDelayedCommands()
		{
		}

		public void Remove(Character character, bool hide = true)
		{
		}

		public void SelectAll()
		{
		}

		public void SelectNone()
		{
		}

		public void SoloSelect(int charIndex)
		{
		}

		public void ToggleSelect(int charIndex)
		{
		}

		public int SelectionCount()
		{
			return 0;
		}

		private void SetSelected(int charIdx, bool value)
		{
		}

		protected override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void PartyCheckIfTheyHaveNotLostTheirPath()
		{
		}

		private void OnEnable()
		{
		}

		private IEnumerator CharacterCorrectPositionChecker()
		{
			return null;
		}

		private void EnableMainPartyMemberMovement()
		{
		}

		public void PlacementAdjustment(FormationMarker formationMarker)
		{
		}

		public static bool IsInParty(Character character)
		{
			return false;
		}

		public static int? GetPartyIndex(Character character)
		{
			return null;
		}

		private IEnumerator MoveOverTime(FormationMarker formationMarker)
		{
			return null;
		}
	}
}
