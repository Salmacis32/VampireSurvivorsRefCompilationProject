/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.PhaserTweens
{
	public class MultiTargetTween // TypeDefIndex: 18128
	{
		// Fields
		private List<DG.Tweening.Sequence> tweens; // 0x10
		private List<float> delays; // 0x18
		private float _lastUpdateTime; // 0x20
		private TweenCallback _onUpdate; // 0x28
		private bool _isPaused; // 0x30
	
		// Constructors
		public MultiTargetTween() {} // 0x00000001866CF1F0-0x00000001866CF350
	
		// Methods
		public void Add(DG.Tweening.Sequence tween, float delay = 0f /* Metadata: 0x0197873E */) {} // 0x00000001866CE070-0x00000001866CE190
		public void Pause() {} // 0x00000001866CE190-0x00000001866CE390
		public void Play() {} // 0x00000001866CE390-0x00000001866CE530
		public bool IsPaused() => default; // 0x0000000180B1C110-0x0000000180B1C120
		public void Restart() {} // 0x00000001866CE530-0x00000001866CE840
		public void Stop() {} // 0x00000001866CE840-0x00000001866CE850
		public void Kill() {} // 0x00000001866CE850-0x00000001866CEA60
		public bool IsAlive() => default; // 0x00000001866CEA60-0x00000001866CEBC0
		public MultiTargetTween SetAutoKill(bool autoKill) => default; // 0x00000001866CEBC0-0x00000001866CED50
		public DG.Tweening.Sequence GetFirstTween() => default; // 0x00000001866CED50-0x00000001866CEDC0
		public DG.Tweening.Sequence GetLastTween() => default; // 0x00000001866CEDC0-0x00000001866CEE50
		public DG.Tweening.Sequence GetLongestTween() => default; // 0x00000001866CEE50-0x00000001866CF1A0
		public void SetOnUpdate(TweenCallback onUpdate) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		public void OnUpdate() {} // 0x00000001866CF1A0-0x00000001866CF1F0
	}
}
