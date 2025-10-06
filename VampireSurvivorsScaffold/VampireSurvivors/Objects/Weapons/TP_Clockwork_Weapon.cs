/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Clockwork_Weapon : Weapon // TypeDefIndex: 16292
	{
		// Fields
		protected bool _initialisedParticles; // 0x158
		protected int _orologionCount; // 0x15C
		protected float _oroBonus; // 0x160
		protected List<WeaponType> _otherClockWeapons; // 0x168
		protected List<Weapon> _foundClockWeapons; // 0x170
	
		// Constructors
		public TP_Clockwork_Weapon() {} // 0x0000000186F91F10-0x0000000186F92220
	
		// Methods
		protected override void Awake() {} // 0x0000000186F6AB60-0x0000000186F6AB70
		public override float PPower() => default; // 0x0000000186F91220-0x0000000186F91310
		public override float PArea() => default; // 0x0000000186F91310-0x0000000186F91380
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F91380-0x0000000186F91440
		public override void InternalUpdate() {} // 0x0000000186F91440-0x0000000186F914D0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C30 */) {} // 0x0000000186F914D0-0x0000000186F91600
		public virtual void FireProjectiles(Vector2 pos) {} // 0x0000000186F91600-0x0000000186F91800
		private void UpdateOrologionCount() {} // 0x0000000186F91800-0x0000000186F91A20
		public override void CheckArcanas() {} // 0x0000000186F6A610-0x0000000186F6A620
		public override bool LevelUp(bool skipFire) => default; // 0x0000000186F91A20-0x0000000186F91A50
		protected void FireOthers() {} // 0x0000000186F91A50-0x0000000186F91C80
		public void FindClockWeapons() {} // 0x0000000186F91C80-0x0000000186F91F10
	}
}
