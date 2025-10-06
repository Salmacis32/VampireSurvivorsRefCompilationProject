/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Mace2_Weapon : Weapon // TypeDefIndex: 16424
	{
		// Fields
		[NonSerialized]
		public bool isCrit; // 0x158
		[NonSerialized]
		public int ExtraBodyAmount; // 0x15C
		private float maxCooldownOffset; // 0x160
		private float cooldownOffset; // 0x164
		private VampireSurvivors.Framework.TimerSystem.Timer _freezeTimer; // 0x168
		private bool _canFreeze; // 0x170
		private BulletPool _invisPool; // 0x178
		private BulletPool _critPool; // 0x180
		private BulletPool _standardPool; // 0x188
	
		// Constructors
		public TP_Mace2_Weapon() {} // 0x0000000186FD8B60-0x0000000186FD8BD0
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD7890-0x0000000186FD7E20
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CA5 */) {} // 0x0000000186FD7E20-0x0000000186FD8090
		protected override void OnUpdate() {} // 0x0000000186FD8090-0x0000000186FD8100
		public override float PInterval() => default; // 0x0000000186FD8100-0x0000000186FD8300
		protected bool OnCriticalBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FD8300-0x0000000186FD8660
		public void ShowBigDamage(float value, Vector3 position) {} // 0x0000000186FD8660-0x0000000186FD8780
		public bool FrameFreeze() => default; // 0x0000000186FD8780-0x0000000186FD8930
		public Projectile CreateStandardProjectile(int index) => default; // 0x0000000186FD8930-0x0000000186FD89C0
		public Projectile CreateCriticalProjectile(int index) => default; // 0x0000000186FD89C0-0x0000000186FD8A50
		protected override void OnDestroy() {} // 0x0000000186FD8A50-0x0000000186FD8B60
	}
}
