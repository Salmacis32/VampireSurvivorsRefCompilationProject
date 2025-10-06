/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public class SaveSummary // TypeDefIndex: 18173
	{
		// Fields
		private string _timestamp; // 0x20
	
		// Properties
		public PlayerOptionsData Pod { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public byte[] Data { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public string Timestamp { get => default; set {} } // 0x0000000180B15530-0x0000000180B15540 0x00000001866EF510-0x00000001866EF820
		public DateTime RawDateTime { get; private set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		public int _totalGold { get; set; } // 0x0000000181953B80-0x0000000181953B90 0x0000000181953B90-0x0000000181953BA0
		public VampireSurvivors.Data.CharacterType _selectedCharacter { get; set; } // 0x00000001819496B0-0x00000001819496C0 0x00000001819496C0-0x00000001819496D0
		public StageType _selectedStage { get; set; } // 0x0000000181E091A0-0x0000000181E091B0 0x0000000181E091B0-0x0000000181E091C0
		public int _unlockedCharacters { get; set; } // 0x0000000182187010-0x0000000182187020 0x0000000182187020-0x0000000182187030
		public int _achievements { get; set; } // 0x0000000181953C80-0x0000000181953C90 0x0000000181953C90-0x0000000181953CA0
	
		// Constructors
		public SaveSummary() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
