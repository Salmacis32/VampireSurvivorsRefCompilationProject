/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class FireworksUIManager : MonoBehaviour // TypeDefIndex: 14195
	{
		// Fields
		[SerializeField]
		private ParticleEmitterManager _Fireworks; // 0x20
		[SerializeField]
		private RectTransform _ScreenRect; // 0x28
		[SerializeField]
		private RectTransform _Target; // 0x30
		private SignalBus _signalBus; // 0x38
		private static FireworksUIManager Instance; // 0x00
		private List<ParticleSystem> _particles; // 0x40
		private GravityWell _well; // 0x48
	
		// Constructors
		public FireworksUIManager() {} // 0x0000000186DAE250-0x0000000186DAE350
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x0000000181953C20-0x0000000181953C80
		private void Awake() {} // 0x0000000186DACFB0-0x0000000186DAD050
		private void Test() {} // 0x0000000186DAD050-0x0000000186DAD340
		private void PlayFirework(Vector2 screenPos, List<string> frames, int i, Transform parent) {} // 0x0000000186DAD340-0x0000000186DADC70
		public static void AddGravityWell(GravityWellConfig conf, Vector3 pos, Transform parent) {} // 0x0000000186DADC70-0x0000000186DAE160
		public static Vector2 GetPositionFromCanvas(Vector3 position) => default; // 0x0000000186DAE160-0x0000000186DAE250
	}
}
