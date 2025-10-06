/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class JubileeProjectile : Projectile // TypeDefIndex: 15907
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private JubileeWeapon _trueWeapon; // 0xD8
		private MultiTargetTween _emitterCounter; // 0xE0
		private int _basePixelSize; // 0xE8
		public float counter; // 0xEC
	
		// Constructors
		public JubileeProjectile() {} // 0x0000000186E39770-0x0000000186E397D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D1D3F0-0x0000000186D1D420
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E389F0-0x0000000186E39770
	}
}
