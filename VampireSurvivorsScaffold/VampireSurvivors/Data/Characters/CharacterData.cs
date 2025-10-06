/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Poncle.Schema.Attributes.Attributes;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Characters
{
	[Serializable]
	[Title("Character")]
	public class CharacterData // TypeDefIndex: 18470
	{
		// Fields
		[ReadOnly(true)]
		public const string CharacterLangSheet = "characterLang/"; // Metadata: 0x0197A986
		[ReadOnly(true)]
		public const string SkinLangSheet = "skinLang/"; // Metadata: 0x0197A995
	
		// Properties
		public bool allowCoopOutline { get; set; } // 0x0000000180B15AC0-0x0000000180B15AD0 0x000000018195A980-0x000000018195A990
		[Title("Hidden")]
		public bool hidden { get; set; } // 0x000000018195ABE0-0x000000018195ABF0 0x000000018195C940-0x000000018195C950
		[Title("Always Hidden")]
		public bool alwaysHidden { get; set; } // 0x0000000181DFEFB0-0x0000000181DFEFC0 0x0000000181DFEFC0-0x0000000181DFEFD0
		[Title("Secret")]
		public bool secret { get; set; } // 0x0000000181DFEFD0-0x0000000181DFEFE0 0x0000000181DFEFE0-0x0000000181DFEFF0
		[Title("Hide Weapon Icon")]
		public bool hideWeaponIcon { get; set; } // 0x000000018195FC30-0x000000018195FC40 0x000000018195FC40-0x000000018195FC50
		[Required]
		[Title("Level")]
		public int level { get; set; } // 0x00000001819457C0-0x00000001819457D0 0x000000018195FC50-0x000000018195FC60
		[Title("Starting Weapon")]
		public WeaponType? startingWeapon { get; set; } // 0x0000000186751C00-0x0000000186751C10 0x0000000182894130-0x0000000182894140
		[Title("Cooldown")]
		public float cooldown { get; set; } // 0x0000000184C5EF80-0x0000000184C5EF90 0x0000000184C5EF90-0x0000000184C5EFA0
		[Title("Prefix")]
		public string prefix { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Character Name")]
		public string charName { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[Title("Surname")]
		public string surname { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[Title("Texture Name")]
		public string textureName { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		[Title("Sprite Name")]
		public string spriteName { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		[Title("Char Sel Texture")]
		public string charSelTexture { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		[Title("Char Sel Frame")]
		public string charSelFrame { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		[Title("Portrait Name")]
		public string portraitName { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x000000018117C120-0x000000018117C180
		[Title("Walking Frames")]
		public int walkingFrames { get; set; } // 0x0000000182A74C20-0x0000000182A74C30 0x0000000182A74C30-0x0000000182A74C40
		[Title("Head Offsets")]
		public List<Vector2> headOffsets { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
		[Title("Skins")]
		public List<Skin> skins { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		[Title("Walk Frame Rate")]
		public int? walkFrameRate { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x000000018655F360-0x000000018655F370
		[Title("Description")]
		public string description { get; set; } // 0x00000001819A03E0-0x00000001819A03F0 0x00000001819A03F0-0x00000001819A0450
		[Title("Price")]
		public float price { get; set; } // 0x0000000184E163F0-0x0000000184E16400 0x000000018675D2C0-0x000000018675D2D0
		[Title("Max HP")]
		public float maxHp { get; set; } // 0x00000001828A0120-0x00000001828A0130 0x000000018675D2D0-0x000000018675D2E0
		[Title("Armor")]
		public float armor { get; set; } // 0x00000001828A0160-0x00000001828A0170 0x000000018675D2E0-0x000000018675D2F0
		[Title("Regen")]
		public float regen { get; set; } // 0x000000018675D2F0-0x000000018675D300 0x000000018675D300-0x000000018675D310
		[Title("Move Speed")]
		public float moveSpeed { get; set; } // 0x00000001846DB9B0-0x00000001846DB9C0 0x0000000186758970-0x0000000186758980
		[Title("Power")]
		public double power { get; set; } // 0x000000018675D310-0x000000018675D320 0x000000018675D320-0x000000018675D330
		[Title("Area")]
		public float area { get; set; } // 0x0000000186256150-0x0000000186256160 0x0000000186256160-0x0000000186256170
		[Title("Speed")]
		public float speed { get; set; } // 0x0000000185DD4A60-0x0000000185DD4A70 0x0000000186256170-0x0000000186256180
		[Title("Duration")]
		public float duration { get; set; } // 0x000000018656C770-0x000000018656C780 0x000000018656C780-0x000000018656C790
		[Title("Amount")]
		public float amount { get; set; } // 0x000000018293AC00-0x000000018293AC10 0x0000000185DD4B80-0x0000000185DD4B90
		[Title("Luck")]
		public float luck { get; set; } // 0x0000000183725DA0-0x0000000183725DB0 0x0000000183725DB0-0x0000000183725DC0
		[Title("Growth")]
		public float growth { get; set; } // 0x000000018675D330-0x000000018675D340 0x000000018675D340-0x000000018675D350
		[Title("Greed")]
		public float greed { get; set; } // 0x0000000183725DE0-0x0000000183725DF0 0x0000000183725DF0-0x0000000183725E00
		[Title("Magnet")]
		public float magnet { get; set; } // 0x0000000183725E00-0x0000000183725E10 0x0000000183725E10-0x0000000183725E20
		[Title("Revivals")]
		public float revivals { get; set; } // 0x0000000182906D90-0x0000000182906DA0 0x0000000183725FD0-0x0000000183725FE0
		[Title("Curse")]
		public float curse { get; set; } // 0x0000000182907E40-0x0000000182907E50 0x0000000185DD4BF0-0x0000000185DD4C00
		[Title("Shields")]
		public float shields { get; set; } // 0x0000000182917620-0x0000000182917630 0x00000001867530D0-0x00000001867530E0
		[Title("Rerolls")]
		public float reRolls { get; set; } // 0x0000000182907680-0x0000000182907690 0x00000001867589B0-0x00000001867589C0
		[Title("Skips")]
		public float skips { get; set; } // 0x0000000185138410-0x0000000185138420 0x0000000185138420-0x0000000185138430
		[Title("Banish")]
		public float banish { get; set; } // 0x0000000181945E20-0x0000000181945E30 0x0000000185138430-0x0000000185138440
		[CanBeNull]
		[Title("Showcase")]
		public List<WeaponType> showcase { get; set; } // 0x0000000182766DD0-0x0000000182766DE0 0x0000000184755900-0x0000000184755960
		[CanBeNull]
		[Title("Level Up Presets")]
		public List<Loadout> levelUpPresets { get; set; } // 0x00000001819716C0-0x00000001819716D0 0x0000000180B3E860-0x0000000180B3E8C0
		[Title("Debug Time")]
		public float debugTime { get; set; } // 0x000000018675D350-0x000000018675D360 0x000000018675D360-0x000000018675D370
		[Title("Debug Enemies")]
		public float debugEnemies { get; set; } // 0x00000001827FCBA0-0x00000001827FCBB0 0x000000018675D370-0x000000018675D380
		[Title("BGM")]
		public string bgm { get; set; } // 0x0000000182766860-0x0000000182766870 0x0000000184B1D430-0x0000000184B1D490
		[Title("Start Frame Count")]
		public int? startFrameCount { get; set; } // 0x0000000182766870-0x0000000182766880 0x0000000182A45AE0-0x0000000182A45AF0
		[Title("Zero Pad")]
		public int? zeroPad { get; set; } // 0x0000000182A45AF0-0x0000000182A45B00 0x0000000182A45B00-0x0000000182A45B10
		[Title("Suffix")]
		public string suffix { get; set; } // 0x00000001829475E0-0x00000001829475F0 0x0000000184BDAFE0-0x0000000184BDB040
		[Title("Frame Rate")]
		public int? frameRate { get; set; } // 0x00000001829475F0-0x0000000182947600 0x0000000182A45B20-0x0000000182A45B30
		[Title("Sine Speed")]
		public SineBonusData sineSpeed { get; set; } // 0x0000000182937BD0-0x0000000182937BE0 0x0000000182A45B30-0x0000000182A45B90
		[Title("Sine Cooldown")]
		public SineBonusData sineCooldown { get; set; } // 0x0000000182A45B90-0x0000000182A45BA0 0x0000000182A45BA0-0x0000000182A45C00
		[Title("Sine Area")]
		public SineBonusData sineArea { get; set; } // 0x0000000184F612E0-0x0000000184F612F0 0x0000000185D80170-0x0000000185D801D0
		[Title("Sine Duration")]
		public SineBonusData sineDuration { get; set; } // 0x0000000184F612F0-0x0000000184F61300 0x0000000185F85960-0x0000000185F859C0
		[Title("Sine Might")]
		public SineBonusData sineMight { get; set; } // 0x0000000184F54FC0-0x0000000184F54FD0 0x00000001857819E0-0x0000000185781A40
		[Title("No Hurt")]
		public bool noHurt { get; set; } // 0x000000018578E980-0x000000018578E990 0x000000018578E990-0x000000018578E9A0
		[Title("Ex Levels")]
		public int exLevels { get; set; } // 0x000000018208C640-0x000000018208C650 0x000000018208C650-0x000000018208C660
		[Title("Ex Weapons")]
		public List<string> exWeapons { get; set; } // 0x0000000184755AB0-0x0000000184755AC0 0x00000001862CA0A0-0x00000001862CA100
		[Title("Hidden Weapons")]
		public List<string> hiddenWeapons { get; set; } // 0x00000001827668E0-0x00000001827668F0 0x00000001827668F0-0x0000000182766950
		[Title("On Every Level Up")]
		public ModifierStats onEveryLevelUp { get; set; } // 0x00000001829176E0-0x00000001829176F0 0x0000000185F8DFD0-0x0000000185F8E030
		[Title("Body Offset")]
		public Vector2? bodyOffset { get; set; } // 0x000000018675D380-0x000000018675D3A0 0x000000018675D3A0-0x000000018675D3C0
		[Title("Name Index")]
		public int? nameIndex { get; set; } // 0x0000000186758B20-0x0000000186758B30 0x0000000186758B30-0x0000000186758B40
		[Title("Current Skin")]
		public SkinType currentSkin { get; set; } // 0x0000000182766980-0x0000000182766990 0x0000000182766990-0x00000001827669A0
		[Title("Racing Offsets")]
		public List<RacingOffsetData> racingOffsets { get; set; } // 0x00000001826DBA40-0x00000001826DBA50 0x00000001826DBA50-0x00000001826DBAB0
		[Title("Requires Relic")]
		public VampireSurvivors.Data.ItemType? requiresRelic { get; set; } // 0x0000000182766A50-0x0000000182766A60 0x000000018675D3C0-0x000000018675D3D0
	
		// Constructors
		public CharacterData() {} // 0x000000018675E540-0x000000018675E6C0
	
		// Methods
		public string GetFirstNameLocKey(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D3D0-0x000000018675D460
		public string GetSkinPrefix() => default; // 0x000000018675D460-0x000000018675D500
		public string GetSkinSuffix() => default; // 0x000000018675D500-0x000000018675D5A0
		public string GetCharPrefix(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D5A0-0x000000018675D630
		public string GetCharFirstName(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D630-0x000000018675D6C0
		public string GetCharSurname(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D6C0-0x000000018675D750
		public string GetTextWithFallback<T>(T t, string sheet, string term, string fallback) => default;
		public string GetFirstNameWithPrefix(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D750-0x000000018675D8B0
		public string GetSurnameWithSuffix(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675D8B0-0x000000018675D9A0
		public string GetFullName(VampireSurvivors.Data.CharacterType t, bool ignoreSkinPrefixSuffix = false /* Metadata: 0x0197A984 */, bool splitDualCharacterNames = true /* Metadata: 0x0197A985 */) => default; // 0x000000018675D9A0-0x000000018675DE00
		public string GetFullNameUntranslated() => default; // 0x000000018675DE00-0x000000018675DEB0
		public string GetSurNameLocKey(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675DEB0-0x000000018675DF40
		public string GetDescriptionLocKey(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675DF40-0x000000018675DFF0
		public string GetDescription(VampireSurvivors.Data.CharacterType t) => default; // 0x000000018675DFF0-0x000000018675E0F0
		public RacingOffsetData GetRacingOffsetData(CharacterVehicleType characterVehicleType) => default; // 0x000000018675E0F0-0x000000018675E270
		public Skin GetCurrentSkinData() => default; // 0x000000018675E270-0x000000018675E3D0
		public Skin GetSkinData(SkinType skinType) => default; // 0x000000018675E3D0-0x000000018675E540
	}
}
