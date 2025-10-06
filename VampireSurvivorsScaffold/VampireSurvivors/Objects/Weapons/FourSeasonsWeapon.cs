/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FourSeasonsWeapon : Weapon // TypeDefIndex: 16689
	{
		// Fields
		private PhaserSprite[] _orbs; // 0x158
		private MultiTargetTween[] _orbTweens; // 0x160
		private bool _canSpin; // 0x168
		public float2[] _positions; // 0x170
		private float _angleUnit; // 0x178
		private float[] _angles; // 0x180
		private float[] _cornerOffsets; // 0x188
	
		// Constructors
		public FourSeasonsWeapon() {} // 0x000000018707AD10-0x000000018707AE10
	
		// Methods
		public override float PPower() => default; // 0x00000001870790D0-0x0000000187079290
		protected override void FakeConstruct() {} // 0x0000000187079290-0x0000000187079720
		private void Set4Positions() {} // 0x0000000187079720-0x0000000187079AB0
		protected override void MakeLevelOne() {} // 0x0000000187079AB0-0x000000018707A240
		public override void InternalUpdate() {} // 0x000000018707A240-0x000000018707A560
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DD3 */) {} // 0x000000018707A560-0x000000018707A8C0
		public override void SetVisible(bool visible) {} // 0x000000018707A8C0-0x000000018707AA50
		public override void Cleanup() {} // 0x000000018707AA50-0x000000018707AD10
	}
}
