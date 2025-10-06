/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class PetInstance // TypeDefIndex: 15082
	{
		// Fields
		public Equipment _baseEquipment; // 0x10
		public Equipment _hiddenWeapon; // 0x18
		public SpriteRenderer _petSprite; // 0x20
		public VampireSurvivors.Objects.Characters.CharacterController Owner; // 0x28
		public float _petOffset; // 0x30
		private Vector2 _currentDirection; // 0x34
		protected float _offsetY; // 0x3C
		protected float _runSpeed; // 0x40
	
		// Constructors
		public PetInstance() {} // 0x00000001869EF680-0x00000001869EF730
	
		// Methods
		private float GetOffsetX() => default; // 0x00000001869EF210-0x00000001869EF240
		private float DistanceSquared(Vector2 vec1, Vector2 vec2) => default; // 0x00000001869EF240-0x00000001869EF280
		public void InternalPetUpdate() {} // 0x00000001869EF280-0x00000001869EF680
	}
}
