/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class TileSpriteBuilder // TypeDefIndex: 14540
	{
		// Fields
		private Vector2 _pos; // 0x10
		private Vector3 _scale; // 0x18
		private string _textureName; // 0x28
		private string _spriteName; // 0x30
		private Vector2? _spritePivot; // 0x38
		private float _depth; // 0x44
		private float _depthMul; // 0x48
		private float _alpha; // 0x4C
		private Transform _parent; // 0x50
		private string _name; // 0x58
		private float _tileWidth; // 0x60
		private float _tileHeight; // 0x64
		private VampireSurvivors.Framework.Particles.BlendMode _blendMode; // 0x68
	
		// Constructors
		public TileSpriteBuilder() {} // 0x00000001871AA5A0-0x00000001871AA650
	
		// Methods
		public TileSpriteBuilder SetPosition(float x, float y) => default; // 0x00000001871A9A70-0x00000001871A9A80
		public TileSpriteBuilder SetScale(float scale) => default; // 0x00000001871A9A80-0x00000001871A9B00
		public TileSpriteBuilder SetScale(float xScale, float yScale) => default; // 0x00000001871A9B00-0x00000001871A9B20
		public TileSpriteBuilder SetSpriteInfo(string textureName, string spriteName) => default; // 0x00000001871A9B20-0x00000001871A9BD0
		public TileSpriteBuilder SetSpritePivot(Vector2? pivot) => default; // 0x00000001871A9BD0-0x00000001871A9BF0
		public TileSpriteBuilder SetDepth(float depth, float depthMul = 1f /* Metadata: 0x0197716D */) => default; // 0x00000001871A9BF0-0x00000001871A9C00
		public TileSpriteBuilder SetAlpha(float alpha) => default; // 0x00000001871A9C00-0x00000001871A9C10
		public TileSpriteBuilder SetParent(Transform parent) => default; // 0x0000000182887F60-0x0000000182887FC0
		public TileSpriteBuilder SetName(string name) => default; // 0x000000018260C7E0-0x000000018260C840
		public TileSpriteBuilder SetTileSize(float width, float height) => default; // 0x00000001871A9C10-0x00000001871A9C20
		public TileSpriteBuilder SetBlendMode(VampireSurvivors.Framework.Particles.BlendMode blendMode) => default; // 0x00000001871A9C20-0x00000001871A9C30
		public TileSprite Build() => default; // 0x00000001871A9C30-0x00000001871A9FF0
		private void GenerateSpriteRenderer(TileSprite tileSprite) {} // 0x00000001871A9FF0-0x00000001871AA4F0
		private void GenerateSpriteScroller(TileSprite tileSprite) {} // 0x00000001871AA4F0-0x00000001871AA5A0
	}
}
