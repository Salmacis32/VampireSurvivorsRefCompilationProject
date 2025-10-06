/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class DebuffZoneFlexible : DamageZoneFlexible // TypeDefIndex: 15073
	{
		// Fields
		private DebuffType _debuffZoneType; // 0x118
		private float _slowAmount; // 0x11C
		private float _moneyDrainAmount; // 0x120
		private List<VampireSurvivors.Objects.Characters.CharacterController> _currentlyDebuffedPlayers; // 0x128
	
		// Nested types
		public enum DebuffType // TypeDefIndex: 15072
		{
			SLOW = 0,
			MONEY_DRAIN = 1
		}
	
		// Constructors
		public DebuffZoneFlexible() {} // 0x00000001869E96C0-0x00000001869E97F0
	
		// Methods
		public static DebuffZoneFlexible CreateDebuffZone(Camera targetCamera) => default; // 0x00000001869E8A20-0x00000001869E8C90
		public void InitDebuffZoneBehaviour(DebuffType debuffType, float debuffValue) {} // 0x00000001869E8C90-0x00000001869E8D50
		protected override void UpdatePlayerEffects() {} // 0x00000001869E8D50-0x00000001869E8E30
		private void HandleSlowDebuff(List<VampireSurvivors.Objects.Characters.CharacterController> players) {} // 0x00000001869E8E30-0x00000001869E91A0
		private void HandleMoneyDrain(List<VampireSurvivors.Objects.Characters.CharacterController> players) {} // 0x00000001869E91A0-0x00000001869E95C0
		protected override void Despawn() {} // 0x00000001869E95C0-0x00000001869E96C0
	}
}
