/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class UITPDeath : MonoBehaviour // TypeDefIndex: 17428
	{
		// Fields
		[SerializeField]
		public Image deathMask; // 0x20
		[SerializeField]
		public List<Image> deathCape; // 0x28
		[SerializeField]
		public List<Image> glitch; // 0x30
		[SerializeField]
		public Image leftHand; // 0x38
		[SerializeField]
		public Image rightHand; // 0x40
		[SerializeField]
		public Image leftCracks; // 0x48
		[SerializeField]
		public Image rightCracks; // 0x50
		[SerializeField]
		public Image leftEye; // 0x58
		[SerializeField]
		public Image rightEye; // 0x60
		[SerializeField]
		public List<Image> leftJoints; // 0x68
		[SerializeField]
		public List<Image> rightJoints; // 0x70
		private MultiTargetTween _armTween; // 0x78
		[NonSerialized]
		public int glitchIndex; // 0x80
		[NonSerialized]
		public float glitchYOffset; // 0x84
		[NonSerialized]
		public float leftHandOffset; // 0x88
		[NonSerialized]
		public float rightHandOffset; // 0x8C
		[NonSerialized]
		public bool leftHandScale; // 0x90
		[NonSerialized]
		public bool rightHandScale; // 0x91
		private float _crawlTimer; // 0x94
	
		// Constructors
		public UITPDeath() {} // 0x00000001872BE910-0x00000001872BEA80
	
		// Methods
		private void Awake() {} // 0x00000001872BC190-0x00000001872BC210
		private void Start() {} // 0x00000001872BC210-0x00000001872BCC50
		private void StartMovingArms() {} // 0x00000001872BCC50-0x00000001872BD1F0
		protected void Update() {} // 0x00000001872BD1F0-0x00000001872BDE60
		private void UpdateJoints(Image arm, List<Image> armSprites, bool shouldScale) {} // 0x00000001872BDE60-0x00000001872BE620
		private float FindNextJointT(float2 start, float2 end, float2 lastJointPos, float lastJointT, float desiredDistance, float iterationStep = -0.01f /* Metadata: 0x019785A3 */) => default; // 0x00000001872BE620-0x00000001872BE770
		private float2 ArmSample(float2 start, float2 end, float t) => default; // 0x00000001872BE770-0x00000001872BE8F0
		private void OnDestroy() {} // 0x00000001872BE8F0-0x00000001872BE910
	}
}
