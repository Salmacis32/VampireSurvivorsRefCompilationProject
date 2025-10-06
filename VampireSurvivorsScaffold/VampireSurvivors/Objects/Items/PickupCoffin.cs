/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCoffin : PickupGuarded // TypeDefIndex: 16039
	{
		// Fields
		private SpriteRenderer _charSprite; // 0x1D0
		private SpriteRenderer _lid; // 0x1D8
		private bool _isOpened; // 0x1E0
		private Tween _charScaleTween; // 0x1E8
		private Tween _charMoveTween; // 0x1F0
		private DG.Tweening.Sequence _lidTween; // 0x1F8
		private Vector2 _lidStartPosition; // 0x200
		public Action OnGotTaken; // 0x218
	
		// Properties
		[OnValueSynced("OnCharacterSetRemotely")]
		[Sync]
		public int SyncedCharCff { get => default; set {} } // 0x0000000186EBCDB0-0x0000000186EBCDC0 0x0000000186EBCDC0-0x0000000186EBCDD0
		[OnValueSynced("OnLidSpriteChanged")]
		[Sync]
		public string LidSpriteName { get; set; } // 0x00000001854006C0-0x00000001854006D0 0x00000001812D6360-0x00000001812D63C0
		private VampireSurvivors.Data.CharacterType CharCff { get; set; } // 0x0000000186EBCDB0-0x0000000186EBCDC0 0x0000000186EBCDC0-0x0000000186EBCDD0
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupCoffin() {} // 0x0000000186EB9040-0x0000000186EB9050
	
		// Methods
		protected override void Awake() {} // 0x0000000186EBCDD0-0x0000000186EBD250
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EBD250-0x0000000186EBD3C0
		public override void InternalUpdate() {} // 0x0000000186EBD3C0-0x0000000186EBD430
		public void SetChar(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186EBD430-0x0000000186EBD8B0
		public override void UpdateDepth() {} // 0x0000000186EBD8B0-0x0000000186EBD970
		public void SetWhiteCoffinSprites() {} // 0x0000000186EBD970-0x0000000186EBDAA0
		public override void GetOnlineTaken() {} // 0x0000000186EBDAA0-0x0000000186EBDAD0
		private void OnLidSpriteChanged(string old, string newSprite) {} // 0x0000000186EBDAD0-0x0000000186EBDB70
		protected override void OnRecycle() {} // 0x0000000186EBDB70-0x0000000186EBDE40
		public override void GetTaken() {} // 0x0000000186EBDE40-0x0000000186EBE760
		private void PlaySfx() {} // 0x0000000186EBE760-0x0000000186EBE880
		private void TriggerCharacterPanel(VampireSurvivors.Objects.Characters.CharacterController targetPlayer) {} // 0x0000000186EBE880-0x0000000186EBE9C0
		private void SpawnCursor() {} // 0x0000000186EBE9C0-0x0000000186EBEDA0
		private void RemoveCursor() {} // 0x0000000186EBEDA0-0x0000000186EBEE70
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186EBEE70-0x0000000186EBEF50
		protected void OnCharacterSetRemotely(int old, int newChar) {} // 0x0000000186EBEF50-0x0000000186EBEF60
	}
}
