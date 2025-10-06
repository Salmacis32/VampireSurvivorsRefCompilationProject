/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyFlag : EnemyController // TypeDefIndex: 17318
	{
		// Fields
		[SerializeField]
		protected TrailRenderer _Trail; // 0x270
		protected Tween _fadeTrailTween; // 0x278
		protected float _trailTime; // 0x280
		protected bool _goingRight; // 0x284
	
		// Constructors
		public EnemyFlag() {} // 0x00000001871E33F0-0x00000001871E3450
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187263AC0-0x0000000187263D50
		public override void Disappear() {} // 0x0000000187263D50-0x0000000187263DC0
		public override void Despawn() {} // 0x0000000187263DC0-0x0000000187263E00
		protected override void OnUpdate() {} // 0x0000000187263E00-0x0000000187263F80
		protected virtual Vector2 MovementCal() => default; // 0x0000000187263F80-0x0000000187264200
		protected virtual void InitTrail() {} // 0x0000000187264200-0x0000000187264480
		protected virtual void UpdateTrailFlip() {} // 0x0000000187264480-0x0000000187264530
		protected override void Die() {} // 0x0000000187264530-0x0000000187264560
		protected override void UpdateDepth() {} // 0x0000000187264560-0x0000000187264610
		protected void FadeTrailOut(bool instant = false /* Metadata: 0x0197843F */) {} // 0x0000000187264610-0x0000000187264870
	}
}
