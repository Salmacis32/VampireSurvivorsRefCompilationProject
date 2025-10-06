/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_GrandCross2_BeamProjectile : Projectile // TypeDefIndex: 15576
	{
		// Fields
		private PhaserSprite _beamSprite; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private TP_GrandCross2_Weapon _trueWeapon; // 0xE8
	
		// Constructors
		public TP_GrandCross2_BeamProjectile() {} // 0x0000000186CB9520-0x0000000186CB9570
	
		// Methods
		protected override void Awake() {} // 0x0000000186CB86E0-0x0000000186CB8B40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CB8B40-0x0000000186CB8D80
		private void DoTweens() {} // 0x0000000186CB8D80-0x0000000186CB9230
		private int GetNumActiveBeams() => default; // 0x0000000186CB9230-0x0000000186CB9430
		public override void InternalUpdate() {} // 0x0000000186CB9430-0x0000000186CB94E0
		private void UpdateBeamSprite() {} // 0x0000000186CB9430-0x0000000186CB94E0
		public override void Despawn() {} // 0x0000000186CB94E0-0x0000000186CB9520
	}
}
