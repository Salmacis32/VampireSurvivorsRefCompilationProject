/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyGashadokuro : EnemyController // TypeDefIndex: 17323
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _FrontArm; // 0x270
		[SerializeField]
		private SpriteAnimation _FrontArmAnim; // 0x278
		[SerializeField]
		private SpriteRenderer _BackArm; // 0x280
		[SerializeField]
		private SpriteAnimation _BackArmAnim; // 0x288
		[SerializeField]
		private SpriteRenderer _Head; // 0x290
		[SerializeField]
		private SpriteAnimation _HeadAnim; // 0x298
		private Vector2 _frontOffset; // 0x2A0
		private Vector2 _backOffset; // 0x2A8
		private Vector2 _headOffset; // 0x2B0
		private Vector2 _invFrontOffset; // 0x2B8
		private Vector2 _invBackOffset; // 0x2C0
		private Vector2 _invHeadOffset; // 0x2C8
		private List<Sprite> _frameNamesArms; // 0x2D0
		private List<Sprite> _frameNamesArmsDie; // 0x2D8
		private List<Sprite> _frameNamesHead; // 0x2E0
		private List<Sprite> _frameNamesHeadDie; // 0x2E8
		private MultiTargetTween _armsSpinTween; // 0x2F0
		private MultiTargetTween _speedTween; // 0x2F8
		public float _SpeedMul; // 0x300
		private VampireSurvivors.Framework.TimerSystem.Timer _spinTimer; // 0x308
		private MultiTargetTween _armsSpinTween2; // 0x310
		private MultiTargetTween _speedTween2; // 0x318
		private VampireSurvivors.Framework.TimerSystem.Timer _summonTimer; // 0x320
		private int _spiritsToSummon; // 0x328
		private float _spinnnDelay; // 0x32C
		private float _summonTime; // 0x330
		private float _summonDelay; // 0x334
		private bool _spritesInitialised; // 0x338
		private bool _hasLostTreasure; // 0x339
	
		// Constructors
		public EnemyGashadokuro() {} // 0x000000018726AD30-0x000000018726AE20
	
		// Methods
		protected override void Awake() {} // 0x0000000187266E10-0x0000000187267150
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187267150-0x0000000187267570
		private void InitSprites() {} // 0x0000000187267570-0x00000001872678C0
		private void PlayDeathAnimations() {} // 0x00000001872678C0-0x0000000187267D00
		private void AndSpinnn() {} // 0x0000000187267D00-0x0000000187268690
		private void AndSummon() {} // 0x0000000187268690-0x00000001872686A0
		protected override void Die() {} // 0x00000001872686A0-0x00000001872686D0
		private void MakeTreasureChest() {} // 0x00000001872686D0-0x0000000187268D10
		public override void Disappear() {} // 0x0000000187268D10-0x0000000187268D30
		public override void Despawn() {} // 0x0000000187268D30-0x0000000187268EF0
		protected override void OnUpdate() {} // 0x0000000187268EF0-0x00000001872696E0
		private void DrownerWarning() {} // 0x00000001872696E0-0x0000000187269970
		private void RedWarning() {} // 0x0000000187269970-0x000000018726A520
		private void SingleWarning(float sizeX) {} // 0x000000018726A520-0x000000018726AD30
	}
}
