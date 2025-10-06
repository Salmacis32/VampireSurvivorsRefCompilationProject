/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class ShroudProjectile : Projectile // TypeDefIndex: 15950
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _InversionVFX; // 0xD0
		[SerializeField]
		private SpriteRenderer _Bubble; // 0xD8
		public bool _ShroudActive; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private Tween _scaleTween; // 0xF0
		private Tween _inversionTween; // 0xF8
		private Tween _bubbleAlphaTween; // 0x100
		private Vector3 _parentTransformPos; // 0x108
		private const float Radius = 16f; // Metadata: 0x0197799A
		private bool _enableBodyOnNextFrame; // 0x114
	
		// Constructors
		public ShroudProjectile() {} // 0x0000000186E68C70-0x0000000186E68CC0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E678B0-0x0000000186E682F0
		public override void InternalUpdate() {} // 0x0000000186E682F0-0x0000000186E68500
		private bool HasSoleSolution() => default; // 0x0000000186E68500-0x0000000186E686D0
		public override void Despawn() {} // 0x0000000186E686D0-0x0000000186E68890
		private void PlaySound() {} // 0x0000000186E68890-0x0000000186E689B0
		private void InversionVFX(float radius, float duration) {} // 0x0000000186E689B0-0x0000000186E68C70
	}
}
