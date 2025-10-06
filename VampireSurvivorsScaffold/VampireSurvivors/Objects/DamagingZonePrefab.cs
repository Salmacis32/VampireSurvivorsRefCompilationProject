/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class DamagingZonePrefab : GameMonoBehaviour // TypeDefIndex: 15071
	{
		// Fields
		[HideInInspector]
		public float damage; // 0x28
		[HideInInspector]
		public float duration; // 0x2C
		[HideInInspector]
		public float respawnCooldown; // 0x30
		[FormerlySerializedAs("timeBeforeEnable")]
		[HideInInspector]
		public float timeBeforeActivation; // 0x34
		[FormerlySerializedAs("activationDelay")]
		[HideInInspector]
		public float hitDelayMillis; // 0x38
		[HideInInspector]
		public bool hasWarningMark; // 0x3C
		[HideInInspector]
		public float warningTime; // 0x40
		[HideInInspector]
		public bool enableGroundVisuals; // 0x44
		[HideInInspector]
		public bool isCircle; // 0x45
		[HideInInspector]
		public float width; // 0x48
		[HideInInspector]
		public float height; // 0x4C
		[HideInInspector]
		public float radius; // 0x50
		[HideInInspector]
		public SpawnType spawnType; // 0x54
		[FormerlySerializedAs("verticalSpawnCounts")]
		[FormerlySerializedAs("horizontalSpawnCount")]
		[HideInInspector]
		public int verticalSpawnCount; // 0x58
		[FormerlySerializedAs("verticalSpawnCount")]
		[HideInInspector]
		public int horizontalSpawnCount; // 0x5C
		[HideInInspector]
		public bool follow; // 0x60
		[HideInInspector]
		public float followSpeed; // 0x64
		[HideInInspector]
		public bool lockX; // 0x68
		[HideInInspector]
		public bool lockY; // 0x69
		[HideInInspector]
		public bool isAnimated; // 0x6A
		[HideInInspector]
		public string frameLocation; // 0x70
		[HideInInspector]
		public int framePadding; // 0x78
		[HideInInspector]
		public float frameScale; // 0x7C
		[HideInInspector]
		public string frameName; // 0x80
		[HideInInspector]
		public int startingFrameNumber; // 0x88
		[HideInInspector]
		public int endingFrameNumber; // 0x8C
		[HideInInspector]
		public int fps; // 0x90
		[HideInInspector]
		public float offsetX; // 0x94
		[HideInInspector]
		public float offsetY; // 0x98
		[HideInInspector]
		public bool usingParticles; // 0x9C
		[HideInInspector]
		public bool setSpeed; // 0x9D
		[HideInInspector]
		public bool setAngle; // 0x9E
		[HideInInspector]
		public bool setRotation; // 0x9F
		[HideInInspector]
		public bool setScale; // 0xA0
		[HideInInspector]
		public DamageZoneFlexible.ZoneAlignment alignment; // 0xA4
		[HideInInspector]
		public int particleQuantity; // 0xA8
		[HideInInspector]
		public float particleFrequency; // 0xAC
		[HideInInspector]
		public float particleLifespan; // 0xB0
		[HideInInspector]
		public float minParticleSpeed; // 0xB4
		[HideInInspector]
		public float maxParticleSpeed; // 0xB8
		[HideInInspector]
		public float minParticleAngle; // 0xBC
		[HideInInspector]
		public float maxParticleAngle; // 0xC0
		[HideInInspector]
		public float minParticleRotation; // 0xC4
		[HideInInspector]
		public float maxParticleRotation; // 0xC8
		[HideInInspector]
		public float minParticleScale; // 0xCC
		[HideInInspector]
		public float maxParticleScale; // 0xD0
		[HideInInspector]
		public bool doParticlesBounce; // 0xD4
		protected float _zoneWidth; // 0xD8
		protected float _zoneHeight; // 0xDC
		protected float _zoneRadius; // 0xE0
		private float2 _originLocation; // 0xE4
		private Unity.Mathematics.Random _random; // 0xEC
	
		// Properties
		protected Camera MainCamera { get => default; } // 0x000000018678FD00-0x000000018678FD10 
	
		// Nested types
		public enum SpawnType // TypeDefIndex: 15070
		{
			TARGETED = 0,
			HORIZONTAL_FIXED = 1,
			HORIZONTAL_RANDOM = 2,
			VERTICAL_FIXED = 3,
			VERTICAL_RANDOM = 4,
			CROSSHATCH = 5
		}
	
		// Constructors
		public DamagingZonePrefab() {} // 0x00000001869E88B0-0x00000001869E8A20
	
		// Methods
		public void SpawnZone(uint seed, float2 originLocation) {} // 0x00000001869E64C0-0x00000001869E6510
		protected virtual void SpawnPattern() {} // 0x00000001869E6510-0x00000001869E68D0
		protected virtual void SpawnCrosshatchPattern() {} // 0x00000001869E68D0-0x00000001869E6FA0
		protected void SetupVisualElement(Vector3 pos, DamageZoneFlexible zone, DamageZoneFlexible.ZoneAlignment newAlignment) {} // 0x00000001869E6FA0-0x00000001869E7790
		protected List<float2> GetSpawnLocations() => default; // 0x00000001869E7790-0x00000001869E7A20
		protected VampireSurvivors.Objects.Characters.CharacterController GetRandomCharacterController() => default; // 0x00000001869E7A20-0x00000001869E7B90
		private float2 GetTargetedSpawnLocation() => default; // 0x00000001869E7B90-0x00000001869E7C70
		protected List<float2> GetVerticalFixedSpawnLocations() => default; // 0x00000001869E7C70-0x00000001869E7F80
		private List<float2> GetVerticalRandomSpawnLocations(float zoneSizeAdjustment) => default; // 0x00000001869E7F80-0x00000001869E8290
		protected List<float2> GetHorizontalFixedSpawnLocations() => default; // 0x00000001869E8290-0x00000001869E85A0
		private List<float2> GetHorizontalRandomSpawnLocations(float zoneSizeAdjustment) => default; // 0x00000001869E85A0-0x00000001869E88B0
	}
}
