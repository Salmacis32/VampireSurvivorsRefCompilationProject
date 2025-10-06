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
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyCrabbino : EnemyController // TypeDefIndex: 17288
	{
		// Fields
		[SerializeField]
		protected PhaserSprite _pincerSpriteL; // 0x270
		[SerializeField]
		protected PhaserSprite _pincerSpriteR; // 0x278
		[SerializeField]
		protected SpriteAnimation _pincerLAnim; // 0x280
		[SerializeField]
		protected SpriteAnimation _pincerRAnim; // 0x288
		private Vector2 _leftPincerPos; // 0x290
		private Vector2 _rightPincerPos; // 0x298
		protected DG.Tweening.Sequence _fadeOutPincersTween; // 0x2A0
		protected Vector2 LeftOffset; // 0x2A8
		protected Vector2 RightOffset; // 0x2B0
	
		// Constructors
		public EnemyCrabbino() {} // 0x00000001872275A0-0x00000001872275F0
	
		// Methods
		protected override void Awake() {} // 0x000000018723F150-0x000000018723F230
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018723F230-0x000000018723F260
		protected virtual void SetupPincers() {} // 0x000000018723F260-0x000000018723F4B0
		public override void Disappear() {} // 0x000000018723F4B0-0x000000018723F4D0
		public override void Despawn() {} // 0x000000018723F4D0-0x000000018723F4F0
		protected override void OnUpdate() {} // 0x000000018723F4F0-0x000000018723F520
		protected override void Die() {} // 0x000000018723F520-0x000000018723F540
		protected virtual void UpdatePincerTransforms() {} // 0x000000018723F540-0x000000018723FCD0
		private void FadeOutPincers() {} // 0x000000018723FCD0-0x000000018723FF00
	}
}
