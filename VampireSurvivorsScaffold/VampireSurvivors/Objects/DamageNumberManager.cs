/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class DamageNumberManager : MonoBehaviour // TypeDefIndex: 15066
	{
		// Fields
		[SerializeField]
		private List<Sprite> _numberSprites; // 0x20
		[SerializeField]
		private int _MaxAmount; // 0x28
		[SerializeField]
		private int SpawnSpam; // 0x2C
		private Blitter _blitter; // 0x30
		private bool _blittersMade; // 0x38
		private List<float> RANDOMS; // 0x40
		private List<float> RANDOMSY; // 0x48
		private int INDEX; // 0x50
		private List<Bob> _bobs; // 0x58
		private List<BobGroup> _groups; // 0x60
		private GameSessionData _session; // 0x68
		private SignalBus _signalBus; // 0x70
		private Bounds _bobMaxBounds; // 0x78
		private Color32 _white; // 0x90
		public int Count; // 0x94
		public Color32 ColorMax; // 0x98
		public Color32 Color010; // 0x9C
		public Color32 Color006; // 0xA0
		public Color32 Color003; // 0xA4
		public Color32 Color000; // 0xA8
		public Color32 ColorNeg; // 0xAC
		private ProfilerMarker updateBobMarker; // 0xB0
		private ProfilerMarker deleteBobsMarker; // 0xB8
		private static int[] digitsArray; // 0x00
	
		// Constructors
		public DamageNumberManager() {} // 0x00000001869D6DF0-0x00000001869D71B0
		static DamageNumberManager() {} // 0x00000001869D71B0-0x00000001869D7270
	
		// Methods
		[Inject]
		private void Construct(GameSessionData session, SignalBus signalBus) {} // 0x00000001865FA5D0-0x00000001865FA680
		private void Awake() {} // 0x00000001869D4E50-0x00000001869D50F0
		private void Start() {} // 0x00000001869D50F0-0x00000001869D5720
		private void OnDestroy() {} // 0x00000001869D5720-0x00000001869D59F0
		private void LateUpdate() {} // 0x00000001869D59F0-0x00000001869D5EE0
		private void MakeBlitters() {} // 0x00000001869D5EE0-0x00000001869D60A0
		private void Spawn(UISignals.CreateDamageNumberSignal sig) {} // 0x00000001869D60A0-0x00000001869D6120
		private void AddBob(Blitter blitter, int num, float rawDamage, Vector3 worldPos, float growth = 2f /* Metadata: 0x0197729C */) {} // 0x00000001869D6120-0x00000001869D64C0
		private void AddBobSpecial(UISignals.CreateSpecialDamageNumberSignal sig) {} // 0x00000001869D64C0-0x00000001869D68D0
		public void AddBob_Number1(Vector3 worldPos) {} // 0x00000001869D68D0-0x00000001869D6B70
		private static int[] SplitIntByDigitsReversed(int number, out int numDigits) {
			numDigits = default;
			return default;
		} // 0x00000001869D6B70-0x00000001869D6CB0
		private Color32 GetDamageColour(float rawDamage) => default; // 0x00000001869D6CB0-0x00000001869D6D00
		private int GetDamageValue(int rawDamage) => default; // 0x00000001869D6D00-0x00000001869D6DF0
	}
}
