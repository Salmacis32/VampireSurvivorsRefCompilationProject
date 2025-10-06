/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerArengijus : CharacterController // TypeDefIndex: 16930
	{
		// Fields
		private Unity.Mathematics.Random _initializationRng; // 0x3F8
	
		// Properties
		public int SyncedStartingWeaponType { get => default; set {} } // 0x0000000184756700-0x0000000184756710 0x00000001870EF270-0x00000001870EF280
		[Sync]
		public int NameIndex { get; set; } // 0x0000000187106AD0-0x0000000187106AE0 0x0000000187106AE0-0x0000000187106AF0
		[Sync]
		public uint InitializationSeed { get; set; } // 0x0000000187106AF0-0x0000000187106B00 0x0000000187106B00-0x0000000187106B10
	
		// Constructors
		public CharacterControllerArengijus() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F1B */) {} // 0x0000000187106B10-0x0000000187107F90
	}
}
