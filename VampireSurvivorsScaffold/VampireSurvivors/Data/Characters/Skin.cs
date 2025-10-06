/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Characters
{
	[Serializable]
	public class Skin // TypeDefIndex: 18473
	{
		// Fields
		[FormerlySerializedAs("id")]
		[Title("Skin Type")]
		public SkinType skinType; // 0x18
	
		// Properties
		[Required]
		[Title("Name")]
		public string name { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[Title("Prefix")]
		public string prefix { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Suffix")]
		public string suffix { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Description")]
		public string description { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		[Required]
		[Title("Texture Name")]
		public string textureName { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[Required]
		[Title("Sprite Name")]
		public string spriteName { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		[Title("Char Sel Texture")]
		public string charSelTexture { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
		[Title("Char Sel Frame")]
		public string charSelFrame { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		[Required]
		[Title("Walking Frames")]
		public int walkingFrames { get; set; } // 0x00000001819A01E0-0x00000001819A01F0 0x0000000181EDFC80-0x0000000181EDFC90
		[Title("Walk Frame Rate")]
		public int? walkFrameRate { get; set; } // 0x00000001847E3880-0x00000001847E3890 0x00000001847E3890-0x00000001847E38A0
		[Title("Unlocked")]
		public bool unlocked { get; set; } // 0x0000000182926A40-0x0000000182926A50 0x00000001867530A0-0x00000001867530B0
		[Title("Hidden")]
		public bool hidden { get; set; } // 0x00000001852676A0-0x00000001852676B0 0x00000001867530B0-0x00000001867530C0
		[Title("Always Hidden")]
		public bool alwaysHidden { get; set; } // 0x00000001852676D0-0x00000001852676E0 0x0000000186437760-0x0000000186437770
		[Title("Secret")]
		public bool secret { get; set; } // 0x00000001852676F0-0x0000000185267700 0x0000000186437770-0x0000000186437780
		[Title("Head Offsets")]
		public List<Vector2> headOffsets { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		[Title("Starting Weapon")]
		public WeaponType? startingWeapon { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x0000000183BF5D20-0x0000000183BF5D30
		[Title("Sprite Anims")]
		public SpriteAnims spriteAnims { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public Vector2? bodyOffset { get; set; } // 0x0000000184E2F000-0x0000000184E2F020 0x0000000184E2F020-0x0000000184E2F040
		[Title("Price")]
		public float price { get; set; } // 0x000000018289FF70-0x000000018289FF80 0x0000000183B88DF0-0x0000000183B88E00
		[Title("Cooldown")]
		public float cooldown { get; set; } // 0x0000000184E163F0-0x0000000184E16400 0x000000018675D2C0-0x000000018675D2D0
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
		[Title("Ex Weapons")]
		public List<string> exWeapons { get; set; } // 0x0000000182766DD0-0x0000000182766DE0 0x0000000184755900-0x0000000184755960
		[Title("Ex Accessories")]
		public List<string> exAccessories { get; set; } // 0x00000001819716C0-0x00000001819716D0 0x0000000180B3E860-0x0000000180B3E8C0
		[Title("Hidden Weapons")]
		public List<string> hiddenWeapons { get; set; } // 0x0000000181945E90-0x0000000181945EA0 0x0000000180B3E800-0x0000000180B3E860
		public ModifierStats onEveryLevelUp { get; set; } // 0x0000000182766860-0x0000000182766870 0x0000000184B1D430-0x0000000184B1D490
	
		// Constructors
		public Skin() {} // 0x000000018675E740-0x000000018675E8F0
	}
}
