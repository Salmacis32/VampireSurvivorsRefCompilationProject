/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Data
{
	[Serializable]
	public class CustomMerchantData // TypeDefIndex: 18614
	{
		// Properties
		[JsonProperty("merchantCharacter")]
		public VampireSurvivors.Data.CharacterType MerchantCharacter { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[JsonProperty("portraitSprite")]
		public string PortraitSprite { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[JsonProperty("portraitSpriteTexture")]
		public string PortraitSpriteTexture { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[JsonProperty("staticSprite")]
		public string StaticSprite { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[JsonProperty("staticSpriteTexture")]
		public string StaticSpriteTexture { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[JsonProperty("DLC")]
		public DlcType? DLC { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		[JsonProperty("isAnimated")]
		public bool IsAnimated { get; set; } // 0x0000000182699160-0x0000000182699170 0x0000000182699170-0x0000000182699180
		[JsonProperty("hideBackgroundParticles")]
		public bool HideBackgroundParticles { get; set; } // 0x0000000182A43640-0x0000000182A43650 0x000000018287CDA0-0x000000018287CDB0
		[JsonProperty("hideBackgroundWindows")]
		public bool HideBackgroundWindows { get; set; } // 0x000000018419B850-0x000000018419B860 0x000000018419B860-0x000000018419B870
		[JsonProperty("hideBackgroundMask")]
		public bool HideBackgroundMask { get; set; } // 0x0000000184A028C0-0x0000000184A028D0 0x00000001855BAF30-0x00000001855BAF40
		[JsonProperty("customCooldown")]
		public float? CustomCooldown { get; set; } // 0x000000018644F940-0x000000018644F950 0x00000001841C7E30-0x00000001841C7E40
		[JsonProperty("textLocKey")]
		public string TextLocKey { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		[JsonProperty("merchantXPos")]
		public float? MerchantXPos { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x0000000184BBA0D0-0x0000000184BBA0E0
		[JsonProperty("merchantYPos")]
		public float? MerchantYPos { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x0000000184E2EFF0-0x0000000184E2F000
		[JsonProperty("merchantInventory")]
		public List<WeaponType> MerchantInventory { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		[JsonProperty("merchantInventoryItems")]
		public List<VampireSurvivors.Data.ItemType> MerchantInventoryItems { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
	
		// Constructors
		public CustomMerchantData() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
