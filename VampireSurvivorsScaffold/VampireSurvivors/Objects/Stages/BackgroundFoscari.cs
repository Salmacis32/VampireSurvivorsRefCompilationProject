/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundFoscari : BackgroundManager // TypeDefIndex: 15279
	{
		// Fields
		private MeshRenderer _magicWaterImage; // 0x80
		private TileSprite _water; // 0x88
		private bool _hasMagicWater; // 0x90
		private PhaserSprite _waterAnim; // 0x98
		private float _fsSealX; // 0xA0
		private float _fsSealY; // 0xA4
	
		// Constructors
		public BackgroundFoscari() {} // 0x0000000186B2E4C0-0x0000000186B2E4F0
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000186B2C960-0x0000000186B2CAE0
		protected void InitMagicWater() {} // 0x0000000186B2CAE0-0x0000000186B2D1E0
		public override void Create() {} // 0x0000000186B2D1E0-0x0000000186B2D870
		private void OnRemoteDestructibleSpawned(Destructible destructible) {} // 0x0000000186B2D870-0x0000000186B2D9B0
		public override void OnInitCompleted() {} // 0x0000000186B2D9B0-0x0000000186B2DA30
		protected override void OnUpdate() {} // 0x0000000186B2DA30-0x0000000186B2DC00
		public override void Cleanup() {} // 0x0000000186B2DC00-0x0000000186B2DC70
		private void InitVFX() {} // 0x0000000186B2DC70-0x0000000186B2E180
		private void CreateSeal1() {} // 0x0000000186B2E180-0x0000000186B2E3D0
		private void CreateBadge() {} // 0x0000000186B2E3D0-0x0000000186B2E4C0
	}
}
