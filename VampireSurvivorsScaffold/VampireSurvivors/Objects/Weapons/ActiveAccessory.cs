/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class ActiveAccessory : Accessory // TypeDefIndex: 16113
	{
		// Fields
		[SerializeField]
		protected WeaponType HiddenWeaponTypeToAdd; // 0x78
		[SerializeField]
		protected Weapon HiddenWeaponLinked; // 0x80
		[SerializeField]
		protected bool _hasPet; // 0x88
		[SerializeField]
		protected string _petSprite; // 0x90
		[SerializeField]
		protected string _petAnimPrefix; // 0x98
		[SerializeField]
		protected int _petAnimFrameCount; // 0xA0
		[SerializeField]
		protected float _petOffset; // 0xA4
		[SerializeField]
		protected int _framesPerSecond; // 0xA8
	
		// Constructors
		public ActiveAccessory() {} // 0x0000000186EEE800-0x0000000186EEE940
	
		// Methods
		protected override void MakeLevelOne() {} // 0x0000000186EEE190-0x0000000186EEE2D0
		public virtual void AfterWeaponAdded() {} // 0x0000000180B15170-0x0000000180B15180
		public override bool LevelUp(bool skipFire = false /* Metadata: 0x01977B63 */) => default; // 0x0000000186EEE2D0-0x0000000186EEE310
		public override void Cleanup() {} // 0x0000000186EEE310-0x0000000186EEE380
		private void MakePetFollower() {} // 0x0000000186EEE380-0x0000000186EEE800
	}
}
