/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class SpriteManager : IInitializable // TypeDefIndex: 14536
	{
		// Fields
		public static bool HighlightMissingAssetErrors; // 0x00
		private Sprite[] _rawSprites; // 0x10
		private static readonly Dictionary<StringHashCaseI, Sprite> Sprites; // 0x08
		private static readonly Dictionary<StringHashCaseI, string> AnimationsTextureReferences; // 0x10
		private static readonly Dictionary<StringHashCaseI, List<Sprite>> Animations; // 0x18
		private static readonly Dictionary<StringHashCaseI, Texture2D> SpritesAsTextures; // 0x20
		private static readonly Dictionary<StringHashCaseI, Dictionary<StringHashCaseI, Sprite>> SpriteTextureReference; // 0x28
		private static readonly Dictionary<int, string> FastAnimationsTextureReferences; // 0x30
		private static readonly Dictionary<int, List<Sprite>> FastAnimations; // 0x38
		private static readonly bool LogWarnings; // 0x40
		private static readonly Dictionary<string, Dictionary<string, Sprite>> SpriteTextureCache; // 0x48
		private static readonly ProfilerMarker MarkerGetSprite1; // 0x50
		private static readonly ProfilerMarker MarkerGetSprite2; // 0x58
		private static readonly ProfilerMarker _markerGetAnimationFrames; // 0x60
		private static readonly ProfilerMarker MarkerGetAnimationFramesFast; // 0x68
	
		// Nested types
		public class StringHashCaseIComparer : IEqualityComparer<StringHashCaseI> // TypeDefIndex: 14534
		{
			// Fields
			public static readonly StringHashCaseIComparer Instance; // 0x00
	
			// Constructors
			public StringHashCaseIComparer() {} // 0x0000000180B15170-0x0000000180B15180
			static StringHashCaseIComparer() {} // 0x00000001871A3AC0-0x00000001871A3B60
	
			// Methods
			public bool Equals(StringHashCaseI x, StringHashCaseI y) => default; // 0x00000001832367F0-0x0000000183236800
			public int GetHashCode(StringHashCaseI obj) => default; // 0x0000000182F29440-0x0000000182F29450
		}
	
		public struct StringHashCaseI : IEquatable<StringHashCaseI> // TypeDefIndex: 14535
		{
			// Fields
			public readonly int _Hash; // 0x00
	
			// Constructors
			public StringHashCaseI(string str) {
				_Hash = default;
			} // 0x00000001871A3B60-0x00000001871A3B90
			public StringHashCaseI(string str, bool ignoreExtension) {
				_Hash = default;
			} // 0x00000001871A3B90-0x00000001871A3C00
	
			// Methods
			public static implicit operator StringHashCaseI(string str) => default; // 0x00000001871A3C00-0x00000001871A3C10
			public static int GetStrHashCode(string str, int lenght = -1 /* Metadata: 0x01977169 */) => default; // 0x00000001871A3C10-0x00000001871A3CF0
			public override bool Equals(object obj) => default; // 0x00000001871A3CF0-0x00000001871A3D80
			public override int GetHashCode() => default; // 0x000000018195AD90-0x000000018195ADA0
			public bool Equals(StringHashCaseI other) => default; // 0x0000000182A69D60-0x0000000182A69D70
		}
	
		// Constructors
		public SpriteManager() {} // 0x0000000180B15170-0x0000000180B15180
		static SpriteManager() {} // 0x0000000187064220-0x0000000187064A50
	
		// Methods
		public void Initialize() {} // 0x000000018705E970-0x000000018705EC00
		public static Sprite GetSpriteFast(string spriteName, string textureName) => default; // 0x000000018705EC00-0x000000018705EC70
		public static Sprite GetSprite(string spriteName, bool ignoreExtension = true /* Metadata: 0x01977159 */) => default; // 0x000000018705EC70-0x000000018705EEE0
		public static Sprite GetUnpackedSprite(string spriteName, bool ignoreExtension = true /* Metadata: 0x0197715A */) => default; // 0x000000018705EEE0-0x000000018705F150
		public static bool TextureExists(string textureName) => default; // 0x000000018705F150-0x000000018705F200
		public static Sprite GetSprite(SpriteTextureData sprite) => default; // 0x000000018705F200-0x000000018705F260
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static Sprite GetSprite(string spriteName, string textureName, bool ignoreExtension = true /* Metadata: 0x0197715B */) => default; // 0x000000018705F260-0x000000018705F900
		public static bool DoesSpriteExistInTexture(string spriteName, string textureName, bool ignoreExtension = true /* Metadata: 0x0197715C */) => default; // 0x000000018705F900-0x000000018705FAD0
		public static Sprite GetUnpackedSprite(string spriteName, Vector2 newPivot) => default; // 0x000000018705FAD0-0x000000018705FD30
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static Sprite GetSprite(string spriteName, Vector2 newPivot, string textureName, bool respectOriginalXPivot = false /* Metadata: 0x0197715D */) => default; // 0x000000018705FD30-0x00000001870600F0
		public static Sprite GetSprite(SpriteTextureData sprite, Vector2 newPivot, bool respectOriginalXPivot = false /* Metadata: 0x0197715E */) => default; // 0x00000001870600F0-0x0000000187060170
		public static Texture2D GetSpriteAsTexture(string spriteName, string textureName, bool generateMipMaps = false /* Metadata: 0x0197715F */) => default; // 0x0000000187060170-0x0000000187060420
		public static List<Sprite> GetAnimation(string animName, int startValue, int frameCount, string textureName, bool addLeadingZeros = true /* Metadata: 0x01977160 */) => default; // 0x0000000187060420-0x0000000187060930
		public static List<Sprite> GetAnimationFrames(SpriteAnimationData spriteAnimation, int zeroPad = 0 /* Metadata: 0x01977161 */) => default; // 0x0000000187060930-0x00000001870609F0
		public static List<Sprite> GetAnimationFrames(string animName, int start, int end, string textureName, int zeroPad = 0 /* Metadata: 0x01977162 */) => default; // 0x00000001870609F0-0x0000000187061040
		public static List<Sprite> GetAnimationFrames(SpriteAnimationData spriteAnimation, Vector2 pivot, int zeroPad = 0 /* Metadata: 0x01977163 */, bool respectOriginalXPivot = false /* Metadata: 0x01977164 */) => default; // 0x0000000187061040-0x0000000187061140
		public static List<Sprite> GetAnimationFrames(string animName, int start, int end, Vector2 pivot, string textureName, int zeroPad = 0 /* Metadata: 0x01977165 */, bool respectOriginalXPivot = false /* Metadata: 0x01977166 */) => default; // 0x0000000187061140-0x00000001870616D0
		public static List<Sprite> GetAnimationFrames(List<string> frameNames, string textureName) => default; // 0x00000001870616D0-0x0000000187061930
		public static List<Sprite> GetAnimationFrames(List<string> frameNames, string textureName, Vector2 pivot) => default; // 0x0000000187061930-0x0000000187061BC0
		public static List<Sprite> GetAnimationFramesFast(List<string> frameNames, string textureName, bool skipCache = false /* Metadata: 0x01977167 */) => default; // 0x0000000187061BC0-0x00000001870620F0
		public static List<string> GenerateFrameNames(int start, int end, int zeroPad = 0 /* Metadata: 0x01977168 */, string prefix = null) => default; // 0x00000001870620F0-0x00000001870622F0
		private void LoadAllSpriteSheets() {} // 0x00000001870622F0-0x0000000187062450
		public static void RegisterSprites(Sprite[] rawSprites) {} // 0x0000000187062450-0x00000001870624F0
		public static void RegisterSprite(Sprite s) {} // 0x00000001870624F0-0x0000000187062A10
		public static Sprite UnregisterSprite(string spriteName) => default; // 0x0000000187062A10-0x0000000187062E50
		public static void UnregisterTexture(string textureName) {} // 0x0000000187062E50-0x0000000187063D20
		private static string RemoveExtension(string name) => default; // 0x0000000187063D20-0x0000000187063D80
		private static bool CheckIfAnimationExists(string name) => default; // 0x0000000187063D80-0x0000000187063E40
		private static void AddCustomPhaserMappings() {} // 0x0000000187063E40-0x0000000187063F50
		private static List<string> FramesNumberArray(int start, int end, string prefix = null, string suffix = null) => default; // 0x0000000187063F50-0x0000000187064220
	}
}
