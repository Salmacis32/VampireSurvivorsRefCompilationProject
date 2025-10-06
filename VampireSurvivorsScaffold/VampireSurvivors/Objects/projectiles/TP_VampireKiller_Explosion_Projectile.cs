/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_VampireKiller_Explosion_Projectile : Projectile // TypeDefIndex: 15714
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private Tween _scaleTween; // 0xD8
		private PhaserSprite _animatedSprite; // 0xE0
		private PhaserSprite _sunraySprite; // 0xE8
		private uint[] _tints; // 0xF0
		private List<PhaserSprite> explosionSprites; // 0xF8
		private string[] _sideNames; // 0x100
		private string[] _starNames; // 0x108
		private string[] _flatNames; // 0x110
		private List<PhaserSprite> BeamSprites; // 0x118
		private List<PhaserSprite> SideSprites; // 0x120
		private List<PhaserSprite> StarSprites; // 0x128
		private List<PhaserSprite> FlatSprites; // 0x130
		private List<List<PhaserSprite>> ListOfListsLol; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer attackTimer; // 0x140
		private VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0x148
		private bool _isDespawning; // 0x150
		private EnemyController _targetEnemy; // 0x158
		private List<SfxType> sfxs; // 0x160
	
		// Constructors
		public TP_VampireKiller_Explosion_Projectile() {} // 0x0000000186D47800-0x0000000186D47E80
	
		// Methods
		protected override void Awake() {} // 0x0000000186D43A00-0x0000000186D442B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D442B0-0x0000000186D447A0
		public void Explode() {} // 0x0000000186D447A0-0x0000000186D44BC0
		private void DisplayRandomFlare() {} // 0x0000000186D44BC0-0x0000000186D45DA0
		public void SetTargetEnemy(EnemyController enemy) {} // 0x00000001862CA0A0-0x00000001862CA100
		private void LateUpdate() {} // 0x0000000186D45DA0-0x0000000186D460C0
		public void StartDespawn() {} // 0x0000000186D460C0-0x0000000186D46390
		private void GenerateAnimatedSprites() {} // 0x0000000186D46390-0x0000000186D46F70
		private void GenerateParticleSystem() {} // 0x0000000186D46F70-0x0000000186D477A0
		public override void Despawn() {} // 0x0000000186D477A0-0x0000000186D47800
	}
}
