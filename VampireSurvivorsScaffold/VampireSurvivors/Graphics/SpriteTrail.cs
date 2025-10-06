/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class SpriteTrail : GameMonoBehaviour // TypeDefIndex: 14538
	{
		// Fields
		[SerializeField]
		public SpriteRenderer _MainSprite; // 0x28
		[SerializeField]
		private int _MaxHistory; // 0x30
		[SerializeField]
		private List<string> _Tints; // 0x38
		[SerializeField]
		public float _DefaultGhostAlpha; // 0x40
		[SerializeField]
		public float _AlphaDecayPerGhost; // 0x44
		[SerializeField]
		private Vector2 _ScaleModifier; // 0x48
		[SerializeField]
		private Material _MaterialOverride; // 0x50
		[SerializeField]
		[Tooltip("Will make all ghosts use the same latest angle")]
		private bool _MatchTargetAngle; // 0x58
		[SerializeField]
		private bool _UsePauseSystem; // 0x59
		[SerializeField]
		private bool _AutoUpdateDepth; // 0x5A
		public static GameObject TrailContainer; // 0x00
		private List<Vector3> _positionHistory; // 0x60
		private List<Vector3> _angleHistory; // 0x68
		private List<Vector3> _scaleHistory; // 0x70
		private List<SpriteRenderer> _ghosts; // 0x78
		private int _historyIndex; // 0x80
		private bool _skipOne; // 0x84
		private int _knownHistory; // 0x88
		private static int _fps; // 0x08
		private static double _frameTime; // 0x10
		private double _frameTimeMS; // 0x90
		private double _elapsed; // 0x98
		private static ProfilerMarker _markerOnEnableBase; // 0x18
		private static ProfilerMarker _markerOnEnableGhosts; // 0x20
		private static ProfilerMarker _markerOnDisableBase; // 0x28
		private static ProfilerMarker _markerOnDisableGhosts; // 0x30
	
		// Properties
		public bool AutoUpdateDepth { get => default; set {} } // 0x000000018277C8F0-0x000000018277C900 0x0000000186C3BC80-0x0000000186C3BC90
	
		// Constructors
		public SpriteTrail() {} // 0x00000001871A89C0-0x00000001871A8D60
		static SpriteTrail() {} // 0x00000001871A8D60-0x00000001871A8ED0
	
		// Methods
		protected override void OnEnable() {} // 0x00000001871A4D40-0x00000001871A5080
		protected override void OnDisable() {} // 0x00000001871A5080-0x00000001871A52B0
		protected override void OnDestroy() {} // 0x00000001871A52B0-0x00000001871A5360
		public void Start() {} // 0x00000001871A5360-0x00000001871A55A0
		private void ResetHistory() {} // 0x00000001871A55A0-0x00000001871A55B0
		public int GetMaxHistory() => default; // 0x0000000181953B80-0x0000000181953B90
		public void SetMaxHistory(int max) {} // 0x00000001871A55B0-0x00000001871A55C0
		public void SetMaskInteraction(SpriteMaskInteraction interaction) {} // 0x00000001871A55C0-0x00000001871A57A0
		public void InitialiseGhosts(bool expandExisting = false /* Metadata: 0x0197716A */) {} // 0x00000001871A57A0-0x00000001871A5F10
		public void ResetGhostValues() {} // 0x00000001871A5F10-0x00000001871A60A0
		private void LateUpdate() {} // 0x00000001871A60A0-0x00000001871A6B60
		public void Reset() {} // 0x00000001871A6B60-0x00000001871A79A0
		public SpriteTrail SetSprite(int index, Sprite s) => default; // 0x00000001871A79A0-0x00000001871A7A40
		public SpriteTrail SetTint(int index, Color c) => default; // 0x00000001871A7A40-0x00000001871A7B70
		public SpriteTrail SetAlpha(int index, float a) => default; // 0x00000001871A7B70-0x00000001871A7E60
		public SpriteTrail SetTint(int index, string c) => default; // 0x00000001871A7E60-0x00000001871A7FA0
		public Vector3 GetPosition(int index) => default; // 0x00000001871A7FA0-0x00000001871A8040
		public SpriteTrail SetPosition(int index, Vector3 position) => default; // 0x00000001871A8040-0x00000001871A80E0
		public SpriteTrail SetColors(List<string> colors) => default; // 0x00000001871A80E0-0x00000001871A82E0
		public SpriteTrail SetAlphas(List<float> alphas) => default; // 0x00000001871A82E0-0x00000001871A8570
		public SpriteTrail setVisible(bool b) => default; // 0x00000001871A8570-0x00000001871A8710
		public void UpdateDepth() {} // 0x00000001871A8710-0x00000001871A88D0
		public SpriteRenderer GetTrailSprite(int index) => default; // 0x00000001871A88D0-0x00000001871A8950
		public int GetGhostCount() => default; // 0x00000001871A8950-0x00000001871A89A0
		private int GetHistoryIndex(int index) => default; // 0x00000001871A89A0-0x00000001871A89C0
	}
}
