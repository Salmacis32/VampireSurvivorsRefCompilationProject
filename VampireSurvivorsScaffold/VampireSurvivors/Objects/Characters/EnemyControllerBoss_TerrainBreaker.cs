/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemyControllerBoss_TerrainBreaker : EnemyControllerBoss // TypeDefIndex: 17168
	{
		// Fields
		private static readonly List<string> TILE_LAYERS; // 0x00
		private List<int2> _tilesToEat; // 0x3F8
		private List<int2> _currentTilesBeingEaten; // 0x400
		private ParticleEmitterManager _particlesManager; // 0x408
		private ParticleSystem _pfxEmitter; // 0x410
		private ParticleSystem _pfxEmitter2; // 0x418
		private GravityWell _well; // 0x420
	
		// Constructors
		public EnemyControllerBoss_TerrainBreaker() {} // 0x000000018719D550-0x000000018719D6A0
		static EnemyControllerBoss_TerrainBreaker() {} // 0x000000018719D6A0-0x000000018719DB30
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote = false /* Metadata: 0x0197816C */) {} // 0x000000018719B1A0-0x000000018719B1C0
		protected override void OnUpdate() {} // 0x000000018719B1C0-0x000000018719B230
		protected virtual void UpdateTileDestructionList() {} // 0x000000018719B230-0x000000018719B4A0
		protected void CheckTiles() {} // 0x000000018719B4A0-0x000000018719B800
		protected void StartEatingTile(List<int2> posList) {} // 0x000000018719B800-0x000000018719B990
		private void EatTile(List<int2> posList) {} // 0x000000018719B990-0x000000018719BD70
		private void BlackExplosionAt(List<int2> posList) {} // 0x000000018719BD70-0x000000018719C150
		private void CreateBlackEmitter() {} // 0x000000018719C150-0x000000018719D550
	}
}
