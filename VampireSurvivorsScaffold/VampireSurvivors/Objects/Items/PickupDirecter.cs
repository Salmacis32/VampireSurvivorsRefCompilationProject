/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupDirecter : NetworkPickup // TypeDefIndex: 16046
	{
		// Fields
		[HideInInspector]
		public float _Radius1; // 0x170
		[HideInInspector]
		public float _Radius2; // 0x174
		[HideInInspector]
		public float _Radius3; // 0x178
		[HideInInspector]
		public float _Radius4; // 0x17C
		[HideInInspector]
		public float _Radius5; // 0x180
		[HideInInspector]
		public float _Radius6; // 0x184
		[HideInInspector]
		public float _Radius7; // 0x188
		private float _myAngle1; // 0x18C
		private float _myAngle2; // 0x190
		private float _myAngle3; // 0x194
		private float _myAngle4; // 0x198
		private float _myAngle5; // 0x19C
		private float _myAngle6; // 0x1A0
		private float _myAngle7; // 0x1A4
		private PhaserSprite _eye1; // 0x1A8
		private PhaserSprite _eye2; // 0x1B0
		private PhaserSprite _eye3; // 0x1B8
		private PhaserSprite _eye4; // 0x1C0
		private PhaserSprite _eye5; // 0x1C8
		private PhaserSprite _eye6; // 0x1D0
		private PhaserSprite _eye7; // 0x1D8
		private TileSprite _stars1; // 0x1E0
		private TileSprite _stars2; // 0x1E8
		private bool _isBehind; // 0x1F0
		private PhaserSprite _LeftHand; // 0x1F8
		private PhaserSprite _RightHand; // 0x200
		private float _angleUnit; // 0x208
		private SpriteMask _spriteMask; // 0x210
		private List<MultiTargetTween> _allTweens; // 0x218
		private bool _locallyDisableGet; // 0x220
	
		// Properties
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupDirecter() {} // 0x0000000186ECAFE0-0x0000000186ECB000
	
		// Methods
		protected override void Awake() {} // 0x0000000186EC6CA0-0x0000000186EC8D80
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EC8D80-0x0000000186EC99C0
		public override void InternalUpdate() {} // 0x0000000186EC99C0-0x0000000186ECA380
		public override void GetTaken() {} // 0x0000000186ECA380-0x0000000186ECA630
		public override void Despawn() {} // 0x0000000186ECA630-0x0000000186ECAF60
		private void OnForceClosedUi() {} // 0x0000000186ECAF60-0x0000000186ECAFE0
	}
}
