/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class PhaserWeapon : Weapon // TypeDefIndex: 16754
	{
		// Fields
		protected List<BaseBody> bodies; // 0x158
		protected int _accumulatedActivations; // 0x160
		private int _sfxIndex; // 0x164
		public float[] _detuneValues; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _testBeatTimer; // 0x170
		protected SfxType _soundEffect; // 0x178
		protected float _soundVolume; // 0x17C
		protected float _musicBeatInterval; // 0x180
		protected float _timeUnit; // 0x184
		protected float _camOffsetPerc; // 0x188
		protected float _camSizePerc; // 0x18C
	
		// Constructors
		public PhaserWeapon() {} // 0x00000001870A5E00-0x00000001870A5F20
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x00000001870A5F20-0x00000001870A6120
		protected virtual void Setuppo() {} // 0x00000001870A6120-0x00000001870A6160
		protected virtual float GetProjectilesAmount() => default; // 0x00000001870A6160-0x00000001870A61A0
		protected virtual float GetTimeUnit() => default; // 0x0000000186F12E70-0x0000000186F12E90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E14 */) {} // 0x00000001870A61A0-0x00000001870A61B0
		public void OnBeatFire(bool skipTriggers = false /* Metadata: 0x01977E15 */) {} // 0x00000001870A61B0-0x00000001870A6B00
		public void OnBeatFireAlt(bool skipTriggers = false /* Metadata: 0x01977E16 */) {} // 0x00000001870A6B00-0x00000001870A7390
		public float2 RandomPos() => default; // 0x00000001870A7390-0x00000001870A74A0
		public virtual float2 PickRandomEnemyOnScreenRect() => default; // 0x00000001870A74A0-0x00000001870A7930
		public override void Cleanup() {} // 0x0000000186F13A90-0x0000000186F13AC0
	}
}
