/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class C1_Shapeshifter : CharacterController // TypeDefIndex: 17011
	{
		// Fields
		private bool _canDropBodyPart; // 0x408
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyPartTimer; // 0x410
		private ShapeShifterShapes currentForm; // 0x418
		private ShapeShifterShapes[] shapesBag; // 0x420
		private bool _hasSecondAnim; // 0x428
		private float _meatDelay; // 0x42C
		private int MaxHealthMaxBonus; // 0x430
		private int CurrentMaxHPBonus; // 0x434
	
		// Properties
		public Weapon FireNovaWeapon { get; set; } // 0x0000000187146EF0-0x0000000187146F00 0x0000000187146F00-0x0000000187146F60
		public Weapon IceNovaWeapon { get; set; } // 0x0000000187139AA0-0x0000000187139AB0 0x0000000187139AB0-0x0000000187139B10
		public Weapon FearNovaWeapon { get; set; } // 0x0000000187146F60-0x0000000187146F70 0x0000000187146F70-0x0000000187146FD0
	
		// Constructors
		public C1_Shapeshifter() {} // 0x0000000187149180-0x00000001871491A0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FC9 */) {} // 0x0000000187146FD0-0x0000000187147D00
		public float MeatInterval() => default; // 0x0000000187147D00-0x0000000187147D40
		public override void AfterFullInitialization() {} // 0x0000000187147D40-0x0000000187147D70
		public override void LevelUp() {} // 0x0000000187147D70-0x0000000187147EB0
		public override bool GetDamaged(float damageAmount) => default; // 0x0000000187147EB0-0x0000000187148C90
		[Command]
		public void TurnToNormal() {} // 0x0000000187148C90-0x0000000187148CF0
		[Command]
		public void TurnToSnow() {} // 0x0000000187148CF0-0x0000000187148D70
		[Command]
		public void TurnToLava() {} // 0x0000000187148D70-0x0000000187148DF0
		[Command]
		public void TurnToGhost(string anim) {} // 0x0000000187148DF0-0x0000000187148E50
		[Command]
		public void TurnToSus(string anim) {} // 0x0000000187148E50-0x0000000187148E90
		private string GetSusAnimation() => default; // 0x0000000187148E90-0x0000000187148F80
		private string GetGhostAnimation() => default; // 0x0000000187148F80-0x0000000187149010
		private void AddMaxHPBonus(int value) {} // 0x0000000187149010-0x0000000187149180
	}
}
