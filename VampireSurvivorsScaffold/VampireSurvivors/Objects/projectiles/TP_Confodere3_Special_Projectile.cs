/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Confodere3_Special_Projectile : Projectile // TypeDefIndex: 15516
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0xD0
		private bool _isDespawning; // 0xD8
		private MultiTargetTween _tween1; // 0xE0
		private MultiTargetTween _tween2; // 0xE8
		private MultiTargetTween _tween3; // 0xF0
		private SpriteMask _posterMask; // 0xF8
		private Tween posterTween; // 0x100
		private Material material; // 0x108
		private static readonly int _matColor; // 0x00
		private static readonly int _matAlpha; // 0x04
		private List<Vector3> colors; // 0x110
		private TP_Confodere1_Weapon trueWeapon; // 0x118
		private Tween angleTween; // 0x120
	
		// Constructors
		public TP_Confodere3_Special_Projectile() {} // 0x0000000186C790F0-0x0000000186C79330
		static TP_Confodere3_Special_Projectile() {} // 0x0000000186C79330-0x0000000186C793C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C77D80-0x0000000186C782D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C782D0-0x0000000186C78EF0
		public void StartDespawn() {} // 0x0000000186C78EF0-0x0000000186C79000
		public override void Despawn() {} // 0x0000000186C79000-0x0000000186C790F0
	}
}
