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
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DeathFightDirecter : PhaserSprite // TypeDefIndex: 13941
	{
		// Fields
		private float _Radius1; // 0x40
		private float _Radius2; // 0x44
		private float _Radius3; // 0x48
		private float _Radius4; // 0x4C
		private float _Radius5; // 0x50
		private float _Radius6; // 0x54
		private float _Radius7; // 0x58
		private float _myAngle1; // 0x5C
		private float _myAngle2; // 0x60
		private float _myAngle3; // 0x64
		private float _myAngle4; // 0x68
		private float _myAngle5; // 0x6C
		private float _myAngle6; // 0x70
		private float _myAngle7; // 0x74
		private PhaserSprite _eye1; // 0x78
		private PhaserSprite _eye2; // 0x80
		private PhaserSprite _eye3; // 0x88
		private PhaserSprite _eye4; // 0x90
		private PhaserSprite _eye5; // 0x98
		private PhaserSprite _eye6; // 0xA0
		private PhaserSprite _eye7; // 0xA8
		private TileSprite _stars1; // 0xB0
		private TileSprite _stars2; // 0xB8
		private PhaserSprite _LeftHand; // 0xC0
		private PhaserSprite _RightHand; // 0xC8
		private float _angleUnit; // 0xD0
		private SpriteMask _spriteMask; // 0xD8
		private List<MultiTargetTween> _allTweens; // 0xE0
		public Transform _protectionTarget; // 0xE8
		public Transform _projectileToBlock; // 0xF0
		public Enemy_TP_Death _death; // 0xF8
	
		// Constructors
		public DeathFightDirecter() {} // 0x00000001865DBC30-0x00000001865DBDB0
	
		// Methods
		protected override void Awake() {} // 0x00000001865D6C40-0x00000001865D91B0
		protected override void OnUpdate() {} // 0x00000001865D91B0-0x00000001865DA150
		private void UpdateDirecterSubObjects() {} // 0x00000001865DA150-0x00000001865DA170
		private void UpdateDepths() {} // 0x00000001865DA170-0x00000001865DA460
		private void UpdateMaskPositions() {} // 0x00000001865DA460-0x00000001865DAB80
		protected override void OnDestroy() {} // 0x00000001865DAB80-0x00000001865DB490
		public void StartBlockCutscene() {} // 0x00000001865DB490-0x00000001865DB540
		private float BlockDistance() => default; // 0x00000001865DB540-0x00000001865DB550
		private float2 BlockPosition() => default; // 0x00000001865DB550-0x00000001865DB6F0
		[IteratorStateMachine(typeof(__BlockCutscene_d__40))]
		private IEnumerator _BlockCutscene() => default; // 0x00000001865DB6F0-0x00000001865DB790
		private void BreakSomething(PhaserSprite thing) {} // 0x00000001865DB790-0x00000001865DB9E0
		private void BreakMask(PhaserSprite mask) {} // 0x00000001865DB9E0-0x00000001865DBC30
	}
}
