/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Spells;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Objects.Spells
{
	public class Spell_Halloween : SpellModifier // TypeDefIndex: 18569
	{
		// Fields
		private SignalBus _signalBus; // 0x10
		private SpellsManager _spellsManager; // 0x18
		private DataManager _data; // 0x20
		private PlayerOptions _playerOptions; // 0x28
		private StageType _saveStage; // 0x30
		private VampireSurvivors.Data.CharacterType _saveCharacter; // 0x34
		private BgmModType _saveBGMMod; // 0x38
		private BgmType _saveBGM; // 0x3C
	
		// Constructors
		public Spell_Halloween() {} // Dummy constructor
		public Spell_Halloween(SignalBus signalBus, SpellsManager spellsManager, DataManager data, PlayerOptions player) {} // 0x00000001827C42C0-0x00000001827C4410
	
		// Methods
		public void Start() {} // 0x00000001867E4980-0x00000001867E5110
		public void Activate() {} // 0x00000001867E5110-0x00000001867E5270
	}
}
