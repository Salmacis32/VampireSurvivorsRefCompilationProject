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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FollowerGarlicWeapon : Weapon // TypeDefIndex: 16685
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Renderer; // 0x158
		private Tween _rotateTweenHandle; // 0x160
		private DG.Tweening.Sequence _fadeTween; // 0x168
		private bool _cooldownAffectedByMovement; // 0x170
		private const float Mul = 166.66667f; // Metadata: 0x01977DCE
	
		// Constructors
		public FollowerGarlicWeapon() {} // 0x0000000187077BB0-0x0000000187077C00
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187076EA0-0x00000001870773B0
		public override void Cleanup() {} // 0x00000001870773B0-0x0000000187077590
		public override void InternalUpdate() {} // 0x0000000187077590-0x00000001870777A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DCD */) {} // 0x00000001870777A0-0x00000001870777D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x00000001870777D0-0x0000000187077910
		public override void CheckArcanas() {} // 0x0000000187077910-0x00000001870779D0
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PPower() => default; // 0x0000000186F32BA0-0x0000000186F32BF0
		private void UpdateRendererScaleToArea() {} // 0x00000001870779D0-0x0000000187077B30
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void SetVisible(bool visible) {} // 0x0000000187077B30-0x0000000187077BB0
	}
}
