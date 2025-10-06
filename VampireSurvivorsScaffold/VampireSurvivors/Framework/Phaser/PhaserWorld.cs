/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Phaser
{
	public class PhaserWorld : GameMonoBehaviour // TypeDefIndex: 18220
	{
		// Fields
		[SerializeField]
		private bool _EnableHideFlags; // 0x28
		private Transform _phaserSpritesParent; // 0x30
		private static PhaserWorld _instance; // 0x00
	
		// Properties
		public static PhaserWorld Instance { get => default; } // 0x0000000186705690-0x0000000186705840 
	
		// Constructors
		public PhaserWorld() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x0000000186705840-0x00000001867058E0
		public T AddPhaserSpriteOfType<T>(float2 pos, string texture = null, string spriteName = null)
			where T : PhaserSprite => default;
		public PhaserSprite AddPhaserSprite(Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867058E0-0x0000000186705900
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public PhaserSprite AddPhaserSprite(Vector2 pos, string texture = null, string spriteName = null) => default; // 0x0000000186705900-0x00000001867059B0
		public PhaserSprite AddRectangle(Vector2 pos, float width, float height, uint fillColor) => default; // 0x00000001867059B0-0x0000000186705AE0
		private void GenerateParents() {} // 0x0000000186705AE0-0x0000000186705C50
		private void ToggleHideFlags() {} // 0x0000000186705C50-0x0000000186705CC0
	}
}
