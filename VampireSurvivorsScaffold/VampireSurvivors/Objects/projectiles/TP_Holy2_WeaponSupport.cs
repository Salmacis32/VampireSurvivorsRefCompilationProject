/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Holy2_WeaponSupport : MonoBehaviour // TypeDefIndex: 16006
	{
		// Fields
		[SerializeField]
		private Transform _pivotTransform; // 0x20
		[SerializeField]
		private Transform _meshTransform; // 0x28
		[SerializeField]
		private MeshRenderer _mesh; // 0x30
		private static readonly int _InputColor; // 0x00
		private static readonly int _AlphaMul; // 0x04
		private Tween rotTween; // 0x38
		private DG.Tweening.Sequence _windSequence; // 0x40
		private VampireSurvivors.Framework.TimerSystem.Timer sanct1Timer; // 0x48
		private VampireSurvivors.Framework.TimerSystem.Timer sanct2Timer; // 0x50
		private bool canTrigger; // 0x58
		private VampireSurvivors.Framework.TimerSystem.Timer retriggerTimer; // 0x60
		private ParticleSystem _glitchEmitter; // 0x68
		private VampireSurvivors.Framework.TimerSystem.Timer sanct3Timer; // 0x70
		private TP_Holy2_Weapon _trueWeapon; // 0x78
	
		// Constructors
		public TP_Holy2_WeaponSupport() {} // 0x0000000180B18150-0x0000000180B181A0
		static TP_Holy2_WeaponSupport() {} // 0x0000000186EAFF00-0x0000000186EAFF90
	
		// Methods
		public void Initialize() {} // 0x0000000186EAD420-0x0000000186EADB50
		public void Trigger() {} // 0x0000000186EADB50-0x0000000186EAE910
		private void CastComplete() {} // 0x0000000186EAE910-0x0000000186EAEC20
		private void DoSanctuaryEffect() {} // 0x0000000186EAEC20-0x0000000186EAEED0
		private void RosaryDamage() {} // 0x0000000186EAEED0-0x0000000186EAF2A0
		private void MakeEmitters() {} // 0x0000000186EAF2A0-0x0000000186EAFEE0
		public void SetVisible(bool visible) {} // 0x0000000186EAFEE0-0x0000000186EAFF00
	}
}
