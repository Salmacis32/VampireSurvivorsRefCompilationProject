/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MadMoonZoneProjectile : Projectile // TypeDefIndex: 15924
	{
		// Fields
		private Camera _camera; // 0xD0
		private float alpha; // 0xD8
		public MadMoonProjectile symbol; // 0xE0
		public float2 playerPos; // 0xE8
		private MadMoonSymbol effect; // 0xF0
		private int reel; // 0xF4
		public float buffMultiplier; // 0xF8
		private static List<EnemyController>[] effectedEnemies; // 0x00
		private static List<Gem>[] effectedGems; // 0x08
		private static List<TreasureChest>[] effectedTreasures; // 0x10
		private static List<Coin>[] effectedCoins; // 0x18
		private static List<Destructible>[] effectedLights; // 0x20
		private int level; // 0xFC
		private MultiTargetTween _scaleTween; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer anforaDisappearTimer; // 0x108
	
		// Constructors
		public MadMoonZoneProjectile() {} // 0x0000000186E47270-0x0000000186E472D0
		static MadMoonZoneProjectile() {} // 0x0000000186E472D0-0x0000000186E47DD0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C93600-0x0000000186C93610
		public void AfterInit(MadMoonProjectile symbol, float time, int level, int reel, MadMoonSymbol effect, float value = 1f /* Metadata: 0x01977952 */, bool specialBonus = false /* Metadata: 0x01977956 */) {} // 0x0000000186E43D00-0x0000000186E44070
		private Color getColor(MadMoonSymbol madMoonSymbol) => default; // 0x0000000186E44070-0x0000000186E44100
		public void CheckObjects(float mult = 1f /* Metadata: 0x01977957 */, bool specialBonus = false /* Metadata: 0x0197795B */) {} // 0x0000000186E44100-0x0000000186E44BE0
		private void SpawnSkelegems() {} // 0x0000000186E44BE0-0x0000000186E45370
		private void SpawnAnforaCluster() {} // 0x0000000186E45370-0x0000000186E45950
		private void SpawnReapers() {} // 0x0000000186E45950-0x0000000186E45C50
		public void AddGemEffect(Gem gem) {} // 0x0000000186E45C50-0x0000000186E45CD0
		public void AddTreasureEffect(TreasureChest treasure, float valueLuck = 1f /* Metadata: 0x0197795C */) {} // 0x0000000186E45CD0-0x0000000186E45D10
		public void AddCoinEffect(Coin coin) {} // 0x0000000186E45D10-0x0000000186E45D50
		public void AddLightEffect(Destructible destructible, float valueLuck = 1f /* Metadata: 0x01977960 */) {} // 0x0000000186E45D50-0x0000000186E45DA0
		public void AddEnemyEffect(EnemyController enemy, float valueCurse = 1f /* Metadata: 0x01977964 */) {} // 0x0000000186E45DA0-0x0000000186E45ED0
		public void OnEnemyKilled(GameplaySignals.EnemyKilledImmediateSignal signal) {} // 0x0000000186E45ED0-0x0000000186E46050
		public void OnDestructibleDestroyed(GameplaySignals.DestructibleDestroyed signal) {} // 0x0000000186E46050-0x0000000186E461D0
		private void DoVFX(float2 position) {} // 0x0000000186E461D0-0x0000000186E462C0
		public void OnItemPickedUp(Pickup pickup) {} // 0x0000000186E462C0-0x0000000186E468C0
		[IteratorStateMachine(typeof(_DamageEnemyLoop_d__31))]
		private IEnumerator DamageEnemyLoop(EnemyController enemy, float amount) => default; // 0x0000000186E468C0-0x0000000186E469E0
		private bool ObjectOverlaps(float2 objectPos) => default; // 0x0000000186E469E0-0x0000000186E46AD0
		public override void Despawn() {} // 0x0000000186E46AD0-0x0000000186E46D90
		public void RemoveGemEffect(Gem gem, int level) {} // 0x0000000186E46D90-0x0000000186E46E80
		public void RemoveTreasureEffect(TreasureChest treasure, int level) {} // 0x0000000186E46E80-0x0000000186E46FB0
		public void RemoveCoinEffect(Coin coin, int level) {} // 0x0000000186E46FB0-0x0000000186E470A0
		public void RemoveLightEffect(Destructible p, int level) {} // 0x0000000186E470A0-0x0000000186E471A0
		public void RemoveEnemyEffect(EnemyController enemy) {} // 0x0000000186E471A0-0x0000000186E47270
	}
}
