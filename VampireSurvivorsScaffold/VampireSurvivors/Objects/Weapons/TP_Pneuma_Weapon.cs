/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Pneuma_Weapon : Weapon // TypeDefIndex: 16439
	{
		// Fields
		private List<SpikeData> spikeData; // 0x158
		private BulletPool _waveProjectile; // 0x160
		private float _spikePosLeniency; // 0x168
	
		// Constructors
		public TP_Pneuma_Weapon() {} // 0x0000000186FDCCD0-0x0000000186FDCDD0
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CB0 */) {} // 0x0000000186FDBD10-0x0000000186FDBD80
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FDBD80-0x0000000186FDBE90
		private SpikeData nextSpikeData() => default; // 0x0000000186FDBE90-0x0000000186FDC1A0
		public void addSpikeSprite(float2 pos, float angle, float scale, float alpha) {} // 0x0000000186FDC1A0-0x0000000186FDC9B0
		public override void Cleanup() {} // 0x0000000186FDC9B0-0x0000000186FDCB40
		public override void SetVisible(bool visible) {} // 0x0000000186FDCB40-0x0000000186FDCCD0
	}
}
