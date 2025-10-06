/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EME_CharacterControllerTsunanori : EME_CharacterControllerShowstopper // TypeDefIndex: 17156
	{
		// Fields
		private WeaponType[] standardPassives; // 0x428
		private VampireSurvivors.Data.CharacterType[] kugutsuTypes; // 0x430
		private WeaponType[] kugutsuWeaponBackup; // 0x438
		private int[] kugutsuLevels; // 0x440
		private int kugutsuIndex; // 0x448
		private List<VampireSurvivors.Data.CharacterType> currentFollowers; // 0x450
		private bool _summonAllies; // 0x458
	
		// Constructors
		public EME_CharacterControllerTsunanori() {} // 0x0000000187189560-0x00000001871898C0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187189110-0x0000000187189160
		public override void LevelUp() {} // 0x0000000187189160-0x0000000187189280
		private void MakeKugutsu(int index) {} // 0x0000000187189280-0x0000000187189560
	}
}
