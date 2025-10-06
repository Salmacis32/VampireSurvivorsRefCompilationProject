/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyMaddenerNormal : EnemyAlias // TypeDefIndex: 17351
	{
		// Fields
		[SerializeField]
		private GameObject _SingleWarningPrefab; // 0x278
		private float _spinRadius; // 0x280
		private Tween _onEnterTween; // 0x288
		private Tween _lowerScreenTween; // 0x290
		private Tween _spinningTween; // 0x298
		private DG.Tweening.Sequence _killTween; // 0x2A0
		private Bounds _camBounds; // 0x2A8
		private SpriteRenderer _ringSprite; // 0x2C0
	
		// Properties
		public Action OnDefeat { get; set; } // 0x0000000187280760-0x0000000187280770 0x0000000187280770-0x00000001872807D0
	
		// Constructors
		public EnemyMaddenerNormal() {} // 0x000000018722AA00-0x000000018722AA50
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872807D0-0x0000000187281150
		public override void Despawn() {} // 0x0000000187281150-0x00000001872811E0
		protected override void UpdateDepth() {} // 0x00000001872811E0-0x00000001872812C0
		protected override void Die() {} // 0x00000001872812C0-0x00000001872817C0
		private void SingleWarning(Vector2 pos) {} // 0x00000001872817C0-0x0000000187282000
	}
}
