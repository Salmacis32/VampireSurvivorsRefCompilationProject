/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Chauve2_Projectile : TP_Chauve1_Projectile // TypeDefIndex: 15512
	{
		// Fields
		[SerializeField]
		private Transform _BeamSpawnPoint; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _animTimer; // 0x120
		private float _beamXOffset; // 0x128
		private TP_Chauve2_Weapon _trueWeapon; // 0x130
	
		// Properties
		protected override bool IsEvo { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected override string SpriteName { get => default; } // 0x0000000186C729B0-0x0000000186C729F0 
		protected override string SpriteObjectName { get => default; } // 0x0000000186C729F0-0x0000000186C72A30 
		protected override uint Tint { get => default; } // 0x0000000186C72A30-0x0000000186C72A40 
	
		// Constructors
		public TP_Chauve2_Projectile() {} // 0x0000000186C706E0-0x0000000186C70730
	
		// Methods
		protected override void Awake() {} // 0x0000000186C72A40-0x0000000186C72B20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C72B20-0x0000000186C72CD0
		private void CheckForCrit() {} // 0x0000000186C72CD0-0x0000000186C72D80
		protected override void MakeCritProjectile() {} // 0x0000000186C72D80-0x0000000186C734E0
		private void DoCritAnim() {} // 0x0000000186C734E0-0x0000000186C73670
		public override void Despawn() {} // 0x0000000186C73670-0x0000000186C736D0
	}
}
