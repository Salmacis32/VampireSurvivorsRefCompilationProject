/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Energy1_Weapon : Weapon // TypeDefIndex: 16350
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x168
		protected Weapon _counterWeapon; // 0x170
		protected SantaJavelinCounterWeapon _counterSet; // 0x178
		protected bool _hasCounterSet; // 0x180
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Energy1_Weapon() {} // 0x0000000186FB1D90-0x0000000186FB1DF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FB0DD0-0x0000000186FB0FB0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB0FB0-0x0000000186FB1070
		public override void InternalUpdate() {} // 0x0000000186FB1070-0x0000000186FB1450
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C65 */) {} // 0x0000000186FB1450-0x0000000186FB1700
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FB1700-0x0000000186FB1780
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C66 */) {} // 0x0000000186FB1780-0x0000000186FB1A00
		public override bool LevelUp() => default; // 0x0000000186FB1A00-0x0000000186FB1B20
		public override void CheckArcanas() {} // 0x0000000186FB1B20-0x0000000186FB1D90
		public override void SetVisible(bool visible) {} // 0x0000000186FA7E20-0x0000000186FA7E50
	}
}
