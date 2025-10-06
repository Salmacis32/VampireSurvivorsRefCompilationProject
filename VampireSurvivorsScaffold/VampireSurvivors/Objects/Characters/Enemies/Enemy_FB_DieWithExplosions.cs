/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_FB_DieWithExplosions : EnemyController // TypeDefIndex: 17215
	{
		// Fields
		[SerializeField]
		private float OnDeathScaleMultiplier; // 0x270
		private bool hasExplosions; // 0x274
		private float _defaultScale; // 0x278
		private List<PhaserSprite> explosionSprites; // 0x280
		private float offsetRadius; // 0x288
		private List<VampireSurvivors.Framework.TimerSystem.Timer> explosionTimers; // 0x290
		private int ExplosionsNumber; // 0x298
		private Vector2 _SpriteOffset; // 0x29C
	
		// Constructors
		public Enemy_FB_DieWithExplosions() {} // 0x00000001871E6AE0-0x00000001871E6BE0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871E5CC0-0x00000001871E6570
		public override void Despawn() {} // 0x00000001871E6570-0x00000001871E65E0
		protected override void Die() {} // 0x00000001871E65E0-0x00000001871E6620
		private void PlayExplosions() {} // 0x00000001871E6620-0x00000001871E6AE0
	}
}
