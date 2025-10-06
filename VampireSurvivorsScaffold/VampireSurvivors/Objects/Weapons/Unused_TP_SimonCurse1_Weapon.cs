/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Unused_TP_SimonCurse1_Weapon : TP_WhipCore1_Weapon // TypeDefIndex: 16546
	{
		// Fields
		protected BulletPool _firePool; // 0x178
		protected BulletPool _explosionPool; // 0x180
	
		// Constructors
		public Unused_TP_SimonCurse1_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x00000001870084A0-0x00000001870084C0
		public Projectile CreateFireProjectile(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977D2F */, int damage = 1 /* Metadata: 0x01977D30 */, float area = 1f /* Metadata: 0x01977D31 */) => default; // 0x00000001870084C0-0x0000000187008810
		public Projectile SpawnWhipExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977D35 */, int damage = 1 /* Metadata: 0x01977D36 */, float area = 1f /* Metadata: 0x01977D37 */) => default; // 0x0000000187008810-0x0000000187008B50
		protected override void OnDestroy() {} // 0x0000000187008B50-0x0000000187008C60
		public override void Cleanup() {} // 0x0000000187008C60-0x0000000187008CC0
	}
}
