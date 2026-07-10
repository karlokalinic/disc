using System;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public class LogPlayerUseWeaponData : ISettable
	{
		public IntPtr PlayerHandle { get; set; }

		public Vec3f PlayerPosition { get; set; }

		public Quat PlayerViewRotation { get; set; }

		public bool IsPlayerViewZoomed { get; set; }

		public bool IsMeleeAttack { get; set; }

		public string WeaponName { get; set; }

		internal void Set(LogPlayerUseWeaponDataInternal? other)
		{
		}

		public void Set(object other)
		{
		}
	}
}
