/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.App.Data;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCustomMerchant : NetworkPickup // TypeDefIndex: 16044
	{
		// Fields
		private ParticleEmitterManager _particleEmitterManager; // 0x170
		private ParticleSystem _pfxEmitter; // 0x178
		protected CustomMerchantData _customMerchantData; // 0x180
		private float _shopCooldownTimer; // 0x188
		private bool _facePlayer; // 0x18C
		private float _shopCooldown; // 0x190
		public readonly List<CustomActionInventoryItem> CustomActionInventoryItems; // 0x198
	
		// Properties
		public CustomMerchantData CustomMerchantData { get => default; } // 0x00000001826DB9D0-0x00000001826DB9E0 
		public bool SkipValidWeaponCheck { get; private set; } // 0x0000000184F61A70-0x0000000184F61A80 0x00000001857F9BC0-0x00000001857F9BD0
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupCustomMerchant() {} // 0x0000000186EC6B10-0x0000000186EC6BF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186EC3580-0x0000000186EC35C0
		private void Update() {} // 0x0000000186EC35C0-0x0000000186EC3610
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EC3610-0x0000000186EC3710
		public void SetInventoryData(CustomMerchantData customMerchantData) {} // 0x0000000186EC3710-0x0000000186EC3B60
		[Command]
		public void SendMerchantData(byte[] serializedMerchantData) {} // 0x0000000186EC3B60-0x0000000186EC3B90
		public void SetFacePlayerEnabled(bool isEnabled) {} // 0x0000000186EC3B90-0x0000000186EC3BA0
		public override void InternalUpdate() {} // 0x0000000186EC3BA0-0x0000000186EC3C60
		public override void UpdateDepth() {} // 0x0000000186EC3C60-0x0000000186EC3D80
		public void UpdateShopCooldown(float newCooldown) {} // 0x0000000186EC3D80-0x0000000186EC3DA0
		public override void GetTaken() {} // 0x0000000186EC3DA0-0x0000000186EC3FD0
		public override void GetOnlineTaken() {} // 0x0000000186EC3FD0-0x0000000186EC3FF0
		public virtual bool IsMerchantSoldOut() => default; // 0x0000000186EC3FF0-0x0000000186EC40C0
		public void ForceGetTaken() {} // 0x0000000186EBCDA0-0x0000000186EBCDB0
		protected virtual MerchantInventoryType GetInventoryType() => default; // 0x0000000180B21B50-0x0000000180B21B60
		private void SetCharacterFrame() {} // 0x0000000186EC40C0-0x0000000186EC45B0
		private void GenerateParticleSystem() {} // 0x0000000186EC45B0-0x0000000186EC55C0
		private void AddEffects() {} // 0x0000000186EC55C0-0x0000000186EC6350
		private void SpawnCursor() {} // 0x0000000186EC6350-0x0000000186EC67D0
		private void RemoveCursor() {} // 0x0000000186EC67D0-0x0000000186EC68A0
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186EC68A0-0x0000000186EC6980
		private Sprite GetCustomMerchantCursorSprite() => default; // 0x0000000186EC6980-0x0000000186EC6A70
		private void LoadCharacterTextureAsync(string textureName, Action<bool> onTextureLoaded) {} // 0x0000000186EC6A70-0x0000000186EC6B10
	}
}
