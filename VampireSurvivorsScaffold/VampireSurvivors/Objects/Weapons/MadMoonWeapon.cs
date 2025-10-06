/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class MadMoonWeapon : Weapon // TypeDefIndex: 16732
	{
		// Fields
		private Bounds camBounds; // 0x158
		private float2 playerPos; // 0x170
		private Camera _camera; // 0x178
		private BulletPool _reelZonePool; // 0x180
		[SerializeField]
		protected Projectile _reelZonePrefab; // 0x188
		public int numOfReels; // 0x190
		public int symbolsPerReel; // 0x194
		private float spinTime; // 0x198
		private float delayBetweenReels; // 0x19C
		public Vector2 slotMachineSize; // 0x1A0
		public Vector2 slotMachinePos; // 0x1A8
		private MadMoonReelState[] reelStates; // 0x1B0
		private MadMoonProjectile[] landedProjectiles; // 0x1B8
		public MadMoonSymbol[] finalSymbols; // 0x1C0
		private float[] symbolWeights; // 0x1C8
		private float timeBetweenZones; // 0x1D0
		[SerializeField]
		private GameObject blackBar; // 0x1D8
		private Tween _blackbarTween; // 0x1E0
		[Range(0f, 1f)]
		[SerializeField]
		private float winChance; // 0x1E8
		private bool hasWinningSymbols; // 0x1EC
		private bool _emitterBuilt; // 0x1ED
		private ParticleSystem _EmitterCoins; // 0x1F0
		private ParticleSystem _EmitterSkulls; // 0x1F8
		private ParticleSystem _EmitterGems; // 0x200
		private ParticleSystem _EmitterClovers; // 0x208
	
		// Constructors
		public MadMoonWeapon() {} // 0x000000018709DDC0-0x000000018709DE40
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187098A20-0x00000001870993D0
		public override void InternalUpdate() {} // 0x0000000186F98360-0x0000000186F98370
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E05 */) {} // 0x00000001870993D0-0x0000000187099610
		public void StartSpinning(int reel) {} // 0x0000000187099610-0x0000000187099B90
		[IteratorStateMachine(typeof(_Spinning_d__29))]
		private IEnumerator Spinning(int reel, float duration) => default; // 0x0000000187099B90-0x0000000187099C50
		public void Stopping(int reel) {} // 0x0000000187099C50-0x000000018709A030
		public void SpawnZone(int reel) {} // 0x000000018709A030-0x000000018709A8D0
		private void Restart() {} // 0x000000018709A8D0-0x000000018709AB90
		private void FadeBlackBar(bool fadeOn) {} // 0x000000018709AB90-0x000000018709AD10
		private void updateWeights() {} // 0x000000018709AD10-0x000000018709AF10
		private static float map(float value, float fromLow, float fromHigh, float toLow, float toHigh) => default; // 0x0000000186E42820-0x0000000186E42840
		private float2 getSlotMachinePos() => default; // 0x000000018709AF10-0x000000018709AF50
		private float2 getTopLeftSymbolPos() => default; // 0x000000018709AF50-0x000000018709AFC0
		public void setFinalSymbols(bool won) {} // 0x000000018709AFC0-0x000000018709B450
		public MadMoonSymbol getRandomSymbol(bool weighted = false /* Metadata: 0x01977E06 */, bool includeWilds = true /* Metadata: 0x01977E07 */) => default; // 0x000000018709B450-0x000000018709B6C0
		[Command]
		public void SyncFinalSymbols(string serializedFinalSymbols) {} // 0x000000018709B6C0-0x000000018709B730
		public string SerializeFinalSymbols(MadMoonSymbol[] symbols) => default; // 0x000000018709B730-0x000000018709BAF0
		public MadMoonSymbol[] DeserializeFinalSymbols(string str) => default; // 0x000000018709BAF0-0x000000018709BDC0
		public void OnSpinRemotely(OnlineSignals.MadMoonSpin sig) {} // 0x000000018709B6C0-0x000000018709B730
		private void BuildEmitter() {} // 0x000000018709BDC0-0x000000018709DA30
		public void PlayParticleVFXAt(Vector3 finalPos, MadMoonSymbol mmSymbol) {} // 0x000000018709DA30-0x000000018709DDC0
	}
}
