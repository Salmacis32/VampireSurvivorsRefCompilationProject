/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GarbageChuteProjectile : Projectile // TypeDefIndex: 15444
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private GarbageChuteWeapon _trueWeapon; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xE0
		private float _grav; // 0xE8
		private float2 _initialVelocity; // 0xEC
		private int _chuteIndex; // 0xF4
		private int _itemSpriteIndex; // 0xF8
		private List<Sprite> _itemSprites; // 0x100
		private MultiTargetTween _rotationTween; // 0x108
		private bool _despawned; // 0x110
	
		// Constructors
		public GarbageChuteProjectile() {} // 0x0000000186C03980-0x0000000186C039E0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C01F80-0x0000000186C02CC0
		public void CustomFire(int chuteIndex) {} // 0x0000000186C02CC0-0x0000000186C031D0
		public override void InternalUpdate() {} // 0x0000000186C031D0-0x0000000186C03680
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C03680-0x0000000186C03710
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186C03710-0x0000000186C037B0
		public Sprite GetNextSprite() => default; // 0x0000000186C037B0-0x0000000186C03850
		public Sprite GetRandomSprite() => default; // 0x0000000186C03850-0x0000000186C03920
		public override void Despawn() {} // 0x0000000186C03920-0x0000000186C03980
	}
}
