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
	public class Enemy_TP_BlackmoreBoss : Enemy_TP_GateBoss // TypeDefIndex: 17242
	{
		// Fields
		[Header("Blackmore Boss")]
		[SerializeField]
		private PhaserSprite _shadowSprite; // 0x3A8
		[SerializeField]
		private SpriteAnimation _shadowAnim; // 0x3B0
		private Vector2 _shadowPos; // 0x3B8
		private DG.Tweening.Sequence _fadeOutShadowTween; // 0x3C0
		private readonly Vector2 _shadowOffset; // 0x3C8
	
		// Constructors
		public Enemy_TP_BlackmoreBoss() {} // 0x0000000187203C10-0x0000000187203C20
	
		// Methods
		protected override void Awake() {} // 0x0000000187203230-0x0000000187203330
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187203330-0x00000001872034E0
		public override void SetFlipX(bool flip) {} // 0x00000001872034E0-0x0000000187203530
		public override void Disappear() {} // 0x0000000187203530-0x0000000187203580
		protected override void OnUpdate() {} // 0x0000000187203580-0x00000001872035A0
		protected override void Die() {} // 0x0000000187203530-0x0000000187203580
		private void UpdatePincerTransforms() {} // 0x00000001872035A0-0x0000000187203A30
		private void FadeOutShadow() {} // 0x0000000187203A30-0x0000000187203C10
	}
}
