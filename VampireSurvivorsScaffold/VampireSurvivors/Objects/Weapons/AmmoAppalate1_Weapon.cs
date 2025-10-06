/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class AmmoAppalate1_Weapon : Weapon // TypeDefIndex: 16121
	{
		// Fields
		protected int _accumulatedActivations; // 0x158
		private int _sfxIndex; // 0x15C
		private const WeaponType _counterWeaponType = WeaponType.EX_AMMO1_COUNTER; // Metadata: 0x01977B66
		private Weapon _counterWeapon; // 0x160
		public float[] _detuneValues; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _testBeatTimer; // 0x170
		protected SfxType _soundEffect; // 0x178
		protected float _soundVolume; // 0x17C
		protected float _musicBeatInterval; // 0x180
		protected float _timeUnit; // 0x184
		protected float _camOffsetPerc; // 0x188
		protected float _camSizePerc; // 0x18C
	
		// Properties
		protected virtual bool _isMirrored { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public virtual bool FireInTheFacedDirection { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public AmmoAppalate1_Weapon() {} // 0x0000000186F14480-0x0000000186F145A0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F12CA0-0x0000000186F12DF0
		protected virtual void Setuppo() {} // 0x0000000186F12DF0-0x0000000186F12E30
		protected virtual float GetProjectilesAmount() => default; // 0x0000000186F12E30-0x0000000186F12E70
		protected virtual float GetTimeUnit() => default; // 0x0000000186F12E70-0x0000000186F12E90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B64 */) {} // 0x0000000186F12E90-0x0000000186F12EA0
		public void OnBeatFire(bool skipTriggers = false /* Metadata: 0x01977B65 */) {} // 0x0000000186F12EA0-0x0000000186F13980
		public float2 RandomPos() => default; // 0x0000000186F13980-0x0000000186F13A90
		public override void Cleanup() {} // 0x0000000186F13A90-0x0000000186F13AC0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F13AC0-0x0000000186F13E00
		public override void CheckArcanas() {} // 0x0000000186F13E00-0x0000000186F14360
		public override bool LevelUp() => default; // 0x0000000186F14360-0x0000000186F14480
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
