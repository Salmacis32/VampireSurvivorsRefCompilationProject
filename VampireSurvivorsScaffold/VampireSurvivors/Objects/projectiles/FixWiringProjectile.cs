/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FixWiringProjectile : Projectile // TypeDefIndex: 15439
	{
		// Fields
		private PhaserSprite _line; // 0xD0
		private PhaserSprite _wireCap; // 0xD8
		private FixWiringWeapon _trueWeapon; // 0xE0
		private bool _followCap; // 0xE8
		private MultiTargetTween _lineTween; // 0xF0
		private MultiTargetTween _wireCapTween; // 0xF8
		[NonSerialized]
		public bool Connected; // 0x100
		[NonSerialized]
		public uint Color; // 0x104
		[NonSerialized]
		public float2 StartPos; // 0x108
		[NonSerialized]
		public float2 TargetPos; // 0x110
		[NonSerialized]
		public int Num; // 0x118
	
		// Constructors
		public FixWiringProjectile() {} // 0x0000000186BFEE60-0x0000000186BFEEB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BFD780-0x0000000186BFD7A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BFD7A0-0x0000000186BFDE40
		public void Cleanup() {} // 0x0000000186BFDE40-0x0000000186BFE020
		public void setWireCapPos(float2 worldPos) {} // 0x0000000186BFE020-0x0000000186BFE070
		public void startLine(float2 from, float2 to, uint color, int num) {} // 0x0000000186BFE070-0x0000000186BFE9B0
		protected override void OnUpdate() {} // 0x0000000186BFE9B0-0x0000000186BFE9F0
		public void connectLine() {} // 0x0000000186BFE9F0-0x0000000186BFEB70
		public void SetCapVisible(bool visible) {} // 0x0000000186BFEB70-0x0000000186BFEC70
		public void clearLine() {} // 0x0000000186BFEC70-0x0000000186BFEE40
		public override void Despawn() {} // 0x0000000186BFEE40-0x0000000186BFEE60
	}
}
