/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_LongswordProjectile_GaleSlash : Projectile // TypeDefIndex: 15797
	{
		// Fields
		[SerializeField]
		private MeshRenderer galeSlashVFX; // 0xD0
		private const float RADIUS = 50f; // Metadata: 0x0197786C
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186DBC980-0x0000000186DBC9F0 
	
		// Constructors
		public EME_LongswordProjectile_GaleSlash() {} // 0x0000000186DBD360-0x0000000186DBD3B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DBC9F0-0x0000000186DBCB70
		private void SetupMechanics() {} // 0x0000000186DBCB70-0x0000000186DBD100
		private void SetupVFX() {} // 0x0000000186DBD100-0x0000000186DBD300
		public override void Despawn() {} // 0x0000000186DBD300-0x0000000186DBD360
	}
}
