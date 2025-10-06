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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class ColdExplosionWeapon : Weapon // TypeDefIndex: 16155
	{
		// Fields
		public bool _DoesRetaliate; // 0x158
		private bool _canExplode; // 0x159
		private Tween _explodeTimer; // 0x160
	
		// Constructors
		public ColdExplosionWeapon() {} // 0x0000000186F30D30-0x0000000186F30D80
	
		// Methods
		public override float PPower() => default; // 0x0000000186F30B00-0x0000000186F30BA0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F30BA0-0x0000000186F30BC0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public void ExplodeAt(Vector2 position, bool ignoreCooldown = false /* Metadata: 0x01977B94 */) {} // 0x0000000186F30BC0-0x0000000186F30D30
	}
}
