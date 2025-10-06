/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_RightFacing_CartRider : EnemyController // TypeDefIndex: 17420
	{
		// Fields
		private PhaserSprite _frontSprite; // 0x270
		private PhaserSprite _backSprite; // 0x278
		protected float2 _CartOffset; // 0x280
		private MultiTargetTween cartScaleTween; // 0x288
		private SoundManager.SoundConfig sfxConfig; // 0x290
		private Sprite _resetfrontSprite; // 0x298
		private Sprite _resetbackSprite; // 0x2A0
	
		// Constructors
		public Enemy_RightFacing_CartRider() {} // 0x00000001872B94C0-0x00000001872B9530
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B8700-0x00000001872B9010
		protected override void OnRecycleEnemy() {} // 0x00000001872B9010-0x00000001872B9020
		protected override void OnUpdate() {} // 0x00000001872B9020-0x00000001872B9200
		public override void Despawn() {} // 0x00000001872B9200-0x00000001872B9340
		protected override void Die() {} // 0x00000001872B9340-0x00000001872B9430
		public override void Disappear() {} // 0x00000001872B9430-0x00000001872B94C0
	}
}
