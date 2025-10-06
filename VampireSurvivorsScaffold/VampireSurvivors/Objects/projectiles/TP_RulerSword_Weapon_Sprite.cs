/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_RulerSword_Weapon_Sprite : PhaserSprite // TypeDefIndex: 16007
	{
		// Fields
		private PhaserSprite _phaserSprite; // 0x40
		public TP_RulerSword_Weapon Weapon; // 0x48
		private Tween _scaleTween; // 0x50
		private List<Projectile> bodies; // 0x58
		public Vector2 offset_Idle; // 0x60
		public Vector2 offset_Attack; // 0x68
		private bool _isAttacking; // 0x70
	
		// Constructors
		public TP_RulerSword_Weapon_Sprite() {} // 0x0000000186EB10B0-0x0000000186EB11B0
	
		// Methods
		public void Initialize(TP_RulerSword_Weapon _weapon, int hitBoxesAmount) {} // 0x0000000186EAFFC0-0x0000000186EB0890
		public void Disable() {} // 0x0000000186EB0890-0x0000000186EB0960
		public void Enable() {} // 0x0000000186EB0960-0x0000000186EB0BA0
		public void Attack() {} // 0x0000000186EB0BA0-0x0000000186EB10B0
	}
}
