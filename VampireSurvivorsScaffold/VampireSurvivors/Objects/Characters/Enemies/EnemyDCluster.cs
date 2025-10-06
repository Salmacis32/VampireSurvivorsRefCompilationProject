/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDCluster : EnemyDMask // TypeDefIndex: 17291
	{
		// Fields
		private bool _canEmitParticles; // 0x280
		private MultiTargetTween _onEnterTween; // 0x288
		private ParticleSystem _pfxEmitter; // 0x290
		private VampireSurvivors.Framework.TimerSystem.Timer _particlesTimer; // 0x298
		private float _particlesDelay; // 0x2A0
	
		// Constructors
		public EnemyDCluster() {} // 0x00000001872412D0-0x0000000187241330
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872400E0-0x0000000187240330
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019783E9 */, float damageKb = 1f /* Metadata: 0x019783EA */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019783EE */, bool hasKb = true /* Metadata: 0x019783EF */) {} // 0x0000000187240330-0x0000000187240A30
		private void GenerateParticleSystems() {} // 0x0000000187240A30-0x00000001872412D0
	}
}
