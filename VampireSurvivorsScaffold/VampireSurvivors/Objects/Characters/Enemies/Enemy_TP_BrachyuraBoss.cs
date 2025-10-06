/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_BrachyuraBoss : Enemy_TP_GateBoss // TypeDefIndex: 17243
	{
		// Fields
		[Header("Brachyura Boss")]
		[SerializeField]
		private PhaserSprite _pincerSpriteL; // 0x3A8
		[SerializeField]
		private PhaserSprite _pincerSpriteR; // 0x3B0
		[SerializeField]
		private SpriteAnimation _pincerLAnim; // 0x3B8
		[SerializeField]
		private SpriteAnimation _pincerRAnim; // 0x3C0
		private Vector2 _leftPincerPos; // 0x3C8
		private Vector2 _rightPincerPos; // 0x3D0
		private DG.Tweening.Sequence _fadeOutPincersTween; // 0x3D8
		private readonly Vector2 _leftOffset; // 0x3E0
		private readonly Vector2 _rightOffset; // 0x3E8
	
		// Constructors
		public Enemy_TP_BrachyuraBoss() {} // 0x0000000187204A40-0x0000000187204A70
	
		// Methods
		protected override void Awake() {} // 0x0000000187203C20-0x0000000187203DA0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187203DA0-0x0000000187204010
		public override void SetFlipX(bool flip) {} // 0x0000000180B15170-0x0000000180B15180
		public override void Disappear() {} // 0x0000000187204010-0x0000000187204060
		protected override void OnUpdate() {} // 0x0000000187204060-0x0000000187204080
		protected override void Die() {} // 0x0000000187204010-0x0000000187204060
		private void UpdatePincerTransforms() {} // 0x0000000187204080-0x0000000187204810
		private void FadeOutPincers() {} // 0x0000000187204810-0x0000000187204A40
	}
}
