/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using SuperTiled2Unity;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Props;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundFoscari2 : BackgroundManager // TypeDefIndex: 15284
	{
		// Fields
		private TileSprite _water; // 0x80
		private float _beats; // 0x88
		private float _tilingOffset; // 0x8C
		private PhaserSprite _sDarkness; // 0x90
		private PhaserSprite _sFader; // 0x98
		private PhaserSprite _pizzaAsprite; // 0xA0
		private Circle _pizzaA; // 0xA8
		private bool _canPizza; // 0xB0
		private BgmType _saveBGM; // 0xB4
		private BgmModType _saveBGMMod; // 0xB8
		private VampireSurvivors.Framework.TimerSystem.Timer beatTimer; // 0xC0
		private bool _isSealed; // 0xC8
		private bool _isPathBlocked; // 0xC9
		private float _waterOffset; // 0xCC
		private EnemyJeneviv _jeneviv; // 0xD0
		private PhaserSprite _sBlackWall; // 0xD8
		private ParticleEmitterManager _shadowParticlesManager; // 0xE0
		private ParticleSystem _shadowEmitter; // 0xE8
		private PropFoscariSeal2 _seal; // 0xF0
		private ParticleEmitterManager _particlesManager; // 0xF8
		private ParticleSystem _glitchEmitter; // 0x100
		private ParticleSystem _glitchEmitter2; // 0x108
		private PropFoscariSeal3 _sealBlue; // 0x110
		private bool _checkForLuminaire; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _luminairePathEvent; // 0x120
		private float Delay01_Wave; // 0x128
		private float Delay02_Wave; // 0x12C
		private float Delay03_Wave; // 0x130
		private float Delay04_Wave; // 0x134
		private float Delay05_Break; // 0x138
		private float Delay06_Move; // 0x13C
		private float Delay07_Color; // 0x140
		private float Delay08_Charge; // 0x144
		private float Delay09_WorldEater; // 0x148
		private float Delay10_Start; // 0x14C
		private float Delay11_Light; // 0x150
		private List<Weapon> _playerWeapons; // 0x158
	
		// Constructors
		public BackgroundFoscari2() {} // 0x0000000186B38FC0-0x0000000186B39100
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000186B2E620-0x0000000186B2E900
		public override void Awake() {} // 0x0000000186B2E900-0x0000000186B304A0
		public override void Create() {} // 0x0000000186B304A0-0x0000000186B32010
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186B32010-0x0000000186B32210
		private void OnRemoteDestructibleSpawned(Destructible destructible) {} // 0x0000000186B32210-0x0000000186B32550
		public override void OnInitCompleted() {} // 0x0000000186B32550-0x0000000186B32820
		public void OnJenevivActivation() {} // 0x0000000186B32820-0x0000000186B32870
		public override void CheckMinute(int minute) {} // 0x0000000186B32870-0x0000000186B32AC0
		public override void Cleanup() {} // 0x0000000186B32AC0-0x0000000186B32CB0
		protected override void OnUpdate() {} // 0x0000000186B32CB0-0x0000000186B33CD0
		public void StopBeat() {} // 0x0000000186B33CD0-0x0000000186B33DE0
		public void ForceSpoopyMusic() {} // 0x0000000186B33DE0-0x0000000186B33EA0
		public void onBeat() {} // 0x0000000186B33EA0-0x0000000186B34100
		public void ResumeEnemiesMovement() {} // 0x0000000186B34100-0x0000000186B342D0
		public void MakePizza() {} // 0x0000000186B342D0-0x0000000186B34990
		public void CheckPizzas(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B34990-0x0000000186B34A40
		public void AnimPizza() {} // 0x0000000186B34A40-0x0000000186B34D60
		public void CreateSeal2() {} // 0x0000000186B34D60-0x0000000186B353D0
		public void CreateSeal3() {} // 0x0000000186B353D0-0x0000000186B35A40
		public void CreateBadge() {} // 0x0000000186B35A40-0x0000000186B35ED0
		private void CreateShadowServant() {} // 0x0000000186B35ED0-0x0000000186B36360
		private void CreateWeapons() {} // 0x0000000186B36360-0x0000000186B366B0
		public void OnSeal2DestructionComplete() {} // 0x0000000186B366B0-0x0000000186B36A70
		public void SetBoundsBeforeSeal2() {} // 0x0000000186B36A70-0x0000000186B36C20
		public void OpenBounds() {} // 0x0000000186B36C20-0x0000000186B36CA0
		private void SpawnJeneviv() {} // 0x0000000186B36CA0-0x0000000186B371A0
		private void SealJeneviv() {} // 0x0000000186B371A0-0x0000000186B37290
		public void FreeJeneviv() {} // 0x0000000186B37290-0x0000000186B37B80
		private void SummonSnakes() {} // 0x0000000186B37B80-0x0000000186B37EF0
		public void DevourEggs() {} // 0x0000000186B37EF0-0x0000000186B38910
		private void StartSpawningPrismaticMissile() {} // 0x0000000186B38910-0x0000000186B38A20
		private void OnWorldEater() {} // 0x0000000186B38A20-0x0000000186B38ED0
		private void GimmeAbeat(float interval, Action callback) {} // 0x0000000186B38ED0-0x0000000186B38FA0
		private void ClearBeat() {} // 0x0000000186B38FA0-0x0000000186B38FC0
	}
}
