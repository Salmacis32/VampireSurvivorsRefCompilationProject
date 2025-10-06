/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Unused_TP_Lemuria1_Weapon : TP_WhipCore1_Weapon // TypeDefIndex: 16543
	{
		// Fields
		protected BulletPool _spikePool; // 0x178
	
		// Constructors
		public Unused_TP_Lemuria1_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000187006F50-0x0000000187006F70
		protected override void OnStart() {} // 0x0000000187006F70-0x0000000187007290
		public Projectile CreateSpikeProjectile(float2 pos, int index) => default; // 0x0000000187007290-0x00000001870075F0
		public void FireSpikes(Vector2 spikePos, bool _flipX) {} // 0x00000001870075F0-0x0000000187007950
		protected override void OnDestroy() {} // 0x0000000186FC81B0-0x0000000186FC8230
		public override void Cleanup() {} // 0x0000000187007950-0x00000001870079A0
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
	}
}
