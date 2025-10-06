/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Algorithm;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Weapons
{
	[Serializable]
	public class WeaponData // TypeDefIndex: 18449
	{
		// Fields
		[CanBeNull]
		[Title("Custom Desc Value")]
		public string customDescValue; // 0x188
	
		// Properties
		[Title("Hidden")]
		public bool hidden { get; set; } // 0x0000000180B15AC0-0x0000000180B15AD0 0x000000018195A980-0x000000018195A990
		[Title("Always Hidden")]
		public bool alwaysHidden { get; set; } // 0x000000018195ABE0-0x000000018195ABF0 0x000000018195C940-0x000000018195C950
		[Title("Level")]
		public int level { get; set; } // 0x0000000180B15AD0-0x0000000180B15AE0 0x0000000181968000-0x0000000181968010
		[Title("Bullet Type")]
		public WeaponType bulletType { get; set; } // 0x00000001819457C0-0x00000001819457D0 0x000000018195FC50-0x000000018195FC60
		[Title("Name")]
		public string name { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Description")]
		public string description { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Tips")]
		public string tips { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[Title("Texture")]
		public string texture { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[Title("Frame Name")]
		public string frameName { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		[Title("Collection Frame")]
		public string collectionFrame { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		[Title("Evo Into")]
		public string evoInto { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		[Title("Evo Synergy")]
		public WeaponType[] evoSynergy { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		[Title("Is Evolution")]
		public bool isEvolution { get; set; } // 0x000000018289FD40-0x000000018289FD50 0x0000000184EC0B20-0x0000000184EC0B30
		[Title("Is Special Only")]
		public bool isSpecialOnly { get; set; } // 0x0000000184885DA0-0x0000000184885DB0 0x0000000184A11CF0-0x0000000184A11D00
		[Title("Evolves From")]
		public List<WeaponType> evolvesFrom { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		[Title("Requires")]
		public List<WeaponType> requires { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
		[Title("Requires Max")]
		public List<WeaponType> requiresMax { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		[Title("Evolution Line")]
		public List<WeaponType> evolutionLine { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x00000001819A0380-0x00000001819A03E0
		[Title("Is Unlocked")]
		public bool isUnlocked { get; set; } // 0x0000000182699300-0x0000000182699310 0x0000000182699310-0x0000000182699320
		[Title("Volume")]
		public float? volume { get; set; } // 0x0000000184BDAFA0-0x0000000184BDAFB0 0x0000000183B898F0-0x0000000183B89900
		[Title("Pool Limit")]
		public int? poolLimit { get; set; } // 0x0000000186758960-0x0000000186758970 0x0000000185C8B820-0x0000000185C8B830
		[Title("Rarity")]
		public int rarity { get; set; } // 0x000000018198E610-0x000000018198E620 0x000000018198E620-0x000000018198E630
		[Title("Interval")]
		public float interval { get; set; } // 0x00000001846DB9B0-0x00000001846DB9C0 0x0000000186758970-0x0000000186758980
		[Title("Duration")]
		public float? duration { get; set; } // 0x0000000186758980-0x0000000186758990 0x0000000186758990-0x00000001867589A0
		[Title("Repeat Interval")]
		public float repeatInterval { get; set; } // 0x000000018293ABD0-0x000000018293ABE0 0x00000001867589A0-0x00000001867589B0
		[Title("Power")]
		public float power { get; set; } // 0x0000000186256150-0x0000000186256160 0x0000000186256160-0x0000000186256170
		[Title("Secondary Power")]
		public float secondaryPower { get; set; } // 0x0000000185DD4A60-0x0000000185DD4A70 0x0000000186256170-0x0000000186256180
		[Title("Knockback")]
		public float? knockback { get; set; } // 0x00000001819A01A0-0x00000001819A01B0 0x0000000186544750-0x0000000186544760
		[Title("Hit Box Delay")]
		public float? hitBoxDelay { get; set; } // 0x00000001819A0460-0x00000001819A0470 0x0000000182A45A40-0x0000000182A45A50
		[Title("Area")]
		public float area { get; set; } // 0x0000000183725DE0-0x0000000183725DF0 0x0000000183725DF0-0x0000000183725E00
		[Title("Speed")]
		public float speed { get; set; } // 0x0000000183725E00-0x0000000183725E10 0x0000000183725E10-0x0000000183725E20
		[Title("Amount")]
		public int amount { get; set; } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		[Title("Crit Chance")]
		public float critChance { get; set; } // 0x0000000182907E40-0x0000000182907E50 0x0000000185DD4BF0-0x0000000185DD4C00
		[Title("Hits Walls")]
		public bool hitsWalls { get; set; } // 0x0000000182816BD0-0x0000000182816BE0 0x0000000182816BE0-0x0000000182816BF0
		[Title("Crit Mul")]
		public float critMul { get; set; } // 0x0000000182907680-0x0000000182907690 0x00000001867589B0-0x00000001867589C0
		[Title("Seen")]
		public bool seen { get; set; } // 0x00000001857FBC70-0x00000001857FBC80 0x0000000185DD4CE0-0x0000000185DD4CF0
		[Title("Add Evolved Weapon")]
		public WeaponType? addEvolvedWeapon { get; set; } // 0x0000000184BBA470-0x0000000184BBA480 0x0000000184BBA480-0x0000000184BBA490
		[Title("Add Normal Weapon")]
		public WeaponType? addNormalWeapon { get; set; } // 0x00000001867589C0-0x00000001867589D0 0x00000001867589D0-0x00000001867589E0
		[Title("Exclude Weapon")]
		public WeaponType? excludeWeapon { get; set; } // 0x00000001867589E0-0x00000001867589F0 0x00000001867589F0-0x0000000186758A00
		[Title("Charges")]
		public int charges { get; set; } // 0x0000000184E1BEE0-0x0000000184E1BEF0 0x0000000184E1BEF0-0x0000000184E1BF00
		[Title("Interval Depends On Duration")]
		public bool intervalDependsOnDuration { get; set; } // 0x00000001829080B0-0x00000001829080C0 0x00000001864B9290-0x00000001864B92A0
		[Title("Is Power Up")]
		public bool isPowerUp { get; set; } // 0x00000001829080E0-0x00000001829080F0 0x0000000186758A00-0x0000000186758A10
		[Title("Penetrating")]
		public int penetrating { get; set; } // 0x0000000182808600-0x0000000182808610 0x0000000186753120-0x0000000186753130
		[Title("Hit VFX")]
		public HitVfxType hitVFX { get; set; } // 0x0000000181945D40-0x0000000181945D50 0x0000000185DD4E90-0x0000000185DD4EA0
		[Title("Forced Synergy Weapons")]
		public List<WeaponType> forcedSynergyWeapons { get; set; } // 0x0000000182A45AF0-0x0000000182A45B00 0x0000000184BB6350-0x0000000184BB63B0
		[Title("Skip Removing Base Weapon")]
		public bool skipRemovingBaseWeapon { get; set; } // 0x00000001865DBE60-0x00000001865DBE70 0x00000001867531A0-0x00000001867531B0
		[Title("Has Unique Requirements")]
		public bool hasUniqueRequirements { get; set; } // 0x00000001867531B0-0x00000001867531C0 0x00000001867531C0-0x00000001867531D0
		[Title("Cooldown")]
		public float cooldown { get; set; } // 0x0000000186758A10-0x0000000186758A20 0x0000000186758A20-0x0000000186758A30
		[Title("Max HP")]
		public float maxHp { get; set; } // 0x0000000185D80110-0x0000000185D80120 0x0000000186758A30-0x0000000186758A40
		[Title("Move Speed")]
		public float moveSpeed { get; set; } // 0x0000000185D80120-0x0000000185D80130 0x0000000185D80130-0x0000000185D80140
		[Title("Growth")]
		public float growth { get; set; } // 0x0000000185D80140-0x0000000185D80150 0x0000000186758A40-0x0000000186758A50
		[Title("Magnet")]
		public float magnet { get; set; } // 0x0000000186758A50-0x0000000186758A60 0x0000000186758A60-0x0000000186758A70
		[Title("Luck")]
		public float luck { get; set; } // 0x0000000186758A70-0x0000000186758A80 0x0000000186758A80-0x0000000186758A90
		[Title("Armor")]
		public float armor { get; set; } // 0x0000000186560970-0x0000000186560980 0x0000000186560980-0x0000000186560990
		[Title("Greed")]
		public float greed { get; set; } // 0x0000000186758A90-0x0000000186758AA0 0x0000000186758AA0-0x0000000186758AB0
		[Title("Regen")]
		public float regen { get; set; } // 0x0000000186753300-0x0000000186753310 0x0000000186753310-0x0000000186753320
		[Title("Revivals")]
		public float revivals { get; set; } // 0x0000000184F54B50-0x0000000184F54B60 0x000000018628F1E0-0x000000018628F1F0
		[Title("Rerolls")]
		public float rerolls { get; set; } // 0x0000000184F54B90-0x0000000184F54BA0 0x0000000186758AB0-0x0000000186758AC0
		[Title("Skips")]
		public float skips { get; set; } // 0x0000000185F859C0-0x0000000185F859D0 0x0000000185F859D0-0x0000000185F859E0
		[Title("Chance")]
		public float chance { get; set; } // 0x0000000186560A30-0x0000000186560A40 0x0000000186560A40-0x0000000186560A50
		[Title("BGM")]
		public string bgm { get; set; } // 0x0000000184F54BD0-0x0000000184F54BE0 0x00000001864D7EE0-0x00000001864D7F40
		[Title("Shield Invul Time")]
		public float? shieldInvulTime { get; set; } // 0x0000000184755AB0-0x0000000184755AC0 0x0000000186758AC0-0x0000000186758AD0
		[Title("Curse")]
		public float curse { get; set; } // 0x00000001829176A0-0x00000001829176B0 0x0000000186758AD0-0x0000000186758AE0
		[Title("Desc")]
		public string desc { get; set; } // 0x00000001829176E0-0x00000001829176F0 0x0000000185F8DFD0-0x0000000185F8E030
		[Title("Charm")]
		public float charm { get; set; } // 0x000000018291ED60-0x000000018291ED70 0x0000000186758AE0-0x0000000186758AF0
		[Title("Fever")]
		public float fever { get; set; } // 0x0000000184F6B670-0x0000000184F6B680 0x0000000186758AF0-0x0000000186758B00
		[Title("Invul Time Bonus")]
		public float invulTimeBonus { get; set; } // 0x0000000186758B00-0x0000000186758B10 0x0000000186758B10-0x0000000186758B20
		[Title("Custom Desc")]
		public float? customDesc { get; set; } // 0x0000000186758B20-0x0000000186758B30 0x0000000186758B30-0x0000000186758B40
		[Title("Unexclude Self")]
		public bool unexcludeSelf { get; set; } // 0x0000000184F619B0-0x0000000184F619C0 0x0000000186522600-0x0000000186522610
		[Title("Drop Rate Affected By Luck")]
		public bool dropRateAffectedByLuck { get; set; } // 0x0000000184F619E0-0x0000000184F619F0 0x00000001865213A0-0x00000001865213B0
		[Title("Sealable")]
		public bool sealable { get; set; } // 0x0000000184F61A10-0x0000000184F61A20 0x0000000186758B40-0x0000000186758B50
		[Title("Price")]
		public float? price { get; set; } // 0x0000000186758B50-0x0000000186758B60 0x0000000186758B60-0x0000000186758B70
		[Title("Applies Only To Owner")]
		public bool appliesOnlyToOwner { get; set; } // 0x0000000184F61B00-0x0000000184F61B10 0x0000000186758B70-0x0000000186758B80
		[Title("Allow Duplicates")]
		public bool allowDuplicates { get; set; } // 0x0000000186758B80-0x0000000186758B90 0x0000000186758B90-0x0000000186758BA0
		[Title("Despawn On Unavailable")]
		public bool despawnOnUnavailable { get; set; } // 0x0000000186758BA0-0x0000000186758BB0 0x0000000186758BB0-0x0000000186758BC0
		[Title("Content Group")]
		public ContentGroupType contentGroup { get; set; } // 0x0000000186758BC0-0x0000000186758BD0 0x0000000186758BD0-0x0000000186758BE0
		[Title("Follower Type")]
		public VampireSurvivors.Data.CharacterType followerType { get; set; } // 0x0000000186758BE0-0x0000000186758BF0 0x0000000186758BF0-0x0000000186758C00
		[Title("Follower AI")]
		public AIType followerAI { get; set; } // 0x0000000186758C00-0x0000000186758C10 0x0000000186758C10-0x0000000186758C20
	
		// Constructors
		public WeaponData() {} // 0x000000018675A590-0x000000018675A670
	
		// Methods
		public string GetLocalizedNameTerm(WeaponType wType) => default; // 0x0000000186758C20-0x0000000186758C80
		public string GetLocalizedDescriptionTerm(WeaponType wType) => default; // 0x0000000186758C80-0x0000000186758CE0
		public string GetLocalizedTipsTerm(WeaponType wType) => default; // 0x0000000186758CE0-0x0000000186758D40
		public string GetLocalizedDescriptionForLevel(WeaponData levelData, WeaponType weaponType) => default; // 0x0000000186758D40-0x0000000186759B20
		private string GetLevelUpAllPrefixTranslation() => default; // 0x0000000186759B20-0x0000000186759C00
		private string GetTranslation(string term) => default; // 0x0000000186759C00-0x0000000186759CA0
		public string GetCustomDescription(WeaponType t, float value) => default; // 0x0000000186759CA0-0x0000000186759E70
		public string GetDescription(string term, float value) => default; // 0x0000000186759E70-0x000000018675A060
		public string GetDescriptionPercent(string term, float value) => default; // 0x000000018675A060-0x000000018675A270
		private string GetDescriptionWithDecimalFormatting(string term, float value, int decimalPlaces) => default; // 0x000000018675A270-0x000000018675A500
		private string GetPrefix(WeaponType wType) => default; // 0x000000018675A500-0x000000018675A590
	}
}
