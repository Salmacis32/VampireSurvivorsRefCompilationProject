/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FourSeasons2Projectile : Projectile // TypeDefIndex: 15877
	{
		// Fields
		private FourSeasons2Weapon _trueWeapon; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private ParticleEmitterManager _particles; // 0xE0
		private ParticleSystem _fwEmitter; // 0xE8
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xF0
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xF8
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0x100
		private MultiTargetTween _tween5; // 0x108
		private MultiTargetTween _tween3; // 0x110
		private MultiTargetTween _tween4; // 0x118
		private MultiTargetTween _tween2; // 0x120
		private MultiTargetTween _tween1; // 0x128
		private int _season; // 0x130
		private List<ParticleEmitterManager> _seasonParticles; // 0x138
		private List<ParticleSystem> _seasonEmitters; // 0x140
		private List<GravityWell> _seasonWells; // 0x148
		private PhaserSprite _kanji; // 0x150
		private List<Sprite> _kanjiFrames; // 0x158
		private PhaserSprite _lightning; // 0x160
		private MultiTargetTween _tweenLightning; // 0x168
		private MultiTargetTween _tweenLightningReturn; // 0x170
		private bool _initalized; // 0x178
	
		// Constructors
		public FourSeasons2Projectile() {} // 0x0000000186E1A900-0x0000000186E1AB30
	
		// Methods
		public uint[] getEmitCustomTint(int season) => default; // 0x0000000186E161F0-0x0000000186E16330
		protected override void Awake() {} // 0x0000000186E16330-0x0000000186E164B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E164B0-0x0000000186E16AD0
		private void Initialize() {} // 0x0000000186E16AD0-0x0000000186E17F60
		private void MakeEmitter_Frames(List<string> frames, int season) {} // 0x0000000186E17F60-0x0000000186E18950
		private void OnRecycle() {} // 0x0000000186E18950-0x0000000186E19310
		private void TryDetonate() {} // 0x0000000186E19310-0x0000000186E1A400
		public override void InternalUpdate() {} // 0x0000000186E1A400-0x0000000186E1A840
		public override void Despawn() {} // 0x0000000186E1A840-0x0000000186E1A900
	}
}
