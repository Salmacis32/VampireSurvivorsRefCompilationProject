/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AlucardSpear1_Projectile : Projectile // TypeDefIndex: 15497
	{
		// Fields
		private MultiTargetTween _alphaTween; // 0xD0
		private MultiTargetTween _angleTween; // 0xD8
		private bool _flipToCheck; // 0xE0
		private float _flipSwitch; // 0xE4
		private VampireSurvivors.Framework.TimerSystem.Timer _attackDelay; // 0xE8
		private int _turnCount; // 0xF0
		private TP_AlucardSpear1_Weapon _trueWeapon; // 0xF8
		private float horizontalOffset; // 0x100
		private Vector2 _attackOffset; // 0x104
		private List<Projectile> _tips; // 0x110
		private float _ownerOffsetX; // 0x118
		private float _ownerOffsetY; // 0x11C
		private float offsetPx; // 0x120
		private List<float> _randomSpearOffsets; // 0x128
		private float2 _startingPosition; // 0x130
		private Tween _positionTween; // 0x138
	
		// Properties
		protected virtual string FrameName { get => default; } // 0x0000000186C383F0-0x0000000186C38430 
		protected virtual int AutoFlip { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
		protected virtual Vector2 ImageHalfSize { get => default; } // 0x0000000186C38430-0x0000000186C38450 
	
		// Constructors
		public TP_AlucardSpear1_Projectile() {} // 0x0000000186C3A080-0x0000000186C3A200
	
		// Methods
		protected override void Awake() {} // 0x0000000186C38450-0x0000000186C38500
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C38500-0x0000000186C38D90
		private void Forward() {} // 0x0000000186C38D90-0x0000000186C392C0
		private void CheckForFlip() {} // 0x0000000186C392C0-0x0000000186C39BD0
		private void FadeOut() {} // 0x0000000186C39BD0-0x0000000186C39E60
		public override void InternalUpdate() {} // 0x0000000186C39E60-0x0000000186C39ED0
		public override void Despawn() {} // 0x0000000186C39ED0-0x0000000186C3A080
	}
}
