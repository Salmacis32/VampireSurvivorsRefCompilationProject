/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SwordBrothers_Projectile : Projectile // TypeDefIndex: 15700
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private float2 displayOffset; // 0xD8
		private MultiTargetTween _angleTween; // 0xE0
		private DG.Tweening.Sequence _windSequence; // 0xE8
		private TP_SwordBrothers_Weapon _trueWeapon; // 0xF0
		private List<TP_SwordBrothers_Firing_Projectile> bullets; // 0xF8
		private MultiTargetTween _alphaTween; // 0x100
		private PhaserSprite _displaySprite; // 0x108
		private float2 positionOffset; // 0x110
		private float physOffsetRadius; // 0x118
		private List<VampireSurvivors.Framework.TimerSystem.Timer> _bulletTimers; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _shootTimer; // 0x128
	
		// Constructors
		public TP_SwordBrothers_Projectile() {} // 0x0000000186D3C3A0-0x0000000186D3C400
	
		// Methods
		protected override void Awake() {} // 0x0000000186D3A400-0x0000000186D3A770
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D3A770-0x0000000186D3B390
		public void EmitBullets() {} // 0x0000000186D3B390-0x0000000186D3BA60
		public override void InternalUpdate() {} // 0x0000000186D3BA60-0x0000000186D3BBC0
		private void ShootBullets() {} // 0x0000000186D3BBC0-0x0000000186D3BD30
		private void FadeOutAndDispose() {} // 0x0000000186D3BD30-0x0000000186D3C1D0
		public override void Despawn() {} // 0x0000000186D3C1D0-0x0000000186D3C3A0
	}
}
