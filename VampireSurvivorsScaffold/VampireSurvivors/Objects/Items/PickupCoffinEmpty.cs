/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCoffinEmpty : PickupGuarded // TypeDefIndex: 16041
	{
		// Fields
		private SpriteRenderer _charSprite; // 0x1D0
		private SpriteRenderer _lid; // 0x1D8
		private bool _isOpened; // 0x1E0
		private Tween _charScaleTween; // 0x1E8
		private Tween _charMoveTween; // 0x1F0
		private DG.Tweening.Sequence _lidTween; // 0x1F8
	
		// Properties
		[Sync]
		public int SyncedCharCff { get => default; set {} } // 0x0000000186EBF3F0-0x0000000186EBF400 0x0000000186EBF400-0x0000000186EBF410
		private VampireSurvivors.Data.CharacterType CharCff { get; set; } // 0x0000000186EBF3F0-0x0000000186EBF400 0x0000000186EBF400-0x0000000186EBF410
		public Action OnOpen { get; set; } // 0x00000001854006C0-0x00000001854006D0 0x00000001812D6360-0x00000001812D63C0
	
		// Constructors
		public PickupCoffinEmpty() {} // 0x0000000186EB9040-0x0000000186EB9050
	
		// Methods
		protected override void Awake() {} // 0x0000000186EBF410-0x0000000186EBF7D0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EBF7D0-0x0000000186EBF940
		public override void InternalUpdate() {} // 0x0000000186EBF940-0x0000000186EBF9A0
		public void SetChar(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186EBF9A0-0x0000000186EBFD70
		public override void UpdateDepth() {} // 0x0000000186EBFD70-0x0000000186EBFE20
		protected void OnCharTypeUpdated(int oldChar, int newChar) {} // 0x0000000186EBFE20-0x0000000186EBFE30
		protected override void OnRecycle() {} // 0x0000000186EBFE30-0x0000000186EC0020
		public override void GetTaken() {} // 0x0000000186EC0020-0x0000000186EC0E30
		private void PlaySfx() {} // 0x0000000186EC0E30-0x0000000186EC0F50
		private void TriggerCharacterPanel() {} // 0x0000000186EC0F50-0x0000000186EC0FB0
		private void SpawnCursor() {} // 0x0000000186EC0FB0-0x0000000186EC1390
		private void RemoveCursor() {} // 0x0000000186EC1390-0x0000000186EC1460
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186EC1460-0x0000000186EC1540
	}
}
