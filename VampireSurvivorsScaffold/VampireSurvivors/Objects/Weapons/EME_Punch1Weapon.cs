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
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Punch1Weapon : EME_Weapon // TypeDefIndex: 16613
	{
		// Fields
		private const float RAKSHA_REPEAT_INTERVAL = 500f; // Metadata: 0x01977D80
		private bool _flipVisuals; // 0x1C8
		private float _screenPerimeter; // 0x1CC
		[SerializeField]
		private ParticleSystem guayimPunchingVFX; // 0x1D0
		private PhaserSprite _guayimPlayerSpriteRenderer; // 0x1D8
		private PhaserSprite _guayimBackgroundFader; // 0x1E0
		private float _guayimExecutionDelayDefault; // 0x1E8
		private float _guayimExecutionDelta; // 0x1EC
		private float _guayimExecutionDelay; // 0x1F0
		private bool _isGuayimRunning; // 0x1F4
		private bool _playSoundsDuringUpdate; // 0x1F5
		private float _detuneValue; // 0x1F8
		public SfxType HitSound; // 0x1FC
		private float _guayimFiringDelta; // 0x200
		private float _guayimFiringDelay; // 0x204
		private bool _updateGuayim; // 0x208
		private MultiTargetTween _guayimFadeTween; // 0x210
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex1 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex2 { get => default; } // 0x0000000181FFA580-0x0000000181FFA590 
		protected override int _comboIndex3 { get => default; } // 0x0000000181FFDDC0-0x0000000181FFDDD0 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
	
		// Constructors
		public EME_Punch1Weapon() {} // 0x0000000187023860-0x00000001870238A0
	
		// Methods
		public override void InternalUpdate() {} // 0x0000000187020700-0x0000000187020730
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187020730-0x0000000187020830
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187020830-0x0000000187021670
		public void FireSpecialProjectiles() {} // 0x0000000187021670-0x0000000187021AE0
		private float Perimeter(Rect rect) => default; // 0x0000000187021AE0-0x0000000187021B00
		private Vector2 GetPoint(Rect rectangle, float ratio) => default; // 0x0000000187021B00-0x0000000187021BD0
		protected override void InitGlimmer1BulletPool() {} // 0x0000000187021BD0-0x0000000187021F50
		protected override void InitGlimmer2BulletPool() {} // 0x0000000187021F50-0x00000001870222D0
		protected override void InitGlimmer3BulletPool() {} // 0x00000001870222D0-0x0000000187022560
		protected bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187022560-0x00000001870226D0
		protected bool OnBulletOverlapsEnemyLowDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870226D0-0x0000000187022840
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187022840-0x0000000187022870
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187022870-0x0000000187022D10
		private void StartGuayim() {} // 0x0000000187022D10-0x0000000187022D90
		private void DisplayGuayimVFX() {} // 0x0000000187022D90-0x0000000187023250
		private void HideGuayimVFX() {} // 0x0000000187023250-0x0000000187023560
		private void StopGuayim() {} // 0x0000000187023560-0x0000000187023580
		private void ClearGuayimVFX() {} // 0x0000000187023580-0x00000001870235B0
		public void GuayimUpdate() {} // 0x00000001870235B0-0x0000000187023860
		public override void CheckArcanas() {} // 0x0000000186F71380-0x0000000186F71480
	}
}
