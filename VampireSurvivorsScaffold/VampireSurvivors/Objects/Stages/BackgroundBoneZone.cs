/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundBoneZone : BackgroundManager // TypeDefIndex: 15253
	{
		// Fields
		private float _elapsedTime; // 0x80
		private float _elapsedTime2; // 0x84
		private Circle _fixedCircle; // 0x88
		private SpriteRenderer _groundFx; // 0x90
		private List<Transform> _group; // 0x98
		private List<Transform> _group2; // 0xA0
		private Transform _group1Parent; // 0xA8
		private Transform _group2Parent; // 0xB0
		public float _TweenTarget; // 0xB8
		public float _Tween2Target; // 0xBC
		private MultiTargetTween _tween; // 0xC0
		private MultiTargetTween _tween2; // 0xC8
		private MultiTargetTween _tween3; // 0xD0
		private Texture _normalMap; // 0xD8
	
		// Properties
		private VampireSurvivors.Objects.Characters.CharacterController Player { get => default; } // 0x0000000186B00A70-0x0000000186B00AD0 
	
		// Constructors
		public BackgroundBoneZone() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186B00AD0-0x0000000186B00FE0
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B00FE0-0x0000000186B01250
		public override void Create() {} // 0x0000000186B01250-0x0000000186B01670
		public override void OnInitCompleted() {} // 0x0000000186B01670-0x0000000186B01730
		private void AddGroundFx(float x, float y) {} // 0x0000000186B01730-0x0000000186B01B50
		private void AddFlowers(float x, float y) {} // 0x0000000186B01B50-0x0000000186B03000
	}
}
