/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class HatWeapon : Weapon // TypeDefIndex: 16198
	{
		// Fields
		[NonSerialized]
		public int MaxHats; // 0x158
		[NonSerialized]
		public int DragogionRand; // 0x15C
		private BulletPool _explosionPool; // 0x160
	
		// Constructors
		public HatWeapon() {} // 0x0000000186F59E40-0x0000000186F59EB0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F59700-0x0000000186F59A00
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BBB */) {} // 0x0000000186F59A00-0x0000000186F59B90
		public float throwInterval() => default; // 0x0000000186F59B90-0x0000000186F59C60
		public void ExplodeAt(float x, float y, int index) {} // 0x0000000186F59C60-0x0000000186F59CA0
		public override void Cleanup() {} // 0x0000000186F59CA0-0x0000000186F59CD0
		public override void CheckArcanas() {} // 0x0000000186F59CD0-0x0000000186F59E40
	}
}
