/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class Background1 : BackgroundManager // TypeDefIndex: 15204
	{
		// Fields
		private bool _hadEnoughChicken; // 0x80
		private bool _chickenTrailSpawned; // 0x81
		private int _chickenTimerLoopCount; // 0x84
		private SpriteRenderer _chickenSprite; // 0x88
		private ParticleSystem _pfxEmitterPickups; // 0x90
		private VampireSurvivors.Framework.TimerSystem.Timer _chickenTimer; // 0x98
		private EnemyStalkerNoob _boon; // 0xA0
		private bool _awarded; // 0xA8
	
		// Constructors
		public Background1() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		public override void Awake() {} // 0x0000000186A92150-0x0000000186A921F0
		protected override void OnDestroy() {} // 0x0000000186A921F0-0x0000000186A92450
		protected override void OnUpdate() {} // 0x0000000186A92450-0x0000000186A92500
		public override void Create() {} // 0x0000000186A92500-0x0000000186A926D0
		private bool Siffregatoipummarola() => default; // 0x0000000186A926D0-0x0000000186A92750
		private void StartChickenTrail() {} // 0x0000000186A92750-0x0000000186A92A50
		private void OnDefeated() {} // 0x0000000186A92A50-0x0000000186A92BC0
		public void AwardNeoUnlock() {} // 0x0000000186A92BC0-0x0000000186A93070
		private void SpawnFreeChicken() {} // 0x0000000186A93070-0x0000000186A93A40
		private void GenerateParticleSystems() {} // 0x0000000186A93A40-0x0000000186A94200
		private void GenerateChickenSprite() {} // 0x0000000186A94200-0x0000000186A94680
	}
}
