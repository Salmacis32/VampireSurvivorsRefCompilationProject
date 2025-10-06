/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class GarbageChuteWeapon : Weapon // TypeDefIndex: 16197
	{
		// Fields
		private float _chuteDefaultWidth; // 0x158
		private float _chuteMaxWidth; // 0x15C
		[NonSerialized]
		public float ChuteArea; // 0x160
		[NonSerialized]
		public float ChuteWidth; // 0x164
		[NonSerialized]
		public List<GarbageChuteMovement> _garbageChutes; // 0x168
		private List<float> _projectileCount; // 0x170
		private List<VampireSurvivors.Framework.TimerSystem.Timer> _projectileTimer; // 0x178
	
		// Constructors
		public GarbageChuteWeapon() {} // 0x0000000186F59280-0x0000000186F59300
	
		// Methods
		public override void CheckArcanas() {} // 0x0000000186F575B0-0x0000000186F57700
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F57700-0x0000000186F58000
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BBA */) {} // 0x0000000186F58000-0x0000000186F58050
		public void startFiringProjectile(int chuteIndex) {} // 0x0000000186F58050-0x0000000186F58680
		private void startNewChute() {} // 0x0000000186F58680-0x0000000186F58850
		private int freeChuteIndex() => default; // 0x0000000186F58850-0x0000000186F58920
		public void ProjectileComplete(int chuteIndex) {} // 0x0000000186F58920-0x0000000186F58BB0
		private void LateUpdate() {} // 0x0000000186F58BB0-0x0000000186F58E60
		public override void Cleanup() {} // 0x0000000186F58E60-0x0000000186F59280
	}
}
