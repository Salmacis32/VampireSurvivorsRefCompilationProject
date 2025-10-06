/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Props;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundFoscari2_Plain : BackgroundManager // TypeDefIndex: 15286
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
		private float _waterOffset; // 0xC8
		private EnemyJeneviv _jeneviv; // 0xD0
		private ParticleEmitterManager _shadowParticlesManager; // 0xD8
		private ParticleSystem _shadowEmitter; // 0xE0
		private PropFoscariSeal2 _seal; // 0xE8
		private ParticleEmitterManager _particlesManager; // 0xF0
		private ParticleSystem _glitchEmitter; // 0xF8
		private ParticleSystem _glitchEmitter2; // 0x100
	
		// Constructors
		public BackgroundFoscari2_Plain() {} // 0x0000000186B3ED40-0x0000000186B3ED50
	
		// Methods
		public override void Awake() {} // 0x0000000186B3AD50-0x0000000186B3C8E0
		public override void Create() {} // 0x0000000186B3C8E0-0x0000000186B3D310
		public override void OnInitCompleted() {} // 0x0000000186B3D310-0x0000000186B3D450
		public override void CheckMinute(int minute) {} // 0x0000000186B3D450-0x0000000186B3D6A0
		public override void Cleanup() {} // 0x0000000186B3D6A0-0x0000000186B3D890
		protected override void OnUpdate() {} // 0x0000000186B3D890-0x0000000186B3DBA0
		public void StopBeat() {} // 0x0000000186B3DBA0-0x0000000186B3DCB0
		public void ForceSpoopyMusic() {} // 0x0000000186B3DCB0-0x0000000186B3DD70
		public void onBeat() {} // 0x0000000186B3DD70-0x0000000186B3DFD0
		public void ResumeEnemiesMovement() {} // 0x0000000186B3DFD0-0x0000000186B3E1A0
		public void MakePizza() {} // 0x0000000186B3E1A0-0x0000000186B3E860
		public void CheckPizzas(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B3E860-0x0000000186B3EA20
		public void AnimPizza() {} // 0x0000000186B3EA20-0x0000000186B3ED40
		private void GimmeAbeat(float interval, Action callback) {} // 0x0000000186B38ED0-0x0000000186B38FA0
		private void ClearBeat() {} // 0x0000000186B38FA0-0x0000000186B38FC0
	}
}
