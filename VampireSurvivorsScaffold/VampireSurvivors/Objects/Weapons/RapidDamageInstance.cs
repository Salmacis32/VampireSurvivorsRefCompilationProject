/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public struct RapidDamageInstance // TypeDefIndex: 16653
	{
		// Fields
		public float RemainingDamage; // 0x00
		private readonly Weapon _parentWeapon; // 0x08
		public readonly EnemyController Target; // 0x10
		private readonly float DamagePerHit; // 0x18
		private readonly float DamageInterval; // 0x1C
		private float _timeUntilNextDamage; // 0x20
	
		// Constructors
		public RapidDamageInstance(Weapon parentWeapon, EnemyController target, float remainingDamage, float damagePerHit, float damageInterval) {
			RemainingDamage = default;
			_parentWeapon = default;
			Target = default;
			DamagePerHit = default;
			DamageInterval = default;
			_timeUntilNextDamage = default;
		} // 0x00000001870336D0-0x00000001870337A0
	
		// Methods
		public RapidDamageInstance Update(float deltaTime, SignalBus signalBus, bool showDamageNumbers) => default; // 0x00000001870337A0-0x0000000187033B10
		private void DoDamage(float damageAmount, Vector3 damagePosition) {} // 0x0000000187033B10-0x0000000187033C10
	}
}
