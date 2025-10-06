/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundWestwoods : BackgroundManager // TypeDefIndex: 15318
	{
		// Fields
		private WestwoodsBounds _westwoodsBounds; // 0x80
		private WestwoodsBounds.WestwoodsZone _currentUnlockedZone; // 0x88
		private WestwoodsTrisectionManager _westwoodsTrisection; // 0x90
		private WestwoodsWaterHue _westwoodsWaterHue; // 0x98
		private PickupCustomMerchant _giacoreMerchant; // 0xA0
		private bool _giacoreRunning; // 0xA8
		private Vector3 _giacoreStartPosition; // 0xAC
		private Vector3 _giacoreTargetPosition; // 0xB8
		private float _giacoreRunTimer; // 0xC4
		private const float GiacoreRunDuration = 5f; // Metadata: 0x01977530
		private const string Zone1BarrierLayer = "Shadows"; // Metadata: 0x01977534
		private const string Zone2BarrierLayer = "ShadowDecals"; // Metadata: 0x0197753C
		private float _barrier1Alpha; // 0xC8
		private float _barrier2Alpha; // 0xCC
		private bool _barrierFadeActive; // 0xD0
		private float _barrierFadeTimer; // 0xD4
		private Tilemap _barrier1Tilemap; // 0xD8
		private Tilemap _barrier2Tilemap; // 0xE0
		private const float BarrierFadeDuration = 0.5f; // Metadata: 0x01977549
		private const float Zone2MerchantXOffset = 14.3488f; // Metadata: 0x0197754D
		private const float Zone3MerchantXOffset = 10.1f; // Metadata: 0x01977551
		private const string BACKGROUND_WESTWOODS = "background_westwoods_grayscale"; // Metadata: 0x01977555
		private PhaserSprite _waterAnim; // 0xE8
		private TileSprite _water; // 0xF0
		private CustomActionInventoryItem _secretinoShopItem; // 0xF8
	
		// Constructors
		public BackgroundWestwoods() {} // 0x0000000186B6E720-0x0000000186B6E740
	
		// Methods
		public override bool HasCustomMadGrooveRestriction() => default; // 0x0000000181958370-0x0000000181958380
		public override bool IsPositionPulledByMadGroove(float2 position) => default; // 0x0000000186B6A5D0-0x0000000186B6A660
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B6A660-0x0000000186B6A800
		public override void Create() {} // 0x0000000186B6A800-0x0000000186B6AD90
		protected override void OnDestroy() {} // 0x0000000186B6AD90-0x0000000186B6AED0
		private void OnWestwoodsSpin(OnlineSignals.WestwoodsSpin spin) {} // 0x0000000186B6AED0-0x0000000186B6AFD0
		protected override void OnUpdate() {} // 0x0000000186B6AFD0-0x0000000186B6B940
		public void TriggerMinigameTrisection() {} // 0x0000000186B6B940-0x0000000186B6BC90
		private void OnMinigameSuccess() {} // 0x0000000186B6BC90-0x0000000186B6C090
		private bool InitBounds(GameObject support) => default; // 0x0000000186B6C090-0x0000000186B6C2C0
		private void InitWestwoodsTrisection() {} // 0x0000000186B6C2C0-0x0000000186B6C540
		private bool InitWater(GameObject support) => default; // 0x0000000186B6C540-0x0000000186B6CD50
		private void SpawnGiocareMerchant(WestwoodsBounds.WestwoodsZone currentUnlockedZone) {} // 0x0000000186B6CD50-0x0000000186B6D440
		private void ConfigureGiocoreMerchant() {} // 0x0000000186B6D440-0x0000000186B6E2E0
		private void RemoveSecretinoItem() {} // 0x0000000186B6E2E0-0x0000000186B6E3B0
		private void UnlockNextZone(bool saveProgress) {} // 0x0000000186B6E3B0-0x0000000186B6E4C0
		private Tilemap GetTilemap(string layerName) => default; // 0x0000000186B6E4C0-0x0000000186B6E530
		private void SetTilemapAlpha(Tilemap tilemap, float alphaValue) {} // 0x0000000186B6E530-0x0000000186B6E6A0
		public void DebugUnlockNextZone() {} // 0x0000000186B6E6A0-0x0000000186B6E720
	}
}
