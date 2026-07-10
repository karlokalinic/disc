using System;
using System.Collections;
using UnityEngine;

namespace Sunshine.Hack
{
	public class KimKitsuragi : PartyMember<KimKitsuragi>
	{
		private const string SEAGULL_ATTACK_ZONE = "auto.seagull_landmark";

		private const string SEAGULL_ATTACK_KIM_BARK_CONDITION = "Variable[\"coast.orb_seagull_shit_attack\"] == true and Variable[\"coast.orb_seagull_kim_bark_seen\"] == false";

		private const string FALLBACK_GOODMORNING_BARK = "\"Good morning.\"";

		private const string FALLBACK_REMOVING_PISS_JACKET_BARK = "\"That's it, I'm done.\"";

		private const string KIM_SEAGULL_BARK = "Helen - EasterEggs / Flow – Seagull attack / Flow – COAST / Kim seagull ";

		public Action OnNotificationOn;

		public Action OnNotificationOff;

		public bool isRemovingPissJacket;

		public Coroutine RemovingPissJacketCoR;

		private bool isWaitingToRemovePissJacket;

		public bool GoodMorningBarkOnNextEncounter;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnKimEnterSeagullAttackZone(string obj)
		{
		}

		private void OnItemEquiped(string nameOfEquipedItem, EquipmentSlotType itemType, bool isEquipped)
		{
		}

		private void RemovePissJacket()
		{
		}

		private IEnumerator RemovePissJacketCoroutine()
		{
			return null;
		}

		public void NotificationOn()
		{
		}

		public void NotificationOff()
		{
		}

		public void NightyNight()
		{
		}

		public void NightyNightShack()
		{
		}

		public void RemoveAndHide()
		{
		}

		public void TryBarkGoodMorningAndReset()
		{
		}

		public void BarkOnSeagullsSite()
		{
		}

		public override void Remove()
		{
		}

		public void RemoveAndStay()
		{
		}

		public void Bark(string barkConversation)
		{
		}

		public static bool IsKitsuragi(string name)
		{
			return false;
		}

		public static bool KimBlackJacketActiveCondition()
		{
			return false;
		}

		public static string GetKimPortrait(string kimDefaultTextureName)
		{
			return null;
		}
	}
}
