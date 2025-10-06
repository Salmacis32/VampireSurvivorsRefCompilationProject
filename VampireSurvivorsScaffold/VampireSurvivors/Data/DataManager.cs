/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Data;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Data.Props;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Algorithm;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[UsedImplicitly]
	public class DataManager : IInitializable, IDisposable // TypeDefIndex: 18398
	{
		// Fields
		[Inject]
		private DataManagerSettings _settings; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		private Dictionary<CharacterType, List<CharacterData>> _characterData; // 0x20
		private Dictionary<PowerUpType, List<PowerUpData>> _powerUpData; // 0x28
		private Dictionary<StageType, List<StageData>> _stageData; // 0x30
		private Dictionary<WeaponType, List<WeaponData>> _weaponData; // 0x38
		private Dictionary<EnemyType, List<EnemyData>> _enemyData; // 0x40
		private bool _characterDataChangedForOnline; // 0x48
		private bool _powerUpDataChangedForOnline; // 0x49
		private bool _stageDataChangedForOnline; // 0x4A
		private bool _weaponDataChangedForOnline; // 0x4B
		private bool _enemyDataChangedForOnline; // 0x4C
		private Dictionary<DlcType, Dictionary<CharacterType, List<CharacterData>>> _dlcCharacterData; // 0x50
		private Dictionary<DlcType, Dictionary<PowerUpType, List<PowerUpData>>> _dlcPowerUpData; // 0x58
		private Dictionary<DlcType, Dictionary<StageType, List<StageData>>> _dlcStageData; // 0x60
		private Dictionary<DlcType, Dictionary<WeaponType, List<WeaponData>>> _dlcWeaponData; // 0x68
		private Dictionary<DlcType, Dictionary<EnemyType, List<EnemyData>>> _dlcEnemyData; // 0x70
		private Dictionary<DlcType, Dictionary<BgmType, MusicData>> _dlcMusicData; // 0x78
		private Dictionary<DlcType, HashSet<string>> _dlcSfxData; // 0x80
		private JsonMergeSettings _mergeSettings; // 0x88
		private JObject _allWeaponDataJson; // 0x90
		private JObject _allCharactersJson; // 0x98
		private JObject _allEnemiesJson; // 0xA0
		private JObject _allItemsJson; // 0xA8
		private JObject _allPowerUpsJson; // 0xB0
		private JObject _allPropsJson; // 0xB8
		private JObject _allStagesJson; // 0xC0
		private JObject _allArcanasJson; // 0xC8
		private JObject _allHitVfxDataJson; // 0xD0
		private JObject _allMusicDataJson; // 0xD8
		private JObject _allLimitBreakDataJson; // 0xE0
		private JObject _allAchievementsJson; // 0xE8
		private JObject _allSecretsJson; // 0xF0
		private JObject _allAdventuresJson; // 0xF8
		private JObject _allStageSetJson; // 0x100
		private JObject _allAdventureStagesJson; // 0x108
		private JObject _allAdventureMerchantsJson; // 0x110
		private JObject _allAlbumData; // 0x118
		private JObject _allCustomMerchantsJson; // 0x120
		private JObject _allCPUJson; // 0x128
		private Dictionary<CharacterType, List<CharacterData>> _adventureCharacterData; // 0x130
		private Dictionary<StageType, List<StageData>> _adventureStageData; // 0x138
		private Dictionary<EnemyType, List<EnemyData>> _adventureBestiaryData; // 0x140
		private Dictionary<CharacterType, CustomMerchantData> _adventureMerchantsData; // 0x148
		private static readonly ProfilerMarker MarkerReloadAllData; // 0x00
		private static readonly ProfilerMarker MarkerLoadDataFromJson; // 0x08
		private static readonly ProfilerMarker MarkerBuildConvertedData; // 0x10
		private static readonly ProfilerMarker MarkerLoadBaseJObjects; // 0x18
		public const string JsonPartFileNameAchievement = "achievementData"; // Metadata: 0x019789B6
		public const string JsonPartFileNameArcana = "arcanaData"; // Metadata: 0x019789C6
		public const string JsonPartFileNameCharacter = "characterData"; // Metadata: 0x019789D1
		public const string JsonPartFileNameEnemy = "enemyData"; // Metadata: 0x019789DF
		public const string JsonPartFileNameHitVfx = "hitVfxData"; // Metadata: 0x019789E9
		public const string JsonPartFileNameItem = "itemData"; // Metadata: 0x019789F4
		public const string JsonPartFileNameLimitBreak = "limitBreakData"; // Metadata: 0x019789FD
		public const string JsonPartFileNameMusic = "musicData"; // Metadata: 0x01978A0C
		public const string JsonPartFileNamePowerUp = "powerUpData"; // Metadata: 0x01978A16
		public const string JsonPartFileNameProps = "propsData"; // Metadata: 0x01978A22
		public const string JsonPartFileNameSecrets = "secretData"; // Metadata: 0x01978A2C
		public const string JsonPartFileNameStage = "stageData"; // Metadata: 0x01978A37
		public const string JsonPartFileNameWeapon = "weaponData"; // Metadata: 0x01978A41
		public const string JsonPartFileNameAlbum = "albumData"; // Metadata: 0x01978A4C
		public const string JsonPartFileNameAdventure = "adventureData"; // Metadata: 0x01978A56
		public const string JsonPartFileNameAdventuresStageSet = "adventuresStageSetData"; // Metadata: 0x01978A64
		public const string JsonPartFileNameAdventuresMerchants = "adventuresMerchantsData"; // Metadata: 0x01978A7B
	
		// Properties
		public DataManagerSettings DefaultData { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
		public Dictionary<WeaponType, JArray> AllWeaponData { get; private set; } // 0x0000000184F54BD0-0x0000000184F54BE0 0x00000001864D7EE0-0x00000001864D7F40
		public Dictionary<CharacterType, JArray> AllCharacters { get; private set; } // 0x0000000184755AB0-0x0000000184755AC0 0x00000001862CA0A0-0x00000001862CA100
		public Dictionary<EnemyType, JArray> AllEnemies { get; private set; } // 0x00000001827668E0-0x00000001827668F0 0x00000001827668F0-0x0000000182766950
		public Dictionary<ItemType, ItemData> AllItems { get; private set; } // 0x00000001829176E0-0x00000001829176F0 0x0000000185F8DFD0-0x0000000185F8E030
		public Dictionary<PowerUpType, JArray> AllPowerUps { get; private set; } // 0x0000000182917880-0x0000000182917890 0x0000000185C36330-0x0000000185C36390
		public Dictionary<PropType, PropData> AllProps { get; private set; } // 0x0000000182917A20-0x0000000182917A30 0x0000000185637EC0-0x0000000185637F20
		public Dictionary<StageType, JArray> AllStages { get; private set; } // 0x00000001826DB9D0-0x00000001826DB9E0 0x00000001826DB9E0-0x00000001826DBA40
		public Dictionary<ArcanaType, ArcanaData> AllArcanas { get; private set; } // 0x00000001826DBA40-0x00000001826DBA50 0x00000001826DBA50-0x00000001826DBAB0
		public Dictionary<HitVfxType, HitVfxData> AllHitVfxData { get; private set; } // 0x0000000182766A50-0x0000000182766A60 0x0000000185132550-0x00000001851325B0
		public Dictionary<BgmType, MusicData> AllMusicData { get; private set; } // 0x0000000186747020-0x0000000186747030 0x0000000186747030-0x0000000186747090
		public Dictionary<WeaponType, JArray> AllLimitBreakData { get; private set; } // 0x0000000181971880-0x0000000181971890 0x0000000185E2C0B0-0x0000000185E2C110
		public Dictionary<AchievementType, AchievementData> AllAchievements { get; private set; } // 0x0000000185FA2680-0x0000000185FA2690 0x0000000186747090-0x00000001867470F0
		public Dictionary<SecretType, SecretData> AllSecrets { get; private set; } // 0x0000000185FA26F0-0x0000000185FA2700 0x00000001867470F0-0x0000000186747150
		public Dictionary<AdventureType, AdventureData> AllAdventures { get; private set; } // 0x0000000182766A60-0x0000000182766A70 0x0000000182766A70-0x0000000182766AD0
		public Dictionary<AIType, AIData> AllCPU { get; private set; } // 0x0000000185D99B30-0x0000000185D99B40 0x0000000185578FC0-0x0000000185579020
		public Dictionary<StageSetType, JObject> AllStageSetData { get; private set; } // 0x0000000185D98480-0x0000000185D98490 0x0000000186747150-0x00000001867471B0
		public Dictionary<CharacterType, CustomMerchantData> AllAdventureMerchantsData { get; private set; } // 0x0000000182766C90-0x0000000182766CA0 0x0000000182766CA0-0x0000000182766D00
		public Dictionary<CharacterType, CustomMerchantData> AllCustomMerchantsData { get; private set; } // 0x0000000182766D00-0x0000000182766D10 0x0000000182766D10-0x0000000182766D70
		public Dictionary<AlbumType, AlbumData> AllAlbumData { get; private set; } // 0x0000000185D98490-0x0000000185D984A0 0x00000001867471B0-0x0000000186747210
		public HashSet<AchievementType> AllLoadedAchievements { get; private set; } // 0x0000000185D984A0-0x0000000185D984B0 0x0000000186747210-0x0000000186747270
		public Dictionary<DlcType, List<AchievementType>> AllDlcAchievements { get; private set; } // 0x0000000186747270-0x0000000186747280 0x0000000186747280-0x00000001867472E0
		public Dictionary<DlcType, Dictionary<CharacterType, List<CharacterData>>> AllDlcCharacterData { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public Dictionary<DlcType, Dictionary<PowerUpType, List<PowerUpData>>> AllDlcPowerUpData { get => default; } // 0x0000000180B15730-0x0000000180B15740 
		public Dictionary<DlcType, Dictionary<StageType, List<StageData>>> AllDlcStageData { get => default; } // 0x0000000180B15740-0x0000000180B15750 
		public Dictionary<DlcType, Dictionary<WeaponType, List<WeaponData>>> AllDlcWeaponData { get => default; } // 0x00000001819A0210-0x00000001819A0220 
		public Dictionary<DlcType, Dictionary<EnemyType, List<EnemyData>>> AllDlcEnemyData { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public Dictionary<DlcType, Dictionary<BgmType, MusicData>> AllDlcMusicData { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public Dictionary<DlcType, HashSet<string>> AllDlcSfxData { get => default; } // 0x00000001819A0370-0x00000001819A0380 
		public Dictionary<CharacterType, List<CharacterData>> AdventureCharacterData { get => default; } // 0x0000000182A45B90-0x0000000182A45BA0 
		public Dictionary<StageType, List<StageData>> AdventureStageData { get => default; } // 0x0000000184F612E0-0x0000000184F612F0 
		public Dictionary<EnemyType, List<EnemyData>> AdventureBestiaryData { get => default; } // 0x0000000184F612F0-0x0000000184F61300 
		public static List<string> AllJsonPartFileNames { get => default; } // 0x0000000186750FD0-0x0000000186751730 
	
		// Constructors
		public DataManager() {} // 0x0000000186751730-0x0000000186751AD0
		static DataManager() {} // 0x0000000186751AD0-0x0000000186751C00
	
		// Methods
		public void Initialize() {} // 0x00000001867472E0-0x0000000186747320
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void ReloadAllData() {} // 0x0000000186747320-0x0000000186747430
		public Dictionary<CharacterType, List<CharacterData>> GetConvertedDlcCharacterData(DlcType dlcType) => default; // 0x0000000186747430-0x00000001867474E0
		public Dictionary<StageType, List<StageData>> GetConvertedDlcStageData(DlcType dlcType) => default; // 0x00000001867474E0-0x0000000186747590
		public Dictionary<WeaponType, List<WeaponData>> GetConvertedDlcWeaponData(DlcType dlcType) => default; // 0x0000000186747590-0x0000000186747640
		public Dictionary<EnemyType, List<EnemyData>> GetConvertedDlcEnemyData(DlcType dlcType) => default; // 0x0000000186747640-0x00000001867476F0
		public Dictionary<PowerUpType, List<PowerUpData>> GetConvertedDlcPowerUpData(DlcType dlcType) => default; // 0x00000001867476F0-0x00000001867477A0
		public Dictionary<BgmType, MusicData> GetConvertedDlcMusicData(DlcType dlcType) => default; // 0x00000001867477A0-0x0000000186747850
		public Dictionary<CharacterType, List<CharacterData>> GetConvertedCharacterData() => default; // 0x0000000186747850-0x0000000186747CA0
		public Dictionary<EnemyType, List<EnemyData>> GetConvertedEnemyData() => default; // 0x0000000186747CA0-0x00000001867480F0
		public Dictionary<PowerUpType, List<PowerUpData>> GetConvertedPowerUpData() => default; // 0x00000001867480F0-0x0000000186748550
		public Dictionary<StageType, List<StageData>> GetConvertedStages() => default; // 0x0000000186748550-0x00000001867489A0
		public Dictionary<StageType, List<StageData>> GetConvertedAdventureStages() => default; // 0x00000001867489A0-0x0000000186748A60
		public Dictionary<WeaponType, List<WeaponData>> GetConvertedWeapons() => default; // 0x0000000186748A60-0x0000000186748EB0
		public PropData GetPropData(PropType propType) => default; // 0x0000000186748EB0-0x0000000186748F60
		public void AddDefaultUnlocksToSaveData() {} // 0x0000000186748F60-0x00000001867492D0
		public void UpdateAllCharacterHiddenPropertiesForAdventures(AdventureData adventureData) {} // 0x00000001867492D0-0x0000000186749660
		public void GenerateAdventureSpecificData(AdventureData adventureData) {} // 0x0000000186749660-0x000000018674A0A0
		public void ExitAdventure() {} // 0x000000018674A0A0-0x000000018674A170
		private bool IsOnline() => default; // 0x000000018674A170-0x000000018674A340
		private void LoadBaseJObjects() {} // 0x000000018674A340-0x000000018674B000
		private void LoadDataFromJson() {} // 0x000000018674B000-0x000000018674C1D0
		public void MergeInJsonData(DataManagerSettings settings, DlcType dlcType) {} // 0x000000018674C1D0-0x000000018674C380
		private void InternalMergeInJsonData(DataManagerSettings settings, DlcType dlcType, bool reload = true /* Metadata: 0x019789B5 */) {} // 0x000000018674C380-0x000000018674C540
		private void CacheBaseGameLoadedAchievements() {} // 0x000000018674C540-0x000000018674C6F0
		public void MergeInDlcAchievements(DlcType dlcType, TextAsset achievements) {} // 0x000000018674C6F0-0x000000018674CB70
		public void MergeInSFXTypes(DlcType dlc, Transform instantiatedSoundGroup) {} // 0x000000018674CB70-0x000000018674CE90
		private void LoadAndMergeIn(JObject original, TextAsset newAsset) {} // 0x000000018674CE90-0x000000018674CFC0
		private void BuildConvertedDlcData(DataManagerSettings settings, DlcType dlcType) {} // 0x000000018674CFC0-0x000000018674DC20
		public void ClearConvertedDlcData() {} // 0x000000018674DC20-0x000000018674DE70
		private void ClearConvertedData() {} // 0x000000018674DE70-0x000000018674E010
		private void BuildConvertedData() {} // 0x000000018674E010-0x000000018674E130
		private static Dictionary<EnemyType, List<EnemyData>> ConvertEnemyDataJsonToObjects(Dictionary<EnemyType, JArray> enemyJson) => default; // 0x000000018674E130-0x000000018674E560
		private static Dictionary<WeaponType, List<WeaponData>> ConvertWeaponDataJsonToObjects(Dictionary<WeaponType, JArray> weaponJson) => default; // 0x000000018674E560-0x000000018674E810
		private static Dictionary<StageType, List<StageData>> ConvertStageDataJsonToObjects(Dictionary<StageType, JArray> jsonData) => default; // 0x000000018674E810-0x000000018674EAC0
		private static Dictionary<CharacterType, List<CharacterData>> ConvertCharacterJsonDataToObjects(Dictionary<CharacterType, JArray> jsonData) => default; // 0x000000018674EAC0-0x000000018674ED30
		private static Dictionary<PowerUpType, List<PowerUpData>> ConvertPowerUpJsonData(Dictionary<PowerUpType, JArray> jsonData) => default; // 0x000000018674ED30-0x000000018674EFA0
		private static Dictionary<BgmType, List<MusicData>> ConvertMusicJsonDataToObjects(Dictionary<BgmType, JArray> jsonData) => default; // 0x000000018674EFA0-0x000000018674F210
		private static void CacheEnemyDataStrings(EnemyData enemyData) {} // 0x000000018674F210-0x000000018674F7E0
		private void AdjustAchievementDataWithTypes() {} // 0x000000018674F7E0-0x000000018674F970
		private void AdjustAdventureProgressDataWithTypes() {} // 0x000000018674F970-0x000000018674FBE0
		private void GenerateBestiaryDataForAdventure(AdventureData adventureData) {} // 0x000000018674FBE0-0x0000000186750C60
		private EnemyType? FindEnemyBaseVariant(EnemyType enemyType) => default; // 0x0000000186750C60-0x0000000186750FD0
	}
}
