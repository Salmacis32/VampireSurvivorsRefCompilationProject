/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework
{
	[CreateAssetMenu(fileName = "FontFactory", menuName = "VampireSurvivors/New FontFactory")]
	public class FontFactory : SerializedScriptableObject // TypeDefIndex: 18671
	{
		// Fields
		[SerializeField]
		private UnityFontRefDictionary _Fonts; // 0x58
		[SerializeField]
		private TMPFontRefDictionary _TMPFonts; // 0x60
	
		// Nested types
		[Serializable]
		public class UnityFontRefDictionary : UnitySerializedDictionary<string, UnityFontRefData> // TypeDefIndex: 18667
		{
			// Constructors
			public UnityFontRefDictionary() {} // 0x000000018681B540-0x000000018681B580
		}
	
		[Serializable]
		public class TMPFontRefDictionary : UnitySerializedDictionary<string, TMPFontRefData> // TypeDefIndex: 18668
		{
			// Constructors
			public TMPFontRefDictionary() {} // 0x000000018681B580-0x000000018681B5C0
		}
	
		[Serializable]
		public class UnityFontRefData // TypeDefIndex: 18669
		{
			// Fields
			[SerializeField]
			private AssetReferenceT<Font> _UnityFontRef; // 0x10
	
			// Properties
			public AssetReferenceT<Font> UnityFontRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public UnityFontRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		[Serializable]
		public class TMPFontRefData // TypeDefIndex: 18670
		{
			// Fields
			[SerializeField]
			private AssetReferenceT<TMP_FontAsset> _TMPFontRef; // 0x10
	
			// Properties
			public AssetReferenceT<TMP_FontAsset> TMPFontRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public TMPFontRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public FontFactory() {} // 0x000000018681B3B0-0x000000018681B540
	
		// Methods
		public Font GetFont(string fontName) => default; // 0x000000018681B1D0-0x000000018681B2C0
		public TMP_FontAsset GetTMPFont(string fontName) => default; // 0x000000018681B2C0-0x000000018681B3B0
	}
}
