/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Spells
{
	[UsedImplicitly]
	public class SpellsManager : IInitializable, IDisposable // TypeDefIndex: 14550
	{
		// Fields
		private List<SpellModifier> _enabledSpells; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private SignalBus _signalBus; // 0x20
		[Inject]
		private DataManager _dataManager; // 0x28
	
		// Properties
		public static StageType? CachedStageType { get; set; } // 0x00000001871AE4D0-0x00000001871AE510 0x00000001871AE510-0x00000001871AE560
		public static VampireSurvivors.Data.CharacterType? CachedCharacterType { get; set; } // 0x00000001871AE560-0x00000001871AE5A0 0x00000001871AE5A0-0x00000001871AE5F0
		public static BgmType? CachedBgm { get; set; } // 0x00000001871AE5F0-0x00000001871AE630 0x00000001871AE630-0x00000001871AE680
		public static BgmModType? CachedBgmMod { get; set; } // 0x00000001871AE680-0x00000001871AE6C0 0x00000001871AE6C0-0x00000001871AE710
	
		// Constructors
		public SpellsManager() {} // 0x00000001871AF930-0x00000001871AF9F0
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void StartSpell(SecretType secretType) {} // 0x00000001871AE710-0x00000001871AF1B0
		public void ActivateSpells() {} // 0x00000001871AF1B0-0x00000001871AF3F0
		public void AddSpell(SpellModifier spellModifier) {} // 0x00000001871AF3F0-0x00000001871AF490
		public void ResetCachedValues() {} // 0x00000001871AF490-0x00000001871AF540
		public void RestoreCachedPlayerSettings() {} // 0x00000001871AF540-0x00000001871AF930
	}
}
