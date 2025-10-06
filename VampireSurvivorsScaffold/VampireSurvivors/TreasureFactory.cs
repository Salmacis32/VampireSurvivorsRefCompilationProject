/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TreasureFactory : IInitializable, IDisposable // TypeDefIndex: 13923
	{
		// Fields
		[Inject]
		private LevelUpFactory _levelUpFactory; // 0x10
		[Inject]
		private DataManager _dataManager; // 0x18
		[Inject]
		private PlayerOptions _playerOptions; // 0x20
		private List<WeaponType> _accumulatedWeaponPrizes; // 0x28
		private List<WeaponType> _accumulatedWorldSpacePrizes; // 0x30
		private int _accumulatedCoinPrize; // 0x38
		public List<PrizeType> currentTreasureTypes; // 0x40
		private float _coinsAward; // 0x48
		private List<TreasurePrizeTypePair> _prizes; // 0x50
	
		// Constructors
		public TreasureFactory() {} // 0x00000001865C60E0-0x00000001865C6410
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public List<TreasurePrizeTypePair> GenerateNewPrizes(Treasure data) => default; // 0x00000001865C3EC0-0x00000001865C40F0
		private TreasurePrizeTypePair MakePrizePairFromAvailablePowerUps(PrizeType prizeType, WeaponType fixedPrize, CharacterController character, bool isSpecial = false /* Metadata: 0x01976B3F */) => default; // 0x00000001865C40F0-0x00000001865C5730
		private void MakePrizes(Treasure treasure) {} // 0x00000001865C5730-0x00000001865C60B0
		public int GetCoins() => default; // 0x0000000181E091A0-0x0000000181E091B0
		public List<WeaponType> GetAccumulatedWeaponPrizes() => default; // 0x0000000180B15540-0x0000000180B15550
		private void AddFiller(TreasurePrizeTypePair pair) {} // 0x00000001865C60B0-0x00000001865C60E0
	}
}
