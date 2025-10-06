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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCoffinX : PickupGuarded // TypeDefIndex: 16042
	{
		// Fields
		private SpriteRenderer _charSprite; // 0x1D0
		private SpriteRenderer _lid; // 0x1D8
		private bool _isOpened; // 0x1E0
		private Tween _charScaleTween; // 0x1E8
		private Tween _charMoveTween; // 0x1F0
		private DG.Tweening.Sequence _lidTween; // 0x1F8
	
		// Properties
		[OnValueSynced("OnCharacterSetRemotely")]
		[Sync]
		public int SyncedCharCff { get => default; set {} } // 0x0000000186EBF3F0-0x0000000186EBF400 0x0000000186EBF400-0x0000000186EBF410
		private VampireSurvivors.Data.CharacterType CharCff { get; set; } // 0x0000000186EBF3F0-0x0000000186EBF400 0x0000000186EBF400-0x0000000186EBF410
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupCoffinX() {} // 0x0000000186EB9040-0x0000000186EB9050
	
		// Methods
		protected override void Awake() {} // 0x0000000186EC1C10-0x0000000186EC1FD0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EC1FD0-0x0000000186EC2130
		public override void InternalUpdate() {} // 0x0000000186EBF940-0x0000000186EBF9A0
		public void SetChar(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186EC2130-0x0000000186EC2500
		public override void UpdateDepth() {} // 0x0000000186EC2500-0x0000000186EC25B0
		protected override void OnRecycle() {} // 0x0000000186EC25B0-0x0000000186EC27A0
		public override void GetOnlineTaken() {} // 0x0000000186EBDAA0-0x0000000186EBDAD0
		public override void GetTaken() {} // 0x0000000186EC27A0-0x0000000186EC3000
		protected void OnCharacterSetRemotely(int old, int newChar) {} // 0x0000000186EC3000-0x0000000186EC3010
	}
}
