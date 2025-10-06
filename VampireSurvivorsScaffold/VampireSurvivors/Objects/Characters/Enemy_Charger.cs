/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class Enemy_Charger : EnemyController // TypeDefIndex: 17196
	{
		// Fields
		[Header("Charge Timer")]
		[SerializeField]
		private float chargeMechanicInterval; // 0x270
		[SerializeField]
		private float chargeActivationDelay; // 0x274
		[SerializeField]
		private float chargeActiveDuration; // 0x278
		[Space]
		private VampireSurvivors.Framework.TimerSystem.Timer _chargerMechanicTimer; // 0x280
		private VampireSurvivors.Framework.TimerSystem.Timer _chargeDelayTimer; // 0x288
		private VampireSurvivors.Framework.TimerSystem.Timer _chargeFinishTimer; // 0x290
		[Header("Charge Mechanics")]
		[SerializeField]
		private float chargeSpeedModifier; // 0x298
		[Space]
		private bool _isCharging; // 0x29C
		private bool _isMoving; // 0x29D
		private Vector2 _chargeDirection; // 0x2A0
		[Header("Charge Visuals")]
		[SerializeField]
		private SpriteTrail trail; // 0x2A8
		[Header("Charge Warning")]
		[SerializeField]
		[Space]
		private float flashRepeatingInterval; // 0x2B0
		[Space]
		private VampireSurvivors.Framework.TimerSystem.Timer _warningFlashTimer; // 0x2B8
		private bool _toggleWarningColour; // 0x2C0
		private PhaserSprite _exclamationMark; // 0x2C8
		private MultiTargetTween _warningTween; // 0x2D0
		private PhaserSprite _groundFx; // 0x2D8
	
		// Constructors
		public Enemy_Charger() {} // 0x00000001871DB880-0x00000001871DB910
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871D99B0-0x00000001871D9ED0
		protected override void OnUpdate() {} // 0x00000001871D9ED0-0x00000001871DA590
		private void ToggleWarningTint() {} // 0x00000001871DA590-0x00000001871DA670
		private void SetupChargeAtPlayer() {} // 0x00000001871DA670-0x00000001871DAF60
		private void ChargeAtPlayer() {} // 0x00000001871DAF60-0x00000001871DB350
		private void RestartMovement() {} // 0x00000001871DB350-0x00000001871DB4C0
		private Vector2 AdjustedMarkPositionY(float x, float y) => default; // 0x00000001871DB4C0-0x00000001871DB510
		protected override void Die() {} // 0x00000001871DB510-0x00000001871DB620
		public override void Disappear() {} // 0x00000001871DB620-0x00000001871DB650
		public override void Despawn() {} // 0x00000001871DB650-0x00000001871DB880
	}
}
