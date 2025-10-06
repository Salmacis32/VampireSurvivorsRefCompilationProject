/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	public class DlcUtils // TypeDefIndex: 18350
	{
		// Fields
		private Dictionary<VampireSurvivors.Data.CharacterType, DlcType> _characterDlcDict; // 0x10
	
		// Constructors
		public DlcUtils() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public DlcType? GetStageDlcType(StageType stageType, DataManager dataManager) => default; // 0x0000000186737660-0x0000000186737940
		public DlcType? GetBgmDlcType(BgmType bgmType, DataManager dataManager) => default; // 0x0000000186737940-0x0000000186737B70
		public DlcType? GetSFXDlcType(SfxType sfxType, DataManager dataManager) => default; // 0x0000000186737B70-0x0000000186737DE0
		public DlcType? GetCharacterDlcType(VampireSurvivors.Data.CharacterType characterType, DataManager dataManager) => default; // 0x0000000186737DE0-0x0000000186738300
		public DlcType? GetEnemyDlcType(EnemyType enemyType, DataManager dataManager) => default; // 0x0000000186738300-0x0000000186738530
		public string GetPersistentLabel(DlcType dlcType) => default; // 0x0000000186738530-0x00000001867385C0
		public string GetGameplayLabel(DlcType dlcType) => default; // 0x00000001867385C0-0x0000000186738650
	}
}
