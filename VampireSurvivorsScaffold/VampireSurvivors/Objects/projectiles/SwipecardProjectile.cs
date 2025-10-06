/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SwipecardProjectile : Projectile // TypeDefIndex: 15994
	{
		// Fields
		private float _volume; // 0xD0
		private float _timer; // 0xD4
		private int _swipeCounter; // 0xD8
		private int _minimumSwipes; // 0xDC
		private float _swipeSpeed; // 0xE0
		private bool _resettingSwipe; // 0xE4
		private bool _isFinished; // 0xE5
		private List<SfxType> _swipeSounds; // 0xE8
	
		// Constructors
		public SwipecardProjectile() {} // 0x0000000186E9FC40-0x0000000186E9FE60
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E9F0B0-0x0000000186E9F470
		private void PlayRandomSwipe() {} // 0x0000000186E9F470-0x0000000186E9F5F0
		private void UpdatePosition() {} // 0x0000000186E9F5F0-0x0000000186E9F6C0
		public override void InternalUpdate() {} // 0x0000000186E9F6C0-0x0000000186E9FC40
	}
}
