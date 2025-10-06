/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Doppleganger_Runetracer : EnemyProjectile // TypeDefIndex: 15856
	{
		// Fields
		public TrailRenderer _Trail; // 0x78
		public SpriteRenderer _SpriteRenderer; // 0x80
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x88
		private float _saveVelX; // 0x90
		private float _saveVelY; // 0x94
		private TrailRendererPauseController _pauseController; // 0x98
	
		// Constructors
		public Doppleganger_Runetracer() {} // 0x0000000186DF2C50-0x0000000186DF2CA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DF2CA0-0x0000000186DF2D50
		public override void InitProjectile(int index, float2 direction, EnemyBulletPool pool) {} // 0x0000000186DF2D50-0x0000000186DF32C0
		private void FadeOutAndDispose() {} // 0x0000000186DF32C0-0x0000000186DF3600
		public override void Despawn() {} // 0x0000000186DF3600-0x0000000186DF3720
		protected override void OnUpdate() {} // 0x0000000186DF3720-0x0000000186DF3860
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186DF3860-0x0000000186DF38F0
		private void SetupTrails() {} // 0x0000000186DF38F0-0x0000000186DF3DB0
		public override void OnHitPlayer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186DF3DB0-0x0000000186DF3DE0
	}
}
