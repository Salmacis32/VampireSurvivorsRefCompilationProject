/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_CentralisCustos_Weapon : Weapon // TypeDefIndex: 16284
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _AreaRenderer; // 0x158
		[SerializeField]
		private SpriteRenderer _HeadRenderer; // 0x160
		[SerializeField]
		private SpriteRenderer _HeadEnrageEffect; // 0x168
		[SerializeField]
		private Transform _HeadScaler; // 0x170
		[SerializeField]
		private bool _enableDebugText; // 0x178
		[SerializeField]
		private TMP_Text _debugText; // 0x180
		private const float YPosOffset = 0.5f; // Metadata: 0x01977BFE
		private const float RendererScaleMultiplier = 2f; // Metadata: 0x01977C02
		private const float HeadRendererScaleMultiplier = 1f; // Metadata: 0x01977C06
		private SpriteAnimation _headAnim; // 0x188
		private const int AnimFPS = 20; // Metadata: 0x01977C0A
		private const float BonusStatsDuration = 2500f; // Metadata: 0x01977C0B
		private const float BonusArmor = 10f; // Metadata: 0x01977C0F
		private const float BonusRegen = 2f; // Metadata: 0x01977C13
		private const float BonusCooldown = 0.1f; // Metadata: 0x01977C17
		private const int StatBonusStackLimit = 1; // Metadata: 0x01977C1B
		private int _numStatBonusStacks; // 0x190
		private VampireSurvivors.Framework.TimerSystem.Timer _bonusRetriggerTimer; // 0x198
		private const float BonusRetriggerTime = 1000f; // Metadata: 0x01977C1C
		private bool _bonusCanTrigger; // 0x1A0
		private Tween _rotateTweenHandle; // 0x1A8
		private Tween _headRotateTween; // 0x1B0
		private DG.Tweening.Sequence _fadeTween; // 0x1B8
		private MultiTargetTween _headAlphaTween; // 0x1C0
		private MultiTargetTween _headScaleXTween; // 0x1C8
		private MultiTargetTween _headScaleYTween; // 0x1D0
		private MultiTargetTween _headEnrageTween; // 0x1D8
		private const float HeadDefaultAlpha = 0.6f; // Metadata: 0x01977C20
	
		// Constructors
		public TP_CentralisCustos_Weapon() {} // 0x0000000186F8D190-0x0000000186F8D1E0
	
		// Methods
		public override float PArea() => default; // 0x0000000186F89CC0-0x0000000186F89D20
		protected override void Awake() {} // 0x0000000186F89D20-0x0000000186F89DD0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F89DD0-0x0000000186F8AD10
		public override void Cleanup() {} // 0x0000000186F8AD10-0x0000000186F8B0E0
		public override void InternalUpdate() {} // 0x0000000186F8B0E0-0x0000000186F8B340
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F8B340-0x0000000186F8B480
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void SetVisible(bool visible) {} // 0x0000000186F8B480-0x0000000186F8B550
		private void OnPlayerDamaged() {} // 0x0000000186F8B550-0x0000000186F8B6D0
		private void ApplyStatBonuses(bool addStats = true /* Metadata: 0x01977BFD */) {} // 0x0000000186F8B6D0-0x0000000186F8C600
		private void StartLoopingAlphaTween() {} // 0x0000000186F8C600-0x0000000186F8C870
		private void DoScreenShake() {} // 0x0000000186F8C870-0x0000000186F8CD90
		private void UpdatePosition() {} // 0x0000000186F8CD90-0x0000000186F8CE90
		private void UpdateRenderersScaleToArea() {} // 0x0000000186F8CE90-0x0000000186F8D120
		private void UpdateDebugTextVisibility() {} // 0x0000000186F8D120-0x0000000186F8D160
		private float AlphaFromScale(float weaponArea, float maxScale, float minAlpha) => default; // 0x0000000186F8D160-0x0000000186F8D190
	}
}
