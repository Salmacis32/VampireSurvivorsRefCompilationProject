/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterSkillCard_Base // TypeDefIndex: 16858
	{
		// Fields
		public CharacterController LinkedCharacter; // 0x10
		public int AccumulatedLevels; // 0x18
		public List<Dictionary<int, ModifierStats>> ModifierStatsMaps; // 0x20
		public List<CharacterSkillCard_Base> SubCards; // 0x28
		public ModifierStats OnEveryLevelUp; // 0x30
		public int Rarity; // 0x38
		public int AvailableSlots; // 0x3C
		public ModifierStats InitialBonus; // 0x40
		public ArcanaType Type; // 0x48
		public SkillCardEdition Edition; // 0x4C
		public float InitialRunEnemies; // 0x50
		public float InitialRunCoins; // 0x54
		public float InitialRunRunBossesCount; // 0x58
		private int currentBonusIndex; // 0x5C
		private int currentExtraStacks; // 0x60
		private int currentBonusIndex_Gold; // 0x64
		private int currentExtraStacks_Gold; // 0x68
	
		// Properties
		public virtual ArcanaType GalaType { get => default; } // 0x0000000181EE0060-0x0000000181EE0070 
		public virtual List<ArcanaType> FoilTypes { get => default; } // 0x00000001870DCF90-0x00000001870DCFF0 
		protected virtual int[] bonusTresholds { get => default; } // 0x00000001870DDF30-0x00000001870DDFA0 
		protected virtual int[] bonusTresholds_Gold { get => default; } // 0x00000001870DE160-0x00000001870DE1D0 
	
		// Constructors
		public CharacterSkillCard_Base() {} // Dummy constructor
		public CharacterSkillCard_Base(ArcanaType type) {} // 0x00000001870DCFF0-0x00000001870DD200
	
		// Methods
		public void SetEdition(SkillCardEdition edition, bool activateEdition = true /* Metadata: 0x01977EA0 */) {} // 0x00000001870DD200-0x00000001870DD270
		public virtual void SetLinkedCharacter(CharacterController character) {} // 0x00000001870DD270-0x00000001870DD390
		public virtual void InitialActivate() {} // 0x00000001870DD390-0x00000001870DD730
		public virtual void OnOwnerLevelUp() {} // 0x00000001870DD730-0x00000001870DDB30
		public virtual void Update() {} // 0x00000001870DDB30-0x00000001870DDBF0
		public virtual void OnOwnerRevived(float percentage = 1f /* Metadata: 0x01977EA1 */, bool instantRevival = false /* Metadata: 0x01977EA5 */) {} // 0x00000001870DDBF0-0x00000001870DDCD0
		public virtual void OnOwnerGetDamaged(float damageAmount) {} // 0x00000001870DDCD0-0x00000001870DDDA0
		public virtual void OnOwnerCriticalHPTreshold(float rawValue) {} // 0x00000001870DDDA0-0x00000001870DDE70
		public virtual void OnOwnerLevelUpSkipped() {} // 0x00000001870DDE70-0x00000001870DDF30
		protected virtual void OnEnemiesCountReached() {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnGoldCountReached() {} // 0x0000000180B15170-0x0000000180B15180
		protected void Update_CountEnemies() {} // 0x00000001870DDFA0-0x00000001870DE160
		protected void Update_CountGold() {} // 0x00000001870DE1D0-0x00000001870DE380
		protected void AddSubCard(ArcanaType type) {} // 0x00000001870DE380-0x00000001870DE400
		protected void AddSubCard(CharacterSkillCard_Base subCard) {} // 0x00000001870DE400-0x00000001870DE480
		public virtual void SetRarity(int rarity) {} // 0x0000000181E091B0-0x0000000181E091C0
		private void ActivateSpecialEdition() {} // 0x00000001870DE480-0x00000001870DE4E0
		private void MultiplyAllStats(float multiplier) {} // 0x00000001870DE4E0-0x00000001870DE5D0
		protected virtual void OnActivate_Foil() {} // 0x00000001870DE5D0-0x00000001870DE6D0
		protected virtual void OnActivate_Gala() {} // 0x00000001870DE6D0-0x00000001870DE720
		protected float GetBonusMultiplier() => default; // 0x00000001870DE720-0x00000001870DE750
		protected void AddRandomProgressiveBonus() {} // 0x00000001870DE750-0x00000001870DE950
		protected void AddRandomInitialBonus() {} // 0x00000001870DE950-0x00000001870DEA50
		protected void AddRandomPerLevelBonus() {} // 0x00000001870DEA50-0x00000001870DEBE0
	}
}
