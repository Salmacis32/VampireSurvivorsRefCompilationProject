/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyTrina : EnemyController // TypeDefIndex: 17415
	{
		// Fields
		private int _activated; // 0x270
		private Tween _onEnterTween; // 0x278
		private float _legsAngle; // 0x280
		private SpriteRenderer _wings; // 0x288
		private SpriteRenderer _snakes; // 0x290
		private SpriteRenderer _legs; // 0x298
		private SpriteAnimation _wingsSpriteAnimation; // 0x2A0
		private SpriteAnimation _snakesSpriteAnimation; // 0x2A8
		private SpriteAnimation _legsSpriteAnimation; // 0x2B0
		private const float LegsSpeed = 500f; // Metadata: 0x01978560
	
		// Constructors
		public EnemyTrina() {} // 0x00000001872B5050-0x00000001872B50A0
	
		// Methods
		protected override void Awake() {} // 0x00000001872B3830-0x00000001872B3860
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B3860-0x00000001872B38F0
		public override void Disappear() {} // 0x00000001872B38F0-0x00000001872B3950
		public override void Despawn() {} // 0x00000001872B3950-0x00000001872B39B0
		protected override void OnUpdate() {} // 0x00000001872B39B0-0x00000001872B3BC0
		protected override void Die() {} // 0x00000001872B3BC0-0x00000001872B3C20
		private void GenerateSpritesAndAnims() {} // 0x00000001872B3C20-0x00000001872B43B0
		private void UpdateSprites() {} // 0x00000001872B43B0-0x00000001872B5050
	}
}
