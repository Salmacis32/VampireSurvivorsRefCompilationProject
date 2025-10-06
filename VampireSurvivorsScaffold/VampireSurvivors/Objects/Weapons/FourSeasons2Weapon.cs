/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FourSeasons2Weapon : Weapon // TypeDefIndex: 16687
	{
		// Fields
		private PhaserSprite[] _orbs; // 0x158
		private bool _canSpin; // 0x160
		public float2[] _positions; // 0x168
		private float _angleUnit; // 0x170
		private float[] _angles; // 0x178
	
		// Constructors
		public FourSeasons2Weapon() {} // 0x0000000187078FF0-0x0000000187079050
	
		// Methods
		public override float PPower() => default; // 0x0000000187077C00-0x0000000187077DB0
		protected override void FakeConstruct() {} // 0x0000000187077DB0-0x0000000187078210
		private void Set5Positions() {} // 0x0000000187078210-0x00000001870785E0
		protected override void MakeLevelOne() {} // 0x00000001870785E0-0x0000000187078710
		public override void InternalUpdate() {} // 0x0000000187078710-0x0000000187078B00
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DD2 */) {} // 0x0000000187078B00-0x0000000187078E60
		public override void SetVisible(bool visible) {} // 0x0000000187078E60-0x0000000187078FF0
	}
}
