/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.NumberTypes;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class MagnetZone : ArcadeSprite // TypeDefIndex: 15089
	{
		// Fields
		private SpriteRenderer _renderer; // 0x58
		private Transform _cachedTransform; // 0x60
		private VampireSurvivors.Objects.Characters.CharacterController _targetCharacter; // 0x68
		public EggFloat Radius; // 0x70
	
		// Properties
		public VampireSurvivors.Objects.Characters.CharacterController TargetCharacter { get => default; } // 0x00000001819A0210-0x00000001819A0220 
	
		// Constructors
		public MagnetZone() {} // 0x00000001869FE470-0x00000001869FE560
	
		// Methods
		private new void Awake() {} // 0x00000001869FDCC0-0x00000001869FDF30
		public void Init(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001869FDF30-0x00000001869FE2F0
		public void RefreshSize() {} // 0x00000001869FE2F0-0x00000001869FE470
	}
}
