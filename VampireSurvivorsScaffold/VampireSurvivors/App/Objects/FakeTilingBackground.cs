/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Objects
{
	public class FakeTilingBackground : GameMonoBehaviour // TypeDefIndex: 18564
	{
		// Fields
		private TileSprite _bgTile; // 0x28
		private float _speedFactor; // 0x30
	
		// Properties
		public TileSprite BgTile { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		public float SpeedFactor { get => default; set {} } // 0x0000000181949690-0x00000001819496A0 0x00000001819496A0-0x00000001819496B0
	
		// Constructors
		public FakeTilingBackground() {} // 0x00000001867E3AF0-0x00000001867E3B40
	
		// Methods
		protected override void OnUpdate() {} // 0x00000001867E3660-0x00000001867E3770
		public void MakeBackground(string textureName, VampireSurvivors.Objects.Stage stage) {} // 0x00000001867E3770-0x00000001867E3AF0
	}
}
