/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class NovaProjectile : Projectile // TypeDefIndex: 15935
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _displaySprite; // 0xD0
		private float _displaySpritePxSize; // 0xD8
		private MultiTargetTween _tween1; // 0xE0
		private MultiTargetTween _tween2; // 0xE8
		private MultiTargetTween _tween3; // 0xF0
		private float SelfRadius; // 0xF8
		private Transform _cachedSpriteTransform; // 0x100
	
		// Constructors
		public NovaProjectile() {} // 0x0000000186E53150-0x0000000186E531C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E52470-0x0000000186E525A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E525A0-0x0000000186E52FC0
		public override void InternalUpdate() {} // 0x0000000186E52FC0-0x0000000186E530E0
		public void SetNovaTint(uint tintValue) {} // 0x0000000186E530E0-0x0000000186E53150
		public void SetBaseRadius(float value) {} // 0x000000018675D360-0x000000018675D370
	}
}
