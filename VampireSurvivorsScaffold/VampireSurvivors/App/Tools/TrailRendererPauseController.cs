/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	public class TrailRendererPauseController : GameMonoBehaviour // TypeDefIndex: 18555
	{
		// Fields
		private TrailRenderer _trail; // 0x28
		private VampireSurvivors.Framework.TimerSystem.Timer _trailTimeResetTimer; // 0x30
		private float _trailTime; // 0x38
		private float _trailPauseTime; // 0x3C
	
		// Constructors
		public TrailRendererPauseController() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void Init(TrailRenderer trailRenderer, float trailTime) {} // 0x00000001867DE270-0x00000001867DE2D0
		protected override void OnPause() {} // 0x00000001867DE2D0-0x00000001867DE350
		protected override void OnResume() {} // 0x00000001867DE350-0x00000001867DE4C0
		public void Despawn() {} // 0x00000001867DE4C0-0x00000001867DE540
		private void SetTrailTime() {} // 0x00000001867DE540-0x00000001867DE570
	}
}
