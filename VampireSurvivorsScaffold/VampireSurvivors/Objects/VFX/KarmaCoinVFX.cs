/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX
{
	public class KarmaCoinVFX : PoolableMonoBehaviour // TypeDefIndex: 15189
	{
		// Fields
		[SerializeField]
		private float AngelStartSize; // 0x30
		[SerializeField]
		private float KarmaCoinDamageDelay; // 0x34
		public MeshRenderer AngelRenderer; // 0x38
		public ParticleSystem AngelFeathersFX; // 0x40
		[SerializeField]
		private float AngelFeathersFXDelay; // 0x48
		public ParticleSystem HeadsFX; // 0x50
		public ParticleSystem TailsFX; // 0x58
		public ParticleSystem FlareFX; // 0x60
		[SerializeField]
		private float HoldTime; // 0x68
		private VampireSurvivors.Framework.TimerSystem.Timer _holdTimer; // 0x70
		private VampireSurvivors.Framework.TimerSystem.Timer _karmaTimer; // 0x78
		private VampireSurvivors.Framework.TimerSystem.Timer _featherDelayTimer; // 0x80
		private MultiTargetTween _tweenMaterialAnim; // 0x88
		private MultiTargetTween _tweenScale; // 0x90
		public float _animT; // 0x98
		private Action _callback; // 0xA0
	
		// Constructors
		public KarmaCoinVFX() {} // 0x0000000186A83970-0x0000000186A839D0
	
		// Methods
		public void PlaySequence(Action action, float pLuck) {} // 0x0000000186A83080-0x0000000186A838F0
		protected override void OnDestroy() {} // 0x0000000186A838F0-0x0000000186A83970
	}
}
