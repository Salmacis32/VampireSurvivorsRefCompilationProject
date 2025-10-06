/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerMegaloGenevieve : CharacterController // TypeDefIndex: 16949
	{
		// Fields
		private List<int2> _tilesToEat; // 0x3F0
		private List<int2> _currentTilesBeingEaten; // 0x3F8
		private float _eatTimer; // 0x400
		private float _eatDelay; // 0x404
		private ParticleEmitterManager _particlesManager; // 0x408
		private ParticleSystem _pfxEmitter; // 0x410
		private ParticleSystem _pfxEmitter2; // 0x418
		private GravityWell _well; // 0x420
		public WorldEaterVFX _wolrdEater; // 0x428
		public Action _worldEaterCallback; // 0x430
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerMegaloGenevieve() {} // 0x0000000187116310-0x0000000187116330
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187112AD0-0x0000000187112CD0
		public override void OnQuit() {} // 0x0000000187112CD0-0x0000000187112CE0
		public void LastBreath() {} // 0x0000000187112CE0-0x0000000187112D40
		public void TryEatingWorld() {} // 0x0000000187112D40-0x0000000187112DB0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F3A */) {} // 0x0000000187112DB0-0x0000000187112F10
		public override void OnLevelUpSkipped() {} // 0x0000000187112F10-0x0000000187112F70
		public override void OnLevelUpCompleted() {} // 0x0000000187112F70-0x00000001871135F0
		protected override void OnUpdate() {} // 0x00000001871135F0-0x0000000187113C00
		private void CheckTiles() {} // 0x0000000187113C00-0x0000000187113F60
		private void StartEatingTile(List<int2> posList) {} // 0x0000000187113F60-0x00000001871140F0
		private void BuildPositionListToBeSpacedApart(List<int2> posList) {} // 0x00000001871140F0-0x00000001871142A0
		private void EatTile(List<int2> posList) {} // 0x00000001871142A0-0x0000000187114570
		private void BlackExplosionAt(List<int2> posList) {} // 0x0000000187114570-0x00000001871149C0
		private void CreateBlackEmitter() {} // 0x00000001871149C0-0x0000000187115DB0
		protected override void OnStop() {} // 0x0000000187115DB0-0x0000000187115DF0
		protected void ScreenShake() {} // 0x0000000187115DF0-0x0000000187116310
	}
}
