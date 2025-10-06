/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Interfaces;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TrainHazardWeapon : Weapon // TypeDefIndex: 16789
	{
		// Fields
		private Vector2 location; // 0x158
		private float trainPixelSize; // 0x160
	
		// Constructors
		public TrainHazardWeapon() {} // 0x00000001870C2CF0-0x00000001870C2D90
	
		// Methods
		public override float PPower() => default; // 0x0000000186F2B880-0x0000000186F2B980
		public void FireFrom(Vector2 from, bool skipTriggers = false /* Metadata: 0x01977E40 */) {} // 0x00000001870C2880-0x00000001870C28A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E41 */) {} // 0x00000001870C28A0-0x00000001870C2BD0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void DealDamage(IDamageable other, float damage) {} // 0x00000001870C2BD0-0x00000001870C2CF0
	}
}
