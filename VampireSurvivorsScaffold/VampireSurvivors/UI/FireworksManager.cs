/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class FireworksManager : MonoBehaviour // TypeDefIndex: 14773
	{
		// Fields
		[SerializeField]
		private Camera _RenderCam; // 0x20
		[SerializeField]
		private RawImage _RenderImage; // 0x28
		[SerializeField]
		private RectTransform _CanvasRect; // 0x30
		private ParticleEmitterManager _particles; // 0x38
		private List<ParticleSystem> _fwEmitters; // 0x40
		private GravityWell _well; // 0x48
		private float _viewportMin; // 0x50
		private float _viewPortMax; // 0x54
		private float _viewportScale; // 0x58
		private int index; // 0x5C
		private static FireworksManager Instance; // 0x00
		private List<GravityWell> _wells; // 0x60
		private List<ParticleSystem> _particleSpawned; // 0x68
		private RenderTexture _currentRT; // 0x70
	
		// Constructors
		public FireworksManager() {} // 0x0000000186893A80-0x0000000186893C90
	
		// Methods
		private void Awake() {} // 0x0000000186890B60-0x0000000186890C00
		private void Start() {} // 0x0000000186890C00-0x00000001868910E0
		public static ParticleSystem CreateRandomFirework(int _index, List<string> frames, RectTransform _origin, float scale = 1f /* Metadata: 0x019771FF */) => default; // 0x00000001868910E0-0x0000000186891170
		public static ParticleSystem CreateFireworkAtPosition(int _index, List<string> frames, Vector2 viewportPos, float scale = 1f /* Metadata: 0x01977203 */) => default; // 0x0000000186891170-0x0000000186891210
		private void SpawnFirework() {} // 0x0000000186891210-0x0000000186891500
		private float GetRTScale() => default; // 0x0000000186891500-0x0000000186891600
		private ParticleSystem MakeFireworkAtPosition(int _index, List<string> frames, Vector2 viewportPos, float scale = 1f /* Metadata: 0x01977207 */) => default; // 0x0000000186891600-0x0000000186892140
		private ParticleSystem MakeRandomFirework(int _index, List<string> frames, RectTransform _origin, float scale = 1f /* Metadata: 0x0197720B */) => default; // 0x0000000186892140-0x0000000186892D60
		public static GravityWell CreateGravityWell(Vector2 viewportPosition, GravityWellConfig conf = null) => default; // 0x0000000186892D60-0x0000000186892DD0
		private GravityWell SpawnGravityWell(Vector2 viewportPosition, GravityWellConfig conf = null) => default; // 0x0000000186892DD0-0x0000000186893070
		public static void Clear() {} // 0x0000000186893070-0x00000001868938B0
		public static Vector2 GetViewportPosition(RectTransform rTrans) => default; // 0x00000001868938B0-0x0000000186893A80
	}
}
