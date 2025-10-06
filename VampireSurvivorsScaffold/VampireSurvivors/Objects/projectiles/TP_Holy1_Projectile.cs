/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Holy1_Projectile : Projectile // TypeDefIndex: 15585
	{
		// Fields
		private const float Radius = 32f; // Metadata: 0x0197771D
		private const float CrossOffsetY = 0.44f; // Metadata: 0x01977721
		private const float CrossBGScale = 1.1f; // Metadata: 0x01977725
		private const float FadeDuration = 250f; // Metadata: 0x01977729
		private const int AnimFPS = 20; // Metadata: 0x0197772D
		private PhaserSprite _areaSprite; // 0xD0
		private PhaserSprite _crossSprite; // 0xD8
		private PhaserSprite _crossSprite2; // 0xE0
		private PhaserSprite _crossSpriteBG; // 0xE8
		private PhaserSprite _crossSpriteBG2; // 0xF0
		private Tween _scaleTween; // 0xF8
		private MultiTargetTween _alphaTween; // 0x100
		private MultiTargetTween _crossTween; // 0x108
		private MultiTargetTween _crossTween2; // 0x110
		private const float MaxAlpha = 0.8f; // Metadata: 0x0197772E
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _healTimer; // 0x128
		private TP_Holy1_Weapon _parentWeapon; // 0x130
		private bool _geminiProjectile; // 0x138
		private float2 _initialPos; // 0x13C
		private float[] _requiemRandomOffsets; // 0x148
		private int _requiemRandomIndex; // 0x150
	
		// Constructors
		public TP_Holy1_Projectile() {} // 0x0000000186CC4CF0-0x0000000186CC4DC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CC27D0-0x0000000186CC30E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CC30E0-0x0000000186CC3C60
		public override void InternalUpdate() {} // 0x0000000186CC3C60-0x0000000186CC3D10
		private void DoCrossAnim() {} // 0x0000000186CC3D10-0x0000000186CC4160
		public override void Despawn() {} // 0x0000000186CC4160-0x0000000186CC4470
		private void StartDespawn() {} // 0x0000000186CC4470-0x0000000186CC4850
		private void HealPlayersInArea() {} // 0x0000000186CC4850-0x0000000186CC4B00
		private bool IsCharacterInRange(CharacterController character) => default; // 0x0000000186CC4B00-0x0000000186CC4CF0
	}
}
