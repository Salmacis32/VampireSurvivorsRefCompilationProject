/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SummonSpirit_Weapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16504
	{
		// Fields
		private float2 _bulletStartOffset; // 0x160
		private bool _isManualFire; // 0x168
		protected PhaserSprite _animatedSprite; // 0x170
		protected MultiTargetTween _alphaTween; // 0x178
		private float emissionTime; // 0x180
		private float emissionDuration; // 0x184
	
		// Properties
		protected virtual float2 BulletSpawnPos { get => default; } // 0x0000000186FF8730-0x0000000186FF8780 
		protected virtual SpriteTextureData PortalSprite { get => default; } // 0x0000000186FF8780-0x0000000186FF88F0 
		public bool IsUnion { get; set; } // 0x00000001827669D0-0x00000001827669E0 0x0000000186FF88F0-0x0000000186FF8900
	
		// Constructors
		public TP_SummonSpirit_Weapon() {} // 0x0000000186FF86C0-0x0000000186FF8730
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FF8900-0x0000000186FF8CA0
		public void SetManualFire() {} // 0x0000000186FF8CA0-0x0000000186FF8CC0
		public override void InternalUpdate() {} // 0x0000000186FF8CC0-0x0000000186FF93B0
		private void RefreshTarget(TP_SummonSpirit_Projectile bullet) {} // 0x0000000186FF93B0-0x0000000186FF9660
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FF9660-0x0000000186FF98F0
		private float GetDegreesPerSecond() => default; // 0x0000000186FF98F0-0x0000000186FF9980
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CFF */) {} // 0x0000000186FF9980-0x0000000186FF9E80
		public override void ResetFiringTimer() {} // 0x0000000186FF9E80-0x0000000186FF9EB0
		public override void SetVisible(bool visible) {} // 0x0000000186FF9EB0-0x0000000186FF9EF0
		protected virtual void SetPortalPosition() {} // 0x0000000186FF9EF0-0x0000000186FF9F60
		protected virtual void DoPortalTween() {} // 0x0000000186FF9F60-0x0000000186FFA250
		private void PlayFiringSfx(float detune) {} // 0x0000000186FFA250-0x0000000186FFA330
		public override void Cleanup() {} // 0x0000000186FFA330-0x0000000186FFA380
	}
}
