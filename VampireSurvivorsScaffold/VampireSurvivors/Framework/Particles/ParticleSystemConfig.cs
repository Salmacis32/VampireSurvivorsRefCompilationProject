/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Particles
{
	[Serializable]
	public class ParticleSystemConfig // TypeDefIndex: 18232
	{
		// Fields
		public ParticleSystem.MinMaxCurve _x; // 0x10
		public ParticleSystem.MinMaxCurve _y; // 0x30
		[CanBeNull]
		public List<string> _frame; // 0x50
		public int _fps; // 0x58
		public ParticleSystem.MinMaxCurve _angle; // 0x60
		public int _angleSteps; // 0x80
		public ParticleSystem.MinMaxCurve? _speed; // 0x88
		public ParticleSystem.MinMaxCurve? _speedX; // 0xB0
		public ParticleSystem.MinMaxCurve? _speedY; // 0xD8
		public int? _quantity; // 0x100
		public float? _frequency; // 0x108
		public ParticleSystem.MinMaxCurve _rotate; // 0x110
		public ParticleSystem.MinMaxCurve _lifespan; // 0x130
		public ParticleSystem.MinMaxCurve? _alpha; // 0x150
		public Easing _alphaEase; // 0x178
		public ParticleSystem.MinMaxCurve? _scale; // 0x180
		public ParticleSystem.MinMaxCurve? _scaleX; // 0x1A8
		public ParticleSystem.MinMaxCurve? _scaleY; // 0x1D0
		public ScaleMode? _scaleMode; // 0x1F8
		public Easing _scaleEase; // 0x200
		public ParticleSystem.MinMaxCurve _gravity; // 0x208
		public uint? _tint; // 0x228
		public uint[] _tintRandom; // 0x230
		public bool _on; // 0x238
		public BlendMode? _blendMode; // 0x23C
		public ParticleSystem.MinMaxCurve? _bounce; // 0x248
		public Rect? _bounds; // 0x270
		public Bounds? _boundsWorld; // 0x284
		public bool? _collideTop; // 0x2A0
		public bool? _collideBottom; // 0x2A2
		public bool? _collideLeft; // 0x2A4
		public bool? _collideRight; // 0x2A6
		[CanBeNull]
		public EmitZone _emitZone; // 0x2A8
		public ParticleSystemSimulationSpace? _simulationSpace; // 0x2B0
		public bool _circleCollision; // 0x2B8
		public float _circleCollisionRadius; // 0x2BC
	
		// Properties
		public string Texture { get; } // 0x000000018670AA90-0x000000018670AAA0 
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 18231
		{
			Initial = 0,
			Lifetime = 1
		}
	
		// Constructors
		public ParticleSystemConfig() {} // Dummy constructor
		public ParticleSystemConfig(string texture) {} // 0x000000018670AAA0-0x000000018670B2A0
	}
}
