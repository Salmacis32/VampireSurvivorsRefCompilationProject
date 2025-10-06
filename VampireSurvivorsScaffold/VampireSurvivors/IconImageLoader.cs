/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class IconImageLoader : MonoBehaviour // TypeDefIndex: 14203
	{
		// Fields
		[SerializeField]
		private string _filterTextures; // 0x20
		private SpriteTextureDataInternal _spriteTextureData; // 0x28
		[SerializeField]
		private string _texture; // 0x40
		[SerializeField]
		private string _sprite; // 0x48
		private Sprite _spritePreview; // 0x50
		private Image _image; // 0x58
	
		// Nested types
		private struct SpriteTextureDataInternal // TypeDefIndex: 14202
		{
			// Fields
			public string Texture; // 0x00
			public string Sprite; // 0x08
			public Sprite SpriteRef; // 0x10
	
			// Constructors
			public SpriteTextureDataInternal(string texture, string sprite, Sprite spriteRef) {
				Texture = default;
				Sprite = default;
				SpriteRef = default;
			} // 0x00000001826CABD0-0x00000001826CACD0
		}
	
		// Constructors
		public IconImageLoader() {} // 0x0000000186DAFB70-0x0000000186DAFC40
	
		// Methods
		private void Awake() {} // 0x0000000186DAF990-0x0000000186DAFA20
		public void OnEnable() {} // 0x0000000186DAFA20-0x0000000186DAFB70
	}
}
